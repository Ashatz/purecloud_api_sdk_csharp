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
    /// AuthzGrant
    /// </summary>
    [DataContract]
    public partial class AuthzGrant :  IEquatable<AuthzGrant>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzGrant" /> class.
        /// </summary>
        /// <param name="PermissionContext">PermissionContext.</param>
        /// <param name="Role">Role.</param>
        /// <param name="GrantMadeAt">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public AuthzGrant(AuthzPermissionContext PermissionContext = null, AuthzGrantRole Role = null, DateTime? GrantMadeAt = null)
        {
            this.PermissionContext = PermissionContext;
            this.Role = Role;
            this.GrantMadeAt = GrantMadeAt;
        }
        
        /// <summary>
        /// Gets or Sets PermissionContext
        /// </summary>
        [DataMember(Name="permissionContext", EmitDefaultValue=false)]
        public AuthzPermissionContext PermissionContext { get; set; }
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public AuthzGrantRole Role { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="grantMadeAt", EmitDefaultValue=false)]
        public DateTime? GrantMadeAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthzGrant {\n");
            sb.Append("  PermissionContext: ").Append(PermissionContext).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  GrantMadeAt: ").Append(GrantMadeAt).Append("\n");
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
            return this.Equals(obj as AuthzGrant);
        }

        /// <summary>
        /// Returns true if AuthzGrant instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthzGrant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthzGrant other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PermissionContext == other.PermissionContext ||
                    this.PermissionContext != null &&
                    this.PermissionContext.Equals(other.PermissionContext)
                ) &&
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) &&
                (
                    this.GrantMadeAt == other.GrantMadeAt ||
                    this.GrantMadeAt != null &&
                    this.GrantMadeAt.Equals(other.GrantMadeAt)
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
                if (this.PermissionContext != null)
                    hash = hash * 59 + this.PermissionContext.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.GrantMadeAt != null)
                    hash = hash * 59 + this.GrantMadeAt.GetHashCode();
                return hash;
            }
        }
    }

}
