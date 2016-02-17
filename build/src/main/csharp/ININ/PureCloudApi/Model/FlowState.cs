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
    /// Information about the a State of a flow
    /// </summary>
    [DataContract]
    public partial class FlowState :  IEquatable<FlowState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowState" /> class.
        /// </summary>
        public FlowState()
        {
            
        }

        
        /// <summary>
        /// The identifier of the execution instance of this State.
        /// </summary>
        /// <value>The identifier of the execution instance of this State.</value>
        [DataMember(Name="stateExecId", EmitDefaultValue=false)]
        public string StateExecId { get; set; }
  
        
        /// <summary>
        /// The identifier of the definition of this State.
        /// </summary>
        /// <value>The identifier of the definition of this State.</value>
        [DataMember(Name="stateConfigId", EmitDefaultValue=false)]
        public string StateConfigId { get; set; }
  
        
        /// <summary>
        /// The displayable name of this State.
        /// </summary>
        /// <value>The displayable name of this State.</value>
        [DataMember(Name="stateName", EmitDefaultValue=false)]
        public string StateName { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowState {\n");
            sb.Append("  StateExecId: ").Append(StateExecId).Append("\n");
            sb.Append("  StateConfigId: ").Append(StateConfigId).Append("\n");
            sb.Append("  StateName: ").Append(StateName).Append("\n");
            
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
            return this.Equals(obj as FlowState);
        }

        /// <summary>
        /// Returns true if FlowState instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StateExecId == other.StateExecId ||
                    this.StateExecId != null &&
                    this.StateExecId.Equals(other.StateExecId)
                ) && 
                (
                    this.StateConfigId == other.StateConfigId ||
                    this.StateConfigId != null &&
                    this.StateConfigId.Equals(other.StateConfigId)
                ) && 
                (
                    this.StateName == other.StateName ||
                    this.StateName != null &&
                    this.StateName.Equals(other.StateName)
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
                
                if (this.StateExecId != null)
                    hash = hash * 59 + this.StateExecId.GetHashCode();
                
                if (this.StateConfigId != null)
                    hash = hash * 59 + this.StateConfigId.GetHashCode();
                
                if (this.StateName != null)
                    hash = hash * 59 + this.StateName.GetHashCode();
                
                return hash;
            }
        }

    }
}
