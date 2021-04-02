// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Parquet dataset. </summary>
    public partial class ParquetDataset : Dataset
    {
        /// <summary> Initializes a new instance of ParquetDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public ParquetDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            Type = "Parquet";
        }

        /// <summary> Initializes a new instance of ParquetDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="location"> The location of the parquet storage. </param>
        /// <param name="compressionCodec"> A string from ParquetCompressionCodecEnum or an expression. </param>
        internal ParquetDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, DatasetLocation location, object compressionCodec) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            Location = location;
            CompressionCodec = compressionCodec;
            Type = type ?? "Parquet";
        }

        /// <summary> The location of the parquet storage. </summary>
        public DatasetLocation Location { get; set; }
        /// <summary> A string from ParquetCompressionCodecEnum or an expression. </summary>
        public object CompressionCodec { get; set; }
    }
}
