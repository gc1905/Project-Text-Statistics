/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         PresenterLanguagePack.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

namespace ProjectTextStatistics.Language {
    /// <summary>
    /// Interface for Presenter plugin language pack.
    /// </summary>
    /// <remarks>
    /// Contains string that are visible to users.
    /// </remarks>
    interface PresenterLanguagePack {
        string SummaryHeader { get; }
        string FileAnalyzePrefix { get; }
        string FileCountLabel { get; }
        string CharacterLengthLabel { get; }
        string LineLengthLabel { get; }
        string WordLengthLabel { get; }
        string CanNotAccessFile { get; }

        string AccessDeniedException { get; }
        string DirectoryNotFoundException { get; }
        string NotADirectoryException { get; }
        string UnexpectedException { get; }
        string EmptyDirectoryException { get; }
        string RegexFormatException { get; }
    }
}
