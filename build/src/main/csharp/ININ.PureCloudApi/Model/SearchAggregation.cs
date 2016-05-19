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
    /// SearchAggregation
    /// </summary>
    [DataContract]
    public partial class SearchAggregation :  IEquatable<SearchAggregation>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Term for "TERM"
            /// </summary>
            [EnumMember(Value = "TERM")]
            Term,
            
            /// <summary>
            /// Enum Count for "COUNT"
            /// </summary>
            [EnumMember(Value = "COUNT")]
            Count,
            
            /// <summary>
            /// Enum Sum for "SUM"
            /// </summary>
            [EnumMember(Value = "SUM")]
            Sum,
            
            /// <summary>
            /// Enum Average for "AVERAGE"
            /// </summary>
            [EnumMember(Value = "AVERAGE")]
            Average
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAggregation" /> class.
        /// </summary>
        /// <param name="Field">Field.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        public SearchAggregation(string Field = null, string Name = null, TypeEnum? Type = null)
        {
            this.Field = Field;
            this.Name = Name;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchAggregation {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as SearchAggregation);
        }

        /// <summary>
        /// Returns true if SearchAggregation instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchAggregation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchAggregation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }
    }

}
