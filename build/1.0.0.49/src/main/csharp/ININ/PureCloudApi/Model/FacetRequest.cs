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
    /// Used as part of a searchRequest or reportRequest to denote which facets to generate from the search results.  For RANGE facets, one of rangeFrom or rangeTo (or both) MUST be set
    /// </summary>
    [DataContract]
    public class FacetRequest :  IEquatable<FacetRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacetRequest" /> class.
        /// </summary>
        public FacetRequest()
        {
            
        }

        
        /// <summary>
        /// name of the facet request that will be returned with the result set
        /// </summary>
        /// <value>name of the facet request that will be returned with the result set</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Which facet request type
        /// </summary>
        /// <value>Which facet request type</value>
        [DataMember(Name="facetRequestQueryType", EmitDefaultValue=false)]
        public string FacetRequestQueryType { get; set; }
  
        
        /// <summary>
        /// The fieldName to perform the facet request on.
        /// </summary>
        /// <value>The fieldName to perform the facet request on.</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }
  
        
        /// <summary>
        /// the fieldtype of the field to perform the facet request on.
        /// </summary>
        /// <value>the fieldtype of the field to perform the facet request on.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// For RANGE requests populate this field to specify the beginning of a limit (leave blank for openended).  Note this value is inclusive of the results.  (EG if the value is 1, 1 will be included in the range.)
        /// </summary>
        /// <value>For RANGE requests populate this field to specify the beginning of a limit (leave blank for openended).  Note this value is inclusive of the results.  (EG if the value is 1, 1 will be included in the range.)</value>
        [DataMember(Name="rangeFrom", EmitDefaultValue=false)]
        public string RangeFrom { get; set; }
  
        
        /// <summary>
        /// For RANGE requests populate this field to specify the end of a limit (leave blank for openended).  Note this value is EXCLUSIVE of the result (EG if this value was 5, only values LESS THAN 5 will be included in the count.)
        /// </summary>
        /// <value>For RANGE requests populate this field to specify the end of a limit (leave blank for openended).  Note this value is EXCLUSIVE of the result (EG if this value was 5, only values LESS THAN 5 will be included in the count.)</value>
        [DataMember(Name="rangeTo", EmitDefaultValue=false)]
        public string RangeTo { get; set; }
  
        
        /// <summary>
        /// Limits/expands the number of facet entries returned (default 500)
        /// </summary>
        /// <value>Limits/expands the number of facet entries returned (default 500)</value>
        [DataMember(Name="maxFacetCount", EmitDefaultValue=false)]
        public int? MaxFacetCount { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacetRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FacetRequestQueryType: ").Append(FacetRequestQueryType).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RangeFrom: ").Append(RangeFrom).Append("\n");
            sb.Append("  RangeTo: ").Append(RangeTo).Append("\n");
            sb.Append("  MaxFacetCount: ").Append(MaxFacetCount).Append("\n");
            
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
            return this.Equals(obj as FacetRequest);
        }

        /// <summary>
        /// Returns true if FacetRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of FacetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacetRequest other)
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
                    this.FacetRequestQueryType == other.FacetRequestQueryType ||
                    this.FacetRequestQueryType != null &&
                    this.FacetRequestQueryType.Equals(other.FacetRequestQueryType)
                ) && 
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.RangeFrom == other.RangeFrom ||
                    this.RangeFrom != null &&
                    this.RangeFrom.Equals(other.RangeFrom)
                ) && 
                (
                    this.RangeTo == other.RangeTo ||
                    this.RangeTo != null &&
                    this.RangeTo.Equals(other.RangeTo)
                ) && 
                (
                    this.MaxFacetCount == other.MaxFacetCount ||
                    this.MaxFacetCount != null &&
                    this.MaxFacetCount.Equals(other.MaxFacetCount)
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
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.FacetRequestQueryType != null)
                    hash = hash * 57 + this.FacetRequestQueryType.GetHashCode();
                
                if (this.FieldName != null)
                    hash = hash * 57 + this.FieldName.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.RangeFrom != null)
                    hash = hash * 57 + this.RangeFrom.GetHashCode();
                
                if (this.RangeTo != null)
                    hash = hash * 57 + this.RangeTo.GetHashCode();
                
                if (this.MaxFacetCount != null)
                    hash = hash * 57 + this.MaxFacetCount.GetHashCode();
                
                return hash;
            }
        }

    }


}
