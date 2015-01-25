/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         FileCollectorStrategy.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using ProjectTextStatistics.SystemWrappers;
using ProjectTextStatistics.Engine.Submodules.FileComposite;
using System;

namespace ProjectTextStatistics.Engine.Submodules {
    /// <summary>
    /// Determines the scope of file collection within a directory. 
    /// </summary>
    enum FileCollectorScope {
        TopDirectoryOnly,
        TopAndChildDirectories
    }

    /// <summary>
    /// Provides the abstraction for using multiple file collection strategies.
    /// </summary>
    /// <remarks>
    /// Strategies are responsible for con tent gathering of filesystem directories
    /// and storing them in FileComponent objects.
    /// </remarks>
    abstract class FileCollectorStrategy {
        protected string rule;
        protected FileCollectorScope scope;

        /// <summary>
        /// FileCollectorStrategy constructor.
        /// </summary>
        /// <param name="scope">Scope of file collection<seealso cref="member"/></param>
        /// <param name="rule">Rule for pattern matching</param>
        internal FileCollectorStrategy(FileCollectorScope scope, string rule) {
            this.rule = rule;
            this.scope = scope;
        }

        /// <summary>
        /// Represents the current scope of file collection within a directory. 
        /// </summary>
        public FileCollectorScope Scope {
            get {
                return this.scope;
            }
            set {
                this.scope = value;
            }
        }

        /// <summary>
        /// Collects all files located under specified path and stores them in <seealso cref="FileComponent"/> object. Scope 
        /// of collection depends on current <seealso cref="Scope"/> state.
        /// </summary>
        /// <param name="path">Top directory path</param>
        /// <returns>Files located under specifiad path</returns>
        public abstract FileComponent GetFilesFromDirectory(string path);

        /// <summary>
        /// Translates <seealso cref="FileCollectorScope"/> into platform depandant <seealso cref="DirectorySearchOption"/>
        /// </summary>
        /// <param name="scope"><seealso cref="FileCollectorScope"/> to translate</param>
        /// <returns>Translated <seealso cref="DirectorySearchOption"/> indicator</returns>
        protected static DirectorySearchOption TranslateScope(FileCollectorScope scope) {
            switch(scope) {
                case FileCollectorScope.TopDirectoryOnly:
                    return DirectorySearchOption.TopDirectoryOnly;
                case FileCollectorScope.TopAndChildDirectories:
                    return DirectorySearchOption.AllDirectories;
                default:
                    throw new UnknownCollectorScopeException();
            }
        }
    }

    /// <summary>
    /// Thrown by <seealso cref="TranslateScope"/> method when no translation can be performed.
    /// </summary>
    class UnknownCollectorScopeException : Exception { }
}
