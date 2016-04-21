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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceMemberFilter.cs
    public partial class InstanceMemberFilter :  IEquatable<InstanceMemberFilter>
    { 

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum {
            
            [EnumMember(Value = "PARTIAL")]
            Partial,
            
            [EnumMember(Value = "EXACT")]
            Exact
=======
    public partial class AttributeFilterItem :  IEquatable<AttributeFilterItem>
    { 

        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AttributeFilterItem.cs
        }

        

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceMemberFilter" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Values">Values.</param>
        /// <param name="Type">Type.</param>

        public InstanceMemberFilter(string Id = null, List<string> Values = null, TypeEnum? Type = null)
        {
            this.Id = Id;
            this.Values = Values;
            this.Type = Type;
            
        }

    
        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public _OperatorEnum? _Operator { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeFilterItem" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="_Operator">_Operator.</param>
        /// <param name="Values">Values.</param>

        public AttributeFilterItem(string Id = null, _OperatorEnum? _Operator = null, List<string> Values = null)
        {
            this.Id = Id;
            this._Operator = _Operator;
            this.Values = Values;
            
        }

    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
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
            sb.Append("class AttributeFilterItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceMemberFilter.cs
            sb.Append("  Type: ").Append(Type).Append("\n");
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AttributeFilterItem.cs
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
            return this.Equals(obj as AttributeFilterItem);
        }

        /// <summary>
        /// Returns true if AttributeFilterItem instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceMemberFilter.cs
        /// <param name="other">Instance of InstanceMemberFilter to be compared</param>
=======
        /// <param name="other">Instance of AttributeFilterItem to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AttributeFilterItem.cs
        /// <returns>Boolean</returns>
        public bool Equals(AttributeFilterItem other)
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceMemberFilter.cs
=======
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AttributeFilterItem.cs
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceMemberFilter.cs
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AttributeFilterItem.cs
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceMemberFilter.cs
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
=======
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AttributeFilterItem.cs
                return hash;
            }
        }

    }
}
