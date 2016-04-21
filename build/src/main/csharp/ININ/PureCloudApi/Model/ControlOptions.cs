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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Tag.cs
    public partial class Tag :  IEquatable<Tag>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" />class.
        /// </summary>
        /// <param name="Label">Label.</param>
        /// <param name="InteractionFlag">InteractionFlag (default to false).</param>

        public Tag(string Label = null, bool? InteractionFlag = null)
        {
            this.Label = Label;
            // use default value if no "InteractionFlag" provided
            if (InteractionFlag == null)
            {
                this.InteractionFlag = false;
            }
            else
            {
                this.InteractionFlag = InteractionFlag;
            }
=======
    public partial class ControlOptions :  IEquatable<ControlOptions>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlOptions" />class.
        /// </summary>
        /// <param name="Value">Value.</param>
        /// <param name="Label">Label.</param>

        public ControlOptions(string Value = null, string Label = null)
        {
            this.Value = Value;
            this.Label = Label;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ControlOptions.cs
            
        }

    
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Tag.cs
=======
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ControlOptions.cs
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
    
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Tag.cs
        /// <summary>
        /// Gets or Sets InteractionFlag
        /// </summary>
        [DataMember(Name="interactionFlag", EmitDefaultValue=false)]
        public bool? InteractionFlag { get; set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ControlOptions.cs
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControlOptions {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Tag.cs
            sb.Append("  InteractionFlag: ").Append(InteractionFlag).Append("\n");
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ControlOptions.cs
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
            return this.Equals(obj as ControlOptions);
        }

        /// <summary>
        /// Returns true if ControlOptions instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Tag.cs
        /// <param name="other">Instance of Tag to be compared</param>
=======
        /// <param name="other">Instance of ControlOptions to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ControlOptions.cs
        /// <returns>Boolean</returns>
        public bool Equals(ControlOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Tag.cs
=======
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ControlOptions.cs
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Tag.cs
                ) &&
                (
                    this.InteractionFlag == other.InteractionFlag ||
                    this.InteractionFlag != null &&
                    this.InteractionFlag.Equals(other.InteractionFlag)
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ControlOptions.cs
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Tag.cs
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.InteractionFlag != null)
                    hash = hash * 59 + this.InteractionFlag.GetHashCode();
=======
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ControlOptions.cs
                return hash;
            }
        }

    }
}
