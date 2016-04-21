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
    /// Contains the found elements of a search along with the facet result.  All facet results are always returned along with the searchResults regardless of page size/number.
    /// </summary>
    [DataContract]
    public partial class FlowDetailsSearchResult :  IEquatable<FlowDetailsSearchResult>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowDetailsSearchResult" />class.
        /// </summary>
        /// <param name="SearchResults">The actual results from the search.</param>
        /// <param name="FacetResults">The results from the facet requests for this search - note ALL facets will always be returned regardless of page size/starting pagenumber in the searchRequest.</param>

        public FlowDetailsSearchResult(LinkedEntityListingFlowDetails SearchResults = null, List<FacetResult> FacetResults = null)
        {
            this.SearchResults = SearchResults;
            this.FacetResults = FacetResults;
            
        }

    
        /// <summary>
        /// The actual results from the search
        /// </summary>
        /// <value>The actual results from the search</value>
        [DataMember(Name="searchResults", EmitDefaultValue=false)]
        public LinkedEntityListingFlowDetails SearchResults { get; set; }
    
        /// <summary>
        /// The results from the facet requests for this search - note ALL facets will always be returned regardless of page size/starting pagenumber in the searchRequest
        /// </summary>
        /// <value>The results from the facet requests for this search - note ALL facets will always be returned regardless of page size/starting pagenumber in the searchRequest</value>
        [DataMember(Name="facetResults", EmitDefaultValue=false)]
        public List<FacetResult> FacetResults { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowDetailsSearchResult {\n");
            sb.Append("  SearchResults: ").Append(SearchResults).Append("\n");
            sb.Append("  FacetResults: ").Append(FacetResults).Append("\n");
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
            return this.Equals(obj as FlowDetailsSearchResult);
        }

        /// <summary>
        /// Returns true if FlowDetailsSearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowDetailsSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowDetailsSearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SearchResults == other.SearchResults ||
                    this.SearchResults != null &&
                    this.SearchResults.Equals(other.SearchResults)
                ) &&
                (
                    this.FacetResults == other.FacetResults ||
                    this.FacetResults != null &&
                    this.FacetResults.SequenceEqual(other.FacetResults)
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
                if (this.SearchResults != null)
                    hash = hash * 59 + this.SearchResults.GetHashCode();
                if (this.FacetResults != null)
                    hash = hash * 59 + this.FacetResults.GetHashCode();
                return hash;
            }
        }

    }
}
