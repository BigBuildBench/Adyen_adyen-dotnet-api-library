/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// FundRecipient
    /// </summary>
    [DataContract(Name = "FundRecipient")]
    public partial class FundRecipient : IEquatable<FundRecipient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundRecipient" /> class.
        /// </summary>
        /// <param name="iBAN">Fund Recipient Iban for C2C payments.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="shopperEmail">The email address of the shopper..</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">Required for recurring payments.  Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="subMerchant">subMerchant.</param>
        /// <param name="telephoneNumber">The telephone number of the shopper..</param>
        /// <param name="walletIdentifier">Indicates where the money is going..</param>
        /// <param name="walletOwnerTaxId">Indicates the tax identifier of the fund recepient.</param>
        public FundRecipient(string iBAN = default(string), Address billingAddress = default(Address), CardDetails paymentMethod = default(CardDetails), string shopperEmail = default(string), Name shopperName = default(Name), string shopperReference = default(string), string storedPaymentMethodId = default(string), SubMerchant subMerchant = default(SubMerchant), string telephoneNumber = default(string), string walletIdentifier = default(string), string walletOwnerTaxId = default(string))
        {
            this.IBAN = iBAN;
            this.BillingAddress = billingAddress;
            this.PaymentMethod = paymentMethod;
            this.ShopperEmail = shopperEmail;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.SubMerchant = subMerchant;
            this.TelephoneNumber = telephoneNumber;
            this.WalletIdentifier = walletIdentifier;
            this.WalletOwnerTaxId = walletOwnerTaxId;
        }

        /// <summary>
        /// Fund Recipient Iban for C2C payments
        /// </summary>
        /// <value>Fund Recipient Iban for C2C payments</value>
        [DataMember(Name = "IBAN", EmitDefaultValue = false)]
        public string IBAN { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public CardDetails PaymentMethod { get; set; }

        /// <summary>
        /// The email address of the shopper.
        /// </summary>
        /// <value>The email address of the shopper.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// Gets or Sets ShopperName
        /// </summary>
        [DataMember(Name = "shopperName", EmitDefaultValue = false)]
        public Name ShopperName { get; set; }

        /// <summary>
        /// Required for recurring payments.  Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.
        /// </summary>
        /// <value>Required for recurring payments.  Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// Gets or Sets SubMerchant
        /// </summary>
        [DataMember(Name = "subMerchant", EmitDefaultValue = false)]
        public SubMerchant SubMerchant { get; set; }

        /// <summary>
        /// The telephone number of the shopper.
        /// </summary>
        /// <value>The telephone number of the shopper.</value>
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Indicates where the money is going.
        /// </summary>
        /// <value>Indicates where the money is going.</value>
        [DataMember(Name = "walletIdentifier", EmitDefaultValue = false)]
        public string WalletIdentifier { get; set; }

        /// <summary>
        /// Indicates the tax identifier of the fund recepient
        /// </summary>
        /// <value>Indicates the tax identifier of the fund recepient</value>
        [DataMember(Name = "walletOwnerTaxId", EmitDefaultValue = false)]
        public string WalletOwnerTaxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FundRecipient {\n");
            sb.Append("  IBAN: ").Append(IBAN).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("  SubMerchant: ").Append(SubMerchant).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("  WalletIdentifier: ").Append(WalletIdentifier).Append("\n");
            sb.Append("  WalletOwnerTaxId: ").Append(WalletOwnerTaxId).Append("\n");
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
            return this.Equals(input as FundRecipient);
        }

        /// <summary>
        /// Returns true if FundRecipient instances are equal
        /// </summary>
        /// <param name="input">Instance of FundRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundRecipient input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IBAN == input.IBAN ||
                    (this.IBAN != null &&
                    this.IBAN.Equals(input.IBAN))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    (this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail))
                ) && 
                (
                    this.ShopperName == input.ShopperName ||
                    (this.ShopperName != null &&
                    this.ShopperName.Equals(input.ShopperName))
                ) && 
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
                ) && 
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    (this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
                ) && 
                (
                    this.SubMerchant == input.SubMerchant ||
                    (this.SubMerchant != null &&
                    this.SubMerchant.Equals(input.SubMerchant))
                ) && 
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    (this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(input.TelephoneNumber))
                ) && 
                (
                    this.WalletIdentifier == input.WalletIdentifier ||
                    (this.WalletIdentifier != null &&
                    this.WalletIdentifier.Equals(input.WalletIdentifier))
                ) && 
                (
                    this.WalletOwnerTaxId == input.WalletOwnerTaxId ||
                    (this.WalletOwnerTaxId != null &&
                    this.WalletOwnerTaxId.Equals(input.WalletOwnerTaxId))
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
                if (this.IBAN != null)
                {
                    hashCode = (hashCode * 59) + this.IBAN.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BillingAddress.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                }
                if (this.ShopperEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperEmail.GetHashCode();
                }
                if (this.ShopperName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperName.GetHashCode();
                }
                if (this.ShopperReference != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperReference.GetHashCode();
                }
                if (this.StoredPaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.StoredPaymentMethodId.GetHashCode();
                }
                if (this.SubMerchant != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchant.GetHashCode();
                }
                if (this.TelephoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.TelephoneNumber.GetHashCode();
                }
                if (this.WalletIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.WalletIdentifier.GetHashCode();
                }
                if (this.WalletOwnerTaxId != null)
                {
                    hashCode = (hashCode * 59) + this.WalletOwnerTaxId.GetHashCode();
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
            // ShopperReference (string) maxLength
            if (this.ShopperReference != null && this.ShopperReference.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShopperReference, length must be less than 256.", new [] { "ShopperReference" });
            }

            // ShopperReference (string) minLength
            if (this.ShopperReference != null && this.ShopperReference.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShopperReference, length must be greater than 3.", new [] { "ShopperReference" });
            }

            // StoredPaymentMethodId (string) maxLength
            if (this.StoredPaymentMethodId != null && this.StoredPaymentMethodId.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoredPaymentMethodId, length must be less than 64.", new [] { "StoredPaymentMethodId" });
            }

            yield break;
        }
    }

}
