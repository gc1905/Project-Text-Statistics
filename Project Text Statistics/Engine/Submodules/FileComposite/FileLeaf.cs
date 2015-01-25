/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         FileLeaf.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using ProjectTextStatistics.SystemWrappers;

namespace ProjectTextStatistics.Engine.Submodules.FileComposite {
    /// <summary>
    /// Represents a single instance of File Component object.
    /// </summary>
    /// <remarks>
    /// Carries information about exactly one file.
    /// </remarks>
    class FileLeaf : FileComponent {
        internal string path;
        private const string WordCountRegex = @"\b\w+\b";

        internal FileLeaf(string path) {
            this.path = path;
        }

        /// <summary>
        /// Number of text lines in a file
        /// </summary>
        public override int Lines {
            get  {
                return FileWrapper.ReadLines(this.path).Length;
            }
        }

        /// <summary>
        /// Path to a file
        /// </summary>
        public override string Path {
            get {
                return this.path;
            }
        }

        /// <summary>
        /// Number of words in a file
        /// </summary>
        public override int Words {
            get {
                string content = ReadContent();
                return RegexWrapper.CountMatches(content, WordCountRegex);
            }
        }

        /// <summary>
        /// Number of characters in a file
        /// </summary>
        public override int Characters {
            get {
                string content = ReadContent();
                return content.Length;
            }
        }

        /// <summary>
        /// Returns a one element array containing self reference. Used for compatibility.
        /// </summary>
        /// <returns>One element array containing self reference</returns>
        public override FileComponent[] DisassemblyIntoLeafs() {
            return new FileComponent[] {this};
        }

        private string ReadContent() {
            return FileWrapper.ReadAllText(this.path);
        }
    }
}
