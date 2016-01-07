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
    public class PhoneNumberStatus :  IEquatable<PhoneNumberStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberStatus" /> class.
        /// </summary>
        public PhoneNumberStatus()
        {
            this.Callable = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Callable
        /// </summary>
        [DataMember(Name="callable", EmitDefaultValue=false)]
        public bool? Callable { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneNumberStatus {\n");
            sb.Append("  Callable: ").Append(Callable).Append("\n");
            
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
            return this.Equals(obj as PhoneNumberStatus);
        }

        /// <summary>
        /// Returns true if PhoneNumberStatus instances are equal
        /// </summary>
        /// <param name="obj">Instance of PhoneNumberStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumberStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Callable == other.Callable ||
                    this.Callable != null &&
                    this.Callable.Equals(other.Callable)
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
                
                if (this.Callable != null)
                    hash = hash * 57 + this.Callable.GetHashCode();
                
                return hash;
            }
        }

    }


}
