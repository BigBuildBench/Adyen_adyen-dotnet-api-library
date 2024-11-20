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
    /// TransferEvent
    /// </summary>
    [DataContract(Name = "TransferEvent")]
    public partial class TransferEvent : IEquatable<TransferEvent>, IValidatableObject
    {
        /// <summary>
        /// The reason for the transfer status.
        /// </summary>
        /// <value>The reason for the transfer status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum AmountLimitExceeded for value: amountLimitExceeded
            /// </summary>
            [EnumMember(Value = "amountLimitExceeded")]
            AmountLimitExceeded = 1,

            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 2,

            /// <summary>
            /// Enum BalanceAccountTemporarilyBlockedByTransactionRule for value: balanceAccountTemporarilyBlockedByTransactionRule
            /// </summary>
            [EnumMember(Value = "balanceAccountTemporarilyBlockedByTransactionRule")]
            BalanceAccountTemporarilyBlockedByTransactionRule = 3,

            /// <summary>
            /// Enum CounterpartyAccountBlocked for value: counterpartyAccountBlocked
            /// </summary>
            [EnumMember(Value = "counterpartyAccountBlocked")]
            CounterpartyAccountBlocked = 4,

            /// <summary>
            /// Enum CounterpartyAccountClosed for value: counterpartyAccountClosed
            /// </summary>
            [EnumMember(Value = "counterpartyAccountClosed")]
            CounterpartyAccountClosed = 5,

            /// <summary>
            /// Enum CounterpartyAccountNotFound for value: counterpartyAccountNotFound
            /// </summary>
            [EnumMember(Value = "counterpartyAccountNotFound")]
            CounterpartyAccountNotFound = 6,

            /// <summary>
            /// Enum CounterpartyAddressRequired for value: counterpartyAddressRequired
            /// </summary>
            [EnumMember(Value = "counterpartyAddressRequired")]
            CounterpartyAddressRequired = 7,

            /// <summary>
            /// Enum CounterpartyBankTimedOut for value: counterpartyBankTimedOut
            /// </summary>
            [EnumMember(Value = "counterpartyBankTimedOut")]
            CounterpartyBankTimedOut = 8,

            /// <summary>
            /// Enum CounterpartyBankUnavailable for value: counterpartyBankUnavailable
            /// </summary>
            [EnumMember(Value = "counterpartyBankUnavailable")]
            CounterpartyBankUnavailable = 9,

            /// <summary>
            /// Enum Declined for value: declined
            /// </summary>
            [EnumMember(Value = "declined")]
            Declined = 10,

            /// <summary>
            /// Enum DeclinedByTransactionRule for value: declinedByTransactionRule
            /// </summary>
            [EnumMember(Value = "declinedByTransactionRule")]
            DeclinedByTransactionRule = 11,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 12,

            /// <summary>
            /// Enum NotEnoughBalance for value: notEnoughBalance
            /// </summary>
            [EnumMember(Value = "notEnoughBalance")]
            NotEnoughBalance = 13,

            /// <summary>
            /// Enum PendingApproval for value: pendingApproval
            /// </summary>
            [EnumMember(Value = "pendingApproval")]
            PendingApproval = 14,

            /// <summary>
            /// Enum RefusedByCounterpartyBank for value: refusedByCounterpartyBank
            /// </summary>
            [EnumMember(Value = "refusedByCounterpartyBank")]
            RefusedByCounterpartyBank = 15,

            /// <summary>
            /// Enum RouteNotFound for value: routeNotFound
            /// </summary>
            [EnumMember(Value = "routeNotFound")]
            RouteNotFound = 16,

            /// <summary>
            /// Enum ScaFailed for value: scaFailed
            /// </summary>
            [EnumMember(Value = "scaFailed")]
            ScaFailed = 17,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 18

        }


        /// <summary>
        /// The reason for the transfer status.
        /// </summary>
        /// <value>The reason for the transfer status.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// The status of the transfer event.
        /// </summary>
        /// <value>The status of the transfer event.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ApprovalPending for value: approvalPending
            /// </summary>
            [EnumMember(Value = "approvalPending")]
            ApprovalPending = 1,

            /// <summary>
            /// Enum AtmWithdrawal for value: atmWithdrawal
            /// </summary>
            [EnumMember(Value = "atmWithdrawal")]
            AtmWithdrawal = 2,

            /// <summary>
            /// Enum AtmWithdrawalReversalPending for value: atmWithdrawalReversalPending
            /// </summary>
            [EnumMember(Value = "atmWithdrawalReversalPending")]
            AtmWithdrawalReversalPending = 3,

            /// <summary>
            /// Enum AtmWithdrawalReversed for value: atmWithdrawalReversed
            /// </summary>
            [EnumMember(Value = "atmWithdrawalReversed")]
            AtmWithdrawalReversed = 4,

            /// <summary>
            /// Enum AuthAdjustmentAuthorised for value: authAdjustmentAuthorised
            /// </summary>
            [EnumMember(Value = "authAdjustmentAuthorised")]
            AuthAdjustmentAuthorised = 5,

            /// <summary>
            /// Enum AuthAdjustmentError for value: authAdjustmentError
            /// </summary>
            [EnumMember(Value = "authAdjustmentError")]
            AuthAdjustmentError = 6,

            /// <summary>
            /// Enum AuthAdjustmentRefused for value: authAdjustmentRefused
            /// </summary>
            [EnumMember(Value = "authAdjustmentRefused")]
            AuthAdjustmentRefused = 7,

            /// <summary>
            /// Enum Authorised for value: authorised
            /// </summary>
            [EnumMember(Value = "authorised")]
            Authorised = 8,

            /// <summary>
            /// Enum BankTransfer for value: bankTransfer
            /// </summary>
            [EnumMember(Value = "bankTransfer")]
            BankTransfer = 9,

            /// <summary>
            /// Enum BankTransferPending for value: bankTransferPending
            /// </summary>
            [EnumMember(Value = "bankTransferPending")]
            BankTransferPending = 10,

            /// <summary>
            /// Enum Booked for value: booked
            /// </summary>
            [EnumMember(Value = "booked")]
            Booked = 11,

            /// <summary>
            /// Enum BookingPending for value: bookingPending
            /// </summary>
            [EnumMember(Value = "bookingPending")]
            BookingPending = 12,

            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 13,

            /// <summary>
            /// Enum CapturePending for value: capturePending
            /// </summary>
            [EnumMember(Value = "capturePending")]
            CapturePending = 14,

            /// <summary>
            /// Enum CaptureReversalPending for value: captureReversalPending
            /// </summary>
            [EnumMember(Value = "captureReversalPending")]
            CaptureReversalPending = 15,

            /// <summary>
            /// Enum CaptureReversed for value: captureReversed
            /// </summary>
            [EnumMember(Value = "captureReversed")]
            CaptureReversed = 16,

            /// <summary>
            /// Enum Captured for value: captured
            /// </summary>
            [EnumMember(Value = "captured")]
            Captured = 17,

            /// <summary>
            /// Enum CapturedExternally for value: capturedExternally
            /// </summary>
            [EnumMember(Value = "capturedExternally")]
            CapturedExternally = 18,

            /// <summary>
            /// Enum Chargeback for value: chargeback
            /// </summary>
            [EnumMember(Value = "chargeback")]
            Chargeback = 19,

            /// <summary>
            /// Enum ChargebackExternally for value: chargebackExternally
            /// </summary>
            [EnumMember(Value = "chargebackExternally")]
            ChargebackExternally = 20,

            /// <summary>
            /// Enum ChargebackPending for value: chargebackPending
            /// </summary>
            [EnumMember(Value = "chargebackPending")]
            ChargebackPending = 21,

            /// <summary>
            /// Enum ChargebackReversalPending for value: chargebackReversalPending
            /// </summary>
            [EnumMember(Value = "chargebackReversalPending")]
            ChargebackReversalPending = 22,

            /// <summary>
            /// Enum ChargebackReversed for value: chargebackReversed
            /// </summary>
            [EnumMember(Value = "chargebackReversed")]
            ChargebackReversed = 23,

            /// <summary>
            /// Enum Credited for value: credited
            /// </summary>
            [EnumMember(Value = "credited")]
            Credited = 24,

            /// <summary>
            /// Enum DepositCorrection for value: depositCorrection
            /// </summary>
            [EnumMember(Value = "depositCorrection")]
            DepositCorrection = 25,

            /// <summary>
            /// Enum DepositCorrectionPending for value: depositCorrectionPending
            /// </summary>
            [EnumMember(Value = "depositCorrectionPending")]
            DepositCorrectionPending = 26,

            /// <summary>
            /// Enum Dispute for value: dispute
            /// </summary>
            [EnumMember(Value = "dispute")]
            Dispute = 27,

            /// <summary>
            /// Enum DisputeClosed for value: disputeClosed
            /// </summary>
            [EnumMember(Value = "disputeClosed")]
            DisputeClosed = 28,

            /// <summary>
            /// Enum DisputeExpired for value: disputeExpired
            /// </summary>
            [EnumMember(Value = "disputeExpired")]
            DisputeExpired = 29,

            /// <summary>
            /// Enum DisputeNeedsReview for value: disputeNeedsReview
            /// </summary>
            [EnumMember(Value = "disputeNeedsReview")]
            DisputeNeedsReview = 30,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 31,

            /// <summary>
            /// Enum Expired for value: expired
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired = 32,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 33,

            /// <summary>
            /// Enum Fee for value: fee
            /// </summary>
            [EnumMember(Value = "fee")]
            Fee = 34,

            /// <summary>
            /// Enum FeePending for value: feePending
            /// </summary>
            [EnumMember(Value = "feePending")]
            FeePending = 35,

            /// <summary>
            /// Enum InternalTransfer for value: internalTransfer
            /// </summary>
            [EnumMember(Value = "internalTransfer")]
            InternalTransfer = 36,

            /// <summary>
            /// Enum InternalTransferPending for value: internalTransferPending
            /// </summary>
            [EnumMember(Value = "internalTransferPending")]
            InternalTransferPending = 37,

            /// <summary>
            /// Enum InvoiceDeduction for value: invoiceDeduction
            /// </summary>
            [EnumMember(Value = "invoiceDeduction")]
            InvoiceDeduction = 38,

            /// <summary>
            /// Enum InvoiceDeductionPending for value: invoiceDeductionPending
            /// </summary>
            [EnumMember(Value = "invoiceDeductionPending")]
            InvoiceDeductionPending = 39,

            /// <summary>
            /// Enum ManualCorrectionPending for value: manualCorrectionPending
            /// </summary>
            [EnumMember(Value = "manualCorrectionPending")]
            ManualCorrectionPending = 40,

            /// <summary>
            /// Enum ManuallyCorrected for value: manuallyCorrected
            /// </summary>
            [EnumMember(Value = "manuallyCorrected")]
            ManuallyCorrected = 41,

            /// <summary>
            /// Enum MatchedStatement for value: matchedStatement
            /// </summary>
            [EnumMember(Value = "matchedStatement")]
            MatchedStatement = 42,

            /// <summary>
            /// Enum MatchedStatementPending for value: matchedStatementPending
            /// </summary>
            [EnumMember(Value = "matchedStatementPending")]
            MatchedStatementPending = 43,

            /// <summary>
            /// Enum MerchantPayin for value: merchantPayin
            /// </summary>
            [EnumMember(Value = "merchantPayin")]
            MerchantPayin = 44,

            /// <summary>
            /// Enum MerchantPayinPending for value: merchantPayinPending
            /// </summary>
            [EnumMember(Value = "merchantPayinPending")]
            MerchantPayinPending = 45,

            /// <summary>
            /// Enum MerchantPayinReversed for value: merchantPayinReversed
            /// </summary>
            [EnumMember(Value = "merchantPayinReversed")]
            MerchantPayinReversed = 46,

            /// <summary>
            /// Enum MerchantPayinReversedPending for value: merchantPayinReversedPending
            /// </summary>
            [EnumMember(Value = "merchantPayinReversedPending")]
            MerchantPayinReversedPending = 47,

            /// <summary>
            /// Enum MiscCost for value: miscCost
            /// </summary>
            [EnumMember(Value = "miscCost")]
            MiscCost = 48,

            /// <summary>
            /// Enum MiscCostPending for value: miscCostPending
            /// </summary>
            [EnumMember(Value = "miscCostPending")]
            MiscCostPending = 49,

            /// <summary>
            /// Enum PaymentCost for value: paymentCost
            /// </summary>
            [EnumMember(Value = "paymentCost")]
            PaymentCost = 50,

            /// <summary>
            /// Enum PaymentCostPending for value: paymentCostPending
            /// </summary>
            [EnumMember(Value = "paymentCostPending")]
            PaymentCostPending = 51,

            /// <summary>
            /// Enum PendingApproval for value: pendingApproval
            /// </summary>
            [EnumMember(Value = "pendingApproval")]
            PendingApproval = 52,

            /// <summary>
            /// Enum Received for value: received
            /// </summary>
            [EnumMember(Value = "received")]
            Received = 53,

            /// <summary>
            /// Enum RefundPending for value: refundPending
            /// </summary>
            [EnumMember(Value = "refundPending")]
            RefundPending = 54,

            /// <summary>
            /// Enum RefundReversalPending for value: refundReversalPending
            /// </summary>
            [EnumMember(Value = "refundReversalPending")]
            RefundReversalPending = 55,

            /// <summary>
            /// Enum RefundReversed for value: refundReversed
            /// </summary>
            [EnumMember(Value = "refundReversed")]
            RefundReversed = 56,

            /// <summary>
            /// Enum Refunded for value: refunded
            /// </summary>
            [EnumMember(Value = "refunded")]
            Refunded = 57,

            /// <summary>
            /// Enum RefundedExternally for value: refundedExternally
            /// </summary>
            [EnumMember(Value = "refundedExternally")]
            RefundedExternally = 58,

            /// <summary>
            /// Enum Refused for value: refused
            /// </summary>
            [EnumMember(Value = "refused")]
            Refused = 59,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 60,

            /// <summary>
            /// Enum ReserveAdjustment for value: reserveAdjustment
            /// </summary>
            [EnumMember(Value = "reserveAdjustment")]
            ReserveAdjustment = 61,

            /// <summary>
            /// Enum ReserveAdjustmentPending for value: reserveAdjustmentPending
            /// </summary>
            [EnumMember(Value = "reserveAdjustmentPending")]
            ReserveAdjustmentPending = 62,

            /// <summary>
            /// Enum Returned for value: returned
            /// </summary>
            [EnumMember(Value = "returned")]
            Returned = 63,

            /// <summary>
            /// Enum SecondChargeback for value: secondChargeback
            /// </summary>
            [EnumMember(Value = "secondChargeback")]
            SecondChargeback = 64,

            /// <summary>
            /// Enum SecondChargebackPending for value: secondChargebackPending
            /// </summary>
            [EnumMember(Value = "secondChargebackPending")]
            SecondChargebackPending = 65,

            /// <summary>
            /// Enum Undefined for value: undefined
            /// </summary>
            [EnumMember(Value = "undefined")]
            Undefined = 66

        }


        /// <summary>
        /// The status of the transfer event.
        /// </summary>
        /// <value>The status of the transfer event.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The type of the transfer event. Possible values: **accounting**, **tracking**.
        /// </summary>
        /// <value>The type of the transfer event. Possible values: **accounting**, **tracking**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Accounting for value: accounting
            /// </summary>
            [EnumMember(Value = "accounting")]
            Accounting = 1,

            /// <summary>
            /// Enum Tracking for value: tracking
            /// </summary>
            [EnumMember(Value = "tracking")]
            Tracking = 2

        }


        /// <summary>
        /// The type of the transfer event. Possible values: **accounting**, **tracking**.
        /// </summary>
        /// <value>The type of the transfer event. Possible values: **accounting**, **tracking**.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferEvent" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="amountAdjustments">The amount adjustments in this transfer..</param>
        /// <param name="arn">Scheme unique arn identifier useful for tracing captures, chargebacks, refunds, etc..</param>
        /// <param name="bookingDate">The date when the transfer request was sent..</param>
        /// <param name="estimatedArrivalTime">The estimated time when the beneficiary should have access to the funds..</param>
        /// <param name="externalReason">externalReason.</param>
        /// <param name="id">The unique identifier of the transfer event..</param>
        /// <param name="modification">modification.</param>
        /// <param name="mutations">The list of balance mutations per event..</param>
        /// <param name="originalAmount">originalAmount.</param>
        /// <param name="reason">The reason for the transfer status..</param>
        /// <param name="status">The status of the transfer event..</param>
        /// <param name="trackingData">trackingData.</param>
        /// <param name="transactionId">The id of the transaction that is related to this accounting event. Only sent for events of type **accounting** where the balance changes..</param>
        /// <param name="type">The type of the transfer event. Possible values: **accounting**, **tracking**..</param>
        /// <param name="updateDate">The date when the tracking status was updated..</param>
        /// <param name="valueDate">A future date, when the funds are expected to be deducted from or credited to the balance account..</param>
        public TransferEvent(Amount amount = default(Amount), List<AmountAdjustment> amountAdjustments = default(List<AmountAdjustment>), string arn = default(string), DateTime bookingDate = default(DateTime), DateTime estimatedArrivalTime = default(DateTime), ExternalReason externalReason = default(ExternalReason), string id = default(string), Modification modification = default(Modification), List<BalanceMutation> mutations = default(List<BalanceMutation>), Amount originalAmount = default(Amount), ReasonEnum? reason = default(ReasonEnum?), StatusEnum? status = default(StatusEnum?), TransferEventTrackingData trackingData = default(TransferEventTrackingData), string transactionId = default(string), TypeEnum? type = default(TypeEnum?), DateTime updateDate = default(DateTime), DateTime valueDate = default(DateTime))
        {
            this.Amount = amount;
            this.AmountAdjustments = amountAdjustments;
            this.Arn = arn;
            this.BookingDate = bookingDate;
            this.EstimatedArrivalTime = estimatedArrivalTime;
            this.ExternalReason = externalReason;
            this.Id = id;
            this.Modification = modification;
            this.Mutations = mutations;
            this.OriginalAmount = originalAmount;
            this.Reason = reason;
            this.Status = status;
            this.TrackingData = trackingData;
            this.TransactionId = transactionId;
            this.Type = type;
            this.UpdateDate = updateDate;
            this.ValueDate = valueDate;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The amount adjustments in this transfer.
        /// </summary>
        /// <value>The amount adjustments in this transfer.</value>
        [DataMember(Name = "amountAdjustments", EmitDefaultValue = false)]
        public List<AmountAdjustment> AmountAdjustments { get; set; }

        /// <summary>
        /// Scheme unique arn identifier useful for tracing captures, chargebacks, refunds, etc.
        /// </summary>
        /// <value>Scheme unique arn identifier useful for tracing captures, chargebacks, refunds, etc.</value>
        [DataMember(Name = "arn", EmitDefaultValue = false)]
        public string Arn { get; set; }

        /// <summary>
        /// The date when the transfer request was sent.
        /// </summary>
        /// <value>The date when the transfer request was sent.</value>
        [DataMember(Name = "bookingDate", EmitDefaultValue = false)]
        public DateTime BookingDate { get; set; }

        /// <summary>
        /// The estimated time when the beneficiary should have access to the funds.
        /// </summary>
        /// <value>The estimated time when the beneficiary should have access to the funds.</value>
        [DataMember(Name = "estimatedArrivalTime", EmitDefaultValue = false)]
        public DateTime EstimatedArrivalTime { get; set; }

        /// <summary>
        /// Gets or Sets ExternalReason
        /// </summary>
        [DataMember(Name = "externalReason", EmitDefaultValue = false)]
        public ExternalReason ExternalReason { get; set; }

        /// <summary>
        /// The unique identifier of the transfer event.
        /// </summary>
        /// <value>The unique identifier of the transfer event.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Modification
        /// </summary>
        [DataMember(Name = "modification", EmitDefaultValue = false)]
        public Modification Modification { get; set; }

        /// <summary>
        /// The list of balance mutations per event.
        /// </summary>
        /// <value>The list of balance mutations per event.</value>
        [DataMember(Name = "mutations", EmitDefaultValue = false)]
        public List<BalanceMutation> Mutations { get; set; }

        /// <summary>
        /// Gets or Sets OriginalAmount
        /// </summary>
        [DataMember(Name = "originalAmount", EmitDefaultValue = false)]
        public Amount OriginalAmount { get; set; }

        /// <summary>
        /// Gets or Sets TrackingData
        /// </summary>
        [DataMember(Name = "trackingData", EmitDefaultValue = false)]
        public TransferEventTrackingData TrackingData { get; set; }

        /// <summary>
        /// The id of the transaction that is related to this accounting event. Only sent for events of type **accounting** where the balance changes.
        /// </summary>
        /// <value>The id of the transaction that is related to this accounting event. Only sent for events of type **accounting** where the balance changes.</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// The date when the tracking status was updated.
        /// </summary>
        /// <value>The date when the tracking status was updated.</value>
        [DataMember(Name = "updateDate", EmitDefaultValue = false)]
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// A future date, when the funds are expected to be deducted from or credited to the balance account.
        /// </summary>
        /// <value>A future date, when the funds are expected to be deducted from or credited to the balance account.</value>
        [DataMember(Name = "valueDate", EmitDefaultValue = false)]
        public DateTime ValueDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferEvent {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountAdjustments: ").Append(AmountAdjustments).Append("\n");
            sb.Append("  Arn: ").Append(Arn).Append("\n");
            sb.Append("  BookingDate: ").Append(BookingDate).Append("\n");
            sb.Append("  EstimatedArrivalTime: ").Append(EstimatedArrivalTime).Append("\n");
            sb.Append("  ExternalReason: ").Append(ExternalReason).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Modification: ").Append(Modification).Append("\n");
            sb.Append("  Mutations: ").Append(Mutations).Append("\n");
            sb.Append("  OriginalAmount: ").Append(OriginalAmount).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TrackingData: ").Append(TrackingData).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdateDate: ").Append(UpdateDate).Append("\n");
            sb.Append("  ValueDate: ").Append(ValueDate).Append("\n");
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
            return this.Equals(input as TransferEvent);
        }

        /// <summary>
        /// Returns true if TransferEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AmountAdjustments == input.AmountAdjustments ||
                    this.AmountAdjustments != null &&
                    input.AmountAdjustments != null &&
                    this.AmountAdjustments.SequenceEqual(input.AmountAdjustments)
                ) && 
                (
                    this.Arn == input.Arn ||
                    (this.Arn != null &&
                    this.Arn.Equals(input.Arn))
                ) && 
                (
                    this.BookingDate == input.BookingDate ||
                    (this.BookingDate != null &&
                    this.BookingDate.Equals(input.BookingDate))
                ) && 
                (
                    this.EstimatedArrivalTime == input.EstimatedArrivalTime ||
                    (this.EstimatedArrivalTime != null &&
                    this.EstimatedArrivalTime.Equals(input.EstimatedArrivalTime))
                ) && 
                (
                    this.ExternalReason == input.ExternalReason ||
                    (this.ExternalReason != null &&
                    this.ExternalReason.Equals(input.ExternalReason))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Modification == input.Modification ||
                    (this.Modification != null &&
                    this.Modification.Equals(input.Modification))
                ) && 
                (
                    this.Mutations == input.Mutations ||
                    this.Mutations != null &&
                    input.Mutations != null &&
                    this.Mutations.SequenceEqual(input.Mutations)
                ) && 
                (
                    this.OriginalAmount == input.OriginalAmount ||
                    (this.OriginalAmount != null &&
                    this.OriginalAmount.Equals(input.OriginalAmount))
                ) && 
                (
                    this.Reason == input.Reason ||
                    this.Reason.Equals(input.Reason)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TrackingData == input.TrackingData ||
                    (this.TrackingData != null &&
                    this.TrackingData.Equals(input.TrackingData))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.UpdateDate == input.UpdateDate ||
                    (this.UpdateDate != null &&
                    this.UpdateDate.Equals(input.UpdateDate))
                ) && 
                (
                    this.ValueDate == input.ValueDate ||
                    (this.ValueDate != null &&
                    this.ValueDate.Equals(input.ValueDate))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.AmountAdjustments != null)
                {
                    hashCode = (hashCode * 59) + this.AmountAdjustments.GetHashCode();
                }
                if (this.Arn != null)
                {
                    hashCode = (hashCode * 59) + this.Arn.GetHashCode();
                }
                if (this.BookingDate != null)
                {
                    hashCode = (hashCode * 59) + this.BookingDate.GetHashCode();
                }
                if (this.EstimatedArrivalTime != null)
                {
                    hashCode = (hashCode * 59) + this.EstimatedArrivalTime.GetHashCode();
                }
                if (this.ExternalReason != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalReason.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Modification != null)
                {
                    hashCode = (hashCode * 59) + this.Modification.GetHashCode();
                }
                if (this.Mutations != null)
                {
                    hashCode = (hashCode * 59) + this.Mutations.GetHashCode();
                }
                if (this.OriginalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.TrackingData != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingData.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.UpdateDate != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateDate.GetHashCode();
                }
                if (this.ValueDate != null)
                {
                    hashCode = (hashCode * 59) + this.ValueDate.GetHashCode();
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
