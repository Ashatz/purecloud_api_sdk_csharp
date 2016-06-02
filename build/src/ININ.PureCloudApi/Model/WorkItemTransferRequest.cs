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
    /// Used as the body to the transferWorkItem request.
    /// </summary>
    [DataContract]
    public partial class WorkItemTransferRequest :  IEquatable<WorkItemTransferRequest>
    {
        /// <summary>
        /// The type of the transferTarget, indicating whether you want to transfer to a User, or a Queue, etc.
        /// </summary>
        /// <value>The type of the transferTarget, indicating whether you want to transfer to a User, or a Queue, etc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransferTargetTypeEnum
        {
            
            /// <summary>
            /// Enum User for "USER"
            /// </summary>
            [EnumMember(Value = "USER")]
            User,
            
            /// <summary>
            /// Enum Queue for "QUEUE"
            /// </summary>
            [EnumMember(Value = "QUEUE")]
            Queue
        }

        /// <summary>
        /// The type of the transferTarget, indicating whether you want to transfer to a User, or a Queue, etc.
        /// </summary>
        /// <value>The type of the transferTarget, indicating whether you want to transfer to a User, or a Queue, etc.</value>
        [DataMember(Name="transferTargetType", EmitDefaultValue=false)]
        public TransferTargetTypeEnum? TransferTargetType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemTransferRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemTransferRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemTransferRequest" /> class.
        /// </summary>
        /// <param name="TransferTargetType">The type of the transferTarget, indicating whether you want to transfer to a User, or a Queue, etc. (required).</param>
        /// <param name="TransferTarget">The destination to where the work item should be transferred. (required).</param>
        public WorkItemTransferRequest(TransferTargetTypeEnum? TransferTargetType = null, string TransferTarget = null)
        {
            // to ensure "TransferTargetType" is required (not null)
            if (TransferTargetType == null)
            {
                throw new InvalidDataException("TransferTargetType is a required property for WorkItemTransferRequest and cannot be null");
            }
            else
            {
                this.TransferTargetType = TransferTargetType;
            }
            // to ensure "TransferTarget" is required (not null)
            if (TransferTarget == null)
            {
                throw new InvalidDataException("TransferTarget is a required property for WorkItemTransferRequest and cannot be null");
            }
            else
            {
                this.TransferTarget = TransferTarget;
            }
        }
        
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
        /// <param name="other">Instance of WorkItemTransferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemTransferRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    hash = hash * 59 + this.TransferTargetType.GetHashCode();
                if (this.TransferTarget != null)
                    hash = hash * 59 + this.TransferTarget.GetHashCode();
                return hash;
            }
        }
    }

}
