/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         SimpleFileCollector.cs
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

namespace ProjectTextStatistics.Engine.Submodules {
    /// <summary>
    /// Represents file collection strategy based on simple pattern 
    /// matching
    /// </summary>
    class SimpleFileCollector : FileCollectorStrategy {
        /// <summary>
        /// SimpleFileCollector constructor.
        /// </summary>
        /// <param name="scope">Scope of file collection<seealso cref="member"/></param>
        /// <param name="rule">Rule rule for pattern matching. Can be a combination of literal and wildcard characters, 
        /// but doesn't support regular expressions.</param>
        public SimpleFileCollector(FileCollectorScope scope = FileCollectorScope.TopDirectoryOnly, string rule = "*") : base(scope, rule) { }

        /// <summary>
        /// Collects all files located under specified path and stores them in <seealso cref="FileComponent"/> object.
        /// Only results matching specified patern are gathered. Scope of collection depends on current 
        /// <seealso cref="Scope"/> state.
        /// </summary>
        /// <param name="path">Top directory path</param>
        /// <returns>Files located under specifiad path</returns>
        public override FileComponent GetFilesFromDirectory(string path) {
            string[] filePaths = DirectoryWrapper.GetFiles(path, this.rule, TranslateScope(this.scope));
            return FileComponentFactory.ConstructComponents(filePaths);
        }
    }
}
