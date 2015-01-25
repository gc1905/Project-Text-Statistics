/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         UserInterface.cs
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
using ProjectTextStatistics.Engine;

namespace ProjectTextStatistics.UI {
    /// <summary>
    /// Interface for user interface functions required by application.
    /// </summary>
    interface UserInterface {
        /// <summary>
        /// Presents error message in User Interface.
        /// </summary>
        /// <param name="message">Message to present</param>
        void ShowErrorMessage(AnalysisResult message);

        /// <summary>
        /// Presents the results of directory analysis in User Interface.
        /// </summary>
        /// <param name="result">Message to present</param>
        void ShowSuccededResult(AnalysisResult result);
    }
}
