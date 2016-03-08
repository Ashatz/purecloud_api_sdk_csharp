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
    public partial class Control :  IEquatable<Control>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "CHECKBOX")]
            Checkbox,
            
            [EnumMember(Value = "RADIO")]
            Radio,
            
            [EnumMember(Value = "SELECT")]
            Select
        }
    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Control" /> class.
        /// Initializes a new instance of the <see cref="Control" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Label">Label.</param>
        /// <param name="Options">Options.</param>
        /// <param name="Required">Required (default to false).</param>
        /// <param name="_ReadOnly">_ReadOnly (default to false).</param>
        /// <param name="VariableBindingId">VariableBindingId.</param>
        /// <param name="Type">Type.</param>

        public Control(string Id = null, string Label = null, List<ControlOptions> Options = null, bool? Required = null, bool? _ReadOnly = null, string VariableBindingId = null, TypeEnum? Type = null)
        {
            this.Id = Id;
            this.Label = Label;
            this.Options = Options;
            // use default value if no "Required" provided
            if (Required == null)
            {
                this.Required = false;
            }
            else
            {
                this.Required = Required;
            }
            // use default value if no "_ReadOnly" provided
            if (_ReadOnly == null)
            {
                this._ReadOnly = false;
            }
            else
            {
                this._ReadOnly = _ReadOnly;
            }
            this.VariableBindingId = VariableBindingId;
            this.Type = Type;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
    
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<ControlOptions> Options { get; set; }
    
        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }
    
        /// <summary>
        /// Gets or Sets _ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? _ReadOnly { get; set; }
    
        /// <summary>
        /// Gets or Sets VariableBindingId
        /// </summary>
        [DataMember(Name="variableBindingId", EmitDefaultValue=false)]
        public string VariableBindingId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Control {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
            sb.Append("  VariableBindingId: ").Append(VariableBindingId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            
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
            return this.Equals(obj as Control);
        }

        /// <summary>
        /// Returns true if Control instances are equal
        /// </summary>
        /// <param name="other">Instance of Control to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Control other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(other.Options)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this._ReadOnly == other._ReadOnly ||
                    this._ReadOnly != null &&
                    this._ReadOnly.Equals(other._ReadOnly)
                ) && 
                (
                    this.VariableBindingId == other.VariableBindingId ||
                    this.VariableBindingId != null &&
                    this.VariableBindingId.Equals(other.VariableBindingId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                
                if (this._ReadOnly != null)
                    hash = hash * 59 + this._ReadOnly.GetHashCode();
                
                if (this.VariableBindingId != null)
                    hash = hash * 59 + this.VariableBindingId.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }

    }
}
