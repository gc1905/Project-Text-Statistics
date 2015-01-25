/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         FileComposite.cs
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
    ///  Represents the composite of File Component objects.
    /// </summary>
    /// <remarks>
    /// Carries information about one or more files.
    /// </remarks>
    class FileComposite : FileComponent {
        private FileComponent[] components;

        /// <summary>
        /// FileComposite constructor.
        /// </summary>
        /// <param name="paths">Array of file paths</param>
        internal FileComposite(string[] paths) {
            components = new FileComponent[paths.Length];
            for(int i = 0; i < paths.Length; i++) {
                components[i] = new FileLeaf(paths[i]);
            }
        }

        /// <summary>
        /// Cumulative number of text lines
        /// </summary>
        public override int Lines  {
            get {
                int sum = 0;
                foreach (var component in this.components) {
                    sum += component.Lines;
                }
                return sum;
            }
        }

        /// <summary>
        /// Path to all files separated by comma
        /// </summary>
        public override string Path {
            get {
                StringBuilderWrapper builder = new StringBuilderWrapper();
                foreach (var component in this.components) {
                    builder.Append(component.Path + " ");
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// Cumulative number of words
        /// </summary>
        public override int Words {
            get {
                int sum = 0;
                foreach (var component in this.components) {
                    sum += component.Words;
                }
                return sum;
            }
        }

        /// <summary>
        /// Cumulative number of characters
        /// </summary>
        public override int Characters {
            get {
                int sum = 0;
                foreach (var component in this.components) {
                    sum += component.Characters;
                }
                return sum;
            }
        }

        /// <summary>
        /// Converts into an array of undividable components (<seealso cref="FileLeaf"/>).
        /// </summary>
        /// <returns>Array of undividable (most promitive) components</returns>
        public override FileComponent[] DisassemblyIntoLeafs() {
            ListWrapper<FileComponent> leafs = new ListWrapper<FileComponent>();
            foreach (var component in components) {
                leafs.Append(component.DisassemblyIntoLeafs());
            }
            return leafs.ToArray();
        }
    }
}
