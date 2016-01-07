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
    public class ContentQueryRequest :  IEquatable<ContentQueryRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentQueryRequest" /> class.
        /// </summary>
        public ContentQueryRequest()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets QueryPhrase
        /// </summary>
        [DataMember(Name="queryPhrase", EmitDefaultValue=false)]
        public string QueryPhrase { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FacetNameRequests
        /// </summary>
        [DataMember(Name="facetNameRequests", EmitDefaultValue=false)]
        public List<string> FacetNameRequests { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<ContentSortItem> Sort { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<ContentFacetFilterItem> Filters { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentQueryRequest {\n");
            sb.Append("  QueryPhrase: ").Append(QueryPhrase).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  FacetNameRequests: ").Append(FacetNameRequests).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
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
            return this.Equals(obj as ContentQueryRequest);
        }

        /// <summary>
        /// Returns true if ContentQueryRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of ContentQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentQueryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.QueryPhrase == other.QueryPhrase ||
                    this.QueryPhrase != null &&
                    this.QueryPhrase.Equals(other.QueryPhrase)
                ) && 
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) && 
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) && 
                (
                    this.FacetNameRequests == other.FacetNameRequests ||
                    this.FacetNameRequests != null &&
                    this.FacetNameRequests.SequenceEqual(other.FacetNameRequests)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
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
                
                if (this.QueryPhrase != null)
                    hash = hash * 57 + this.QueryPhrase.GetHashCode();
                
                if (this.PageNumber != null)
                    hash = hash * 57 + this.PageNumber.GetHashCode();
                
                if (this.PageSize != null)
                    hash = hash * 57 + this.PageSize.GetHashCode();
                
                if (this.FacetNameRequests != null)
                    hash = hash * 57 + this.FacetNameRequests.GetHashCode();
                
                if (this.Sort != null)
                    hash = hash * 57 + this.Sort.GetHashCode();
                
                if (this.Filters != null)
                    hash = hash * 57 + this.Filters.GetHashCode();
                
                return hash;
            }
        }

    }


}
