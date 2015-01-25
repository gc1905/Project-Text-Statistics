/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         DirectoryWrapper.cs
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
using System.IO;

namespace ProjectTextStatistics.SystemWrappers {
    /// <summary>
    /// Abstraction to platform dependand Search Option.
    /// </summary>
    enum DirectorySearchOption {
        AllDirectories,
        TopDirectoryOnly
    };

    /// <summary>
    /// Directory library wrapper provides abstraction from platform dependant directory utilities.
    /// </summary>
    static class DirectoryWrapper {
        public static bool IsDirectoryExists(string path) {
            return Directory.Exists(path);
        }

        public static String[] GetFiles(string path, string rule = "*", DirectorySearchOption option = DirectorySearchOption.AllDirectories) {
            return Directory.GetFiles(path, rule, TranslateOption(option));
        }

        private static SearchOption TranslateOption(DirectorySearchOption option) {
            switch (option) {
                case DirectorySearchOption.AllDirectories:
                    return SearchOption.AllDirectories;
                case DirectorySearchOption.TopDirectoryOnly:
                    return SearchOption.TopDirectoryOnly;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
