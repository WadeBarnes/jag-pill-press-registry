// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// bcgov_region
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovRegion
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMbcgovRegion
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovRegion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMbcgovRegion
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovRegion(int? statecode = default(int?), int? statuscode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string bcgovRegionid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string bcgovRegionnumber = default(string), string bcgovAssignedareasofresponsiblities = default(string), long? versionnumber = default(long?), string _owningteamValue = default(string), string _createdbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _owneridValue = default(string), int? utcconversiontimezonecode = default(int?), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), string bcgovName = default(string), int? importsequencenumber = default(int?), string _createdonbehalfbyValue = default(string), string _bcgovInspectorValue = default(string), string _owningbusinessunitValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> bcgovRegionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovRegionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovRegionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> bcgovRegionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bcgovRegionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser bcgovInspector = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbcgovPostalcode> bcgovRegionBcgovPostalcodeRegion = default(IList<MicrosoftDynamicsCRMbcgovPostalcode>), IList<MicrosoftDynamicsCRMbcgovLocation> bcgovRegionLocationLocationRegion = default(IList<MicrosoftDynamicsCRMbcgovLocation>), IList<MicrosoftDynamicsCRMbcgovArea> bcgovRegionBcgovAreaRegion = default(IList<MicrosoftDynamicsCRMbcgovArea>))
        {
            Statecode = statecode;
            Statuscode = statuscode;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            BcgovRegionid = bcgovRegionid;
            Createdon = createdon;
            BcgovRegionnumber = bcgovRegionnumber;
            BcgovAssignedareasofresponsiblities = bcgovAssignedareasofresponsiblities;
            Versionnumber = versionnumber;
            this._owningteamValue = _owningteamValue;
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owneridValue = _owneridValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            this._owninguserValue = _owninguserValue;
            BcgovName = bcgovName;
            Importsequencenumber = importsequencenumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._bcgovInspectorValue = _bcgovInspectorValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BcgovRegionSyncErrors = bcgovRegionSyncErrors;
            BcgovRegionDuplicateMatchingRecord = bcgovRegionDuplicateMatchingRecord;
            BcgovRegionDuplicateBaseRecord = bcgovRegionDuplicateBaseRecord;
            BcgovRegionAsyncOperations = bcgovRegionAsyncOperations;
            BcgovRegionBulkDeleteFailures = bcgovRegionBulkDeleteFailures;
            BcgovInspector = bcgovInspector;
            BcgovRegionBcgovPostalcodeRegion = bcgovRegionBcgovPostalcodeRegion;
            BcgovRegionLocationLocationRegion = bcgovRegionLocationLocationRegion;
            BcgovRegionBcgovAreaRegion = bcgovRegionBcgovAreaRegion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_regionid")]
        public string BcgovRegionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_regionnumber")]
        public string BcgovRegionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_assignedareasofresponsiblities")]
        public string BcgovAssignedareasofresponsiblities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_name")]
        public string BcgovName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_inspector_value")]
        public string _bcgovInspectorValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_region_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BcgovRegionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_region_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovRegionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_region_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovRegionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_region_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BcgovRegionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_region_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BcgovRegionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_Inspector")]
        public MicrosoftDynamicsCRMsystemuser BcgovInspector { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_region_bcgov_postalcode_Region")]
        public IList<MicrosoftDynamicsCRMbcgovPostalcode> BcgovRegionBcgovPostalcodeRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_region_location_LocationRegion")]
        public IList<MicrosoftDynamicsCRMbcgovLocation> BcgovRegionLocationLocationRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_region_bcgov_area_Region")]
        public IList<MicrosoftDynamicsCRMbcgovArea> BcgovRegionBcgovAreaRegion { get; set; }

    }
}
