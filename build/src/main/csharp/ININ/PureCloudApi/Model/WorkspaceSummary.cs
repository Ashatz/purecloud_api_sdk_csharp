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
    public partial class WorkspaceSummary :  IEquatable<WorkspaceSummary>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSummary" />class.
        /// </summary>
        /// <param name="TotalDocumentCount">TotalDocumentCount.</param>

        public WorkspaceSummary(long? TotalDocumentCount = null)
        {
            this.TotalDocumentCount = TotalDocumentCount;
            
        }

    
        /// <summary>
        /// Gets or Sets TotalDocumentCount
        /// </summary>
        [DataMember(Name="totalDocumentCount", EmitDefaultValue=false)]
        public long? TotalDocumentCount { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceSummary {\n");
            sb.Append("  TotalDocumentCount: ").Append(TotalDocumentCount).Append("\n");
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
            return this.Equals(obj as WorkspaceSummary);
        }

        /// <summary>
        /// Returns true if WorkspaceSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkspaceSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TotalDocumentCount == other.TotalDocumentCount ||
                    this.TotalDocumentCount != null &&
                    this.TotalDocumentCount.Equals(other.TotalDocumentCount)
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
                if (this.TotalDocumentCount != null)
                    hash = hash * 59 + this.TotalDocumentCount.GetHashCode();
                return hash;
            }
        }

    }
}
