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
    public class OrgMediaUtilization :  IEquatable<OrgMediaUtilization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgMediaUtilization" /> class.
        /// </summary>
        public OrgMediaUtilization()
        {
            
        }

        
        /// <summary>
        /// Defines the maximum number of conversations of this type that an agent can handle at one time.
        /// </summary>
        /// <value>Defines the maximum number of conversations of this type that an agent can handle at one time.</value>
        [DataMember(Name="maximumCapacity", EmitDefaultValue=false)]
        public int? MaximumCapacity { get; set; }
  
        
        /// <summary>
        /// Defines the list of other media types that can interrupt a conversation of this media type.  Values can be: call, chat, email, or socialExpression
        /// </summary>
        /// <value>Defines the list of other media types that can interrupt a conversation of this media type.  Values can be: call, chat, email, or socialExpression</value>
        [DataMember(Name="interruptableMediaTypes", EmitDefaultValue=false)]
        public List<string> InterruptableMediaTypes { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgMediaUtilization {\n");
            sb.Append("  MaximumCapacity: ").Append(MaximumCapacity).Append("\n");
            sb.Append("  InterruptableMediaTypes: ").Append(InterruptableMediaTypes).Append("\n");
            
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
            return this.Equals(obj as OrgMediaUtilization);
        }

        /// <summary>
        /// Returns true if OrgMediaUtilization instances are equal
        /// </summary>
        /// <param name="obj">Instance of OrgMediaUtilization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgMediaUtilization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MaximumCapacity == other.MaximumCapacity ||
                    this.MaximumCapacity != null &&
                    this.MaximumCapacity.Equals(other.MaximumCapacity)
                ) && 
                (
                    this.InterruptableMediaTypes == other.InterruptableMediaTypes ||
                    this.InterruptableMediaTypes != null &&
                    this.InterruptableMediaTypes.SequenceEqual(other.InterruptableMediaTypes)
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
                
                if (this.MaximumCapacity != null)
                    hash = hash * 57 + this.MaximumCapacity.GetHashCode();
                
                if (this.InterruptableMediaTypes != null)
                    hash = hash * 57 + this.InterruptableMediaTypes.GetHashCode();
                
                return hash;
            }
        }

    }


}
