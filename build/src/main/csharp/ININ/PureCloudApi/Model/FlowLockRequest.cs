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
    /// Used as the body to the lockFlow request.
    /// </summary>
    [DataContract]
    public partial class FlowLockRequest :  IEquatable<FlowLockRequest>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowLockRequest" />class.
        /// </summary>
        /// <param name="Locked">Change the locked state of the flow definition.  True to attempt to lock for modification, false to release the lock. (required) (default to false).</param>

        public FlowLockRequest(bool? Locked = null)
        {
            // to ensure "Locked" is required (not null)
            if (Locked == null)
            {
                throw new InvalidDataException("Locked is a required property for FlowLockRequest and cannot be null");
            }
            else
            {
                this.Locked = Locked;
            }
            
        }

    
        /// <summary>
        /// Change the locked state of the flow definition.  True to attempt to lock for modification, false to release the lock.
        /// </summary>
        /// <value>Change the locked state of the flow definition.  True to attempt to lock for modification, false to release the lock.</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowLockRequest {\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
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
            return this.Equals(obj as FlowLockRequest);
        }

        /// <summary>
        /// Returns true if FlowLockRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowLockRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowLockRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
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
                if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();
                return hash;
            }
        }

    }
}
