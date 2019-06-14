// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The workflow trigger recurrence.
    /// </summary>
    public partial class WorkflowTriggerRecurrence
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerRecurrence class.
        /// </summary>
        public WorkflowTriggerRecurrence()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerRecurrence class.
        /// </summary>
        /// <param name="frequency">The frequency. Possible values include:
        /// 'NotSpecified', 'Second', 'Minute', 'Hour', 'Day', 'Week', 'Month',
        /// 'Year'</param>
        /// <param name="interval">The interval.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="timeZone">The time zone.</param>
        /// <param name="schedule">The recurrence schedule.</param>
        public WorkflowTriggerRecurrence(string frequency = default(string), int? interval = default(int?), string startTime = default(string), string endTime = default(string), string timeZone = default(string), RecurrenceSchedule schedule = default(RecurrenceSchedule))
        {
            Frequency = frequency;
            Interval = interval;
            StartTime = startTime;
            EndTime = endTime;
            TimeZone = timeZone;
            Schedule = schedule;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the frequency. Possible values include:
        /// 'NotSpecified', 'Second', 'Minute', 'Hour', 'Day', 'Week', 'Month',
        /// 'Year'
        /// </summary>
        [JsonProperty(PropertyName = "frequency")]
        public string Frequency { get; set; }

        /// <summary>
        /// Gets or sets the interval.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the recurrence schedule.
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public RecurrenceSchedule Schedule { get; set; }

    }
}