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
    /// Used as part of the searchResult to return facet results to the caller
    /// </summary>
    [DataContract]
    public class FacetResult :  IEquatable<FacetResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacetResult" /> class.
        /// </summary>
        public FacetResult()
        {
            
        }

        
        /// <summary>
        /// This was the name passed in as part of the facetRequest
        /// </summary>
        /// <value>This was the name passed in as part of the facetRequest</value>
        [DataMember(Name="requestName", EmitDefaultValue=false)]
        public string RequestName { get; set; }
  
        
        /// <summary>
        /// The field name that the facet was requested for.
        /// </summary>
        /// <value>The field name that the facet was requested for.</value>
        [DataMember(Name="requestFieldName", EmitDefaultValue=false)]
        public string RequestFieldName { get; set; }
  
        
        /// <summary>
        /// data type of the field being returned (if this is a mixed field this will be unknown)
        /// </summary>
        /// <value>data type of the field being returned (if this is a mixed field this will be unknown)</value>
        [DataMember(Name="fieldType", EmitDefaultValue=false)]
        public string FieldType { get; set; }
  
        
        /// <summary>
        /// the facet request type that was made.
        /// </summary>
        /// <value>the facet request type that was made.</value>
        [DataMember(Name="requestType", EmitDefaultValue=false)]
        public string RequestType { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<FacetResultItem> Results { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacetResult {\n");
            sb.Append("  RequestName: ").Append(RequestName).Append("\n");
            sb.Append("  RequestFieldName: ").Append(RequestFieldName).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            
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
            return this.Equals(obj as FacetResult);
        }

        /// <summary>
        /// Returns true if FacetResult instances are equal
        /// </summary>
        /// <param name="obj">Instance of FacetResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacetResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RequestName == other.RequestName ||
                    this.RequestName != null &&
                    this.RequestName.Equals(other.RequestName)
                ) && 
                (
                    this.RequestFieldName == other.RequestFieldName ||
                    this.RequestFieldName != null &&
                    this.RequestFieldName.Equals(other.RequestFieldName)
                ) && 
                (
                    this.FieldType == other.FieldType ||
                    this.FieldType != null &&
                    this.FieldType.Equals(other.FieldType)
                ) && 
                (
                    this.RequestType == other.RequestType ||
                    this.RequestType != null &&
                    this.RequestType.Equals(other.RequestType)
                ) && 
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                
                if (this.RequestName != null)
                    hash = hash * 57 + this.RequestName.GetHashCode();
                
                if (this.RequestFieldName != null)
                    hash = hash * 57 + this.RequestFieldName.GetHashCode();
                
                if (this.FieldType != null)
                    hash = hash * 57 + this.FieldType.GetHashCode();
                
                if (this.RequestType != null)
                    hash = hash * 57 + this.RequestType.GetHashCode();
                
                if (this.Results != null)
                    hash = hash * 57 + this.Results.GetHashCode();
                
                return hash;
            }
        }

    }


}