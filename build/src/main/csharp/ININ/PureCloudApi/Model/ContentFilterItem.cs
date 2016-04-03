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
    public partial class ContentFilterItem :  IEquatable<ContentFilterItem>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "NUMBER")]
            Number,
            
            [EnumMember(Value = "STRING")]
            String,
            
            [EnumMember(Value = "DATE")]
            Date,
            
            [EnumMember(Value = "BOOLEAN")]
            Boolean,
            
            [EnumMember(Value = "LIST")]
            List
        }
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum _OperatorEnum {
            
            [EnumMember(Value = "IN")]
            In,
            
            [EnumMember(Value = "RANGE")]
            Range,
            
            [EnumMember(Value = "EQUALS")]
            Equals,
            
            [EnumMember(Value = "NOTEQUALS")]
            Notequals,
            
            [EnumMember(Value = "LESSTHAN")]
            Lessthan,
            
            [EnumMember(Value = "LESSTHANEQUALS")]
            Lessthanequals,
            
            [EnumMember(Value = "GREATERTHAN")]
            Greaterthan,
            
            [EnumMember(Value = "GREATERTHANEQUALS")]
            Greaterthanequals,
            
            [EnumMember(Value = "CONTAINS")]
            Contains
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
        /// Initializes a new instance of the <see cref="ContentFilterItem" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        /// <param name="_Operator">_Operator.</param>
        /// <param name="Values">Values.</param>

        public ContentFilterItem(string Name = null, TypeEnum? Type = null, _OperatorEnum? _Operator = null, List<string> Values = null)
        {
            this.Name = Name;
            this.Type = Type;
            this._Operator = _Operator;
            this.Values = Values;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentFilterItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            
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
            return this.Equals(obj as ContentFilterItem);
        }

        /// <summary>
        /// Returns true if ContentFilterItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentFilterItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentFilterItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                
                return hash;
            }
        }

    }
}
