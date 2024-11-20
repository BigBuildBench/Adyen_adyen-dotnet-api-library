/*
* Account API
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

namespace Adyen.Model.PlatformsAccount
{
    /// <summary>
    /// ViasPhoneNumber
    /// </summary>
    [DataContract(Name = "ViasPhoneNumber")]
    public partial class ViasPhoneNumber : IEquatable<ViasPhoneNumber>, IValidatableObject
    {
        /// <summary>
        /// The type of the phone number. &gt;The following values are permitted: &#x60;Landline&#x60;, &#x60;Mobile&#x60;, &#x60;SIP&#x60;, &#x60;Fax&#x60;.
        /// </summary>
        /// <value>The type of the phone number. &gt;The following values are permitted: &#x60;Landline&#x60;, &#x60;Mobile&#x60;, &#x60;SIP&#x60;, &#x60;Fax&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhoneTypeEnum
        {
            /// <summary>
            /// Enum Fax for value: Fax
            /// </summary>
            [EnumMember(Value = "Fax")]
            Fax = 1,

            /// <summary>
            /// Enum Landline for value: Landline
            /// </summary>
            [EnumMember(Value = "Landline")]
            Landline = 2,

            /// <summary>
            /// Enum Mobile for value: Mobile
            /// </summary>
            [EnumMember(Value = "Mobile")]
            Mobile = 3,

            /// <summary>
            /// Enum SIP for value: SIP
            /// </summary>
            [EnumMember(Value = "SIP")]
            SIP = 4

        }


        /// <summary>
        /// The type of the phone number. &gt;The following values are permitted: &#x60;Landline&#x60;, &#x60;Mobile&#x60;, &#x60;SIP&#x60;, &#x60;Fax&#x60;.
        /// </summary>
        /// <value>The type of the phone number. &gt;The following values are permitted: &#x60;Landline&#x60;, &#x60;Mobile&#x60;, &#x60;SIP&#x60;, &#x60;Fax&#x60;.</value>
        [DataMember(Name = "phoneType", EmitDefaultValue = false)]
        public PhoneTypeEnum? PhoneType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViasPhoneNumber" /> class.
        /// </summary>
        /// <param name="phoneCountryCode">The two-character country code of the phone number. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#39;NL&#39;)..</param>
        /// <param name="phoneNumber">The phone number. &gt;The inclusion of the phone number country code is not necessary..</param>
        /// <param name="phoneType">The type of the phone number. &gt;The following values are permitted: &#x60;Landline&#x60;, &#x60;Mobile&#x60;, &#x60;SIP&#x60;, &#x60;Fax&#x60;..</param>
        public ViasPhoneNumber(string phoneCountryCode = default(string), string phoneNumber = default(string), PhoneTypeEnum? phoneType = default(PhoneTypeEnum?))
        {
            this.PhoneCountryCode = phoneCountryCode;
            this.PhoneNumber = phoneNumber;
            this.PhoneType = phoneType;
        }

        /// <summary>
        /// The two-character country code of the phone number. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#39;NL&#39;).
        /// </summary>
        /// <value>The two-character country code of the phone number. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#39;NL&#39;).</value>
        [DataMember(Name = "phoneCountryCode", EmitDefaultValue = false)]
        public string PhoneCountryCode { get; set; }

        /// <summary>
        /// The phone number. &gt;The inclusion of the phone number country code is not necessary.
        /// </summary>
        /// <value>The phone number. &gt;The inclusion of the phone number country code is not necessary.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ViasPhoneNumber {\n");
            sb.Append("  PhoneCountryCode: ").Append(PhoneCountryCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PhoneType: ").Append(PhoneType).Append("\n");
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
            return this.Equals(input as ViasPhoneNumber);
        }

        /// <summary>
        /// Returns true if ViasPhoneNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of ViasPhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViasPhoneNumber input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PhoneCountryCode == input.PhoneCountryCode ||
                    (this.PhoneCountryCode != null &&
                    this.PhoneCountryCode.Equals(input.PhoneCountryCode))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PhoneType == input.PhoneType ||
                    this.PhoneType.Equals(input.PhoneType)
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
                if (this.PhoneCountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneCountryCode.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PhoneType.GetHashCode();
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
