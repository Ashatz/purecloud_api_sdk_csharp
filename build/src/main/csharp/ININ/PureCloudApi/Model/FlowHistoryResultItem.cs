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
    public partial class FlowHistoryResultItem :  IEquatable<FlowHistoryResultItem>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowHistoryResultItem" />class.
        /// </summary>
        /// <param name="FlowInstance">The flow instance information that applies to the history events. (required).</param>
        /// <param name="AvailableActions">The actions available for operating in the flow, with respect to your authorization identity..</param>
        /// <param name="HistoryItems">The ordered list of history events for this flow..</param>

        public FlowHistoryResultItem(FlowDetails FlowInstance = null, BackendFlowAvailableActions AvailableActions = null, List<FlowHistoryItem> HistoryItems = null)
        {
            // to ensure "FlowInstance" is required (not null)
            if (FlowInstance == null)
            {
                throw new InvalidDataException("FlowInstance is a required property for FlowHistoryResultItem and cannot be null");
            }
            else
            {
                this.FlowInstance = FlowInstance;
            }
            this.AvailableActions = AvailableActions;
            this.HistoryItems = HistoryItems;
            
        }
        
    
        /// <summary>
        /// The flow instance information that applies to the history events.
        /// </summary>
        /// <value>The flow instance information that applies to the history events.</value>
        [DataMember(Name="flowInstance", EmitDefaultValue=false)]
        public FlowDetails FlowInstance { get; set; }
    
        /// <summary>
        /// The actions available for operating in the flow, with respect to your authorization identity.
        /// </summary>
        /// <value>The actions available for operating in the flow, with respect to your authorization identity.</value>
        [DataMember(Name="availableActions", EmitDefaultValue=false)]
        public BackendFlowAvailableActions AvailableActions { get; set; }
    
        /// <summary>
        /// The ordered list of history events for this flow.
        /// </summary>
        /// <value>The ordered list of history events for this flow.</value>
        [DataMember(Name="historyItems", EmitDefaultValue=false)]
        public List<FlowHistoryItem> HistoryItems { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowHistoryResultItem {\n");
            sb.Append("  FlowInstance: ").Append(FlowInstance).Append("\n");
            sb.Append("  AvailableActions: ").Append(AvailableActions).Append("\n");
            sb.Append("  HistoryItems: ").Append(HistoryItems).Append("\n");
            
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
            return this.Equals(obj as FlowHistoryResultItem);
        }

        /// <summary>
        /// Returns true if FlowHistoryResultItem instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowHistoryResultItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowHistoryResultItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FlowInstance == other.FlowInstance ||
                    this.FlowInstance != null &&
                    this.FlowInstance.Equals(other.FlowInstance)
                ) &&
                (
                    this.AvailableActions == other.AvailableActions ||
                    this.AvailableActions != null &&
                    this.AvailableActions.Equals(other.AvailableActions)
                ) &&
                (
                    this.HistoryItems == other.HistoryItems ||
                    this.HistoryItems != null &&
                    this.HistoryItems.SequenceEqual(other.HistoryItems)
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
                
                if (this.FlowInstance != null)
                    hash = hash * 59 + this.FlowInstance.GetHashCode();
                
                if (this.AvailableActions != null)
                    hash = hash * 59 + this.AvailableActions.GetHashCode();
                
                if (this.HistoryItems != null)
                    hash = hash * 59 + this.HistoryItems.GetHashCode();
                
                return hash;
            }
        }

    }
}
