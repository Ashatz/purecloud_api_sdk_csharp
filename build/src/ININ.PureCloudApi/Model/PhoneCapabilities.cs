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
    /// PhoneCapabilities
    /// </summary>
    [DataContract]
    public partial class PhoneCapabilities :  IEquatable<PhoneCapabilities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneCapabilities" /> class.
        /// </summary>
        /// <param name="Provisions">Provisions (default to false).</param>
        /// <param name="Registers">Registers (default to false).</param>
        /// <param name="DualRegisters">DualRegisters (default to false).</param>
        /// <param name="HardwareIdType">HardwareIdType.</param>
        /// <param name="AllowReboot">AllowReboot (default to false).</param>
        /// <param name="NoRebalance">NoRebalance (default to false).</param>
        public PhoneCapabilities(bool? Provisions = null, bool? Registers = null, bool? DualRegisters = null, string HardwareIdType = null, bool? AllowReboot = null, bool? NoRebalance = null)
        {
            // use default value if no "Provisions" provided
            if (Provisions == null)
            {
                this.Provisions = false;
            }
            else
            {
                this.Provisions = Provisions;
            }
            // use default value if no "Registers" provided
            if (Registers == null)
            {
                this.Registers = false;
            }
            else
            {
                this.Registers = Registers;
            }
            // use default value if no "DualRegisters" provided
            if (DualRegisters == null)
            {
                this.DualRegisters = false;
            }
            else
            {
                this.DualRegisters = DualRegisters;
            }
            this.HardwareIdType = HardwareIdType;
            // use default value if no "AllowReboot" provided
            if (AllowReboot == null)
            {
                this.AllowReboot = false;
            }
            else
            {
                this.AllowReboot = AllowReboot;
            }
            // use default value if no "NoRebalance" provided
            if (NoRebalance == null)
            {
                this.NoRebalance = false;
            }
            else
            {
                this.NoRebalance = NoRebalance;
            }
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

            return true &&
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
