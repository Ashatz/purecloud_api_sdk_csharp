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
    /// Cobrowsesession
    /// </summary>
    [DataContract]
    public partial class Cobrowsesession :  IEquatable<Cobrowsesession>
    {
        /// <summary>
        /// The connection state of this communication.
        /// </summary>
        /// <value>The connection state of this communication.</value>
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
            /// Enum Alerting for "ALERTING"
            /// </summary>
            [EnumMember(Value = "ALERTING")]
            Alerting,
            
            /// <summary>
            /// Enum Dialing for "DIALING"
            /// </summary>
            [EnumMember(Value = "DIALING")]
            Dialing,
            
            /// <summary>
            /// Enum Contacting for "CONTACTING"
            /// </summary>
            [EnumMember(Value = "CONTACTING")]
            Contacting,
            
            /// <summary>
            /// Enum Offering for "OFFERING"
            /// </summary>
            [EnumMember(Value = "OFFERING")]
            Offering,
            
            /// <summary>
            /// Enum Connected for "CONNECTED"
            /// </summary>
            [EnumMember(Value = "CONNECTED")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "DISCONNECTED"
            /// </summary>
            [EnumMember(Value = "DISCONNECTED")]
            Disconnected,
            
            /// <summary>
            /// Enum Terminated for "TERMINATED"
            /// </summary>
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            
            /// <summary>
            /// Enum Scheduled for "SCHEDULED"
            /// </summary>
            [EnumMember(Value = "SCHEDULED")]
            Scheduled,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None
        }
        /// <summary>
        /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
        /// </summary>
        /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisconnectTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Endpoint for "ENDPOINT"
            /// </summary>
            [EnumMember(Value = "ENDPOINT")]
            Endpoint,
            
            /// <summary>
            /// Enum Client for "CLIENT"
            /// </summary>
            [EnumMember(Value = "CLIENT")]
            Client,
            
            /// <summary>
            /// Enum System for "SYSTEM"
            /// </summary>
            [EnumMember(Value = "SYSTEM")]
            System,
            
            /// <summary>
            /// Enum Timeout for "TIMEOUT"
            /// </summary>
            [EnumMember(Value = "TIMEOUT")]
            Timeout,
            
            /// <summary>
            /// Enum Transfer for "TRANSFER"
            /// </summary>
            [EnumMember(Value = "TRANSFER")]
            Transfer,
            
            /// <summary>
            /// Enum TransferConference for "TRANSFER_CONFERENCE"
            /// </summary>
            [EnumMember(Value = "TRANSFER_CONFERENCE")]
            TransferConference,
            
            /// <summary>
            /// Enum TransferConsult for "TRANSFER_CONSULT"
            /// </summary>
            [EnumMember(Value = "TRANSFER_CONSULT")]
            TransferConsult,
            
            /// <summary>
            /// Enum TransferForward for "TRANSFER_FORWARD"
            /// </summary>
            [EnumMember(Value = "TRANSFER_FORWARD")]
            TransferForward,
            
            /// <summary>
            /// Enum TransportFailure for "TRANSPORT_FAILURE"
            /// </summary>
            [EnumMember(Value = "TRANSPORT_FAILURE")]
            TransportFailure,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error,
            
            /// <summary>
            /// Enum Peer for "PEER"
            /// </summary>
            [EnumMember(Value = "PEER")]
            Peer,
            
            /// <summary>
            /// Enum Other for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            Other,
            
            /// <summary>
            /// Enum Spam for "SPAM"
            /// </summary>
            [EnumMember(Value = "SPAM")]
            Spam
        }
        /// <summary>
        /// The connection state of this communication.
        /// </summary>
        /// <value>The connection state of this communication.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
        /// </summary>
        /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cobrowsesession" /> class.
        /// </summary>
        /// <param name="State">The connection state of this communication..</param>
        /// <param name="Id">A globally unique identifier for this communication..</param>
        /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
        /// <param name="Self">Address and name data for a call endpoint..</param>
        /// <param name="CobrowseSessionId">The co-browse session ID..</param>
        /// <param name="CobrowseRole">This value identifies the role of the co-browse client within the co-browse session (a client is a sharer or a viewer)..</param>
        /// <param name="Controlling">ID of co-browse participants for which this client has been granted control (list is empty if this client cannot control any shared pages)..</param>
        /// <param name="ViewerUrl">The URL that can be used to open co-browse session in web browser..</param>
        /// <param name="ProviderEventTime">The time when the provider event which triggered this conversation update happened in the corrected provider clock (milliseconds since 1970-01-01 00:00:00 UTC). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public Cobrowsesession(StateEnum? State = null, string Id = null, DisconnectTypeEnum? DisconnectType = null, Address Self = null, string CobrowseSessionId = null, string CobrowseRole = null, List<string> Controlling = null, string ViewerUrl = null, DateTime? ProviderEventTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null)
        {
            this.State = State;
            this.Id = Id;
            this.DisconnectType = DisconnectType;
            this.Self = Self;
            this.CobrowseSessionId = CobrowseSessionId;
            this.CobrowseRole = CobrowseRole;
            this.Controlling = Controlling;
            this.ViewerUrl = ViewerUrl;
            this.ProviderEventTime = ProviderEventTime;
            this.ConnectedTime = ConnectedTime;
            this.DisconnectedTime = DisconnectedTime;
        }
        
        /// <summary>
        /// A globally unique identifier for this communication.
        /// </summary>
        /// <value>A globally unique identifier for this communication.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Address and name data for a call endpoint.
        /// </summary>
        /// <value>Address and name data for a call endpoint.</value>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public Address Self { get; set; }
        /// <summary>
        /// The co-browse session ID.
        /// </summary>
        /// <value>The co-browse session ID.</value>
        [DataMember(Name="cobrowseSessionId", EmitDefaultValue=false)]
        public string CobrowseSessionId { get; set; }
        /// <summary>
        /// This value identifies the role of the co-browse client within the co-browse session (a client is a sharer or a viewer).
        /// </summary>
        /// <value>This value identifies the role of the co-browse client within the co-browse session (a client is a sharer or a viewer).</value>
        [DataMember(Name="cobrowseRole", EmitDefaultValue=false)]
        public string CobrowseRole { get; set; }
        /// <summary>
        /// ID of co-browse participants for which this client has been granted control (list is empty if this client cannot control any shared pages).
        /// </summary>
        /// <value>ID of co-browse participants for which this client has been granted control (list is empty if this client cannot control any shared pages).</value>
        [DataMember(Name="controlling", EmitDefaultValue=false)]
        public List<string> Controlling { get; set; }
        /// <summary>
        /// The URL that can be used to open co-browse session in web browser.
        /// </summary>
        /// <value>The URL that can be used to open co-browse session in web browser.</value>
        [DataMember(Name="viewerUrl", EmitDefaultValue=false)]
        public string ViewerUrl { get; set; }
        /// <summary>
        /// The time when the provider event which triggered this conversation update happened in the corrected provider clock (milliseconds since 1970-01-01 00:00:00 UTC). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when the provider event which triggered this conversation update happened in the corrected provider clock (milliseconds since 1970-01-01 00:00:00 UTC). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="providerEventTime", EmitDefaultValue=false)]
        public DateTime? ProviderEventTime { get; set; }
        /// <summary>
        /// The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }
        /// <summary>
        /// The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="disconnectedTime", EmitDefaultValue=false)]
        public DateTime? DisconnectedTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cobrowsesession {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  CobrowseSessionId: ").Append(CobrowseSessionId).Append("\n");
            sb.Append("  CobrowseRole: ").Append(CobrowseRole).Append("\n");
            sb.Append("  Controlling: ").Append(Controlling).Append("\n");
            sb.Append("  ViewerUrl: ").Append(ViewerUrl).Append("\n");
            sb.Append("  ProviderEventTime: ").Append(ProviderEventTime).Append("\n");
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
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
            return this.Equals(obj as Cobrowsesession);
        }

        /// <summary>
        /// Returns true if Cobrowsesession instances are equal
        /// </summary>
        /// <param name="other">Instance of Cobrowsesession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cobrowsesession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) &&
                (
                    this.CobrowseSessionId == other.CobrowseSessionId ||
                    this.CobrowseSessionId != null &&
                    this.CobrowseSessionId.Equals(other.CobrowseSessionId)
                ) &&
                (
                    this.CobrowseRole == other.CobrowseRole ||
                    this.CobrowseRole != null &&
                    this.CobrowseRole.Equals(other.CobrowseRole)
                ) &&
                (
                    this.Controlling == other.Controlling ||
                    this.Controlling != null &&
                    this.Controlling.SequenceEqual(other.Controlling)
                ) &&
                (
                    this.ViewerUrl == other.ViewerUrl ||
                    this.ViewerUrl != null &&
                    this.ViewerUrl.Equals(other.ViewerUrl)
                ) &&
                (
                    this.ProviderEventTime == other.ProviderEventTime ||
                    this.ProviderEventTime != null &&
                    this.ProviderEventTime.Equals(other.ProviderEventTime)
                ) &&
                (
                    this.ConnectedTime == other.ConnectedTime ||
                    this.ConnectedTime != null &&
                    this.ConnectedTime.Equals(other.ConnectedTime)
                ) &&
                (
                    this.DisconnectedTime == other.DisconnectedTime ||
                    this.DisconnectedTime != null &&
                    this.DisconnectedTime.Equals(other.DisconnectedTime)
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
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.CobrowseSessionId != null)
                    hash = hash * 59 + this.CobrowseSessionId.GetHashCode();
                if (this.CobrowseRole != null)
                    hash = hash * 59 + this.CobrowseRole.GetHashCode();
                if (this.Controlling != null)
                    hash = hash * 59 + this.Controlling.GetHashCode();
                if (this.ViewerUrl != null)
                    hash = hash * 59 + this.ViewerUrl.GetHashCode();
                if (this.ProviderEventTime != null)
                    hash = hash * 59 + this.ProviderEventTime.GetHashCode();
                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();
                if (this.DisconnectedTime != null)
                    hash = hash * 59 + this.DisconnectedTime.GetHashCode();
                return hash;
            }
        }
    }

}
