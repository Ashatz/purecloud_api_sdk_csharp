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
    public partial class HardwareRate :  IEquatable<HardwareRate>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareRate" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="PartNumber">PartNumber.</param>
        /// <param name="Rate">Rate.</param>

        public HardwareRate(string Name = null, string Description = null, string PartNumber = null, Rate Rate = null, )
        {
            this.Name = Name;
            this.Description = Description;
            this.PartNumber = PartNumber;
            this.Rate = Rate;
            
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets PartNumber
        /// </summary>
        [DataMember(Name="partNumber", EmitDefaultValue=false)]
        public string PartNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public Rate Rate { get; set; }
    
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
            sb.Append("class HardwareRate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
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
            return this.Equals(obj as HardwareRate);
        }

        /// <summary>
        /// Returns true if HardwareRate instances are equal
        /// </summary>
        /// <param name="other">Instance of HardwareRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HardwareRate other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.PartNumber == other.PartNumber ||
                    this.PartNumber != null &&
                    this.PartNumber.Equals(other.PartNumber)
                ) &&
                (
                    this.Rate == other.Rate ||
                    this.Rate != null &&
                    this.Rate.Equals(other.Rate)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.PartNumber != null)
                    hash = hash * 59 + this.PartNumber.GetHashCode();
                
                if (this.Rate != null)
                    hash = hash * 59 + this.Rate.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
