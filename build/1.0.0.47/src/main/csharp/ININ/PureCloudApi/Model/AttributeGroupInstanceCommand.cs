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
    public class AttributeGroupInstanceCommand :  IEquatable<AttributeGroupInstanceCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeGroupInstanceCommand" /> class.
        /// </summary>
        public AttributeGroupInstanceCommand()
        {
            this.Created = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Instance
        /// </summary>
        [DataMember(Name="instance", EmitDefaultValue=false)]
        public AttributeGroupInstance Instance { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public CommandStatus Status { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public bool? Created { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttributeGroupInstanceCommand {\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            
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
            return this.Equals(obj as AttributeGroupInstanceCommand);
        }

        /// <summary>
        /// Returns true if AttributeGroupInstanceCommand instances are equal
        /// </summary>
        /// <param name="obj">Instance of AttributeGroupInstanceCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeGroupInstanceCommand other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Instance == other.Instance ||
                    this.Instance != null &&
                    this.Instance.Equals(other.Instance)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
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
                
                if (this.Instance != null)
                    hash = hash * 57 + this.Instance.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.Created != null)
                    hash = hash * 57 + this.Created.GetHashCode();
                
                return hash;
            }
        }

    }


}
