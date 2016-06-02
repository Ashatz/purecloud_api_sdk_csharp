using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ININ.PureCloudApi.Model
{
    /// <summary>
    /// PaymentMethod
    /// </summary>
    [DataContract]
    public partial class PaymentMethod :  IEquatable<PaymentMethod>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Token for "CARD_TOKEN"
            /// </summary>
            [EnumMember(Value = "CARD_TOKEN")]
            Token
        }

        /// <summary>
        /// for payment methods of type CARD_TOKEN, the type of credit or debit card
        /// </summary>
        /// <value>for payment methods of type CARD_TOKEN, the type of credit or debit card</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardTypeEnum
        {
            
            /// <summary>
            /// Enum Visa for "Visa"
            /// </summary>
            [EnumMember(Value = "Visa")]
            Visa,
            
            /// <summary>
            /// Enum Mastercard for "MasterCard"
            /// </summary>
            [EnumMember(Value = "MasterCard")]
            Mastercard,
            
            /// <summary>
            /// Enum Discover for "Discover"
            /// </summary>
            [EnumMember(Value = "Discover")]
            Discover,
            
            /// <summary>
            /// Enum AmericanExpress for "American Express"
            /// </summary>
            [EnumMember(Value = "American Express")]
            AmericanExpress
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// for payment methods of type CARD_TOKEN, the type of credit or debit card
        /// </summary>
        /// <value>for payment methods of type CARD_TOKEN, the type of credit or debit card</value>
        [DataMember(Name="cardType", EmitDefaultValue=false)]
        public CardTypeEnum? CardType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        /// <param name="ProviderName">ProviderName.</param>
        /// <param name="Token">Token.</param>
        /// <param name="CardExpirationDate">for payment methods of type CARD_TOKEN, the card&#39;s expiration date in the format YYYY-MM..</param>
        /// <param name="CardLastFourDigits">CardLastFourDigits.</param>
        /// <param name="CardType">for payment methods of type CARD_TOKEN, the type of credit or debit card.</param>
        public PaymentMethod(string Name = null, TypeEnum? Type = null, string ProviderName = null, string Token = null, string CardExpirationDate = null, string CardLastFourDigits = null, CardTypeEnum? CardType = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.ProviderName = ProviderName;
            this.Token = Token;
            this.CardExpirationDate = CardExpirationDate;
            this.CardLastFourDigits = CardLastFourDigits;
            this.CardType = CardType;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets ProviderName
        /// </summary>
        [DataMember(Name="providerName", EmitDefaultValue=false)]
        public string ProviderName { get; set; }
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
        /// <summary>
        /// for payment methods of type CARD_TOKEN, the card&#39;s expiration date in the format YYYY-MM.
        /// </summary>
        /// <value>for payment methods of type CARD_TOKEN, the card&#39;s expiration date in the format YYYY-MM.</value>
        [DataMember(Name="cardExpirationDate", EmitDefaultValue=false)]
        public string CardExpirationDate { get; set; }
        /// <summary>
        /// Gets or Sets CardLastFourDigits
        /// </summary>
        [DataMember(Name="cardLastFourDigits", EmitDefaultValue=false)]
        public string CardLastFourDigits { get; set; }
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethod {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  CardExpirationDate: ").Append(CardExpirationDate).Append("\n");
            sb.Append("  CardLastFourDigits: ").Append(CardLastFourDigits).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PaymentMethod);
        }

        /// <summary>
        /// Returns true if PaymentMethod instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethod other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.ProviderName == other.ProviderName ||
                    this.ProviderName != null &&
                    this.ProviderName.Equals(other.ProviderName)
                ) &&
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) &&
                (
                    this.CardExpirationDate == other.CardExpirationDate ||
                    this.CardExpirationDate != null &&
                    this.CardExpirationDate.Equals(other.CardExpirationDate)
                ) &&
                (
                    this.CardLastFourDigits == other.CardLastFourDigits ||
                    this.CardLastFourDigits != null &&
                    this.CardLastFourDigits.Equals(other.CardLastFourDigits)
                ) &&
                (
                    this.CardType == other.CardType ||
                    this.CardType != null &&
                    this.CardType.Equals(other.CardType)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.ProviderName != null)
                    hash = hash * 59 + this.ProviderName.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.CardExpirationDate != null)
                    hash = hash * 59 + this.CardExpirationDate.GetHashCode();
                if (this.CardLastFourDigits != null)
                    hash = hash * 59 + this.CardLastFourDigits.GetHashCode();
                if (this.CardType != null)
                    hash = hash * 59 + this.CardType.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
