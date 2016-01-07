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
    /// Passed into a flow to describe an object to launch and returned from the operation with the Id populated with the flowInstance launched.
    /// </summary>
    [DataContract]
    public class FlowLaunchRequest :  IEquatable<FlowLaunchRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowLaunchRequest" /> class.
        /// </summary>
        public FlowLaunchRequest()
        {
            
        }

        
        /// <summary>
        /// ID of the flow to launch, will launch the most recently published version if a specific version is not specified.
        /// </summary>
        /// <value>ID of the flow to launch, will launch the most recently published version if a specific version is not specified.</value>
        [DataMember(Name="flowConfigId", EmitDefaultValue=false)]
        public FlowConfigId FlowConfigId { get; set; }
  
        
        /// <summary>
        /// The displayable instance name to assign to the new flow instance (or omit to have one automatically generated)
        /// </summary>
        /// <value>The displayable instance name to assign to the new flow instance (or omit to have one automatically generated)</value>
        [DataMember(Name="flowInstanceName", EmitDefaultValue=false)]
        public string FlowInstanceName { get; set; }
  
        
        /// <summary>
        /// contains launch parameters or initializations for variables in the flow.
        /// </summary>
        /// <value>contains launch parameters or initializations for variables in the flow.</value>
        [DataMember(Name="inputData", EmitDefaultValue=false)]
        public FlowInputData InputData { get; set; }
  
        
        /// <summary>
        /// launch type of the flow - NORMAL or TEST
        /// </summary>
        /// <value>launch type of the flow - NORMAL or TEST</value>
        [DataMember(Name="launchType", EmitDefaultValue=false)]
        public string LaunchType { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowLaunchRequest {\n");
            sb.Append("  FlowConfigId: ").Append(FlowConfigId).Append("\n");
            sb.Append("  FlowInstanceName: ").Append(FlowInstanceName).Append("\n");
            sb.Append("  InputData: ").Append(InputData).Append("\n");
            sb.Append("  LaunchType: ").Append(LaunchType).Append("\n");
            
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
            return this.Equals(obj as FlowLaunchRequest);
        }

        /// <summary>
        /// Returns true if FlowLaunchRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of FlowLaunchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowLaunchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.InputData == other.InputData ||
                    this.InputData != null &&
                    this.InputData.Equals(other.InputData)
                ) && 
                (
                    this.LaunchType == other.LaunchType ||
                    this.LaunchType != null &&
                    this.LaunchType.Equals(other.LaunchType)
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
                
                if (this.FlowConfigId != null)
                    hash = hash * 57 + this.FlowConfigId.GetHashCode();
                
                if (this.FlowInstanceName != null)
                    hash = hash * 57 + this.FlowInstanceName.GetHashCode();
                
                if (this.InputData != null)
                    hash = hash * 57 + this.InputData.GetHashCode();
                
                if (this.LaunchType != null)
                    hash = hash * 57 + this.LaunchType.GetHashCode();
                
                return hash;
            }
        }

    }


}
