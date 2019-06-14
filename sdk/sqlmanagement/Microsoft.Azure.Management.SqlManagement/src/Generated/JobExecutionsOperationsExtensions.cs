// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JobExecutionsOperations.
    /// </summary>
    public static partial class JobExecutionsOperationsExtensions
    {
            /// <summary>
            /// Lists all executions in a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='createTimeMin'>
            /// If specified, only job executions created at or after the specified time
            /// are included.
            /// </param>
            /// <param name='createTimeMax'>
            /// If specified, only job executions created before the specified time are
            /// included.
            /// </param>
            /// <param name='endTimeMin'>
            /// If specified, only job executions completed at or after the specified time
            /// are included.
            /// </param>
            /// <param name='endTimeMax'>
            /// If specified, only job executions completed before the specified time are
            /// included.
            /// </param>
            /// <param name='isActive'>
            /// If specified, only active or only completed job executions are included.
            /// </param>
            /// <param name='skip'>
            /// The number of elements in the collection to skip.
            /// </param>
            /// <param name='top'>
            /// The number of elements to return from the collection.
            /// </param>
            public static IPage<JobExecution> ListByAgent(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, System.DateTime? createTimeMin = default(System.DateTime?), System.DateTime? createTimeMax = default(System.DateTime?), System.DateTime? endTimeMin = default(System.DateTime?), System.DateTime? endTimeMax = default(System.DateTime?), bool? isActive = default(bool?), int? skip = default(int?), int? top = default(int?))
            {
                return operations.ListByAgentAsync(resourceGroupName, serverName, jobAgentName, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all executions in a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='createTimeMin'>
            /// If specified, only job executions created at or after the specified time
            /// are included.
            /// </param>
            /// <param name='createTimeMax'>
            /// If specified, only job executions created before the specified time are
            /// included.
            /// </param>
            /// <param name='endTimeMin'>
            /// If specified, only job executions completed at or after the specified time
            /// are included.
            /// </param>
            /// <param name='endTimeMax'>
            /// If specified, only job executions completed before the specified time are
            /// included.
            /// </param>
            /// <param name='isActive'>
            /// If specified, only active or only completed job executions are included.
            /// </param>
            /// <param name='skip'>
            /// The number of elements in the collection to skip.
            /// </param>
            /// <param name='top'>
            /// The number of elements to return from the collection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobExecution>> ListByAgentAsync(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, System.DateTime? createTimeMin = default(System.DateTime?), System.DateTime? createTimeMax = default(System.DateTime?), System.DateTime? endTimeMin = default(System.DateTime?), System.DateTime? endTimeMax = default(System.DateTime?), bool? isActive = default(bool?), int? skip = default(int?), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAgentWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Requests cancellation of a job execution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job.
            /// </param>
            /// <param name='jobExecutionId'>
            /// The id of the job execution to cancel.
            /// </param>
            public static void Cancel(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId)
            {
                operations.CancelAsync(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Requests cancellation of a job execution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job.
            /// </param>
            /// <param name='jobExecutionId'>
            /// The id of the job execution to cancel.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CancelAsync(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CancelWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Starts an elastic job execution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job to get.
            /// </param>
            public static JobExecution Create(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName)
            {
                return operations.CreateAsync(resourceGroupName, serverName, jobAgentName, jobName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts an elastic job execution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobExecution> CreateAsync(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, jobName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists a job's executions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job to get.
            /// </param>
            /// <param name='createTimeMin'>
            /// If specified, only job executions created at or after the specified time
            /// are included.
            /// </param>
            /// <param name='createTimeMax'>
            /// If specified, only job executions created before the specified time are
            /// included.
            /// </param>
            /// <param name='endTimeMin'>
            /// If specified, only job executions completed at or after the specified time
            /// are included.
            /// </param>
            /// <param name='endTimeMax'>
            /// If specified, only job executions completed before the specified time are
            /// included.
            /// </param>
            /// <param name='isActive'>
            /// If specified, only active or only completed job executions are included.
            /// </param>
            /// <param name='skip'>
            /// The number of elements in the collection to skip.
            /// </param>
            /// <param name='top'>
            /// The number of elements to return from the collection.
            /// </param>
            public static IPage<JobExecution> ListByJob(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName, System.DateTime? createTimeMin = default(System.DateTime?), System.DateTime? createTimeMax = default(System.DateTime?), System.DateTime? endTimeMin = default(System.DateTime?), System.DateTime? endTimeMax = default(System.DateTime?), bool? isActive = default(bool?), int? skip = default(int?), int? top = default(int?))
            {
                return operations.ListByJobAsync(resourceGroupName, serverName, jobAgentName, jobName, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a job's executions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job to get.
            /// </param>
            /// <param name='createTimeMin'>
            /// If specified, only job executions created at or after the specified time
            /// are included.
            /// </param>
            /// <param name='createTimeMax'>
            /// If specified, only job executions created before the specified time are
            /// included.
            /// </param>
            /// <param name='endTimeMin'>
            /// If specified, only job executions completed at or after the specified time
            /// are included.
            /// </param>
            /// <param name='endTimeMax'>
            /// If specified, only job executions completed before the specified time are
            /// included.
            /// </param>
            /// <param name='isActive'>
            /// If specified, only active or only completed job executions are included.
            /// </param>
            /// <param name='skip'>
            /// The number of elements in the collection to skip.
            /// </param>
            /// <param name='top'>
            /// The number of elements to return from the collection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobExecution>> ListByJobAsync(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName, System.DateTime? createTimeMin = default(System.DateTime?), System.DateTime? createTimeMax = default(System.DateTime?), System.DateTime? endTimeMin = default(System.DateTime?), System.DateTime? endTimeMax = default(System.DateTime?), bool? isActive = default(bool?), int? skip = default(int?), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByJobWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, jobName, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a job execution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job.
            /// </param>
            /// <param name='jobExecutionId'>
            /// The id of the job execution
            /// </param>
            public static JobExecution Get(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId)
            {
                return operations.GetAsync(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a job execution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job.
            /// </param>
            /// <param name='jobExecutionId'>
            /// The id of the job execution
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobExecution> GetAsync(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a job execution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job to get.
            /// </param>
            /// <param name='jobExecutionId'>
            /// The job execution id to create the job execution under.
            /// </param>
            public static JobExecution CreateOrUpdate(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a job execution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job to get.
            /// </param>
            /// <param name='jobExecutionId'>
            /// The job execution id to create the job execution under.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobExecution> CreateOrUpdateAsync(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Starts an elastic job execution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job to get.
            /// </param>
            public static JobExecution BeginCreate(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName)
            {
                return operations.BeginCreateAsync(resourceGroupName, serverName, jobAgentName, jobName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts an elastic job execution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobExecution> BeginCreateAsync(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, jobName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a job execution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job to get.
            /// </param>
            /// <param name='jobExecutionId'>
            /// The job execution id to create the job execution under.
            /// </param>
            public static JobExecution BeginCreateOrUpdate(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a job execution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job to get.
            /// </param>
            /// <param name='jobExecutionId'>
            /// The job execution id to create the job execution under.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobExecution> BeginCreateOrUpdateAsync(this IJobExecutionsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all executions in a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobExecution> ListByAgentNext(this IJobExecutionsOperations operations, string nextPageLink)
            {
                return operations.ListByAgentNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all executions in a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobExecution>> ListByAgentNextAsync(this IJobExecutionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAgentNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists a job's executions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobExecution> ListByJobNext(this IJobExecutionsOperations operations, string nextPageLink)
            {
                return operations.ListByJobNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a job's executions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobExecution>> ListByJobNextAsync(this IJobExecutionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByJobNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}