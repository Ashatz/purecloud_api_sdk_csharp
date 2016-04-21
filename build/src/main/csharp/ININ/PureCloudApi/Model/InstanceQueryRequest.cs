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
    public partial class InstanceQueryRequest :  IEquatable<InstanceQueryRequest>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceQueryRequest" />class.
        /// </summary>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="Sort">Sort.</param>
        /// <param name="Members">Members.</param>

        public InstanceQueryRequest(int? PageNumber = null, int? PageSize = null, List<SortItem> Sort = null, List<InstanceMemberFilter> Members = null)
        {
            this.PageNumber = PageNumber;
            this.PageSize = PageSize;
            this.Sort = Sort;
            this.Members = Members;
            
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
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<SortItem> Sort { get; set; }
    
        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<InstanceMemberFilter> Members { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceQueryRequest {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
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
            return this.Equals(obj as InstanceQueryRequest);
        }

        /// <summary>
        /// Returns true if InstanceQueryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of InstanceQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstanceQueryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
                ) &&
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(other.Members)
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
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.Members != null)
                    hash = hash * 59 + this.Members.GetHashCode();
                return hash;
            }
        }

    }
}
