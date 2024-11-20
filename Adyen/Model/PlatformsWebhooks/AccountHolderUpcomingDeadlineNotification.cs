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
    /// AccountHolderUpcomingDeadlineNotification
    /// </summary>
    [DataContract(Name = "AccountHolderUpcomingDeadlineNotification")]
    public partial class AccountHolderUpcomingDeadlineNotification : IEquatable<AccountHolderUpcomingDeadlineNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderUpcomingDeadlineNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountHolderUpcomingDeadlineNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderUpcomingDeadlineNotification" /> class.
        /// </summary>
        /// <param name="content">content.</param>
        /// <param name="error">error.</param>
        /// <param name="eventDate">The date and time when an event has been completed. (required).</param>
        /// <param name="eventType">The event type of the notification. (required).</param>
        /// <param name="executingUserKey">The user or process that has triggered the notification. (required).</param>
        /// <param name="live">Indicates whether the notification originated from the live environment or the test environment. If true, the notification originated from the live environment. If false, the notification originated from the test environment. (required).</param>
        /// <param name="pspReference">The PSP reference of the request from which the notification originates. (required).</param>
        public AccountHolderUpcomingDeadlineNotification(AccountHolderUpcomingDeadlineNotificationContent content = default(AccountHolderUpcomingDeadlineNotificationContent), NotificationErrorContainer error = default(NotificationErrorContainer), DateTime eventDate = default(DateTime), string eventType = default(string), string executingUserKey = default(string), bool? live = default(bool?), string pspReference = default(string))
        {
            this.EventDate = eventDate;
            this.EventType = eventType;
            this.ExecutingUserKey = executingUserKey;
            this.Live = live;
            this.PspReference = pspReference;
            this.Content = content;
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public AccountHolderUpcomingDeadlineNotificationContent Content { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public NotificationErrorContainer Error { get; set; }

        /// <summary>
        /// The date and time when an event has been completed.
        /// </summary>
        /// <value>The date and time when an event has been completed.</value>
        [DataMember(Name = "eventDate", IsRequired = false, EmitDefaultValue = false)]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// The event type of the notification.
        /// </summary>
        /// <value>The event type of the notification.</value>
        [DataMember(Name = "eventType", IsRequired = false, EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// The user or process that has triggered the notification.
        /// </summary>
        /// <value>The user or process that has triggered the notification.</value>
        [DataMember(Name = "executingUserKey", IsRequired = false, EmitDefaultValue = false)]
        public string ExecutingUserKey { get; set; }

        /// <summary>
        /// Indicates whether the notification originated from the live environment or the test environment. If true, the notification originated from the live environment. If false, the notification originated from the test environment.
        /// </summary>
        /// <value>Indicates whether the notification originated from the live environment or the test environment. If true, the notification originated from the live environment. If false, the notification originated from the test environment.</value>
        [DataMember(Name = "live", IsRequired = false, EmitDefaultValue = false)]
        public bool? Live { get; set; }

        /// <summary>
        /// The PSP reference of the request from which the notification originates.
        /// </summary>
        /// <value>The PSP reference of the request from which the notification originates.</value>
        [DataMember(Name = "pspReference", IsRequired = false, EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountHolderUpcomingDeadlineNotification {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  ExecutingUserKey: ").Append(ExecutingUserKey).Append("\n");
            sb.Append("  Live: ").Append(Live).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
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
            return this.Equals(input as AccountHolderUpcomingDeadlineNotification);
        }

        /// <summary>
        /// Returns true if AccountHolderUpcomingDeadlineNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountHolderUpcomingDeadlineNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderUpcomingDeadlineNotification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.EventDate == input.EventDate ||
                    (this.EventDate != null &&
                    this.EventDate.Equals(input.EventDate))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.ExecutingUserKey == input.ExecutingUserKey ||
                    (this.ExecutingUserKey != null &&
                    this.ExecutingUserKey.Equals(input.ExecutingUserKey))
                ) && 
                (
                    this.Live == input.Live ||
                    this.Live.Equals(input.Live)
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
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
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.EventDate != null)
                {
                    hashCode = (hashCode * 59) + this.EventDate.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.ExecutingUserKey != null)
                {
                    hashCode = (hashCode * 59) + this.ExecutingUserKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Live.GetHashCode();
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
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
