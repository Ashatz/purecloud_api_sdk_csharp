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
    public partial class DeltaResponse :  IEquatable<DeltaResponse>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DeltaResponse" />class.
        /// </summary>
        /// <param name="ContextToken">ContextToken.</param>
        /// <param name="Documents">Documents.</param>
        /// <param name="HasMore">HasMore (default to false).</param>

        public DeltaResponse(string ContextToken = null, List<DeltaDocument> Documents = null, bool? HasMore = null)
        {
            this.ContextToken = ContextToken;
            this.Documents = Documents;
            // use default value if no "HasMore" provided
            if (HasMore == null)
            {
                this.HasMore = false;
            }
            else
            {
                this.HasMore = HasMore;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets ContextToken
        /// </summary>
        [DataMember(Name="contextToken", EmitDefaultValue=false)]
        public string ContextToken { get; set; }
    
        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<DeltaDocument> Documents { get; set; }
    
        /// <summary>
        /// Gets or Sets HasMore
        /// </summary>
        [DataMember(Name="hasMore", EmitDefaultValue=false)]
        public bool? HasMore { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeltaResponse {\n");
            sb.Append("  ContextToken: ").Append(ContextToken).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            
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
            return this.Equals(obj as DeltaResponse);
        }

        /// <summary>
        /// Returns true if DeltaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DeltaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeltaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContextToken == other.ContextToken ||
                    this.ContextToken != null &&
                    this.ContextToken.Equals(other.ContextToken)
                ) &&
                (
                    this.Documents == other.Documents ||
                    this.Documents != null &&
                    this.Documents.SequenceEqual(other.Documents)
                ) &&
                (
                    this.HasMore == other.HasMore ||
                    this.HasMore != null &&
                    this.HasMore.Equals(other.HasMore)
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
                
                if (this.ContextToken != null)
                    hash = hash * 59 + this.ContextToken.GetHashCode();
                
                if (this.Documents != null)
                    hash = hash * 59 + this.Documents.GetHashCode();
                
                if (this.HasMore != null)
                    hash = hash * 59 + this.HasMore.GetHashCode();
                
                return hash;
            }
        }

    }
}
