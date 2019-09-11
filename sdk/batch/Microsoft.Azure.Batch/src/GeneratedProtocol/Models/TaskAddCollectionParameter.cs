// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A collection of Azure Batch Tasks to add.
    /// </summary>
    public partial class TaskAddCollectionParameter
    {
        /// <summary>
        /// Initializes a new instance of the TaskAddCollectionParameter class.
        /// </summary>
        public TaskAddCollectionParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskAddCollectionParameter class.
        /// </summary>
        /// <param name="value">The collection of Tasks to add. The maximum
        /// count of Tasks is 100.</param>
        public TaskAddCollectionParameter(IList<TaskAddParameter> value)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the collection of Tasks to add. The maximum count of
        /// Tasks is 100.
        /// </summary>
        /// <remarks>
        /// The total serialized size of this collection must be less than 1MB.
        /// If it is greater than 1MB (for example if each Task has 100's of
        /// resource files or environment variables), the request will fail
        /// with code 'RequestBodyTooLarge' and should be retried again with
        /// fewer Tasks.
        /// </remarks>
        [JsonProperty(PropertyName = "value")]
        public IList<TaskAddParameter> Value { get; set; }

    }
}