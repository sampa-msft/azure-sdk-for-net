// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Private endpoint update details. </summary>
    public partial class PrivateEndpointUpdate
    {
        /// <summary> Initializes a new instance of PrivateEndpointUpdate. </summary>
        public PrivateEndpointUpdate()
        {
        }

        /// <summary> Remote endpoint resource ID. </summary>
        public string Id { get; set; }
        /// <summary> ARM location of the remote private endpoint. </summary>
        public string Location { get; set; }
        /// <summary> Original subscription ID needed by Microsoft.Network. </summary>
        public string ImmutableSubscriptionId { get; set; }
        /// <summary> Original resource ID needed by Microsoft.Network. </summary>
        public string ImmutableResourceId { get; set; }
        /// <summary> Virtual network traffic tag. </summary>
        public string VnetTrafficTag { get; set; }
    }
}
