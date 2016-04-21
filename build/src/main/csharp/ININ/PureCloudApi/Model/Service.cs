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
    public partial class Service :  IEquatable<Service>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Service" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Status">Status.</param>
        /// <param name="ServiceTypes">ServiceTypes.</param>
        /// <param name="Gateways">Gateways.</param>
        /// <param name="Dns">Dns.</param>
        /// <param name="Vpn">Vpn.</param>
        /// <param name="Carrier">Carrier.</param>

        public Service(string Name = null, string Status = null, List<ServiceType> ServiceTypes = null, List<Gateway> Gateways = null, Dns Dns = null, Vpn Vpn = null, Carrier Carrier = null)
        {
            this.Name = Name;
            this.Status = Status;
            this.ServiceTypes = ServiceTypes;
            this.Gateways = Gateways;
            this.Dns = Dns;
            this.Vpn = Vpn;
            this.Carrier = Carrier;
            
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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets ServiceTypes
        /// </summary>
        [DataMember(Name="serviceTypes", EmitDefaultValue=false)]
        public List<ServiceType> ServiceTypes { get; set; }
    
        /// <summary>
        /// Gets or Sets Gateways
        /// </summary>
        [DataMember(Name="gateways", EmitDefaultValue=false)]
        public List<Gateway> Gateways { get; set; }
    
        /// <summary>
        /// Gets or Sets Dns
        /// </summary>
        [DataMember(Name="dns", EmitDefaultValue=false)]
        public Dns Dns { get; set; }
    
        /// <summary>
        /// Gets or Sets Vpn
        /// </summary>
        [DataMember(Name="vpn", EmitDefaultValue=false)]
        public Vpn Vpn { get; set; }
    
        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public Carrier Carrier { get; set; }
    
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
            sb.Append("class Service {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ServiceTypes: ").Append(ServiceTypes).Append("\n");
            sb.Append("  Gateways: ").Append(Gateways).Append("\n");
            sb.Append("  Dns: ").Append(Dns).Append("\n");
            sb.Append("  Vpn: ").Append(Vpn).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
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
            return this.Equals(obj as Service);
        }

        /// <summary>
        /// Returns true if Service instances are equal
        /// </summary>
        /// <param name="other">Instance of Service to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Service other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ServiceTypes == other.ServiceTypes ||
                    this.ServiceTypes != null &&
                    this.ServiceTypes.SequenceEqual(other.ServiceTypes)
                ) &&
                (
                    this.Gateways == other.Gateways ||
                    this.Gateways != null &&
                    this.Gateways.SequenceEqual(other.Gateways)
                ) &&
                (
                    this.Dns == other.Dns ||
                    this.Dns != null &&
                    this.Dns.Equals(other.Dns)
                ) &&
                (
                    this.Vpn == other.Vpn ||
                    this.Vpn != null &&
                    this.Vpn.Equals(other.Vpn)
                ) &&
                (
                    this.Carrier == other.Carrier ||
                    this.Carrier != null &&
                    this.Carrier.Equals(other.Carrier)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ServiceTypes != null)
                    hash = hash * 59 + this.ServiceTypes.GetHashCode();
                if (this.Gateways != null)
                    hash = hash * 59 + this.Gateways.GetHashCode();
                if (this.Dns != null)
                    hash = hash * 59 + this.Dns.GetHashCode();
                if (this.Vpn != null)
                    hash = hash * 59 + this.Vpn.GetHashCode();
                if (this.Carrier != null)
                    hash = hash * 59 + this.Carrier.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
