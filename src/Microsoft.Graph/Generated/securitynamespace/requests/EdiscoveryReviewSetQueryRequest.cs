// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type EdiscoveryReviewSetQueryRequest.
    /// </summary>
    public partial class EdiscoveryReviewSetQueryRequest : Microsoft.Graph.BaseRequest, IEdiscoveryReviewSetQueryRequest
    {
        /// <summary>
        /// Constructs a new EdiscoveryReviewSetQueryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EdiscoveryReviewSetQueryRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EdiscoveryReviewSetQuery using POST.
        /// </summary>
        /// <param name="ediscoveryReviewSetQueryToCreate">The EdiscoveryReviewSetQuery to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EdiscoveryReviewSetQuery.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryReviewSetQuery> CreateAsync(EdiscoveryReviewSetQuery ediscoveryReviewSetQueryToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<EdiscoveryReviewSetQuery>(ediscoveryReviewSetQueryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EdiscoveryReviewSetQuery using POST and returns a <see cref="GraphResponse{EdiscoveryReviewSetQuery}"/> object.
        /// </summary>
        /// <param name="ediscoveryReviewSetQueryToCreate">The EdiscoveryReviewSetQuery to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryReviewSetQuery}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryReviewSetQuery>> CreateResponseAsync(EdiscoveryReviewSetQuery ediscoveryReviewSetQueryToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<EdiscoveryReviewSetQuery>(ediscoveryReviewSetQueryToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified EdiscoveryReviewSetQuery.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<EdiscoveryReviewSetQuery>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EdiscoveryReviewSetQuery and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified EdiscoveryReviewSetQuery.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EdiscoveryReviewSetQuery.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryReviewSetQuery> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<EdiscoveryReviewSetQuery>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EdiscoveryReviewSetQuery and returns a <see cref="GraphResponse{EdiscoveryReviewSetQuery}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryReviewSetQuery}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryReviewSetQuery>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<EdiscoveryReviewSetQuery>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EdiscoveryReviewSetQuery using PATCH.
        /// </summary>
        /// <param name="ediscoveryReviewSetQueryToUpdate">The EdiscoveryReviewSetQuery to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EdiscoveryReviewSetQuery.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryReviewSetQuery> UpdateAsync(EdiscoveryReviewSetQuery ediscoveryReviewSetQueryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<EdiscoveryReviewSetQuery>(ediscoveryReviewSetQueryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EdiscoveryReviewSetQuery using PATCH and returns a <see cref="GraphResponse{EdiscoveryReviewSetQuery}"/> object.
        /// </summary>
        /// <param name="ediscoveryReviewSetQueryToUpdate">The EdiscoveryReviewSetQuery to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EdiscoveryReviewSetQuery}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryReviewSetQuery>> UpdateResponseAsync(EdiscoveryReviewSetQuery ediscoveryReviewSetQueryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<EdiscoveryReviewSetQuery>(ediscoveryReviewSetQueryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EdiscoveryReviewSetQuery using PUT.
        /// </summary>
        /// <param name="ediscoveryReviewSetQueryToUpdate">The EdiscoveryReviewSetQuery object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryReviewSetQuery> PutAsync(EdiscoveryReviewSetQuery ediscoveryReviewSetQueryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<EdiscoveryReviewSetQuery>(ediscoveryReviewSetQueryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EdiscoveryReviewSetQuery using PUT and returns a <see cref="GraphResponse{EdiscoveryReviewSetQuery}"/> object.
        /// </summary>
        /// <param name="ediscoveryReviewSetQueryToUpdate">The EdiscoveryReviewSetQuery object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{EdiscoveryReviewSetQuery}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryReviewSetQuery>> PutResponseAsync(EdiscoveryReviewSetQuery ediscoveryReviewSetQueryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<EdiscoveryReviewSetQuery>(ediscoveryReviewSetQueryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryReviewSetQueryRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryReviewSetQueryRequest Expand(Expression<Func<EdiscoveryReviewSetQuery, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryReviewSetQueryRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryReviewSetQueryRequest Select(Expression<Func<EdiscoveryReviewSetQuery, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="ediscoveryReviewSetQueryToInitialize">The <see cref="EdiscoveryReviewSetQuery"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EdiscoveryReviewSetQuery ediscoveryReviewSetQueryToInitialize)
        {

        }
    }
}