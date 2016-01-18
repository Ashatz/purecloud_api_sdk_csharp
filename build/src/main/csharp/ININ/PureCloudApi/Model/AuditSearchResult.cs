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
    public class AuditSearchResult :  IEquatable<AuditSearchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditSearchResult" /> class.
        /// </summary>
        public AuditSearchResult()
        {
            
        }

        
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
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PageCount
        /// </summary>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FacetInfo
        /// </summary>
        [DataMember(Name="facetInfo", EmitDefaultValue=false)]
        public List<FacetInfo> FacetInfo { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AuditMessages
        /// </summary>
        [DataMember(Name="auditMessages", EmitDefaultValue=false)]
        public List<AuditMessage> AuditMessages { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditSearchResult {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  FacetInfo: ").Append(FacetInfo).Append("\n");
            sb.Append("  AuditMessages: ").Append(AuditMessages).Append("\n");
            
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
            return this.Equals(obj as AuditSearchResult);
        }

        /// <summary>
        /// Returns true if AuditSearchResult instances are equal
        /// </summary>
        /// <param name="obj">Instance of AuditSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditSearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
                ) && 
                (
                    this.FacetInfo == other.FacetInfo ||
                    this.FacetInfo != null &&
                    this.FacetInfo.SequenceEqual(other.FacetInfo)
                ) && 
                (
                    this.AuditMessages == other.AuditMessages ||
                    this.AuditMessages != null &&
                    this.AuditMessages.SequenceEqual(other.AuditMessages)
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
                
                if (this.PageNumber != null)
                    hash = hash * 57 + this.PageNumber.GetHashCode();
                
                if (this.PageSize != null)
                    hash = hash * 57 + this.PageSize.GetHashCode();
                
                if (this.Total != null)
                    hash = hash * 57 + this.Total.GetHashCode();
                
                if (this.PageCount != null)
                    hash = hash * 57 + this.PageCount.GetHashCode();
                
                if (this.FacetInfo != null)
                    hash = hash * 57 + this.FacetInfo.GetHashCode();
                
                if (this.AuditMessages != null)
                    hash = hash * 57 + this.AuditMessages.GetHashCode();
                
                return hash;
            }
        }

    }


}
