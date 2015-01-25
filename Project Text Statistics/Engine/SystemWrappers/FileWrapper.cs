/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         FileWrapper.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System.IO;

namespace ProjectTextStatistics.SystemWrappers {
    /// <summary>
    /// File library wrapper provides abstraction from platform dependant file processing utilities.
    /// </summary>
    static class FileWrapper {
        public static string[] ReadLines(string path) {
            return File.ReadAllLines(path);
        }

        public static string ReadAllText(string path) {
            return File.ReadAllText(path);
        }
    }
}
