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
    /// SocializeFilterRequest
    /// </summary>
    [DataContract]
    public partial class SocializeFilterRequest :  IEquatable<SocializeFilterRequest>
    {
        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortOrderEnum
        {
            
            /// <summary>
            /// Enum Ascending for "ascending"
            /// </summary>
            [EnumMember(Value = "ascending")]
            Ascending,
            
            /// <summary>
            /// Enum Descending for "descending"
            /// </summary>
            [EnumMember(Value = "descending")]
            Descending
        }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public SortOrderEnum? SortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SocializeFilterRequest" /> class.
        /// </summary>
        /// <param name="Filters">The list of filters used to narrow the return..</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="SortBy">SortBy.</param>
        /// <param name="SortOrder">SortOrder.</param>
        public SocializeFilterRequest(List<SocializeEntityFilter> Filters = null, int? PageSize = null, int? PageNumber = null, string SortBy = null, SortOrderEnum? SortOrder = null)
        {
            this.Filters = Filters;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.SortBy = SortBy;
            this.SortOrder = SortOrder;
        }
        
        /// <summary>
        /// The list of filters used to narrow the return.
        /// </summary>
        /// <value>The list of filters used to narrow the return.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<SocializeEntityFilter> Filters { get; set; }
        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [DataMember(Name="sortBy", EmitDefaultValue=false)]
        public string SortBy { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocializeFilterRequest {\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(obj as SocializeFilterRequest);
        }

        /// <summary>
        /// Returns true if SocializeFilterRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SocializeFilterRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocializeFilterRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) &&
                (
                    this.SortBy == other.SortBy ||
                    this.SortBy != null &&
                    this.SortBy.Equals(other.SortBy)
                ) &&
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
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
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.SortBy != null)
                    hash = hash * 59 + this.SortBy.GetHashCode();
                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                return hash;
            }
        }
    }

}
