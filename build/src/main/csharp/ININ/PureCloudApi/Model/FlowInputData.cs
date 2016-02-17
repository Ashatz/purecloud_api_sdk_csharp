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
    /// launch parameters or initializations for variables in the flow.
    /// </summary>
    [DataContract]
    public partial class FlowInputData :  IEquatable<FlowInputData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowInputData" /> class.
        /// </summary>
        public FlowInputData()
        {
            
        }

        
        /// <summary>
        /// A list of document IDs to link with the new flow instance.
        /// </summary>
        /// <value>A list of document IDs to link with the new flow instance.</value>
        [DataMember(Name="linkedDocumentIds", EmitDefaultValue=false)]
        public List<string> LinkedDocumentIds { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowInputData {\n");
            sb.Append("  LinkedDocumentIds: ").Append(LinkedDocumentIds).Append("\n");
            
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
            return this.Equals(obj as FlowInputData);
        }

        /// <summary>
        /// Returns true if FlowInputData instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowInputData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowInputData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LinkedDocumentIds == other.LinkedDocumentIds ||
                    this.LinkedDocumentIds != null &&
                    this.LinkedDocumentIds.SequenceEqual(other.LinkedDocumentIds)
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
                
                if (this.LinkedDocumentIds != null)
                    hash = hash * 59 + this.LinkedDocumentIds.GetHashCode();
                
                return hash;
            }
        }

    }
}
