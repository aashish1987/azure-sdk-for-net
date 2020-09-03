// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Map of filter type and the details to transfer all data. This field is
    /// required only if the TransferConfigurationType is given as TransferAll
    /// </summary>
    public partial class TransferConfigurationTransferAllDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TransferConfigurationTransferAllDetails class.
        /// </summary>
        public TransferConfigurationTransferAllDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TransferConfigurationTransferAllDetails class.
        /// </summary>
        /// <param name="include">Details to transfer all data.</param>
        public TransferConfigurationTransferAllDetails(TransferAllDetails include = default(TransferAllDetails))
        {
            Include = include;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets details to transfer all data.
        /// </summary>
        [JsonProperty(PropertyName = "include")]
        public TransferAllDetails Include { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Include != null)
            {
                Include.Validate();
            }
        }
    }
}