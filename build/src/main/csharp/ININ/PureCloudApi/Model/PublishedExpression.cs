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
    public class PublishedExpression :  IEquatable<PublishedExpression>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedExpression" /> class.
        /// </summary>
        public PublishedExpression()
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
        /// The name of the social hub.
        /// </summary>
        /// <value>The name of the social hub.</value>
        [DataMember(Name="socialHub", EmitDefaultValue=false)]
        public string SocialHub { get; set; }
  
        
        /// <summary>
        /// Once this expression is published, the Social Hub returns a resulting twitterExpression object.
        /// </summary>
        /// <value>Once this expression is published, the Social Hub returns a resulting twitterExpression object.</value>
        [DataMember(Name="twitterExpression", EmitDefaultValue=false)]
        public TwitterExpression TwitterExpression { get; set; }
  
        
        /// <summary>
        /// When this expression is used by the Direct Publishing feature, this is our internal id of the Publication that generated this published expression
        /// </summary>
        /// <value>When this expression is used by the Direct Publishing feature, this is our internal id of the Publication that generated this published expression</value>
        [DataMember(Name="publicationParentId", EmitDefaultValue=false)]
        public string PublicationParentId { get; set; }
  
        
        /// <summary>
        /// Used by the Scheduling feature:  The date that this expression should be published through the Social Hub. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Used by the Scheduling feature:  The date that this expression should be published through the Social Hub. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="scheduleDate", EmitDefaultValue=false)]
        public DateTime? ScheduleDate { get; set; }
  
        
        /// <summary>
        /// The date this expression was published through the Social Hub. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date this expression was published through the Social Hub. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="publishedDate", EmitDefaultValue=false)]
        public DateTime? PublishedDate { get; set; }
  
        
        /// <summary>
        /// The Social Account used to publish this expression
        /// </summary>
        /// <value>The Social Account used to publish this expression</value>
        [DataMember(Name="socialAccount", EmitDefaultValue=false)]
        public SocialAccount SocialAccount { get; set; }
  
        
        /// <summary>
        /// When replying to an existing tweet:  Twitter's id of the tweet that this expression was replying to
        /// </summary>
        /// <value>When replying to an existing tweet:  Twitter's id of the tweet that this expression was replying to</value>
        [DataMember(Name="twitterId", EmitDefaultValue=false)]
        public string TwitterId { get; set; }
  
        
        /// <summary>
        /// The number of times this published expression has been retweeted.
        /// </summary>
        /// <value>The number of times this published expression has been retweeted.</value>
        [DataMember(Name="retweets", EmitDefaultValue=false)]
        public int? Retweets { get; set; }
  
        
        /// <summary>
        /// A collection of Twitter Tweet Id's that have replied to this published expression
        /// </summary>
        /// <value>A collection of Twitter Tweet Id's that have replied to this published expression</value>
        [DataMember(Name="replies", EmitDefaultValue=false)]
        public List<string> Replies { get; set; }
  
        
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
            sb.Append("class PublishedExpression {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  SocialHub: ").Append(SocialHub).Append("\n");
            sb.Append("  TwitterExpression: ").Append(TwitterExpression).Append("\n");
            sb.Append("  PublicationParentId: ").Append(PublicationParentId).Append("\n");
            sb.Append("  ScheduleDate: ").Append(ScheduleDate).Append("\n");
            sb.Append("  PublishedDate: ").Append(PublishedDate).Append("\n");
            sb.Append("  SocialAccount: ").Append(SocialAccount).Append("\n");
            sb.Append("  TwitterId: ").Append(TwitterId).Append("\n");
            sb.Append("  Retweets: ").Append(Retweets).Append("\n");
            sb.Append("  Replies: ").Append(Replies).Append("\n");
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
            return this.Equals(obj as PublishedExpression);
        }

        /// <summary>
        /// Returns true if PublishedExpression instances are equal
        /// </summary>
        /// <param name="obj">Instance of PublishedExpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublishedExpression other)
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
                    this.SocialHub == other.SocialHub ||
                    this.SocialHub != null &&
                    this.SocialHub.Equals(other.SocialHub)
                ) && 
                (
                    this.TwitterExpression == other.TwitterExpression ||
                    this.TwitterExpression != null &&
                    this.TwitterExpression.Equals(other.TwitterExpression)
                ) && 
                (
                    this.PublicationParentId == other.PublicationParentId ||
                    this.PublicationParentId != null &&
                    this.PublicationParentId.Equals(other.PublicationParentId)
                ) && 
                (
                    this.ScheduleDate == other.ScheduleDate ||
                    this.ScheduleDate != null &&
                    this.ScheduleDate.Equals(other.ScheduleDate)
                ) && 
                (
                    this.PublishedDate == other.PublishedDate ||
                    this.PublishedDate != null &&
                    this.PublishedDate.Equals(other.PublishedDate)
                ) && 
                (
                    this.SocialAccount == other.SocialAccount ||
                    this.SocialAccount != null &&
                    this.SocialAccount.Equals(other.SocialAccount)
                ) && 
                (
                    this.TwitterId == other.TwitterId ||
                    this.TwitterId != null &&
                    this.TwitterId.Equals(other.TwitterId)
                ) && 
                (
                    this.Retweets == other.Retweets ||
                    this.Retweets != null &&
                    this.Retweets.Equals(other.Retweets)
                ) && 
                (
                    this.Replies == other.Replies ||
                    this.Replies != null &&
                    this.Replies.SequenceEqual(other.Replies)
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
                
                if (this.SocialHub != null)
                    hash = hash * 57 + this.SocialHub.GetHashCode();
                
                if (this.TwitterExpression != null)
                    hash = hash * 57 + this.TwitterExpression.GetHashCode();
                
                if (this.PublicationParentId != null)
                    hash = hash * 57 + this.PublicationParentId.GetHashCode();
                
                if (this.ScheduleDate != null)
                    hash = hash * 57 + this.ScheduleDate.GetHashCode();
                
                if (this.PublishedDate != null)
                    hash = hash * 57 + this.PublishedDate.GetHashCode();
                
                if (this.SocialAccount != null)
                    hash = hash * 57 + this.SocialAccount.GetHashCode();
                
                if (this.TwitterId != null)
                    hash = hash * 57 + this.TwitterId.GetHashCode();
                
                if (this.Retweets != null)
                    hash = hash * 57 + this.Retweets.GetHashCode();
                
                if (this.Replies != null)
                    hash = hash * 57 + this.Replies.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
