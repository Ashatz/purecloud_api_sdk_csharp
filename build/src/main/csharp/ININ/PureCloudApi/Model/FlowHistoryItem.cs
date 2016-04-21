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
    /// Information about one flow history item
    /// </summary>
    [DataContract]
    public partial class FlowHistoryItem :  IEquatable<FlowHistoryItem>
    { 

        /// <summary>
        /// The type of the history event being reported.
        /// </summary>
        /// <value>The type of the history event being reported.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum HistoryEventTypeEnum {
            
            [EnumMember(Value = "FLOW_INSTANCE_START")]
            FlowInstanceStart,
            
            [EnumMember(Value = "FLOW_INSTANCE_GOTO")]
            FlowInstanceGoto,
            
            [EnumMember(Value = "FLOW_INSTANCE_TERMINATE")]
            FlowInstanceTerminate,
            
            [EnumMember(Value = "FLOW_INSTANCE_END")]
            FlowInstanceEnd,
            
            [EnumMember(Value = "TASK_INSTANCE_START")]
            TaskInstanceStart,
            
            [EnumMember(Value = "TASK_INSTANCE_END")]
            TaskInstanceEnd,
            
            [EnumMember(Value = "WORK_ITEM_INSTANCE_SAVE")]
            WorkItemInstanceSave,
            
            [EnumMember(Value = "WORK_ITEM_INSTANCE_ACQUIRE")]
            WorkItemInstanceAcquire,
            
            [EnumMember(Value = "WORK_ITEM_INSTANCE_SUBMIT")]
            WorkItemInstanceSubmit,
            
            [EnumMember(Value = "WORK_ITEM_INSTANCE_OFFER")]
            WorkItemInstanceOffer,
            
            [EnumMember(Value = "WORK_ITEM_INSTANCE_REASSIGN")]
            WorkItemInstanceReassign,
            
            [EnumMember(Value = "FLOW_INSTANCE_ERROR")]
            FlowInstanceError,
            
            [EnumMember(Value = "FLOW_INSTANCE_RETRY")]
            FlowInstanceRetry
        }

        

        /// <summary>
        /// The type of the history event being reported.
        /// </summary>
        /// <value>The type of the history event being reported.</value>
        [DataMember(Name="historyEventType", EmitDefaultValue=false)]
        public HistoryEventTypeEnum? HistoryEventType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowHistoryItem" />class.
        /// </summary>
        /// <param name="HistoryEventTime">The time when the history item occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (required).</param>
        /// <param name="State">The State sequence that applies to the history event, if applicable..</param>
        /// <param name="WorkItem">Information about the work item associated with the history event, if applicable..</param>
        /// <param name="User">The user associated with this history event, if applicable..</param>
        /// <param name="Queue">The queue associated with this history event, if applicable..</param>
        /// <param name="HistoryEventData">Data elements associated with this history event..</param>
        /// <param name="HistoryEventType">The type of the history event being reported. (required).</param>
        /// <param name="Success">Whether or not the flow item was successful (if a &#39;notification&#39; event this will default to true) (required) (default to false).</param>

        public FlowHistoryItem(DateTime? HistoryEventTime = null, FlowState State = null, WorkItem WorkItem = null, User User = null, Queue Queue = null, List<FlowHistoryDataItem> HistoryEventData = null, HistoryEventTypeEnum? HistoryEventType = null, bool? Success = null)
        {
            // to ensure "HistoryEventTime" is required (not null)
            if (HistoryEventTime == null)
            {
                throw new InvalidDataException("HistoryEventTime is a required property for FlowHistoryItem and cannot be null");
            }
            else
            {
                this.HistoryEventTime = HistoryEventTime;
            }
            // to ensure "HistoryEventType" is required (not null)
            if (HistoryEventType == null)
            {
                throw new InvalidDataException("HistoryEventType is a required property for FlowHistoryItem and cannot be null");
            }
            else
            {
                this.HistoryEventType = HistoryEventType;
            }
            // to ensure "Success" is required (not null)
            if (Success == null)
            {
                throw new InvalidDataException("Success is a required property for FlowHistoryItem and cannot be null");
            }
            else
            {
                this.Success = Success;
            }
            this.State = State;
            this.WorkItem = WorkItem;
            this.User = User;
            this.Queue = Queue;
            this.HistoryEventData = HistoryEventData;
            
        }

    
        /// <summary>
        /// The time when the history item occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when the history item occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="historyEventTime", EmitDefaultValue=false)]
        public DateTime? HistoryEventTime { get; set; }
    
        /// <summary>
        /// The State sequence that applies to the history event, if applicable.
        /// </summary>
        /// <value>The State sequence that applies to the history event, if applicable.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public FlowState State { get; set; }
    
        /// <summary>
        /// Information about the work item associated with the history event, if applicable.
        /// </summary>
        /// <value>Information about the work item associated with the history event, if applicable.</value>
        [DataMember(Name="workItem", EmitDefaultValue=false)]
        public WorkItem WorkItem { get; set; }
    
        /// <summary>
        /// The user associated with this history event, if applicable.
        /// </summary>
        /// <value>The user associated with this history event, if applicable.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
    
        /// <summary>
        /// The queue associated with this history event, if applicable.
        /// </summary>
        /// <value>The queue associated with this history event, if applicable.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public Queue Queue { get; set; }
    
        /// <summary>
        /// Data elements associated with this history event.
        /// </summary>
        /// <value>Data elements associated with this history event.</value>
        [DataMember(Name="historyEventData", EmitDefaultValue=false)]
        public List<FlowHistoryDataItem> HistoryEventData { get; set; }
    
        /// <summary>
        /// Whether or not the flow item was successful (if a &#39;notification&#39; event this will default to true)
        /// </summary>
        /// <value>Whether or not the flow item was successful (if a &#39;notification&#39; event this will default to true)</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowHistoryItem {\n");
            sb.Append("  HistoryEventTime: ").Append(HistoryEventTime).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  WorkItem: ").Append(WorkItem).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  HistoryEventData: ").Append(HistoryEventData).Append("\n");
            sb.Append("  HistoryEventType: ").Append(HistoryEventType).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(obj as FlowHistoryItem);
        }

        /// <summary>
        /// Returns true if FlowHistoryItem instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowHistoryItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowHistoryItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.HistoryEventTime == other.HistoryEventTime ||
                    this.HistoryEventTime != null &&
                    this.HistoryEventTime.Equals(other.HistoryEventTime)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.WorkItem == other.WorkItem ||
                    this.WorkItem != null &&
                    this.WorkItem.Equals(other.WorkItem)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.HistoryEventData == other.HistoryEventData ||
                    this.HistoryEventData != null &&
                    this.HistoryEventData.SequenceEqual(other.HistoryEventData)
                ) &&
                (
                    this.HistoryEventType == other.HistoryEventType ||
                    this.HistoryEventType != null &&
                    this.HistoryEventType.Equals(other.HistoryEventType)
                ) &&
                (
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
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
                if (this.HistoryEventTime != null)
                    hash = hash * 59 + this.HistoryEventTime.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.WorkItem != null)
                    hash = hash * 59 + this.WorkItem.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                if (this.HistoryEventData != null)
                    hash = hash * 59 + this.HistoryEventData.GetHashCode();
                if (this.HistoryEventType != null)
                    hash = hash * 59 + this.HistoryEventType.GetHashCode();
                if (this.Success != null)
                    hash = hash * 59 + this.Success.GetHashCode();
                return hash;
            }
        }

    }
}
