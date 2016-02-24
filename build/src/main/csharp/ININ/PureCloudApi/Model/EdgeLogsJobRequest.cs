using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class EdgeLogsJobRequest :  IEquatable<EdgeLogsJobRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeLogsJobRequest" /> class.
        /// </summary>
        public EdgeLogsJobRequest()
        {
            this.Recurse = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Recurse
        /// </summary>
        [DataMember(Name="recurse", EmitDefaultValue=false)]
        public bool? Recurse { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeLogsJobRequest {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Recurse: ").Append(Recurse).Append("\n");
            
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
            return this.Equals(obj as EdgeLogsJobRequest);
        }

        /// <summary>
        /// Returns true if EdgeLogsJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeLogsJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeLogsJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this.Recurse == other.Recurse ||
                    this.Recurse != null &&
                    this.Recurse.Equals(other.Recurse)
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
                
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                
                if (this.Recurse != null)
                    hash = hash * 59 + this.Recurse.GetHashCode();
                
                return hash;
            }
        }

    }
}
