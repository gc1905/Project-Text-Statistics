/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         ListWrapper.cs
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

namespace ProjectTextStatistics.SystemWrappers {
    /// <summary>
    /// List wrapper provides abstraction from platform dependant list object library.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class ListWrapper<T> {
        internal List<T> instance;

        public ListWrapper() {
            this.instance = new List<T>();
        }

        public ListWrapper(T[] elements) {
            this.instance = new List<T>(elements);
        }

        public int Count {
            get {
                return this.instance.Count;
            }
        }

        public void Insert(int position, T item) {
            this.instance.Insert(position, item);
        }

        public void AddFront(T item) {
            this.instance.Insert(0, item);
        }

        public void AddBack(T item) {
            this.instance.Add(item);
        }

        public void Append(ListWrapper<T> elements) {
            this.instance.AddRange(elements.instance);
        }

        public void Append(T[] elements) {
            this.instance.AddRange(elements);
        }

        public static ListWrapper<T> ToListWrapper(T[] elements) {
            return new ListWrapper<T>(elements);
        }

        public T[] ToArray() {
            return this.instance.ToArray();
        }
    }
}
