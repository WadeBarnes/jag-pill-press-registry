// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// msdyn_bcgov_inspectionownershipcategory_1
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynBcgovInspectionownershipcategory1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynBcgovInspectionownershipcategory1 class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynBcgovInspectionownershipcategory1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynBcgovInspectionownershipcategory1 class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynBcgovInspectionownershipcategory1(string bcgovInspectionownershipcategoryid = default(string), string knowledgearticleid = default(string), string msdynBcgovInspectionownershipcategory1id = default(string), long? versionnumber = default(long?))
        {
            BcgovInspectionownershipcategoryid = bcgovInspectionownershipcategoryid;
            Knowledgearticleid = knowledgearticleid;
            MsdynBcgovInspectionownershipcategory1id = msdynBcgovInspectionownershipcategory1id;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionownershipcategoryid")]
        public string BcgovInspectionownershipcategoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleid")]
        public string Knowledgearticleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_bcgov_inspectionownershipcategory_1id")]
        public string MsdynBcgovInspectionownershipcategory1id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

    }
}
