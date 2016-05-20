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
    /// ExpressionResponse
    /// </summary>
    [DataContract]
    public partial class ExpressionResponse :  IEquatable<ExpressionResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionResponse" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">Creation date for the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">Date the entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="SocialHub">The name of the social hub..</param>
        /// <param name="Conversation">The conversation that this response is a part of..</param>
        /// <param name="TwitterExpression">The twitter expression that this is in response to..</param>
        /// <param name="RawResponseText">The raw text of the response..</param>
        /// <param name="SocialAccount">The Social Account used to publish this expression.</param>
        /// <param name="SocialHubResponseId">The id given to this response from the social hub.</param>
        public ExpressionResponse(string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, string SocialHub = null, Conversation Conversation = null, TwitterExpression TwitterExpression = null, string RawResponseText = null, SocialAccount SocialAccount = null, string SocialHubResponseId = null)
        {
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.SocialHub = SocialHub;
            this.Conversation = Conversation;
            this.TwitterExpression = TwitterExpression;
            this.RawResponseText = RawResponseText;
            this.SocialAccount = SocialAccount;
            this.SocialHubResponseId = SocialHubResponseId;
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
        /// The name of the social hub.
        /// </summary>
        /// <value>The name of the social hub.</value>
        [DataMember(Name="socialHub", EmitDefaultValue=false)]
        public string SocialHub { get; set; }
        /// <summary>
        /// The conversation that this response is a part of.
        /// </summary>
        /// <value>The conversation that this response is a part of.</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public Conversation Conversation { get; set; }
        /// <summary>
        /// The twitter expression that this is in response to.
        /// </summary>
        /// <value>The twitter expression that this is in response to.</value>
        [DataMember(Name="twitterExpression", EmitDefaultValue=false)]
        public TwitterExpression TwitterExpression { get; set; }
        /// <summary>
        /// The raw text of the response.
        /// </summary>
        /// <value>The raw text of the response.</value>
        [DataMember(Name="rawResponseText", EmitDefaultValue=false)]
        public string RawResponseText { get; set; }
        /// <summary>
        /// The Social Account used to publish this expression
        /// </summary>
        /// <value>The Social Account used to publish this expression</value>
        [DataMember(Name="socialAccount", EmitDefaultValue=false)]
        public SocialAccount SocialAccount { get; set; }
        /// <summary>
        /// The id given to this response from the social hub
        /// </summary>
        /// <value>The id given to this response from the social hub</value>
        [DataMember(Name="socialHubResponseId", EmitDefaultValue=false)]
        public string SocialHubResponseId { get; set; }
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
            sb.Append("class ExpressionResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  SocialHub: ").Append(SocialHub).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  TwitterExpression: ").Append(TwitterExpression).Append("\n");
            sb.Append("  RawResponseText: ").Append(RawResponseText).Append("\n");
            sb.Append("  SocialAccount: ").Append(SocialAccount).Append("\n");
            sb.Append("  SocialHubResponseId: ").Append(SocialHubResponseId).Append("\n");
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
            return this.Equals(obj as ExpressionResponse);
        }

        /// <summary>
        /// Returns true if ExpressionResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ExpressionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpressionResponse other)
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
                    this.SocialHub == other.SocialHub ||
                    this.SocialHub != null &&
                    this.SocialHub.Equals(other.SocialHub)
                ) &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.TwitterExpression == other.TwitterExpression ||
                    this.TwitterExpression != null &&
                    this.TwitterExpression.Equals(other.TwitterExpression)
                ) &&
                (
                    this.RawResponseText == other.RawResponseText ||
                    this.RawResponseText != null &&
                    this.RawResponseText.Equals(other.RawResponseText)
                ) &&
                (
                    this.SocialAccount == other.SocialAccount ||
                    this.SocialAccount != null &&
                    this.SocialAccount.Equals(other.SocialAccount)
                ) &&
                (
                    this.SocialHubResponseId == other.SocialHubResponseId ||
                    this.SocialHubResponseId != null &&
                    this.SocialHubResponseId.Equals(other.SocialHubResponseId)
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
                if (this.SocialHub != null)
                    hash = hash * 59 + this.SocialHub.GetHashCode();
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();
                if (this.TwitterExpression != null)
                    hash = hash * 59 + this.TwitterExpression.GetHashCode();
                if (this.RawResponseText != null)
                    hash = hash * 59 + this.RawResponseText.GetHashCode();
                if (this.SocialAccount != null)
                    hash = hash * 59 + this.SocialAccount.GetHashCode();
                if (this.SocialHubResponseId != null)
                    hash = hash * 59 + this.SocialHubResponseId.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
