/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         RegexFileCollector.cs
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
    /// Represents file collection strategy based on regular expression
    /// matching.
    /// </summary>
    class RegexFileCollector : FileCollectorStrategy {
        /// <summary>
        /// RegexFileCollector constructor.
        /// </summary>
        /// <param name="scope">Scope of file collection<seealso cref="member"/></param>
        /// <param name="rule">Regular expressin rule for pattern matching. Reference: 
        /// http://msdn.microsoft.com/en-us/library/az24scfc%28v=vs.110%29.aspx </param>
        public RegexFileCollector(FileCollectorScope scope, string rule) : base(scope, rule) { }

        /// <summary>
        /// Collects all files located under specified path and stores them in <seealso cref="FileComponent"/> object.
        /// Only results matching specified regular expression are gathered. Scope of collection depends on current 
        /// <seealso cref="Scope"/> state.
        /// <para>Reference of regular expression language: http://msdn.microsoft.com/en-us/library/az24scfc%28v=vs.110%29.aspx </para>
        /// </summary>
        /// <param name="path">Top directory path</param>
        /// <returns>Files located under specifiad path</returns>
        public override FileComponent GetFilesFromDirectory(string path) {
            string[] filePaths = DirectoryWrapper.GetFiles(path, "*", TranslateScope(scope));
            string[] filteredFilePaths = filterPathsByRegex(filePaths);
            return FileComponentFactory.ConstructComponents(filteredFilePaths);
        }

        private string[] filterPathsByRegex(string[] filePaths) {
            ListWrapper<string> mathes = new ListWrapper<string>();
            foreach (string filePath in filePaths) {
                if (RegexWrapper.IsMatch(filePath, this.rule)) {
                    mathes.AddBack(filePath);
                }
            }
            return mathes.ToArray();
        }
    }
}
