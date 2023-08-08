using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.TenantRelationships.FindTenantInformationByDomainNameWithDomainName {
    /// <summary>
    /// Provides operations to call the findTenantInformationByDomainName method.
    /// </summary>
    public class FindTenantInformationByDomainNameWithDomainNameRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new FindTenantInformationByDomainNameWithDomainNameRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="domainName">Usage: domainName=&apos;{domainName}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FindTenantInformationByDomainNameWithDomainNameRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string domainName = "") : base(requestAdapter, "{+baseurl}/tenantRelationships/findTenantInformationByDomainName(domainName='{domainName}')", pathParameters) {
            if (!string.IsNullOrWhiteSpace(domainName)) PathParameters.Add("domainName", domainName);
        }
        /// <summary>
        /// Instantiates a new FindTenantInformationByDomainNameWithDomainNameRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FindTenantInformationByDomainNameWithDomainNameRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships/findTenantInformationByDomainName(domainName='{domainName}')", rawUrl) {
        }
        /// <summary>
        /// Invoke function findTenantInformationByDomainName
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<TenantInformation?> GetAsync(Action<FindTenantInformationByDomainNameWithDomainNameRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<TenantInformation> GetAsync(Action<FindTenantInformationByDomainNameWithDomainNameRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<TenantInformation>(requestInfo, TenantInformation.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Invoke function findTenantInformationByDomainName
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<FindTenantInformationByDomainNameWithDomainNameRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<FindTenantInformationByDomainNameWithDomainNameRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new FindTenantInformationByDomainNameWithDomainNameRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class FindTenantInformationByDomainNameWithDomainNameRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new findTenantInformationByDomainNameWithDomainNameRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public FindTenantInformationByDomainNameWithDomainNameRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}