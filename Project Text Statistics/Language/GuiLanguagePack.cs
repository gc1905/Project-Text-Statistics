/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         GuiLanguagePack.cs
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
    /// Interface for GUI language pack.
    /// </summary>
    /// <remarks>
    /// Contains string that are visible to user.
    /// </remarks>
    public interface GuiLanguagePack {
        string ErrorBoxName { get; }
        string NoDirectoryError { get; }
        string NoRuleError { get; }
        string EnterDirectoryLabel { get; }
        string AnalysisScopeGroupLabel { get; }
        string TopLevelScopeLabel { get; }
        string AllLevelsScopeLabel { get; }
        string NameFilterLabel { get; }
        string RegexFilterLabel { get; }
        string StartButtonLabel { get; }
        string WindowApplicationLabel { get; }
    }
}
