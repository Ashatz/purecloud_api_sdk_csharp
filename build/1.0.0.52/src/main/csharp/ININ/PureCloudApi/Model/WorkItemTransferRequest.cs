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
    /// Used as the body to the transferWorkItem request.
    /// </summary>
    [DataContract]
    public class WorkItemTransferRequest :  IEquatable<WorkItemTransferRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemTransferRequest" /> class.
        /// </summary>
        public WorkItemTransferRequest()
        {
            
        }

        
        /// <summary>
        /// The type of the transferTarget, indicating whether you want to transfer to a User, or a Queue, etc.
        /// </summary>
        /// <value>The type of the transferTarget, indicating whether you want to transfer to a User, or a Queue, etc.</value>
        [DataMember(Name="transferTargetType", EmitDefaultValue=false)]
        public string TransferTargetType { get; set; }
  
        
        /// <summary>
        /// The destination to where the work item should be transferred.
        /// </summary>
        /// <value>The destination to where the work item should be transferred.</value>
        [DataMember(Name="transferTarget", EmitDefaultValue=false)]
        public string TransferTarget { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemTransferRequest {\n");
            sb.Append("  TransferTargetType: ").Append(TransferTargetType).Append("\n");
            sb.Append("  TransferTarget: ").Append(TransferTarget).Append("\n");
            
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
            return this.Equals(obj as WorkItemTransferRequest);
        }

        /// <summary>
        /// Returns true if WorkItemTransferRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of WorkItemTransferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemTransferRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransferTargetType == other.TransferTargetType ||
                    this.TransferTargetType != null &&
                    this.TransferTargetType.Equals(other.TransferTargetType)
                ) && 
                (
                    this.TransferTarget == other.TransferTarget ||
                    this.TransferTarget != null &&
                    this.TransferTarget.Equals(other.TransferTarget)
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
                
                if (this.TransferTargetType != null)
                    hash = hash * 57 + this.TransferTargetType.GetHashCode();
                
                if (this.TransferTarget != null)
                    hash = hash * 57 + this.TransferTarget.GetHashCode();
                
                return hash;
            }
        }

    }


}
