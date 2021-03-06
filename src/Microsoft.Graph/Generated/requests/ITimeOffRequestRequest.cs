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
    /// The interface ITimeOffRequestRequest.
    /// </summary>
    public partial interface ITimeOffRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TimeOffRequestObject using POST.
        /// </summary>
        /// <param name="timeOffRequestObjectToCreate">The TimeOffRequestObject to create.</param>
        /// <returns>The created TimeOffRequestObject.</returns>
        System.Threading.Tasks.Task<TimeOffRequestObject> CreateAsync(TimeOffRequestObject timeOffRequestObjectToCreate);        /// <summary>
        /// Creates the specified TimeOffRequestObject using POST.
        /// </summary>
        /// <param name="timeOffRequestObjectToCreate">The TimeOffRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TimeOffRequestObject.</returns>
        System.Threading.Tasks.Task<TimeOffRequestObject> CreateAsync(TimeOffRequestObject timeOffRequestObjectToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TimeOffRequestObject.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TimeOffRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TimeOffRequestObject.
        /// </summary>
        /// <returns>The TimeOffRequestObject.</returns>
        System.Threading.Tasks.Task<TimeOffRequestObject> GetAsync();

        /// <summary>
        /// Gets the specified TimeOffRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TimeOffRequestObject.</returns>
        System.Threading.Tasks.Task<TimeOffRequestObject> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TimeOffRequestObject using PATCH.
        /// </summary>
        /// <param name="timeOffRequestObjectToUpdate">The TimeOffRequestObject to update.</param>
        /// <returns>The updated TimeOffRequestObject.</returns>
        System.Threading.Tasks.Task<TimeOffRequestObject> UpdateAsync(TimeOffRequestObject timeOffRequestObjectToUpdate);

        /// <summary>
        /// Updates the specified TimeOffRequestObject using PATCH.
        /// </summary>
        /// <param name="timeOffRequestObjectToUpdate">The TimeOffRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TimeOffRequestObject.</returns>
        System.Threading.Tasks.Task<TimeOffRequestObject> UpdateAsync(TimeOffRequestObject timeOffRequestObjectToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequestRequest Expand(Expression<Func<TimeOffRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequestRequest Select(Expression<Func<TimeOffRequestObject, object>> selectExpression);

    }
}
