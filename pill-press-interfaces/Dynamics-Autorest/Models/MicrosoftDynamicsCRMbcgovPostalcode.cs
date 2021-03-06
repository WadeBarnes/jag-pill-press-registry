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
    /// bcgov_postalcode
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovPostalcode
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovPostalcode class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovPostalcode()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovPostalcode class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovPostalcode(string _owninguserValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owneridValue = default(string), string _bcgovRegionValue = default(string), int? statecode = default(int?), string bcgovPostalcodeid = default(string), int? utcconversiontimezonecode = default(int?), int? statuscode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string _bcgovAreaValue = default(string), int? importsequencenumber = default(int?), long? versionnumber = default(long?), string _modifiedonbehalfbyValue = default(string), string _owningteamValue = default(string), string bcgovName = default(string), int? timezoneruleversionnumber = default(int?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string _createdbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> bcgovPostalcodeSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovPostalcodeDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovPostalcodeDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> bcgovPostalcodeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bcgovPostalcodeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMbcgovRegion bcgovRegion = default(MicrosoftDynamicsCRMbcgovRegion), MicrosoftDynamicsCRMbcgovArea bcgovArea = default(MicrosoftDynamicsCRMbcgovArea))
        {
            this._owninguserValue = _owninguserValue;
            Modifiedon = modifiedon;
            this._owneridValue = _owneridValue;
            this._bcgovRegionValue = _bcgovRegionValue;
            Statecode = statecode;
            BcgovPostalcodeid = bcgovPostalcodeid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statuscode = statuscode;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._bcgovAreaValue = _bcgovAreaValue;
            Importsequencenumber = importsequencenumber;
            Versionnumber = versionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owningteamValue = _owningteamValue;
            BcgovName = bcgovName;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BcgovPostalcodeSyncErrors = bcgovPostalcodeSyncErrors;
            BcgovPostalcodeDuplicateMatchingRecord = bcgovPostalcodeDuplicateMatchingRecord;
            BcgovPostalcodeDuplicateBaseRecord = bcgovPostalcodeDuplicateBaseRecord;
            BcgovPostalcodeAsyncOperations = bcgovPostalcodeAsyncOperations;
            BcgovPostalcodeBulkDeleteFailures = bcgovPostalcodeBulkDeleteFailures;
            BcgovRegion = bcgovRegion;
            BcgovArea = bcgovArea;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_region_value")]
        public string _bcgovRegionValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_postalcodeid")]
        public string BcgovPostalcodeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_area_value")]
        public string _bcgovAreaValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_name")]
        public string BcgovName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

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
        [JsonProperty(PropertyName = "bcgov_postalcode_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BcgovPostalcodeSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_postalcode_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovPostalcodeDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_postalcode_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovPostalcodeDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_postalcode_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BcgovPostalcodeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_postalcode_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BcgovPostalcodeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_Region")]
        public MicrosoftDynamicsCRMbcgovRegion BcgovRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_Area")]
        public MicrosoftDynamicsCRMbcgovArea BcgovArea { get; set; }

    }
}
