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
    /// abs_scheduledprocess
    /// </summary>
    public partial class MicrosoftDynamicsCRMabsScheduledprocess
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMabsScheduledprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMabsScheduledprocess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMabsScheduledprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMabsScheduledprocess(bool? absMonday = default(bool?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), bool? absSeptember = default(bool?), string absScheduledprocessid = default(string), string _owninguserValue = default(string), int? absRecurrencepattern = default(int?), int? importsequencenumber = default(int?), bool? absThursday = default(bool?), long? versionnumber = default(long?), bool? absJanuary = default(bool?), string _modifiedonbehalfbyValue = default(string), bool? absSunday = default(bool?), bool? absWednesday = default(bool?), bool? absOctober = default(bool?), bool? absMay = default(bool?), string absName = default(string), bool? absMarch = default(bool?), bool? absTuesday = default(bool?), bool? absAmpm = default(bool?), string absFetchxmlquery = default(string), bool? absFebruary = default(bool?), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), bool? absJuly = default(bool?), bool? absNovember = default(bool?), bool? absSaturday = default(bool?), int? absHour = default(int?), int? absInterval = default(int?), bool? absFriday = default(bool?), int? absMinute = default(int?), int? timezoneruleversionnumber = default(int?), int? absDayofmonth = default(int?), System.DateTimeOffset? absNextactivation = default(System.DateTimeOffset?), bool? absDecember = default(bool?), string _absProcessidValue = default(string), int? statuscode = default(int?), int? statecode = default(int?), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), bool? absSuspendonfailure = default(bool?), bool? absJune = default(bool?), string _owneridValue = default(string), string _owningteamValue = default(string), int? utcconversiontimezonecode = default(int?), bool? absAugust = default(bool?), bool? absApril = default(bool?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> absScheduledprocessActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> absScheduledprocessAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> absScheduledprocessEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> absScheduledprocessFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> absScheduledprocessLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> absScheduledprocessPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> absScheduledprocessServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> absScheduledprocessTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> absScheduledprocessRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> absScheduledprocessSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMsyncerror> absScheduledprocessSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> absScheduledprocessAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> absScheduledprocessBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> absScheduledprocessAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), MicrosoftDynamicsCRMworkflow absProcessId = default(MicrosoftDynamicsCRMworkflow))
        {
            AbsMonday = absMonday;
            Overriddencreatedon = overriddencreatedon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AbsSeptember = absSeptember;
            AbsScheduledprocessid = absScheduledprocessid;
            this._owninguserValue = _owninguserValue;
            AbsRecurrencepattern = absRecurrencepattern;
            Importsequencenumber = importsequencenumber;
            AbsThursday = absThursday;
            Versionnumber = versionnumber;
            AbsJanuary = absJanuary;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AbsSunday = absSunday;
            AbsWednesday = absWednesday;
            AbsOctober = absOctober;
            AbsMay = absMay;
            AbsName = absName;
            AbsMarch = absMarch;
            AbsTuesday = absTuesday;
            AbsAmpm = absAmpm;
            AbsFetchxmlquery = absFetchxmlquery;
            AbsFebruary = absFebruary;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            Createdon = createdon;
            AbsJuly = absJuly;
            AbsNovember = absNovember;
            AbsSaturday = absSaturday;
            AbsHour = absHour;
            AbsInterval = absInterval;
            AbsFriday = absFriday;
            AbsMinute = absMinute;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AbsDayofmonth = absDayofmonth;
            AbsNextactivation = absNextactivation;
            AbsDecember = absDecember;
            this._absProcessidValue = _absProcessidValue;
            Statuscode = statuscode;
            Statecode = statecode;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AbsSuspendonfailure = absSuspendonfailure;
            AbsJune = absJune;
            this._owneridValue = _owneridValue;
            this._owningteamValue = _owningteamValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AbsAugust = absAugust;
            AbsApril = absApril;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AbsScheduledprocessActivityPointers = absScheduledprocessActivityPointers;
            AbsScheduledprocessAppointments = absScheduledprocessAppointments;
            AbsScheduledprocessEmails = absScheduledprocessEmails;
            AbsScheduledprocessFaxes = absScheduledprocessFaxes;
            AbsScheduledprocessLetters = absScheduledprocessLetters;
            AbsScheduledprocessPhoneCalls = absScheduledprocessPhoneCalls;
            AbsScheduledprocessServiceAppointments = absScheduledprocessServiceAppointments;
            AbsScheduledprocessTasks = absScheduledprocessTasks;
            AbsScheduledprocessRecurringAppointmentMasters = absScheduledprocessRecurringAppointmentMasters;
            AbsScheduledprocessSocialActivities = absScheduledprocessSocialActivities;
            AbsScheduledprocessSyncErrors = absScheduledprocessSyncErrors;
            AbsScheduledprocessAsyncOperations = absScheduledprocessAsyncOperations;
            AbsScheduledprocessBulkDeleteFailures = absScheduledprocessBulkDeleteFailures;
            AbsScheduledprocessAbsScheduledprocessexecutions = absScheduledprocessAbsScheduledprocessexecutions;
            AbsProcessId = absProcessId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_monday")]
        public bool? AbsMonday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_september")]
        public bool? AbsSeptember { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessid")]
        public string AbsScheduledprocessid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_recurrencepattern")]
        public int? AbsRecurrencepattern { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_thursday")]
        public bool? AbsThursday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_january")]
        public bool? AbsJanuary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_sunday")]
        public bool? AbsSunday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_wednesday")]
        public bool? AbsWednesday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_october")]
        public bool? AbsOctober { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_may")]
        public bool? AbsMay { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_name")]
        public string AbsName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_march")]
        public bool? AbsMarch { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_tuesday")]
        public bool? AbsTuesday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_ampm")]
        public bool? AbsAmpm { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_fetchxmlquery")]
        public string AbsFetchxmlquery { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_february")]
        public bool? AbsFebruary { get; set; }

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
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_july")]
        public bool? AbsJuly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_november")]
        public bool? AbsNovember { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_saturday")]
        public bool? AbsSaturday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_hour")]
        public int? AbsHour { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_interval")]
        public int? AbsInterval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_friday")]
        public bool? AbsFriday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_minute")]
        public int? AbsMinute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_dayofmonth")]
        public int? AbsDayofmonth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_nextactivation")]
        public System.DateTimeOffset? AbsNextactivation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_december")]
        public bool? AbsDecember { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_abs_processid_value")]
        public string _absProcessidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_suspendonfailure")]
        public bool? AbsSuspendonfailure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_june")]
        public bool? AbsJune { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_august")]
        public bool? AbsAugust { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_april")]
        public bool? AbsApril { get; set; }

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
        [JsonProperty(PropertyName = "abs_scheduledprocess_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> AbsScheduledprocessActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> AbsScheduledprocessAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_Emails")]
        public IList<MicrosoftDynamicsCRMemail> AbsScheduledprocessEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> AbsScheduledprocessFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_Letters")]
        public IList<MicrosoftDynamicsCRMletter> AbsScheduledprocessLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> AbsScheduledprocessPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> AbsScheduledprocessServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> AbsScheduledprocessTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> AbsScheduledprocessRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> AbsScheduledprocessSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AbsScheduledprocessSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AbsScheduledprocessAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AbsScheduledprocessBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> AbsScheduledprocessAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_ProcessId")]
        public MicrosoftDynamicsCRMworkflow AbsProcessId { get; set; }

    }
}