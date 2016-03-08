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
    public partial class DomainCapabilities :  IEquatable<DomainCapabilities>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainCapabilities" /> class.
        /// Initializes a new instance of the <see cref="DomainCapabilities" />class.
        /// </summary>
        /// <param name="Enabled">Enabled (default to false).</param>
        /// <param name="Dhcp">Dhcp (default to false).</param>
        /// <param name="Metric">Metric.</param>

        public DomainCapabilities(bool? Enabled = null, bool? Dhcp = null, int? Metric = null)
        {
            // use default value if no "Enabled" provided
            if (Enabled == null)
            {
                this.Enabled = false;
            }
            else
            {
                this.Enabled = Enabled;
            }
            // use default value if no "Dhcp" provided
            if (Dhcp == null)
            {
                this.Dhcp = false;
            }
            else
            {
                this.Dhcp = Dhcp;
            }
            this.Metric = Metric;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Gets or Sets Dhcp
        /// </summary>
        [DataMember(Name="dhcp", EmitDefaultValue=false)]
        public bool? Dhcp { get; set; }
    
        /// <summary>
        /// Gets or Sets Metric
        /// </summary>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public int? Metric { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainCapabilities {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Dhcp: ").Append(Dhcp).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            
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
            return this.Equals(obj as DomainCapabilities);
        }

        /// <summary>
        /// Returns true if DomainCapabilities instances are equal
        /// </summary>
        /// <param name="other">Instance of DomainCapabilities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainCapabilities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Dhcp == other.Dhcp ||
                    this.Dhcp != null &&
                    this.Dhcp.Equals(other.Dhcp)
                ) && 
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
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
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.Dhcp != null)
                    hash = hash * 59 + this.Dhcp.GetHashCode();
                
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();
                
                return hash;
            }
        }

    }
}
