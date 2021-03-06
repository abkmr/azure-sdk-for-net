// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Client that can be used to manage and query indexes and documents, as
    /// well as manage other resources, on an Azure Search service.
    /// </summary>
    public partial interface ISearchServiceClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Client Api Version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The name of the Azure Search service.
        /// </summary>
        string SearchServiceName { get; set; }

        /// <summary>
        /// The DNS suffix of the Azure Search service. The default is
        /// search.windows.net.
        /// </summary>
        string SearchDnsSuffix { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IDataSourcesOperations.
        /// </summary>
        IDataSourcesOperations DataSources { get; }

        /// <summary>
        /// Gets the IIndexersOperations.
        /// </summary>
        IIndexersOperations Indexers { get; }

        /// <summary>
        /// Gets the ISkillsetsOperations.
        /// </summary>
        ISkillsetsOperations Skillsets { get; }

        /// <summary>
        /// Gets the ISynonymMapsOperations.
        /// </summary>
        ISynonymMapsOperations SynonymMaps { get; }

        /// <summary>
        /// Gets the IIndexesOperations.
        /// </summary>
        IIndexesOperations Indexes { get; }

        /// <summary>
        /// Gets service level statistics for an Azure Search service.
        /// </summary>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ServiceStatistics>> GetServiceStatisticsWithHttpMessagesAsync(SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
