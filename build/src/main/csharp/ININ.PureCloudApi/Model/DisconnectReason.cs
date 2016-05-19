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
    /// DisconnectReason
    /// </summary>
    [DataContract]
    public partial class DisconnectReason :  IEquatable<DisconnectReason>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Q850 for "Q_850"
            /// </summary>
            [EnumMember(Value = "Q_850")]
            Q850,
            
            /// <summary>
            /// Enum Sip for "SIP"
            /// </summary>
            [EnumMember(Value = "SIP")]
            Sip
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DisconnectReason" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Code">Code.</param>
        /// <param name="Phrase">Phrase.</param>
        public DisconnectReason(TypeEnum? Type = null, int? Code = null, string Phrase = null)
        {
            this.Type = Type;
            this.Code = Code;
            this.Phrase = Phrase;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int? Code { get; set; }
        /// <summary>
        /// Gets or Sets Phrase
        /// </summary>
        [DataMember(Name="phrase", EmitDefaultValue=false)]
        public string Phrase { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisconnectReason {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Phrase: ").Append(Phrase).Append("\n");
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
            return this.Equals(obj as DisconnectReason);
        }

        /// <summary>
        /// Returns true if DisconnectReason instances are equal
        /// </summary>
        /// <param name="other">Instance of DisconnectReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisconnectReason other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Phrase == other.Phrase ||
                    this.Phrase != null &&
                    this.Phrase.Equals(other.Phrase)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Phrase != null)
                    hash = hash * 59 + this.Phrase.GetHashCode();
                return hash;
            }
        }
    }

}
