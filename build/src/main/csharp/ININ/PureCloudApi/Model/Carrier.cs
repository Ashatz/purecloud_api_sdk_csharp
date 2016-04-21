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
    public partial class Carrier :  IEquatable<Carrier>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Carrier" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="AccountManager">AccountManager.</param>
        /// <param name="Support">Support.</param>
        /// <param name="NocSupport">NocSupport.</param>
        /// <param name="Services">Services.</param>
        /// <param name="Address">Address.</param>

        public Carrier(string Name = null, AccountManager AccountManager = null, Support Support = null, NocSupport NocSupport = null, List<Service> Services = nullCarrierAddress Address = null)
        {
            this.Name = Name;
            this.AccountManager = AccountManager;
            this.Support = Support;
            this.NocSupport = NocSupport;
            this.Services = Services;
            this.Address = Address;
            
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
        /// Gets or Sets AccountManager
        /// </summary>
        [DataMember(Name="accountManager", EmitDefaultValue=false)]
        public AccountManager AccountManager { get; set; }
    
        /// <summary>
        /// Gets or Sets Support
        /// </summary>
        [DataMember(Name="support", EmitDefaultValue=false)]
        public Support Support { get; set; }
    
        /// <summary>
        /// Gets or Sets NocSupport
        /// </summary>
        [DataMember(Name="nocSupport", EmitDefaultValue=false)]
        public NocSupport NocSupport { get; set; }
    
        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<Service> Services { get; set; }
    
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
    
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public CarrierAddress Address { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Carrier {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountManager: ").Append(AccountManager).Append("\n");
            sb.Append("  Support: ").Append(Support).Append("\n");
            sb.Append("  NocSupport: ").Append(NocSupport).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(obj as Carrier);
        }

        /// <summary>
        /// Returns true if Carrier instances are equal
        /// </summary>
        /// <param name="other">Instance of Carrier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Carrier other)
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
                    this.AccountManager == other.AccountManager ||
                    this.AccountManager != null &&
                    this.AccountManager.Equals(other.AccountManager)
                ) &&
                (
                    this.Support == other.Support ||
                    this.Support != null &&
                    this.Support.Equals(other.Support)
                ) &&
                (
                    this.NocSupport == other.NocSupport ||
                    this.NocSupport != null &&
                    this.NocSupport.Equals(other.NocSupport)
                ) &&
                (
                    this.Services == other.Services ||
                    this.Services != null &&
                    this.Services.SequenceEqual(other.Services)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
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
                if (this.AccountManager != null)
                    hash = hash * 59 + this.AccountManager.GetHashCode();
                if (this.Support != null)
                    hash = hash * 59 + this.Support.GetHashCode();
                if (this.NocSupport != null)
                    hash = hash * 59 + this.NocSupport.GetHashCode();
                if (this.Services != null)
                    hash = hash * 59 + this.Services.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                return hash;
            }
        }

    }
}
