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
    /// Flow
    /// </summary>
    [DataContract]
    public partial class Flow :  IEquatable<Flow>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Inboundcall for "INBOUNDCALL"
            /// </summary>
            [EnumMember(Value = "INBOUNDCALL")]
            Inboundcall,
            
            /// <summary>
            /// Enum Outboundcall for "OUTBOUNDCALL"
            /// </summary>
            [EnumMember(Value = "OUTBOUNDCALL")]
            Outboundcall,
            
            /// <summary>
            /// Enum Inqueuecall for "INQUEUECALL"
            /// </summary>
            [EnumMember(Value = "INQUEUECALL")]
            Inqueuecall,
            
            /// <summary>
            /// Enum Speech for "SPEECH"
            /// </summary>
            [EnumMember(Value = "SPEECH")]
            Speech
        }

        /// <summary>
        /// Gets or Sets PublishStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PublishStatusEnum
        {
            
            /// <summary>
            /// Enum Started for "STARTED"
            /// </summary>
            [EnumMember(Value = "STARTED")]
            Started,
            
            /// <summary>
            /// Enum PendingVxmlgen for "PENDING_VXMLGEN"
            /// </summary>
            [EnumMember(Value = "PENDING_VXMLGEN")]
            PendingVxmlgen,
            
            /// <summary>
            /// Enum PendingEdgeConfig for "PENDING_EDGE_CONFIG"
            /// </summary>
            [EnumMember(Value = "PENDING_EDGE_CONFIG")]
            PendingEdgeConfig,
            
            /// <summary>
            /// Enum Success for "SUCCESS"
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            Success,
            
            /// <summary>
            /// Enum Failure for "FAILURE"
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            Failure
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets PublishStatus
        /// </summary>
        [DataMember(Name="publishStatus", EmitDefaultValue=false)]
        public PublishStatusEnum? PublishStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Flow" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Type">Type.</param>
        /// <param name="LockedUser">LockedUser.</param>
        /// <param name="Active">Active (default to false).</param>
        /// <param name="Deleted">Deleted (default to false).</param>
        /// <param name="PublishedVersion">PublishedVersion.</param>
        /// <param name="CheckedInVersion">CheckedInVersion.</param>
        /// <param name="SavedVersion">SavedVersion.</param>
        /// <param name="System">System (default to false).</param>
        /// <param name="PublishStatus">PublishStatus.</param>
        /// <param name="PublishedBy">PublishedBy.</param>
        public Flow(string Name = null, string Description = null, TypeEnum? Type = null, UriReference LockedUser = null, bool? Active = null, bool? Deleted = null, FlowVersion PublishedVersion = null, FlowVersion CheckedInVersion = null, FlowVersion SavedVersion = null, bool? System = null, PublishStatusEnum? PublishStatus = null, UriReference PublishedBy = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Type = Type;
            this.LockedUser = LockedUser;
            // use default value if no "Active" provided
            if (Active == null)
            {
                this.Active = false;
            }
            else
            {
                this.Active = Active;
            }
            // use default value if no "Deleted" provided
            if (Deleted == null)
            {
                this.Deleted = false;
            }
            else
            {
                this.Deleted = Deleted;
            }
            this.PublishedVersion = PublishedVersion;
            this.CheckedInVersion = CheckedInVersion;
            this.SavedVersion = SavedVersion;
            // use default value if no "System" provided
            if (System == null)
            {
                this.System = false;
            }
            else
            {
                this.System = System;
            }
            this.PublishStatus = PublishStatus;
            this.PublishedBy = PublishedBy;
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
        /// Gets or Sets LockedUser
        /// </summary>
        [DataMember(Name="lockedUser", EmitDefaultValue=false)]
        public UriReference LockedUser { get; set; }
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }
        /// <summary>
        /// Gets or Sets PublishedVersion
        /// </summary>
        [DataMember(Name="publishedVersion", EmitDefaultValue=false)]
        public FlowVersion PublishedVersion { get; set; }
        /// <summary>
        /// Gets or Sets CheckedInVersion
        /// </summary>
        [DataMember(Name="checkedInVersion", EmitDefaultValue=false)]
        public FlowVersion CheckedInVersion { get; set; }
        /// <summary>
        /// Gets or Sets SavedVersion
        /// </summary>
        [DataMember(Name="savedVersion", EmitDefaultValue=false)]
        public FlowVersion SavedVersion { get; set; }
        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name="system", EmitDefaultValue=false)]
        public bool? System { get; set; }
        /// <summary>
        /// Gets or Sets PublishedBy
        /// </summary>
        [DataMember(Name="publishedBy", EmitDefaultValue=false)]
        public UriReference PublishedBy { get; set; }
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
            sb.Append("class Flow {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LockedUser: ").Append(LockedUser).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  PublishedVersion: ").Append(PublishedVersion).Append("\n");
            sb.Append("  CheckedInVersion: ").Append(CheckedInVersion).Append("\n");
            sb.Append("  SavedVersion: ").Append(SavedVersion).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  PublishStatus: ").Append(PublishStatus).Append("\n");
            sb.Append("  PublishedBy: ").Append(PublishedBy).Append("\n");
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
            return this.Equals(obj as Flow);
        }

        /// <summary>
        /// Returns true if Flow instances are equal
        /// </summary>
        /// <param name="other">Instance of Flow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Flow other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.LockedUser == other.LockedUser ||
                    this.LockedUser != null &&
                    this.LockedUser.Equals(other.LockedUser)
                ) &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) &&
                (
                    this.Deleted == other.Deleted ||
                    this.Deleted != null &&
                    this.Deleted.Equals(other.Deleted)
                ) &&
                (
                    this.PublishedVersion == other.PublishedVersion ||
                    this.PublishedVersion != null &&
                    this.PublishedVersion.Equals(other.PublishedVersion)
                ) &&
                (
                    this.CheckedInVersion == other.CheckedInVersion ||
                    this.CheckedInVersion != null &&
                    this.CheckedInVersion.Equals(other.CheckedInVersion)
                ) &&
                (
                    this.SavedVersion == other.SavedVersion ||
                    this.SavedVersion != null &&
                    this.SavedVersion.Equals(other.SavedVersion)
                ) &&
                (
                    this.System == other.System ||
                    this.System != null &&
                    this.System.Equals(other.System)
                ) &&
                (
                    this.PublishStatus == other.PublishStatus ||
                    this.PublishStatus != null &&
                    this.PublishStatus.Equals(other.PublishStatus)
                ) &&
                (
                    this.PublishedBy == other.PublishedBy ||
                    this.PublishedBy != null &&
                    this.PublishedBy.Equals(other.PublishedBy)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.LockedUser != null)
                    hash = hash * 59 + this.LockedUser.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.Deleted != null)
                    hash = hash * 59 + this.Deleted.GetHashCode();
                if (this.PublishedVersion != null)
                    hash = hash * 59 + this.PublishedVersion.GetHashCode();
                if (this.CheckedInVersion != null)
                    hash = hash * 59 + this.CheckedInVersion.GetHashCode();
                if (this.SavedVersion != null)
                    hash = hash * 59 + this.SavedVersion.GetHashCode();
                if (this.System != null)
                    hash = hash * 59 + this.System.GetHashCode();
                if (this.PublishStatus != null)
                    hash = hash * 59 + this.PublishStatus.GetHashCode();
                if (this.PublishedBy != null)
                    hash = hash * 59 + this.PublishedBy.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
