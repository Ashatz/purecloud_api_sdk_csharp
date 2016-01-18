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
    /// Report for one active (running) process found in result to a report request.
    /// </summary>
    [DataContract]
    public class FlowReportResultItem :  IEquatable<FlowReportResultItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowReportResultItem" /> class.
        /// </summary>
        public FlowReportResultItem()
        {
            
        }

        
        /// <summary>
        /// The flow instance ID for this process
        /// </summary>
        /// <value>The flow instance ID for this process</value>
        [DataMember(Name="flowExecId", EmitDefaultValue=false)]
        public FlowExecId FlowExecId { get; set; }
  
        
        /// <summary>
        /// The flow config ID that this workitem was created from.
        /// </summary>
        /// <value>The flow config ID that this workitem was created from.</value>
        [DataMember(Name="flowConfigId", EmitDefaultValue=false)]
        public FlowConfigId FlowConfigId { get; set; }
  
        
        /// <summary>
        /// The instance name for this flow in relation to its primary document.  If the flow is not a document-centric type, this value will be empty.
        /// </summary>
        /// <value>The instance name for this flow in relation to its primary document.  If the flow is not a document-centric type, this value will be empty.</value>
        [DataMember(Name="flowInstanceName", EmitDefaultValue=false)]
        public string FlowInstanceName { get; set; }
  
        
        /// <summary>
        /// the document for this flow (if this flow was launched via a document)
        /// </summary>
        /// <value>the document for this flow (if this flow was launched via a document)</value>
        [DataMember(Name="associatedDocument", EmitDefaultValue=false)]
        public AssociatedDocument AssociatedDocument { get; set; }
  
        
        /// <summary>
        /// The flow's running status, which indicates whether the flow is running normally or in error, etc;
        /// </summary>
        /// <value>The flow's running status, which indicates whether the flow is running normally or in error, etc;</value>
        [DataMember(Name="flowStatus", EmitDefaultValue=false)]
        public string FlowStatus { get; set; }
  
        
        /// <summary>
        /// The current state of the flow (EG what action is being processed)
        /// </summary>
        /// <value>The current state of the flow (EG what action is being processed)</value>
        [DataMember(Name="currentState", EmitDefaultValue=false)]
        public string CurrentState { get; set; }
  
        
        /// <summary>
        /// The time the flow was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time the flow was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startDateTime", EmitDefaultValue=false)]
        public DateTime? StartDateTime { get; set; }
  
        
        /// <summary>
        /// The time the flow ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time the flow ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endDateTime", EmitDefaultValue=false)]
        public DateTime? EndDateTime { get; set; }
  
        
        /// <summary>
        /// List of users currently assigned to a workItem
        /// </summary>
        /// <value>List of users currently assigned to a workItem</value>
        [DataMember(Name="workItemUserAssignees", EmitDefaultValue=false)]
        public List<User> WorkItemUserAssignees { get; set; }
  
        
        /// <summary>
        /// User that completed the flow
        /// </summary>
        /// <value>User that completed the flow</value>
        [DataMember(Name="completedUser", EmitDefaultValue=false)]
        public User CompletedUser { get; set; }
  
        
        /// <summary>
        /// Reason for completion
        /// </summary>
        /// <value>Reason for completion</value>
        [DataMember(Name="completionReason", EmitDefaultValue=false)]
        public string CompletionReason { get; set; }
  
        
        /// <summary>
        /// Additional information if the flow is in error
        /// </summary>
        /// <value>Additional information if the flow is in error</value>
        [DataMember(Name="flowErrorInfo", EmitDefaultValue=false)]
        public ErrorBody FlowErrorInfo { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowReportResultItem {\n");
            sb.Append("  FlowExecId: ").Append(FlowExecId).Append("\n");
            sb.Append("  FlowConfigId: ").Append(FlowConfigId).Append("\n");
            sb.Append("  FlowInstanceName: ").Append(FlowInstanceName).Append("\n");
            sb.Append("  AssociatedDocument: ").Append(AssociatedDocument).Append("\n");
            sb.Append("  FlowStatus: ").Append(FlowStatus).Append("\n");
            sb.Append("  CurrentState: ").Append(CurrentState).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  WorkItemUserAssignees: ").Append(WorkItemUserAssignees).Append("\n");
            sb.Append("  CompletedUser: ").Append(CompletedUser).Append("\n");
            sb.Append("  CompletionReason: ").Append(CompletionReason).Append("\n");
            sb.Append("  FlowErrorInfo: ").Append(FlowErrorInfo).Append("\n");
            
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
            return this.Equals(obj as FlowReportResultItem);
        }

        /// <summary>
        /// Returns true if FlowReportResultItem instances are equal
        /// </summary>
        /// <param name="obj">Instance of FlowReportResultItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowReportResultItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlowExecId == other.FlowExecId ||
                    this.FlowExecId != null &&
                    this.FlowExecId.Equals(other.FlowExecId)
                ) && 
                (
                    this.FlowConfigId == other.FlowConfigId ||
                    this.FlowConfigId != null &&
                    this.FlowConfigId.Equals(other.FlowConfigId)
                ) && 
                (
                    this.FlowInstanceName == other.FlowInstanceName ||
                    this.FlowInstanceName != null &&
                    this.FlowInstanceName.Equals(other.FlowInstanceName)
                ) && 
                (
                    this.AssociatedDocument == other.AssociatedDocument ||
                    this.AssociatedDocument != null &&
                    this.AssociatedDocument.Equals(other.AssociatedDocument)
                ) && 
                (
                    this.FlowStatus == other.FlowStatus ||
                    this.FlowStatus != null &&
                    this.FlowStatus.Equals(other.FlowStatus)
                ) && 
                (
                    this.CurrentState == other.CurrentState ||
                    this.CurrentState != null &&
                    this.CurrentState.Equals(other.CurrentState)
                ) && 
                (
                    this.StartDateTime == other.StartDateTime ||
                    this.StartDateTime != null &&
                    this.StartDateTime.Equals(other.StartDateTime)
                ) && 
                (
                    this.EndDateTime == other.EndDateTime ||
                    this.EndDateTime != null &&
                    this.EndDateTime.Equals(other.EndDateTime)
                ) && 
                (
                    this.WorkItemUserAssignees == other.WorkItemUserAssignees ||
                    this.WorkItemUserAssignees != null &&
                    this.WorkItemUserAssignees.SequenceEqual(other.WorkItemUserAssignees)
                ) && 
                (
                    this.CompletedUser == other.CompletedUser ||
                    this.CompletedUser != null &&
                    this.CompletedUser.Equals(other.CompletedUser)
                ) && 
                (
                    this.CompletionReason == other.CompletionReason ||
                    this.CompletionReason != null &&
                    this.CompletionReason.Equals(other.CompletionReason)
                ) && 
                (
                    this.FlowErrorInfo == other.FlowErrorInfo ||
                    this.FlowErrorInfo != null &&
                    this.FlowErrorInfo.Equals(other.FlowErrorInfo)
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
                
                if (this.FlowExecId != null)
                    hash = hash * 57 + this.FlowExecId.GetHashCode();
                
                if (this.FlowConfigId != null)
                    hash = hash * 57 + this.FlowConfigId.GetHashCode();
                
                if (this.FlowInstanceName != null)
                    hash = hash * 57 + this.FlowInstanceName.GetHashCode();
                
                if (this.AssociatedDocument != null)
                    hash = hash * 57 + this.AssociatedDocument.GetHashCode();
                
                if (this.FlowStatus != null)
                    hash = hash * 57 + this.FlowStatus.GetHashCode();
                
                if (this.CurrentState != null)
                    hash = hash * 57 + this.CurrentState.GetHashCode();
                
                if (this.StartDateTime != null)
                    hash = hash * 57 + this.StartDateTime.GetHashCode();
                
                if (this.EndDateTime != null)
                    hash = hash * 57 + this.EndDateTime.GetHashCode();
                
                if (this.WorkItemUserAssignees != null)
                    hash = hash * 57 + this.WorkItemUserAssignees.GetHashCode();
                
                if (this.CompletedUser != null)
                    hash = hash * 57 + this.CompletedUser.GetHashCode();
                
                if (this.CompletionReason != null)
                    hash = hash * 57 + this.CompletionReason.GetHashCode();
                
                if (this.FlowErrorInfo != null)
                    hash = hash * 57 + this.FlowErrorInfo.GetHashCode();
                
                return hash;
            }
        }

    }


}
