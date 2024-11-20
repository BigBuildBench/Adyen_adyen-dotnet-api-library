/*
* Adyen Payout API
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Payout
{
    /// <summary>
    /// FraudCheckResult
    /// </summary>
    [DataContract(Name = "FraudCheckResult")]
    public partial class FraudCheckResult : IEquatable<FraudCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudCheckResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FraudCheckResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudCheckResult" /> class.
        /// </summary>
        /// <param name="accountScore">The fraud score generated by the risk check. (required).</param>
        /// <param name="checkId">The ID of the risk check. (required).</param>
        /// <param name="name">The name of the risk check. (required).</param>
        public FraudCheckResult(int? accountScore = default(int?), int? checkId = default(int?), string name = default(string))
        {
            this.AccountScore = accountScore;
            this.CheckId = checkId;
            this.Name = name;
        }

        /// <summary>
        /// The fraud score generated by the risk check.
        /// </summary>
        /// <value>The fraud score generated by the risk check.</value>
        [DataMember(Name = "accountScore", IsRequired = false, EmitDefaultValue = false)]
        public int? AccountScore { get; set; }

        /// <summary>
        /// The ID of the risk check.
        /// </summary>
        /// <value>The ID of the risk check.</value>
        [DataMember(Name = "checkId", IsRequired = false, EmitDefaultValue = false)]
        public int? CheckId { get; set; }

        /// <summary>
        /// The name of the risk check.
        /// </summary>
        /// <value>The name of the risk check.</value>
        [DataMember(Name = "name", IsRequired = false, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FraudCheckResult {\n");
            sb.Append("  AccountScore: ").Append(AccountScore).Append("\n");
            sb.Append("  CheckId: ").Append(CheckId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as FraudCheckResult);
        }

        /// <summary>
        /// Returns true if FraudCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudCheckResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountScore == input.AccountScore ||
                    this.AccountScore.Equals(input.AccountScore)
                ) && 
                (
                    this.CheckId == input.CheckId ||
                    this.CheckId.Equals(input.CheckId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = (hashCode * 59) + this.AccountScore.GetHashCode();
                hashCode = (hashCode * 59) + this.CheckId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
