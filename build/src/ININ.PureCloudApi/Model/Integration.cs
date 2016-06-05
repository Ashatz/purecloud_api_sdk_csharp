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
    /// Details for an Integration
    /// </summary>
    [DataContract]
    public partial class Integration :  IEquatable<Integration>
    {
        /// <summary>
        /// Configured state of the integration.
        /// </summary>
        /// <value>Configured state of the integration.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Enabled for "ENABLED"
            /// </summary>
            [EnumMember(Value = "ENABLED")]
            Enabled,
            
            /// <summary>
            /// Enum Disabled for "DISABLED"
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            Disabled,
            
            /// <summary>
            /// Enum Deleted for "DELETED"
            /// </summary>
            [EnumMember(Value = "DELETED")]
            Deleted
        }

        /// <summary>
        /// Configured state of the integration.
        /// </summary>
        /// <value>Configured state of the integration.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Integration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Integration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Integration" /> class.
        /// </summary>
        /// <param name="Name">The name of the integration, used to distinguish this integration from others of the same type. (required).</param>
        /// <param name="IntegrationType">Type of the integration.</param>
        /// <param name="State">Configured state of the integration. (required).</param>
        /// <param name="Config">Configuration for the integration..</param>
        /// <param name="LastStatus">Last reported status of the integration..</param>
        /// <param name="Version">Version number required for updates. (required).</param>
        public Integration(string Name = null, IntegrationType IntegrationType = null, StateEnum? State = null, IntegrationConfiguration Config = null, IntegrationStatusInfo LastStatus = null, int? Version = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Integration and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for Integration and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new InvalidDataException("Version is a required property for Integration and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            this.IntegrationType = IntegrationType;
            this.Config = Config;
            this.LastStatus = LastStatus;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The name of the integration, used to distinguish this integration from others of the same type.
        /// </summary>
        /// <value>The name of the integration, used to distinguish this integration from others of the same type.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Type of the integration
        /// </summary>
        /// <value>Type of the integration</value>
        [DataMember(Name="integrationType", EmitDefaultValue=false)]
        public IntegrationType IntegrationType { get; set; }
        /// <summary>
        /// Configuration for the integration.
        /// </summary>
        /// <value>Configuration for the integration.</value>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public IntegrationConfiguration Config { get; set; }
        /// <summary>
        /// Last reported status of the integration.
        /// </summary>
        /// <value>Last reported status of the integration.</value>
        [DataMember(Name="lastStatus", EmitDefaultValue=false)]
        public IntegrationStatusInfo LastStatus { get; set; }
        /// <summary>
        /// Version number required for updates.
        /// </summary>
        /// <value>Version number required for updates.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
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
            sb.Append("class Integration {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IntegrationType: ").Append(IntegrationType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  LastStatus: ").Append(LastStatus).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as Integration);
        }

        /// <summary>
        /// Returns true if Integration instances are equal
        /// </summary>
        /// <param name="other">Instance of Integration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Integration other)
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
                    this.IntegrationType == other.IntegrationType ||
                    this.IntegrationType != null &&
                    this.IntegrationType.Equals(other.IntegrationType)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Config == other.Config ||
                    this.Config != null &&
                    this.Config.Equals(other.Config)
                ) &&
                (
                    this.LastStatus == other.LastStatus ||
                    this.LastStatus != null &&
                    this.LastStatus.Equals(other.LastStatus)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.IntegrationType != null)
                    hash = hash * 59 + this.IntegrationType.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Config != null)
                    hash = hash * 59 + this.Config.GetHashCode();
                if (this.LastStatus != null)
                    hash = hash * 59 + this.LastStatus.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
