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
    /// Relationship
    /// </summary>
    [DataContract]
    public partial class Relationship :  IEquatable<Relationship>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationship" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Relationship() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationship" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="User">The user associated with the external organization (required).</param>
        /// <param name="ExternalOrganization">The external organization this relationship is attached to (required).</param>
        /// <param name="_Relationship">The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant (required).</param>
        public Relationship(string Name = null, User User = null, ExternalOrganization ExternalOrganization = null, string _Relationship = null)
        {
            // to ensure "User" is required (not null)
            if (User == null)
            {
                throw new InvalidDataException("User is a required property for Relationship and cannot be null");
            }
            else
            {
                this.User = User;
            }
            // to ensure "ExternalOrganization" is required (not null)
            if (ExternalOrganization == null)
            {
                throw new InvalidDataException("ExternalOrganization is a required property for Relationship and cannot be null");
            }
            else
            {
                this.ExternalOrganization = ExternalOrganization;
            }
            // to ensure "_Relationship" is required (not null)
            if (_Relationship == null)
            {
                throw new InvalidDataException("_Relationship is a required property for Relationship and cannot be null");
            }
            else
            {
                this._Relationship = _Relationship;
            }
            this.Name = Name;
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
        /// The user associated with the external organization
        /// </summary>
        /// <value>The user associated with the external organization</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        /// <summary>
        /// The external organization this relationship is attached to
        /// </summary>
        /// <value>The external organization this relationship is attached to</value>
        [DataMember(Name="externalOrganization", EmitDefaultValue=false)]
        public ExternalOrganization ExternalOrganization { get; set; }
        /// <summary>
        /// The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant
        /// </summary>
        /// <value>The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant</value>
        [DataMember(Name="relationship", EmitDefaultValue=false)]
        public string _Relationship { get; set; }
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
            sb.Append("class Relationship {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
            sb.Append("  _Relationship: ").Append(_Relationship).Append("\n");
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
            return this.Equals(obj as Relationship);
        }

        /// <summary>
        /// Returns true if Relationship instances are equal
        /// </summary>
        /// <param name="other">Instance of Relationship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Relationship other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.ExternalOrganization == other.ExternalOrganization ||
                    this.ExternalOrganization != null &&
                    this.ExternalOrganization.Equals(other.ExternalOrganization)
                ) &&
                (
                    this._Relationship == other._Relationship ||
                    this._Relationship != null &&
                    this._Relationship.Equals(other._Relationship)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.ExternalOrganization != null)
                    hash = hash * 59 + this.ExternalOrganization.GetHashCode();
                if (this._Relationship != null)
                    hash = hash * 59 + this._Relationship.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
