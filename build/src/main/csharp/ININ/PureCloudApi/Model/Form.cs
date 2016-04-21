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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ChatParticipant.cs
    public partial class ChatParticipant :  IEquatable<ChatParticipant>
    { 

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum {
            
            [EnumMember(Value = "USER")]
            User,
=======
    public partial class Form :  IEquatable<Form>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Form" />class.
        /// </summary>
        /// <param name="Controls">Controls.</param>

        public Form(List<Control> Controls = null)
        {
            this.Controls = Controls;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Form.cs
            
            [EnumMember(Value = "ROOM")]
            Room
        }

<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ChatParticipant.cs
        

=======
    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Form.cs
        /// <summary>
        /// Gets or Sets Controls
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ChatParticipant.cs
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatParticipant" />class.
        /// </summary>
        /// <param name="Type">Type.</param>

        public ChatParticipant(TypeEnum? Type = null)
        {
            this.Type = Type;
            
        }

=======
        [DataMember(Name="controls", EmitDefaultValue=false)]
        public List<Control> Controls { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Form.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ChatParticipant.cs
            sb.Append("class ChatParticipant {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
=======
            sb.Append("class Form {\n");
            sb.Append("  Controls: ").Append(Controls).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Form.cs
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
            return this.Equals(obj as Form);
        }

        /// <summary>
        /// Returns true if Form instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ChatParticipant.cs
        /// <param name="other">Instance of ChatParticipant to be compared</param>
=======
        /// <param name="other">Instance of Form to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Form.cs
        /// <returns>Boolean</returns>
        public bool Equals(Form other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Controls == other.Controls ||
                    this.Controls != null &&
                    this.Controls.SequenceEqual(other.Controls)
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ChatParticipant.cs
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
=======
                if (this.Controls != null)
                    hash = hash * 59 + this.Controls.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Form.cs
                return hash;
            }
        }

    }
}
