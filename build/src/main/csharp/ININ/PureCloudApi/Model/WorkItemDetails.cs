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
    /// Details about a WorkItem
    /// </summary>
    [DataContract]
    public partial class WorkItemDetails :  IEquatable<WorkItemDetails>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemDetails" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="WorkItemDefinition">WorkItemDefinition.</param>
        /// <param name="FlowExecId">The flow instance ID that created this WorkItem (required).</param>
        /// <param name="FlowConfigId">The flow config ID that this workitem was created from. (required).</param>
        /// <param name="FlowCreateTime">The time the flow was started. (that created this workitem). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (required).</param>
        /// <param name="CreateTime">The time this workitem was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (required).</param>
        /// <param name="Owner">The user currently working on/has responsibility for this WorkItem.  May be null if no owner..</param>
        /// <param name="OfferedToUsers">List of users that this workItem is offered to.  May be null if only offered to queues..</param>
        /// <param name="OfferedToQueues">List of queues that this workItem is offered to.  May be null if only offered to users..</param>
        /// <param name="Title">The work item title.</param>
        /// <param name="Subtitle">The work item&#39;s subtitle - 2nd line/description.</param>
        /// <param name="AssociatedDocuments">The documents associated with this workitem.</param>
        /// <param name="AvailableActions">The actions that the user can take on this workitem (submit, transfer, etc)..</param>
        /// <param name="DataValueInfo">The data items that provide values for any work item form elements, if applicable..</param>
        /// <param name="WorkItemCache">The data items in the current work item cache, if one exists..</param>
        /// <param name="LastOfferedTime">The time this work item was last offered to a user or queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="LastOwnershipUpdateTime">The most recent time a user assumed ownership of a work item. This may be blank if the work item has no owner. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="CurrentTaskStartTime">This is the time when the current task that started the work item was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>

        public WorkItemDetails(string Name = null, WorkItemDefinition WorkItemDefinition = null, FlowExecId FlowExecId = null, FlowConfigId FlowConfigId = null, DateTime? FlowCreateTime = null, DateTime? CreateTime = null, User Owner = null, List<User> OfferedToUsers = null, List<Queue> OfferedToQueues = null, string Title = null, string Subtitle = null, List<AssociatedDocument> AssociatedDocuments = null, WorkItemActions AvailableActions = null, DataValueInfo DataValueInfo = null, WorkItemCache WorkItemCache = null, DateTime? LastOfferedTime = null, DateTime? LastOwnershipUpdateTime = null, DateTime? CurrentTaskStartTime = null)
        {
            // to ensure "FlowExecId" is required (not null)
            if (FlowExecId == null)
            {
                throw new InvalidDataException("FlowExecId is a required property for WorkItemDetails and cannot be null");
            }
            else
            {
                this.FlowExecId = FlowExecId;
            }
            // to ensure "FlowConfigId" is required (not null)
            if (FlowConfigId == null)
            {
                throw new InvalidDataException("FlowConfigId is a required property for WorkItemDetails and cannot be null");
            }
            else
            {
                this.FlowConfigId = FlowConfigId;
            }
            // to ensure "FlowCreateTime" is required (not null)
            if (FlowCreateTime == null)
            {
                throw new InvalidDataException("FlowCreateTime is a required property for WorkItemDetails and cannot be null");
            }
            else
            {
                this.FlowCreateTime = FlowCreateTime;
            }
            // to ensure "CreateTime" is required (not null)
            if (CreateTime == null)
            {
                throw new InvalidDataException("CreateTime is a required property for WorkItemDetails and cannot be null");
            }
            else
            {
                this.CreateTime = CreateTime;
            }
            this.Name = Name;
            this.WorkItemDefinition = WorkItemDefinition;
            this.Owner = Owner;
            this.OfferedToUsers = OfferedToUsers;
            this.OfferedToQueues = OfferedToQueues;
            this.Title = Title;
            this.Subtitle = Subtitle;
            this.AssociatedDocuments = AssociatedDocuments;
            this.AvailableActions = AvailableActions;
            this.DataValueInfo = DataValueInfo;
            this.WorkItemCache = WorkItemCache;
            this.LastOfferedTime = LastOfferedTime;
            this.LastOwnershipUpdateTime = LastOwnershipUpdateTime;
            this.CurrentTaskStartTime = CurrentTaskStartTime;
            
        }
        
    
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets WorkItemDefinition
        /// </summary>
        [DataMember(Name="workItemDefinition", EmitDefaultValue=false)]
        public WorkItemDefinition WorkItemDefinition { get; set; }
    
        /// <summary>
        /// The flow instance ID that created this WorkItem
        /// </summary>
        /// <value>The flow instance ID that created this WorkItem</value>
        [DataMember(Name="flowExecId", EmitDefaultValue=false)]
        public FlowExecId FlowExecId { get; set; }
    
        /// <summary>
        /// The flow config ID that this workitem was created from.
        /// </summary>
        /// <value>The flow config ID that this workitem was created from.</value>
        [DataMember(Name="flowConfigId", EmitDefaultValue=false)]
        public FlowConfigId FlowConfigId { get; set; }
    
        /// <summary>
        /// The time the flow was started. (that created this workitem). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time the flow was started. (that created this workitem). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="flowCreateTime", EmitDefaultValue=false)]
        public DateTime? FlowCreateTime { get; set; }
    
        /// <summary>
        /// The time this workitem was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time this workitem was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createTime", EmitDefaultValue=false)]
        public DateTime? CreateTime { get; set; }
    
        /// <summary>
        /// The user currently working on/has responsibility for this WorkItem.  May be null if no owner.
        /// </summary>
        /// <value>The user currently working on/has responsibility for this WorkItem.  May be null if no owner.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public User Owner { get; set; }
    
        /// <summary>
        /// List of users that this workItem is offered to.  May be null if only offered to queues.
        /// </summary>
        /// <value>List of users that this workItem is offered to.  May be null if only offered to queues.</value>
        [DataMember(Name="offeredToUsers", EmitDefaultValue=false)]
        public List<User> OfferedToUsers { get; set; }
    
        /// <summary>
        /// List of queues that this workItem is offered to.  May be null if only offered to users.
        /// </summary>
        /// <value>List of queues that this workItem is offered to.  May be null if only offered to users.</value>
        [DataMember(Name="offeredToQueues", EmitDefaultValue=false)]
        public List<Queue> OfferedToQueues { get; set; }
    
        /// <summary>
        /// The work item title
        /// </summary>
        /// <value>The work item title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
    
        /// <summary>
        /// The work item's subtitle - 2nd line/description
        /// </summary>
        /// <value>The work item's subtitle - 2nd line/description</value>
        [DataMember(Name="subtitle", EmitDefaultValue=false)]
        public string Subtitle { get; set; }
    
        /// <summary>
        /// The documents associated with this workitem
        /// </summary>
        /// <value>The documents associated with this workitem</value>
        [DataMember(Name="associatedDocuments", EmitDefaultValue=false)]
        public List<AssociatedDocument> AssociatedDocuments { get; set; }
    
        /// <summary>
        /// The actions that the user can take on this workitem (submit, transfer, etc).
        /// </summary>
        /// <value>The actions that the user can take on this workitem (submit, transfer, etc).</value>
        [DataMember(Name="availableActions", EmitDefaultValue=false)]
        public WorkItemActions AvailableActions { get; set; }
    
        /// <summary>
        /// The data items that provide values for any work item form elements, if applicable.
        /// </summary>
        /// <value>The data items that provide values for any work item form elements, if applicable.</value>
        [DataMember(Name="dataValueInfo", EmitDefaultValue=false)]
        public DataValueInfo DataValueInfo { get; set; }
    
        /// <summary>
        /// The data items in the current work item cache, if one exists.
        /// </summary>
        /// <value>The data items in the current work item cache, if one exists.</value>
        [DataMember(Name="workItemCache", EmitDefaultValue=false)]
        public WorkItemCache WorkItemCache { get; set; }
    
        /// <summary>
        /// The time this work item was last offered to a user or queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time this work item was last offered to a user or queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="lastOfferedTime", EmitDefaultValue=false)]
        public DateTime? LastOfferedTime { get; set; }
    
        /// <summary>
        /// The most recent time a user assumed ownership of a work item. This may be blank if the work item has no owner. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The most recent time a user assumed ownership of a work item. This may be blank if the work item has no owner. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="lastOwnershipUpdateTime", EmitDefaultValue=false)]
        public DateTime? LastOwnershipUpdateTime { get; set; }
    
        /// <summary>
        /// This is the time when the current task that started the work item was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>This is the time when the current task that started the work item was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="currentTaskStartTime", EmitDefaultValue=false)]
        public DateTime? CurrentTaskStartTime { get; set; }
    
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  WorkItemDefinition: ").Append(WorkItemDefinition).Append("\n");
            sb.Append("  FlowExecId: ").Append(FlowExecId).Append("\n");
            sb.Append("  FlowConfigId: ").Append(FlowConfigId).Append("\n");
            sb.Append("  FlowCreateTime: ").Append(FlowCreateTime).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  OfferedToUsers: ").Append(OfferedToUsers).Append("\n");
            sb.Append("  OfferedToQueues: ").Append(OfferedToQueues).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  AssociatedDocuments: ").Append(AssociatedDocuments).Append("\n");
            sb.Append("  AvailableActions: ").Append(AvailableActions).Append("\n");
            sb.Append("  DataValueInfo: ").Append(DataValueInfo).Append("\n");
            sb.Append("  WorkItemCache: ").Append(WorkItemCache).Append("\n");
            sb.Append("  LastOfferedTime: ").Append(LastOfferedTime).Append("\n");
            sb.Append("  LastOwnershipUpdateTime: ").Append(LastOwnershipUpdateTime).Append("\n");
            sb.Append("  CurrentTaskStartTime: ").Append(CurrentTaskStartTime).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            
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
            return this.Equals(obj as WorkItemDetails);
        }

        /// <summary>
        /// Returns true if WorkItemDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkItemDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.WorkItemDefinition == other.WorkItemDefinition ||
                    this.WorkItemDefinition != null &&
                    this.WorkItemDefinition.Equals(other.WorkItemDefinition)
                ) &&
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
                    this.FlowCreateTime == other.FlowCreateTime ||
                    this.FlowCreateTime != null &&
                    this.FlowCreateTime.Equals(other.FlowCreateTime)
                ) &&
                (
                    this.CreateTime == other.CreateTime ||
                    this.CreateTime != null &&
                    this.CreateTime.Equals(other.CreateTime)
                ) &&
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) &&
                (
                    this.OfferedToUsers == other.OfferedToUsers ||
                    this.OfferedToUsers != null &&
                    this.OfferedToUsers.SequenceEqual(other.OfferedToUsers)
                ) &&
                (
                    this.OfferedToQueues == other.OfferedToQueues ||
                    this.OfferedToQueues != null &&
                    this.OfferedToQueues.SequenceEqual(other.OfferedToQueues)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Subtitle == other.Subtitle ||
                    this.Subtitle != null &&
                    this.Subtitle.Equals(other.Subtitle)
                ) &&
                (
                    this.AssociatedDocuments == other.AssociatedDocuments ||
                    this.AssociatedDocuments != null &&
                    this.AssociatedDocuments.SequenceEqual(other.AssociatedDocuments)
                ) &&
                (
                    this.AvailableActions == other.AvailableActions ||
                    this.AvailableActions != null &&
                    this.AvailableActions.Equals(other.AvailableActions)
                ) &&
                (
                    this.DataValueInfo == other.DataValueInfo ||
                    this.DataValueInfo != null &&
                    this.DataValueInfo.Equals(other.DataValueInfo)
                ) &&
                (
                    this.WorkItemCache == other.WorkItemCache ||
                    this.WorkItemCache != null &&
                    this.WorkItemCache.Equals(other.WorkItemCache)
                ) &&
                (
                    this.LastOfferedTime == other.LastOfferedTime ||
                    this.LastOfferedTime != null &&
                    this.LastOfferedTime.Equals(other.LastOfferedTime)
                ) &&
                (
                    this.LastOwnershipUpdateTime == other.LastOwnershipUpdateTime ||
                    this.LastOwnershipUpdateTime != null &&
                    this.LastOwnershipUpdateTime.Equals(other.LastOwnershipUpdateTime)
                ) &&
                (
                    this.CurrentTaskStartTime == other.CurrentTaskStartTime ||
                    this.CurrentTaskStartTime != null &&
                    this.CurrentTaskStartTime.Equals(other.CurrentTaskStartTime)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.WorkItemDefinition != null)
                    hash = hash * 59 + this.WorkItemDefinition.GetHashCode();
                
                if (this.FlowExecId != null)
                    hash = hash * 59 + this.FlowExecId.GetHashCode();
                
                if (this.FlowConfigId != null)
                    hash = hash * 59 + this.FlowConfigId.GetHashCode();
                
                if (this.FlowCreateTime != null)
                    hash = hash * 59 + this.FlowCreateTime.GetHashCode();
                
                if (this.CreateTime != null)
                    hash = hash * 59 + this.CreateTime.GetHashCode();
                
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                
                if (this.OfferedToUsers != null)
                    hash = hash * 59 + this.OfferedToUsers.GetHashCode();
                
                if (this.OfferedToQueues != null)
                    hash = hash * 59 + this.OfferedToQueues.GetHashCode();
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.Subtitle != null)
                    hash = hash * 59 + this.Subtitle.GetHashCode();
                
                if (this.AssociatedDocuments != null)
                    hash = hash * 59 + this.AssociatedDocuments.GetHashCode();
                
                if (this.AvailableActions != null)
                    hash = hash * 59 + this.AvailableActions.GetHashCode();
                
                if (this.DataValueInfo != null)
                    hash = hash * 59 + this.DataValueInfo.GetHashCode();
                
                if (this.WorkItemCache != null)
                    hash = hash * 59 + this.WorkItemCache.GetHashCode();
                
                if (this.LastOfferedTime != null)
                    hash = hash * 59 + this.LastOfferedTime.GetHashCode();
                
                if (this.LastOwnershipUpdateTime != null)
                    hash = hash * 59 + this.LastOwnershipUpdateTime.GetHashCode();
                
                if (this.CurrentTaskStartTime != null)
                    hash = hash * 59 + this.CurrentTaskStartTime.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
