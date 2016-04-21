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
    /// 
    /// </summary>
    [DataContract]
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/OrganizationAddress.cs
    public partial class OrganizationAddress :  IEquatable<OrganizationAddress>
=======
    public partial class DisconnectReason :  IEquatable<DisconnectReason>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DisconnectReason.cs
    { 

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum {
            
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/OrganizationAddress.cs
            [EnumMember(Value = "WORK")]
            Work,
            
            [EnumMember(Value = "HOME")]
            Home,
            
            [EnumMember(Value = "MOBILE")]
            Mobile,
            
            [EnumMember(Value = "MAIN")]
            Main
        }


        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum MediaTypeEnum {
            
            [EnumMember(Value = "PHONE")]
            Phone,
            
            [EnumMember(Value = "EMAIL")]
            Email,
            
            [EnumMember(Value = "SMS")]
            Sms
        }

        

=======
            [EnumMember(Value = "Q_850")]
            Q850,
            
            [EnumMember(Value = "SIP")]
            Sip
        }

        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DisconnectReason" />class.
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

    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DisconnectReason.cs
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/OrganizationAddress.cs
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    

=======
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int? Code { get; set; }
    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DisconnectReason.cs
        /// <summary>
        /// Gets or Sets Phrase
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/OrganizationAddress.cs
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationAddress" />class.
        /// </summary>
        /// <param name="Display">Display.</param>
        /// <param name="Address">Address.</param>
        /// <param name="Type">Type.</param>
        /// <param name="MediaType">MediaType.</param>

        public OrganizationAddress(string Display = null, string Address = null, TypeEnum? Type = null, MediaTypeEnum? MediaType = null)
        {
            this.Display = Display;
            this.Address = Address;
            this.Type = Type;
            this.MediaType = MediaType;
            
        }

    
        /// <summary>
        /// Gets or Sets Display
        /// </summary>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public string Display { get; set; }
    
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
=======
        [DataMember(Name="phrase", EmitDefaultValue=false)]
        public string Phrase { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DisconnectReason.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisconnectReason {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/OrganizationAddress.cs
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
=======
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Phrase: ").Append(Phrase).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DisconnectReason.cs
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/OrganizationAddress.cs
        /// <param name="other">Instance of OrganizationAddress to be compared</param>
=======
        /// <param name="other">Instance of DisconnectReason to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DisconnectReason.cs
        /// <returns>Boolean</returns>
        public bool Equals(DisconnectReason other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/OrganizationAddress.cs
                (
                    this.Display == other.Display ||
                    this.Display != null &&
                    this.Display.Equals(other.Display)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DisconnectReason.cs
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/OrganizationAddress.cs
                if (this.Display != null)
                    hash = hash * 59 + this.Display.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
=======
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Phrase != null)
                    hash = hash * 59 + this.Phrase.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DisconnectReason.cs
                return hash;
            }
        }

    }
}
