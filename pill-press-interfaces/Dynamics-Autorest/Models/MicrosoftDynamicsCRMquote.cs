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
    /// quote
    /// </summary>
    public partial class MicrosoftDynamicsCRMquote
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMquote class.
        /// </summary>
        public MicrosoftDynamicsCRMquote()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMquote class.
        /// </summary>
        public MicrosoftDynamicsCRMquote(int? statuscode = default(int?), string billtoStateorprovince = default(string), string processid = default(string), string stageid = default(string), int? onholdtime = default(int?), string quotenumber = default(string), System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), string billtoComposite = default(string), string billtoLine1 = default(string), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string billtoFax = default(string), object totaltaxBase = default(object), string shiptoAddressid = default(string), string _owninguserValue = default(string), string shiptoComposite = default(string), string shiptoCountry = default(string), object totallineitemamount = default(object), System.DateTimeOffset? requestdeliveryby = default(System.DateTimeOffset?), string _customeridValue = default(string), string billtoContactname = default(string), int? utcconversiontimezonecode = default(int?), string _pricelevelidValue = default(string), string shiptoName = default(string), object totalamount = default(object), string _contactidValue = default(string), object freightamount = default(object), string billtoTelephone = default(string), object totallineitemamountBase = default(object), int? pricingerrorcode = default(int?), string description = default(string), object totaldiscountamount = default(object), string _accountidValue = default(string), string _opportunityidValue = default(string), string shiptoLine1 = default(string), string billtoAddressid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? effectiveto = default(System.DateTimeOffset?), string shiptoCity = default(string), string billtoName = default(string), System.DateTimeOffset? expireson = default(System.DateTimeOffset?), object totalamountlessfreight = default(object), bool? willcall = default(bool?), System.DateTimeOffset? closedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), object freightamountBase = default(object), object totaltax = default(object), string shiptoTelephone = default(string), string _slainvokedidValue = default(string), int? statecode = default(int?), string traversedpath = default(string), string billtoPostalcode = default(string), string billtoCity = default(string), string _owneridValue = default(string), string billtoLine2 = default(string), string quoteid = default(string), object totalamountlessfreightBase = default(object), object discountpercentage = default(object), int? shiptoFreighttermscode = default(int?), object discountamount = default(object), string shiptoLine3 = default(string), string billtoLine3 = default(string), System.DateTimeOffset? effectivefrom = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string shiptoContactname = default(string), string _createdbyValue = default(string), string _slaidValue = default(string), int? revisionnumber = default(int?), string _owningteamValue = default(string), object discountamountBase = default(object), string shiptoStateorprovince = default(string), string shiptoPostalcode = default(string), object totalamountBase = default(object), string _transactioncurrencyidValue = default(string), string _owningbusinessunitValue = default(string), long? versionnumber = default(long?), string _modifiedbyValue = default(string), object totallineitemdiscountamountBase = default(object), object totallineitemdiscountamount = default(object), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string shiptoLine2 = default(string), int? paymenttermscode = default(int?), string shiptoFax = default(string), object exchangerate = default(object), string name = default(string), object totaldiscountamountBase = default(object), string _campaignidValue = default(string), int? shippingmethodcode = default(int?), string billtoCountry = default(string), int? freighttermscode = default(int?), IList<MicrosoftDynamicsCRMcontact> contactquotesAssociation = default(IList<MicrosoftDynamicsCRMcontact>), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMopportunitysalesprocess> quoteOpportunitysalesprocess = default(IList<MicrosoftDynamicsCRMopportunitysalesprocess>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> quoteSharepointDocumentLocation = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMquoteclose> quoteQuoteClose = default(IList<MicrosoftDynamicsCRMquoteclose>), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMconnection> quoteConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMconnection> quoteConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMletter> quoteLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMbulkdeletefailure> quoteBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMtask> quoteTasks = default(IList<MicrosoftDynamicsCRMtask>), MicrosoftDynamicsCRMsla slainvokedidQuoteSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMsocialactivity> quoteSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), MicrosoftDynamicsCRMsla slaQuoteSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMactivitypointer> quoteActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsalesorder> quoteOrders = default(IList<MicrosoftDynamicsCRMsalesorder>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMappointment> quoteAppointments = default(IList<MicrosoftDynamicsCRMappointment>), MicrosoftDynamicsCRMpricelevel pricelevelid = default(MicrosoftDynamicsCRMpricelevel), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMduplicaterecord> quoteDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMactivityparty> quoteActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMfax> quoteFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMsyncerror> quoteSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMserviceappointment> quoteServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMasyncoperation> quoteAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> quoteRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceQuote = default(IList<MicrosoftDynamicsCRMslakpiinstance>), IList<MicrosoftDynamicsCRMannotation> quoteAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMquotedetail> quoteDetails = default(IList<MicrosoftDynamicsCRMquotedetail>), IList<MicrosoftDynamicsCRMphonecall> quotePhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMopportunity opportunityid = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMemail> quoteEmails = default(IList<MicrosoftDynamicsCRMemail>), MicrosoftDynamicsCRMcampaign campaignid = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMduplicaterecord> quoteDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> quoteAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>))
        {
            Statuscode = statuscode;
            BilltoStateorprovince = billtoStateorprovince;
            Processid = processid;
            Stageid = stageid;
            Onholdtime = onholdtime;
            Quotenumber = quotenumber;
            Lastonholdtime = lastonholdtime;
            BilltoComposite = billtoComposite;
            BilltoLine1 = billtoLine1;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            BilltoFax = billtoFax;
            TotaltaxBase = totaltaxBase;
            ShiptoAddressid = shiptoAddressid;
            this._owninguserValue = _owninguserValue;
            ShiptoComposite = shiptoComposite;
            ShiptoCountry = shiptoCountry;
            Totallineitemamount = totallineitemamount;
            Requestdeliveryby = requestdeliveryby;
            this._customeridValue = _customeridValue;
            BilltoContactname = billtoContactname;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._pricelevelidValue = _pricelevelidValue;
            ShiptoName = shiptoName;
            Totalamount = totalamount;
            this._contactidValue = _contactidValue;
            Freightamount = freightamount;
            BilltoTelephone = billtoTelephone;
            TotallineitemamountBase = totallineitemamountBase;
            Pricingerrorcode = pricingerrorcode;
            Description = description;
            Totaldiscountamount = totaldiscountamount;
            this._accountidValue = _accountidValue;
            this._opportunityidValue = _opportunityidValue;
            ShiptoLine1 = shiptoLine1;
            BilltoAddressid = billtoAddressid;
            Modifiedon = modifiedon;
            Effectiveto = effectiveto;
            ShiptoCity = shiptoCity;
            BilltoName = billtoName;
            Expireson = expireson;
            Totalamountlessfreight = totalamountlessfreight;
            Willcall = willcall;
            Closedon = closedon;
            Createdon = createdon;
            FreightamountBase = freightamountBase;
            Totaltax = totaltax;
            ShiptoTelephone = shiptoTelephone;
            this._slainvokedidValue = _slainvokedidValue;
            Statecode = statecode;
            Traversedpath = traversedpath;
            BilltoPostalcode = billtoPostalcode;
            BilltoCity = billtoCity;
            this._owneridValue = _owneridValue;
            BilltoLine2 = billtoLine2;
            Quoteid = quoteid;
            TotalamountlessfreightBase = totalamountlessfreightBase;
            Discountpercentage = discountpercentage;
            ShiptoFreighttermscode = shiptoFreighttermscode;
            Discountamount = discountamount;
            ShiptoLine3 = shiptoLine3;
            BilltoLine3 = billtoLine3;
            Effectivefrom = effectivefrom;
            Importsequencenumber = importsequencenumber;
            ShiptoContactname = shiptoContactname;
            this._createdbyValue = _createdbyValue;
            this._slaidValue = _slaidValue;
            Revisionnumber = revisionnumber;
            this._owningteamValue = _owningteamValue;
            DiscountamountBase = discountamountBase;
            ShiptoStateorprovince = shiptoStateorprovince;
            ShiptoPostalcode = shiptoPostalcode;
            TotalamountBase = totalamountBase;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Versionnumber = versionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            TotallineitemdiscountamountBase = totallineitemdiscountamountBase;
            Totallineitemdiscountamount = totallineitemdiscountamount;
            Overriddencreatedon = overriddencreatedon;
            ShiptoLine2 = shiptoLine2;
            Paymenttermscode = paymenttermscode;
            ShiptoFax = shiptoFax;
            Exchangerate = exchangerate;
            Name = name;
            TotaldiscountamountBase = totaldiscountamountBase;
            this._campaignidValue = _campaignidValue;
            Shippingmethodcode = shippingmethodcode;
            BilltoCountry = billtoCountry;
            Freighttermscode = freighttermscode;
            ContactquotesAssociation = contactquotesAssociation;
            Owninguser = owninguser;
            QuoteOpportunitysalesprocess = quoteOpportunitysalesprocess;
            QuoteSharepointDocumentLocation = quoteSharepointDocumentLocation;
            QuoteQuoteClose = quoteQuoteClose;
            CustomeridContact = customeridContact;
            QuoteConnections1 = quoteConnections1;
            Owningbusinessunit = owningbusinessunit;
            QuoteConnections2 = quoteConnections2;
            Owningteam = owningteam;
            Modifiedonbehalfby = modifiedonbehalfby;
            QuoteLetters = quoteLetters;
            QuoteBulkDeleteFailures = quoteBulkDeleteFailures;
            QuoteTasks = quoteTasks;
            SlainvokedidQuoteSla = slainvokedidQuoteSla;
            QuoteSocialActivities = quoteSocialActivities;
            SlaQuoteSla = slaQuoteSla;
            Transactioncurrencyid = transactioncurrencyid;
            QuoteActivityPointers = quoteActivityPointers;
            QuoteOrders = quoteOrders;
            StageidProcessstage = stageidProcessstage;
            QuoteAppointments = quoteAppointments;
            Pricelevelid = pricelevelid;
            Createdby = createdby;
            Ownerid = ownerid;
            QuoteDuplicateMatchingRecord = quoteDuplicateMatchingRecord;
            CustomeridAccount = customeridAccount;
            QuoteActivityParties = quoteActivityParties;
            Modifiedby = modifiedby;
            QuoteFaxes = quoteFaxes;
            QuoteSyncErrors = quoteSyncErrors;
            QuoteServiceAppointments = quoteServiceAppointments;
            QuoteAsyncOperations = quoteAsyncOperations;
            QuoteRecurringAppointmentMasters = quoteRecurringAppointmentMasters;
            SlakpiinstanceQuote = slakpiinstanceQuote;
            QuoteAnnotation = quoteAnnotation;
            QuoteDetails = quoteDetails;
            QuotePhonecalls = quotePhonecalls;
            Createdonbehalfby = createdonbehalfby;
            Opportunityid = opportunityid;
            QuoteEmails = quoteEmails;
            Campaignid = campaignid;
            QuoteDuplicateBaseRecord = quoteDuplicateBaseRecord;
            QuoteAbsScheduledprocessexecutions = quoteAbsScheduledprocessexecutions;
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
        [JsonProperty(PropertyName = "billto_stateorprovince")]
        public string BilltoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "onholdtime")]
        public int? Onholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotenumber")]
        public string Quotenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastonholdtime")]
        public System.DateTimeOffset? Lastonholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_composite")]
        public string BilltoComposite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line1")]
        public string BilltoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_fax")]
        public string BilltoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaltax_base")]
        public object TotaltaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_addressid")]
        public string ShiptoAddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_composite")]
        public string ShiptoComposite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_country")]
        public string ShiptoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemamount")]
        public object Totallineitemamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestdeliveryby")]
        public System.DateTimeOffset? Requestdeliveryby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_customerid_value")]
        public string _customeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_contactname")]
        public string BilltoContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_pricelevelid_value")]
        public string _pricelevelidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_name")]
        public string ShiptoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamount")]
        public object Totalamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freightamount")]
        public object Freightamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_telephone")]
        public string BilltoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemamount_base")]
        public object TotallineitemamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscountamount")]
        public object Totaldiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line1")]
        public string ShiptoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_addressid")]
        public string BilltoAddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveto")]
        public System.DateTimeOffset? Effectiveto { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_city")]
        public string ShiptoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_name")]
        public string BilltoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expireson")]
        public System.DateTimeOffset? Expireson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamountlessfreight")]
        public object Totalamountlessfreight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "willcall")]
        public bool? Willcall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "closedon")]
        public System.DateTimeOffset? Closedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freightamount_base")]
        public object FreightamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaltax")]
        public object Totaltax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_telephone")]
        public string ShiptoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slainvokedid_value")]
        public string _slainvokedidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_postalcode")]
        public string BilltoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_city")]
        public string BilltoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line2")]
        public string BilltoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteid")]
        public string Quoteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamountlessfreight_base")]
        public object TotalamountlessfreightBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountpercentage")]
        public object Discountpercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_freighttermscode")]
        public int? ShiptoFreighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountamount")]
        public object Discountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line3")]
        public string ShiptoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line3")]
        public string BilltoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectivefrom")]
        public System.DateTimeOffset? Effectivefrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_contactname")]
        public string ShiptoContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "revisionnumber")]
        public int? Revisionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountamount_base")]
        public object DiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_stateorprovince")]
        public string ShiptoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_postalcode")]
        public string ShiptoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamount_base")]
        public object TotalamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemdiscountamount_base")]
        public object TotallineitemdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemdiscountamount")]
        public object Totallineitemdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line2")]
        public string ShiptoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymenttermscode")]
        public int? Paymenttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_fax")]
        public string ShiptoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscountamount_base")]
        public object TotaldiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_campaignid_value")]
        public string _campaignidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_country")]
        public string BilltoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freighttermscode")]
        public int? Freighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactquotes_association")]
        public IList<MicrosoftDynamicsCRMcontact> ContactquotesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quote_opportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMopportunitysalesprocess> QuoteOpportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_SharepointDocumentLocation")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> QuoteSharepointDocumentLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_QuoteClose")]
        public IList<MicrosoftDynamicsCRMquoteclose> QuoteQuoteClose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quote_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> QuoteConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quote_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> QuoteConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_Letters")]
        public IList<MicrosoftDynamicsCRMletter> QuoteLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> QuoteBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> QuoteTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_quote_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidQuoteSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> QuoteSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_quote_sla")]
        public MicrosoftDynamicsCRMsla SlaQuoteSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> QuoteActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quote_orders")]
        public IList<MicrosoftDynamicsCRMsalesorder> QuoteOrders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> QuoteAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public MicrosoftDynamicsCRMpricelevel Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> QuoteDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quote_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> QuoteActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> QuoteFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> QuoteSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> QuoteServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> QuoteAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> QuoteRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_quote")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> QuoteAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quote_details")]
        public IList<MicrosoftDynamicsCRMquotedetail> QuoteDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_Phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> QuotePhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public MicrosoftDynamicsCRMopportunity Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_Emails")]
        public IList<MicrosoftDynamicsCRMemail> QuoteEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignid")]
        public MicrosoftDynamicsCRMcampaign Campaignid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Quote_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> QuoteDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quote_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> QuoteAbsScheduledprocessexecutions { get; set; }

    }
}
