// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.AI.FormRecognizer;
using Azure.AI.FormRecognizer.Models;

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary> Response to the list custom models operation. </summary>
    internal partial class Models_internal
    {
        /// <summary> Summary of all trained custom models. </summary>
        public ModelsSummary_internal Summary { get; set; }
        /// <summary> Collection of trained custom models. </summary>
        public IList<ModelInfo_internal> ModelList { get; set; }
        /// <summary> Link to the next page of custom models. </summary>
        public string NextLink { get; set; }
    }
}
