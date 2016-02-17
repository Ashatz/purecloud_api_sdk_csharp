using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class DialerDispositionCallCommand :  IEquatable<DialerDispositionCallCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerDispositionCallCommand" /> class.
        /// </summary>
        public DialerDispositionCallCommand()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets CallId
        /// </summary>
        [DataMember(Name="callId", EmitDefaultValue=false)]
        public string CallId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets WrapupCodeId
        /// </summary>
        [DataMember(Name="wrapupCodeId", EmitDefaultValue=false)]
        public string WrapupCodeId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public Contact Contact { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerDispositionCallCommand {\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  WrapupCodeId: ").Append(WrapupCodeId).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            
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
            return this.Equals(obj as DialerDispositionCallCommand);
        }

        /// <summary>
        /// Returns true if DialerDispositionCallCommand instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerDispositionCallCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerDispositionCallCommand other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CallId == other.CallId ||
                    this.CallId != null &&
                    this.CallId.Equals(other.CallId)
                ) && 
                (
                    this.WrapupCodeId == other.WrapupCodeId ||
                    this.WrapupCodeId != null &&
                    this.WrapupCodeId.Equals(other.WrapupCodeId)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
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
                
                if (this.CallId != null)
                    hash = hash * 59 + this.CallId.GetHashCode();
                
                if (this.WrapupCodeId != null)
                    hash = hash * 59 + this.WrapupCodeId.GetHashCode();
                
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                
                return hash;
            }
        }

    }
}
