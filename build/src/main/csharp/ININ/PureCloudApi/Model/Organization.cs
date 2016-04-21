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
    public partial class Organization :  IEquatable<Organization>
    { 

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum {
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            
            [EnumMember(Value = "DELETED")]
            Deleted
        }

        

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ThirdPartyOrgId">ThirdPartyOrgId.</param>
        /// <param name="ThirdPartyOrgName">ThirdPartyOrgName.</param>
        /// <param name="ThirdPartyURI">ThirdPartyURI.</param>
        /// <param name="Domain">Domain.</param>
        /// <param name="Version">The current version of the organization. (required).</param>
        /// <param name="State">State.</param>
        /// <param name="DefaultSiteId">DefaultSiteId.</param>
        /// <param name="Deletable">Deletable (default to false).</param>

        public Organization(string Name = null, string ThirdPartyOrgId = null, string ThirdPartyOrgName = null, string ThirdPartyURI = null, string Domain = null, int? Version = null, StateEnum? State = null, string DefaultSiteId = null, bool? Deletable = null)
        {
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new InvalidDataException("Version is a required property for Organization and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            this.Name = Name;
            this.ThirdPartyOrgId = ThirdPartyOrgId;
            this.ThirdPartyOrgName = ThirdPartyOrgName;
            this.ThirdPartyURI = ThirdPartyURI;
            this.Domain = Domain;
            this.State = State;
            this.DefaultSiteId = DefaultSiteId;
            // use default value if no "Deletable" provided
            if (Deletable == null)
            {
                this.Deletable = false;
            }
            else
            {
                this.Deletable = Deletable;
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
        /// Gets or Sets ThirdPartyOrgId
        /// </summary>
        [DataMember(Name="thirdPartyOrgId", EmitDefaultValue=false)]
        public string ThirdPartyOrgId { get; set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyOrgName
        /// </summary>
        [DataMember(Name="thirdPartyOrgName", EmitDefaultValue=false)]
        public string ThirdPartyOrgName { get; set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyURI
        /// </summary>
        [DataMember(Name="thirdPartyURI", EmitDefaultValue=false)]
        public string ThirdPartyURI { get; set; }
    
        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }
    
        /// <summary>
        /// The current version of the organization.
        /// </summary>
        /// <value>The current version of the organization.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
    
        /// <summary>
        /// Gets or Sets DefaultSiteId
        /// </summary>
        [DataMember(Name="defaultSiteId", EmitDefaultValue=false)]
        public string DefaultSiteId { get; set; }
    
        /// <summary>
        /// Gets or Sets Deletable
        /// </summary>
        [DataMember(Name="deletable", EmitDefaultValue=false)]
        public bool? Deletable { get; set; }
    
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
            sb.Append("class Organization {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ThirdPartyOrgId: ").Append(ThirdPartyOrgId).Append("\n");
            sb.Append("  ThirdPartyOrgName: ").Append(ThirdPartyOrgName).Append("\n");
            sb.Append("  ThirdPartyURI: ").Append(ThirdPartyURI).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DefaultSiteId: ").Append(DefaultSiteId).Append("\n");
            sb.Append("  Deletable: ").Append(Deletable).Append("\n");
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
            return this.Equals(obj as Organization);
        }

        /// <summary>
        /// Returns true if Organization instances are equal
        /// </summary>
        /// <param name="other">Instance of Organization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Organization other)
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
                    this.ThirdPartyOrgId == other.ThirdPartyOrgId ||
                    this.ThirdPartyOrgId != null &&
                    this.ThirdPartyOrgId.Equals(other.ThirdPartyOrgId)
                ) &&
                (
                    this.ThirdPartyOrgName == other.ThirdPartyOrgName ||
                    this.ThirdPartyOrgName != null &&
                    this.ThirdPartyOrgName.Equals(other.ThirdPartyOrgName)
                ) &&
                (
                    this.ThirdPartyURI == other.ThirdPartyURI ||
                    this.ThirdPartyURI != null &&
                    this.ThirdPartyURI.Equals(other.ThirdPartyURI)
                ) &&
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.DefaultSiteId == other.DefaultSiteId ||
                    this.DefaultSiteId != null &&
                    this.DefaultSiteId.Equals(other.DefaultSiteId)
                ) &&
                (
                    this.Deletable == other.Deletable ||
                    this.Deletable != null &&
                    this.Deletable.Equals(other.Deletable)
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
                if (this.ThirdPartyOrgId != null)
                    hash = hash * 59 + this.ThirdPartyOrgId.GetHashCode();
                if (this.ThirdPartyOrgName != null)
                    hash = hash * 59 + this.ThirdPartyOrgName.GetHashCode();
                if (this.ThirdPartyURI != null)
                    hash = hash * 59 + this.ThirdPartyURI.GetHashCode();
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.DefaultSiteId != null)
                    hash = hash * 59 + this.DefaultSiteId.GetHashCode();
                if (this.Deletable != null)
                    hash = hash * 59 + this.Deletable.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
