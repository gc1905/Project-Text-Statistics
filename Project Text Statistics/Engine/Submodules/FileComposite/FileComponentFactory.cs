/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         FileComponentFactory.cs
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

namespace ProjectTextStatistics.Engine.Submodules.FileComposite {
    /// <summary>
    /// Used for creation of File Components implemented by composite desing 
    /// pattern.
    /// </summary>
    static class FileComponentFactory {
        /// <summary>
        /// Contructs <seealso cref="FileComponent"/> object from an array of file paths.
        /// <para>Throws <seealso cref="EmptyFilePathArrayException"/> when empty array is passed as parameter</para>
        /// </summary>
        /// <param name="paths">Array of file paths</param>
        /// <returns>Component representation of files</returns>
        public static FileComponent ConstructComponents(string[] paths) {
            if (paths.Length < 1) {
                throw new EmptyFilePathArrayException();
            } else if (paths.Length == 1) {
                return new FileLeaf(paths[0]);
            } else {
                return new FileComposite(paths);
            }
        }
    }

    /// <summary>
    /// Thrown by <seealso cref="FileComponentFactory.ConstructComponents"/> when an empty array is passed as parameter.
    /// </summary>
    class EmptyFilePathArrayException : Exception { }
}
