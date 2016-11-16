// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// StorageAccountsOperations operations.
    /// </summary>
    public partial interface IStorageAccountsOperations
    {
        /// <summary>
        /// Gets the specified Azure Storage account linked to the given Data
        /// Lake Analytics account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account from which to retrieve
        /// Azure storage account details.
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure Storage account for which to retrieve the
        /// details.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<StorageAccountInfo>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified Data Lake Analytics account to remove an
        /// Azure Storage account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account from which to remove
        /// the Azure Storage account.
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure Storage account to remove
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the Data Lake Analytics account to replace Azure Storage
        /// blob account details, such as the access key and/or suffix.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to modify storage
        /// accounts in
        /// </param>
        /// <param name='storageAccountName'>
        /// The Azure Storage account to modify
        /// </param>
        /// <param name='parameters'>
        /// The parameters containing the access key and suffix to update the
        /// storage account with, if any. Passing nothing results in no
        /// change.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, UpdateStorageAccountParameters parameters = default(UpdateStorageAccountParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified Data Lake Analytics account to add an Azure
        /// Storage account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to which to add the
        /// Azure Storage account.
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure Storage account to add
        /// </param>
        /// <param name='parameters'>
        /// The parameters containing the access key and optional suffix for
        /// the Azure Storage Account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> AddWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, AddStorageAccountParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified Azure Storage container associated with the
        /// given Data Lake Analytics and Azure Storage accounts.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account for which to retrieve
        /// blob container.
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure storage account from which to retrieve the
        /// blob container.
        /// </param>
        /// <param name='containerName'>
        /// The name of the Azure storage container to retrieve
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<StorageContainer>> GetStorageContainerWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, string containerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Azure Storage containers, if any, associated with the
        /// specified Data Lake Analytics and Azure Storage account
        /// combination. The response includes a link to the next page of
        /// results, if any.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account for which to list
        /// Azure Storage blob containers.
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure storage account from which to list blob
        /// containers.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<StorageContainer>>> ListStorageContainersWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the SAS token associated with the specified Data Lake
        /// Analytics and Azure Storage account and container combination.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account from which an Azure
        /// Storage account's SAS token is being requested.
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure storage account for which the SAS token is
        /// being requested.
        /// </param>
        /// <param name='containerName'>
        /// The name of the Azure storage container for which the SAS token is
        /// being requested.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SasTokenInfo>>> ListSasTokensWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, string containerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of Azure Storage accounts, if any, linked to
        /// the specified Data Lake Analytics account. The response includes
        /// a link to the next page, if any.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account for which to list
        /// Azure Storage accounts.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='select'>
        /// OData Select statement. Limits the properties on each entry to
        /// just those requested, e.g.
        /// Categories?$select=CategoryName,Description. Optional.
        /// </param>
        /// <param name='count'>
        /// The Boolean value of true or false to request a count of the
        /// matching resources included with the resources in the response,
        /// e.g. Categories?$count=true. Optional.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<StorageAccountInfo>>> ListByAccountWithHttpMessagesAsync(string resourceGroupName, string accountName, ODataQuery<StorageAccountInfo> odataQuery = default(ODataQuery<StorageAccountInfo>), string select = default(string), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Azure Storage containers, if any, associated with the
        /// specified Data Lake Analytics and Azure Storage account
        /// combination. The response includes a link to the next page of
        /// results, if any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<StorageContainer>>> ListStorageContainersNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the SAS token associated with the specified Data Lake
        /// Analytics and Azure Storage account and container combination.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SasTokenInfo>>> ListSasTokensNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of Azure Storage accounts, if any, linked to
        /// the specified Data Lake Analytics account. The response includes
        /// a link to the next page, if any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<StorageAccountInfo>>> ListByAccountNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}