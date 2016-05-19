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
    /// SocializeEntityFilter
    /// </summary>
    [DataContract]
    public partial class SocializeEntityFilter :  IEquatable<SocializeEntityFilter>
    {
        /// <summary>
        /// The operator to apply when filtering.
        /// </summary>
        /// <value>The operator to apply when filtering.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            
            /// <summary>
            /// Enum Eq for "EQ"
            /// </summary>
            [EnumMember(Value = "EQ")]
            Eq,
            
            /// <summary>
            /// Enum NegEq for "NEG_EQ"
            /// </summary>
            [EnumMember(Value = "NEG_EQ")]
            NegEq,
            
            /// <summary>
            /// Enum Contains for "CONTAINS"
            /// </summary>
            [EnumMember(Value = "CONTAINS")]
            Contains,
            
            /// <summary>
            /// Enum NegContains for "NEG_CONTAINS"
            /// </summary>
            [EnumMember(Value = "NEG_CONTAINS")]
            NegContains,
            
            /// <summary>
            /// Enum StartsWith for "STARTS_WITH"
            /// </summary>
            [EnumMember(Value = "STARTS_WITH")]
            StartsWith,
            
            /// <summary>
            /// Enum NegStartsWith for "NEG_STARTS_WITH"
            /// </summary>
            [EnumMember(Value = "NEG_STARTS_WITH")]
            NegStartsWith,
            
            /// <summary>
            /// Enum EndsWith for "ENDS_WITH"
            /// </summary>
            [EnumMember(Value = "ENDS_WITH")]
            EndsWith,
            
            /// <summary>
            /// Enum NegEndsWith for "NEG_ENDS_WITH"
            /// </summary>
            [EnumMember(Value = "NEG_ENDS_WITH")]
            NegEndsWith,
            
            /// <summary>
            /// Enum Bt for "BT"
            /// </summary>
            [EnumMember(Value = "BT")]
            Bt,
            
            /// <summary>
            /// Enum Gt for "GT"
            /// </summary>
            [EnumMember(Value = "GT")]
            Gt,
            
            /// <summary>
            /// Enum Lt for "LT"
            /// </summary>
            [EnumMember(Value = "LT")]
            Lt,
            
            /// <summary>
            /// Enum Ge for "GE"
            /// </summary>
            [EnumMember(Value = "GE")]
            Ge,
            
            /// <summary>
            /// Enum Le for "LE"
            /// </summary>
            [EnumMember(Value = "LE")]
            Le,
            
            /// <summary>
            /// Enum In for "IN"
            /// </summary>
            [EnumMember(Value = "IN")]
            In
        }

        /// <summary>
        /// The operator to apply when filtering.
        /// </summary>
        /// <value>The operator to apply when filtering.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SocializeEntityFilter" /> class.
        /// </summary>
        /// <param name="FieldName">The fieldName the filter will be applied to..</param>
        /// <param name="_Operator">The operator to apply when filtering..</param>
        /// <param name="FieldValue">The value to filter on..</param>
        public SocializeEntityFilter(string FieldName = null, OperatorEnum? _Operator = null, string FieldValue = null)
        {
            this.FieldName = FieldName;
            this._Operator = _Operator;
            this.FieldValue = FieldValue;
        }
        
        /// <summary>
        /// The fieldName the filter will be applied to.
        /// </summary>
        /// <value>The fieldName the filter will be applied to.</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }
        /// <summary>
        /// The value to filter on.
        /// </summary>
        /// <value>The value to filter on.</value>
        [DataMember(Name="fieldValue", EmitDefaultValue=false)]
        public string FieldValue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocializeEntityFilter {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
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
            return this.Equals(obj as SocializeEntityFilter);
        }

        /// <summary>
        /// Returns true if SocializeEntityFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of SocializeEntityFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocializeEntityFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) && 
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) && 
                (
                    this.FieldValue == other.FieldValue ||
                    this.FieldValue != null &&
                    this.FieldValue.Equals(other.FieldValue)
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
                if (this.FieldName != null)
                    hash = hash * 59 + this.FieldName.GetHashCode();
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                if (this.FieldValue != null)
                    hash = hash * 59 + this.FieldValue.GetHashCode();
                return hash;
            }
        }
    }

}
