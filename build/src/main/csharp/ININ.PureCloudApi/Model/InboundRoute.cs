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
    /// InboundRoute
    /// </summary>
    [DataContract]
    public partial class InboundRoute :  IEquatable<InboundRoute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundRoute" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Pattern">The search pattern that the mailbox name should match..</param>
        /// <param name="Queue">The queue to route the emails to..</param>
        /// <param name="Priority">The priority to use for routing..</param>
        /// <param name="Skills">The skills to use for routing..</param>
        /// <param name="Language">The language to use for routing..</param>
        /// <param name="FromName">The sender name to use for outgoing replies..</param>
        /// <param name="FromEmail">The sender email to use for outgoing replies..</param>
        public InboundRoute(, string Name = null, string Pattern = null, UriReference Queue = null, int? Priority = null, List<UriReference> Skills = null, UriReference Language = null, string FromName = null, string FromEmail = null)
        {
            this.Name = Name;
            this.Pattern = Pattern;
            this.Queue = Queue;
            this.Priority = Priority;
            this.Skills = Skills;
            this.Language = Language;
            this.FromName = FromName;
            this.FromEmail = FromEmail;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The search pattern that the mailbox name should match.
        /// </summary>
        /// <value>The search pattern that the mailbox name should match.</value>
        [DataMember(Name="pattern", EmitDefaultValue=false)]
        public string Pattern { get; set; }
        /// <summary>
        /// The queue to route the emails to.
        /// </summary>
        /// <value>The queue to route the emails to.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public UriReference Queue { get; set; }
        /// <summary>
        /// The priority to use for routing.
        /// </summary>
        /// <value>The priority to use for routing.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }
        /// <summary>
        /// The skills to use for routing.
        /// </summary>
        /// <value>The skills to use for routing.</value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<UriReference> Skills { get; set; }
        /// <summary>
        /// The language to use for routing.
        /// </summary>
        /// <value>The language to use for routing.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public UriReference Language { get; set; }
        /// <summary>
        /// The sender name to use for outgoing replies.
        /// </summary>
        /// <value>The sender name to use for outgoing replies.</value>
        [DataMember(Name="fromName", EmitDefaultValue=false)]
        public string FromName { get; set; }
        /// <summary>
        /// The sender email to use for outgoing replies.
        /// </summary>
        /// <value>The sender email to use for outgoing replies.</value>
        [DataMember(Name="fromEmail", EmitDefaultValue=false)]
        public string FromEmail { get; set; }
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundRoute {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  FromName: ").Append(FromName).Append("\n");
            sb.Append("  FromEmail: ").Append(FromEmail).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as InboundRoute);
        }

        /// <summary>
        /// Returns true if InboundRoute instances are equal
        /// </summary>
        /// <param name="other">Instance of InboundRoute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundRoute other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Pattern == other.Pattern ||
                    this.Pattern != null &&
                    this.Pattern.Equals(other.Pattern)
                ) && 
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.Skills == other.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(other.Skills)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.FromName == other.FromName ||
                    this.FromName != null &&
                    this.FromName.Equals(other.FromName)
                ) && 
                (
                    this.FromEmail == other.FromEmail ||
                    this.FromEmail != null &&
                    this.FromEmail.Equals(other.FromEmail)
                )
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Pattern != null)
                    hash = hash * 59 + this.Pattern.GetHashCode();
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.Skills != null)
                    hash = hash * 59 + this.Skills.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.FromName != null)
                    hash = hash * 59 + this.FromName.GetHashCode();
                if (this.FromEmail != null)
                    hash = hash * 59 + this.FromEmail.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
