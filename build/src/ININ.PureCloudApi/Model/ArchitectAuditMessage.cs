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
    /// ArchitectAuditMessage
    /// </summary>
    [DataContract]
    public partial class ArchitectAuditMessage :  IEquatable<ArchitectAuditMessage>
    {
        /// <summary>
        /// The audit action
        /// </summary>
        /// <value>The audit action</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Checkin for "CHECKIN"
            /// </summary>
            [EnumMember(Value = "CHECKIN")]
            Checkin,
            
            /// <summary>
            /// Enum Publish for "PUBLISH"
            /// </summary>
            [EnumMember(Value = "PUBLISH")]
            Publish,
            
            /// <summary>
            /// Enum Delete for "DELETE"
            /// </summary>
            [EnumMember(Value = "DELETE")]
            Delete
        }

        /// <summary>
        /// The audit action
        /// </summary>
        /// <value>The audit action</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectAuditMessage" /> class.
        /// </summary>
        /// <param name="Action">The audit action.</param>
        /// <param name="User">User.</param>
        /// <param name="Timestamp">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Changes">Changes.</param>
        /// <param name="Entity">Entity.</param>
        public ArchitectAuditMessage(ActionEnum? Action = null, AuditUser User = null, DateTime? Timestamp = null, List<Change> Changes = null, AuditEntity Entity = null)
        {
            this.Action = Action;
            this.User = User;
            this.Timestamp = Timestamp;
            this.Changes = Changes;
            this.Entity = Entity;
        }
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public AuditUser User { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets Changes
        /// </summary>
        [DataMember(Name="changes", EmitDefaultValue=false)]
        public List<Change> Changes { get; set; }
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public AuditEntity Entity { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchitectAuditMessage {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
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
            return this.Equals(obj as ArchitectAuditMessage);
        }

        /// <summary>
        /// Returns true if ArchitectAuditMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectAuditMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectAuditMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.Changes == other.Changes ||
                    this.Changes != null &&
                    this.Changes.SequenceEqual(other.Changes)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
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
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.Changes != null)
                    hash = hash * 59 + this.Changes.GetHashCode();
                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();
                return hash;
            }
        }
    }

}
