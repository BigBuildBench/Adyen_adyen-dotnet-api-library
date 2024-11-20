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
using System.Reflection;

namespace Adyen.Model.TransferWebhooks
{
    /// <summary>
    /// The relevant data according to the transfer category.
    /// </summary>
    [JsonConverter(typeof(TransferDataCategoryDataJsonConverter))]
    [DataContract(Name = "TransferData_categoryData")]
    public partial class TransferDataCategoryData : AbstractOpenAPISchema, IEquatable<TransferDataCategoryData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDataCategoryData" /> class
        /// with the <see cref="BankCategoryData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of BankCategoryData.</param>
        public TransferDataCategoryData(BankCategoryData actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDataCategoryData" /> class
        /// with the <see cref="InternalCategoryData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InternalCategoryData.</param>
        public TransferDataCategoryData(InternalCategoryData actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDataCategoryData" /> class
        /// with the <see cref="IssuedCard" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IssuedCard.</param>
        public TransferDataCategoryData(IssuedCard actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDataCategoryData" /> class
        /// with the <see cref="PlatformPayment" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PlatformPayment.</param>
        public TransferDataCategoryData(PlatformPayment actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(BankCategoryData))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(InternalCategoryData))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(IssuedCard))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PlatformPayment))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: BankCategoryData, InternalCategoryData, IssuedCard, PlatformPayment");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `BankCategoryData`. If the actual instance is not `BankCategoryData`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of BankCategoryData</returns>
        public BankCategoryData GetBankCategoryData()
        {
            return (BankCategoryData)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `InternalCategoryData`. If the actual instance is not `InternalCategoryData`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InternalCategoryData</returns>
        public InternalCategoryData GetInternalCategoryData()
        {
            return (InternalCategoryData)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IssuedCard`. If the actual instance is not `IssuedCard`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IssuedCard</returns>
        public IssuedCard GetIssuedCard()
        {
            return (IssuedCard)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PlatformPayment`. If the actual instance is not `PlatformPayment`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PlatformPayment</returns>
        public PlatformPayment GetPlatformPayment()
        {
            return (PlatformPayment)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferDataCategoryData {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, TransferDataCategoryData.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of TransferDataCategoryData
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of TransferDataCategoryData</returns>
        public static TransferDataCategoryData FromJson(string jsonString)
        {
            TransferDataCategoryData newTransferDataCategoryData = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newTransferDataCategoryData;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();
            JToken typeToken = JObject.Parse(jsonString).GetValue("type");
            string type = typeToken?.Value<string>();
            // Throw exception if jsonString does not contain type param
            if (type == null)
            {
                throw new InvalidDataException("JsonString does not contain required enum type for deserialization.");
            }
            try
            {
                // Check if the jsonString type enum matches the BankCategoryData type enums
                if (ContainsValue<BankCategoryData.TypeEnum>(type))
                {
                    newTransferDataCategoryData = new TransferDataCategoryData(JsonConvert.DeserializeObject<BankCategoryData>(jsonString, TransferDataCategoryData.SerializerSettings));
                    matchedTypes.Add("BankCategoryData");
                    match++;
                }
                // Check if the jsonString type enum matches the InternalCategoryData type enums
                if (ContainsValue<InternalCategoryData.TypeEnum>(type))
                {
                    newTransferDataCategoryData = new TransferDataCategoryData(JsonConvert.DeserializeObject<InternalCategoryData>(jsonString, TransferDataCategoryData.SerializerSettings));
                    matchedTypes.Add("InternalCategoryData");
                    match++;
                }
                // Check if the jsonString type enum matches the IssuedCard type enums
                if (ContainsValue<IssuedCard.TypeEnum>(type))
                {
                    newTransferDataCategoryData = new TransferDataCategoryData(JsonConvert.DeserializeObject<IssuedCard>(jsonString, TransferDataCategoryData.SerializerSettings));
                    matchedTypes.Add("IssuedCard");
                    match++;
                }
                // Check if the jsonString type enum matches the PlatformPayment type enums
                if (ContainsValue<PlatformPayment.TypeEnum>(type))
                {
                    newTransferDataCategoryData = new TransferDataCategoryData(JsonConvert.DeserializeObject<PlatformPayment>(jsonString, TransferDataCategoryData.SerializerSettings));
                    matchedTypes.Add("PlatformPayment");
                    match++;
                }
            } 
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                     throw new InvalidDataException(string.Format("Failed to deserialize `{0}` into target: {1}", jsonString, ex.ToString()));
                }
            }

            if (match != 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined. MatchedTypes are: " + matchedTypes);
            }
            
            // deserialization is considered successful at this point if no exception has been thrown.
            return newTransferDataCategoryData;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferDataCategoryData);
        }

        /// <summary>
        /// Returns true if TransferDataCategoryData instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferDataCategoryData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferDataCategoryData input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for TransferDataCategoryData
    /// </summary>
    public class TransferDataCategoryDataJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(TransferDataCategoryData).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return TransferDataCategoryData.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
