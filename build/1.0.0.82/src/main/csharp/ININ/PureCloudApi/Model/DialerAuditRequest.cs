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
    public class DialerAuditRequest :  IEquatable<DialerAuditRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerAuditRequest" /> class.
        /// </summary>
        public DialerAuditRequest()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets QueryPhrase
        /// </summary>
        [DataMember(Name="queryPhrase", EmitDefaultValue=false)]
        public string QueryPhrase { get; set; }
  
        
        /// <summary>
        /// Gets or Sets QueryFields
        /// </summary>
        [DataMember(Name="queryFields", EmitDefaultValue=false)]
        public List<string> QueryFields { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Facets
        /// </summary>
        [DataMember(Name="facets", EmitDefaultValue=false)]
        public List<Facet> Facets { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<Filter> Filters { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerAuditRequest {\n");
            sb.Append("  QueryPhrase: ").Append(QueryPhrase).Append("\n");
            sb.Append("  QueryFields: ").Append(QueryFields).Append("\n");
            sb.Append("  Facets: ").Append(Facets).Append("\n");
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
            return this.Equals(obj as DialerAuditRequest);
        }

        /// <summary>
        /// Returns true if DialerAuditRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of DialerAuditRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerAuditRequest other)
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
                    this.QueryFields == other.QueryFields ||
                    this.QueryFields != null &&
                    this.QueryFields.SequenceEqual(other.QueryFields)
                ) && 
                (
                    this.Facets == other.Facets ||
                    this.Facets != null &&
                    this.Facets.SequenceEqual(other.Facets)
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
                
                if (this.QueryFields != null)
                    hash = hash * 57 + this.QueryFields.GetHashCode();
                
                if (this.Facets != null)
                    hash = hash * 57 + this.Facets.GetHashCode();
                
                if (this.Filters != null)
                    hash = hash * 57 + this.Filters.GetHashCode();
                
                return hash;
            }
        }

    }


}
