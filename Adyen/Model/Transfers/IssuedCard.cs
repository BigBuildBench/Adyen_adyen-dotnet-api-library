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
    /// IssuedCard
    /// </summary>
    [DataContract(Name = "IssuedCard")]
    public partial class IssuedCard : IEquatable<IssuedCard>, IValidatableObject
    {
        /// <summary>
        /// Indicates the method used for entering the PAN to initiate a transaction.  Possible values: **manual**, **chip**, **magstripe**, **contactless**, **cof**, **ecommerce**, **token**.
        /// </summary>
        /// <value>Indicates the method used for entering the PAN to initiate a transaction.  Possible values: **manual**, **chip**, **magstripe**, **contactless**, **cof**, **ecommerce**, **token**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PanEntryModeEnum
        {
            /// <summary>
            /// Enum Chip for value: chip
            /// </summary>
            [EnumMember(Value = "chip")]
            Chip = 1,

            /// <summary>
            /// Enum Cof for value: cof
            /// </summary>
            [EnumMember(Value = "cof")]
            Cof = 2,

            /// <summary>
            /// Enum Contactless for value: contactless
            /// </summary>
            [EnumMember(Value = "contactless")]
            Contactless = 3,

            /// <summary>
            /// Enum Ecommerce for value: ecommerce
            /// </summary>
            [EnumMember(Value = "ecommerce")]
            Ecommerce = 4,

            /// <summary>
            /// Enum Magstripe for value: magstripe
            /// </summary>
            [EnumMember(Value = "magstripe")]
            Magstripe = 5,

            /// <summary>
            /// Enum Manual for value: manual
            /// </summary>
            [EnumMember(Value = "manual")]
            Manual = 6,

            /// <summary>
            /// Enum Token for value: token
            /// </summary>
            [EnumMember(Value = "token")]
            Token = 7

        }


        /// <summary>
        /// Indicates the method used for entering the PAN to initiate a transaction.  Possible values: **manual**, **chip**, **magstripe**, **contactless**, **cof**, **ecommerce**, **token**.
        /// </summary>
        /// <value>Indicates the method used for entering the PAN to initiate a transaction.  Possible values: **manual**, **chip**, **magstripe**, **contactless**, **cof**, **ecommerce**, **token**.</value>
        [DataMember(Name = "panEntryMode", EmitDefaultValue = false)]
        public PanEntryModeEnum? PanEntryMode { get; set; }
        /// <summary>
        /// Contains information about how the payment was processed. For example, **ecommerce** for online or **pos** for in-person payments.
        /// </summary>
        /// <value>Contains information about how the payment was processed. For example, **ecommerce** for online or **pos** for in-person payments.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProcessingTypeEnum
        {
            /// <summary>
            /// Enum AtmWithdraw for value: atmWithdraw
            /// </summary>
            [EnumMember(Value = "atmWithdraw")]
            AtmWithdraw = 1,

            /// <summary>
            /// Enum BalanceInquiry for value: balanceInquiry
            /// </summary>
            [EnumMember(Value = "balanceInquiry")]
            BalanceInquiry = 2,

            /// <summary>
            /// Enum Ecommerce for value: ecommerce
            /// </summary>
            [EnumMember(Value = "ecommerce")]
            Ecommerce = 3,

            /// <summary>
            /// Enum Moto for value: moto
            /// </summary>
            [EnumMember(Value = "moto")]
            Moto = 4,

            /// <summary>
            /// Enum Pos for value: pos
            /// </summary>
            [EnumMember(Value = "pos")]
            Pos = 5,

            /// <summary>
            /// Enum PurchaseWithCashback for value: purchaseWithCashback
            /// </summary>
            [EnumMember(Value = "purchaseWithCashback")]
            PurchaseWithCashback = 6,

            /// <summary>
            /// Enum Recurring for value: recurring
            /// </summary>
            [EnumMember(Value = "recurring")]
            Recurring = 7,

            /// <summary>
            /// Enum Token for value: token
            /// </summary>
            [EnumMember(Value = "token")]
            Token = 8

        }


        /// <summary>
        /// Contains information about how the payment was processed. For example, **ecommerce** for online or **pos** for in-person payments.
        /// </summary>
        /// <value>Contains information about how the payment was processed. For example, **ecommerce** for online or **pos** for in-person payments.</value>
        [DataMember(Name = "processingType", EmitDefaultValue = false)]
        public ProcessingTypeEnum? ProcessingType { get; set; }
        /// <summary>
        /// **issuedCard**
        /// </summary>
        /// <value>**issuedCard**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum IssuedCard for value: issuedCard
            /// </summary>
            [EnumMember(Value = "issuedCard")]
            IssuedCard = 1

        }


        /// <summary>
        /// **issuedCard**
        /// </summary>
        /// <value>**issuedCard**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedCard" /> class.
        /// </summary>
        /// <param name="authorisationType">The authorisation type. For example, **defaultAuthorisation**, **preAuthorisation**, **finalAuthorisation**.</param>
        /// <param name="panEntryMode">Indicates the method used for entering the PAN to initiate a transaction.  Possible values: **manual**, **chip**, **magstripe**, **contactless**, **cof**, **ecommerce**, **token**..</param>
        /// <param name="processingType">Contains information about how the payment was processed. For example, **ecommerce** for online or **pos** for in-person payments..</param>
        /// <param name="relayedAuthorisationData">relayedAuthorisationData.</param>
        /// <param name="schemeTraceId">The identifier of the original payment. This ID is provided by the scheme and can be alphanumeric or numeric, depending on the scheme. The &#x60;schemeTraceID&#x60; should refer to an original &#x60;schemeUniqueTransactionID&#x60; provided in an earlier payment (not necessarily processed by Adyen). A &#x60;schemeTraceId&#x60; is typically available for authorization adjustments or recurring payments..</param>
        /// <param name="schemeUniqueTransactionId">The unique identifier created by the scheme. This ID can be alphanumeric or numeric depending on the scheme..</param>
        /// <param name="type">**issuedCard** (default to TypeEnum.IssuedCard).</param>
        /// <param name="validationFacts">The evaluation of the validation facts. See [validation checks](https://docs.adyen.com/issuing/validation-checks) for more information..</param>
        public IssuedCard(string authorisationType = default(string), PanEntryModeEnum? panEntryMode = default(PanEntryModeEnum?), ProcessingTypeEnum? processingType = default(ProcessingTypeEnum?), RelayedAuthorisationData relayedAuthorisationData = default(RelayedAuthorisationData), string schemeTraceId = default(string), string schemeUniqueTransactionId = default(string), TypeEnum? type = TypeEnum.IssuedCard, List<TransferNotificationValidationFact> validationFacts = default(List<TransferNotificationValidationFact>))
        {
            this.AuthorisationType = authorisationType;
            this.PanEntryMode = panEntryMode;
            this.ProcessingType = processingType;
            this.RelayedAuthorisationData = relayedAuthorisationData;
            this.SchemeTraceId = schemeTraceId;
            this.SchemeUniqueTransactionId = schemeUniqueTransactionId;
            this.Type = type;
            this.ValidationFacts = validationFacts;
        }

        /// <summary>
        /// The authorisation type. For example, **defaultAuthorisation**, **preAuthorisation**, **finalAuthorisation**
        /// </summary>
        /// <value>The authorisation type. For example, **defaultAuthorisation**, **preAuthorisation**, **finalAuthorisation**</value>
        [DataMember(Name = "authorisationType", EmitDefaultValue = false)]
        public string AuthorisationType { get; set; }

        /// <summary>
        /// Gets or Sets RelayedAuthorisationData
        /// </summary>
        [DataMember(Name = "relayedAuthorisationData", EmitDefaultValue = false)]
        public RelayedAuthorisationData RelayedAuthorisationData { get; set; }

        /// <summary>
        /// The identifier of the original payment. This ID is provided by the scheme and can be alphanumeric or numeric, depending on the scheme. The &#x60;schemeTraceID&#x60; should refer to an original &#x60;schemeUniqueTransactionID&#x60; provided in an earlier payment (not necessarily processed by Adyen). A &#x60;schemeTraceId&#x60; is typically available for authorization adjustments or recurring payments.
        /// </summary>
        /// <value>The identifier of the original payment. This ID is provided by the scheme and can be alphanumeric or numeric, depending on the scheme. The &#x60;schemeTraceID&#x60; should refer to an original &#x60;schemeUniqueTransactionID&#x60; provided in an earlier payment (not necessarily processed by Adyen). A &#x60;schemeTraceId&#x60; is typically available for authorization adjustments or recurring payments.</value>
        [DataMember(Name = "schemeTraceId", EmitDefaultValue = false)]
        public string SchemeTraceId { get; set; }

        /// <summary>
        /// The unique identifier created by the scheme. This ID can be alphanumeric or numeric depending on the scheme.
        /// </summary>
        /// <value>The unique identifier created by the scheme. This ID can be alphanumeric or numeric depending on the scheme.</value>
        [DataMember(Name = "schemeUniqueTransactionId", EmitDefaultValue = false)]
        public string SchemeUniqueTransactionId { get; set; }

        /// <summary>
        /// The evaluation of the validation facts. See [validation checks](https://docs.adyen.com/issuing/validation-checks) for more information.
        /// </summary>
        /// <value>The evaluation of the validation facts. See [validation checks](https://docs.adyen.com/issuing/validation-checks) for more information.</value>
        [DataMember(Name = "validationFacts", EmitDefaultValue = false)]
        public List<TransferNotificationValidationFact> ValidationFacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuedCard {\n");
            sb.Append("  AuthorisationType: ").Append(AuthorisationType).Append("\n");
            sb.Append("  PanEntryMode: ").Append(PanEntryMode).Append("\n");
            sb.Append("  ProcessingType: ").Append(ProcessingType).Append("\n");
            sb.Append("  RelayedAuthorisationData: ").Append(RelayedAuthorisationData).Append("\n");
            sb.Append("  SchemeTraceId: ").Append(SchemeTraceId).Append("\n");
            sb.Append("  SchemeUniqueTransactionId: ").Append(SchemeUniqueTransactionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValidationFacts: ").Append(ValidationFacts).Append("\n");
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
            return this.Equals(input as IssuedCard);
        }

        /// <summary>
        /// Returns true if IssuedCard instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedCard input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthorisationType == input.AuthorisationType ||
                    (this.AuthorisationType != null &&
                    this.AuthorisationType.Equals(input.AuthorisationType))
                ) && 
                (
                    this.PanEntryMode == input.PanEntryMode ||
                    this.PanEntryMode.Equals(input.PanEntryMode)
                ) && 
                (
                    this.ProcessingType == input.ProcessingType ||
                    this.ProcessingType.Equals(input.ProcessingType)
                ) && 
                (
                    this.RelayedAuthorisationData == input.RelayedAuthorisationData ||
                    (this.RelayedAuthorisationData != null &&
                    this.RelayedAuthorisationData.Equals(input.RelayedAuthorisationData))
                ) && 
                (
                    this.SchemeTraceId == input.SchemeTraceId ||
                    (this.SchemeTraceId != null &&
                    this.SchemeTraceId.Equals(input.SchemeTraceId))
                ) && 
                (
                    this.SchemeUniqueTransactionId == input.SchemeUniqueTransactionId ||
                    (this.SchemeUniqueTransactionId != null &&
                    this.SchemeUniqueTransactionId.Equals(input.SchemeUniqueTransactionId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.ValidationFacts == input.ValidationFacts ||
                    this.ValidationFacts != null &&
                    input.ValidationFacts != null &&
                    this.ValidationFacts.SequenceEqual(input.ValidationFacts)
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
                if (this.AuthorisationType != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorisationType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PanEntryMode.GetHashCode();
                hashCode = (hashCode * 59) + this.ProcessingType.GetHashCode();
                if (this.RelayedAuthorisationData != null)
                {
                    hashCode = (hashCode * 59) + this.RelayedAuthorisationData.GetHashCode();
                }
                if (this.SchemeTraceId != null)
                {
                    hashCode = (hashCode * 59) + this.SchemeTraceId.GetHashCode();
                }
                if (this.SchemeUniqueTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.SchemeUniqueTransactionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.ValidationFacts != null)
                {
                    hashCode = (hashCode * 59) + this.ValidationFacts.GetHashCode();
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
