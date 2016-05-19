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
    /// Used to perform a search on various data stored in search engines
    /// </summary>
    [DataContract]
    public partial class FlowSearchRequest :  IEquatable<FlowSearchRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowSearchRequest" /> class.
        /// </summary>
        /// <param name="SearchPhrase">The search text to look for.</param>
        /// <param name="PageNumber">The pageNumber to get results from (EG If there are 100 results with a pageSize of 10 and pageNumber is 3 then 10 results will be returned starting with index #31.</param>
        /// <param name="PageSize">Number of entries to return/calculate per page..</param>
        /// <param name="SearchFields">The fields to limit the searchPhrase search to.</param>
        /// <param name="FacetRequests">List of facet requests to generate summary views from the search result set (if any).</param>
        /// <param name="Sort">sort the results on a field(s).</param>
        /// <param name="Filters">You can also restrict the search to particular field values and ranges.</param>
        public FlowSearchRequest(string SearchPhrase = null, int? PageNumber = null, int? PageSize = null, List<string> SearchFields = null, List<FacetRequest> FacetRequests = null, List<SortField> Sort = null, List<FilterItem> Filters = null)
        {
            this.SearchPhrase = SearchPhrase;
            this.PageNumber = PageNumber;
            this.PageSize = PageSize;
            this.SearchFields = SearchFields;
            this.FacetRequests = FacetRequests;
            this.Sort = Sort;
            this.Filters = Filters;
        }
        
        /// <summary>
        /// The search text to look for
        /// </summary>
        /// <value>The search text to look for</value>
        [DataMember(Name="searchPhrase", EmitDefaultValue=false)]
        public string SearchPhrase { get; set; }
        /// <summary>
        /// The pageNumber to get results from (EG If there are 100 results with a pageSize of 10 and pageNumber is 3 then 10 results will be returned starting with index #31
        /// </summary>
        /// <value>The pageNumber to get results from (EG If there are 100 results with a pageSize of 10 and pageNumber is 3 then 10 results will be returned starting with index #31</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
        /// <summary>
        /// Number of entries to return/calculate per page.
        /// </summary>
        /// <value>Number of entries to return/calculate per page.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        /// <summary>
        /// The fields to limit the searchPhrase search to
        /// </summary>
        /// <value>The fields to limit the searchPhrase search to</value>
        [DataMember(Name="searchFields", EmitDefaultValue=false)]
        public List<string> SearchFields { get; set; }
        /// <summary>
        /// List of facet requests to generate summary views from the search result set (if any)
        /// </summary>
        /// <value>List of facet requests to generate summary views from the search result set (if any)</value>
        [DataMember(Name="facetRequests", EmitDefaultValue=false)]
        public List<FacetRequest> FacetRequests { get; set; }
        /// <summary>
        /// sort the results on a field(s)
        /// </summary>
        /// <value>sort the results on a field(s)</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<SortField> Sort { get; set; }
        /// <summary>
        /// You can also restrict the search to particular field values and ranges
        /// </summary>
        /// <value>You can also restrict the search to particular field values and ranges</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<FilterItem> Filters { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowSearchRequest {\n");
            sb.Append("  SearchPhrase: ").Append(SearchPhrase).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  SearchFields: ").Append(SearchFields).Append("\n");
            sb.Append("  FacetRequests: ").Append(FacetRequests).Append("\n");
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
            return this.Equals(obj as FlowSearchRequest);
        }

        /// <summary>
        /// Returns true if FlowSearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowSearchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SearchPhrase == other.SearchPhrase ||
                    this.SearchPhrase != null &&
                    this.SearchPhrase.Equals(other.SearchPhrase)
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
                return hash;
            }
        }
    }

}
