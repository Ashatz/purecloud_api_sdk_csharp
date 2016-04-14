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
    public partial class TwitterExpression :  IEquatable<TwitterExpression>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterExpression" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">Creation date for the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">Date the entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="IsDispositioned">True once the expression has been dispositioned by an agent through the ACD process (default to false).</param>
        /// <param name="IsNoise">Indicates if a user/agent found this expression to be undesirable (default to false).</param>
        /// <param name="Gistener">The Gistener that generated this expression.</param>
        /// <param name="TweetId">Twitter: the tweet&#39;s unique id.</param>
        /// <param name="Text">Twitter: the tweets full text.</param>
        /// <param name="TweetCreated">Twitter: the date the tweet was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="IsReply">Twitter: indicates this tweet as a reply to another tweet (default to false).</param>
        /// <param name="IsRetweet">Twitter: indicates this tweet as a &#39;retweet&#39; of another tweet (default to false).</param>
        /// <param name="RetweetParentId">Twitter: when the expression is a retweet, this is Twitter&#39;s id of the original tweet.</param>
        /// <param name="RetweetCount">Twitter: the number of times the parent tweet was retweeted - at the time this expression was created.</param>
        /// <param name="IsQuotedTweet">Twitter: indicates this expression as a quoted tweet (a tweet with an addendum as the primary text) (default to false).</param>
        /// <param name="QuotedParentId">Twitter: when the expression is a quoted tweet, this is Twitter&#39;s id of the original tweet (may not be immediately functional).</param>
        /// <param name="UserId">Twitter: the expressing user&#39;s Twitter id.</param>
        /// <param name="UserName">Twitter: the user&#39;s account name for the core service.</param>
        /// <param name="UserScreenName">Twitter: the user&#39;s custom &#39;branding&#39; name (allowed to change over time).</param>
        /// <param name="UserTweetCount">Twitter: the number of times this user has tweeted (includes all forms of expression replies/quotes/retweets).</param>
        /// <param name="UserFollowersCount">Twitter: the number of followers this user has at the time of this expression.</param>
        /// <param name="GroupTags">The Group Tags applied by the generating Gistener.</param>
        /// <param name="Routed">Routed (default to false).</param>

        public TwitterExpression(string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, bool? IsDispositioned = null, bool? IsNoise = null, Gistener Gistener = null, string TweetId = null, string Text = null, DateTime? TweetCreated = null, bool? IsReply = null, bool? IsRetweet = null, string RetweetParentId = null, int? RetweetCount = null, bool? IsQuotedTweet = null, string QuotedParentId = null, string UserId = null, string UserName = null, string UserScreenName = null, int? UserTweetCount = null, int? UserFollowersCount = null, List<GroupTag> GroupTags = null, bool? Routed = null)
        {
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            // use default value if no "IsDispositioned" provided
            if (IsDispositioned == null)
            {
                this.IsDispositioned = false;
            }
            else
            {
                this.IsDispositioned = IsDispositioned;
            }
            // use default value if no "IsNoise" provided
            if (IsNoise == null)
            {
                this.IsNoise = false;
            }
            else
            {
                this.IsNoise = IsNoise;
            }
            this.Gistener = Gistener;
            this.TweetId = TweetId;
            this.Text = Text;
            this.TweetCreated = TweetCreated;
            // use default value if no "IsReply" provided
            if (IsReply == null)
            {
                this.IsReply = false;
            }
            else
            {
                this.IsReply = IsReply;
            }
            // use default value if no "IsRetweet" provided
            if (IsRetweet == null)
            {
                this.IsRetweet = false;
            }
            else
            {
                this.IsRetweet = IsRetweet;
            }
            this.RetweetParentId = RetweetParentId;
            this.RetweetCount = RetweetCount;
            // use default value if no "IsQuotedTweet" provided
            if (IsQuotedTweet == null)
            {
                this.IsQuotedTweet = false;
            }
            else
            {
                this.IsQuotedTweet = IsQuotedTweet;
            }
            this.QuotedParentId = QuotedParentId;
            this.UserId = UserId;
            this.UserName = UserName;
            this.UserScreenName = UserScreenName;
            this.UserTweetCount = UserTweetCount;
            this.UserFollowersCount = UserFollowersCount;
            this.GroupTags = GroupTags;
            // use default value if no "Routed" provided
            if (Routed == null)
            {
                this.Routed = false;
            }
            else
            {
                this.Routed = Routed;
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
        /// True once the expression has been dispositioned by an agent through the ACD process
        /// </summary>
        /// <value>True once the expression has been dispositioned by an agent through the ACD process</value>
        [DataMember(Name="isDispositioned", EmitDefaultValue=false)]
        public bool? IsDispositioned { get; set; }
    
        /// <summary>
        /// Indicates if a user/agent found this expression to be undesirable
        /// </summary>
        /// <value>Indicates if a user/agent found this expression to be undesirable</value>
        [DataMember(Name="isNoise", EmitDefaultValue=false)]
        public bool? IsNoise { get; set; }
    
        /// <summary>
        /// The Gistener that generated this expression
        /// </summary>
        /// <value>The Gistener that generated this expression</value>
        [DataMember(Name="gistener", EmitDefaultValue=false)]
        public Gistener Gistener { get; set; }
    
        /// <summary>
        /// Twitter: the tweet&#39;s unique id
        /// </summary>
        /// <value>Twitter: the tweet&#39;s unique id</value>
        [DataMember(Name="tweetId", EmitDefaultValue=false)]
        public string TweetId { get; set; }
    
        /// <summary>
        /// Twitter: the tweets full text
        /// </summary>
        /// <value>Twitter: the tweets full text</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
    
        /// <summary>
        /// Twitter: the date the tweet was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Twitter: the date the tweet was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="tweetCreated", EmitDefaultValue=false)]
        public DateTime? TweetCreated { get; set; }
    
        /// <summary>
        /// Twitter: indicates this tweet as a reply to another tweet
        /// </summary>
        /// <value>Twitter: indicates this tweet as a reply to another tweet</value>
        [DataMember(Name="isReply", EmitDefaultValue=false)]
        public bool? IsReply { get; set; }
    
        /// <summary>
        /// Twitter: indicates this tweet as a &#39;retweet&#39; of another tweet
        /// </summary>
        /// <value>Twitter: indicates this tweet as a &#39;retweet&#39; of another tweet</value>
        [DataMember(Name="isRetweet", EmitDefaultValue=false)]
        public bool? IsRetweet { get; set; }
    
        /// <summary>
        /// Twitter: when the expression is a retweet, this is Twitter&#39;s id of the original tweet
        /// </summary>
        /// <value>Twitter: when the expression is a retweet, this is Twitter&#39;s id of the original tweet</value>
        [DataMember(Name="retweetParentId", EmitDefaultValue=false)]
        public string RetweetParentId { get; set; }
    
        /// <summary>
        /// Twitter: the number of times the parent tweet was retweeted - at the time this expression was created
        /// </summary>
        /// <value>Twitter: the number of times the parent tweet was retweeted - at the time this expression was created</value>
        [DataMember(Name="retweetCount", EmitDefaultValue=false)]
        public int? RetweetCount { get; set; }
    
        /// <summary>
        /// Twitter: indicates this expression as a quoted tweet (a tweet with an addendum as the primary text)
        /// </summary>
        /// <value>Twitter: indicates this expression as a quoted tweet (a tweet with an addendum as the primary text)</value>
        [DataMember(Name="isQuotedTweet", EmitDefaultValue=false)]
        public bool? IsQuotedTweet { get; set; }
    
        /// <summary>
        /// Twitter: when the expression is a quoted tweet, this is Twitter&#39;s id of the original tweet (may not be immediately functional)
        /// </summary>
        /// <value>Twitter: when the expression is a quoted tweet, this is Twitter&#39;s id of the original tweet (may not be immediately functional)</value>
        [DataMember(Name="quotedParentId", EmitDefaultValue=false)]
        public string QuotedParentId { get; set; }
    
        /// <summary>
        /// Twitter: the expressing user&#39;s Twitter id
        /// </summary>
        /// <value>Twitter: the expressing user&#39;s Twitter id</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Twitter: the user&#39;s account name for the core service
        /// </summary>
        /// <value>Twitter: the user&#39;s account name for the core service</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
    
        /// <summary>
        /// Twitter: the user&#39;s custom &#39;branding&#39; name (allowed to change over time)
        /// </summary>
        /// <value>Twitter: the user&#39;s custom &#39;branding&#39; name (allowed to change over time)</value>
        [DataMember(Name="userScreenName", EmitDefaultValue=false)]
        public string UserScreenName { get; set; }
    
        /// <summary>
        /// Twitter: the number of times this user has tweeted (includes all forms of expression replies/quotes/retweets)
        /// </summary>
        /// <value>Twitter: the number of times this user has tweeted (includes all forms of expression replies/quotes/retweets)</value>
        [DataMember(Name="userTweetCount", EmitDefaultValue=false)]
        public int? UserTweetCount { get; set; }
    
        /// <summary>
        /// Twitter: the number of followers this user has at the time of this expression
        /// </summary>
        /// <value>Twitter: the number of followers this user has at the time of this expression</value>
        [DataMember(Name="userFollowersCount", EmitDefaultValue=false)]
        public int? UserFollowersCount { get; set; }
    
        /// <summary>
        /// The Group Tags applied by the generating Gistener
        /// </summary>
        /// <value>The Group Tags applied by the generating Gistener</value>
        [DataMember(Name="groupTags", EmitDefaultValue=false)]
        public List<GroupTag> GroupTags { get; set; }
    
        /// <summary>
        /// Gets or Sets Routed
        /// </summary>
        [DataMember(Name="routed", EmitDefaultValue=false)]
        public bool? Routed { get; set; }
    
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
            sb.Append("class TwitterExpression {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  IsDispositioned: ").Append(IsDispositioned).Append("\n");
            sb.Append("  IsNoise: ").Append(IsNoise).Append("\n");
            sb.Append("  Gistener: ").Append(Gistener).Append("\n");
            sb.Append("  TweetId: ").Append(TweetId).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  TweetCreated: ").Append(TweetCreated).Append("\n");
            sb.Append("  IsReply: ").Append(IsReply).Append("\n");
            sb.Append("  IsRetweet: ").Append(IsRetweet).Append("\n");
            sb.Append("  RetweetParentId: ").Append(RetweetParentId).Append("\n");
            sb.Append("  RetweetCount: ").Append(RetweetCount).Append("\n");
            sb.Append("  IsQuotedTweet: ").Append(IsQuotedTweet).Append("\n");
            sb.Append("  QuotedParentId: ").Append(QuotedParentId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserScreenName: ").Append(UserScreenName).Append("\n");
            sb.Append("  UserTweetCount: ").Append(UserTweetCount).Append("\n");
            sb.Append("  UserFollowersCount: ").Append(UserFollowersCount).Append("\n");
            sb.Append("  GroupTags: ").Append(GroupTags).Append("\n");
            sb.Append("  Routed: ").Append(Routed).Append("\n");
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
            return this.Equals(obj as TwitterExpression);
        }

        /// <summary>
        /// Returns true if TwitterExpression instances are equal
        /// </summary>
        /// <param name="other">Instance of TwitterExpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwitterExpression other)
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
                    this.IsDispositioned == other.IsDispositioned ||
                    this.IsDispositioned != null &&
                    this.IsDispositioned.Equals(other.IsDispositioned)
                ) &&
                (
                    this.IsNoise == other.IsNoise ||
                    this.IsNoise != null &&
                    this.IsNoise.Equals(other.IsNoise)
                ) &&
                (
                    this.Gistener == other.Gistener ||
                    this.Gistener != null &&
                    this.Gistener.Equals(other.Gistener)
                ) &&
                (
                    this.TweetId == other.TweetId ||
                    this.TweetId != null &&
                    this.TweetId.Equals(other.TweetId)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.TweetCreated == other.TweetCreated ||
                    this.TweetCreated != null &&
                    this.TweetCreated.Equals(other.TweetCreated)
                ) &&
                (
                    this.IsReply == other.IsReply ||
                    this.IsReply != null &&
                    this.IsReply.Equals(other.IsReply)
                ) &&
                (
                    this.IsRetweet == other.IsRetweet ||
                    this.IsRetweet != null &&
                    this.IsRetweet.Equals(other.IsRetweet)
                ) &&
                (
                    this.RetweetParentId == other.RetweetParentId ||
                    this.RetweetParentId != null &&
                    this.RetweetParentId.Equals(other.RetweetParentId)
                ) &&
                (
                    this.RetweetCount == other.RetweetCount ||
                    this.RetweetCount != null &&
                    this.RetweetCount.Equals(other.RetweetCount)
                ) &&
                (
                    this.IsQuotedTweet == other.IsQuotedTweet ||
                    this.IsQuotedTweet != null &&
                    this.IsQuotedTweet.Equals(other.IsQuotedTweet)
                ) &&
                (
                    this.QuotedParentId == other.QuotedParentId ||
                    this.QuotedParentId != null &&
                    this.QuotedParentId.Equals(other.QuotedParentId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) &&
                (
                    this.UserScreenName == other.UserScreenName ||
                    this.UserScreenName != null &&
                    this.UserScreenName.Equals(other.UserScreenName)
                ) &&
                (
                    this.UserTweetCount == other.UserTweetCount ||
                    this.UserTweetCount != null &&
                    this.UserTweetCount.Equals(other.UserTweetCount)
                ) &&
                (
                    this.UserFollowersCount == other.UserFollowersCount ||
                    this.UserFollowersCount != null &&
                    this.UserFollowersCount.Equals(other.UserFollowersCount)
                ) &&
                (
                    this.GroupTags == other.GroupTags ||
                    this.GroupTags != null &&
                    this.GroupTags.SequenceEqual(other.GroupTags)
                ) &&
                (
                    this.Routed == other.Routed ||
                    this.Routed != null &&
                    this.Routed.Equals(other.Routed)
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
                if (this.IsDispositioned != null)
                    hash = hash * 59 + this.IsDispositioned.GetHashCode();
                if (this.IsNoise != null)
                    hash = hash * 59 + this.IsNoise.GetHashCode();
                if (this.Gistener != null)
                    hash = hash * 59 + this.Gistener.GetHashCode();
                if (this.TweetId != null)
                    hash = hash * 59 + this.TweetId.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.TweetCreated != null)
                    hash = hash * 59 + this.TweetCreated.GetHashCode();
                if (this.IsReply != null)
                    hash = hash * 59 + this.IsReply.GetHashCode();
                if (this.IsRetweet != null)
                    hash = hash * 59 + this.IsRetweet.GetHashCode();
                if (this.RetweetParentId != null)
                    hash = hash * 59 + this.RetweetParentId.GetHashCode();
                if (this.RetweetCount != null)
                    hash = hash * 59 + this.RetweetCount.GetHashCode();
                if (this.IsQuotedTweet != null)
                    hash = hash * 59 + this.IsQuotedTweet.GetHashCode();
                if (this.QuotedParentId != null)
                    hash = hash * 59 + this.QuotedParentId.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.UserScreenName != null)
                    hash = hash * 59 + this.UserScreenName.GetHashCode();
                if (this.UserTweetCount != null)
                    hash = hash * 59 + this.UserTweetCount.GetHashCode();
                if (this.UserFollowersCount != null)
                    hash = hash * 59 + this.UserFollowersCount.GetHashCode();
                if (this.GroupTags != null)
                    hash = hash * 59 + this.GroupTags.GetHashCode();
                if (this.Routed != null)
                    hash = hash * 59 + this.Routed.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
