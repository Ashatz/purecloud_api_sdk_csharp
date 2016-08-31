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
    /// DomainLogicalInterface
    /// </summary>
    [DataContract]
    public partial class DomainLogicalInterface :  IEquatable<DomainLogicalInterface>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "inactive"
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Deleted for "deleted"
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted
        }
        /// <summary>
        /// The type of this network interface.
        /// </summary>
        /// <value>The type of this network interface.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InterfaceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Diagnostic for "DIAGNOSTIC"
            /// </summary>
            [EnumMember(Value = "DIAGNOSTIC")]
            Diagnostic,
            
            /// <summary>
            /// Enum System for "SYSTEM"
            /// </summary>
            [EnumMember(Value = "SYSTEM")]
            System
        }
        /// <summary>
        /// Gets or Sets CurrentState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrentStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Init for "INIT"
            /// </summary>
            [EnumMember(Value = "INIT")]
            Init,
            
            /// <summary>
            /// Enum Creating for "CREATING"
            /// </summary>
            [EnumMember(Value = "CREATING")]
            Creating,
            
            /// <summary>
            /// Enum Updating for "UPDATING"
            /// </summary>
            [EnumMember(Value = "UPDATING")]
            Updating,
            
            /// <summary>
            /// Enum Ok for "OK"
            /// </summary>
            [EnumMember(Value = "OK")]
            Ok,
            
            /// <summary>
            /// Enum Exception for "EXCEPTION"
            /// </summary>
            [EnumMember(Value = "EXCEPTION")]
            Exception,
            
            /// <summary>
            /// Enum Deleting for "DELETING"
            /// </summary>
            [EnumMember(Value = "DELETING")]
            Deleting
        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// The type of this network interface.
        /// </summary>
        /// <value>The type of this network interface.</value>
        [DataMember(Name="interfaceType", EmitDefaultValue=false)]
        public InterfaceTypeEnum? InterfaceType { get; set; }
        /// <summary>
        /// Gets or Sets CurrentState
        /// </summary>
        [DataMember(Name="currentState", EmitDefaultValue=false)]
        public CurrentStateEnum? CurrentState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainLogicalInterface" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DomainLogicalInterface() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainLogicalInterface" /> class.
        /// </summary>
        /// <param name="Name">The name of the entity. (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="Version">Version.</param>
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="State">State.</param>
        /// <param name="ModifiedByApp">ModifiedByApp.</param>
        /// <param name="CreatedByApp">CreatedByApp.</param>
        /// <param name="EdgeUri">EdgeUri.</param>
        /// <param name="EdgeAssignedId">EdgeAssignedId.</param>
        /// <param name="FriendlyName">Friendly Name (required).</param>
        /// <param name="VlanTagId">VlanTagId.</param>
        /// <param name="HardwareAddress">Hardware Address (required).</param>
        /// <param name="PhysicalAdapterId">Physical Adapter Id (required).</param>
        /// <param name="IfStatus">IfStatus.</param>
        /// <param name="Routes">The list of routes assigned to this interface..</param>
        /// <param name="Addresses">The list of IP addresses on this interface.  Priority of dns addresses are based on order in the list..</param>
        /// <param name="Ipv4Capabilities">IPv4 interface settings..</param>
        /// <param name="Ipv6Capabilities">IPv6 interface settings..</param>
        /// <param name="CurrentState">CurrentState.</param>
        /// <param name="LastModifiedUserId">LastModifiedUserId.</param>
        /// <param name="LastModifiedCorrelationId">LastModifiedCorrelationId.</param>
        /// <param name="CommandResponses">CommandResponses.</param>
        /// <param name="InheritPhoneTrunkBasesIPv4">The IPv4 phone trunk base assignment will be inherited from the Edge Group. (default to false).</param>
        /// <param name="InheritPhoneTrunkBasesIPv6">The IPv6 phone trunk base assignment will be inherited from the Edge Group. (default to false).</param>
        /// <param name="UseForInternalEdgeCommunication">This interface will be used for all internal edge-to-edge communication using settings from the edgeTrunkBaseAssignment on the Edge Group. (default to false).</param>
        /// <param name="ExternalTrunkBaseAssignments">External trunk base settings to use for external communication from this interface..</param>
        /// <param name="PhoneTrunkBaseAssignments">Phone trunk base settings to use for phone communication from this interface.  These settings will be ignored when \&quot;inheritPhoneTrunkBases\&quot; is true..</param>
        public DomainLogicalInterface(string Name = null, string Description = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, StateEnum? State = null, string ModifiedByApp = null, string CreatedByApp = null, string EdgeUri = null, string EdgeAssignedId = null, string FriendlyName = null, int? VlanTagId = null, string HardwareAddress = null, string PhysicalAdapterId = null, string IfStatus = null, List<DomainNetworkRoute> Routes = null, List<DomainNetworkAddress> Addresses = null, DomainCapabilities Ipv4Capabilities = null, DomainCapabilities Ipv6Capabilities = null, CurrentStateEnum? CurrentState = null, string LastModifiedUserId = null, string LastModifiedCorrelationId = null, List<DomainNetworkCommandResponse> CommandResponses = null, bool? InheritPhoneTrunkBasesIPv4 = null, bool? InheritPhoneTrunkBasesIPv6 = null, bool? UseForInternalEdgeCommunication = null, List<TrunkBaseAssignment> ExternalTrunkBaseAssignments = null, List<TrunkBaseAssignment> PhoneTrunkBaseAssignments = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DomainLogicalInterface and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "FriendlyName" is required (not null)
            if (FriendlyName == null)
            {
                throw new InvalidDataException("FriendlyName is a required property for DomainLogicalInterface and cannot be null");
            }
            else
            {
                this.FriendlyName = FriendlyName;
            }
            // to ensure "HardwareAddress" is required (not null)
            if (HardwareAddress == null)
            {
                throw new InvalidDataException("HardwareAddress is a required property for DomainLogicalInterface and cannot be null");
            }
            else
            {
                this.HardwareAddress = HardwareAddress;
            }
            // to ensure "PhysicalAdapterId" is required (not null)
            if (PhysicalAdapterId == null)
            {
                throw new InvalidDataException("PhysicalAdapterId is a required property for DomainLogicalInterface and cannot be null");
            }
            else
            {
                this.PhysicalAdapterId = PhysicalAdapterId;
            }
            this.Description = Description;
            this.Version = Version;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            this.CreatedBy = CreatedBy;
            this.State = State;
            this.ModifiedByApp = ModifiedByApp;
            this.CreatedByApp = CreatedByApp;
            this.EdgeUri = EdgeUri;
            this.EdgeAssignedId = EdgeAssignedId;
            this.VlanTagId = VlanTagId;
            this.IfStatus = IfStatus;
            this.Routes = Routes;
            this.Addresses = Addresses;
            this.Ipv4Capabilities = Ipv4Capabilities;
            this.Ipv6Capabilities = Ipv6Capabilities;
            this.CurrentState = CurrentState;
            this.LastModifiedUserId = LastModifiedUserId;
            this.LastModifiedCorrelationId = LastModifiedCorrelationId;
            this.CommandResponses = CommandResponses;
            // use default value if no "InheritPhoneTrunkBasesIPv4" provided
            if (InheritPhoneTrunkBasesIPv4 == null)
            {
                this.InheritPhoneTrunkBasesIPv4 = false;
            }
            else
            {
                this.InheritPhoneTrunkBasesIPv4 = InheritPhoneTrunkBasesIPv4;
            }
            // use default value if no "InheritPhoneTrunkBasesIPv6" provided
            if (InheritPhoneTrunkBasesIPv6 == null)
            {
                this.InheritPhoneTrunkBasesIPv6 = false;
            }
            else
            {
                this.InheritPhoneTrunkBasesIPv6 = InheritPhoneTrunkBasesIPv6;
            }
            // use default value if no "UseForInternalEdgeCommunication" provided
            if (UseForInternalEdgeCommunication == null)
            {
                this.UseForInternalEdgeCommunication = false;
            }
            else
            {
                this.UseForInternalEdgeCommunication = UseForInternalEdgeCommunication;
            }
            this.ExternalTrunkBaseAssignments = ExternalTrunkBaseAssignments;
            this.PhoneTrunkBaseAssignments = PhoneTrunkBaseAssignments;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The name of the entity.
        /// </summary>
        /// <value>The name of the entity.</value>
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
        /// Gets or Sets EdgeUri
        /// </summary>
        [DataMember(Name="edgeUri", EmitDefaultValue=false)]
        public string EdgeUri { get; set; }
        /// <summary>
        /// Gets or Sets EdgeAssignedId
        /// </summary>
        [DataMember(Name="edgeAssignedId", EmitDefaultValue=false)]
        public string EdgeAssignedId { get; set; }
        /// <summary>
        /// Friendly Name
        /// </summary>
        /// <value>Friendly Name</value>
        [DataMember(Name="friendlyName", EmitDefaultValue=false)]
        public string FriendlyName { get; set; }
        /// <summary>
        /// Gets or Sets VlanTagId
        /// </summary>
        [DataMember(Name="vlanTagId", EmitDefaultValue=false)]
        public int? VlanTagId { get; set; }
        /// <summary>
        /// Hardware Address
        /// </summary>
        /// <value>Hardware Address</value>
        [DataMember(Name="hardwareAddress", EmitDefaultValue=false)]
        public string HardwareAddress { get; set; }
        /// <summary>
        /// Physical Adapter Id
        /// </summary>
        /// <value>Physical Adapter Id</value>
        [DataMember(Name="physicalAdapterId", EmitDefaultValue=false)]
        public string PhysicalAdapterId { get; set; }
        /// <summary>
        /// Gets or Sets IfStatus
        /// </summary>
        [DataMember(Name="ifStatus", EmitDefaultValue=false)]
        public string IfStatus { get; set; }
        /// <summary>
        /// The list of routes assigned to this interface.
        /// </summary>
        /// <value>The list of routes assigned to this interface.</value>
        [DataMember(Name="routes", EmitDefaultValue=false)]
        public List<DomainNetworkRoute> Routes { get; set; }
        /// <summary>
        /// The list of IP addresses on this interface.  Priority of dns addresses are based on order in the list.
        /// </summary>
        /// <value>The list of IP addresses on this interface.  Priority of dns addresses are based on order in the list.</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<DomainNetworkAddress> Addresses { get; set; }
        /// <summary>
        /// IPv4 interface settings.
        /// </summary>
        /// <value>IPv4 interface settings.</value>
        [DataMember(Name="ipv4Capabilities", EmitDefaultValue=false)]
        public DomainCapabilities Ipv4Capabilities { get; set; }
        /// <summary>
        /// IPv6 interface settings.
        /// </summary>
        /// <value>IPv6 interface settings.</value>
        [DataMember(Name="ipv6Capabilities", EmitDefaultValue=false)]
        public DomainCapabilities Ipv6Capabilities { get; set; }
        /// <summary>
        /// Gets or Sets LastModifiedUserId
        /// </summary>
        [DataMember(Name="lastModifiedUserId", EmitDefaultValue=false)]
        public string LastModifiedUserId { get; set; }
        /// <summary>
        /// Gets or Sets LastModifiedCorrelationId
        /// </summary>
        [DataMember(Name="lastModifiedCorrelationId", EmitDefaultValue=false)]
        public string LastModifiedCorrelationId { get; set; }
        /// <summary>
        /// Gets or Sets CommandResponses
        /// </summary>
        [DataMember(Name="commandResponses", EmitDefaultValue=false)]
        public List<DomainNetworkCommandResponse> CommandResponses { get; set; }
        /// <summary>
        /// The IPv4 phone trunk base assignment will be inherited from the Edge Group.
        /// </summary>
        /// <value>The IPv4 phone trunk base assignment will be inherited from the Edge Group.</value>
        [DataMember(Name="inheritPhoneTrunkBasesIPv4", EmitDefaultValue=false)]
        public bool? InheritPhoneTrunkBasesIPv4 { get; set; }
        /// <summary>
        /// The IPv6 phone trunk base assignment will be inherited from the Edge Group.
        /// </summary>
        /// <value>The IPv6 phone trunk base assignment will be inherited from the Edge Group.</value>
        [DataMember(Name="inheritPhoneTrunkBasesIPv6", EmitDefaultValue=false)]
        public bool? InheritPhoneTrunkBasesIPv6 { get; set; }
        /// <summary>
        /// This interface will be used for all internal edge-to-edge communication using settings from the edgeTrunkBaseAssignment on the Edge Group.
        /// </summary>
        /// <value>This interface will be used for all internal edge-to-edge communication using settings from the edgeTrunkBaseAssignment on the Edge Group.</value>
        [DataMember(Name="useForInternalEdgeCommunication", EmitDefaultValue=false)]
        public bool? UseForInternalEdgeCommunication { get; set; }
        /// <summary>
        /// External trunk base settings to use for external communication from this interface.
        /// </summary>
        /// <value>External trunk base settings to use for external communication from this interface.</value>
        [DataMember(Name="externalTrunkBaseAssignments", EmitDefaultValue=false)]
        public List<TrunkBaseAssignment> ExternalTrunkBaseAssignments { get; set; }
        /// <summary>
        /// Phone trunk base settings to use for phone communication from this interface.  These settings will be ignored when \&quot;inheritPhoneTrunkBases\&quot; is true.
        /// </summary>
        /// <value>Phone trunk base settings to use for phone communication from this interface.  These settings will be ignored when \&quot;inheritPhoneTrunkBases\&quot; is true.</value>
        [DataMember(Name="phoneTrunkBaseAssignments", EmitDefaultValue=false)]
        public List<TrunkBaseAssignment> PhoneTrunkBaseAssignments { get; set; }
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
            sb.Append("class DomainLogicalInterface {\n");
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
            sb.Append("  EdgeUri: ").Append(EdgeUri).Append("\n");
            sb.Append("  EdgeAssignedId: ").Append(EdgeAssignedId).Append("\n");
            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  VlanTagId: ").Append(VlanTagId).Append("\n");
            sb.Append("  HardwareAddress: ").Append(HardwareAddress).Append("\n");
            sb.Append("  PhysicalAdapterId: ").Append(PhysicalAdapterId).Append("\n");
            sb.Append("  IfStatus: ").Append(IfStatus).Append("\n");
            sb.Append("  InterfaceType: ").Append(InterfaceType).Append("\n");
            sb.Append("  Routes: ").Append(Routes).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Ipv4Capabilities: ").Append(Ipv4Capabilities).Append("\n");
            sb.Append("  Ipv6Capabilities: ").Append(Ipv6Capabilities).Append("\n");
            sb.Append("  CurrentState: ").Append(CurrentState).Append("\n");
            sb.Append("  LastModifiedUserId: ").Append(LastModifiedUserId).Append("\n");
            sb.Append("  LastModifiedCorrelationId: ").Append(LastModifiedCorrelationId).Append("\n");
            sb.Append("  CommandResponses: ").Append(CommandResponses).Append("\n");
            sb.Append("  InheritPhoneTrunkBasesIPv4: ").Append(InheritPhoneTrunkBasesIPv4).Append("\n");
            sb.Append("  InheritPhoneTrunkBasesIPv6: ").Append(InheritPhoneTrunkBasesIPv6).Append("\n");
            sb.Append("  UseForInternalEdgeCommunication: ").Append(UseForInternalEdgeCommunication).Append("\n");
            sb.Append("  ExternalTrunkBaseAssignments: ").Append(ExternalTrunkBaseAssignments).Append("\n");
            sb.Append("  PhoneTrunkBaseAssignments: ").Append(PhoneTrunkBaseAssignments).Append("\n");
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
            return this.Equals(obj as DomainLogicalInterface);
        }

        /// <summary>
        /// Returns true if DomainLogicalInterface instances are equal
        /// </summary>
        /// <param name="other">Instance of DomainLogicalInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainLogicalInterface other)
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
                    this.EdgeUri == other.EdgeUri ||
                    this.EdgeUri != null &&
                    this.EdgeUri.Equals(other.EdgeUri)
                ) &&
                (
                    this.EdgeAssignedId == other.EdgeAssignedId ||
                    this.EdgeAssignedId != null &&
                    this.EdgeAssignedId.Equals(other.EdgeAssignedId)
                ) &&
                (
                    this.FriendlyName == other.FriendlyName ||
                    this.FriendlyName != null &&
                    this.FriendlyName.Equals(other.FriendlyName)
                ) &&
                (
                    this.VlanTagId == other.VlanTagId ||
                    this.VlanTagId != null &&
                    this.VlanTagId.Equals(other.VlanTagId)
                ) &&
                (
                    this.HardwareAddress == other.HardwareAddress ||
                    this.HardwareAddress != null &&
                    this.HardwareAddress.Equals(other.HardwareAddress)
                ) &&
                (
                    this.PhysicalAdapterId == other.PhysicalAdapterId ||
                    this.PhysicalAdapterId != null &&
                    this.PhysicalAdapterId.Equals(other.PhysicalAdapterId)
                ) &&
                (
                    this.IfStatus == other.IfStatus ||
                    this.IfStatus != null &&
                    this.IfStatus.Equals(other.IfStatus)
                ) &&
                (
                    this.InterfaceType == other.InterfaceType ||
                    this.InterfaceType != null &&
                    this.InterfaceType.Equals(other.InterfaceType)
                ) &&
                (
                    this.Routes == other.Routes ||
                    this.Routes != null &&
                    this.Routes.SequenceEqual(other.Routes)
                ) &&
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) &&
                (
                    this.Ipv4Capabilities == other.Ipv4Capabilities ||
                    this.Ipv4Capabilities != null &&
                    this.Ipv4Capabilities.Equals(other.Ipv4Capabilities)
                ) &&
                (
                    this.Ipv6Capabilities == other.Ipv6Capabilities ||
                    this.Ipv6Capabilities != null &&
                    this.Ipv6Capabilities.Equals(other.Ipv6Capabilities)
                ) &&
                (
                    this.CurrentState == other.CurrentState ||
                    this.CurrentState != null &&
                    this.CurrentState.Equals(other.CurrentState)
                ) &&
                (
                    this.LastModifiedUserId == other.LastModifiedUserId ||
                    this.LastModifiedUserId != null &&
                    this.LastModifiedUserId.Equals(other.LastModifiedUserId)
                ) &&
                (
                    this.LastModifiedCorrelationId == other.LastModifiedCorrelationId ||
                    this.LastModifiedCorrelationId != null &&
                    this.LastModifiedCorrelationId.Equals(other.LastModifiedCorrelationId)
                ) &&
                (
                    this.CommandResponses == other.CommandResponses ||
                    this.CommandResponses != null &&
                    this.CommandResponses.SequenceEqual(other.CommandResponses)
                ) &&
                (
                    this.InheritPhoneTrunkBasesIPv4 == other.InheritPhoneTrunkBasesIPv4 ||
                    this.InheritPhoneTrunkBasesIPv4 != null &&
                    this.InheritPhoneTrunkBasesIPv4.Equals(other.InheritPhoneTrunkBasesIPv4)
                ) &&
                (
                    this.InheritPhoneTrunkBasesIPv6 == other.InheritPhoneTrunkBasesIPv6 ||
                    this.InheritPhoneTrunkBasesIPv6 != null &&
                    this.InheritPhoneTrunkBasesIPv6.Equals(other.InheritPhoneTrunkBasesIPv6)
                ) &&
                (
                    this.UseForInternalEdgeCommunication == other.UseForInternalEdgeCommunication ||
                    this.UseForInternalEdgeCommunication != null &&
                    this.UseForInternalEdgeCommunication.Equals(other.UseForInternalEdgeCommunication)
                ) &&
                (
                    this.ExternalTrunkBaseAssignments == other.ExternalTrunkBaseAssignments ||
                    this.ExternalTrunkBaseAssignments != null &&
                    this.ExternalTrunkBaseAssignments.SequenceEqual(other.ExternalTrunkBaseAssignments)
                ) &&
                (
                    this.PhoneTrunkBaseAssignments == other.PhoneTrunkBaseAssignments ||
                    this.PhoneTrunkBaseAssignments != null &&
                    this.PhoneTrunkBaseAssignments.SequenceEqual(other.PhoneTrunkBaseAssignments)
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
                if (this.EdgeUri != null)
                    hash = hash * 59 + this.EdgeUri.GetHashCode();
                if (this.EdgeAssignedId != null)
                    hash = hash * 59 + this.EdgeAssignedId.GetHashCode();
                if (this.FriendlyName != null)
                    hash = hash * 59 + this.FriendlyName.GetHashCode();
                if (this.VlanTagId != null)
                    hash = hash * 59 + this.VlanTagId.GetHashCode();
                if (this.HardwareAddress != null)
                    hash = hash * 59 + this.HardwareAddress.GetHashCode();
                if (this.PhysicalAdapterId != null)
                    hash = hash * 59 + this.PhysicalAdapterId.GetHashCode();
                if (this.IfStatus != null)
                    hash = hash * 59 + this.IfStatus.GetHashCode();
                if (this.InterfaceType != null)
                    hash = hash * 59 + this.InterfaceType.GetHashCode();
                if (this.Routes != null)
                    hash = hash * 59 + this.Routes.GetHashCode();
                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                if (this.Ipv4Capabilities != null)
                    hash = hash * 59 + this.Ipv4Capabilities.GetHashCode();
                if (this.Ipv6Capabilities != null)
                    hash = hash * 59 + this.Ipv6Capabilities.GetHashCode();
                if (this.CurrentState != null)
                    hash = hash * 59 + this.CurrentState.GetHashCode();
                if (this.LastModifiedUserId != null)
                    hash = hash * 59 + this.LastModifiedUserId.GetHashCode();
                if (this.LastModifiedCorrelationId != null)
                    hash = hash * 59 + this.LastModifiedCorrelationId.GetHashCode();
                if (this.CommandResponses != null)
                    hash = hash * 59 + this.CommandResponses.GetHashCode();
                if (this.InheritPhoneTrunkBasesIPv4 != null)
                    hash = hash * 59 + this.InheritPhoneTrunkBasesIPv4.GetHashCode();
                if (this.InheritPhoneTrunkBasesIPv6 != null)
                    hash = hash * 59 + this.InheritPhoneTrunkBasesIPv6.GetHashCode();
                if (this.UseForInternalEdgeCommunication != null)
                    hash = hash * 59 + this.UseForInternalEdgeCommunication.GetHashCode();
                if (this.ExternalTrunkBaseAssignments != null)
                    hash = hash * 59 + this.ExternalTrunkBaseAssignments.GetHashCode();
                if (this.PhoneTrunkBaseAssignments != null)
                    hash = hash * 59 + this.PhoneTrunkBaseAssignments.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
