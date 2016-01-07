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
    /// Used as the body to the lockFlow request.
    /// </summary>
    [DataContract]
    public class FlowLockRequest :  IEquatable<FlowLockRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowLockRequest" /> class.
        /// </summary>
        public FlowLockRequest()
        {
            this.Locked = false;
            
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
        /// <param name="obj">Instance of FlowLockRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowLockRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    hash = hash * 57 + this.Locked.GetHashCode();
                
                return hash;
            }
        }

    }


}
