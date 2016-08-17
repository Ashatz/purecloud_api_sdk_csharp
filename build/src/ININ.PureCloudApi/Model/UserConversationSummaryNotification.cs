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
    /// UserConversationSummaryNotification
    /// </summary>
    [DataContract]
    public partial class UserConversationSummaryNotification :  IEquatable<UserConversationSummaryNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConversationSummaryNotification" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="Call">Call.</param>
        public UserConversationSummaryNotification(string UserId = null, UserConversationSummaryNotificationCall Call = null)
        {
            this.UserId = UserId;
            this.Call = Call;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Gets or Sets Call
        /// </summary>
        [DataMember(Name="call", EmitDefaultValue=false)]
        public UserConversationSummaryNotificationCall Call { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserConversationSummaryNotification {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Call: ").Append(Call).Append("\n");
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
            return this.Equals(obj as UserConversationSummaryNotification);
        }

        /// <summary>
        /// Returns true if UserConversationSummaryNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of UserConversationSummaryNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserConversationSummaryNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.Call == other.Call ||
                    this.Call != null &&
                    this.Call.Equals(other.Call)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Call != null)
                    hash = hash * 59 + this.Call.GetHashCode();
                return hash;
            }
        }
    }

}
