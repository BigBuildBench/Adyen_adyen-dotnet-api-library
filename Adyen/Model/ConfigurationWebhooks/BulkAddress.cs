/*
* Configuration webhooks
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

namespace Adyen.Model.ConfigurationWebhooks
{
    /// <summary>
    /// BulkAddress
    /// </summary>
    [DataContract(Name = "BulkAddress")]
    public partial class BulkAddress : IEquatable<BulkAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddress" /> class.
        /// </summary>
        /// <param name="city">The name of the city..</param>
        /// <param name="company">The name of the company..</param>
        /// <param name="country">The two-character ISO-3166-1 alpha-2 country code. For example, **US**. (required).</param>
        /// <param name="email">The email address..</param>
        /// <param name="houseNumberOrName">The house number or name..</param>
        /// <param name="mobile">The full telephone number..</param>
        /// <param name="postalCode">The postal code.  Maximum length:  * 5 digits for addresses in the US.  * 10 characters for all other countries..</param>
        /// <param name="stateOrProvince">The two-letter ISO 3166-2 state or province code.  Maximum length: 2 characters for addresses in the US..</param>
        /// <param name="street">The streetname of the house..</param>
        public BulkAddress(string city = default(string), string company = default(string), string country = default(string), string email = default(string), string houseNumberOrName = default(string), string mobile = default(string), string postalCode = default(string), string stateOrProvince = default(string), string street = default(string))
        {
            this.Country = country;
            this.City = city;
            this.Company = company;
            this.Email = email;
            this.HouseNumberOrName = houseNumberOrName;
            this.Mobile = mobile;
            this.PostalCode = postalCode;
            this.StateOrProvince = stateOrProvince;
            this.Street = street;
        }

        /// <summary>
        /// The name of the city.
        /// </summary>
        /// <value>The name of the city.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public string Company { get; set; }

        /// <summary>
        /// The two-character ISO-3166-1 alpha-2 country code. For example, **US**.
        /// </summary>
        /// <value>The two-character ISO-3166-1 alpha-2 country code. For example, **US**.</value>
        [DataMember(Name = "country", IsRequired = false, EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        /// <value>The email address.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The house number or name.
        /// </summary>
        /// <value>The house number or name.</value>
        [DataMember(Name = "houseNumberOrName", EmitDefaultValue = false)]
        public string HouseNumberOrName { get; set; }

        /// <summary>
        /// The full telephone number.
        /// </summary>
        /// <value>The full telephone number.</value>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// The postal code.  Maximum length:  * 5 digits for addresses in the US.  * 10 characters for all other countries.
        /// </summary>
        /// <value>The postal code.  Maximum length:  * 5 digits for addresses in the US.  * 10 characters for all other countries.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The two-letter ISO 3166-2 state or province code.  Maximum length: 2 characters for addresses in the US.
        /// </summary>
        /// <value>The two-letter ISO 3166-2 state or province code.  Maximum length: 2 characters for addresses in the US.</value>
        [DataMember(Name = "stateOrProvince", EmitDefaultValue = false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// The streetname of the house.
        /// </summary>
        /// <value>The streetname of the house.</value>
        [DataMember(Name = "street", EmitDefaultValue = false)]
        public string Street { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BulkAddress {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  HouseNumberOrName: ").Append(HouseNumberOrName).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
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
            return this.Equals(input as BulkAddress);
        }

        /// <summary>
        /// Returns true if BulkAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkAddress input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.HouseNumberOrName == input.HouseNumberOrName ||
                    (this.HouseNumberOrName != null &&
                    this.HouseNumberOrName.Equals(input.HouseNumberOrName))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.StateOrProvince == input.StateOrProvince ||
                    (this.StateOrProvince != null &&
                    this.StateOrProvince.Equals(input.StateOrProvince))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
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
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.HouseNumberOrName != null)
                {
                    hashCode = (hashCode * 59) + this.HouseNumberOrName.GetHashCode();
                }
                if (this.Mobile != null)
                {
                    hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.StateOrProvince != null)
                {
                    hashCode = (hashCode * 59) + this.StateOrProvince.GetHashCode();
                }
                if (this.Street != null)
                {
                    hashCode = (hashCode * 59) + this.Street.GetHashCode();
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
