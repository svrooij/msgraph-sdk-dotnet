// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDriveItemRequestBuilder.
    /// </summary>
    public partial interface IDriveItemRequestBuilder : IBaseItemRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDriveItemRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDriveItemRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Children.
        /// </summary>
        /// <returns>The <see cref="IDriveItemChildrenCollectionRequestBuilder"/>.</returns>
        IDriveItemChildrenCollectionRequestBuilder Children { get; }

        /// <summary>
        /// Gets the request builder for Permissions.
        /// </summary>
        /// <returns>The <see cref="IDriveItemPermissionsCollectionRequestBuilder"/>.</returns>
        IDriveItemPermissionsCollectionRequestBuilder Permissions { get; }

        /// <summary>
        /// Gets the request builder for Thumbnails.
        /// </summary>
        /// <returns>The <see cref="IDriveItemThumbnailsCollectionRequestBuilder"/>.</returns>
        IDriveItemThumbnailsCollectionRequestBuilder Thumbnails { get; }

        /// <summary>
        /// Gets the request builder for Workbook.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRequestBuilder"/>.</returns>
        IWorkbookRequestBuilder Workbook { get; }
    
        /// <summary>
        /// Gets the request builder for Content.
        /// </summary>
        /// <returns>The <see cref="IDriveItemContentRequestBuilder"/>.</returns>
        IDriveItemContentRequestBuilder Content { get; }
    
        /// <summary>
        /// Gets the request builder for DriveItemCopy.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCopyRequestBuilder"/>.</returns>
        IDriveItemCopyRequestBuilder Copy(
            string name = null,
            ItemReference parentReference = null);

        /// <summary>
        /// Gets the request builder for DriveItemCreateLink.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCreateLinkRequestBuilder"/>.</returns>
        IDriveItemCreateLinkRequestBuilder CreateLink(
            string scope = null,
            string type = null);

        /// <summary>
        /// Gets the request builder for DriveItemCreateUploadSession.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCreateUploadSessionRequestBuilder"/>.</returns>
        IDriveItemCreateUploadSessionRequestBuilder CreateUploadSession(
            DriveItemUploadableProperties item = null);

        /// <summary>
        /// Gets the request builder for DriveItemInvite.
        /// </summary>
        /// <returns>The <see cref="IDriveItemInviteRequestBuilder"/>.</returns>
        IDriveItemInviteRequestBuilder Invite(
            string message = null,
            IEnumerable<DriveRecipient> recipients = null,
            bool? requireSignIn = null,
            IEnumerable<string> roles = null,
            bool? sendInvitation = null);

        /// <summary>
        /// Gets the request builder for DriveItemDelta.
        /// </summary>
        /// <returns>The <see cref="IDriveItemDeltaRequestBuilder"/>.</returns>
        IDriveItemDeltaRequestBuilder Delta(
            string token = null);

        /// <summary>
        /// Gets the request builder for DriveItemDelta.
        /// </summary>
        /// <returns>The <see cref="IDriveItemDeltaRequestBuilder"/>.</returns>
        IDriveItemDeltaRequestBuilder Delta();

        /// <summary>
        /// Gets the request builder for DriveItemSearch.
        /// </summary>
        /// <returns>The <see cref="IDriveItemSearchRequestBuilder"/>.</returns>
        IDriveItemSearchRequestBuilder Search(
            string q = null);
    
    }
}
