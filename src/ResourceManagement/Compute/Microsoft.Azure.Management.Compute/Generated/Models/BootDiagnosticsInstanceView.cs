// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The instance view of a virtual machine boot diagnostics.
    /// </summary>
    public partial class BootDiagnosticsInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the BootDiagnosticsInstanceView
        /// class.
        /// </summary>
        public BootDiagnosticsInstanceView() { }

        /// <summary>
        /// Initializes a new instance of the BootDiagnosticsInstanceView
        /// class.
        /// </summary>
        public BootDiagnosticsInstanceView(string consoleScreenshotBlobUri = default(string), string serialConsoleLogBlobUri = default(string))
        {
            ConsoleScreenshotBlobUri = consoleScreenshotBlobUri;
            SerialConsoleLogBlobUri = serialConsoleLogBlobUri;
        }

        /// <summary>
        /// Gets or sets the console screenshot blob Uri.
        /// </summary>
        [JsonProperty(PropertyName = "consoleScreenshotBlobUri")]
        public string ConsoleScreenshotBlobUri { get; set; }

        /// <summary>
        /// Gets or sets the Linux serial console log blob Uri.
        /// </summary>
        [JsonProperty(PropertyName = "serialConsoleLogBlobUri")]
        public string SerialConsoleLogBlobUri { get; set; }

    }
}
