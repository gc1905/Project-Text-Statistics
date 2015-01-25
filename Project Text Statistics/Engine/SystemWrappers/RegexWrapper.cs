/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         RegexWrapper.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System.Text.RegularExpressions;
using System;

namespace ProjectTextStatistics.SystemWrappers {
    /// <summary>
    /// Regular Expression library wrapper provides abstraction from platform dependant regex processing utilities.
    /// </summary>
    static class RegexWrapper {
        static public bool IsMatch(string sentence, string regex) {
            try {
                Regex regexObject = new Regex(regex);
                return regexObject.IsMatch(sentence);
            } catch (ArgumentException e) {
                throw new RegexArgumentException(e.Message, e);
            }
        }

        static public int CountMatches(string sentence, string regex) {
            try {
                return Regex.Matches(sentence, regex).Count;
            } catch (ArgumentException e) {
                throw new RegexArgumentException(e.Message, e);
            }
        }
    }

    class RegexArgumentException : ArgumentException {
        public RegexArgumentException(string s, Exception e) : base(s, e) { }
    }
}
