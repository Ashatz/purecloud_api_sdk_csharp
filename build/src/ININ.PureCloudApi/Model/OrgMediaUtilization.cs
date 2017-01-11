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
    /// OrgMediaUtilization
    /// </summary>
    [DataContract]
    public partial class OrgMediaUtilization :  IEquatable<OrgMediaUtilization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgMediaUtilization" /> class.
        /// </summary>
        /// <param name="MaximumCapacity">Defines the maximum number of conversations of this type that an agent can handle at one time..</param>
        /// <param name="InterruptableMediaTypes">Defines the list of other media types that can interrupt a conversation of this media type.  Values can be: call, chat, email, or socialExpression.</param>
        /// <param name="IncludeNonAcd">If true, then track non-ACD conversations against utilization.</param>
        public OrgMediaUtilization(int? MaximumCapacity = null, List<string> InterruptableMediaTypes = null, bool? IncludeNonAcd = null)
        {
            this.MaximumCapacity = MaximumCapacity;
            this.InterruptableMediaTypes = InterruptableMediaTypes;
            this.IncludeNonAcd = IncludeNonAcd;
        }
        
        /// <summary>
        /// Defines the maximum number of conversations of this type that an agent can handle at one time.
        /// </summary>
        /// <value>Defines the maximum number of conversations of this type that an agent can handle at one time.</value>
        [DataMember(Name="maximumCapacity", EmitDefaultValue=false)]
        public int? MaximumCapacity { get; set; }
        /// <summary>
        /// Defines the list of other media types that can interrupt a conversation of this media type.  Values can be: call, chat, email, or socialExpression
        /// </summary>
        /// <value>Defines the list of other media types that can interrupt a conversation of this media type.  Values can be: call, chat, email, or socialExpression</value>
        [DataMember(Name="interruptableMediaTypes", EmitDefaultValue=false)]
        public List<string> InterruptableMediaTypes { get; set; }
        /// <summary>
        /// If true, then track non-ACD conversations against utilization
        /// </summary>
        /// <value>If true, then track non-ACD conversations against utilization</value>
        [DataMember(Name="includeNonAcd", EmitDefaultValue=false)]
        public bool? IncludeNonAcd { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgMediaUtilization {\n");
            sb.Append("  MaximumCapacity: ").Append(MaximumCapacity).Append("\n");
            sb.Append("  InterruptableMediaTypes: ").Append(InterruptableMediaTypes).Append("\n");
            sb.Append("  IncludeNonAcd: ").Append(IncludeNonAcd).Append("\n");
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
            return this.Equals(obj as OrgMediaUtilization);
        }

        /// <summary>
        /// Returns true if OrgMediaUtilization instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgMediaUtilization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgMediaUtilization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MaximumCapacity == other.MaximumCapacity ||
                    this.MaximumCapacity != null &&
                    this.MaximumCapacity.Equals(other.MaximumCapacity)
                ) &&
                (
                    this.InterruptableMediaTypes == other.InterruptableMediaTypes ||
                    this.InterruptableMediaTypes != null &&
                    this.InterruptableMediaTypes.SequenceEqual(other.InterruptableMediaTypes)
                ) &&
                (
                    this.IncludeNonAcd == other.IncludeNonAcd ||
                    this.IncludeNonAcd != null &&
                    this.IncludeNonAcd.Equals(other.IncludeNonAcd)
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
                if (this.MaximumCapacity != null)
                    hash = hash * 59 + this.MaximumCapacity.GetHashCode();
                if (this.InterruptableMediaTypes != null)
                    hash = hash * 59 + this.InterruptableMediaTypes.GetHashCode();
                if (this.IncludeNonAcd != null)
                    hash = hash * 59 + this.IncludeNonAcd.GetHashCode();
                return hash;
            }
        }
    }

}
