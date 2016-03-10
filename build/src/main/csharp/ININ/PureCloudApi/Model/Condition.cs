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
    public partial class Condition :  IEquatable<Condition>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueTypeEnum {
            
            [EnumMember(Value = "STRING")]
            String,
            
            [EnumMember(Value = "NUMERIC")]
            Numeric,
            
            [EnumMember(Value = "DATETIME")]
            Datetime,
            
            [EnumMember(Value = "PERIOD")]
            Period
        }
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum _OperatorEnum {
            
            [EnumMember(Value = "EQUALS")]
            Equals,
            
            [EnumMember(Value = "LESS_THAN")]
            LessThan,
            
            [EnumMember(Value = "LESS_THAN_EQUALS")]
            LessThanEquals,
            
            [EnumMember(Value = "GREATER_THAN")]
            GreaterThan,
            
            [EnumMember(Value = "GREATER_THAN_EQUALS")]
            GreaterThanEquals,
            
            [EnumMember(Value = "CONTAINS")]
            Contains,
            
            [EnumMember(Value = "BEGINS_WITH")]
            BeginsWith,
            
            [EnumMember(Value = "ENDS_WITH")]
            EndsWith,
            
            [EnumMember(Value = "BEFORE")]
            Before,
            
            [EnumMember(Value = "AFTER")]
            After
        }
        
        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public ValueTypeEnum? ValueType { get; set; }
    
        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public _OperatorEnum? _Operator { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" />class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Inverted">Inverted (default to false).</param>
        /// <param name="AttributeName">AttributeName.</param>
        /// <param name="Value">Value.</param>
        /// <param name="ValueType">ValueType.</param>
        /// <param name="_Operator">_Operator.</param>
        /// <param name="Codes">Codes.</param>

        public Condition(string Type = null, bool? Inverted = null, string AttributeName = null, string Value = null, ValueTypeEnum? ValueType = null, _OperatorEnum? _Operator = null, List<string> Codes = null)
        {
            this.Type = Type;
            // use default value if no "Inverted" provided
            if (Inverted == null)
            {
                this.Inverted = false;
            }
            else
            {
                this.Inverted = Inverted;
            }
            this.AttributeName = AttributeName;
            this.Value = Value;
            this.ValueType = ValueType;
            this._Operator = _Operator;
            this.Codes = Codes;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or Sets Inverted
        /// </summary>
        [DataMember(Name="inverted", EmitDefaultValue=false)]
        public bool? Inverted { get; set; }
    
        /// <summary>
        /// Gets or Sets AttributeName
        /// </summary>
        [DataMember(Name="attributeName", EmitDefaultValue=false)]
        public string AttributeName { get; set; }
    
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
    
        /// <summary>
        /// Gets or Sets Codes
        /// </summary>
        [DataMember(Name="codes", EmitDefaultValue=false)]
        public List<string> Codes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Condition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Inverted: ").Append(Inverted).Append("\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Codes: ").Append(Codes).Append("\n");
            
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
            return this.Equals(obj as Condition);
        }

        /// <summary>
        /// Returns true if Condition instances are equal
        /// </summary>
        /// <param name="other">Instance of Condition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Condition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Inverted == other.Inverted ||
                    this.Inverted != null &&
                    this.Inverted.Equals(other.Inverted)
                ) &&
                (
                    this.AttributeName == other.AttributeName ||
                    this.AttributeName != null &&
                    this.AttributeName.Equals(other.AttributeName)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.ValueType == other.ValueType ||
                    this.ValueType != null &&
                    this.ValueType.Equals(other.ValueType)
                ) &&
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
                (
                    this.Codes == other.Codes ||
                    this.Codes != null &&
                    this.Codes.SequenceEqual(other.Codes)
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
                
                if (this.Inverted != null)
                    hash = hash * 59 + this.Inverted.GetHashCode();
                
                if (this.AttributeName != null)
                    hash = hash * 59 + this.AttributeName.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.ValueType != null)
                    hash = hash * 59 + this.ValueType.GetHashCode();
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.Codes != null)
                    hash = hash * 59 + this.Codes.GetHashCode();
                
                return hash;
            }
        }

    }
}
