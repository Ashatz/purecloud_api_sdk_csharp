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
    /// Details about the current state of a Flow Definition
    /// </summary>
    [DataContract]
    public partial class FlowConfigMetaData :  IEquatable<FlowConfigMetaData>
    { 

        /// <summary>
        /// Usability of this flow definition. (output only)
        /// </summary>
        /// <value>Usability of this flow definition. (output only)</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ConfigStateEnum {
            
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            
            [EnumMember(Value = "DELETED")]
            Deleted
        }


        /// <summary>
        /// Type of flow this definition describes
        /// </summary>
        /// <value>Type of flow this definition describes</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FlowTypeEnum {
            
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            [EnumMember(Value = "WORKFLOW")]
            Workflow
        }

        

        /// <summary>
        /// Usability of this flow definition. (output only)
        /// </summary>
        /// <value>Usability of this flow definition. (output only)</value>
        [DataMember(Name="configState", EmitDefaultValue=false)]
        public ConfigStateEnum? ConfigState { get; set; }
    

        /// <summary>
        /// Type of flow this definition describes
        /// </summary>
        /// <value>Type of flow this definition describes</value>
        [DataMember(Name="flowType", EmitDefaultValue=false)]
        public FlowTypeEnum? FlowType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowConfigMetaData" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ConfigState">Usability of this flow definition. (output only).</param>
        /// <param name="FlowType">Type of flow this definition describes (required).</param>
        /// <param name="LockedByUser">If locked for editing, the user who locked this definition, otherwise null.</param>
        /// <param name="NewestPublishedVersion">The most recently published version (output only).</param>
        /// <param name="NewestVersion">The most recent version, regardless of published state (output only).</param>
        /// <param name="AssociatedWorkspaces">Workspaces associated with this flow..</param>
        /// <param name="Description">User notes describing the flow definition..</param>
        /// <param name="HasDraft">Flag if this definition has a draft populated. (default to false).</param>

        public FlowConfigMetaData(string Name = null, ConfigStateEnum? ConfigState = null, FlowTypeEnum? FlowType = null, User LockedByUser = null, string NewestPublishedVersion = null, string NewestVersion = null, List<Workspace> AssociatedWorkspaces = null, string Description = null, bool? HasDraft = null)
        {
            // to ensure "FlowType" is required (not null)
            if (FlowType == null)
            {
                throw new InvalidDataException("FlowType is a required property for FlowConfigMetaData and cannot be null");
            }
            else
            {
                this.FlowType = FlowType;
            }
            this.Name = Name;
            this.ConfigState = ConfigState;
            this.LockedByUser = LockedByUser;
            this.NewestPublishedVersion = NewestPublishedVersion;
            this.NewestVersion = NewestVersion;
            this.AssociatedWorkspaces = AssociatedWorkspaces;
            this.Description = Description;
            // use default value if no "HasDraft" provided
            if (HasDraft == null)
            {
                this.HasDraft = false;
            }
            else
            {
                this.HasDraft = HasDraft;
            }
            
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
        /// If locked for editing, the user who locked this definition, otherwise null
        /// </summary>
        /// <value>If locked for editing, the user who locked this definition, otherwise null</value>
        [DataMember(Name="lockedByUser", EmitDefaultValue=false)]
        public User LockedByUser { get; set; }
    
        /// <summary>
        /// The most recently published version (output only)
        /// </summary>
        /// <value>The most recently published version (output only)</value>
        [DataMember(Name="newestPublishedVersion", EmitDefaultValue=false)]
        public string NewestPublishedVersion { get; set; }
    
        /// <summary>
        /// The most recent version, regardless of published state (output only)
        /// </summary>
        /// <value>The most recent version, regardless of published state (output only)</value>
        [DataMember(Name="newestVersion", EmitDefaultValue=false)]
        public string NewestVersion { get; set; }
    
        /// <summary>
        /// Workspaces associated with this flow.
        /// </summary>
        /// <value>Workspaces associated with this flow.</value>
        [DataMember(Name="associatedWorkspaces", EmitDefaultValue=false)]
        public List<Workspace> AssociatedWorkspaces { get; set; }
    
        /// <summary>
        /// User notes describing the flow definition.
        /// </summary>
        /// <value>User notes describing the flow definition.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Flag if this definition has a draft populated.
        /// </summary>
        /// <value>Flag if this definition has a draft populated.</value>
        [DataMember(Name="hasDraft", EmitDefaultValue=false)]
        public bool? HasDraft { get; set; }
    
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
            sb.Append("class FlowConfigMetaData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ConfigState: ").Append(ConfigState).Append("\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
            sb.Append("  LockedByUser: ").Append(LockedByUser).Append("\n");
            sb.Append("  NewestPublishedVersion: ").Append(NewestPublishedVersion).Append("\n");
            sb.Append("  NewestVersion: ").Append(NewestVersion).Append("\n");
            sb.Append("  AssociatedWorkspaces: ").Append(AssociatedWorkspaces).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HasDraft: ").Append(HasDraft).Append("\n");
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
            return this.Equals(obj as FlowConfigMetaData);
        }

        /// <summary>
        /// Returns true if FlowConfigMetaData instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowConfigMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowConfigMetaData other)
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
                    this.ConfigState == other.ConfigState ||
                    this.ConfigState != null &&
                    this.ConfigState.Equals(other.ConfigState)
                ) &&
                (
                    this.FlowType == other.FlowType ||
                    this.FlowType != null &&
                    this.FlowType.Equals(other.FlowType)
                ) &&
                (
                    this.LockedByUser == other.LockedByUser ||
                    this.LockedByUser != null &&
                    this.LockedByUser.Equals(other.LockedByUser)
                ) &&
                (
                    this.NewestPublishedVersion == other.NewestPublishedVersion ||
                    this.NewestPublishedVersion != null &&
                    this.NewestPublishedVersion.Equals(other.NewestPublishedVersion)
                ) &&
                (
                    this.NewestVersion == other.NewestVersion ||
                    this.NewestVersion != null &&
                    this.NewestVersion.Equals(other.NewestVersion)
                ) &&
                (
                    this.AssociatedWorkspaces == other.AssociatedWorkspaces ||
                    this.AssociatedWorkspaces != null &&
                    this.AssociatedWorkspaces.SequenceEqual(other.AssociatedWorkspaces)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.HasDraft == other.HasDraft ||
                    this.HasDraft != null &&
                    this.HasDraft.Equals(other.HasDraft)
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
                if (this.ConfigState != null)
                    hash = hash * 59 + this.ConfigState.GetHashCode();
                if (this.FlowType != null)
                    hash = hash * 59 + this.FlowType.GetHashCode();
                if (this.LockedByUser != null)
                    hash = hash * 59 + this.LockedByUser.GetHashCode();
                if (this.NewestPublishedVersion != null)
                    hash = hash * 59 + this.NewestPublishedVersion.GetHashCode();
                if (this.NewestVersion != null)
                    hash = hash * 59 + this.NewestVersion.GetHashCode();
                if (this.AssociatedWorkspaces != null)
                    hash = hash * 59 + this.AssociatedWorkspaces.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.HasDraft != null)
                    hash = hash * 59 + this.HasDraft.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
