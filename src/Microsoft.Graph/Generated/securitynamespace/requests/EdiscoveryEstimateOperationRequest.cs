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
    /// The type EdiscoveryEstimateOperationRequest.
    /// </summary>
    public partial class EdiscoveryEstimateOperationRequest : Microsoft.Graph.BaseRequest, IEdiscoveryEstimateOperationRequest
    {
        /// <summary>
        /// Constructs a new EdiscoveryEstimateOperationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EdiscoveryEstimateOperationRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EdiscoveryEstimateOperation using POST.
        /// </summary>
        /// <param name="ediscoveryEstimateOperationToCreate">The EdiscoveryEstimateOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EdiscoveryEstimateOperation.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryEstimateOperation> CreateAsync(EdiscoveryEstimateOperation ediscoveryEstimateOperationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<EdiscoveryEstimateOperation>(ediscoveryEstimateOperationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EdiscoveryEstimateOperation using POST and returns a <see cref="GraphResponse{EdiscoveryEstimateOperation}"/> object.
        /// </summary>
        /// <param name="ediscoveryEstimateOperationToCreate">The EdiscoveryEstimateOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryEstimateOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryEstimateOperation>> CreateResponseAsync(EdiscoveryEstimateOperation ediscoveryEstimateOperationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<EdiscoveryEstimateOperation>(ediscoveryEstimateOperationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified EdiscoveryEstimateOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<EdiscoveryEstimateOperation>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EdiscoveryEstimateOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified EdiscoveryEstimateOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EdiscoveryEstimateOperation.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryEstimateOperation> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<EdiscoveryEstimateOperation>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EdiscoveryEstimateOperation and returns a <see cref="GraphResponse{EdiscoveryEstimateOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryEstimateOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryEstimateOperation>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<EdiscoveryEstimateOperation>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EdiscoveryEstimateOperation using PATCH.
        /// </summary>
        /// <param name="ediscoveryEstimateOperationToUpdate">The EdiscoveryEstimateOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EdiscoveryEstimateOperation.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryEstimateOperation> UpdateAsync(EdiscoveryEstimateOperation ediscoveryEstimateOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<EdiscoveryEstimateOperation>(ediscoveryEstimateOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EdiscoveryEstimateOperation using PATCH and returns a <see cref="GraphResponse{EdiscoveryEstimateOperation}"/> object.
        /// </summary>
        /// <param name="ediscoveryEstimateOperationToUpdate">The EdiscoveryEstimateOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EdiscoveryEstimateOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryEstimateOperation>> UpdateResponseAsync(EdiscoveryEstimateOperation ediscoveryEstimateOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<EdiscoveryEstimateOperation>(ediscoveryEstimateOperationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EdiscoveryEstimateOperation using PUT.
        /// </summary>
        /// <param name="ediscoveryEstimateOperationToUpdate">The EdiscoveryEstimateOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryEstimateOperation> PutAsync(EdiscoveryEstimateOperation ediscoveryEstimateOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<EdiscoveryEstimateOperation>(ediscoveryEstimateOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EdiscoveryEstimateOperation using PUT and returns a <see cref="GraphResponse{EdiscoveryEstimateOperation}"/> object.
        /// </summary>
        /// <param name="ediscoveryEstimateOperationToUpdate">The EdiscoveryEstimateOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{EdiscoveryEstimateOperation}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryEstimateOperation>> PutResponseAsync(EdiscoveryEstimateOperation ediscoveryEstimateOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<EdiscoveryEstimateOperation>(ediscoveryEstimateOperationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryEstimateOperationRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryEstimateOperationRequest Expand(Expression<Func<EdiscoveryEstimateOperation, object>> expandExpression)
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
        public IEdiscoveryEstimateOperationRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryEstimateOperationRequest Select(Expression<Func<EdiscoveryEstimateOperation, object>> selectExpression)
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
        /// <param name="ediscoveryEstimateOperationToInitialize">The <see cref="EdiscoveryEstimateOperation"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EdiscoveryEstimateOperation ediscoveryEstimateOperationToInitialize)
        {

        }
    }
}