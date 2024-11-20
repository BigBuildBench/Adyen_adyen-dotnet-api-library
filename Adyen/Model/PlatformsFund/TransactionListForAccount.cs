/*
* Fund API
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

namespace Adyen.Model.PlatformsFund
{
    /// <summary>
    /// TransactionListForAccount
    /// </summary>
    [DataContract(Name = "TransactionListForAccount")]
    public partial class TransactionListForAccount : IEquatable<TransactionListForAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionListForAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionListForAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionListForAccount" /> class.
        /// </summary>
        /// <param name="accountCode">The account for which to retrieve the transactions. (required).</param>
        /// <param name="page">The page of transactions to retrieve. Each page lists fifty (50) transactions.  The most recent transactions are included on page 1. (required).</param>
        public TransactionListForAccount(string accountCode = default(string), int? page = default(int?))
        {
            this.AccountCode = accountCode;
            this.Page = page;
        }

        /// <summary>
        /// The account for which to retrieve the transactions.
        /// </summary>
        /// <value>The account for which to retrieve the transactions.</value>
        [DataMember(Name = "accountCode", IsRequired = false, EmitDefaultValue = false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The page of transactions to retrieve. Each page lists fifty (50) transactions.  The most recent transactions are included on page 1.
        /// </summary>
        /// <value>The page of transactions to retrieve. Each page lists fifty (50) transactions.  The most recent transactions are included on page 1.</value>
        [DataMember(Name = "page", IsRequired = false, EmitDefaultValue = false)]
        public int? Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionListForAccount {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
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
            return this.Equals(input as TransactionListForAccount);
        }

        /// <summary>
        /// Returns true if TransactionListForAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionListForAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionListForAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
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
                if (this.AccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.AccountCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
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
