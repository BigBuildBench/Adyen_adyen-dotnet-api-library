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
    /// TransferRouteResponse
    /// </summary>
    [DataContract(Name = "TransferRouteResponse")]
    public partial class TransferRouteResponse : IEquatable<TransferRouteResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRouteResponse" /> class.
        /// </summary>
        /// <param name="transferRoutes">List of available priorities for a transfer, along with requirements. Use this information to initiate a transfer..</param>
        public TransferRouteResponse(List<TransferRoute> transferRoutes = default(List<TransferRoute>))
        {
            this.TransferRoutes = transferRoutes;
        }

        /// <summary>
        /// List of available priorities for a transfer, along with requirements. Use this information to initiate a transfer.
        /// </summary>
        /// <value>List of available priorities for a transfer, along with requirements. Use this information to initiate a transfer.</value>
        [DataMember(Name = "transferRoutes", EmitDefaultValue = false)]
        public List<TransferRoute> TransferRoutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferRouteResponse {\n");
            sb.Append("  TransferRoutes: ").Append(TransferRoutes).Append("\n");
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
            return this.Equals(input as TransferRouteResponse);
        }

        /// <summary>
        /// Returns true if TransferRouteResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferRouteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferRouteResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransferRoutes == input.TransferRoutes ||
                    this.TransferRoutes != null &&
                    input.TransferRoutes != null &&
                    this.TransferRoutes.SequenceEqual(input.TransferRoutes)
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
                if (this.TransferRoutes != null)
                {
                    hashCode = (hashCode * 59) + this.TransferRoutes.GetHashCode();
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
