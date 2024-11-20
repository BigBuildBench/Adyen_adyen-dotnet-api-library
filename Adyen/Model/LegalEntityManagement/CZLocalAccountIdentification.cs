/*
* Legal Entity Management API
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

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// CZLocalAccountIdentification
    /// </summary>
    [DataContract(Name = "CZLocalAccountIdentification")]
    public partial class CZLocalAccountIdentification : IEquatable<CZLocalAccountIdentification>, IValidatableObject
    {
        /// <summary>
        /// **czLocal**
        /// </summary>
        /// <value>**czLocal**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum CzLocal for value: czLocal
            /// </summary>
            [EnumMember(Value = "czLocal")]
            CzLocal = 1

        }


        /// <summary>
        /// **czLocal**
        /// </summary>
        /// <value>**czLocal**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CZLocalAccountIdentification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CZLocalAccountIdentification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CZLocalAccountIdentification" /> class.
        /// </summary>
        /// <param name="accountNumber">The 2- to 16-digit bank account number (Číslo účtu) in the following format:  - The optional prefix (předčíslí).  - The required second part (základní část) which must be at least two non-zero digits.  Examples:  - **19-123457** (with prefix)  - **123457** (without prefix)  - **000019-0000123457** (with prefix, normalized)  - **000000-0000123457** (without prefix, normalized) (required).</param>
        /// <param name="bankCode">The 4-digit bank code (Kód banky), without separators or whitespace. (required).</param>
        /// <param name="type">**czLocal** (required) (default to TypeEnum.CzLocal).</param>
        public CZLocalAccountIdentification(string accountNumber = default(string), string bankCode = default(string), TypeEnum type = TypeEnum.CzLocal)
        {
            this.AccountNumber = accountNumber;
            this.BankCode = bankCode;
            this.Type = type;
        }

        /// <summary>
        /// The 2- to 16-digit bank account number (Číslo účtu) in the following format:  - The optional prefix (předčíslí).  - The required second part (základní část) which must be at least two non-zero digits.  Examples:  - **19-123457** (with prefix)  - **123457** (without prefix)  - **000019-0000123457** (with prefix, normalized)  - **000000-0000123457** (without prefix, normalized)
        /// </summary>
        /// <value>The 2- to 16-digit bank account number (Číslo účtu) in the following format:  - The optional prefix (předčíslí).  - The required second part (základní část) which must be at least two non-zero digits.  Examples:  - **19-123457** (with prefix)  - **123457** (without prefix)  - **000019-0000123457** (with prefix, normalized)  - **000000-0000123457** (without prefix, normalized)</value>
        [DataMember(Name = "accountNumber", IsRequired = false, EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The 4-digit bank code (Kód banky), without separators or whitespace.
        /// </summary>
        /// <value>The 4-digit bank code (Kód banky), without separators or whitespace.</value>
        [DataMember(Name = "bankCode", IsRequired = false, EmitDefaultValue = false)]
        public string BankCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CZLocalAccountIdentification {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CZLocalAccountIdentification);
        }

        /// <summary>
        /// Returns true if CZLocalAccountIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of CZLocalAccountIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CZLocalAccountIdentification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                if (this.BankCode != null)
                {
                    hashCode = (hashCode * 59) + this.BankCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // AccountNumber (string) maxLength
            if (this.AccountNumber != null && this.AccountNumber.Length > 17)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 17.", new [] { "AccountNumber" });
            }

            // AccountNumber (string) minLength
            if (this.AccountNumber != null && this.AccountNumber.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be greater than 2.", new [] { "AccountNumber" });
            }

            // BankCode (string) maxLength
            if (this.BankCode != null && this.BankCode.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankCode, length must be less than 4.", new [] { "BankCode" });
            }

            // BankCode (string) minLength
            if (this.BankCode != null && this.BankCode.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankCode, length must be greater than 4.", new [] { "BankCode" });
            }

            yield break;
        }
    }

}
