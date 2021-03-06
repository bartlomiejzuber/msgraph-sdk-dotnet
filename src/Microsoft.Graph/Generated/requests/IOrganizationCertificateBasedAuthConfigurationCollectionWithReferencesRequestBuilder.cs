// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IOrganizationCertificateBasedAuthConfigurationCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IOrganizationCertificateBasedAuthConfigurationCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IOrganizationCertificateBasedAuthConfigurationCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IOrganizationCertificateBasedAuthConfigurationCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ICertificateBasedAuthConfigurationWithReferenceRequestBuilder"/> for the specified CertificateBasedAuthConfiguration.
        /// </summary>
        /// <param name="id">The ID for the CertificateBasedAuthConfiguration.</param>
        /// <returns>The <see cref="ICertificateBasedAuthConfigurationWithReferenceRequestBuilder"/>.</returns>
        ICertificateBasedAuthConfigurationWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IOrganizationCertificateBasedAuthConfigurationCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IOrganizationCertificateBasedAuthConfigurationCollectionReferencesRequestBuilder"/>.</returns>
        IOrganizationCertificateBasedAuthConfigurationCollectionReferencesRequestBuilder References { get; }

    }
}
