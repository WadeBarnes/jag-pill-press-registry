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
    /// bcgov_complaint_cecontact
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovComplaintCecontact
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovComplaintCecontact class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovComplaintCecontact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovComplaintCecontact class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovComplaintCecontact(string bcgovComplaintCecontactid = default(string), string bcgovCecontactid = default(string), string bcgovComplaintid = default(string), long? versionnumber = default(long?))
        {
            BcgovComplaintCecontactid = bcgovComplaintCecontactid;
            BcgovCecontactid = bcgovCecontactid;
            BcgovComplaintid = bcgovComplaintid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_cecontactid")]
        public string BcgovComplaintCecontactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_cecontactid")]
        public string BcgovCecontactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaintid")]
        public string BcgovComplaintid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

    }
}
