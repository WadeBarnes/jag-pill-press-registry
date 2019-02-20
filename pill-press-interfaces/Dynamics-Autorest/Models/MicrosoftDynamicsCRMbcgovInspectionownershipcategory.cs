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
    /// bcgov_inspectionownershipcategory
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovInspectionownershipcategory
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovInspectionownershipcategory class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovInspectionownershipcategory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovInspectionownershipcategory class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovInspectionownershipcategory(int? statuscode = default(int?), string _createdbyValue = default(string), string _stageidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningteamValue = default(string), string _owneridValue = default(string), string traversedpath = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string _owninguserValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), string processid = default(string), string _owningbusinessunitValue = default(string), string bcgovName = default(string), string _modifiedonbehalfbyValue = default(string), int? statecode = default(int?), long? versionnumber = default(long?), int? utcconversiontimezonecode = default(int?), string bcgovInspectionownershipcategoryid = default(string), string _modifiedbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> bcgovInspectionownershipcategoryActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> bcgovInspectionownershipcategoryAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> bcgovInspectionownershipcategoryEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> bcgovInspectionownershipcategoryFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> bcgovInspectionownershipcategoryLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> bcgovInspectionownershipcategoryPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> bcgovInspectionownershipcategoryServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> bcgovInspectionownershipcategoryTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> bcgovInspectionownershipcategoryRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> bcgovInspectionownershipcategorySocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> bcgovInspectionownershipcategoryAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), IList<MicrosoftDynamicsCRMsyncerror> bcgovInspectionownershipcategorySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovInspectionownershipcategoryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovInspectionownershipcategoryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> bcgovInspectionownershipcategorySharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMqueueitem> bcgovInspectionownershipcategoryQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMannotation> bcgovInspectionownershipcategoryAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> bcgovInspectionownershipcategoryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bcgovInspectionownershipcategoryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMprocessstage stageid = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMknowledgebaserecord> bcgovInspectionownershipcategoryKnowledgebaserecord = default(IList<MicrosoftDynamicsCRMknowledgebaserecord>), IList<MicrosoftDynamicsCRMknowledgearticle> msdynBcgovInspectionownershipcategoryKnowledgearticle = default(IList<MicrosoftDynamicsCRMknowledgearticle>))
        {
            Statuscode = statuscode;
            this._createdbyValue = _createdbyValue;
            this._stageidValue = _stageidValue;
            Createdon = createdon;
            this._owningteamValue = _owningteamValue;
            this._owneridValue = _owneridValue;
            Traversedpath = traversedpath;
            Overriddencreatedon = overriddencreatedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owninguserValue = _owninguserValue;
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Processid = processid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            BcgovName = bcgovName;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Statecode = statecode;
            Versionnumber = versionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            BcgovInspectionownershipcategoryid = bcgovInspectionownershipcategoryid;
            this._modifiedbyValue = _modifiedbyValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BcgovInspectionownershipcategoryActivityPointers = bcgovInspectionownershipcategoryActivityPointers;
            BcgovInspectionownershipcategoryAppointments = bcgovInspectionownershipcategoryAppointments;
            BcgovInspectionownershipcategoryEmails = bcgovInspectionownershipcategoryEmails;
            BcgovInspectionownershipcategoryFaxes = bcgovInspectionownershipcategoryFaxes;
            BcgovInspectionownershipcategoryLetters = bcgovInspectionownershipcategoryLetters;
            BcgovInspectionownershipcategoryPhoneCalls = bcgovInspectionownershipcategoryPhoneCalls;
            BcgovInspectionownershipcategoryServiceAppointments = bcgovInspectionownershipcategoryServiceAppointments;
            BcgovInspectionownershipcategoryTasks = bcgovInspectionownershipcategoryTasks;
            BcgovInspectionownershipcategoryRecurringAppointmentMasters = bcgovInspectionownershipcategoryRecurringAppointmentMasters;
            BcgovInspectionownershipcategorySocialActivities = bcgovInspectionownershipcategorySocialActivities;
            BcgovInspectionownershipcategoryAbsScheduledprocessexecutions = bcgovInspectionownershipcategoryAbsScheduledprocessexecutions;
            BcgovInspectionownershipcategorySyncErrors = bcgovInspectionownershipcategorySyncErrors;
            BcgovInspectionownershipcategoryDuplicateMatchingRecord = bcgovInspectionownershipcategoryDuplicateMatchingRecord;
            BcgovInspectionownershipcategoryDuplicateBaseRecord = bcgovInspectionownershipcategoryDuplicateBaseRecord;
            BcgovInspectionownershipcategorySharePointDocumentLocations = bcgovInspectionownershipcategorySharePointDocumentLocations;
            BcgovInspectionownershipcategoryQueueItems = bcgovInspectionownershipcategoryQueueItems;
            BcgovInspectionownershipcategoryAnnotations = bcgovInspectionownershipcategoryAnnotations;
            BcgovInspectionownershipcategoryAsyncOperations = bcgovInspectionownershipcategoryAsyncOperations;
            BcgovInspectionownershipcategoryBulkDeleteFailures = bcgovInspectionownershipcategoryBulkDeleteFailures;
            Stageid = stageid;
            BcgovInspectionownershipcategoryKnowledgebaserecord = bcgovInspectionownershipcategoryKnowledgebaserecord;
            MsdynBcgovInspectionownershipcategoryKnowledgearticle = msdynBcgovInspectionownershipcategoryKnowledgearticle;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_stageid_value")]
        public string _stageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_name")]
        public string BcgovName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategoryid")]
        public string BcgovInspectionownershipcategoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

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
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> BcgovInspectionownershipcategoryActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> BcgovInspectionownershipcategoryAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_Emails")]
        public IList<MicrosoftDynamicsCRMemail> BcgovInspectionownershipcategoryEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> BcgovInspectionownershipcategoryFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_Letters")]
        public IList<MicrosoftDynamicsCRMletter> BcgovInspectionownershipcategoryLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> BcgovInspectionownershipcategoryPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> BcgovInspectionownershipcategoryServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> BcgovInspectionownershipcategoryTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> BcgovInspectionownershipcategoryRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> BcgovInspectionownershipcategorySocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> BcgovInspectionownershipcategoryAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BcgovInspectionownershipcategorySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovInspectionownershipcategoryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovInspectionownershipcategoryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> BcgovInspectionownershipcategorySharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> BcgovInspectionownershipcategoryQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> BcgovInspectionownershipcategoryAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BcgovInspectionownershipcategoryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BcgovInspectionownershipcategoryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public MicrosoftDynamicsCRMprocessstage Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategory_knowledgebaserecord")]
        public IList<MicrosoftDynamicsCRMknowledgebaserecord> BcgovInspectionownershipcategoryKnowledgebaserecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_bcgov_inspectionownershipcategory_knowledgearticle")]
        public IList<MicrosoftDynamicsCRMknowledgearticle> MsdynBcgovInspectionownershipcategoryKnowledgearticle { get; set; }

    }
}