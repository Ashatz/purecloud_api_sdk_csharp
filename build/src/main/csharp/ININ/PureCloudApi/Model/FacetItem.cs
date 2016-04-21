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
    public partial class FacetItem :  IEquatable<FacetItem>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FacetItem" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="FilterValue">FilterValue.</param>
        /// <param name="Count">Count.</param>

        public FacetItem(string Name = null, string FilterValue = null, int? Count = null)
        {
            this.Name = Name;
            this.FilterValue = FilterValue;
            this.Count = Count;
            
        }

    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets FilterValue
        /// </summary>
        [DataMember(Name="filterValue", EmitDefaultValue=false)]
        public string FilterValue { get; set; }
    
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacetItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FilterValue: ").Append(FilterValue).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as FacetItem);
        }

        /// <summary>
        /// Returns true if FacetItem instances are equal
        /// </summary>
        /// <param name="other">Instance of FacetItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacetItem other)
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
                    this.FilterValue == other.FilterValue ||
                    this.FilterValue != null &&
                    this.FilterValue.Equals(other.FilterValue)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.FilterValue != null)
                    hash = hash * 59 + this.FilterValue.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                return hash;
            }
        }

    }
}
