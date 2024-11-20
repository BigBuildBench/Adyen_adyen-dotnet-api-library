/*
* Classic Platforms - Notifications
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

namespace Adyen.Model.PlatformsWebhooks
{
    /// <summary>
    /// AccountHolderStatusChangeNotificationContent
    /// </summary>
    [DataContract(Name = "AccountHolderStatusChangeNotificationContent")]
    public partial class AccountHolderStatusChangeNotificationContent : IEquatable<AccountHolderStatusChangeNotificationContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderStatusChangeNotificationContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountHolderStatusChangeNotificationContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderStatusChangeNotificationContent" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the account holder. (required).</param>
        /// <param name="invalidFields">in case the account holder has not been updated, contains account holder fields, that did not pass the validation..</param>
        /// <param name="newStatus">newStatus.</param>
        /// <param name="oldStatus">oldStatus.</param>
        /// <param name="reason">The reason for the status change..</param>
        public AccountHolderStatusChangeNotificationContent(string accountHolderCode = default(string), List<ErrorFieldType> invalidFields = default(List<ErrorFieldType>), AccountHolderStatus newStatus = default(AccountHolderStatus), AccountHolderStatus oldStatus = default(AccountHolderStatus), string reason = default(string))
        {
            this.AccountHolderCode = accountHolderCode;
            this.InvalidFields = invalidFields;
            this.NewStatus = newStatus;
            this.OldStatus = oldStatus;
            this.Reason = reason;
        }

        /// <summary>
        /// The code of the account holder.
        /// </summary>
        /// <value>The code of the account holder.</value>
        [DataMember(Name = "accountHolderCode", IsRequired = false, EmitDefaultValue = false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// in case the account holder has not been updated, contains account holder fields, that did not pass the validation.
        /// </summary>
        /// <value>in case the account holder has not been updated, contains account holder fields, that did not pass the validation.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// Gets or Sets NewStatus
        /// </summary>
        [DataMember(Name = "newStatus", EmitDefaultValue = false)]
        public AccountHolderStatus NewStatus { get; set; }

        /// <summary>
        /// Gets or Sets OldStatus
        /// </summary>
        [DataMember(Name = "oldStatus", EmitDefaultValue = false)]
        public AccountHolderStatus OldStatus { get; set; }

        /// <summary>
        /// The reason for the status change.
        /// </summary>
        /// <value>The reason for the status change.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountHolderStatusChangeNotificationContent {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  NewStatus: ").Append(NewStatus).Append("\n");
            sb.Append("  OldStatus: ").Append(OldStatus).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as AccountHolderStatusChangeNotificationContent);
        }

        /// <summary>
        /// Returns true if AccountHolderStatusChangeNotificationContent instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountHolderStatusChangeNotificationContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderStatusChangeNotificationContent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    this.InvalidFields == input.InvalidFields ||
                    this.InvalidFields != null &&
                    input.InvalidFields != null &&
                    this.InvalidFields.SequenceEqual(input.InvalidFields)
                ) && 
                (
                    this.NewStatus == input.NewStatus ||
                    (this.NewStatus != null &&
                    this.NewStatus.Equals(input.NewStatus))
                ) && 
                (
                    this.OldStatus == input.OldStatus ||
                    (this.OldStatus != null &&
                    this.OldStatus.Equals(input.OldStatus))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.AccountHolderCode != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolderCode.GetHashCode();
                }
                if (this.InvalidFields != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidFields.GetHashCode();
                }
                if (this.NewStatus != null)
                {
                    hashCode = (hashCode * 59) + this.NewStatus.GetHashCode();
                }
                if (this.OldStatus != null)
                {
                    hashCode = (hashCode * 59) + this.OldStatus.GetHashCode();
                }
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
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
