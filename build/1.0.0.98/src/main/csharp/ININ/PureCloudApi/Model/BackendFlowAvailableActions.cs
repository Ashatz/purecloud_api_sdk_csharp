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
    public class BackendFlowAvailableActions :  IEquatable<BackendFlowAvailableActions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackendFlowAvailableActions" /> class.
        /// </summary>
        public BackendFlowAvailableActions()
        {
            this.CanTerminate = false;
            
        }

        
        /// <summary>
        /// Gets or Sets CanTerminate
        /// </summary>
        [DataMember(Name="canTerminate", EmitDefaultValue=false)]
        public bool? CanTerminate { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackendFlowAvailableActions {\n");
            sb.Append("  CanTerminate: ").Append(CanTerminate).Append("\n");
            
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
            return this.Equals(obj as BackendFlowAvailableActions);
        }

        /// <summary>
        /// Returns true if BackendFlowAvailableActions instances are equal
        /// </summary>
        /// <param name="obj">Instance of BackendFlowAvailableActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackendFlowAvailableActions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CanTerminate == other.CanTerminate ||
                    this.CanTerminate != null &&
                    this.CanTerminate.Equals(other.CanTerminate)
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
                
                if (this.CanTerminate != null)
                    hash = hash * 57 + this.CanTerminate.GetHashCode();
                
                return hash;
            }
        }

    }


}
