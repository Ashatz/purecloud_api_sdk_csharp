using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class FacetEntry :  IEquatable<FacetEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacetEntry" /> class.
        /// </summary>
        public FacetEntry()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Attribute
        /// </summary>
        [DataMember(Name="attribute", EmitDefaultValue=false)]
        public TermAttribute Attribute { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [DataMember(Name="statistics", EmitDefaultValue=false)]
        public FacetStatistics Statistics { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name="other", EmitDefaultValue=false)]
        public long? Other { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Missing
        /// </summary>
        [DataMember(Name="missing", EmitDefaultValue=false)]
        public long? Missing { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TermCount
        /// </summary>
        [DataMember(Name="termCount", EmitDefaultValue=false)]
        public int? TermCount { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TermType
        /// </summary>
        [DataMember(Name="termType", EmitDefaultValue=false)]
        public string TermType { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public List<FacetTerm> Terms { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacetEntry {\n");
            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Missing: ").Append(Missing).Append("\n");
            sb.Append("  TermCount: ").Append(TermCount).Append("\n");
            sb.Append("  TermType: ").Append(TermType).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            
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
            return this.Equals(obj as FacetEntry);
        }

        /// <summary>
        /// Returns true if FacetEntry instances are equal
        /// </summary>
        /// <param name="obj">Instance of FacetEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacetEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Attribute == other.Attribute ||
                    this.Attribute != null &&
                    this.Attribute.Equals(other.Attribute)
                ) && 
                (
                    this.Statistics == other.Statistics ||
                    this.Statistics != null &&
                    this.Statistics.Equals(other.Statistics)
                ) && 
                (
                    this.Other == other.Other ||
                    this.Other != null &&
                    this.Other.Equals(other.Other)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.Missing == other.Missing ||
                    this.Missing != null &&
                    this.Missing.Equals(other.Missing)
                ) && 
                (
                    this.TermCount == other.TermCount ||
                    this.TermCount != null &&
                    this.TermCount.Equals(other.TermCount)
                ) && 
                (
                    this.TermType == other.TermType ||
                    this.TermType != null &&
                    this.TermType.Equals(other.TermType)
                ) && 
                (
                    this.Terms == other.Terms ||
                    this.Terms != null &&
                    this.Terms.SequenceEqual(other.Terms)
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
                
                if (this.Attribute != null)
                    hash = hash * 57 + this.Attribute.GetHashCode();
                
                if (this.Statistics != null)
                    hash = hash * 57 + this.Statistics.GetHashCode();
                
                if (this.Other != null)
                    hash = hash * 57 + this.Other.GetHashCode();
                
                if (this.Total != null)
                    hash = hash * 57 + this.Total.GetHashCode();
                
                if (this.Missing != null)
                    hash = hash * 57 + this.Missing.GetHashCode();
                
                if (this.TermCount != null)
                    hash = hash * 57 + this.TermCount.GetHashCode();
                
                if (this.TermType != null)
                    hash = hash * 57 + this.TermType.GetHashCode();
                
                if (this.Terms != null)
                    hash = hash * 57 + this.Terms.GetHashCode();
                
                return hash;
            }
        }

    }


}