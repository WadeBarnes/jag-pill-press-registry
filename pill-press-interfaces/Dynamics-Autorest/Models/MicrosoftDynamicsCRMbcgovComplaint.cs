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
    /// bcgov_complaint
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovComplaint
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovComplaint class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovComplaint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovComplaint class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovComplaint(string _createdbyValue = default(string), string bcgovName = default(string), bool? bcgovDocumentsuploaded = default(bool?), bool? bcgovLetterssent = default(bool?), string emailaddress = default(string), string bcgovEquipmentlocationcomments = default(string), string bcgovComplaintparticulars = default(string), string _owningbusinessunitValue = default(string), string _bcgovLocationValue = default(string), string _modifiedonbehalfbyValue = default(string), string bcgovNameofmanufacturer = default(string), string processid = default(string), string bcgovComplaintid = default(string), string _bcgovBusinesslegalnameValue = default(string), string _bcgovAssigntoValue = default(string), int? bcgovPillpressencapsulatorsize = default(int?), string bcgovDrrefusecomment = default(string), int? bcgovProgram = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string traversedpath = default(string), System.DateTimeOffset? bcgovIncidentdate = default(System.DateTimeOffset?), string bcgovEquipmenttypeother = default(string), int? statecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? bcgovComplaintsource = default(int?), bool? bcgovUploadedcomplaintdocs = default(bool?), int? bcgovHowwasequipmentbuilt = default(int?), int? bcgovEquipmenttype = default(int?), string bcgovModel = default(string), bool? bcgovReferraltora = default(bool?), int? statuscode = default(int?), bool? bcgovComplaintclosed = default(bool?), int? bcgovComplaintstatus = default(int?), string _owninguserValue = default(string), string bcgovDracceptcomment = default(string), string _stageidValue = default(string), string bcgovMake = default(string), int? bcgovLevelofequipmentautomation = default(int?), long? versionnumber = default(long?), int? bcgovDraction = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string _createdonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), string bcgovLocationofincident = default(string), bool? bcgovAcceptrefuse = default(bool?), string bcgovCustombuiltorkeypartserialnumber = default(string), string _bcgovLocationaddressValue = default(string), string bcgovSerialnumber = default(string), int? importsequencenumber = default(int?), string _owneridValue = default(string), string _bcgovEquipmentValue = default(string), string _owningteamValue = default(string), string bcgovConsiderations = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? bcgovComplaintdate = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> bcgovComplaintActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> bcgovComplaintAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> bcgovComplaintEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> bcgovComplaintFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> bcgovComplaintLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> bcgovComplaintPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> bcgovComplaintServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> bcgovComplaintTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> bcgovComplaintRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> bcgovComplaintSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> bcgovComplaintAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), IList<MicrosoftDynamicsCRMsyncerror> bcgovComplaintSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> bcgovComplaintActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMconnection> bcgovComplaintConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> bcgovComplaintConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovComplaintDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovComplaintDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMqueueitem> bcgovComplaintQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMannotation> bcgovComplaintAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> bcgovComplaintAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bcgovComplaintBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMprocessstage stageid = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMaccount bcgovBusinessLegalName = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMbcgovLocation bcgovLocation = default(MicrosoftDynamicsCRMbcgovLocation), MicrosoftDynamicsCRMbcgovEquipment bcgovEquipment = default(MicrosoftDynamicsCRMbcgovEquipment), MicrosoftDynamicsCRMbcgovCustomaddress bcgovLocationAddress = default(MicrosoftDynamicsCRMbcgovCustomaddress), MicrosoftDynamicsCRMsystemuser bcgovAssignTo = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbcgovCecontact> bcgovComplaintCecontact = default(IList<MicrosoftDynamicsCRMbcgovCecontact>))
        {
            this._createdbyValue = _createdbyValue;
            BcgovName = bcgovName;
            BcgovDocumentsuploaded = bcgovDocumentsuploaded;
            BcgovLetterssent = bcgovLetterssent;
            Emailaddress = emailaddress;
            BcgovEquipmentlocationcomments = bcgovEquipmentlocationcomments;
            BcgovComplaintparticulars = bcgovComplaintparticulars;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._bcgovLocationValue = _bcgovLocationValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            BcgovNameofmanufacturer = bcgovNameofmanufacturer;
            Processid = processid;
            BcgovComplaintid = bcgovComplaintid;
            this._bcgovBusinesslegalnameValue = _bcgovBusinesslegalnameValue;
            this._bcgovAssigntoValue = _bcgovAssigntoValue;
            BcgovPillpressencapsulatorsize = bcgovPillpressencapsulatorsize;
            BcgovDrrefusecomment = bcgovDrrefusecomment;
            BcgovProgram = bcgovProgram;
            Createdon = createdon;
            Traversedpath = traversedpath;
            BcgovIncidentdate = bcgovIncidentdate;
            BcgovEquipmenttypeother = bcgovEquipmenttypeother;
            Statecode = statecode;
            Modifiedon = modifiedon;
            BcgovComplaintsource = bcgovComplaintsource;
            BcgovUploadedcomplaintdocs = bcgovUploadedcomplaintdocs;
            BcgovHowwasequipmentbuilt = bcgovHowwasequipmentbuilt;
            BcgovEquipmenttype = bcgovEquipmenttype;
            BcgovModel = bcgovModel;
            BcgovReferraltora = bcgovReferraltora;
            Statuscode = statuscode;
            BcgovComplaintclosed = bcgovComplaintclosed;
            BcgovComplaintstatus = bcgovComplaintstatus;
            this._owninguserValue = _owninguserValue;
            BcgovDracceptcomment = bcgovDracceptcomment;
            this._stageidValue = _stageidValue;
            BcgovMake = bcgovMake;
            BcgovLevelofequipmentautomation = bcgovLevelofequipmentautomation;
            Versionnumber = versionnumber;
            BcgovDraction = bcgovDraction;
            Overriddencreatedon = overriddencreatedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            BcgovLocationofincident = bcgovLocationofincident;
            BcgovAcceptrefuse = bcgovAcceptrefuse;
            BcgovCustombuiltorkeypartserialnumber = bcgovCustombuiltorkeypartserialnumber;
            this._bcgovLocationaddressValue = _bcgovLocationaddressValue;
            BcgovSerialnumber = bcgovSerialnumber;
            Importsequencenumber = importsequencenumber;
            this._owneridValue = _owneridValue;
            this._bcgovEquipmentValue = _bcgovEquipmentValue;
            this._owningteamValue = _owningteamValue;
            BcgovConsiderations = bcgovConsiderations;
            this._modifiedbyValue = _modifiedbyValue;
            BcgovComplaintdate = bcgovComplaintdate;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BcgovComplaintActivityPointers = bcgovComplaintActivityPointers;
            BcgovComplaintAppointments = bcgovComplaintAppointments;
            BcgovComplaintEmails = bcgovComplaintEmails;
            BcgovComplaintFaxes = bcgovComplaintFaxes;
            BcgovComplaintLetters = bcgovComplaintLetters;
            BcgovComplaintPhoneCalls = bcgovComplaintPhoneCalls;
            BcgovComplaintServiceAppointments = bcgovComplaintServiceAppointments;
            BcgovComplaintTasks = bcgovComplaintTasks;
            BcgovComplaintRecurringAppointmentMasters = bcgovComplaintRecurringAppointmentMasters;
            BcgovComplaintSocialActivities = bcgovComplaintSocialActivities;
            BcgovComplaintAbsScheduledprocessexecutions = bcgovComplaintAbsScheduledprocessexecutions;
            BcgovComplaintSyncErrors = bcgovComplaintSyncErrors;
            BcgovComplaintActivityParties = bcgovComplaintActivityParties;
            BcgovComplaintConnections1 = bcgovComplaintConnections1;
            BcgovComplaintConnections2 = bcgovComplaintConnections2;
            BcgovComplaintDuplicateMatchingRecord = bcgovComplaintDuplicateMatchingRecord;
            BcgovComplaintDuplicateBaseRecord = bcgovComplaintDuplicateBaseRecord;
            BcgovComplaintQueueItems = bcgovComplaintQueueItems;
            BcgovComplaintAnnotations = bcgovComplaintAnnotations;
            BcgovComplaintAsyncOperations = bcgovComplaintAsyncOperations;
            BcgovComplaintBulkDeleteFailures = bcgovComplaintBulkDeleteFailures;
            Stageid = stageid;
            BcgovBusinessLegalName = bcgovBusinessLegalName;
            BcgovLocation = bcgovLocation;
            BcgovEquipment = bcgovEquipment;
            BcgovLocationAddress = bcgovLocationAddress;
            BcgovAssignTo = bcgovAssignTo;
            BcgovComplaintCecontact = bcgovComplaintCecontact;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_name")]
        public string BcgovName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_documentsuploaded")]
        public bool? BcgovDocumentsuploaded { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_letterssent")]
        public bool? BcgovLetterssent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipmentlocationcomments")]
        public string BcgovEquipmentlocationcomments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaintparticulars")]
        public string BcgovComplaintparticulars { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_location_value")]
        public string _bcgovLocationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_nameofmanufacturer")]
        public string BcgovNameofmanufacturer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaintid")]
        public string BcgovComplaintid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_businesslegalname_value")]
        public string _bcgovBusinesslegalnameValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_assignto_value")]
        public string _bcgovAssigntoValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_pillpressencapsulatorsize")]
        public int? BcgovPillpressencapsulatorsize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_drrefusecomment")]
        public string BcgovDrrefusecomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_program")]
        public int? BcgovProgram { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_incidentdate")]
        public System.DateTimeOffset? BcgovIncidentdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipmenttypeother")]
        public string BcgovEquipmenttypeother { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaintsource")]
        public int? BcgovComplaintsource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_uploadedcomplaintdocs")]
        public bool? BcgovUploadedcomplaintdocs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_howwasequipmentbuilt")]
        public int? BcgovHowwasequipmentbuilt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipmenttype")]
        public int? BcgovEquipmenttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_model")]
        public string BcgovModel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_referraltora")]
        public bool? BcgovReferraltora { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaintclosed")]
        public bool? BcgovComplaintclosed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaintstatus")]
        public int? BcgovComplaintstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_dracceptcomment")]
        public string BcgovDracceptcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_stageid_value")]
        public string _stageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_make")]
        public string BcgovMake { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_levelofequipmentautomation")]
        public int? BcgovLevelofequipmentautomation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_draction")]
        public int? BcgovDraction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_locationofincident")]
        public string BcgovLocationofincident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_acceptrefuse")]
        public bool? BcgovAcceptrefuse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_custombuiltorkeypartserialnumber")]
        public string BcgovCustombuiltorkeypartserialnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_locationaddress_value")]
        public string _bcgovLocationaddressValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_serialnumber")]
        public string BcgovSerialnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_equipment_value")]
        public string _bcgovEquipmentValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_considerations")]
        public string BcgovConsiderations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaintdate")]
        public System.DateTimeOffset? BcgovComplaintdate { get; set; }

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
        [JsonProperty(PropertyName = "bcgov_complaint_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> BcgovComplaintActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> BcgovComplaintAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_Emails")]
        public IList<MicrosoftDynamicsCRMemail> BcgovComplaintEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> BcgovComplaintFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_Letters")]
        public IList<MicrosoftDynamicsCRMletter> BcgovComplaintLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> BcgovComplaintPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> BcgovComplaintServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> BcgovComplaintTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> BcgovComplaintRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> BcgovComplaintSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> BcgovComplaintAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BcgovComplaintSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_ActivityParties")]
        public IList<MicrosoftDynamicsCRMactivityparty> BcgovComplaintActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> BcgovComplaintConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> BcgovComplaintConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovComplaintDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovComplaintDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> BcgovComplaintQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> BcgovComplaintAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BcgovComplaintAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BcgovComplaintBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public MicrosoftDynamicsCRMprocessstage Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_BusinessLegalName")]
        public MicrosoftDynamicsCRMaccount BcgovBusinessLegalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_Location")]
        public MicrosoftDynamicsCRMbcgovLocation BcgovLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_Equipment")]
        public MicrosoftDynamicsCRMbcgovEquipment BcgovEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_LocationAddress")]
        public MicrosoftDynamicsCRMbcgovCustomaddress BcgovLocationAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_AssignTo")]
        public MicrosoftDynamicsCRMsystemuser BcgovAssignTo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_cecontact")]
        public IList<MicrosoftDynamicsCRMbcgovCecontact> BcgovComplaintCecontact { get; set; }

    }
}
