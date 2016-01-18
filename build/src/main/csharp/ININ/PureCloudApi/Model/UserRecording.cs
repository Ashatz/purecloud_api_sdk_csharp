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
    public class UserRecording :  IEquatable<UserRecording>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRecording" /> class.
        /// </summary>
        public UserRecording()
        {
            this.Read = false;
            
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
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ContentUri
        /// </summary>
        [DataMember(Name="contentUri", EmitDefaultValue=false)]
        public string ContentUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Workspace
        /// </summary>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public UriReference Workspace { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UriReference CreatedBy { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public Conversation Conversation { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ContentLength
        /// </summary>
        [DataMember(Name="contentLength", EmitDefaultValue=false)]
        public long? ContentLength { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DurationMilliseconds
        /// </summary>
        [DataMember(Name="durationMilliseconds", EmitDefaultValue=false)]
        public long? DurationMilliseconds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Thumbnails
        /// </summary>
        [DataMember(Name="thumbnails", EmitDefaultValue=false)]
        public List<DocumentThumbnail> Thumbnails { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }
  
        
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
            sb.Append("class UserRecording {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  DurationMilliseconds: ").Append(DurationMilliseconds).Append("\n");
            sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
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
            return this.Equals(obj as UserRecording);
        }

        /// <summary>
        /// Returns true if UserRecording instances are equal
        /// </summary>
        /// <param name="obj">Instance of UserRecording to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRecording other)
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
                    this.ContentUri == other.ContentUri ||
                    this.ContentUri != null &&
                    this.ContentUri.Equals(other.ContentUri)
                ) && 
                (
                    this.Workspace == other.Workspace ||
                    this.Workspace != null &&
                    this.Workspace.Equals(other.Workspace)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) && 
                (
                    this.ContentLength == other.ContentLength ||
                    this.ContentLength != null &&
                    this.ContentLength.Equals(other.ContentLength)
                ) && 
                (
                    this.DurationMilliseconds == other.DurationMilliseconds ||
                    this.DurationMilliseconds != null &&
                    this.DurationMilliseconds.Equals(other.DurationMilliseconds)
                ) && 
                (
                    this.Thumbnails == other.Thumbnails ||
                    this.Thumbnails != null &&
                    this.Thumbnails.SequenceEqual(other.Thumbnails)
                ) && 
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
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
                
                if (this.DateCreated != null)
                    hash = hash * 57 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 57 + this.DateModified.GetHashCode();
                
                if (this.ContentUri != null)
                    hash = hash * 57 + this.ContentUri.GetHashCode();
                
                if (this.Workspace != null)
                    hash = hash * 57 + this.Workspace.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 57 + this.CreatedBy.GetHashCode();
                
                if (this.Conversation != null)
                    hash = hash * 57 + this.Conversation.GetHashCode();
                
                if (this.ContentLength != null)
                    hash = hash * 57 + this.ContentLength.GetHashCode();
                
                if (this.DurationMilliseconds != null)
                    hash = hash * 57 + this.DurationMilliseconds.GetHashCode();
                
                if (this.Thumbnails != null)
                    hash = hash * 57 + this.Thumbnails.GetHashCode();
                
                if (this.Read != null)
                    hash = hash * 57 + this.Read.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
