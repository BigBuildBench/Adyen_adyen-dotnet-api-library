/*
* Transfer webhooks
*
*
* The version of the OpenAPI document: 4
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

namespace Adyen.Model.TransferWebhooks
{
    /// <summary>
    /// BalanceMutation
    /// </summary>
    [DataContract(Name = "BalanceMutation")]
    public partial class BalanceMutation : IEquatable<BalanceMutation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceMutation" /> class.
        /// </summary>
        /// <param name="balance">The amount in the payment&#39;s currency that is debited or credited on the balance accounting register..</param>
        /// <param name="currency">The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes)..</param>
        /// <param name="received">The amount in the payment&#39;s currency that is debited or credited on the received accounting register..</param>
        /// <param name="reserved">The amount in the payment&#39;s currency that is debited or credited on the reserved accounting register..</param>
        public BalanceMutation(long? balance = default(long?), string currency = default(string), long? received = default(long?), long? reserved = default(long?))
        {
            this.Balance = balance;
            this.Currency = currency;
            this.Received = received;
            this.Reserved = reserved;
        }

        /// <summary>
        /// The amount in the payment&#39;s currency that is debited or credited on the balance accounting register.
        /// </summary>
        /// <value>The amount in the payment&#39;s currency that is debited or credited on the balance accounting register.</value>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        public long? Balance { get; set; }

        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        /// <value>The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// The amount in the payment&#39;s currency that is debited or credited on the received accounting register.
        /// </summary>
        /// <value>The amount in the payment&#39;s currency that is debited or credited on the received accounting register.</value>
        [DataMember(Name = "received", EmitDefaultValue = false)]
        public long? Received { get; set; }

        /// <summary>
        /// The amount in the payment&#39;s currency that is debited or credited on the reserved accounting register.
        /// </summary>
        /// <value>The amount in the payment&#39;s currency that is debited or credited on the reserved accounting register.</value>
        [DataMember(Name = "reserved", EmitDefaultValue = false)]
        public long? Reserved { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceMutation {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Received: ").Append(Received).Append("\n");
            sb.Append("  Reserved: ").Append(Reserved).Append("\n");
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
            return this.Equals(input as BalanceMutation);
        }

        /// <summary>
        /// Returns true if BalanceMutation instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceMutation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceMutation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Balance == input.Balance ||
                    this.Balance.Equals(input.Balance)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Received == input.Received ||
                    this.Received.Equals(input.Received)
                ) && 
                (
                    this.Reserved == input.Reserved ||
                    this.Reserved.Equals(input.Reserved)
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
                hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Received.GetHashCode();
                hashCode = (hashCode * 59) + this.Reserved.GetHashCode();
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
