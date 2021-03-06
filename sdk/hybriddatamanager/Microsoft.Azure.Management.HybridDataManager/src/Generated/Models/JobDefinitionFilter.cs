// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains the supported job definition filters.
    /// </summary>
    public partial class JobDefinitionFilter
    {
        /// <summary>
        /// Initializes a new instance of the JobDefinitionFilter class.
        /// </summary>
        public JobDefinitionFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobDefinitionFilter class.
        /// </summary>
        /// <param name="state">The state of the job definition. Possible
        /// values include: 'Disabled', 'Enabled', 'Supported'</param>
        /// <param name="dataSource">The data source associated with the job
        /// definition</param>
        /// <param name="lastModified">The last modified date time of the data
        /// source.</param>
        public JobDefinitionFilter(State state, string dataSource = default(string), System.DateTime? lastModified = default(System.DateTime?))
        {
            State = state;
            DataSource = dataSource;
            LastModified = lastModified;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the state of the job definition. Possible values
        /// include: 'Disabled', 'Enabled', 'Supported'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public State State { get; set; }

        /// <summary>
        /// Gets or sets the data source associated with the job definition
        /// </summary>
        [JsonProperty(PropertyName = "dataSource")]
        public string DataSource { get; set; }

        /// <summary>
        /// Gets or sets the last modified date time of the data source.
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
