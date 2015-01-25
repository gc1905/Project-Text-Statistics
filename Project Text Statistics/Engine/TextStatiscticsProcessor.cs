/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         TextStatisticsProcessor.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;
using ProjectTextStatistics.Engine;
using ProjectTextStatistics.Engine.Submodules;
using ProjectTextStatistics.Engine.Submodules.FileComposite;
using ProjectTextStatistics.Engine.Submodules.Presenter;
using ProjectTextStatistics.Language;

namespace ProjectTextStatistics.Engine {
    /// <summary>
    /// Class represents instance of statistics processor engine.
    /// </summary>
    /// <remarks>
    /// Contains information about file collection strategy and presenter plugin.
    /// </remarks>
    class TextStatiscticsProcessor {
        private FileCollectorStrategy fileCollector;
        private Presenter presenter;

        /// <summary>
        /// TextStatiscticsProcessor constructor.
        /// </summary>
        /// <param name="fileCollector">Initial strategy for file collecting</param>
        /// <param name="language">Language pack for presenter module</param>
        public TextStatiscticsProcessor(FileCollectorStrategy fileCollector, PresenterLanguagePack language) {
            this.fileCollector = fileCollector;
            this.presenter = new TextualPresenter(language);
        }

        /// <summary>
        /// Strategy for file collection.
        /// </summary>
        public FileCollectorStrategy CollectorStrategy {
            get {
                return this.fileCollector;
            }
            set {
                this.fileCollector = value;
            }
        }

        /// <summary>
        /// Performs complete analysis of files stored under specified directory. Depends on <seealso cref="CollectorStrategy"/>.
        /// Catches all exceptions caught during program runtime.
        /// </summary>
        /// <param name="path">Root directory for analysis</param>
        /// <returns>Result of directory analysis. Can be either error message or a summary.</returns>
        public AnalysisResult RunAnalysis(string path) {
            try {
                FileComponent files = fileCollector.GetFilesFromDirectory(path);
                return this.presenter.RunAnalysis(files);
            } catch (Exception e) {
                return this.presenter.CreateExceptionMessage(e);
            }
        }
    }
}
