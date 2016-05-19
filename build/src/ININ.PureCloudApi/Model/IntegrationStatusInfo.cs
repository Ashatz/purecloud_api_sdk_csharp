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
    /// Status information for an Integration.
    /// </summary>
    [DataContract]
    public partial class IntegrationStatusInfo :  IEquatable<IntegrationStatusInfo>
    {
        /// <summary>
        /// Machine-readable status as reported by the integration.
        /// </summary>
        /// <value>Machine-readable status as reported by the integration.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InternalEnum
        {
            
            /// <summary>
            /// Enum Active for "ACTIVE"
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            /// <summary>
            /// Enum Activating for "ACTIVATING"
            /// </summary>
            [EnumMember(Value = "ACTIVATING")]
            Activating,
            
            /// <summary>
            /// Enum Inactive for "INACTIVE"
            /// </summary>
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            
            /// <summary>
            /// Enum Deactivating for "DEACTIVATING"
            /// </summary>
            [EnumMember(Value = "DEACTIVATING")]
            Deactivating,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error
        }

        /// <summary>
        /// Machine-readable status as reported by the integration.
        /// </summary>
        /// <value>Machine-readable status as reported by the integration.</value>
        [DataMember(Name="internal", EmitDefaultValue=false)]
        public InternalEnum? _Internal { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationStatusInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntegrationStatusInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationStatusInfo" /> class.
        /// </summary>
        public IntegrationStatusInfo()
        {
        }
        
        /// <summary>
        /// Localized, human-readable, effective status of the integration.
        /// </summary>
        /// <value>Localized, human-readable, effective status of the integration.</value>
        [DataMember(Name="effective", EmitDefaultValue=false)]
        public string Effective { get; private set; }
        /// <summary>
        /// Localized status details for the integration.
        /// </summary>
        /// <value>Localized status details for the integration.</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; private set; }
        /// <summary>
        /// Date and time (in UTC) when the integration status (i.e. the internal field) was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date and time (in UTC) when the integration status (i.e. the internal field) was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
        public DateTime? LastUpdated { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationStatusInfo {\n");
            sb.Append("  _Internal: ").Append(_Internal).Append("\n");
            sb.Append("  Effective: ").Append(Effective).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
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
            return this.Equals(obj as IntegrationStatusInfo);
        }

        /// <summary>
        /// Returns true if IntegrationStatusInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrationStatusInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationStatusInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Internal == other._Internal ||
                    this._Internal != null &&
                    this._Internal.Equals(other._Internal)
                ) && 
                (
                    this.Effective == other.Effective ||
                    this.Effective != null &&
                    this.Effective.Equals(other.Effective)
                ) && 
                (
                    this.Detail == other.Detail ||
                    this.Detail != null &&
                    this.Detail.Equals(other.Detail)
                ) && 
                (
                    this.LastUpdated == other.LastUpdated ||
                    this.LastUpdated != null &&
                    this.LastUpdated.Equals(other.LastUpdated)
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
                if (this._Internal != null)
                    hash = hash * 59 + this._Internal.GetHashCode();
                if (this.Effective != null)
                    hash = hash * 59 + this.Effective.GetHashCode();
                if (this.Detail != null)
                    hash = hash * 59 + this.Detail.GetHashCode();
                if (this.LastUpdated != null)
                    hash = hash * 59 + this.LastUpdated.GetHashCode();
                return hash;
            }
        }
    }

}
