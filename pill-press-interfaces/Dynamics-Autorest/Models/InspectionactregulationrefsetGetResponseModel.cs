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
    /// Collection of bcgov_inspection_actregulationrefset
    /// </summary>
    public partial class InspectionactregulationrefsetGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InspectionactregulationrefsetGetResponseModel class.
        /// </summary>
        public InspectionactregulationrefsetGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InspectionactregulationrefsetGetResponseModel class.
        /// </summary>
        public InspectionactregulationrefsetGetResponseModel(IList<MicrosoftDynamicsCRMbcgovInspectionActregulationref> value = default(IList<MicrosoftDynamicsCRMbcgovInspectionActregulationref>))
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
        public IList<MicrosoftDynamicsCRMbcgovInspectionActregulationref> Value { get; set; }

    }
}
