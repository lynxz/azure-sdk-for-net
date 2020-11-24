// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WorkspaceManagedSqlServerSecurityAlertPolicyOperations.
    /// </summary>
    public static partial class WorkspaceManagedSqlServerSecurityAlertPolicyOperationsExtensions
    {
            /// <summary>
            /// Get server's security alert policy.
            /// </summary>
            /// <remarks>
            /// Get a workspace managed sql server's security alert policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            public static ServerSecurityAlertPolicy Get(this IWorkspaceManagedSqlServerSecurityAlertPolicyOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get server's security alert policy.
            /// </summary>
            /// <remarks>
            /// Get a workspace managed sql server's security alert policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerSecurityAlertPolicy> GetAsync(this IWorkspaceManagedSqlServerSecurityAlertPolicyOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or Update server's threat detection policy.
            /// </summary>
            /// <remarks>
            /// Create or Update a workspace managed sql server's threat detection policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='parameters'>
            /// The workspace managed sql server security alert policy.
            /// </param>
            public static ServerSecurityAlertPolicy CreateOrUpdate(this IWorkspaceManagedSqlServerSecurityAlertPolicyOperations operations, string resourceGroupName, string workspaceName, ServerSecurityAlertPolicy parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or Update server's threat detection policy.
            /// </summary>
            /// <remarks>
            /// Create or Update a workspace managed sql server's threat detection policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='parameters'>
            /// The workspace managed sql server security alert policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerSecurityAlertPolicy> CreateOrUpdateAsync(this IWorkspaceManagedSqlServerSecurityAlertPolicyOperations operations, string resourceGroupName, string workspaceName, ServerSecurityAlertPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get server's threat detection policies.
            /// </summary>
            /// <remarks>
            /// Get workspace managed sql server's threat detection policies.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            public static IPage<ServerSecurityAlertPolicy> List(this IWorkspaceManagedSqlServerSecurityAlertPolicyOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.ListAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get server's threat detection policies.
            /// </summary>
            /// <remarks>
            /// Get workspace managed sql server's threat detection policies.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServerSecurityAlertPolicy>> ListAsync(this IWorkspaceManagedSqlServerSecurityAlertPolicyOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or Update server's threat detection policy.
            /// </summary>
            /// <remarks>
            /// Create or Update a workspace managed sql server's threat detection policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='parameters'>
            /// The workspace managed sql server security alert policy.
            /// </param>
            public static ServerSecurityAlertPolicy BeginCreateOrUpdate(this IWorkspaceManagedSqlServerSecurityAlertPolicyOperations operations, string resourceGroupName, string workspaceName, ServerSecurityAlertPolicy parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, workspaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or Update server's threat detection policy.
            /// </summary>
            /// <remarks>
            /// Create or Update a workspace managed sql server's threat detection policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='parameters'>
            /// The workspace managed sql server security alert policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerSecurityAlertPolicy> BeginCreateOrUpdateAsync(this IWorkspaceManagedSqlServerSecurityAlertPolicyOperations operations, string resourceGroupName, string workspaceName, ServerSecurityAlertPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get server's threat detection policies.
            /// </summary>
            /// <remarks>
            /// Get workspace managed sql server's threat detection policies.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServerSecurityAlertPolicy> ListNext(this IWorkspaceManagedSqlServerSecurityAlertPolicyOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get server's threat detection policies.
            /// </summary>
            /// <remarks>
            /// Get workspace managed sql server's threat detection policies.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServerSecurityAlertPolicy>> ListNextAsync(this IWorkspaceManagedSqlServerSecurityAlertPolicyOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}