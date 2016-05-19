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
    /// Information about the work item associated with a history item.
    /// </summary>
    [DataContract]
    public partial class WorkItem :  IEquatable<WorkItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItem" /> class.
        /// </summary>
        /// <param name="WorkItemExecId">The work item execution id. (required).</param>
        /// <param name="WorkItemConfigId">The work item definition id. (required).</param>
        /// <param name="WorkItemName">The work item displayable name..</param>
        public WorkItem(string WorkItemExecId = null, string WorkItemConfigId = null, string WorkItemName = null)
        {
            // to ensure "WorkItemExecId" is required (not null)
            if (WorkItemExecId == null)
            {
                throw new InvalidDataException("WorkItemExecId is a required property for WorkItem and cannot be null");
            }
            else
            {
                this.WorkItemExecId = WorkItemExecId;
            }
            // to ensure "WorkItemConfigId" is required (not null)
            if (WorkItemConfigId == null)
            {
                throw new InvalidDataException("WorkItemConfigId is a required property for WorkItem and cannot be null");
            }
            else
            {
                this.WorkItemConfigId = WorkItemConfigId;
            }
            this.WorkItemName = WorkItemName;
        }
        
        /// <summary>
        /// The work item execution id.
        /// </summary>
        /// <value>The work item execution id.</value>
        [DataMember(Name="workItemExecId", EmitDefaultValue=false)]
        public string WorkItemExecId { get; set; }
        /// <summary>
        /// The work item definition id.
        /// </summary>
        /// <value>The work item definition id.</value>
        [DataMember(Name="workItemConfigId", EmitDefaultValue=false)]
        public string WorkItemConfigId { get; set; }
        /// <summary>
        /// The work item displayable name.
        /// </summary>
        /// <value>The work item displayable name.</value>
        [DataMember(Name="workItemName", EmitDefaultValue=false)]
        public string WorkItemName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItem {\n");
            sb.Append("  WorkItemExecId: ").Append(WorkItemExecId).Append("\n");
            sb.Append("  WorkItemConfigId: ").Append(WorkItemConfigId).Append("\n");
            sb.Append("  WorkItemName: ").Append(WorkItemName).Append("\n");
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
            return this.Equals(obj as WorkItem);
        }

        /// <summary>
        /// Returns true if WorkItem instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WorkItemExecId == other.WorkItemExecId ||
                    this.WorkItemExecId != null &&
                    this.WorkItemExecId.Equals(other.WorkItemExecId)
                ) && 
                (
                    this.WorkItemConfigId == other.WorkItemConfigId ||
                    this.WorkItemConfigId != null &&
                    this.WorkItemConfigId.Equals(other.WorkItemConfigId)
                ) && 
                (
                    this.WorkItemName == other.WorkItemName ||
                    this.WorkItemName != null &&
                    this.WorkItemName.Equals(other.WorkItemName)
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
                if (this.WorkItemExecId != null)
                    hash = hash * 59 + this.WorkItemExecId.GetHashCode();
                if (this.WorkItemConfigId != null)
                    hash = hash * 59 + this.WorkItemConfigId.GetHashCode();
                if (this.WorkItemName != null)
                    hash = hash * 59 + this.WorkItemName.GetHashCode();
                return hash;
            }
        }
    }

}
