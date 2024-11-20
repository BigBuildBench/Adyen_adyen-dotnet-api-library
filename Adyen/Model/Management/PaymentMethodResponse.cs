/*
* Management API
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// PaymentMethodResponse
    /// </summary>
    [DataContract(Name = "PaymentMethodResponse")]
    public partial class PaymentMethodResponse : IEquatable<PaymentMethodResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines TypesWithErrors
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypesWithErrorsEnum
        {
            /// <summary>
            /// Enum Accel for value: accel
            /// </summary>
            [EnumMember(Value = "accel")]
            Accel = 1,

            /// <summary>
            /// Enum Afterpaytouch for value: afterpaytouch
            /// </summary>
            [EnumMember(Value = "afterpaytouch")]
            Afterpaytouch = 2,

            /// <summary>
            /// Enum Alelo for value: alelo
            /// </summary>
            [EnumMember(Value = "alelo")]
            Alelo = 3,

            /// <summary>
            /// Enum Alipay for value: alipay
            /// </summary>
            [EnumMember(Value = "alipay")]
            Alipay = 4,

            /// <summary>
            /// Enum AlipayHk for value: alipay_hk
            /// </summary>
            [EnumMember(Value = "alipay_hk")]
            AlipayHk = 5,

            /// <summary>
            /// Enum Amex for value: amex
            /// </summary>
            [EnumMember(Value = "amex")]
            Amex = 6,

            /// <summary>
            /// Enum Applepay for value: applepay
            /// </summary>
            [EnumMember(Value = "applepay")]
            Applepay = 7,

            /// <summary>
            /// Enum BaneseCard for value: banese_card
            /// </summary>
            [EnumMember(Value = "banese_card")]
            BaneseCard = 8,

            /// <summary>
            /// Enum BaneseCardCredit for value: banese_card_credit
            /// </summary>
            [EnumMember(Value = "banese_card_credit")]
            BaneseCardCredit = 9,

            /// <summary>
            /// Enum BaneseCardDebit for value: banese_card_debit
            /// </summary>
            [EnumMember(Value = "banese_card_debit")]
            BaneseCardDebit = 10,

            /// <summary>
            /// Enum BaneseCardPrepaid for value: banese_card_prepaid
            /// </summary>
            [EnumMember(Value = "banese_card_prepaid")]
            BaneseCardPrepaid = 11,

            /// <summary>
            /// Enum Bcmc for value: bcmc
            /// </summary>
            [EnumMember(Value = "bcmc")]
            Bcmc = 12,

            /// <summary>
            /// Enum Blik for value: blik
            /// </summary>
            [EnumMember(Value = "blik")]
            Blik = 13,

            /// <summary>
            /// Enum Cartebancaire for value: cartebancaire
            /// </summary>
            [EnumMember(Value = "cartebancaire")]
            Cartebancaire = 14,

            /// <summary>
            /// Enum Clearpay for value: clearpay
            /// </summary>
            [EnumMember(Value = "clearpay")]
            Clearpay = 15,

            /// <summary>
            /// Enum Clicktopay for value: clicktopay
            /// </summary>
            [EnumMember(Value = "clicktopay")]
            Clicktopay = 16,

            /// <summary>
            /// Enum Credtodos for value: credtodos
            /// </summary>
            [EnumMember(Value = "credtodos")]
            Credtodos = 17,

            /// <summary>
            /// Enum CredtodosPrivateCredit for value: credtodos_private_credit
            /// </summary>
            [EnumMember(Value = "credtodos_private_credit")]
            CredtodosPrivateCredit = 18,

            /// <summary>
            /// Enum CredtodosPrivateDebit for value: credtodos_private_debit
            /// </summary>
            [EnumMember(Value = "credtodos_private_debit")]
            CredtodosPrivateDebit = 19,

            /// <summary>
            /// Enum Cup for value: cup
            /// </summary>
            [EnumMember(Value = "cup")]
            Cup = 20,

            /// <summary>
            /// Enum Diners for value: diners
            /// </summary>
            [EnumMember(Value = "diners")]
            Diners = 21,

            /// <summary>
            /// Enum DirectdebitGB for value: directdebit_GB
            /// </summary>
            [EnumMember(Value = "directdebit_GB")]
            DirectdebitGB = 22,

            /// <summary>
            /// Enum Discover for value: discover
            /// </summary>
            [EnumMember(Value = "discover")]
            Discover = 23,

            /// <summary>
            /// Enum EbankingFI for value: ebanking_FI
            /// </summary>
            [EnumMember(Value = "ebanking_FI")]
            EbankingFI = 24,

            /// <summary>
            /// Enum EftposAustralia for value: eftpos_australia
            /// </summary>
            [EnumMember(Value = "eftpos_australia")]
            EftposAustralia = 25,

            /// <summary>
            /// Enum Elo for value: elo
            /// </summary>
            [EnumMember(Value = "elo")]
            Elo = 26,

            /// <summary>
            /// Enum Elocredit for value: elocredit
            /// </summary>
            [EnumMember(Value = "elocredit")]
            Elocredit = 27,

            /// <summary>
            /// Enum Elodebit for value: elodebit
            /// </summary>
            [EnumMember(Value = "elodebit")]
            Elodebit = 28,

            /// <summary>
            /// Enum Girocard for value: girocard
            /// </summary>
            [EnumMember(Value = "girocard")]
            Girocard = 29,

            /// <summary>
            /// Enum Googlepay for value: googlepay
            /// </summary>
            [EnumMember(Value = "googlepay")]
            Googlepay = 30,

            /// <summary>
            /// Enum Hiper for value: hiper
            /// </summary>
            [EnumMember(Value = "hiper")]
            Hiper = 31,

            /// <summary>
            /// Enum Hipercard for value: hipercard
            /// </summary>
            [EnumMember(Value = "hipercard")]
            Hipercard = 32,

            /// <summary>
            /// Enum Ideal for value: ideal
            /// </summary>
            [EnumMember(Value = "ideal")]
            Ideal = 33,

            /// <summary>
            /// Enum InteracCard for value: interac_card
            /// </summary>
            [EnumMember(Value = "interac_card")]
            InteracCard = 34,

            /// <summary>
            /// Enum Jcb for value: jcb
            /// </summary>
            [EnumMember(Value = "jcb")]
            Jcb = 35,

            /// <summary>
            /// Enum Klarna for value: klarna
            /// </summary>
            [EnumMember(Value = "klarna")]
            Klarna = 36,

            /// <summary>
            /// Enum KlarnaAccount for value: klarna_account
            /// </summary>
            [EnumMember(Value = "klarna_account")]
            KlarnaAccount = 37,

            /// <summary>
            /// Enum KlarnaPaynow for value: klarna_paynow
            /// </summary>
            [EnumMember(Value = "klarna_paynow")]
            KlarnaPaynow = 38,

            /// <summary>
            /// Enum Maestro for value: maestro
            /// </summary>
            [EnumMember(Value = "maestro")]
            Maestro = 39,

            /// <summary>
            /// Enum Mbway for value: mbway
            /// </summary>
            [EnumMember(Value = "mbway")]
            Mbway = 40,

            /// <summary>
            /// Enum Mc for value: mc
            /// </summary>
            [EnumMember(Value = "mc")]
            Mc = 41,

            /// <summary>
            /// Enum Mcdebit for value: mcdebit
            /// </summary>
            [EnumMember(Value = "mcdebit")]
            Mcdebit = 42,

            /// <summary>
            /// Enum MealVoucherFR for value: mealVoucher_FR
            /// </summary>
            [EnumMember(Value = "mealVoucher_FR")]
            MealVoucherFR = 43,

            /// <summary>
            /// Enum Mobilepay for value: mobilepay
            /// </summary>
            [EnumMember(Value = "mobilepay")]
            Mobilepay = 44,

            /// <summary>
            /// Enum Multibanco for value: multibanco
            /// </summary>
            [EnumMember(Value = "multibanco")]
            Multibanco = 45,

            /// <summary>
            /// Enum Nyce for value: nyce
            /// </summary>
            [EnumMember(Value = "nyce")]
            Nyce = 46,

            /// <summary>
            /// Enum OnlineBankingPL for value: onlineBanking_PL
            /// </summary>
            [EnumMember(Value = "onlineBanking_PL")]
            OnlineBankingPL = 47,

            /// <summary>
            /// Enum Paybybank for value: paybybank
            /// </summary>
            [EnumMember(Value = "paybybank")]
            Paybybank = 48,

            /// <summary>
            /// Enum Payme for value: payme
            /// </summary>
            [EnumMember(Value = "payme")]
            Payme = 49,

            /// <summary>
            /// Enum PaymePos for value: payme_pos
            /// </summary>
            [EnumMember(Value = "payme_pos")]
            PaymePos = 50,

            /// <summary>
            /// Enum Paynow for value: paynow
            /// </summary>
            [EnumMember(Value = "paynow")]
            Paynow = 51,

            /// <summary>
            /// Enum PaynowPos for value: paynow_pos
            /// </summary>
            [EnumMember(Value = "paynow_pos")]
            PaynowPos = 52,

            /// <summary>
            /// Enum Paypal for value: paypal
            /// </summary>
            [EnumMember(Value = "paypal")]
            Paypal = 53,

            /// <summary>
            /// Enum Payshop for value: payshop
            /// </summary>
            [EnumMember(Value = "payshop")]
            Payshop = 54,

            /// <summary>
            /// Enum Pulse for value: pulse
            /// </summary>
            [EnumMember(Value = "pulse")]
            Pulse = 55,

            /// <summary>
            /// Enum Sodexo for value: sodexo
            /// </summary>
            [EnumMember(Value = "sodexo")]
            Sodexo = 56,

            /// <summary>
            /// Enum Star for value: star
            /// </summary>
            [EnumMember(Value = "star")]
            Star = 57,

            /// <summary>
            /// Enum Swish for value: swish
            /// </summary>
            [EnumMember(Value = "swish")]
            Swish = 58,

            /// <summary>
            /// Enum Ticket for value: ticket
            /// </summary>
            [EnumMember(Value = "ticket")]
            Ticket = 59,

            /// <summary>
            /// Enum TodoGiftcard for value: todo_giftcard
            /// </summary>
            [EnumMember(Value = "todo_giftcard")]
            TodoGiftcard = 60,

            /// <summary>
            /// Enum Trustly for value: trustly
            /// </summary>
            [EnumMember(Value = "trustly")]
            Trustly = 61,

            /// <summary>
            /// Enum Twint for value: twint
            /// </summary>
            [EnumMember(Value = "twint")]
            Twint = 62,

            /// <summary>
            /// Enum TwintPos for value: twint_pos
            /// </summary>
            [EnumMember(Value = "twint_pos")]
            TwintPos = 63,

            /// <summary>
            /// Enum UpBrazilCredit for value: up_brazil_credit
            /// </summary>
            [EnumMember(Value = "up_brazil_credit")]
            UpBrazilCredit = 64,

            /// <summary>
            /// Enum ValeRefeicao for value: vale_refeicao
            /// </summary>
            [EnumMember(Value = "vale_refeicao")]
            ValeRefeicao = 65,

            /// <summary>
            /// Enum ValeRefeicaoPrepaid for value: vale_refeicao_prepaid
            /// </summary>
            [EnumMember(Value = "vale_refeicao_prepaid")]
            ValeRefeicaoPrepaid = 66,

            /// <summary>
            /// Enum Vipps for value: vipps
            /// </summary>
            [EnumMember(Value = "vipps")]
            Vipps = 67,

            /// <summary>
            /// Enum Visa for value: visa
            /// </summary>
            [EnumMember(Value = "visa")]
            Visa = 68,

            /// <summary>
            /// Enum Visadebit for value: visadebit
            /// </summary>
            [EnumMember(Value = "visadebit")]
            Visadebit = 69,

            /// <summary>
            /// Enum Vpay for value: vpay
            /// </summary>
            [EnumMember(Value = "vpay")]
            Vpay = 70,

            /// <summary>
            /// Enum Wechatpay for value: wechatpay
            /// </summary>
            [EnumMember(Value = "wechatpay")]
            Wechatpay = 71,

            /// <summary>
            /// Enum WechatpayPos for value: wechatpay_pos
            /// </summary>
            [EnumMember(Value = "wechatpay_pos")]
            WechatpayPos = 72

        }



        /// <summary>
        /// Payment method types with errors.
        /// </summary>
        /// <value>Payment method types with errors.</value>
        [DataMember(Name = "typesWithErrors", EmitDefaultValue = false)]
        public List<TypesWithErrorsEnum> TypesWithErrors { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodResponse" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="data">The list of supported payment methods and their details..</param>
        /// <param name="itemsTotal">Total number of items. (required).</param>
        /// <param name="pagesTotal">Total number of pages. (required).</param>
        /// <param name="typesWithErrors">Payment method types with errors..</param>
        public PaymentMethodResponse(PaginationLinks links = default(PaginationLinks), List<PaymentMethod> data = default(List<PaymentMethod>), int? itemsTotal = default(int?), int? pagesTotal = default(int?), List<TypesWithErrorsEnum> typesWithErrors = default(List<TypesWithErrorsEnum>))
        {
            this.ItemsTotal = itemsTotal;
            this.PagesTotal = pagesTotal;
            this.Links = links;
            this.Data = data;
            this.TypesWithErrors = typesWithErrors;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public PaginationLinks Links { get; set; }

        /// <summary>
        /// The list of supported payment methods and their details.
        /// </summary>
        /// <value>The list of supported payment methods and their details.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<PaymentMethod> Data { get; set; }

        /// <summary>
        /// Total number of items.
        /// </summary>
        /// <value>Total number of items.</value>
        [DataMember(Name = "itemsTotal", IsRequired = false, EmitDefaultValue = false)]
        public int? ItemsTotal { get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        /// <value>Total number of pages.</value>
        [DataMember(Name = "pagesTotal", IsRequired = false, EmitDefaultValue = false)]
        public int? PagesTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodResponse {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ItemsTotal: ").Append(ItemsTotal).Append("\n");
            sb.Append("  PagesTotal: ").Append(PagesTotal).Append("\n");
            sb.Append("  TypesWithErrors: ").Append(TypesWithErrors).Append("\n");
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
            return this.Equals(input as PaymentMethodResponse);
        }

        /// <summary>
        /// Returns true if PaymentMethodResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.ItemsTotal == input.ItemsTotal ||
                    this.ItemsTotal.Equals(input.ItemsTotal)
                ) && 
                (
                    this.PagesTotal == input.PagesTotal ||
                    this.PagesTotal.Equals(input.PagesTotal)
                ) && 
                (
                    this.TypesWithErrors == input.TypesWithErrors ||
                    this.TypesWithErrors.SequenceEqual(input.TypesWithErrors)
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
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemsTotal.GetHashCode();
                hashCode = (hashCode * 59) + this.PagesTotal.GetHashCode();
                hashCode = (hashCode * 59) + this.TypesWithErrors.GetHashCode();
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
