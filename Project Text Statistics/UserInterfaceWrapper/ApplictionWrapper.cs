/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         ApplicationWrapper.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using ProjectTextStatistics.Engine;
using ProjectTextStatistics.Engine.Submodules;
using ProjectTextStatistics.UI;
using ProjectTextStatistics.Language;

namespace ProjectTextStatistics.UI {
    /// <summary>
    /// Wraps application engine with user interface.
    /// </summary>
    class ApplicationWrapper {
        private TextStatiscticsProcessor engine;
        private UserInterface ui;
        private static ApplicationWrapper instance;

        private ApplicationWrapper() {
            PolishLanguagePack language = new PolishLanguagePack();
            engine = new TextStatiscticsProcessor(new SimpleFileCollector(), language);
            this.ui = new GUI(language);
        }

        /// <summary>
        /// Reference to User Interface object representation.
        /// </summary>
        public UserInterface UI {
            get {
                return ui;
            }
        }

        /// <summary>
        /// Gets an instance of singleton object.
        /// </summary>
        /// <returns>Reference to singleton instance</returns>
        public static ApplicationWrapper GetSingleton() {
            if (instance == null) {
                instance = new ApplicationWrapper();
            }
            return instance;
        }

        /// <summary>
        /// Sets a Simple Collector Strategy for directory analysis.
        /// </summary>
        /// <param name="scope">Scope of directory analysis.</param>
        /// <param name="matchRule">Rule for pattern matching. Can be a combination of literal and wildcard characters.</param>
        public void SetSimpleCollector(FileCollectorScope scope, string matchRule = "*") {
            this.engine.CollectorStrategy = new SimpleFileCollector(scope, matchRule);
        }

        /// <summary>
        /// Sets a Regular Expression Collector Strategy for directory analysis.
        /// </summary>
        /// <param name="scope">Scope of directory analysis.</param>
        /// <param name="matchRule">Regular Expression. Reference: 
        /// http://msdn.microsoft.com/en-us/library/az24scfc%28v=vs.110%29.aspx </param>
        public void SetRegexCollector(FileCollectorScope scope, string matchRule) {
            this.engine.CollectorStrategy = new RegexFileCollector(scope, matchRule);
        }

        /// <summary>
        /// Runs the test analysis and presents the results in user interface.
        /// </summary>
        /// <param name="path">Root directory path for analysis</param>
        public void PerformTextAnalysis(string path) {
            ShowResult(this.engine.RunAnalysis(path));
        }

        private void ShowResult(AnalysisResult result) {
            if (result.Succeded()) {
                this.ui.ShowSuccededResult(result);
            } else {
                this.ui.ShowErrorMessage(result);
            }
        }
    }
}
