/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         StringBuilderWrapper.cs
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
    /// String Builder library wrapper provides abstraction from platform dependant utilities used for string construction.
    /// </summary>
    class StringBuilderWrapper {
        private StringBuilder instance;

        public StringBuilderWrapper() {
            this.instance = new StringBuilder();
        }

        public int Capacity {
            get {
                return this.instance.Capacity;
            }
            set {
                this.instance.Capacity = value;
            }
        }

        public int Length {
            get {
                return this.instance.Length;
            }
            set {
                this.instance.Length = value;
            }
        }

        public int MaxCapacity {
            get {
                return this.instance.MaxCapacity;
            }
        }

        public StringBuilderWrapper Append(bool value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(byte value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(char value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(char[] value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(decimal value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(double value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(float value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(int value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(long value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(object value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(sbyte value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(short value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(string value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(uint value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(ulong value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(ushort value) {
            this.instance.Append(value);
            return this;
        }

        public StringBuilderWrapper Append(char value, int repeatCount) {
            this.instance.Append(value, repeatCount);
            return this;
        }

        public StringBuilderWrapper Append(char[] value, int startIndex, int charCount) {
            this.instance.Append(value, startIndex, charCount);
            return this;
        }

        public StringBuilderWrapper Append(string value, int startIndex, int count) {
            this.instance.Append(value, startIndex, count);
            return this;
        }

        public override string ToString() {
            return this.instance.ToString();
        }
    }
}
