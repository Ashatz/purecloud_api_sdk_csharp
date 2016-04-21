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
    /// 
    /// </summary>
    [DataContract]
    public partial class MediaPolicies :  IEquatable<MediaPolicies>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaPolicies" />class.
        /// </summary>
        /// <param name="CallPolicy">Conditions and actions for calls.</param>
        /// <param name="ChatPolicy">Conditions and actions for chats.</param>
        /// <param name="EmailPolicy">Conditions and actions for emails.</param>

        public MediaPolicies(MediaPolicy CallPolicy = null, MediaPolicy ChatPolicy = null, MediaPolicy EmailPolicy = null)
        {
            this.CallPolicy = CallPolicy;
            this.ChatPolicy = ChatPolicy;
            this.EmailPolicy = EmailPolicy;
            
        }

    
        /// <summary>
        /// Conditions and actions for calls
        /// </summary>
        /// <value>Conditions and actions for calls</value>
        [DataMember(Name="callPolicy", EmitDefaultValue=false)]
        public MediaPolicy CallPolicy { get; set; }
    
        /// <summary>
        /// Conditions and actions for chats
        /// </summary>
        /// <value>Conditions and actions for chats</value>
        [DataMember(Name="chatPolicy", EmitDefaultValue=false)]
        public MediaPolicy ChatPolicy { get; set; }
    
        /// <summary>
        /// Conditions and actions for emails
        /// </summary>
        /// <value>Conditions and actions for emails</value>
        [DataMember(Name="emailPolicy", EmitDefaultValue=false)]
        public MediaPolicy EmailPolicy { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaPolicies {\n");
            sb.Append("  CallPolicy: ").Append(CallPolicy).Append("\n");
            sb.Append("  ChatPolicy: ").Append(ChatPolicy).Append("\n");
            sb.Append("  EmailPolicy: ").Append(EmailPolicy).Append("\n");
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
            return this.Equals(obj as MediaPolicies);
        }

        /// <summary>
        /// Returns true if MediaPolicies instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaPolicies to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaPolicies other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CallPolicy == other.CallPolicy ||
                    this.CallPolicy != null &&
                    this.CallPolicy.Equals(other.CallPolicy)
                ) &&
                (
                    this.ChatPolicy == other.ChatPolicy ||
                    this.ChatPolicy != null &&
                    this.ChatPolicy.Equals(other.ChatPolicy)
                ) &&
                (
                    this.EmailPolicy == other.EmailPolicy ||
                    this.EmailPolicy != null &&
                    this.EmailPolicy.Equals(other.EmailPolicy)
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
                if (this.CallPolicy != null)
                    hash = hash * 59 + this.CallPolicy.GetHashCode();
                if (this.ChatPolicy != null)
                    hash = hash * 59 + this.ChatPolicy.GetHashCode();
                if (this.EmailPolicy != null)
                    hash = hash * 59 + this.EmailPolicy.GetHashCode();
                return hash;
            }
        }

    }
}
