/*
* Configuration API
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// AmountMinMaxRequirement
    /// </summary>
    [DataContract(Name = "AmountMinMaxRequirement")]
    public partial class AmountMinMaxRequirement : IEquatable<AmountMinMaxRequirement>, IValidatableObject
    {
        /// <summary>
        /// **amountMinMaxRequirement**
        /// </summary>
        /// <value>**amountMinMaxRequirement**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AmountMinMaxRequirement for value: amountMinMaxRequirement
            /// </summary>
            [EnumMember(Value = "amountMinMaxRequirement")]
            AmountMinMaxRequirement = 1

        }


        /// <summary>
        /// **amountMinMaxRequirement**
        /// </summary>
        /// <value>**amountMinMaxRequirement**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AmountMinMaxRequirement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AmountMinMaxRequirement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AmountMinMaxRequirement" /> class.
        /// </summary>
        /// <param name="description">Specifies the eligible amounts for a particular route..</param>
        /// <param name="max">Maximum amount..</param>
        /// <param name="min">Minimum amount..</param>
        /// <param name="type">**amountMinMaxRequirement** (required) (default to TypeEnum.AmountMinMaxRequirement).</param>
        public AmountMinMaxRequirement(string description = default(string), long? max = default(long?), long? min = default(long?), TypeEnum type = TypeEnum.AmountMinMaxRequirement)
        {
            this.Type = type;
            this.Description = description;
            this.Max = max;
            this.Min = min;
        }

        /// <summary>
        /// Specifies the eligible amounts for a particular route.
        /// </summary>
        /// <value>Specifies the eligible amounts for a particular route.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Maximum amount.
        /// </summary>
        /// <value>Maximum amount.</value>
        [DataMember(Name = "max", EmitDefaultValue = false)]
        public long? Max { get; set; }

        /// <summary>
        /// Minimum amount.
        /// </summary>
        /// <value>Minimum amount.</value>
        [DataMember(Name = "min", EmitDefaultValue = false)]
        public long? Min { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AmountMinMaxRequirement {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
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
            return this.Equals(input as AmountMinMaxRequirement);
        }

        /// <summary>
        /// Returns true if AmountMinMaxRequirement instances are equal
        /// </summary>
        /// <param name="input">Instance of AmountMinMaxRequirement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmountMinMaxRequirement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Max == input.Max ||
                    this.Max.Equals(input.Max)
                ) && 
                (
                    this.Min == input.Min ||
                    this.Min.Equals(input.Min)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Max.GetHashCode();
                hashCode = (hashCode * 59) + this.Min.GetHashCode();
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
            yield break;
        }
    }

}
