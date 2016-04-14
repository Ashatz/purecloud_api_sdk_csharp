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
    public partial class SubscriberResponse :  IEquatable<SubscriberResponse>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberResponse" />class.
        /// </summary>
        /// <param name="MessageReturned">MessageReturned.</param>
        /// <param name="Status">Status.</param>

        public SubscriberResponse(List<string> MessageReturned = null, string Status = null)
        {
            this.MessageReturned = MessageReturned;
            this.Status = Status;
            
        }

    
        /// <summary>
        /// Gets or Sets MessageReturned
        /// </summary>
        [DataMember(Name="messageReturned", EmitDefaultValue=false)]
        public List<string> MessageReturned { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriberResponse {\n");
            sb.Append("  MessageReturned: ").Append(MessageReturned).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as SubscriberResponse);
        }

        /// <summary>
        /// Returns true if SubscriberResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriberResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriberResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MessageReturned == other.MessageReturned ||
                    this.MessageReturned != null &&
                    this.MessageReturned.SequenceEqual(other.MessageReturned)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.MessageReturned != null)
                    hash = hash * 59 + this.MessageReturned.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }

    }
}
