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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DateDefinition.cs
    public partial class DateDefinition :  IEquatable<DateDefinition>
    { 

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum {
=======
    public partial class MemberEntity :  IEquatable<MemberEntity>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberEntity" />class.
        /// </summary>
        /// <param name="Id">Id.</param>

        public MemberEntity(string Id = null)
        {
            this.Id = Id;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MemberEntity.cs
            
            [EnumMember(Value = "DATE")]
            Date,
            
            [EnumMember(Value = "TIME")]
            Time,
            
            [EnumMember(Value = "DATETIME")]
            Datetime
        }

<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DateDefinition.cs
        

=======
    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MemberEntity.cs
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DateDefinition.cs
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DateDefinition" />class.
        /// </summary>
        /// <param name="Type">Type.</param>

        public DateDefinition(TypeEnum? Type = null)
        {
            this.Type = Type;
            
        }

=======
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MemberEntity.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DateDefinition.cs
            sb.Append("class DateDefinition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
=======
            sb.Append("class MemberEntity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MemberEntity.cs
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
            return this.Equals(obj as MemberEntity);
        }

        /// <summary>
        /// Returns true if MemberEntity instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DateDefinition.cs
        /// <param name="other">Instance of DateDefinition to be compared</param>
=======
        /// <param name="other">Instance of MemberEntity to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MemberEntity.cs
        /// <returns>Boolean</returns>
        public bool Equals(MemberEntity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DateDefinition.cs
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
=======
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MemberEntity.cs
                return hash;
            }
        }

    }
}
