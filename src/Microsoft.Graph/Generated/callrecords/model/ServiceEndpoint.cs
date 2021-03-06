// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ServiceEndpoint.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ServiceEndpoint : Endpoint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceEndpoint"/> class.
        /// </summary>
        public ServiceEndpoint()
        {
            this.ODataType = "microsoft.graph.callRecords.serviceEndpoint";
        }

    }
}
