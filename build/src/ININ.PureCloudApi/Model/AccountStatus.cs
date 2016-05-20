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
    /// AccountStatus
    /// </summary>
    [DataContract]
    public partial class AccountStatus :  IEquatable<AccountStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountStatus" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="OrgName">OrgName.</param>
        /// <param name="Configured">Configured (default to false).</param>
        /// <param name="AdminUIURL">AdminUIURL.</param>
        /// <param name="ThirdPartyAccountId">ThirdPartyAccountId.</param>
        /// <param name="ThirdPartySubscriptionId">ThirdPartySubscriptionId.</param>
        /// <param name="ThirdPartySubscriptionNonAcbId">ThirdPartySubscriptionNonAcbId.</param>
        public AccountStatus(string Name = null, string OrgName = null, bool? Configured = null, string AdminUIURL = null, string ThirdPartyAccountId = null, string ThirdPartySubscriptionId = null, string ThirdPartySubscriptionNonAcbId = null)
        {
            this.Name = Name;
            this.OrgName = OrgName;
            // use default value if no "Configured" provided
            if (Configured == null)
            {
                this.Configured = false;
            }
            else
            {
                this.Configured = Configured;
            }
            this.AdminUIURL = AdminUIURL;
            this.ThirdPartyAccountId = ThirdPartyAccountId;
            this.ThirdPartySubscriptionId = ThirdPartySubscriptionId;
            this.ThirdPartySubscriptionNonAcbId = ThirdPartySubscriptionNonAcbId;
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
        /// Gets or Sets OrgName
        /// </summary>
        [DataMember(Name="orgName", EmitDefaultValue=false)]
        public string OrgName { get; set; }
        /// <summary>
        /// Gets or Sets Configured
        /// </summary>
        [DataMember(Name="configured", EmitDefaultValue=false)]
        public bool? Configured { get; set; }
        /// <summary>
        /// Gets or Sets AdminUIURL
        /// </summary>
        [DataMember(Name="adminUIURL", EmitDefaultValue=false)]
        public string AdminUIURL { get; set; }
        /// <summary>
        /// Gets or Sets ThirdPartyAccountId
        /// </summary>
        [DataMember(Name="thirdPartyAccountId", EmitDefaultValue=false)]
        public string ThirdPartyAccountId { get; set; }
        /// <summary>
        /// Gets or Sets ThirdPartySubscriptionId
        /// </summary>
        [DataMember(Name="thirdPartySubscriptionId", EmitDefaultValue=false)]
        public string ThirdPartySubscriptionId { get; set; }
        /// <summary>
        /// Gets or Sets ThirdPartySubscriptionNonAcbId
        /// </summary>
        [DataMember(Name="thirdPartySubscriptionNonAcbId", EmitDefaultValue=false)]
        public string ThirdPartySubscriptionNonAcbId { get; set; }
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
            sb.Append("class AccountStatus {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrgName: ").Append(OrgName).Append("\n");
            sb.Append("  Configured: ").Append(Configured).Append("\n");
            sb.Append("  AdminUIURL: ").Append(AdminUIURL).Append("\n");
            sb.Append("  ThirdPartyAccountId: ").Append(ThirdPartyAccountId).Append("\n");
            sb.Append("  ThirdPartySubscriptionId: ").Append(ThirdPartySubscriptionId).Append("\n");
            sb.Append("  ThirdPartySubscriptionNonAcbId: ").Append(ThirdPartySubscriptionNonAcbId).Append("\n");
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
            return this.Equals(obj as AccountStatus);
        }

        /// <summary>
        /// Returns true if AccountStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountStatus other)
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
                    this.OrgName == other.OrgName ||
                    this.OrgName != null &&
                    this.OrgName.Equals(other.OrgName)
                ) &&
                (
                    this.Configured == other.Configured ||
                    this.Configured != null &&
                    this.Configured.Equals(other.Configured)
                ) &&
                (
                    this.AdminUIURL == other.AdminUIURL ||
                    this.AdminUIURL != null &&
                    this.AdminUIURL.Equals(other.AdminUIURL)
                ) &&
                (
                    this.ThirdPartyAccountId == other.ThirdPartyAccountId ||
                    this.ThirdPartyAccountId != null &&
                    this.ThirdPartyAccountId.Equals(other.ThirdPartyAccountId)
                ) &&
                (
                    this.ThirdPartySubscriptionId == other.ThirdPartySubscriptionId ||
                    this.ThirdPartySubscriptionId != null &&
                    this.ThirdPartySubscriptionId.Equals(other.ThirdPartySubscriptionId)
                ) &&
                (
                    this.ThirdPartySubscriptionNonAcbId == other.ThirdPartySubscriptionNonAcbId ||
                    this.ThirdPartySubscriptionNonAcbId != null &&
                    this.ThirdPartySubscriptionNonAcbId.Equals(other.ThirdPartySubscriptionNonAcbId)
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
                if (this.OrgName != null)
                    hash = hash * 59 + this.OrgName.GetHashCode();
                if (this.Configured != null)
                    hash = hash * 59 + this.Configured.GetHashCode();
                if (this.AdminUIURL != null)
                    hash = hash * 59 + this.AdminUIURL.GetHashCode();
                if (this.ThirdPartyAccountId != null)
                    hash = hash * 59 + this.ThirdPartyAccountId.GetHashCode();
                if (this.ThirdPartySubscriptionId != null)
                    hash = hash * 59 + this.ThirdPartySubscriptionId.GetHashCode();
                if (this.ThirdPartySubscriptionNonAcbId != null)
                    hash = hash * 59 + this.ThirdPartySubscriptionNonAcbId.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
