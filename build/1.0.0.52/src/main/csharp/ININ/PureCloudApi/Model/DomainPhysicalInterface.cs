using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class DomainPhysicalInterface :  IEquatable<DomainPhysicalInterface>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPhysicalInterface" /> class.
        /// </summary>
        public DomainPhysicalInterface()
        {
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EdgeUri
        /// </summary>
        [DataMember(Name="edgeUri", EmitDefaultValue=false)]
        public string EdgeUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FriendlyName
        /// </summary>
        [DataMember(Name="friendlyName", EmitDefaultValue=false)]
        public string FriendlyName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets HardwareAddress
        /// </summary>
        [DataMember(Name="hardwareAddress", EmitDefaultValue=false)]
        public string HardwareAddress { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PortLabel
        /// </summary>
        [DataMember(Name="portLabel", EmitDefaultValue=false)]
        public string PortLabel { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PhysicalCapabilities
        /// </summary>
        [DataMember(Name="physicalCapabilities", EmitDefaultValue=false)]
        public DomainPhysicalCapabilities PhysicalCapabilities { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPhysicalInterface {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EdgeUri: ").Append(EdgeUri).Append("\n");
            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  HardwareAddress: ").Append(HardwareAddress).Append("\n");
            sb.Append("  PortLabel: ").Append(PortLabel).Append("\n");
            sb.Append("  PhysicalCapabilities: ").Append(PhysicalCapabilities).Append("\n");
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
            return this.Equals(obj as DomainPhysicalInterface);
        }

        /// <summary>
        /// Returns true if DomainPhysicalInterface instances are equal
        /// </summary>
        /// <param name="obj">Instance of DomainPhysicalInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPhysicalInterface other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.EdgeUri == other.EdgeUri ||
                    this.EdgeUri != null &&
                    this.EdgeUri.Equals(other.EdgeUri)
                ) && 
                (
                    this.FriendlyName == other.FriendlyName ||
                    this.FriendlyName != null &&
                    this.FriendlyName.Equals(other.FriendlyName)
                ) && 
                (
                    this.HardwareAddress == other.HardwareAddress ||
                    this.HardwareAddress != null &&
                    this.HardwareAddress.Equals(other.HardwareAddress)
                ) && 
                (
                    this.PortLabel == other.PortLabel ||
                    this.PortLabel != null &&
                    this.PortLabel.Equals(other.PortLabel)
                ) && 
                (
                    this.PhysicalCapabilities == other.PhysicalCapabilities ||
                    this.PhysicalCapabilities != null &&
                    this.PhysicalCapabilities.Equals(other.PhysicalCapabilities)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.EdgeUri != null)
                    hash = hash * 57 + this.EdgeUri.GetHashCode();
                
                if (this.FriendlyName != null)
                    hash = hash * 57 + this.FriendlyName.GetHashCode();
                
                if (this.HardwareAddress != null)
                    hash = hash * 57 + this.HardwareAddress.GetHashCode();
                
                if (this.PortLabel != null)
                    hash = hash * 57 + this.PortLabel.GetHashCode();
                
                if (this.PhysicalCapabilities != null)
                    hash = hash * 57 + this.PhysicalCapabilities.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
