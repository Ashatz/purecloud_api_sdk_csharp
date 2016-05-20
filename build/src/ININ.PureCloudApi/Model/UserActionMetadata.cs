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
    /// UserActionMetadata
    /// </summary>
    [DataContract]
    public partial class UserActionMetadata :  IEquatable<UserActionMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserActionMetadata" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Category">Category.</param>
        /// <param name="Deprecated">Deprecated (default to false).</param>
        /// <param name="Description">Description.</param>
        /// <param name="Published">Published (default to false).</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="HelpLink">HelpLink.</param>
        /// <param name="Requests">Requests.</param>
        public UserActionMetadata(string Name = null, string Category = null, bool? Deprecated = null, string Description = null, bool? Published = null, List<string> Tags = null, string HelpLink = null, List<UserActionMetadataRequest> Requests = null)
        {
            this.Name = Name;
            this.Category = Category;
            // use default value if no "Deprecated" provided
            if (Deprecated == null)
            {
                this.Deprecated = false;
            }
            else
            {
                this.Deprecated = Deprecated;
            }
            this.Description = Description;
            // use default value if no "Published" provided
            if (Published == null)
            {
                this.Published = false;
            }
            else
            {
                this.Published = Published;
            }
            this.Tags = Tags;
            this.HelpLink = HelpLink;
            this.Requests = Requests;
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
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
        /// <summary>
        /// Gets or Sets Deprecated
        /// </summary>
        [DataMember(Name="deprecated", EmitDefaultValue=false)]
        public bool? Deprecated { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }
        /// <summary>
        /// Gets or Sets HelpLink
        /// </summary>
        [DataMember(Name="helpLink", EmitDefaultValue=false)]
        public string HelpLink { get; set; }
        /// <summary>
        /// Gets or Sets Requests
        /// </summary>
        [DataMember(Name="requests", EmitDefaultValue=false)]
        public List<UserActionMetadataRequest> Requests { get; set; }
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
            sb.Append("class UserActionMetadata {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Deprecated: ").Append(Deprecated).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  HelpLink: ").Append(HelpLink).Append("\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
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
            return this.Equals(obj as UserActionMetadata);
        }

        /// <summary>
        /// Returns true if UserActionMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of UserActionMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserActionMetadata other)
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
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.Deprecated == other.Deprecated ||
                    this.Deprecated != null &&
                    this.Deprecated.Equals(other.Deprecated)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.HelpLink == other.HelpLink ||
                    this.HelpLink != null &&
                    this.HelpLink.Equals(other.HelpLink)
                ) &&
                (
                    this.Requests == other.Requests ||
                    this.Requests != null &&
                    this.Requests.SequenceEqual(other.Requests)
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
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Deprecated != null)
                    hash = hash * 59 + this.Deprecated.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.HelpLink != null)
                    hash = hash * 59 + this.HelpLink.GetHashCode();
                if (this.Requests != null)
                    hash = hash * 59 + this.Requests.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
