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
    /// WorkItem entry found in result to a search.
    /// </summary>
    [DataContract]
    public class WorkItemSearchDetails :  IEquatable<WorkItemSearchDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemSearchDetails" /> class.
        /// </summary>
        public WorkItemSearchDetails()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets WorkItem
        /// </summary>
        [DataMember(Name="workItem", EmitDefaultValue=false)]
        public WorkItemDetails WorkItem { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemSearchDetails {\n");
            sb.Append("  WorkItem: ").Append(WorkItem).Append("\n");
            
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
            return this.Equals(obj as WorkItemSearchDetails);
        }

        /// <summary>
        /// Returns true if WorkItemSearchDetails instances are equal
        /// </summary>
        /// <param name="obj">Instance of WorkItemSearchDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemSearchDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WorkItem == other.WorkItem ||
                    this.WorkItem != null &&
                    this.WorkItem.Equals(other.WorkItem)
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
                
                if (this.WorkItem != null)
                    hash = hash * 57 + this.WorkItem.GetHashCode();
                
                return hash;
            }
        }

    }


}
