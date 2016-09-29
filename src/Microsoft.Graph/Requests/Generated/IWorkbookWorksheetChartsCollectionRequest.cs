// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IWorkbookWorksheetChartsCollectionRequest.
    /// </summary>
    public partial interface IWorkbookWorksheetChartsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified WorkbookChart to the collection via POST.
        /// </summary>
        /// <param name="workbookChart">The WorkbookChart to add.</param>
        /// <returns>The created WorkbookChart.</returns>
        System.Threading.Tasks.Task<WorkbookChart> AddAsync(WorkbookChart workbookChart);

        /// <summary>
        /// Adds the specified WorkbookChart to the collection via POST.
        /// </summary>
        /// <param name="workbookChart">The WorkbookChart to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChart.</returns>
        System.Threading.Tasks.Task<WorkbookChart> AddAsync(WorkbookChart workbookChart, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IWorkbookWorksheetChartsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IWorkbookWorksheetChartsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookWorksheetChartsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookWorksheetChartsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookWorksheetChartsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookWorksheetChartsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookWorksheetChartsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookWorksheetChartsCollectionRequest OrderBy(string value);
    }
}