/*
* Notification Configuration API
*
*
* The version of the OpenAPI document: 6
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.PlatformsNotificationConfiguration
{
    /// <summary>
    /// GetNotificationConfigurationRequest
    /// </summary>
    [DataContract(Name = "GetNotificationConfigurationRequest")]
    public partial class GetNotificationConfigurationRequest : IEquatable<GetNotificationConfigurationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotificationConfigurationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetNotificationConfigurationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotificationConfigurationRequest" /> class.
        /// </summary>
        /// <param name="notificationId">The ID of the notification subscription configuration whose details are to be retrieved. (required).</param>
        public GetNotificationConfigurationRequest(long? notificationId = default(long?))
        {
            this.NotificationId = notificationId;
        }

        /// <summary>
        /// The ID of the notification subscription configuration whose details are to be retrieved.
        /// </summary>
        /// <value>The ID of the notification subscription configuration whose details are to be retrieved.</value>
        [DataMember(Name = "notificationId", IsRequired = false, EmitDefaultValue = false)]
        public long? NotificationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetNotificationConfigurationRequest {\n");
            sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetNotificationConfigurationRequest);
        }

        /// <summary>
        /// Returns true if GetNotificationConfigurationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetNotificationConfigurationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetNotificationConfigurationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NotificationId == input.NotificationId ||
                    this.NotificationId.Equals(input.NotificationId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.NotificationId.GetHashCode();
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
