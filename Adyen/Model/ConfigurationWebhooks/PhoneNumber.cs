/*
* Configuration webhooks
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.ConfigurationWebhooks
{
    /// <summary>
    /// PhoneNumber
    /// </summary>
    [DataContract(Name = "PhoneNumber")]
    public partial class PhoneNumber : IEquatable<PhoneNumber>, IValidatableObject
    {
        /// <summary>
        /// The type of the phone number. Possible values: **Landline**, **Mobile**, **SIP**, **Fax**.
        /// </summary>
        /// <value>The type of the phone number. Possible values: **Landline**, **Mobile**, **SIP**, **Fax**.</value>
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
        /// The type of the phone number. Possible values: **Landline**, **Mobile**, **SIP**, **Fax**.
        /// </summary>
        /// <value>The type of the phone number. Possible values: **Landline**, **Mobile**, **SIP**, **Fax**.</value>
        [DataMember(Name = "phoneType", EmitDefaultValue = false)]
        public PhoneTypeEnum? PhoneType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        /// <param name="phoneCountryCode">The two-character ISO-3166-1 alpha-2 country code of the phone number. For example, **US** or **NL**..</param>
        /// <param name="phoneNumber">The phone number. The inclusion of the phone number country code is not necessary..</param>
        /// <param name="phoneType">The type of the phone number. Possible values: **Landline**, **Mobile**, **SIP**, **Fax**..</param>
        public PhoneNumber(string phoneCountryCode = default(string), string phoneNumber = default(string), PhoneTypeEnum? phoneType = default(PhoneTypeEnum?))
        {
            this.PhoneCountryCode = phoneCountryCode;
            this._PhoneNumber = phoneNumber;
            this.PhoneType = phoneType;
        }

        /// <summary>
        /// The two-character ISO-3166-1 alpha-2 country code of the phone number. For example, **US** or **NL**.
        /// </summary>
        /// <value>The two-character ISO-3166-1 alpha-2 country code of the phone number. For example, **US** or **NL**.</value>
        [DataMember(Name = "phoneCountryCode", EmitDefaultValue = false)]
        public string PhoneCountryCode { get; set; }

        /// <summary>
        /// The phone number. The inclusion of the phone number country code is not necessary.
        /// </summary>
        /// <value>The phone number. The inclusion of the phone number country code is not necessary.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string _PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PhoneNumber {\n");
            sb.Append("  PhoneCountryCode: ").Append(PhoneCountryCode).Append("\n");
            sb.Append("  _PhoneNumber: ").Append(_PhoneNumber).Append("\n");
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
            return this.Equals(input as PhoneNumber);
        }

        /// <summary>
        /// Returns true if PhoneNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumber input)
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
                    this._PhoneNumber == input._PhoneNumber ||
                    (this._PhoneNumber != null &&
                    this._PhoneNumber.Equals(input._PhoneNumber))
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
                if (this._PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this._PhoneNumber.GetHashCode();
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
