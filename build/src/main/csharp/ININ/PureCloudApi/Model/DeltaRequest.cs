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
    public partial class DeltaRequest :  IEquatable<DeltaRequest>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DeltaRequest" />class.
        /// </summary>
        /// <param name="ContextToken">ContextToken.</param>

        public DeltaRequest(string ContextToken = null)
        {
            this.ContextToken = ContextToken;
            
        }

    
        /// <summary>
        /// Gets or Sets ContextToken
        /// </summary>
        [DataMember(Name="contextToken", EmitDefaultValue=false)]
        public string ContextToken { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeltaRequest {\n");
            sb.Append("  ContextToken: ").Append(ContextToken).Append("\n");
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
            return this.Equals(obj as DeltaRequest);
        }

        /// <summary>
        /// Returns true if DeltaRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DeltaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeltaRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContextToken == other.ContextToken ||
                    this.ContextToken != null &&
                    this.ContextToken.Equals(other.ContextToken)
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
                return hash;
            }
        }

    }
}
