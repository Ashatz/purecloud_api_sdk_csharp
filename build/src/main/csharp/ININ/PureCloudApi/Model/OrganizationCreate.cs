using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// Creating an Organization
    /// </summary>
    [DataContract]
    public partial class OrganizationCreate :  IEquatable<OrganizationCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreate" /> class.
        /// </summary>
        public OrganizationCreate()
        {
            this.Deletable = false;
            
        }

        
        /// <summary>
        /// Display Name for Organization
        /// </summary>
        /// <value>Display Name for Organization</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Administrator username for this organization
        /// </summary>
        /// <value>Administrator username for this organization</value>
        [DataMember(Name="adminUsername", EmitDefaultValue=false)]
        public string AdminUsername { get; set; }
  
        
        /// <summary>
        /// Administrator password for this organization
        /// </summary>
        /// <value>Administrator password for this organization</value>
        [DataMember(Name="adminPassword", EmitDefaultValue=false)]
        public string AdminPassword { get; set; }
  
        
        /// <summary>
        /// Fully qualified domain name for this organization (Ex. example.com).
        /// </summary>
        /// <value>Fully qualified domain name for this organization (Ex. example.com).</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }
  
        
        /// <summary>
        /// Organization Name which does not contain special characters like spaces.
        /// </summary>
        /// <value>Organization Name which does not contain special characters like spaces.</value>
        [DataMember(Name="thirdPartyOrgName", EmitDefaultValue=false)]
        public string ThirdPartyOrgName { get; set; }
  
        
        /// <summary>
        /// Deletable Property for Organization.
        /// </summary>
        /// <value>Deletable Property for Organization.</value>
        [DataMember(Name="deletable", EmitDefaultValue=false)]
        public bool? Deletable { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationCreate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AdminUsername: ").Append(AdminUsername).Append("\n");
            sb.Append("  AdminPassword: ").Append(AdminPassword).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  ThirdPartyOrgName: ").Append(ThirdPartyOrgName).Append("\n");
            sb.Append("  Deletable: ").Append(Deletable).Append("\n");
            
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
            return this.Equals(obj as OrganizationCreate);
        }

        /// <summary>
        /// Returns true if OrganizationCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.AdminUsername == other.AdminUsername ||
                    this.AdminUsername != null &&
                    this.AdminUsername.Equals(other.AdminUsername)
                ) && 
                (
                    this.AdminPassword == other.AdminPassword ||
                    this.AdminPassword != null &&
                    this.AdminPassword.Equals(other.AdminPassword)
                ) && 
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) && 
                (
                    this.ThirdPartyOrgName == other.ThirdPartyOrgName ||
                    this.ThirdPartyOrgName != null &&
                    this.ThirdPartyOrgName.Equals(other.ThirdPartyOrgName)
                ) && 
                (
                    this.Deletable == other.Deletable ||
                    this.Deletable != null &&
                    this.Deletable.Equals(other.Deletable)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.AdminUsername != null)
                    hash = hash * 59 + this.AdminUsername.GetHashCode();
                
                if (this.AdminPassword != null)
                    hash = hash * 59 + this.AdminPassword.GetHashCode();
                
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                
                if (this.ThirdPartyOrgName != null)
                    hash = hash * 59 + this.ThirdPartyOrgName.GetHashCode();
                
                if (this.Deletable != null)
                    hash = hash * 59 + this.Deletable.GetHashCode();
                
                return hash;
            }
        }

    }
}
