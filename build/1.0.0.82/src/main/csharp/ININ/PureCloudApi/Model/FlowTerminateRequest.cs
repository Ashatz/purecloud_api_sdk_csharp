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
    /// Passed into a terminate command to customize the termination/cancellation action.
    /// </summary>
    [DataContract]
    public class FlowTerminateRequest :  IEquatable<FlowTerminateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowTerminateRequest" /> class.
        /// </summary>
        public FlowTerminateRequest()
        {
            this.Force = false;
            
        }

        
        /// <summary>
        /// force the termination of a flow.
        /// </summary>
        /// <value>force the termination of a flow.</value>
        [DataMember(Name="force", EmitDefaultValue=false)]
        public bool? Force { get; set; }
  
        
        /// <summary>
        /// Reason for termination.
        /// </summary>
        /// <value>Reason for termination.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowTerminateRequest {\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            
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
            return this.Equals(obj as FlowTerminateRequest);
        }

        /// <summary>
        /// Returns true if FlowTerminateRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of FlowTerminateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowTerminateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Force == other.Force ||
                    this.Force != null &&
                    this.Force.Equals(other.Force)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                
                if (this.Force != null)
                    hash = hash * 57 + this.Force.GetHashCode();
                
                if (this.Reason != null)
                    hash = hash * 57 + this.Reason.GetHashCode();
                
                return hash;
            }
        }

    }


}
