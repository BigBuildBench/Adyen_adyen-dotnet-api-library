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
    /// Card
    /// </summary>
    [DataContract(Name = "Card")]
    public partial class Card : IEquatable<Card>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Card() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// </summary>
        /// <param name="cardHolder">cardHolder (required).</param>
        /// <param name="cardIdentification">cardIdentification (required).</param>
        public Card(PartyIdentification cardHolder = default(PartyIdentification), CardIdentification cardIdentification = default(CardIdentification))
        {
            this.CardHolder = cardHolder;
            this.CardIdentification = cardIdentification;
        }

        /// <summary>
        /// Gets or Sets CardHolder
        /// </summary>
        [DataMember(Name = "cardHolder", IsRequired = false, EmitDefaultValue = false)]
        public PartyIdentification CardHolder { get; set; }

        /// <summary>
        /// Gets or Sets CardIdentification
        /// </summary>
        [DataMember(Name = "cardIdentification", IsRequired = false, EmitDefaultValue = false)]
        public CardIdentification CardIdentification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Card {\n");
            sb.Append("  CardHolder: ").Append(CardHolder).Append("\n");
            sb.Append("  CardIdentification: ").Append(CardIdentification).Append("\n");
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
            return this.Equals(input as Card);
        }

        /// <summary>
        /// Returns true if Card instances are equal
        /// </summary>
        /// <param name="input">Instance of Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Card input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardHolder == input.CardHolder ||
                    (this.CardHolder != null &&
                    this.CardHolder.Equals(input.CardHolder))
                ) && 
                (
                    this.CardIdentification == input.CardIdentification ||
                    (this.CardIdentification != null &&
                    this.CardIdentification.Equals(input.CardIdentification))
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
                if (this.CardHolder != null)
                {
                    hashCode = (hashCode * 59) + this.CardHolder.GetHashCode();
                }
                if (this.CardIdentification != null)
                {
                    hashCode = (hashCode * 59) + this.CardIdentification.GetHashCode();
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
