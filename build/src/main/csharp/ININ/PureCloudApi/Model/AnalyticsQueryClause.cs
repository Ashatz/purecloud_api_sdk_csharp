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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Occurrence.cs
    public partial class Occurrence :  IEquatable<Occurrence>
=======
    public partial class AnalyticsQueryClause :  IEquatable<AnalyticsQueryClause>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AnalyticsQueryClause.cs
    { 

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum {
            
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Occurrence.cs
            [EnumMember(Value = "EVENT")]
            Event,
            
            [EnumMember(Value = "SECONDS")]
            Seconds,
            
            [EnumMember(Value = "MINUTES")]
            Minutes,
            
            [EnumMember(Value = "INTERVALS")]
            Intervals
=======
            [EnumMember(Value = "and")]
            And,
            
            [EnumMember(Value = "or")]
            Or
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AnalyticsQueryClause.cs
        }

        

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Occurrence" />class.
        /// </summary>
        /// <param name="Limit">Limit.</param>
        /// <param name="Type">Type.</param>

        public Occurrence(int? Limit = null, TypeEnum? Type = null)
        {
            this.Limit = Limit;
            this.Type = Type;
            
        }

    
        /// <summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Occurrence.cs
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
=======
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryClause" />class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Predicates">Like a three-word sentence: (attribute-name) (operator) (target-value). These can be one of three types: dimension, property, metric..</param>

        public AnalyticsQueryClause(TypeEnum? Type = null, List<AnalyticsQueryPredicate> Predicates = null)
        {
            this.Type = Type;
            this.Predicates = Predicates;
            
        }

    
        /// <summary>
        /// Like a three-word sentence: (attribute-name) (operator) (target-value). These can be one of three types: dimension, property, metric.
        /// </summary>
        /// <value>Like a three-word sentence: (attribute-name) (operator) (target-value). These can be one of three types: dimension, property, metric.</value>
        [DataMember(Name="predicates", EmitDefaultValue=false)]
        public List<AnalyticsQueryPredicate> Predicates { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AnalyticsQueryClause.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsQueryClause {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Occurrence.cs
=======
            sb.Append("  Predicates: ").Append(Predicates).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AnalyticsQueryClause.cs
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
            return this.Equals(obj as AnalyticsQueryClause);
        }

        /// <summary>
        /// Returns true if AnalyticsQueryClause instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Occurrence.cs
        /// <param name="other">Instance of Occurrence to be compared</param>
=======
        /// <param name="other">Instance of AnalyticsQueryClause to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AnalyticsQueryClause.cs
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsQueryClause other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Occurrence.cs
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AnalyticsQueryClause.cs
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/Occurrence.cs
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
=======
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Predicates != null)
                    hash = hash * 59 + this.Predicates.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AnalyticsQueryClause.cs
                return hash;
            }
        }

    }
}
