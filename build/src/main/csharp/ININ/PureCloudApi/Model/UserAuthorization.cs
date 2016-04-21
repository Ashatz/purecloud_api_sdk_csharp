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
    public partial class UserAuthorization :  IEquatable<UserAuthorization>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuthorization" />class.
        /// </summary>
<<<<<<< HEAD
        /// <param name="Name">Name.</param>
        /// <param name="Licenses">Licenses.</param>
        /// <param name="Roles">Roles.</param>
        /// <param name="Permissions">Permissions.</param>
        /// <param name="PermissionPolicies">PermissionPolicies.</param>

        public UserAuthorization(string Name = null, List<string> Licenses = null, List<string> Roles = null, List<string> Permissions = null, List<ResourcePermissionPolicy> PermissionPolicies = null)
        {
            this.Name = Name;
            this.Licenses = Licenses;
=======
        /// <param name="Roles">Roles.</param>
        /// <param name="Permissions">A collection of the permissions granted by all assigned roles.</param>
        /// <param name="PermissionPolicies">The policies configured for assigned permissions..</param>

        public UserAuthorization(List<DomainRole> Roles = null, List<string> Permissions = null, List<ResourcePermissionPolicy> PermissionPolicies = null)
        {
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            this.Roles = Roles;
            this.Permissions = Permissions;
            this.PermissionPolicies = PermissionPolicies;
            
        }

    
<<<<<<< HEAD
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
        /// Gets or Sets Licenses
        /// </summary>
        [DataMember(Name="licenses", EmitDefaultValue=false)]
        public List<string> Licenses { get; set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
<<<<<<< HEAD
        public List<string> Roles { get; set; }
=======
        public List<DomainRole> Roles { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// A collection of the permissions granted by all assigned roles
        /// </summary>
        /// <value>A collection of the permissions granted by all assigned roles</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; set; }
    
        /// <summary>
        /// The policies configured for assigned permissions.
        /// </summary>
        /// <value>The policies configured for assigned permissions.</value>
        [DataMember(Name="permissionPolicies", EmitDefaultValue=false)]
        public List<ResourcePermissionPolicy> PermissionPolicies { get; set; }
    
<<<<<<< HEAD
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAuthorization {\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  PermissionPolicies: ").Append(PermissionPolicies).Append("\n");
<<<<<<< HEAD
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            return this.Equals(obj as UserAuthorization);
        }

        /// <summary>
        /// Returns true if UserAuthorization instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAuthorization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAuthorization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
<<<<<<< HEAD
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
                    this.Licenses == other.Licenses ||
                    this.Licenses != null &&
                    this.Licenses.SequenceEqual(other.Licenses)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
                ) &&
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
                ) &&
                (
                    this.PermissionPolicies == other.PermissionPolicies ||
                    this.PermissionPolicies != null &&
                    this.PermissionPolicies.SequenceEqual(other.PermissionPolicies)
<<<<<<< HEAD
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Licenses != null)
                    hash = hash * 59 + this.Licenses.GetHashCode();
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                if (this.PermissionPolicies != null)
                    hash = hash * 59 + this.PermissionPolicies.GetHashCode();
<<<<<<< HEAD
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
