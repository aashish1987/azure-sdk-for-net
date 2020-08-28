// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Migrate.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class for operation status errors.
    /// </summary>
    public partial class OperationStatusError
    {
        /// <summary>
        /// Initializes a new instance of the OperationStatusError class.
        /// </summary>
        public OperationStatusError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationStatusError class.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <param name="message">The error message.</param>
        /// <param name="details">The error details.</param>
        /// <param name="additionalInfo">The additional info.</param>
        public OperationStatusError(string code = default(string), string message = default(string), IList<OperationStatusError> details = default(IList<OperationStatusError>), IList<OperationErrorAdditionalInfo> additionalInfo = default(IList<OperationErrorAdditionalInfo>))
        {
            Code = code;
            Message = message;
            Details = details;
            AdditionalInfo = additionalInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the error details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<OperationStatusError> Details { get; private set; }

        /// <summary>
        /// Gets the additional info.
        /// </summary>
        [JsonProperty(PropertyName = "additionalInfo")]
        public IList<OperationErrorAdditionalInfo> AdditionalInfo { get; private set; }

    }
}