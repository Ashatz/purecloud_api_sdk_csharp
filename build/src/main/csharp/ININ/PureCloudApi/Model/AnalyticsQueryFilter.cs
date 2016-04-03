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
    public partial class AnalyticsQueryFilter :  IEquatable<AnalyticsQueryFilter>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "and")]
            And,
            
            [EnumMember(Value = "or")]
            Or
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryFilter" />class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Clauses">Boolean &#39;and/or&#39; logic with up to two-levels of nesting.</param>
        /// <param name="Predicates">Like a three-word sentence: (attribute-name) (operator) (target-value). These can be one of three types: dimension, property, metric..</param>

        public AnalyticsQueryFilter(TypeEnum? Type = null, List<AnalyticsQueryClause> Clauses = null, List<AnalyticsQueryPredicate> Predicates = null)
        {
            this.Type = Type;
            this.Clauses = Clauses;
            this.Predicates = Predicates;
            
        }
        
    
        /// <summary>
        /// Boolean 'and/or' logic with up to two-levels of nesting
        /// </summary>
        /// <value>Boolean 'and/or' logic with up to two-levels of nesting</value>
        [DataMember(Name="clauses", EmitDefaultValue=false)]
        public List<AnalyticsQueryClause> Clauses { get; set; }
    
        /// <summary>
        /// Like a three-word sentence: (attribute-name) (operator) (target-value). These can be one of three types: dimension, property, metric.
        /// </summary>
        /// <value>Like a three-word sentence: (attribute-name) (operator) (target-value). These can be one of three types: dimension, property, metric.</value>
        [DataMember(Name="predicates", EmitDefaultValue=false)]
        public List<AnalyticsQueryPredicate> Predicates { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsQueryFilter {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Clauses: ").Append(Clauses).Append("\n");
            sb.Append("  Predicates: ").Append(Predicates).Append("\n");
            
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
            return this.Equals(obj as AnalyticsQueryFilter);
        }

        /// <summary>
        /// Returns true if AnalyticsQueryFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsQueryFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsQueryFilter other)
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
                    this.Clauses == other.Clauses ||
                    this.Clauses != null &&
                    this.Clauses.SequenceEqual(other.Clauses)
                ) &&
                (
                    this.Predicates == other.Predicates ||
                    this.Predicates != null &&
                    this.Predicates.SequenceEqual(other.Predicates)
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
                
                if (this.Clauses != null)
                    hash = hash * 59 + this.Clauses.GetHashCode();
                
                if (this.Predicates != null)
                    hash = hash * 59 + this.Predicates.GetHashCode();
                
                return hash;
            }
        }

    }
}
