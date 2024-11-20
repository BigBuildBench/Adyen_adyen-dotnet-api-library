/*
* Transfers API
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

namespace Adyen.Model.Transfers
{
    /// <summary>
    /// Counterparty
    /// </summary>
    [DataContract(Name = "Counterparty")]
    public partial class Counterparty : IEquatable<Counterparty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Counterparty" /> class.
        /// </summary>
        /// <param name="accountHolderId">The identifier of the receiving account holder. The payout will default to the primary balance account of this account holder if no &#x60;balanceAccountId&#x60; is provided..</param>
        /// <param name="balanceAccountId">The identifier of the balance account that belongs to the receiving account holder..</param>
        /// <param name="transferInstrumentId">The identifier of the transfer instrument that belongs to the legal entity of the account holder..</param>
        public Counterparty(string accountHolderId = default(string), string balanceAccountId = default(string), string transferInstrumentId = default(string))
        {
            this.AccountHolderId = accountHolderId;
            this.BalanceAccountId = balanceAccountId;
            this.TransferInstrumentId = transferInstrumentId;
        }

        /// <summary>
        /// The identifier of the receiving account holder. The payout will default to the primary balance account of this account holder if no &#x60;balanceAccountId&#x60; is provided.
        /// </summary>
        /// <value>The identifier of the receiving account holder. The payout will default to the primary balance account of this account holder if no &#x60;balanceAccountId&#x60; is provided.</value>
        [DataMember(Name = "accountHolderId", EmitDefaultValue = false)]
        public string AccountHolderId { get; set; }

        /// <summary>
        /// The identifier of the balance account that belongs to the receiving account holder.
        /// </summary>
        /// <value>The identifier of the balance account that belongs to the receiving account holder.</value>
        [DataMember(Name = "balanceAccountId", EmitDefaultValue = false)]
        public string BalanceAccountId { get; set; }

        /// <summary>
        /// The identifier of the transfer instrument that belongs to the legal entity of the account holder.
        /// </summary>
        /// <value>The identifier of the transfer instrument that belongs to the legal entity of the account holder.</value>
        [DataMember(Name = "transferInstrumentId", EmitDefaultValue = false)]
        public string TransferInstrumentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Counterparty {\n");
            sb.Append("  AccountHolderId: ").Append(AccountHolderId).Append("\n");
            sb.Append("  BalanceAccountId: ").Append(BalanceAccountId).Append("\n");
            sb.Append("  TransferInstrumentId: ").Append(TransferInstrumentId).Append("\n");
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
            return this.Equals(input as Counterparty);
        }

        /// <summary>
        /// Returns true if Counterparty instances are equal
        /// </summary>
        /// <param name="input">Instance of Counterparty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Counterparty input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountHolderId == input.AccountHolderId ||
                    (this.AccountHolderId != null &&
                    this.AccountHolderId.Equals(input.AccountHolderId))
                ) && 
                (
                    this.BalanceAccountId == input.BalanceAccountId ||
                    (this.BalanceAccountId != null &&
                    this.BalanceAccountId.Equals(input.BalanceAccountId))
                ) && 
                (
                    this.TransferInstrumentId == input.TransferInstrumentId ||
                    (this.TransferInstrumentId != null &&
                    this.TransferInstrumentId.Equals(input.TransferInstrumentId))
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
                if (this.AccountHolderId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolderId.GetHashCode();
                }
                if (this.BalanceAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.BalanceAccountId.GetHashCode();
                }
                if (this.TransferInstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.TransferInstrumentId.GetHashCode();
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
