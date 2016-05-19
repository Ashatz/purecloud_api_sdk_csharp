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
    /// JsonNodeSearchResponse
    /// </summary>
    [DataContract]
    public partial class JsonNodeSearchResponse :  IEquatable<JsonNodeSearchResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonNodeSearchResponse" /> class.
        /// </summary>
        /// <param name="Total">Total.</param>
        /// <param name="PageCount">PageCount.</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="PreviousPage">PreviousPage.</param>
        /// <param name="CurrentPage">CurrentPage.</param>
        /// <param name="NextPage">NextPage.</param>
        /// <param name="Types">Types.</param>
        /// <param name="Results">Results.</param>
        public JsonNodeSearchResponse(long? Total = null, int? PageCount = null, int? PageSize = null, int? PageNumber = null, string PreviousPage = null, string CurrentPage = null, string NextPage = null, List<string> Types = null, JsonNode Results = null)
        {
            this.Total = Total;
            this.PageCount = PageCount;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.PreviousPage = PreviousPage;
            this.CurrentPage = CurrentPage;
            this.NextPage = NextPage;
            this.Types = Types;
            this.Results = Results;
        }
        
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }
        /// <summary>
        /// Gets or Sets PageCount
        /// </summary>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }
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
        /// Gets or Sets PreviousPage
        /// </summary>
        [DataMember(Name="previousPage", EmitDefaultValue=false)]
        public string PreviousPage { get; set; }
        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        [DataMember(Name="currentPage", EmitDefaultValue=false)]
        public string CurrentPage { get; set; }
        /// <summary>
        /// Gets or Sets NextPage
        /// </summary>
        [DataMember(Name="nextPage", EmitDefaultValue=false)]
        public string NextPage { get; set; }
        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<string> Types { get; set; }
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public JsonNode Results { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonNodeSearchResponse {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return this.Equals(obj as JsonNodeSearchResponse);
        }

        /// <summary>
        /// Returns true if JsonNodeSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonNodeSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonNodeSearchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.PreviousPage == other.PreviousPage ||
                    this.PreviousPage != null &&
                    this.PreviousPage.Equals(other.PreviousPage)
                ) && 
                (
                    this.CurrentPage == other.CurrentPage ||
                    this.CurrentPage != null &&
                    this.CurrentPage.Equals(other.CurrentPage)
                ) && 
                (
                    this.NextPage == other.NextPage ||
                    this.NextPage != null &&
                    this.NextPage.Equals(other.NextPage)
                ) && 
                (
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
                ) && 
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.Equals(other.Results)
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
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.PreviousPage != null)
                    hash = hash * 59 + this.PreviousPage.GetHashCode();
                if (this.CurrentPage != null)
                    hash = hash * 59 + this.CurrentPage.GetHashCode();
                if (this.NextPage != null)
                    hash = hash * 59 + this.NextPage.GetHashCode();
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                return hash;
            }
        }
    }

}
