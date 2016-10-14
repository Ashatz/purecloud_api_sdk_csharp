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
    /// EdgeOfflineConfiguration
    /// </summary>
    [DataContract]
    public partial class EdgeOfflineConfiguration :  IEquatable<EdgeOfflineConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeOfflineConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdgeOfflineConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeOfflineConfiguration" /> class.
        /// </summary>
        /// <param name="PairingId">The pairingId for your hardware Edge in the format: 00000-00000-00000-00000-00000. (required).</param>
        /// <param name="Network">Network settings for your hardware Edge. (required).</param>
        public EdgeOfflineConfiguration(string PairingId = null, EdgeOfflineConfigurationNetwork Network = null)
        {
            // to ensure "PairingId" is required (not null)
            if (PairingId == null)
            {
                throw new InvalidDataException("PairingId is a required property for EdgeOfflineConfiguration and cannot be null");
            }
            else
            {
                this.PairingId = PairingId;
            }
            // to ensure "Network" is required (not null)
            if (Network == null)
            {
                throw new InvalidDataException("Network is a required property for EdgeOfflineConfiguration and cannot be null");
            }
            else
            {
                this.Network = Network;
            }
        }
        
        /// <summary>
        /// The pairingId for your hardware Edge in the format: 00000-00000-00000-00000-00000.
        /// </summary>
        /// <value>The pairingId for your hardware Edge in the format: 00000-00000-00000-00000-00000.</value>
        [DataMember(Name="pairingId", EmitDefaultValue=false)]
        public string PairingId { get; set; }
        /// <summary>
        /// Network settings for your hardware Edge.
        /// </summary>
        /// <value>Network settings for your hardware Edge.</value>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public EdgeOfflineConfigurationNetwork Network { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeOfflineConfiguration {\n");
            sb.Append("  PairingId: ").Append(PairingId).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
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
            return this.Equals(obj as EdgeOfflineConfiguration);
        }

        /// <summary>
        /// Returns true if EdgeOfflineConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeOfflineConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeOfflineConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PairingId == other.PairingId ||
                    this.PairingId != null &&
                    this.PairingId.Equals(other.PairingId)
                ) &&
                (
                    this.Network == other.Network ||
                    this.Network != null &&
                    this.Network.Equals(other.Network)
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
                if (this.PairingId != null)
                    hash = hash * 59 + this.PairingId.GetHashCode();
                if (this.Network != null)
                    hash = hash * 59 + this.Network.GetHashCode();
                return hash;
            }
        }
    }

}
