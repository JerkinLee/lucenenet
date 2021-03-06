using Lucene.Net.Index;

namespace Lucene.Net.Documents
{
    /*
     * Licensed to the Apache Software Foundation (ASF) under one or more
     * contributor license agreements.  See the NOTICE file distributed with
     * this work for additional information regarding copyright ownership.
     * The ASF licenses this file to You under the Apache License, Version 2.0
     * (the "License"); you may not use this file except in compliance with
     * the License.  You may obtain a copy of the License at
     *
     *     http://www.apache.org/licenses/LICENSE-2.0
     *
     * Unless required by applicable law or agreed to in writing, software
     * distributed under the License is distributed on an "AS IS" BASIS,
     * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
     * See the License for the specific language governing permissions and
     * limitations under the License.
     */

    /// <summary>
    /// A field that is indexed but not tokenized: the entire
    /// <see cref="string"/> value is indexed as a single token.  For example
    /// this might be used for a 'country' field or an 'id'
    /// field, or any field that you intend to use for sorting
    /// or access through the field cache.
    /// </summary>
    public sealed class StringField : Field
    {
        /// <summary>
        /// Indexed, not tokenized, omits norms, indexes
        /// <see cref="IndexOptions.DOCS_ONLY"/>, not stored.
        /// </summary>
        public static readonly FieldType TYPE_NOT_STORED = LoadTypeNotStored();

        private static FieldType LoadTypeNotStored() // LUCENENET: Avoid static constructors (see https://github.com/apache/lucenenet/pull/224#issuecomment-469284006)
        {
            var typeNotStored = new FieldType
            {
                IsIndexed = true,
                OmitNorms = true,
                IndexOptions = IndexOptions.DOCS_ONLY,
                IsTokenized = false
            };
            typeNotStored.Freeze();
            return typeNotStored;
        }

        /// <summary>
        /// Indexed, not tokenized, omits norms, indexes
        /// <see cref="IndexOptions.DOCS_ONLY"/>, stored
        /// </summary>
        public static readonly FieldType TYPE_STORED = LoadTypeStored();

        private static FieldType LoadTypeStored() // LUCENENET: Avoid static constructors (see https://github.com/apache/lucenenet/pull/224#issuecomment-469284006)
        {
            var typeStored = new FieldType
            {
                IsIndexed = true,
                OmitNorms = true,
                IndexOptions = IndexOptions.DOCS_ONLY,
                IsStored = true,
                IsTokenized = false
            };
            typeStored.Freeze();
            return typeStored;
        }

        /// <summary>
        /// Creates a new <see cref="StringField"/> (a field that is indexed but not tokenized)
        /// </summary>
        /// <param name="name"> field name </param>
        /// <param name="value"> <see cref="string"/> value </param>
        /// <param name="stored"> <see cref="Field.Store.YES"/> if the content should also be stored </param>
        /// <exception cref="System.ArgumentNullException"> if the field <paramref name="name"/> or <paramref name="value"/> is <c>null</c>. </exception>
        public StringField(string name, string value, Store stored)
            : base(name, value, stored == Store.YES ? TYPE_STORED : TYPE_NOT_STORED)
        {
        }
    }
}