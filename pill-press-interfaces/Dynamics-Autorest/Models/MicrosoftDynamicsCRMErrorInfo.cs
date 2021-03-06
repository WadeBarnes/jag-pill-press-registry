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
    /// ErrorInfo
    /// </summary>
    public partial class MicrosoftDynamicsCRMErrorInfo
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMErrorInfo
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMErrorInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMErrorInfo
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMErrorInfo(IList<MicrosoftDynamicsCRMResourceInfo> resourceList = default(IList<MicrosoftDynamicsCRMResourceInfo>), string errorCode = default(string))
        {
            ResourceList = resourceList;
            ErrorCode = errorCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceList")]
        public IList<MicrosoftDynamicsCRMResourceInfo> ResourceList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ErrorCode")]
        public string ErrorCode { get; set; }

    }
}
