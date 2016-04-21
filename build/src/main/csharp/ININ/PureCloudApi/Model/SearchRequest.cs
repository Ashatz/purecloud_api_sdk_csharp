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
    public partial class SearchRequest :  IEquatable<SearchRequest>
    { 
<<<<<<< HEAD
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" />class.
        /// </summary>
        /// <param name="SearchPhrase">The search text to look for.</param>
        /// <param name="PageNumber">The pageNumber to get results from (EG If there are 100 results with a pageSize of 10 and pageNumber is 3 then 10 results will be returned starting with index #31.</param>
        /// <param name="PageSize">Number of entries to return/calculate per page..</param>
        /// <param name="SearchFields">The fields to limit the searchPhrase search to.</param>
        /// <param name="FacetRequests">List of facet requests to generate summary views from the search result set (if any).</param>
        /// <param name="Sort">sort the results on a field(s).</param>
        /// <param name="Filters">You can also restrict the search to particular field values and ranges.</param>

        public SearchRequest(string SearchPhrase = null, int? PageNumber = null, int? PageSize = null, List<string> SearchFields = null, List<FacetRequest> FacetRequests = null, List<SortField> Sort = null, List<FilterItem> Filters = null)
        {
            this.SearchPhrase = SearchPhrase;
            this.PageNumber = PageNumber;
            this.PageSize = PageSize;
            this.SearchFields = SearchFields;
            this.FacetRequests = FacetRequests;
            this.Sort = Sort;
            this.Filters = Filters;
=======

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SortOrderEnum {
            
            [EnumMember(Value = "ASC")]
            Asc,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            [EnumMember(Value = "DESC")]
            Desc,
            
            [EnumMember(Value = "SCORE")]
            Score
        }

    
        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
<<<<<<< HEAD
        /// <value>The search text to look for</value>
        [DataMember(Name="searchPhrase", EmitDefaultValue=false)]
        public string SearchPhrase { get; set; }
=======
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public SortOrderEnum? SortOrder { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" />class.
        /// </summary>
<<<<<<< HEAD
        /// <value>The pageNumber to get results from (EG If there are 100 results with a pageSize of 10 and pageNumber is 3 then 10 results will be returned starting with index #31</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
=======
        /// <param name="Types">Types.</param>
        /// <param name="SortOrder">SortOrder.</param>
        /// <param name="Query">Query.</param>
        /// <param name="SortBy">SortBy.</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="ReturnFields">ReturnFields.</param>
        /// <param name="Aggregations">Aggregations.</param>
        /// <param name="Expand">Expand.</param>

        public SearchRequest(List<string> Types = null, SortOrderEnum? SortOrder = null, List<SearchCriteria> Query = null, string SortBy = null, int? PageSize = null, int? PageNumber = null, List<string> ReturnFields = null, List<SearchAggregation> Aggregations = null, List<string> Expand = null)
        {
            this.Types = Types;
            this.SortOrder = SortOrder;
            this.Query = Query;
            this.SortBy = SortBy;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.ReturnFields = ReturnFields;
            this.Aggregations = Aggregations;
            this.Expand = Expand;
            
        }

    
        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<string> Types { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public List<SearchCriteria> Query { get; set; }
    
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
<<<<<<< HEAD
        /// <value>The fields to limit the searchPhrase search to</value>
        [DataMember(Name="searchFields", EmitDefaultValue=false)]
        public List<string> SearchFields { get; set; }
=======
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets ReturnFields
        /// </summary>
<<<<<<< HEAD
        /// <value>List of facet requests to generate summary views from the search result set (if any)</value>
        [DataMember(Name="facetRequests", EmitDefaultValue=false)]
        public List<FacetRequest> FacetRequests { get; set; }
=======
        [DataMember(Name="returnFields", EmitDefaultValue=false)]
        public List<string> ReturnFields { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets Aggregations
        /// </summary>
<<<<<<< HEAD
        /// <value>sort the results on a field(s)</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<SortField> Sort { get; set; }
=======
        [DataMember(Name="aggregations", EmitDefaultValue=false)]
        public List<SearchAggregation> Aggregations { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets Expand
        /// </summary>
<<<<<<< HEAD
        /// <value>You can also restrict the search to particular field values and ranges</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<FilterItem> Filters { get; set; }
=======
        [DataMember(Name="expand", EmitDefaultValue=false)]
        public List<string> Expand { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchRequest {\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
<<<<<<< HEAD
            sb.Append("  SearchFields: ").Append(SearchFields).Append("\n");
            sb.Append("  FacetRequests: ").Append(FacetRequests).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
=======
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  ReturnFields: ").Append(ReturnFields).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
            sb.Append("  Expand: ").Append(Expand).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            return this.Equals(obj as SearchRequest);
        }

        /// <summary>
        /// Returns true if SearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
<<<<<<< HEAD
                    this.SearchPhrase == other.SearchPhrase ||
                    this.SearchPhrase != null &&
                    this.SearchPhrase.Equals(other.SearchPhrase)
                ) &&
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
=======
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
                ) &&
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) &&
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.SequenceEqual(other.Query)
                ) &&
                (
                    this.SortBy == other.SortBy ||
                    this.SortBy != null &&
                    this.SortBy.Equals(other.SortBy)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
<<<<<<< HEAD
                    this.SearchFields == other.SearchFields ||
                    this.SearchFields != null &&
                    this.SearchFields.SequenceEqual(other.SearchFields)
                ) &&
                (
                    this.FacetRequests == other.FacetRequests ||
                    this.FacetRequests != null &&
                    this.FacetRequests.SequenceEqual(other.FacetRequests)
                ) &&
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
=======
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
                    this.Aggregations == other.Aggregations ||
                    this.Aggregations != null &&
                    this.Aggregations.SequenceEqual(other.Aggregations)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                ) &&
                (
                    this.Expand == other.Expand ||
                    this.Expand != null &&
                    this.Expand.SequenceEqual(other.Expand)
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
<<<<<<< HEAD
                if (this.SearchPhrase != null)
                    hash = hash * 59 + this.SearchPhrase.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.SearchFields != null)
                    hash = hash * 59 + this.SearchFields.GetHashCode();
                if (this.FacetRequests != null)
                    hash = hash * 59 + this.FacetRequests.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
=======
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();
                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                if (this.SortBy != null)
                    hash = hash * 59 + this.SortBy.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.ReturnFields != null)
                    hash = hash * 59 + this.ReturnFields.GetHashCode();
                if (this.Aggregations != null)
                    hash = hash * 59 + this.Aggregations.GetHashCode();
                if (this.Expand != null)
                    hash = hash * 59 + this.Expand.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
