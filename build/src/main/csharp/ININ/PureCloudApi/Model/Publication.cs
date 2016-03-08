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
    public partial class Publication :  IEquatable<Publication>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Publication" /> class.
        /// Initializes a new instance of the <see cref="Publication" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">Creation date for the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">Date the entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="TweetText">The text of the tweet..</param>
        /// <param name="RawTweetText">The raw text of the tweet.</param>
        /// <param name="Approved">Approved (default to false).</param>

        public Publication(string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, string TweetText = null, string RawTweetText = null, bool? Approved = null, )
        {
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.TweetText = TweetText;
            this.RawTweetText = RawTweetText;
            // use default value if no "Approved" provided
            if (Approved == null)
            {
                this.Approved = false;
            }
            else
            {
                this.Approved = Approved;
            }
            
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
        /// The text of the tweet.
        /// </summary>
        /// <value>The text of the tweet.</value>
        [DataMember(Name="tweetText", EmitDefaultValue=false)]
        public string TweetText { get; set; }
    
        /// <summary>
        /// The raw text of the tweet
        /// </summary>
        /// <value>The raw text of the tweet</value>
        [DataMember(Name="rawTweetText", EmitDefaultValue=false)]
        public string RawTweetText { get; set; }
    
        /// <summary>
        /// Gets or Sets Approved
        /// </summary>
        [DataMember(Name="approved", EmitDefaultValue=false)]
        public bool? Approved { get; set; }
    
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
            sb.Append("class Publication {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  TweetText: ").Append(TweetText).Append("\n");
            sb.Append("  RawTweetText: ").Append(RawTweetText).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
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
            return this.Equals(obj as Publication);
        }

        /// <summary>
        /// Returns true if Publication instances are equal
        /// </summary>
        /// <param name="other">Instance of Publication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Publication other)
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
                    this.TweetText == other.TweetText ||
                    this.TweetText != null &&
                    this.TweetText.Equals(other.TweetText)
                ) && 
                (
                    this.RawTweetText == other.RawTweetText ||
                    this.RawTweetText != null &&
                    this.RawTweetText.Equals(other.RawTweetText)
                ) && 
                (
                    this.Approved == other.Approved ||
                    this.Approved != null &&
                    this.Approved.Equals(other.Approved)
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
                
                if (this.TweetText != null)
                    hash = hash * 59 + this.TweetText.GetHashCode();
                
                if (this.RawTweetText != null)
                    hash = hash * 59 + this.RawTweetText.GetHashCode();
                
                if (this.Approved != null)
                    hash = hash * 59 + this.Approved.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
