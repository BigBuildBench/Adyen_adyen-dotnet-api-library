/*
* Management API
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// WeChatPayPosInfo
    /// </summary>
    [DataContract(Name = "WeChatPayPosInfo")]
    public partial class WeChatPayPosInfo : IEquatable<WeChatPayPosInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeChatPayPosInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WeChatPayPosInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WeChatPayPosInfo" /> class.
        /// </summary>
        /// <param name="contactPersonName">The name of the contact person from merchant support. (required).</param>
        /// <param name="email">The email address of merchant support. (required).</param>
        public WeChatPayPosInfo(string contactPersonName = default(string), string email = default(string))
        {
            this.ContactPersonName = contactPersonName;
            this.Email = email;
        }

        /// <summary>
        /// The name of the contact person from merchant support.
        /// </summary>
        /// <value>The name of the contact person from merchant support.</value>
        [DataMember(Name = "contactPersonName", IsRequired = false, EmitDefaultValue = false)]
        public string ContactPersonName { get; set; }

        /// <summary>
        /// The email address of merchant support.
        /// </summary>
        /// <value>The email address of merchant support.</value>
        [DataMember(Name = "email", IsRequired = false, EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WeChatPayPosInfo {\n");
            sb.Append("  ContactPersonName: ").Append(ContactPersonName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as WeChatPayPosInfo);
        }

        /// <summary>
        /// Returns true if WeChatPayPosInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of WeChatPayPosInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeChatPayPosInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContactPersonName == input.ContactPersonName ||
                    (this.ContactPersonName != null &&
                    this.ContactPersonName.Equals(input.ContactPersonName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.ContactPersonName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactPersonName.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
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
