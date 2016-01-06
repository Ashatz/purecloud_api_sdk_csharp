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
    public class Facets :  IEquatable<Facets>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Facets" /> class.
        /// </summary>
        public Facets()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FacetGroups
        /// </summary>
        [DataMember(Name="facetGroups", EmitDefaultValue=false)]
        public List<FacetGroup> FacetGroups { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Facets {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  FacetGroups: ").Append(FacetGroups).Append("\n");
            
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
            return this.Equals(obj as Facets);
        }

        /// <summary>
        /// Returns true if Facets instances are equal
        /// </summary>
        /// <param name="obj">Instance of Facets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Facets other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.FacetGroups == other.FacetGroups ||
                    this.FacetGroups != null &&
                    this.FacetGroups.SequenceEqual(other.FacetGroups)
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
                
                if (this.Count != null)
                    hash = hash * 57 + this.Count.GetHashCode();
                
                if (this.FacetGroups != null)
                    hash = hash * 57 + this.FacetGroups.GetHashCode();
                
                return hash;
            }
        }

    }


}
