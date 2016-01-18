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
    /// Information about one flow history item
    /// </summary>
    [DataContract]
    public class FlowHistoryItem :  IEquatable<FlowHistoryItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowHistoryItem" /> class.
        /// </summary>
        public FlowHistoryItem()
        {
            this.Success = false;
            
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
        public List<DataItem> HistoryEventData { get; set; }
  
        
        /// <summary>
        /// The type of the history event being reported.
        /// </summary>
        /// <value>The type of the history event being reported.</value>
        [DataMember(Name="historyEventType", EmitDefaultValue=false)]
        public string HistoryEventType { get; set; }
  
        
        /// <summary>
        /// Whether or not the flow item was successful (if a 'notification' event this will default to true)
        /// </summary>
        /// <value>Whether or not the flow item was successful (if a 'notification' event this will default to true)</value>
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
        /// <param name="obj">Instance of FlowHistoryItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowHistoryItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    hash = hash * 57 + this.HistoryEventTime.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 57 + this.State.GetHashCode();
                
                if (this.WorkItem != null)
                    hash = hash * 57 + this.WorkItem.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 57 + this.User.GetHashCode();
                
                if (this.Queue != null)
                    hash = hash * 57 + this.Queue.GetHashCode();
                
                if (this.HistoryEventData != null)
                    hash = hash * 57 + this.HistoryEventData.GetHashCode();
                
                if (this.HistoryEventType != null)
                    hash = hash * 57 + this.HistoryEventType.GetHashCode();
                
                if (this.Success != null)
                    hash = hash * 57 + this.Success.GetHashCode();
                
                return hash;
            }
        }

    }


}
