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
using ININ.PureCloudApi.Client;

namespace ININ.PureCloudApi.Model
{
    /// <summary>
    /// DomainCapabilities
    /// </summary>
    [DataContract]
    public partial class DomainCapabilities :  IEquatable<DomainCapabilities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainCapabilities" /> class.
        /// </summary>
        /// <param name="Enabled">True if this address family on the interface is enabled. (default to false).</param>
        /// <param name="Dhcp">True if this address family on the interface is using DHCP. (default to false).</param>
        /// <param name="Metric">The metric being used for the address family on this interface. Lower values will have a higher priority. If autoMetric is true, this value will be the automatically calculated metric. To set this value be sure autoMetric is false. If no value is returned, metric configuration is not supported on this Edge..</param>
        /// <param name="AutoMetric">True if the metric is being calculated automatically for the address family on this interface. (default to false).</param>
        public DomainCapabilities(bool? Enabled = null, bool? Dhcp = null, int? Metric = null, bool? AutoMetric = null)
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
            // use default value if no "AutoMetric" provided
            if (AutoMetric == null)
            {
                this.AutoMetric = false;
            }
            else
            {
                this.AutoMetric = AutoMetric;
            }
        }
        
        /// <summary>
        /// True if this address family on the interface is enabled.
        /// </summary>
        /// <value>True if this address family on the interface is enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// True if this address family on the interface is using DHCP.
        /// </summary>
        /// <value>True if this address family on the interface is using DHCP.</value>
        [DataMember(Name="dhcp", EmitDefaultValue=false)]
        public bool? Dhcp { get; set; }
        /// <summary>
        /// The metric being used for the address family on this interface. Lower values will have a higher priority. If autoMetric is true, this value will be the automatically calculated metric. To set this value be sure autoMetric is false. If no value is returned, metric configuration is not supported on this Edge.
        /// </summary>
        /// <value>The metric being used for the address family on this interface. Lower values will have a higher priority. If autoMetric is true, this value will be the automatically calculated metric. To set this value be sure autoMetric is false. If no value is returned, metric configuration is not supported on this Edge.</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public int? Metric { get; set; }
        /// <summary>
        /// True if the metric is being calculated automatically for the address family on this interface.
        /// </summary>
        /// <value>True if the metric is being calculated automatically for the address family on this interface.</value>
        [DataMember(Name="autoMetric", EmitDefaultValue=false)]
        public bool? AutoMetric { get; set; }
        /// <summary>
        /// True if metric configuration is supported.
        /// </summary>
        /// <value>True if metric configuration is supported.</value>
        [DataMember(Name="supportsMetric", EmitDefaultValue=false)]
        public bool? SupportsMetric { get; private set; }
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
            sb.Append("  AutoMetric: ").Append(AutoMetric).Append("\n");
            sb.Append("  SupportsMetric: ").Append(SupportsMetric).Append("\n");
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

            return true &&
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
                ) &&
                (
                    this.AutoMetric == other.AutoMetric ||
                    this.AutoMetric != null &&
                    this.AutoMetric.Equals(other.AutoMetric)
                ) &&
                (
                    this.SupportsMetric == other.SupportsMetric ||
                    this.SupportsMetric != null &&
                    this.SupportsMetric.Equals(other.SupportsMetric)
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
                if (this.AutoMetric != null)
                    hash = hash * 59 + this.AutoMetric.GetHashCode();
                if (this.SupportsMetric != null)
                    hash = hash * 59 + this.SupportsMetric.GetHashCode();
                return hash;
            }
        }
    }

}
