// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SQL pool
    /// </summary>
    /// <remarks>
    /// A SQL Analytics pool
    /// </remarks>
    [Rest.Serialization.JsonTransformation]
    public partial class SqlPool : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlPool class.
        /// </summary>
        public SqlPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlPool class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">SQL pool SKU</param>
        /// <param name="maxSizeBytes">Maximum size in bytes</param>
        /// <param name="collation">Collation mode</param>
        /// <param name="sourceDatabaseId">Source database to create
        /// from</param>
        /// <param name="recoverableDatabaseId">Backup database to restore
        /// from</param>
        /// <param name="provisioningState">Resource state</param>
        /// <param name="status">Resource status</param>
        /// <param name="restorePointInTime">Snapshot time to restore</param>
        /// <param name="createMode">What is this?</param>
        /// <param name="creationDate">Date the SQL pool was created</param>
        public SqlPool(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), long? maxSizeBytes = default(long?), string collation = default(string), string sourceDatabaseId = default(string), string recoverableDatabaseId = default(string), string provisioningState = default(string), string status = default(string), System.DateTime? restorePointInTime = default(System.DateTime?), string createMode = default(string), System.DateTime? creationDate = default(System.DateTime?))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            MaxSizeBytes = maxSizeBytes;
            Collation = collation;
            SourceDatabaseId = sourceDatabaseId;
            RecoverableDatabaseId = recoverableDatabaseId;
            ProvisioningState = provisioningState;
            Status = status;
            RestorePointInTime = restorePointInTime;
            CreateMode = createMode;
            CreationDate = creationDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SQL pool SKU
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets maximum size in bytes
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSizeBytes")]
        public long? MaxSizeBytes { get; set; }

        /// <summary>
        /// Gets or sets collation mode
        /// </summary>
        [JsonProperty(PropertyName = "properties.collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Gets or sets source database to create from
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceDatabaseId")]
        public string SourceDatabaseId { get; set; }

        /// <summary>
        /// Gets or sets backup database to restore from
        /// </summary>
        [JsonProperty(PropertyName = "properties.recoverableDatabaseId")]
        public string RecoverableDatabaseId { get; set; }

        /// <summary>
        /// Gets or sets resource state
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets resource status
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets snapshot time to restore
        /// </summary>
        [JsonProperty(PropertyName = "properties.restorePointInTime")]
        public System.DateTime? RestorePointInTime { get; set; }

        /// <summary>
        /// Gets or sets what is this?
        /// </summary>
        [JsonProperty(PropertyName = "properties.createMode")]
        public string CreateMode { get; set; }

        /// <summary>
        /// Gets or sets date the SQL pool was created
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}