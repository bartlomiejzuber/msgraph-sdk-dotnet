// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IPlayPromptOperationRequest.
    /// </summary>
    public partial interface IPlayPromptOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlayPromptOperation using POST.
        /// </summary>
        /// <param name="playPromptOperationToCreate">The PlayPromptOperation to create.</param>
        /// <returns>The created PlayPromptOperation.</returns>
        System.Threading.Tasks.Task<PlayPromptOperation> CreateAsync(PlayPromptOperation playPromptOperationToCreate);        /// <summary>
        /// Creates the specified PlayPromptOperation using POST.
        /// </summary>
        /// <param name="playPromptOperationToCreate">The PlayPromptOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlayPromptOperation.</returns>
        System.Threading.Tasks.Task<PlayPromptOperation> CreateAsync(PlayPromptOperation playPromptOperationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PlayPromptOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PlayPromptOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PlayPromptOperation.
        /// </summary>
        /// <returns>The PlayPromptOperation.</returns>
        System.Threading.Tasks.Task<PlayPromptOperation> GetAsync();

        /// <summary>
        /// Gets the specified PlayPromptOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlayPromptOperation.</returns>
        System.Threading.Tasks.Task<PlayPromptOperation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PlayPromptOperation using PATCH.
        /// </summary>
        /// <param name="playPromptOperationToUpdate">The PlayPromptOperation to update.</param>
        /// <returns>The updated PlayPromptOperation.</returns>
        System.Threading.Tasks.Task<PlayPromptOperation> UpdateAsync(PlayPromptOperation playPromptOperationToUpdate);

        /// <summary>
        /// Updates the specified PlayPromptOperation using PATCH.
        /// </summary>
        /// <param name="playPromptOperationToUpdate">The PlayPromptOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlayPromptOperation.</returns>
        System.Threading.Tasks.Task<PlayPromptOperation> UpdateAsync(PlayPromptOperation playPromptOperationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlayPromptOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlayPromptOperationRequest Expand(Expression<Func<PlayPromptOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlayPromptOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlayPromptOperationRequest Select(Expression<Func<PlayPromptOperation, object>> selectExpression);

    }
}
