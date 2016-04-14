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
    public partial class Gistener :  IEquatable<Gistener>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Gistener" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">Creation date for the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">Date the entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Enabled">Indicates if this Gistener may be utilized on another entity (default to false).</param>
        /// <param name="AnyWords">A tweet must contain any one of these words.</param>
        /// <param name="AllWords">A tweet must contain every one of these words in any order.</param>
        /// <param name="ExcludeWords">If a tweet contains any one of these words, it is thrown out.</param>
        /// <param name="ExactPhrase">A tweet must contain this exact quoted phrase.</param>
        /// <param name="GroupTags">The group tags associated with this Gistener.</param>
        /// <param name="SocialAccount">The social account associated with this Gistener.</param>
        /// <param name="Queue">The operator queue the gistener will route to..</param>

        public Gistener(string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, bool? Enabled = null, string AnyWords = null, string AllWords = null, string ExcludeWords = null, string ExactPhrase = null, List<GroupTag> GroupTags = null, SocialAccount SocialAccount = null, Queue Queue = null)
        {
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            // use default value if no "Enabled" provided
            if (Enabled == null)
            {
                this.Enabled = false;
            }
            else
            {
                this.Enabled = Enabled;
            }
            this.AnyWords = AnyWords;
            this.AllWords = AllWords;
            this.ExcludeWords = ExcludeWords;
            this.ExactPhrase = ExactPhrase;
            this.GroupTags = GroupTags;
            this.SocialAccount = SocialAccount;
            this.Queue = Queue;
            
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
        /// Creation date for the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Creation date for the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
    
        /// <summary>
        /// Date the entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date the entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
    
        /// <summary>
        /// Indicates if this Gistener may be utilized on another entity
        /// </summary>
        /// <value>Indicates if this Gistener may be utilized on another entity</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// A tweet must contain any one of these words
        /// </summary>
        /// <value>A tweet must contain any one of these words</value>
        [DataMember(Name="anyWords", EmitDefaultValue=false)]
        public string AnyWords { get; set; }
    
        /// <summary>
        /// A tweet must contain every one of these words in any order
        /// </summary>
        /// <value>A tweet must contain every one of these words in any order</value>
        [DataMember(Name="allWords", EmitDefaultValue=false)]
        public string AllWords { get; set; }
    
        /// <summary>
        /// If a tweet contains any one of these words, it is thrown out
        /// </summary>
        /// <value>If a tweet contains any one of these words, it is thrown out</value>
        [DataMember(Name="excludeWords", EmitDefaultValue=false)]
        public string ExcludeWords { get; set; }
    
        /// <summary>
        /// A tweet must contain this exact quoted phrase
        /// </summary>
        /// <value>A tweet must contain this exact quoted phrase</value>
        [DataMember(Name="exactPhrase", EmitDefaultValue=false)]
        public string ExactPhrase { get; set; }
    
        /// <summary>
        /// The group tags associated with this Gistener
        /// </summary>
        /// <value>The group tags associated with this Gistener</value>
        [DataMember(Name="groupTags", EmitDefaultValue=false)]
        public List<GroupTag> GroupTags { get; set; }
    
        /// <summary>
        /// The social account associated with this Gistener
        /// </summary>
        /// <value>The social account associated with this Gistener</value>
        [DataMember(Name="socialAccount", EmitDefaultValue=false)]
        public SocialAccount SocialAccount { get; set; }
    
        /// <summary>
        /// The operator queue the gistener will route to.
        /// </summary>
        /// <value>The operator queue the gistener will route to.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public Queue Queue { get; set; }
    
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
            sb.Append("class Gistener {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  AnyWords: ").Append(AnyWords).Append("\n");
            sb.Append("  AllWords: ").Append(AllWords).Append("\n");
            sb.Append("  ExcludeWords: ").Append(ExcludeWords).Append("\n");
            sb.Append("  ExactPhrase: ").Append(ExactPhrase).Append("\n");
            sb.Append("  GroupTags: ").Append(GroupTags).Append("\n");
            sb.Append("  SocialAccount: ").Append(SocialAccount).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
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
            return this.Equals(obj as Gistener);
        }

        /// <summary>
        /// Returns true if Gistener instances are equal
        /// </summary>
        /// <param name="other">Instance of Gistener to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Gistener other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.AnyWords == other.AnyWords ||
                    this.AnyWords != null &&
                    this.AnyWords.Equals(other.AnyWords)
                ) &&
                (
                    this.AllWords == other.AllWords ||
                    this.AllWords != null &&
                    this.AllWords.Equals(other.AllWords)
                ) &&
                (
                    this.ExcludeWords == other.ExcludeWords ||
                    this.ExcludeWords != null &&
                    this.ExcludeWords.Equals(other.ExcludeWords)
                ) &&
                (
                    this.ExactPhrase == other.ExactPhrase ||
                    this.ExactPhrase != null &&
                    this.ExactPhrase.Equals(other.ExactPhrase)
                ) &&
                (
                    this.GroupTags == other.GroupTags ||
                    this.GroupTags != null &&
                    this.GroupTags.SequenceEqual(other.GroupTags)
                ) &&
                (
                    this.SocialAccount == other.SocialAccount ||
                    this.SocialAccount != null &&
                    this.SocialAccount.Equals(other.SocialAccount)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
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
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.AnyWords != null)
                    hash = hash * 59 + this.AnyWords.GetHashCode();
                if (this.AllWords != null)
                    hash = hash * 59 + this.AllWords.GetHashCode();
                if (this.ExcludeWords != null)
                    hash = hash * 59 + this.ExcludeWords.GetHashCode();
                if (this.ExactPhrase != null)
                    hash = hash * 59 + this.ExactPhrase.GetHashCode();
                if (this.GroupTags != null)
                    hash = hash * 59 + this.GroupTags.GetHashCode();
                if (this.SocialAccount != null)
                    hash = hash * 59 + this.SocialAccount.GetHashCode();
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
