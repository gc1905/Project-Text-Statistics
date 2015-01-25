/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         AnalysisResult.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using ProjectTextStatistics.SystemWrappers;

namespace ProjectTextStatistics.Engine {
    ///<summary>
    ///Analysis Result class represents the output of text analysis.
    ///</summary>
    public abstract class AnalysisResult {
        private string summary;

        /// <summary>
        /// AnalysisResult contructor
        /// </summary>
        /// <param name="summary">Output of the analyzer passed from analyzer to user interface.</param>
        public AnalysisResult(string summary) {
            this.summary = summary;
        }
        
        /// <summary>
        /// Formated string data passed from analyzer to user interface.
        /// </summary>
        public string Summary {
            get {
                return this.summary;
            }
        }

        /// <summary>
        /// Indicates if object carry analysis result or error message.
        /// </summary>
        /// <returns>true for succeded result, false for error message</returns>
        public abstract bool Succeded();
    }
}
