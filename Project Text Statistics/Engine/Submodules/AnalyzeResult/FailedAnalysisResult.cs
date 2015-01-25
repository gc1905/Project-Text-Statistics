/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         FailedAnalysisResult.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectTextStatistics.Engine {
    ///<summary>
    ///Analysis Result class represents the output of text analysis.
    ///<summary>
    class FailedAnalysisResult : AnalysisResult {
        private Exception exception;

        /// <summary>
        /// FailedAnalysisResult default constructor.
        /// </summary>
        /// <param name="summary">Output of the analyzer passed from analyzer to user interface.</param>
        /// <seealso cref="AnalysisResult.AnalysisResult"/>
        public FailedAnalysisResult(string summary) : base(summary) {
            this.exception = null;
        }

        /// <summary>
        /// FailedAnalysisResult constructor.
        /// </summary>
        /// <param name="summary">Output of the analyzer passed from analyzer to user interface.</param>
        /// <param name="exception">Exception that caused the failure.</param>
        /// <seealso cref="AnalysisResult.AnalysisResult"/>
        public FailedAnalysisResult(string summary, Exception exception) : base(summary) {
            this.exception = exception;
        }

        /// <summary>
        /// Indicates if object carry analysis result or error message.
        /// </summary>
        /// <returns>false</returns>
        public override bool Succeded() {
            return false;
        }
    }
}
