// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Models
{
    /// <summary> The result of Autocomplete query. </summary>
    public partial class AutocompleteResults
    {
        /// <summary> A value indicating the percentage of the index that was considered by the autocomplete request, or null if minimumCoverage was not specified in the request. </summary>
        public double? Coverage { get; internal set; }
        /// <summary> The list of returned Autocompleted items. </summary>
        public IList<Autocompletion> Results { get; internal set; } = new List<Autocompletion>();
    }
}
