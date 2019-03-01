// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// This OData service is located at
    /// https://wsgw.dev.jag.gov.bc.ca/pillpress/dev/api/data/v8.2/
    /// </summary>
    public partial interface IDynamicsClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IAccounts.
        /// </summary>
        IAccounts Accounts { get; }

        /// <summary>
        /// Gets the IApplicationtypes.
        /// </summary>
        IApplicationtypes Applicationtypes { get; }

        /// <summary>
        /// Gets the IBusinesscontacts.
        /// </summary>
        IBusinesscontacts Businesscontacts { get; }

        /// <summary>
        /// Gets the ICertificateapprovedproducts.
        /// </summary>
        ICertificateapprovedproducts Certificateapprovedproducts { get; }

        /// <summary>
        /// Gets the ICertificates.
        /// </summary>
        ICertificates Certificates { get; }

        /// <summary>
        /// Gets the ICertificatetermsandconditionses.
        /// </summary>
        ICertificatetermsandconditionses Certificatetermsandconditionses { get; }

        /// <summary>
        /// Gets the ICustomaddresses.
        /// </summary>
        ICustomaddresses Customaddresses { get; }

        /// <summary>
        /// Gets the ICustomproducts.
        /// </summary>
        ICustomproducts Customproducts { get; }

        /// <summary>
        /// Gets the IEquipmentlocations.
        /// </summary>
        IEquipmentlocations Equipmentlocations { get; }

        /// <summary>
        /// Gets the IEquipments.
        /// </summary>
        IEquipments Equipments { get; }

        /// <summary>
        /// Gets the IIncidentbusinesscontactset.
        /// </summary>
        IIncidentbusinesscontactset Incidentbusinesscontactset { get; }

        /// <summary>
        /// Gets the IInspectionownershipcategories.
        /// </summary>
        IInspectionownershipcategories Inspectionownershipcategories { get; }

        /// <summary>
        /// Gets the IInspections.
        /// </summary>
        IInspections Inspections { get; }

        /// <summary>
        /// Gets the ILocationequipmentset.
        /// </summary>
        ILocationequipmentset Locationequipmentset { get; }

        /// <summary>
        /// Gets the ILocations.
        /// </summary>
        ILocations Locations { get; }

        /// <summary>
        /// Gets the IPostalcodes.
        /// </summary>
        IPostalcodes Postalcodes { get; }

        /// <summary>
        /// Gets the IRegions.
        /// </summary>
        IRegions Regions { get; }

        /// <summary>
        /// Gets the IRiskassessments.
        /// </summary>
        IRiskassessments Riskassessments { get; }

        /// <summary>
        /// Gets the ITermsconditionspresets.
        /// </summary>
        ITermsconditionspresets Termsconditionspresets { get; }

        /// <summary>
        /// Gets the IContacts.
        /// </summary>
        IContacts Contacts { get; }

        /// <summary>
        /// Gets the IIncidents.
        /// </summary>
        IIncidents Incidents { get; }

        /// <summary>
        /// Gets the IInvoices.
        /// </summary>
        IInvoices Invoices { get; }

        /// <summary>
        /// Gets the IMsdyncustomaddressknowledgearticlset.
        /// </summary>
        IMsdyncustomaddressknowledgearticlset Msdyncustomaddressknowledgearticlset { get; }

        /// <summary>
        /// Gets the IMsdyncustomaddressknowledgebasereset.
        /// </summary>
        IMsdyncustomaddressknowledgebasereset Msdyncustomaddressknowledgebasereset { get; }

        /// <summary>
        /// Gets the ISharepointdocumentlocations.
        /// </summary>
        ISharepointdocumentlocations Sharepointdocumentlocations { get; }

        /// <summary>
        /// Gets the ISharepointsites.
        /// </summary>
        ISharepointsites Sharepointsites { get; }

        /// <summary>
        /// Gets the IEntitydefinitions.
        /// </summary>
        IEntitydefinitions Entitydefinitions { get; }

        /// <summary>
        /// Gets the IGlobaloptionsetdefinitions.
        /// </summary>
        IGlobaloptionsetdefinitions Globaloptionsetdefinitions { get; }

    }
}
