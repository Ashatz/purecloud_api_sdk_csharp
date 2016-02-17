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
    /// 
    /// </summary>
    [DataContract]
    public partial class PhoneCapabilities :  IEquatable<PhoneCapabilities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneCapabilities" /> class.
        /// </summary>
        public PhoneCapabilities()
        {
            this.Provisions = false;
            this.Registers = false;
            this.DualRegisters = false;
            this.AllowReboot = false;
            this.NoRebalance = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Provisions
        /// </summary>
        [DataMember(Name="provisions", EmitDefaultValue=false)]
        public bool? Provisions { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Registers
        /// </summary>
        [DataMember(Name="registers", EmitDefaultValue=false)]
        public bool? Registers { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DualRegisters
        /// </summary>
        [DataMember(Name="dualRegisters", EmitDefaultValue=false)]
        public bool? DualRegisters { get; set; }
  
        
        /// <summary>
        /// Gets or Sets HardwareIdType
        /// </summary>
        [DataMember(Name="hardwareIdType", EmitDefaultValue=false)]
        public string HardwareIdType { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AllowReboot
        /// </summary>
        [DataMember(Name="allowReboot", EmitDefaultValue=false)]
        public bool? AllowReboot { get; set; }
  
        
        /// <summary>
        /// Gets or Sets NoRebalance
        /// </summary>
        [DataMember(Name="noRebalance", EmitDefaultValue=false)]
        public bool? NoRebalance { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneCapabilities {\n");
            sb.Append("  Provisions: ").Append(Provisions).Append("\n");
            sb.Append("  Registers: ").Append(Registers).Append("\n");
            sb.Append("  DualRegisters: ").Append(DualRegisters).Append("\n");
            sb.Append("  HardwareIdType: ").Append(HardwareIdType).Append("\n");
            sb.Append("  AllowReboot: ").Append(AllowReboot).Append("\n");
            sb.Append("  NoRebalance: ").Append(NoRebalance).Append("\n");
            
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
            return this.Equals(obj as PhoneCapabilities);
        }

        /// <summary>
        /// Returns true if PhoneCapabilities instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneCapabilities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneCapabilities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Provisions == other.Provisions ||
                    this.Provisions != null &&
                    this.Provisions.Equals(other.Provisions)
                ) && 
                (
                    this.Registers == other.Registers ||
                    this.Registers != null &&
                    this.Registers.Equals(other.Registers)
                ) && 
                (
                    this.DualRegisters == other.DualRegisters ||
                    this.DualRegisters != null &&
                    this.DualRegisters.Equals(other.DualRegisters)
                ) && 
                (
                    this.HardwareIdType == other.HardwareIdType ||
                    this.HardwareIdType != null &&
                    this.HardwareIdType.Equals(other.HardwareIdType)
                ) && 
                (
                    this.AllowReboot == other.AllowReboot ||
                    this.AllowReboot != null &&
                    this.AllowReboot.Equals(other.AllowReboot)
                ) && 
                (
                    this.NoRebalance == other.NoRebalance ||
                    this.NoRebalance != null &&
                    this.NoRebalance.Equals(other.NoRebalance)
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
                
                if (this.Provisions != null)
                    hash = hash * 59 + this.Provisions.GetHashCode();
                
                if (this.Registers != null)
                    hash = hash * 59 + this.Registers.GetHashCode();
                
                if (this.DualRegisters != null)
                    hash = hash * 59 + this.DualRegisters.GetHashCode();
                
                if (this.HardwareIdType != null)
                    hash = hash * 59 + this.HardwareIdType.GetHashCode();
                
                if (this.AllowReboot != null)
                    hash = hash * 59 + this.AllowReboot.GetHashCode();
                
                if (this.NoRebalance != null)
                    hash = hash * 59 + this.NoRebalance.GetHashCode();
                
                return hash;
            }
        }

    }
}
