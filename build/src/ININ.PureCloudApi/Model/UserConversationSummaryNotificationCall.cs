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
    /// UserConversationSummaryNotificationCall
    /// </summary>
    [DataContract]
    public partial class UserConversationSummaryNotificationCall :  IEquatable<UserConversationSummaryNotificationCall>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConversationSummaryNotificationCall" /> class.
        /// </summary>
        /// <param name="ContactCenter">ContactCenter.</param>
        public UserConversationSummaryNotificationCall(UserConversationSummaryNotificationCallContactCenter ContactCenter = null)
        {
            this.ContactCenter = ContactCenter;
        }
        
        /// <summary>
        /// Gets or Sets ContactCenter
        /// </summary>
        [DataMember(Name="contactCenter", EmitDefaultValue=false)]
        public UserConversationSummaryNotificationCallContactCenter ContactCenter { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserConversationSummaryNotificationCall {\n");
            sb.Append("  ContactCenter: ").Append(ContactCenter).Append("\n");
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
            return this.Equals(obj as UserConversationSummaryNotificationCall);
        }

        /// <summary>
        /// Returns true if UserConversationSummaryNotificationCall instances are equal
        /// </summary>
        /// <param name="other">Instance of UserConversationSummaryNotificationCall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserConversationSummaryNotificationCall other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContactCenter == other.ContactCenter ||
                    this.ContactCenter != null &&
                    this.ContactCenter.Equals(other.ContactCenter)
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
                if (this.ContactCenter != null)
                    hash = hash * 59 + this.ContactCenter.GetHashCode();
                return hash;
            }
        }
    }

}
