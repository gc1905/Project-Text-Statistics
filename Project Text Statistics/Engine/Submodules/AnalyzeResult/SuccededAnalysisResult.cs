/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         SuccededAnalysisResult.cs
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
    ///Represents successful text analysis and carries formatted results.
    ///<summary>
    class SuccededAnalysisResult : AnalysisResult {
        /// <summary>
        /// SuccededAnalysisResult constructor.
        /// </summary>
        /// <param name="summary">Output of the analyzer passed from analyzer to user interface.</param>
        public SuccededAnalysisResult(string summary) : base(summary) { }

        /// <summary>
        /// Indicates if object carry analysis result or error message.
        /// </summary>
        /// <returns>true</returns>
        public override bool Succeded() {
            return true;
        }
    }
}
