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
    public class InboundRoute :  IEquatable<InboundRoute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundRoute" /> class.
        /// </summary>
        public InboundRoute()
        {
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
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
        /// The maximum spam score for email that will be routed.
        /// </summary>
        /// <value>The maximum spam score for email that will be routed.</value>
        [DataMember(Name="spamThreshold", EmitDefaultValue=false)]
        public double? SpamThreshold { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
  
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
            sb.Append("  SpamThreshold: ").Append(SpamThreshold).Append("\n");
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
        /// <param name="obj">Instance of InboundRoute to be compared</param>
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
                ) && 
                (
                    this.SpamThreshold == other.SpamThreshold ||
                    this.SpamThreshold != null &&
                    this.SpamThreshold.Equals(other.SpamThreshold)
                ) && 
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Pattern != null)
                    hash = hash * 57 + this.Pattern.GetHashCode();
                
                if (this.Queue != null)
                    hash = hash * 57 + this.Queue.GetHashCode();
                
                if (this.Priority != null)
                    hash = hash * 57 + this.Priority.GetHashCode();
                
                if (this.Skills != null)
                    hash = hash * 57 + this.Skills.GetHashCode();
                
                if (this.Language != null)
                    hash = hash * 57 + this.Language.GetHashCode();
                
                if (this.FromName != null)
                    hash = hash * 57 + this.FromName.GetHashCode();
                
                if (this.FromEmail != null)
                    hash = hash * 57 + this.FromEmail.GetHashCode();
                
                if (this.SpamThreshold != null)
                    hash = hash * 57 + this.SpamThreshold.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
