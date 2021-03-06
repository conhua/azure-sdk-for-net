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
    /// The workflow run trigger.
    /// </summary>
    public partial class WorkflowRunTrigger
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowRunTrigger class.
        /// </summary>
        public WorkflowRunTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkflowRunTrigger class.
        /// </summary>
        /// <param name="name">Gets the name.</param>
        /// <param name="inputs">Gets the inputs.</param>
        /// <param name="inputsLink">Gets the link to inputs.</param>
        /// <param name="outputs">Gets the outputs.</param>
        /// <param name="outputsLink">Gets the link to outputs.</param>
        /// <param name="scheduledTime">Gets the scheduled time.</param>
        /// <param name="startTime">Gets the start time.</param>
        /// <param name="endTime">Gets the end time.</param>
        /// <param name="trackingId">Gets the tracking id.</param>
        /// <param name="correlation">The run correlation.</param>
        /// <param name="code">Gets the code.</param>
        /// <param name="status">Gets the status. Possible values include:
        /// 'NotSpecified', 'Paused', 'Running', 'Waiting', 'Succeeded',
        /// 'Skipped', 'Suspended', 'Cancelled', 'Failed', 'Faulted',
        /// 'TimedOut', 'Aborted', 'Ignored'</param>
        /// <param name="error">Gets the error.</param>
        /// <param name="trackedProperties">Gets the tracked
        /// properties.</param>
        public WorkflowRunTrigger(string name = default(string), object inputs = default(object), ContentLink inputsLink = default(ContentLink), object outputs = default(object), ContentLink outputsLink = default(ContentLink), System.DateTime? scheduledTime = default(System.DateTime?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string trackingId = default(string), Correlation correlation = default(Correlation), string code = default(string), string status = default(string), object error = default(object), object trackedProperties = default(object))
        {
            Name = name;
            Inputs = inputs;
            InputsLink = inputsLink;
            Outputs = outputs;
            OutputsLink = outputsLink;
            ScheduledTime = scheduledTime;
            StartTime = startTime;
            EndTime = endTime;
            TrackingId = trackingId;
            Correlation = correlation;
            Code = code;
            Status = status;
            Error = error;
            TrackedProperties = trackedProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the inputs.
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public object Inputs { get; private set; }

        /// <summary>
        /// Gets the link to inputs.
        /// </summary>
        [JsonProperty(PropertyName = "inputsLink")]
        public ContentLink InputsLink { get; private set; }

        /// <summary>
        /// Gets the outputs.
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public object Outputs { get; private set; }

        /// <summary>
        /// Gets the link to outputs.
        /// </summary>
        [JsonProperty(PropertyName = "outputsLink")]
        public ContentLink OutputsLink { get; private set; }

        /// <summary>
        /// Gets the scheduled time.
        /// </summary>
        [JsonProperty(PropertyName = "scheduledTime")]
        public System.DateTime? ScheduledTime { get; private set; }

        /// <summary>
        /// Gets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets the tracking id.
        /// </summary>
        [JsonProperty(PropertyName = "trackingId")]
        public string TrackingId { get; private set; }

        /// <summary>
        /// Gets or sets the run correlation.
        /// </summary>
        [JsonProperty(PropertyName = "correlation")]
        public Correlation Correlation { get; set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the status. Possible values include: 'NotSpecified', 'Paused',
        /// 'Running', 'Waiting', 'Succeeded', 'Skipped', 'Suspended',
        /// 'Cancelled', 'Failed', 'Faulted', 'TimedOut', 'Aborted', 'Ignored'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public object Error { get; private set; }

        /// <summary>
        /// Gets the tracked properties.
        /// </summary>
        [JsonProperty(PropertyName = "trackedProperties")]
        public object TrackedProperties { get; private set; }

    }
}
