/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         Presenter.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using ProjectTextStatistics.Engine.Submodules.FileComposite;
using System;

namespace ProjectTextStatistics.Engine.Submodules.Presenter {
    /// <summary>
    /// Interface for processor's Presenter plugin.
    /// </summary>
    /// <remarks>
    /// Used for formating analyse result and messages into format accepted by user interface.
    /// </remarks>
    interface Presenter {
        /// <summary>
        /// Files from latest analysis.
        /// </summary>
        FileComponent Files { get; set; }

        /// <summary>
        /// Formats user interface dependant error mesage depending on caught exception.
        /// </summary>
        /// <param name="e">Exception caught during program runtime.</param>
        /// <returns>User interface dependant message.</returns>
        AnalysisResult CreateExceptionMessage(Exception e);

        /// <summary>
        /// Formats user interface dependant result of file analysis.
        /// </summary>
        /// <param name="files">File data to process</param>
        /// <returns>User interface dependant message</returns>
        AnalysisResult RunAnalysis(FileComponent files);
    }
}
