﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Samples
{
    /// <summary>
    /// Indicates that the <see cref="SearchField"/> generated by <see cref="FieldBuilder"/> for
    /// the target property should have its <see cref="SearchField.SynonymMapNames"/> property set to the
    /// specified value.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class SynonymMapsAttribute : Attribute
    {
        /// <summary>
        /// Indicates that the specified synonym maps should be used for searches on the target field.
        /// </summary>
        /// <param name="synonymMaps">A list of synonym map names that associates synonym maps with the field.
        /// This option can be used only with searchable fields. Currently only one synonym map per field is
        /// supported. Assigning a synonym map to a field ensures that query terms targeting that field are
        /// expanded at query-time using the rules in the synonym map.
        /// </param>
        public SynonymMapsAttribute(params string[] synonymMaps)
        {
            SynonymMaps = synonymMaps;
        }

        /// <summary>
        /// A list of synonym map names that associates synonym maps with the field.
        /// </summary>
        public IList<string> SynonymMaps { get; }
    }
}
