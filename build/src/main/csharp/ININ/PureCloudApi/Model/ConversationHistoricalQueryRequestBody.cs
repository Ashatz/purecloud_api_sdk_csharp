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
    /// Historical conversation request parameters
    /// </summary>
    [DataContract]
    public partial class ConversationHistoricalQueryRequestBody :  IEquatable<ConversationHistoricalQueryRequestBody>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoricalQueryRequestBody" />class.
        /// </summary>
        /// <param name="PageSize">Maximum number of conversations returned. Overrides &#39;maximum&#39; if both specified. Default 100.</param>
        /// <param name="Maximum">Maximum number of conversations returned.</param>
        /// <param name="Filters">Query filters. Default is all conversations for the previous 7 days.</param>
        /// <param name="Facets">Facets to return. Currently, only &#39;queue&#39; is supported.</param>

        public ConversationHistoricalQueryRequestBody(int? PageSize = null, int? Maximum = null, List<ConversationHistoricalQueryRequestFilter> Filters = null, List<string> Facets = null)
        {
            this.PageSize = PageSize;
            this.Maximum = Maximum;
            this.Filters = Filters;
            this.Facets = Facets;
            
        }
        
    
        /// <summary>
        /// Maximum number of conversations returned. Overrides 'maximum' if both specified. Default 100
        /// </summary>
        /// <value>Maximum number of conversations returned. Overrides 'maximum' if both specified. Default 100</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
    
        /// <summary>
        /// Maximum number of conversations returned
        /// </summary>
        /// <value>Maximum number of conversations returned</value>
        [DataMember(Name="maximum", EmitDefaultValue=false)]
        public int? Maximum { get; set; }
    
        /// <summary>
        /// Query filters. Default is all conversations for the previous 7 days
        /// </summary>
        /// <value>Query filters. Default is all conversations for the previous 7 days</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<ConversationHistoricalQueryRequestFilter> Filters { get; set; }
    
        /// <summary>
        /// Facets to return. Currently, only 'queue' is supported
        /// </summary>
        /// <value>Facets to return. Currently, only 'queue' is supported</value>
        [DataMember(Name="facets", EmitDefaultValue=false)]
        public List<string> Facets { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationHistoricalQueryRequestBody {\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Facets: ").Append(Facets).Append("\n");
            
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
            return this.Equals(obj as ConversationHistoricalQueryRequestBody);
        }

        /// <summary>
        /// Returns true if ConversationHistoricalQueryRequestBody instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationHistoricalQueryRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationHistoricalQueryRequestBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.Maximum == other.Maximum ||
                    this.Maximum != null &&
                    this.Maximum.Equals(other.Maximum)
                ) &&
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
                ) &&
                (
                    this.Facets == other.Facets ||
                    this.Facets != null &&
                    this.Facets.SequenceEqual(other.Facets)
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
                
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                
                if (this.Maximum != null)
                    hash = hash * 59 + this.Maximum.GetHashCode();
                
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                
                if (this.Facets != null)
                    hash = hash * 59 + this.Facets.GetHashCode();
                
                return hash;
            }
        }

    }
}
