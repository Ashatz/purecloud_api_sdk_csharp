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
    /// GroupSearchRequest
    /// </summary>
    [DataContract]
    public partial class GroupSearchRequest :  IEquatable<GroupSearchRequest>
    {
        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortOrderEnum
        {
            
            /// <summary>
            /// Enum Asc for "ASC"
            /// </summary>
            [EnumMember(Value = "ASC")]
            Asc,
            
            /// <summary>
            /// Enum Desc for "DESC"
            /// </summary>
            [EnumMember(Value = "DESC")]
            Desc,
            
            /// <summary>
            /// Enum Score for "SCORE"
            /// </summary>
            [EnumMember(Value = "SCORE")]
            Score
        }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public SortOrderEnum? SortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSearchRequest" /> class.
        /// </summary>
        /// <param name="SortOrder">SortOrder.</param>
        /// <param name="SortBy">SortBy.</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="ReturnFields">ReturnFields.</param>
        /// <param name="Expand">Expand.</param>
        /// <param name="Query">Query.</param>
        public GroupSearchRequest(SortOrderEnum? SortOrder = null, string SortBy = null, int? PageSize = null, int? PageNumber = null, List<string> ReturnFields = null, List<string> Expand = null, List<GroupSearchCriteria> Query = null)
        {
            this.SortOrder = SortOrder;
            this.SortBy = SortBy;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.ReturnFields = ReturnFields;
            this.Expand = Expand;
            this.Query = Query;
        }
        
        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [DataMember(Name="sortBy", EmitDefaultValue=false)]
        public string SortBy { get; set; }
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
        /// Gets or Sets ReturnFields
        /// </summary>
        [DataMember(Name="returnFields", EmitDefaultValue=false)]
        public List<string> ReturnFields { get; set; }
        /// <summary>
        /// Gets or Sets Expand
        /// </summary>
        [DataMember(Name="expand", EmitDefaultValue=false)]
        public List<string> Expand { get; set; }
        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public List<GroupSearchCriteria> Query { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupSearchRequest {\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  ReturnFields: ").Append(ReturnFields).Append("\n");
            sb.Append("  Expand: ").Append(Expand).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(obj as GroupSearchRequest);
        }

        /// <summary>
        /// Returns true if GroupSearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupSearchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) &&
                (
                    this.SortBy == other.SortBy ||
                    this.SortBy != null &&
                    this.SortBy.Equals(other.SortBy)
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
                    this.ReturnFields == other.ReturnFields ||
                    this.ReturnFields != null &&
                    this.ReturnFields.SequenceEqual(other.ReturnFields)
                ) &&
                (
                    this.Expand == other.Expand ||
                    this.Expand != null &&
                    this.Expand.SequenceEqual(other.Expand)
                ) &&
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.SequenceEqual(other.Query)
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
                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                if (this.SortBy != null)
                    hash = hash * 59 + this.SortBy.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.ReturnFields != null)
                    hash = hash * 59 + this.ReturnFields.GetHashCode();
                if (this.Expand != null)
                    hash = hash * 59 + this.Expand.GetHashCode();
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                return hash;
            }
        }
    }

}
