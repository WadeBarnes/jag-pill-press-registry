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
    /// processstage
    /// </summary>
    public partial class MicrosoftDynamicsCRMprocessstage
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMprocessstage
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMprocessstage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMprocessstage
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMprocessstage(long? versionnumber = default(long?), string processstageid = default(string), int? stagecategory = default(int?), string owningbusinessunit = default(string), string _processidValue = default(string), string _owneridValue = default(string), string primaryentitytypecode = default(string), string clientdata = default(string), string stagename = default(string), IList<MicrosoftDynamicsCRMknowledgearticle> processstageKnowledgearticle = default(IList<MicrosoftDynamicsCRMknowledgearticle>), IList<MicrosoftDynamicsCRMsalesorder> processstageSalesorders = default(IList<MicrosoftDynamicsCRMsalesorder>), IList<MicrosoftDynamicsCRMcontact> processstageContact = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMlist> processstageLists = default(IList<MicrosoftDynamicsCRMlist>), IList<MicrosoftDynamicsCRMfax> processstageFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMteam> processstageTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMsyncerror> processStageSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMletter> processstageLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMinvoice> processstageInvoices = default(IList<MicrosoftDynamicsCRMinvoice>), IList<MicrosoftDynamicsCRMcampaignresponse> processstageCampaignresponses = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMappointment> processstageAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMcompetitor> processstageCompetitors = default(IList<MicrosoftDynamicsCRMcompetitor>), IList<MicrosoftDynamicsCRMproductpricelevel> processstageProductpricelevels = default(IList<MicrosoftDynamicsCRMproductpricelevel>), IList<MicrosoftDynamicsCRMsalesliterature> processstageSalesliteratures = default(IList<MicrosoftDynamicsCRMsalesliterature>), IList<MicrosoftDynamicsCRMopportunitysalesprocess> processstageOpportunitysalesprocess = default(IList<MicrosoftDynamicsCRMopportunitysalesprocess>), IList<MicrosoftDynamicsCRMexpiredprocess> processstageExpiredprocess = default(IList<MicrosoftDynamicsCRMexpiredprocess>), IList<MicrosoftDynamicsCRMquote> processstageQuotes = default(IList<MicrosoftDynamicsCRMquote>), IList<MicrosoftDynamicsCRMtask> processstageTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMnewprocess> processstageNewprocess = default(IList<MicrosoftDynamicsCRMnewprocess>), IList<MicrosoftDynamicsCRMincident> processstageIncident = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMopportunity> processstageOpportunity = default(IList<MicrosoftDynamicsCRMopportunity>), IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess> processstageLeadtoopportunitysalesprocess = default(IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess>), IList<MicrosoftDynamicsCRMphonecall> processstagePhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMphonetocaseprocess> processstagePhonetocaseprocess = default(IList<MicrosoftDynamicsCRMphonetocaseprocess>), IList<MicrosoftDynamicsCRMproduct> processstageProducts = default(IList<MicrosoftDynamicsCRMproduct>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> processstageRecurringappointmentmasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsystemuser> processstageSystemusers = default(IList<MicrosoftDynamicsCRMsystemuser>), MicrosoftDynamicsCRMworkflow processid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMcampaign> processstageCampaigns = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMlead> processstageLead = default(IList<MicrosoftDynamicsCRMlead>), IList<MicrosoftDynamicsCRMcampaignactivity> processstageCampaignactivities = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMemail> processstageEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMtranslationprocess> processstageTranslationprocess = default(IList<MicrosoftDynamicsCRMtranslationprocess>), IList<MicrosoftDynamicsCRMaccount> processstageAccount = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMbcgovCustomaddress> processstageBcgovCustomaddress = default(IList<MicrosoftDynamicsCRMbcgovCustomaddress>), IList<MicrosoftDynamicsCRMbcgovCustomproduct> processstageBcgovCustomproduct = default(IList<MicrosoftDynamicsCRMbcgovCustomproduct>), IList<MicrosoftDynamicsCRMbcgovEquipment> processstageBcgovEquipment = default(IList<MicrosoftDynamicsCRMbcgovEquipment>), IList<MicrosoftDynamicsCRMbcgovLocation> processstageBcgovLocation = default(IList<MicrosoftDynamicsCRMbcgovLocation>), IList<MicrosoftDynamicsCRMbcgovInspection> processstageBcgovInspection = default(IList<MicrosoftDynamicsCRMbcgovInspection>))
        {
            Versionnumber = versionnumber;
            Processstageid = processstageid;
            Stagecategory = stagecategory;
            Owningbusinessunit = owningbusinessunit;
            this._processidValue = _processidValue;
            this._owneridValue = _owneridValue;
            Primaryentitytypecode = primaryentitytypecode;
            Clientdata = clientdata;
            Stagename = stagename;
            ProcessstageKnowledgearticle = processstageKnowledgearticle;
            ProcessstageSalesorders = processstageSalesorders;
            ProcessstageContact = processstageContact;
            ProcessstageLists = processstageLists;
            ProcessstageFaxes = processstageFaxes;
            ProcessstageTeams = processstageTeams;
            ProcessStageSyncErrors = processStageSyncErrors;
            ProcessstageLetters = processstageLetters;
            ProcessstageInvoices = processstageInvoices;
            ProcessstageCampaignresponses = processstageCampaignresponses;
            ProcessstageAppointments = processstageAppointments;
            ProcessstageCompetitors = processstageCompetitors;
            ProcessstageProductpricelevels = processstageProductpricelevels;
            ProcessstageSalesliteratures = processstageSalesliteratures;
            ProcessstageOpportunitysalesprocess = processstageOpportunitysalesprocess;
            ProcessstageExpiredprocess = processstageExpiredprocess;
            ProcessstageQuotes = processstageQuotes;
            ProcessstageTasks = processstageTasks;
            ProcessstageNewprocess = processstageNewprocess;
            ProcessstageIncident = processstageIncident;
            ProcessstageOpportunity = processstageOpportunity;
            ProcessstageLeadtoopportunitysalesprocess = processstageLeadtoopportunitysalesprocess;
            ProcessstagePhonecalls = processstagePhonecalls;
            ProcessstagePhonetocaseprocess = processstagePhonetocaseprocess;
            ProcessstageProducts = processstageProducts;
            ProcessstageRecurringappointmentmasters = processstageRecurringappointmentmasters;
            ProcessstageSystemusers = processstageSystemusers;
            Processid = processid;
            ProcessstageCampaigns = processstageCampaigns;
            ProcessstageLead = processstageLead;
            ProcessstageCampaignactivities = processstageCampaignactivities;
            ProcessstageEmails = processstageEmails;
            ProcessstageTranslationprocess = processstageTranslationprocess;
            ProcessstageAccount = processstageAccount;
            ProcessstageBcgovCustomaddress = processstageBcgovCustomaddress;
            ProcessstageBcgovCustomproduct = processstageBcgovCustomproduct;
            ProcessstageBcgovEquipment = processstageBcgovEquipment;
            ProcessstageBcgovLocation = processstageBcgovLocation;
            ProcessstageBcgovInspection = processstageBcgovInspection;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstageid")]
        public string Processstageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stagecategory")]
        public int? Stagecategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentitytypecode")]
        public string Primaryentitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientdata")]
        public string Clientdata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stagename")]
        public string Stagename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_knowledgearticle")]
        public IList<MicrosoftDynamicsCRMknowledgearticle> ProcessstageKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_salesorders")]
        public IList<MicrosoftDynamicsCRMsalesorder> ProcessstageSalesorders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_contact")]
        public IList<MicrosoftDynamicsCRMcontact> ProcessstageContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_lists")]
        public IList<MicrosoftDynamicsCRMlist> ProcessstageLists { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_faxes")]
        public IList<MicrosoftDynamicsCRMfax> ProcessstageFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_teams")]
        public IList<MicrosoftDynamicsCRMteam> ProcessstageTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProcessStage_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ProcessStageSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_letters")]
        public IList<MicrosoftDynamicsCRMletter> ProcessstageLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_invoices")]
        public IList<MicrosoftDynamicsCRMinvoice> ProcessstageInvoices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_campaignresponses")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> ProcessstageCampaignresponses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_appointments")]
        public IList<MicrosoftDynamicsCRMappointment> ProcessstageAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_competitors")]
        public IList<MicrosoftDynamicsCRMcompetitor> ProcessstageCompetitors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_productpricelevels")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> ProcessstageProductpricelevels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_salesliteratures")]
        public IList<MicrosoftDynamicsCRMsalesliterature> ProcessstageSalesliteratures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_opportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMopportunitysalesprocess> ProcessstageOpportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_expiredprocess")]
        public IList<MicrosoftDynamicsCRMexpiredprocess> ProcessstageExpiredprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_quotes")]
        public IList<MicrosoftDynamicsCRMquote> ProcessstageQuotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_tasks")]
        public IList<MicrosoftDynamicsCRMtask> ProcessstageTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_newprocess")]
        public IList<MicrosoftDynamicsCRMnewprocess> ProcessstageNewprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_incident")]
        public IList<MicrosoftDynamicsCRMincident> ProcessstageIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_opportunity")]
        public IList<MicrosoftDynamicsCRMopportunity> ProcessstageOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_leadtoopportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess> ProcessstageLeadtoopportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> ProcessstagePhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_phonetocaseprocess")]
        public IList<MicrosoftDynamicsCRMphonetocaseprocess> ProcessstagePhonetocaseprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_products")]
        public IList<MicrosoftDynamicsCRMproduct> ProcessstageProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_recurringappointmentmasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> ProcessstageRecurringappointmentmasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_systemusers")]
        public IList<MicrosoftDynamicsCRMsystemuser> ProcessstageSystemusers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public MicrosoftDynamicsCRMworkflow Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_campaigns")]
        public IList<MicrosoftDynamicsCRMcampaign> ProcessstageCampaigns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_lead")]
        public IList<MicrosoftDynamicsCRMlead> ProcessstageLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_campaignactivities")]
        public IList<MicrosoftDynamicsCRMcampaignactivity> ProcessstageCampaignactivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_emails")]
        public IList<MicrosoftDynamicsCRMemail> ProcessstageEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_translationprocess")]
        public IList<MicrosoftDynamicsCRMtranslationprocess> ProcessstageTranslationprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_account")]
        public IList<MicrosoftDynamicsCRMaccount> ProcessstageAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_bcgov_customaddress")]
        public IList<MicrosoftDynamicsCRMbcgovCustomaddress> ProcessstageBcgovCustomaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_bcgov_customproduct")]
        public IList<MicrosoftDynamicsCRMbcgovCustomproduct> ProcessstageBcgovCustomproduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_bcgov_equipment")]
        public IList<MicrosoftDynamicsCRMbcgovEquipment> ProcessstageBcgovEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_bcgov_location")]
        public IList<MicrosoftDynamicsCRMbcgovLocation> ProcessstageBcgovLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_bcgov_inspection")]
        public IList<MicrosoftDynamicsCRMbcgovInspection> ProcessstageBcgovInspection { get; set; }

    }
}
