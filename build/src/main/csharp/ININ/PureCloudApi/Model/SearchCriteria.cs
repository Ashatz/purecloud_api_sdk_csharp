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
    public partial class SearchCriteria :  IEquatable<SearchCriteria>
    { 

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum {
            
            [EnumMember(Value = "EXACT")]
            Exact,
            
            [EnumMember(Value = "CONTAINS")]
            Contains,
            
            [EnumMember(Value = "STARTS_WITH")]
            StartsWith,
            
            [EnumMember(Value = "REQUIRED_FIELDS")]
            RequiredFields,
            
            [EnumMember(Value = "RANGE")]
            Range,
            
            [EnumMember(Value = "DATE_RANGE")]
            DateRange,
            
            [EnumMember(Value = "LESS_THAN")]
            LessThan,
            
            [EnumMember(Value = "LESS_THAN_EQUAL_TO")]
            LessThanEqualTo,
            
            [EnumMember(Value = "GREATER_THAN")]
            GreaterThan,
            
            [EnumMember(Value = "GREATER_THAN_EQUAL_TO")]
            GreaterThanEqualTo,
            
            [EnumMember(Value = "SIMPLE_STRING")]
            SimpleString
        }


        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum _OperatorEnum {
            
            [EnumMember(Value = "AND")]
            And,
            
            [EnumMember(Value = "OR")]
            Or,
            
            [EnumMember(Value = "NOT")]
            Not
        }

        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public _OperatorEnum? _Operator { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCriteria" />class.
        /// </summary>
        /// <param name="EndValue">EndValue.</param>
        /// <param name="Values">Values.</param>
        /// <param name="StartValue">StartValue.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Fields">Fields.</param>
        /// <param name="Value">Value.</param>
        /// <param name="_Operator">_Operator.</param>
        /// <param name="Group">Group.</param>

        public SearchCriteria(string EndValue = null, List<string> Values = null, string StartValue = null, TypeEnum? Type = null, List<string> Fields = null, string Value = null, _OperatorEnum? _Operator = null, List<SearchCriteria> Group = null)
        {
            this.EndValue = EndValue;
            this.Values = Values;
            this.StartValue = StartValue;
            this.Type = Type;
            this.Fields = Fields;
            this.Value = Value;
            this._Operator = _Operator;
            this.Group = Group;
            
        }

    
        /// <summary>
        /// Gets or Sets EndValue
        /// </summary>
        [DataMember(Name="endValue", EmitDefaultValue=false)]
        public string EndValue { get; set; }
    
        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }
    
        /// <summary>
        /// Gets or Sets StartValue
        /// </summary>
        [DataMember(Name="startValue", EmitDefaultValue=false)]
        public string StartValue { get; set; }
    
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }
    
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
    
        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public List<SearchCriteria> Group { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchCriteria {\n");
            sb.Append("  EndValue: ").Append(EndValue).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  StartValue: ").Append(StartValue).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
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
            return this.Equals(obj as SearchCriteria);
        }

        /// <summary>
        /// Returns true if SearchCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchCriteria other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EndValue == other.EndValue ||
                    this.EndValue != null &&
                    this.EndValue.Equals(other.EndValue)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) &&
                (
                    this.StartValue == other.StartValue ||
                    this.StartValue != null &&
                    this.StartValue.Equals(other.StartValue)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.SequenceEqual(other.Group)
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
                if (this.EndValue != null)
                    hash = hash * 59 + this.EndValue.GetHashCode();
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                if (this.StartValue != null)
                    hash = hash * 59 + this.StartValue.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                return hash;
            }
        }

    }
}
