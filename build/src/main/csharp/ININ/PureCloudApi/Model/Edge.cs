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
    public partial class Edge :  IEquatable<Edge>
    { 

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum {
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            
            [EnumMember(Value = "DELETED")]
            Deleted
        }


        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusCodeEnum {
            
            [EnumMember(Value = "NEW")]
            New,
            
            [EnumMember(Value = "AWAITING_CONNECTION")]
            AwaitingConnection,
            
            [EnumMember(Value = "AWAITING_FINGERPRINT")]
            AwaitingFingerprint,
            
            [EnumMember(Value = "AWAITING_FINGERPRINT_VERIFICATION")]
            AwaitingFingerprintVerification,
            
            [EnumMember(Value = "FINGERPRINT_VERIFIED")]
            FingerprintVerified,
            
            [EnumMember(Value = "AWAITING_BOOTSTRAP")]
            AwaitingBootstrap,
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            
            [EnumMember(Value = "RMA")]
            Rma,
            
            [EnumMember(Value = "UNPAIRING")]
            Unpairing,
            
            [EnumMember(Value = "UNPAIRED")]
            Unpaired
        }


        /// <summary>
        /// Gets or Sets OnlineStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OnlineStatusEnum {
            
            [EnumMember(Value = "ONLINE")]
            Online,
            
            [EnumMember(Value = "OFFLINE")]
            Offline
        }

        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public StatusCodeEnum? StatusCode { get; set; }
    
        /// <summary>
        /// Gets or Sets OnlineStatus
        /// </summary>
        [DataMember(Name="onlineStatus", EmitDefaultValue=false)]
        public OnlineStatusEnum? OnlineStatus { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Edge" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Version">Version.</param>
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="State">State.</param>
        /// <param name="ModifiedByApp">ModifiedByApp.</param>
        /// <param name="CreatedByApp">CreatedByApp.</param>
        /// <param name="Interfaces">Interfaces.</param>
        /// <param name="Make">Make.</param>
        /// <param name="Model">Model.</param>
        /// <param name="ApiVersion">ApiVersion.</param>
        /// <param name="SoftwareVersion">SoftwareVersion.</param>
        /// <param name="SoftwareVersionTimestamp">SoftwareVersionTimestamp.</param>
        /// <param name="SoftwareVersionPlatform">SoftwareVersionPlatform.</param>
        /// <param name="SoftwareVersionConfiguration">SoftwareVersionConfiguration.</param>
        /// <param name="FullSoftwareVersion">FullSoftwareVersion.</param>
        /// <param name="PairingId">PairingId.</param>
        /// <param name="Fingerprint">Fingerprint.</param>
        /// <param name="FingerprintHint">FingerprintHint.</param>
        /// <param name="CurrentVersion">CurrentVersion.</param>
        /// <param name="StagedVersion">StagedVersion.</param>
        /// <param name="Patch">Patch.</param>
        /// <param name="StatusCode">StatusCode.</param>
        /// <param name="EdgeGroup">EdgeGroup.</param>
        /// <param name="Site">Site.</param>
        /// <param name="SoftwareStatus">SoftwareStatus.</param>
        /// <param name="OnlineStatus">OnlineStatus.</param>
        /// <param name="SerialNumber">SerialNumber.</param>
        /// <param name="PhysicalEdge">PhysicalEdge (default to false).</param>
        /// <param name="Managed">Managed (default to false).</param>

        public Edge(string Name = null, string Description = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, StateEnum? State = null, string ModifiedByApp = null, string CreatedByApp = null, List<EdgeInterface> Interfaces = null, string Make = null, string Model = null, string ApiVersion = null, string SoftwareVersion = null, string SoftwareVersionTimestamp = null, string SoftwareVersionPlatform = null, string SoftwareVersionConfiguration = null, string FullSoftwareVersion = null, string PairingId = null, string Fingerprint = null, string FingerprintHint = null, string CurrentVersion = null, string StagedVersion = null, string Patch = null, StatusCodeEnum? StatusCode = null, EdgeGroup EdgeGroup = null, UriReference Site = null, DomainEdgeSoftwareUpdateDto SoftwareStatus = null, OnlineStatusEnum? OnlineStatus = null, string SerialNumber = null, bool? PhysicalEdge = null, bool? Managed = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Version = Version;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            this.CreatedBy = CreatedBy;
            this.State = State;
            this.ModifiedByApp = ModifiedByApp;
            this.CreatedByApp = CreatedByApp;
            this.Interfaces = Interfaces;
            this.Make = Make;
            this.Model = Model;
            this.ApiVersion = ApiVersion;
            this.SoftwareVersion = SoftwareVersion;
            this.SoftwareVersionTimestamp = SoftwareVersionTimestamp;
            this.SoftwareVersionPlatform = SoftwareVersionPlatform;
            this.SoftwareVersionConfiguration = SoftwareVersionConfiguration;
            this.FullSoftwareVersion = FullSoftwareVersion;
            this.PairingId = PairingId;
            this.Fingerprint = Fingerprint;
            this.FingerprintHint = FingerprintHint;
            this.CurrentVersion = CurrentVersion;
            this.StagedVersion = StagedVersion;
            this.Patch = Patch;
            this.StatusCode = StatusCode;
            this.EdgeGroup = EdgeGroup;
            this.Site = Site;
            this.SoftwareStatus = SoftwareStatus;
            this.OnlineStatus = OnlineStatus;
            this.SerialNumber = SerialNumber;
            // use default value if no "PhysicalEdge" provided
            if (PhysicalEdge == null)
            {
                this.PhysicalEdge = false;
            }
            else
            {
                this.PhysicalEdge = PhysicalEdge;
            }
            // use default value if no "Managed" provided
            if (Managed == null)
            {
                this.Managed = false;
            }
            else
            {
                this.Managed = Managed;
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
    
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or Sets ModifiedByApp
        /// </summary>
        [DataMember(Name="modifiedByApp", EmitDefaultValue=false)]
        public string ModifiedByApp { get; set; }
    
        /// <summary>
        /// Gets or Sets CreatedByApp
        /// </summary>
        [DataMember(Name="createdByApp", EmitDefaultValue=false)]
        public string CreatedByApp { get; set; }
    
        /// <summary>
        /// Gets or Sets Interfaces
        /// </summary>
        [DataMember(Name="interfaces", EmitDefaultValue=false)]
        public List<EdgeInterface> Interfaces { get; set; }
    
        /// <summary>
        /// Gets or Sets Make
        /// </summary>
        [DataMember(Name="make", EmitDefaultValue=false)]
        public string Make { get; set; }
    
        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }
    
        /// <summary>
        /// Gets or Sets SoftwareVersion
        /// </summary>
        [DataMember(Name="softwareVersion", EmitDefaultValue=false)]
        public string SoftwareVersion { get; set; }
    
        /// <summary>
        /// Gets or Sets SoftwareVersionTimestamp
        /// </summary>
        [DataMember(Name="softwareVersionTimestamp", EmitDefaultValue=false)]
        public string SoftwareVersionTimestamp { get; set; }
    
        /// <summary>
        /// Gets or Sets SoftwareVersionPlatform
        /// </summary>
        [DataMember(Name="softwareVersionPlatform", EmitDefaultValue=false)]
        public string SoftwareVersionPlatform { get; set; }
    
        /// <summary>
        /// Gets or Sets SoftwareVersionConfiguration
        /// </summary>
        [DataMember(Name="softwareVersionConfiguration", EmitDefaultValue=false)]
        public string SoftwareVersionConfiguration { get; set; }
    
        /// <summary>
        /// Gets or Sets FullSoftwareVersion
        /// </summary>
        [DataMember(Name="fullSoftwareVersion", EmitDefaultValue=false)]
        public string FullSoftwareVersion { get; set; }
    
        /// <summary>
        /// Gets or Sets PairingId
        /// </summary>
        [DataMember(Name="pairingId", EmitDefaultValue=false)]
        public string PairingId { get; set; }
    
        /// <summary>
        /// Gets or Sets Fingerprint
        /// </summary>
        [DataMember(Name="fingerprint", EmitDefaultValue=false)]
        public string Fingerprint { get; set; }
    
        /// <summary>
        /// Gets or Sets FingerprintHint
        /// </summary>
        [DataMember(Name="fingerprintHint", EmitDefaultValue=false)]
        public string FingerprintHint { get; set; }
    
        /// <summary>
        /// Gets or Sets CurrentVersion
        /// </summary>
        [DataMember(Name="currentVersion", EmitDefaultValue=false)]
        public string CurrentVersion { get; set; }
    
        /// <summary>
        /// Gets or Sets StagedVersion
        /// </summary>
        [DataMember(Name="stagedVersion", EmitDefaultValue=false)]
        public string StagedVersion { get; set; }
    
        /// <summary>
        /// Gets or Sets Patch
        /// </summary>
        [DataMember(Name="patch", EmitDefaultValue=false)]
        public string Patch { get; set; }
    
        /// <summary>
        /// Gets or Sets EdgeGroup
        /// </summary>
        [DataMember(Name="edgeGroup", EmitDefaultValue=false)]
        public EdgeGroup EdgeGroup { get; set; }
    
        /// <summary>
        /// Gets or Sets Site
        /// </summary>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public UriReference Site { get; set; }
    
        /// <summary>
        /// Gets or Sets SoftwareStatus
        /// </summary>
        [DataMember(Name="softwareStatus", EmitDefaultValue=false)]
        public DomainEdgeSoftwareUpdateDto SoftwareStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="serialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets PhysicalEdge
        /// </summary>
        [DataMember(Name="physicalEdge", EmitDefaultValue=false)]
        public bool? PhysicalEdge { get; set; }
    
        /// <summary>
        /// Gets or Sets Managed
        /// </summary>
        [DataMember(Name="managed", EmitDefaultValue=false)]
        public bool? Managed { get; set; }
    
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
            sb.Append("class Edge {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ModifiedByApp: ").Append(ModifiedByApp).Append("\n");
            sb.Append("  CreatedByApp: ").Append(CreatedByApp).Append("\n");
            sb.Append("  Interfaces: ").Append(Interfaces).Append("\n");
            sb.Append("  Make: ").Append(Make).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
            sb.Append("  SoftwareVersionTimestamp: ").Append(SoftwareVersionTimestamp).Append("\n");
            sb.Append("  SoftwareVersionPlatform: ").Append(SoftwareVersionPlatform).Append("\n");
            sb.Append("  SoftwareVersionConfiguration: ").Append(SoftwareVersionConfiguration).Append("\n");
            sb.Append("  FullSoftwareVersion: ").Append(FullSoftwareVersion).Append("\n");
            sb.Append("  PairingId: ").Append(PairingId).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  FingerprintHint: ").Append(FingerprintHint).Append("\n");
            sb.Append("  CurrentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  StagedVersion: ").Append(StagedVersion).Append("\n");
            sb.Append("  Patch: ").Append(Patch).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  EdgeGroup: ").Append(EdgeGroup).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  SoftwareStatus: ").Append(SoftwareStatus).Append("\n");
            sb.Append("  OnlineStatus: ").Append(OnlineStatus).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  PhysicalEdge: ").Append(PhysicalEdge).Append("\n");
            sb.Append("  Managed: ").Append(Managed).Append("\n");
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
            return this.Equals(obj as Edge);
        }

        /// <summary>
        /// Returns true if Edge instances are equal
        /// </summary>
        /// <param name="other">Instance of Edge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Edge other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ModifiedByApp == other.ModifiedByApp ||
                    this.ModifiedByApp != null &&
                    this.ModifiedByApp.Equals(other.ModifiedByApp)
                ) &&
                (
                    this.CreatedByApp == other.CreatedByApp ||
                    this.CreatedByApp != null &&
                    this.CreatedByApp.Equals(other.CreatedByApp)
                ) &&
                (
                    this.Interfaces == other.Interfaces ||
                    this.Interfaces != null &&
                    this.Interfaces.SequenceEqual(other.Interfaces)
                ) &&
                (
                    this.Make == other.Make ||
                    this.Make != null &&
                    this.Make.Equals(other.Make)
                ) &&
                (
                    this.Model == other.Model ||
                    this.Model != null &&
                    this.Model.Equals(other.Model)
                ) &&
                (
                    this.ApiVersion == other.ApiVersion ||
                    this.ApiVersion != null &&
                    this.ApiVersion.Equals(other.ApiVersion)
                ) &&
                (
                    this.SoftwareVersion == other.SoftwareVersion ||
                    this.SoftwareVersion != null &&
                    this.SoftwareVersion.Equals(other.SoftwareVersion)
                ) &&
                (
                    this.SoftwareVersionTimestamp == other.SoftwareVersionTimestamp ||
                    this.SoftwareVersionTimestamp != null &&
                    this.SoftwareVersionTimestamp.Equals(other.SoftwareVersionTimestamp)
                ) &&
                (
                    this.SoftwareVersionPlatform == other.SoftwareVersionPlatform ||
                    this.SoftwareVersionPlatform != null &&
                    this.SoftwareVersionPlatform.Equals(other.SoftwareVersionPlatform)
                ) &&
                (
                    this.SoftwareVersionConfiguration == other.SoftwareVersionConfiguration ||
                    this.SoftwareVersionConfiguration != null &&
                    this.SoftwareVersionConfiguration.Equals(other.SoftwareVersionConfiguration)
                ) &&
                (
                    this.FullSoftwareVersion == other.FullSoftwareVersion ||
                    this.FullSoftwareVersion != null &&
                    this.FullSoftwareVersion.Equals(other.FullSoftwareVersion)
                ) &&
                (
                    this.PairingId == other.PairingId ||
                    this.PairingId != null &&
                    this.PairingId.Equals(other.PairingId)
                ) &&
                (
                    this.Fingerprint == other.Fingerprint ||
                    this.Fingerprint != null &&
                    this.Fingerprint.Equals(other.Fingerprint)
                ) &&
                (
                    this.FingerprintHint == other.FingerprintHint ||
                    this.FingerprintHint != null &&
                    this.FingerprintHint.Equals(other.FingerprintHint)
                ) &&
                (
                    this.CurrentVersion == other.CurrentVersion ||
                    this.CurrentVersion != null &&
                    this.CurrentVersion.Equals(other.CurrentVersion)
                ) &&
                (
                    this.StagedVersion == other.StagedVersion ||
                    this.StagedVersion != null &&
                    this.StagedVersion.Equals(other.StagedVersion)
                ) &&
                (
                    this.Patch == other.Patch ||
                    this.Patch != null &&
                    this.Patch.Equals(other.Patch)
                ) &&
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                ) &&
                (
                    this.EdgeGroup == other.EdgeGroup ||
                    this.EdgeGroup != null &&
                    this.EdgeGroup.Equals(other.EdgeGroup)
                ) &&
                (
                    this.Site == other.Site ||
                    this.Site != null &&
                    this.Site.Equals(other.Site)
                ) &&
                (
                    this.SoftwareStatus == other.SoftwareStatus ||
                    this.SoftwareStatus != null &&
                    this.SoftwareStatus.Equals(other.SoftwareStatus)
                ) &&
                (
                    this.OnlineStatus == other.OnlineStatus ||
                    this.OnlineStatus != null &&
                    this.OnlineStatus.Equals(other.OnlineStatus)
                ) &&
                (
                    this.SerialNumber == other.SerialNumber ||
                    this.SerialNumber != null &&
                    this.SerialNumber.Equals(other.SerialNumber)
                ) &&
                (
                    this.PhysicalEdge == other.PhysicalEdge ||
                    this.PhysicalEdge != null &&
                    this.PhysicalEdge.Equals(other.PhysicalEdge)
                ) &&
                (
                    this.Managed == other.Managed ||
                    this.Managed != null &&
                    this.Managed.Equals(other.Managed)
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
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.ModifiedByApp != null)
                    hash = hash * 59 + this.ModifiedByApp.GetHashCode();
                if (this.CreatedByApp != null)
                    hash = hash * 59 + this.CreatedByApp.GetHashCode();
                if (this.Interfaces != null)
                    hash = hash * 59 + this.Interfaces.GetHashCode();
                if (this.Make != null)
                    hash = hash * 59 + this.Make.GetHashCode();
                if (this.Model != null)
                    hash = hash * 59 + this.Model.GetHashCode();
                if (this.ApiVersion != null)
                    hash = hash * 59 + this.ApiVersion.GetHashCode();
                if (this.SoftwareVersion != null)
                    hash = hash * 59 + this.SoftwareVersion.GetHashCode();
                if (this.SoftwareVersionTimestamp != null)
                    hash = hash * 59 + this.SoftwareVersionTimestamp.GetHashCode();
                if (this.SoftwareVersionPlatform != null)
                    hash = hash * 59 + this.SoftwareVersionPlatform.GetHashCode();
                if (this.SoftwareVersionConfiguration != null)
                    hash = hash * 59 + this.SoftwareVersionConfiguration.GetHashCode();
                if (this.FullSoftwareVersion != null)
                    hash = hash * 59 + this.FullSoftwareVersion.GetHashCode();
                if (this.PairingId != null)
                    hash = hash * 59 + this.PairingId.GetHashCode();
                if (this.Fingerprint != null)
                    hash = hash * 59 + this.Fingerprint.GetHashCode();
                if (this.FingerprintHint != null)
                    hash = hash * 59 + this.FingerprintHint.GetHashCode();
                if (this.CurrentVersion != null)
                    hash = hash * 59 + this.CurrentVersion.GetHashCode();
                if (this.StagedVersion != null)
                    hash = hash * 59 + this.StagedVersion.GetHashCode();
                if (this.Patch != null)
                    hash = hash * 59 + this.Patch.GetHashCode();
                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();
                if (this.EdgeGroup != null)
                    hash = hash * 59 + this.EdgeGroup.GetHashCode();
                if (this.Site != null)
                    hash = hash * 59 + this.Site.GetHashCode();
                if (this.SoftwareStatus != null)
                    hash = hash * 59 + this.SoftwareStatus.GetHashCode();
                if (this.OnlineStatus != null)
                    hash = hash * 59 + this.OnlineStatus.GetHashCode();
                if (this.SerialNumber != null)
                    hash = hash * 59 + this.SerialNumber.GetHashCode();
                if (this.PhysicalEdge != null)
                    hash = hash * 59 + this.PhysicalEdge.GetHashCode();
                if (this.Managed != null)
                    hash = hash * 59 + this.Managed.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
