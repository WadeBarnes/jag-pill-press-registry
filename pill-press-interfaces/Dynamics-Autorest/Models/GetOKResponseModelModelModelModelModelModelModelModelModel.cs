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
    /// Collection of bcgov_incident_businesscontactset
    /// </summary>
    public partial class GetOKResponseModelModelModelModelModelModelModelModelModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetOKResponseModelModelModelModelModelModelModelModelModel class.
        /// </summary>
        public GetOKResponseModelModelModelModelModelModelModelModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetOKResponseModelModelModelModelModelModelModelModelModel class.
        /// </summary>
        public GetOKResponseModelModelModelModelModelModelModelModelModel(IList<MicrosoftDynamicsCRMbcgovIncidentBusinesscontact> value = default(IList<MicrosoftDynamicsCRMbcgovIncidentBusinesscontact>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMbcgovIncidentBusinesscontact> Value { get; set; }

    }
}
