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
    /// 
    /// </summary>
    [DataContract]
    public class PolicyErrors :  IEquatable<PolicyErrors>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyErrors" /> class.
        /// </summary>
        public PolicyErrors()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets PolicyErrorMessages
        /// </summary>
        [DataMember(Name="policyErrorMessages", EmitDefaultValue=false)]
        public List<PolicyErrorMessage> PolicyErrorMessages { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyErrors {\n");
            sb.Append("  PolicyErrorMessages: ").Append(PolicyErrorMessages).Append("\n");
            
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
            return this.Equals(obj as PolicyErrors);
        }

        /// <summary>
        /// Returns true if PolicyErrors instances are equal
        /// </summary>
        /// <param name="obj">Instance of PolicyErrors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyErrors other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PolicyErrorMessages == other.PolicyErrorMessages ||
                    this.PolicyErrorMessages != null &&
                    this.PolicyErrorMessages.SequenceEqual(other.PolicyErrorMessages)
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
                
                if (this.PolicyErrorMessages != null)
                    hash = hash * 57 + this.PolicyErrorMessages.GetHashCode();
                
                return hash;
            }
        }

    }


}
