/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         FileComponent.cs
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
    ///  Provides the abstraction required by composite design pattern.
    /// </summary>
    /// <remarks>
    /// Represents the file component and provides some analysis methods.
    /// </remarks>
    abstract class FileComponent {
        /// <summary>
        /// Cumulative number of text lines
        /// </summary>
        public abstract int Lines {
            get;
        }

        /// <summary>
        /// Path to all files separated by comma
        /// </summary>
        public abstract string Path {
            get;
        }

        /// <summary>
        /// Cumulative number of words
        /// </summary>
        public abstract int Words {
            get;
        }

        /// <summary>
        /// Cumulative number of characters
        /// </summary>
        public abstract int Characters {
            get;
        }

        /// <summary>
        /// Converts into an array of undividable components (<seealso cref="FileLeaf"/>).
        /// </summary>
        /// <returns>Array of undividable (most promitive) components</returns>
        public abstract FileComponent[] DisassemblyIntoLeafs();
    }
}
