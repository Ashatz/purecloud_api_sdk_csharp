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
    /// Used as the body to the activateFlow request.
    /// </summary>
    [DataContract]
    public partial class FlowActivateRequest :  IEquatable<FlowActivateRequest>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowActivateRequest" />class.
        /// </summary>
        /// <param name="Activated">Change the activated state of the flow definition.  True to activate the flow definition so it can be launched, false to disable the flow. (required) (default to false).</param>

        public FlowActivateRequest(bool? Activated = null)
        {
            // to ensure "Activated" is required (not null)
            if (Activated == null)
            {
                throw new InvalidDataException("Activated is a required property for FlowActivateRequest and cannot be null");
            }
            else
            {
                this.Activated = Activated;
            }
            
        }
        
    
        /// <summary>
        /// Change the activated state of the flow definition.  True to activate the flow definition so it can be launched, false to disable the flow.
        /// </summary>
        /// <value>Change the activated state of the flow definition.  True to activate the flow definition so it can be launched, false to disable the flow.</value>
        [DataMember(Name="activated", EmitDefaultValue=false)]
        public bool? Activated { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowActivateRequest {\n");
            sb.Append("  Activated: ").Append(Activated).Append("\n");
            
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
            return this.Equals(obj as FlowActivateRequest);
        }

        /// <summary>
        /// Returns true if FlowActivateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowActivateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowActivateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Activated == other.Activated ||
                    this.Activated != null &&
                    this.Activated.Equals(other.Activated)
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
                
                if (this.Activated != null)
                    hash = hash * 59 + this.Activated.GetHashCode();
                
                return hash;
            }
        }

    }
}
