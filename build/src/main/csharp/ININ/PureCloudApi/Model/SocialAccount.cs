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
    public partial class SocialAccount :  IEquatable<SocialAccount>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialAccount" /> class.
        /// Initializes a new instance of the <see cref="SocialAccount" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">Creation date for the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">Date the entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Enabled">Indicates if this Social Account is available for selection by other entities (default to false).</param>
        /// <param name="Authorized">True when successfully completing the third-party authorization process (default to false).</param>
        /// <param name="SocialHub">Which third party Social Media Hub this account will be communicating through.</param>
        /// <param name="AccessToken">Credential provided through the Social Hub&#39;s authorization process.</param>
        /// <param name="AccessTokenSecret">Credential provided through the Social Hub&#39;s authorization process.</param>
        /// <param name="TwitterId">The account ID as provided by Twitter during the authorization process.</param>
        /// <param name="StreamingEnabled">Indicates if a stream should be opened on behalf of the indicated Social Hub account (default to false).</param>

        public SocialAccount(string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, bool? Enabled = null, bool? Authorized = null, string SocialHub = null, string AccessToken = null, string AccessTokenSecret = null, string TwitterId = null, bool? StreamingEnabled = null, )
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
            // use default value if no "Authorized" provided
            if (Authorized == null)
            {
                this.Authorized = false;
            }
            else
            {
                this.Authorized = Authorized;
            }
            this.SocialHub = SocialHub;
            this.AccessToken = AccessToken;
            this.AccessTokenSecret = AccessTokenSecret;
            this.TwitterId = TwitterId;
            // use default value if no "StreamingEnabled" provided
            if (StreamingEnabled == null)
            {
                this.StreamingEnabled = false;
            }
            else
            {
                this.StreamingEnabled = StreamingEnabled;
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
        /// Indicates if this Social Account is available for selection by other entities
        /// </summary>
        /// <value>Indicates if this Social Account is available for selection by other entities</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// True when successfully completing the third-party authorization process
        /// </summary>
        /// <value>True when successfully completing the third-party authorization process</value>
        [DataMember(Name="authorized", EmitDefaultValue=false)]
        public bool? Authorized { get; set; }
    
        /// <summary>
        /// Which third party Social Media Hub this account will be communicating through
        /// </summary>
        /// <value>Which third party Social Media Hub this account will be communicating through</value>
        [DataMember(Name="socialHub", EmitDefaultValue=false)]
        public string SocialHub { get; set; }
    
        /// <summary>
        /// Credential provided through the Social Hub's authorization process
        /// </summary>
        /// <value>Credential provided through the Social Hub's authorization process</value>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
    
        /// <summary>
        /// Credential provided through the Social Hub's authorization process
        /// </summary>
        /// <value>Credential provided through the Social Hub's authorization process</value>
        [DataMember(Name="access_token_secret", EmitDefaultValue=false)]
        public string AccessTokenSecret { get; set; }
    
        /// <summary>
        /// The account ID as provided by Twitter during the authorization process
        /// </summary>
        /// <value>The account ID as provided by Twitter during the authorization process</value>
        [DataMember(Name="twitterId", EmitDefaultValue=false)]
        public string TwitterId { get; set; }
    
        /// <summary>
        /// Indicates if a stream should be opened on behalf of the indicated Social Hub account
        /// </summary>
        /// <value>Indicates if a stream should be opened on behalf of the indicated Social Hub account</value>
        [DataMember(Name="streamingEnabled", EmitDefaultValue=false)]
        public bool? StreamingEnabled { get; set; }
    
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
            sb.Append("class SocialAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Authorized: ").Append(Authorized).Append("\n");
            sb.Append("  SocialHub: ").Append(SocialHub).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  AccessTokenSecret: ").Append(AccessTokenSecret).Append("\n");
            sb.Append("  TwitterId: ").Append(TwitterId).Append("\n");
            sb.Append("  StreamingEnabled: ").Append(StreamingEnabled).Append("\n");
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
            return this.Equals(obj as SocialAccount);
        }

        /// <summary>
        /// Returns true if SocialAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of SocialAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocialAccount other)
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
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Authorized == other.Authorized ||
                    this.Authorized != null &&
                    this.Authorized.Equals(other.Authorized)
                ) && 
                (
                    this.SocialHub == other.SocialHub ||
                    this.SocialHub != null &&
                    this.SocialHub.Equals(other.SocialHub)
                ) && 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.AccessTokenSecret == other.AccessTokenSecret ||
                    this.AccessTokenSecret != null &&
                    this.AccessTokenSecret.Equals(other.AccessTokenSecret)
                ) && 
                (
                    this.TwitterId == other.TwitterId ||
                    this.TwitterId != null &&
                    this.TwitterId.Equals(other.TwitterId)
                ) && 
                (
                    this.StreamingEnabled == other.StreamingEnabled ||
                    this.StreamingEnabled != null &&
                    this.StreamingEnabled.Equals(other.StreamingEnabled)
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
                
                if (this.Authorized != null)
                    hash = hash * 59 + this.Authorized.GetHashCode();
                
                if (this.SocialHub != null)
                    hash = hash * 59 + this.SocialHub.GetHashCode();
                
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                
                if (this.AccessTokenSecret != null)
                    hash = hash * 59 + this.AccessTokenSecret.GetHashCode();
                
                if (this.TwitterId != null)
                    hash = hash * 59 + this.TwitterId.GetHashCode();
                
                if (this.StreamingEnabled != null)
                    hash = hash * 59 + this.StreamingEnabled.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
