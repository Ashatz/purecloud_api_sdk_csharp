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
    public partial class DomainNetworkRoute :  IEquatable<DomainNetworkRoute>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainNetworkRoute" />class.
        /// </summary>
        /// <param name="Prefix">Prefix.</param>
        /// <param name="Nexthop">Nexthop.</param>
        /// <param name="Persistent">Persistent (default to false).</param>
        /// <param name="Metric">Metric.</param>
        /// <param name="Family">Family.</param>

        public DomainNetworkRoute(string Prefix = null, string Nexthop = null, bool? Persistent = null, int? Metric = null, int? Family = null)
        {
            this.Prefix = Prefix;
            this.Nexthop = Nexthop;
            // use default value if no "Persistent" provided
            if (Persistent == null)
            {
                this.Persistent = false;
            }
            else
            {
                this.Persistent = Persistent;
            }
            this.Metric = Metric;
            this.Family = Family;
            
        }

    
        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }
    
        /// <summary>
        /// Gets or Sets Nexthop
        /// </summary>
        [DataMember(Name="nexthop", EmitDefaultValue=false)]
        public string Nexthop { get; set; }
    
        /// <summary>
        /// Gets or Sets Persistent
        /// </summary>
        [DataMember(Name="persistent", EmitDefaultValue=false)]
        public bool? Persistent { get; set; }
    
        /// <summary>
        /// Gets or Sets Metric
        /// </summary>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public int? Metric { get; set; }
    
        /// <summary>
        /// Gets or Sets Family
        /// </summary>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public int? Family { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainNetworkRoute {\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Nexthop: ").Append(Nexthop).Append("\n");
            sb.Append("  Persistent: ").Append(Persistent).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Family: ").Append(Family).Append("\n");
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
            return this.Equals(obj as DomainNetworkRoute);
        }

        /// <summary>
        /// Returns true if DomainNetworkRoute instances are equal
        /// </summary>
        /// <param name="other">Instance of DomainNetworkRoute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainNetworkRoute other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Prefix == other.Prefix ||
                    this.Prefix != null &&
                    this.Prefix.Equals(other.Prefix)
                ) &&
                (
                    this.Nexthop == other.Nexthop ||
                    this.Nexthop != null &&
                    this.Nexthop.Equals(other.Nexthop)
                ) &&
                (
                    this.Persistent == other.Persistent ||
                    this.Persistent != null &&
                    this.Persistent.Equals(other.Persistent)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.Family == other.Family ||
                    this.Family != null &&
                    this.Family.Equals(other.Family)
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
                if (this.Prefix != null)
                    hash = hash * 59 + this.Prefix.GetHashCode();
                if (this.Nexthop != null)
                    hash = hash * 59 + this.Nexthop.GetHashCode();
                if (this.Persistent != null)
                    hash = hash * 59 + this.Persistent.GetHashCode();
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();
                if (this.Family != null)
                    hash = hash * 59 + this.Family.GetHashCode();
                return hash;
            }
        }

    }
}
