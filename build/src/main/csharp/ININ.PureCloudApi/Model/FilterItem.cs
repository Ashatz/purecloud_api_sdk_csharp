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
    /// FilterItem
    /// </summary>
    [DataContract]
    public partial class FilterItem :  IEquatable<FilterItem>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Number for "NUMBER"
            /// </summary>
            [EnumMember(Value = "NUMBER")]
            Number,
            
            /// <summary>
            /// Enum String for "STRING"
            /// </summary>
            [EnumMember(Value = "STRING")]
            String,
            
            /// <summary>
            /// Enum Date for "DATE"
            /// </summary>
            [EnumMember(Value = "DATE")]
            Date,
            
            /// <summary>
            /// Enum Boolean for "BOOLEAN"
            /// </summary>
            [EnumMember(Value = "BOOLEAN")]
            Boolean,
            
            /// <summary>
            /// Enum List for "LIST"
            /// </summary>
            [EnumMember(Value = "LIST")]
            List,
            
            /// <summary>
            /// Enum Group for "GROUP"
            /// </summary>
            [EnumMember(Value = "GROUP")]
            Group
        }

        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            
            /// <summary>
            /// Enum In for "IN"
            /// </summary>
            [EnumMember(Value = "IN")]
            In,
            
            /// <summary>
            /// Enum Range for "RANGE"
            /// </summary>
            [EnumMember(Value = "RANGE")]
            Range,
            
            /// <summary>
            /// Enum Equals for "EQUALS"
            /// </summary>
            [EnumMember(Value = "EQUALS")]
            Equals,
            
            /// <summary>
            /// Enum Notequals for "NOTEQUALS"
            /// </summary>
            [EnumMember(Value = "NOTEQUALS")]
            Notequals,
            
            /// <summary>
            /// Enum Lessthan for "LESSTHAN"
            /// </summary>
            [EnumMember(Value = "LESSTHAN")]
            Lessthan,
            
            /// <summary>
            /// Enum Lessthanequals for "LESSTHANEQUALS"
            /// </summary>
            [EnumMember(Value = "LESSTHANEQUALS")]
            Lessthanequals,
            
            /// <summary>
            /// Enum Greaterthan for "GREATERTHAN"
            /// </summary>
            [EnumMember(Value = "GREATERTHAN")]
            Greaterthan,
            
            /// <summary>
            /// Enum Greaterthanequals for "GREATERTHANEQUALS"
            /// </summary>
            [EnumMember(Value = "GREATERTHANEQUALS")]
            Greaterthanequals,
            
            /// <summary>
            /// Enum Orgroup for "ORGROUP"
            /// </summary>
            [EnumMember(Value = "ORGROUP")]
            Orgroup,
            
            /// <summary>
            /// Enum Andgroup for "ANDGROUP"
            /// </summary>
            [EnumMember(Value = "ANDGROUP")]
            Andgroup,
            
            /// <summary>
            /// Enum Notgroup for "NOTGROUP"
            /// </summary>
            [EnumMember(Value = "NOTGROUP")]
            Notgroup
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
        public OperatorEnum? _Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterItem" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        /// <param name="_Operator">_Operator.</param>
        /// <param name="Values">Values.</param>
        /// <param name="Filters">Filters.</param>
        public FilterItem(string Name = null, TypeEnum? Type = null, OperatorEnum? _Operator = null, List<string> Values = null, List<FilterItem> Filters = null)
        {
            this.Name = Name;
            this.Type = Type;
            this._Operator = _Operator;
            this.Values = Values;
            this.Filters = Filters;
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
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<FilterItem> Filters { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
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
            return this.Equals(obj as FilterItem);
        }

        /// <summary>
        /// Returns true if FilterItem instances are equal
        /// </summary>
        /// <param name="other">Instance of FilterItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                ) && 
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
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
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                return hash;
            }
        }
    }

}
