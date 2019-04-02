// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Inspectioninspectionchecklset.
    /// </summary>
    public static partial class InspectioninspectionchecklsetExtensions
    {
            /// <summary>
            /// Get entities from bcgov_inspection_inspectionchecklset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static InspectioninspectionchecklsetGetResponseModel Get(this IInspectioninspectionchecklset operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from bcgov_inspection_inspectionchecklset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InspectioninspectionchecklsetGetResponseModel> GetAsync(this IInspectioninspectionchecklset operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to bcgov_inspection_inspectionchecklset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            public static MicrosoftDynamicsCRMbcgovInspectionInspectioncheckl Create(this IInspectioninspectionchecklset operations, MicrosoftDynamicsCRMbcgovInspectionInspectioncheckl body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to bcgov_inspection_inspectionchecklset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMbcgovInspectionInspectioncheckl> CreateAsync(this IInspectioninspectionchecklset operations, MicrosoftDynamicsCRMbcgovInspectionInspectioncheckl body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from bcgov_inspection_inspectionchecklset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInspectionInspectionchecklid'>
            /// key: bcgov_inspection_inspectionchecklid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMbcgovInspectionInspectioncheckl GetByKey(this IInspectioninspectionchecklset operations, string bcgovInspectionInspectionchecklid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeyAsync(bcgovInspectionInspectionchecklid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from bcgov_inspection_inspectionchecklset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInspectionInspectionchecklid'>
            /// key: bcgov_inspection_inspectionchecklid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMbcgovInspectionInspectioncheckl> GetByKeyAsync(this IInspectioninspectionchecklset operations, string bcgovInspectionInspectionchecklid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeyWithHttpMessagesAsync(bcgovInspectionInspectionchecklid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete entity from bcgov_inspection_inspectionchecklset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInspectionInspectionchecklid'>
            /// key: bcgov_inspection_inspectionchecklid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void Delete(this IInspectioninspectionchecklset operations, string bcgovInspectionInspectionchecklid, string ifMatch = default(string))
            {
                operations.DeleteAsync(bcgovInspectionInspectionchecklid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from bcgov_inspection_inspectionchecklset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInspectionInspectionchecklid'>
            /// key: bcgov_inspection_inspectionchecklid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IInspectioninspectionchecklset operations, string bcgovInspectionInspectionchecklid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(bcgovInspectionInspectionchecklid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in bcgov_inspection_inspectionchecklset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInspectionInspectionchecklid'>
            /// key: bcgov_inspection_inspectionchecklid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Update(this IInspectioninspectionchecklset operations, string bcgovInspectionInspectionchecklid, MicrosoftDynamicsCRMbcgovInspectionInspectioncheckl body)
            {
                operations.UpdateAsync(bcgovInspectionInspectionchecklid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in bcgov_inspection_inspectionchecklset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInspectionInspectionchecklid'>
            /// key: bcgov_inspection_inspectionchecklid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IInspectioninspectionchecklset operations, string bcgovInspectionInspectionchecklid, MicrosoftDynamicsCRMbcgovInspectionInspectioncheckl body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(bcgovInspectionInspectionchecklid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
