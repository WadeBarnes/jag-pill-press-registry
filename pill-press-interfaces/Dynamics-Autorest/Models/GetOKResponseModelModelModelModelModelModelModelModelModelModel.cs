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
    public partial class GetOKResponseModelModelModelModelModelModelModelModelModelModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetOKResponseModelModelModelModelModelModelModelModelModelModel
        /// class.
        /// </summary>
        public GetOKResponseModelModelModelModelModelModelModelModelModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetOKResponseModelModelModelModelModelModelModelModelModelModel
        /// class.
        /// </summary>
        public GetOKResponseModelModelModelModelModelModelModelModelModelModel(IList<MicrosoftDynamicsCRMbcgovIncidentBusinesscontact> value = default(IList<MicrosoftDynamicsCRMbcgovIncidentBusinesscontact>))
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
