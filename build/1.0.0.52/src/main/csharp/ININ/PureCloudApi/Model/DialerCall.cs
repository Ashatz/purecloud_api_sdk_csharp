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
    public class DialerCall :  IEquatable<DialerCall>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCall" /> class.
        /// </summary>
        public DialerCall()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets CallId
        /// </summary>
        [DataMember(Name="callId", EmitDefaultValue=false)]
        public string CallId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCall {\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            
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
            return this.Equals(obj as DialerCall);
        }

        /// <summary>
        /// Returns true if DialerCall instances are equal
        /// </summary>
        /// <param name="obj">Instance of DialerCall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCall other)
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
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
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
                    hash = hash * 57 + this.CallId.GetHashCode();
                
                if (this.ConversationId != null)
                    hash = hash * 57 + this.ConversationId.GetHashCode();
                
                return hash;
            }
        }

    }


}
