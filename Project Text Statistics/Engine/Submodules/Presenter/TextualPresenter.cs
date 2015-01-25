/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         TextualPresenter.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using ProjectTextStatistics.SystemWrappers;
using ProjectTextStatistics.Engine.Submodules.FileComposite;
using ProjectTextStatistics.Language;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ProjectTextStatistics.Engine.Submodules.Presenter {
    /// <summary>
    /// Processor's Presenter plugin adapted for textual user interface.
    /// </summary>
    class TextualPresenter : Presenter {
        private FileComponent files;
        private PresenterLanguagePack language;
        private const string newLine = "\r\n";

        /// <summary>
        /// TextualPresenter constructor.
        /// </summary>
        /// <param name="language">Language pack.</param>
        public TextualPresenter(PresenterLanguagePack language) {
            this.language = language;
        }

        /// <summary>
        /// Files from latest analysis.
        /// </summary>
        public FileComponent Files {
            get {
                return this.files;
            }
            set {
                this.files = value;
            }
        }

        /// <summary>
        /// Formats user interface dependant error mesage depending on caught exception.
        /// </summary>
        /// <param name="e">Exception caught during program runtime.</param>
        /// <returns>User interface dependant message.</returns>
        public AnalysisResult CreateExceptionMessage(Exception e) {
            string message;
            if (e is UnauthorizedAccessException) {
                message = language.AccessDeniedException;
            } else if (e is DirectoryNotFoundException) {
                message = language.DirectoryNotFoundException;
            } else if (e is IOException) {
                message = language.NotADirectoryException;
            } else if (e is EmptyFilePathArrayException) {
                message = language.EmptyDirectoryException;
            } else if (e is RegexArgumentException) {
                message = language.RegexFormatException;
            } else {
                message = language.UnexpectedException;
            }
            return new FailedAnalysisResult(message, e);
        }

        /// <summary>
        /// Formats user interface dependant result of file analysis.
        /// </summary>
        /// <param name="files">File data to process</param>
        /// <returns>User interface dependant message</returns>
        public AnalysisResult RunAnalysis(FileComponent files) {
            this.files = files;
            return new SuccededAnalysisResult(FormatReport());
        }

        private string FormatReport() {
            StringBuilderWrapper stringBuilder = new StringBuilderWrapper();
            stringBuilder.Append(FormatSummaryReport()).Append(newLine);
            stringBuilder.Append(FormatReportForAllFiles());
            return stringBuilder.ToString();
        }

        private string FormatSummaryReport() {
            StringBuilderWrapper stringBuilder = new StringBuilderWrapper();
            stringBuilder.Append(this.language.SummaryHeader).Append(newLine);
            stringBuilder.Append("  ").Append(language.FileCountLabel).Append(this.Files.DisassemblyIntoLeafs().Length).Append(newLine);
            stringBuilder.Append(FormatStatisticsField(this.files)).Append(newLine);
            return stringBuilder.ToString();
        }

        private string FormatReportForAllFiles() {
            StringBuilderWrapper stringBuilder = new StringBuilderWrapper();
            FileComponent[] disassembledFiles = files.DisassemblyIntoLeafs();
            foreach (var file in disassembledFiles) {
                stringBuilder.Append(language.FileAnalyzePrefix).Append(file.Path).Append(newLine);
                stringBuilder.Append(FormatStatisticsField(file)).Append(newLine);
            }
            return stringBuilder.ToString();
        }

        private string FormatStatisticsField(FileComponent file) {
            StringBuilderWrapper stringBuilder = new StringBuilderWrapper();
            int lines, words, characters;
            try {
                lines = file.Lines;
                words = file.Words;
                characters = file.Characters;
            } catch {
                stringBuilder.Append(language.CanNotAccessFile).Append(newLine);
                return stringBuilder.ToString();
            }

            stringBuilder.Append("  ").Append(language.LineLengthLabel).Append(lines).Append(newLine);
            stringBuilder.Append("  ").Append(language.WordLengthLabel).Append(words).Append(newLine);
            stringBuilder.Append("  ").Append(language.CharacterLengthLabel).Append(characters).Append(newLine);
            return stringBuilder.ToString();
        }
    }
}
