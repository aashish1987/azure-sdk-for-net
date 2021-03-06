// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The top level storage insight resource container.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageInsight : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the StorageInsight class.
        /// </summary>
        public StorageInsight()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageInsight class.
        /// </summary>
        /// <param name="storageAccount">The storage account connection
        /// details</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="containers">The names of the blob containers that the
        /// workspace should read</param>
        /// <param name="tables">The names of the Azure tables that the
        /// workspace should read</param>
        /// <param name="status">The status of the storage insight</param>
        /// <param name="eTag">The ETag of the storage insight.</param>
        /// <param name="tags">Resource tags.</param>
        public StorageInsight(StorageAccount storageAccount, string id = default(string), string name = default(string), string type = default(string), IList<string> containers = default(IList<string>), IList<string> tables = default(IList<string>), StorageInsightStatus status = default(StorageInsightStatus), string eTag = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(id, name, type)
        {
            Containers = containers;
            Tables = tables;
            StorageAccount = storageAccount;
            Status = status;
            ETag = eTag;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the names of the blob containers that the workspace
        /// should read
        /// </summary>
        [JsonProperty(PropertyName = "properties.containers")]
        public IList<string> Containers { get; set; }

        /// <summary>
        /// Gets or sets the names of the Azure tables that the workspace
        /// should read
        /// </summary>
        [JsonProperty(PropertyName = "properties.tables")]
        public IList<string> Tables { get; set; }

        /// <summary>
        /// Gets or sets the storage account connection details
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccount")]
        public StorageAccount StorageAccount { get; set; }

        /// <summary>
        /// Gets the status of the storage insight
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public StorageInsightStatus Status { get; private set; }

        /// <summary>
        /// Gets or sets the ETag of the storage insight.
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccount");
            }
            if (StorageAccount != null)
            {
                StorageAccount.Validate();
            }
            if (Status != null)
            {
                Status.Validate();
            }
        }
    }
}
