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
    /// Collection of discounts
    /// </summary>
    public partial class DiscountsGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the DiscountsGetResponseModel class.
        /// </summary>
        public DiscountsGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiscountsGetResponseModel class.
        /// </summary>
        public DiscountsGetResponseModel(IList<MicrosoftDynamicsCRMdiscount> value = default(IList<MicrosoftDynamicsCRMdiscount>))
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
        public IList<MicrosoftDynamicsCRMdiscount> Value { get; set; }

    }
}