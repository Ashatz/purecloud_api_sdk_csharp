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
    /// UserScheduleAdherence
    /// </summary>
    [DataContract]
    public partial class UserScheduleAdherence :  IEquatable<UserScheduleAdherence>
    {
        /// <summary>
        /// Activity for which the user is scheduled
        /// </summary>
        /// <value>Activity for which the user is scheduled</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ScheduledActivityCategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Onqueuework for "OnQueueWork"
            /// </summary>
            [EnumMember(Value = "OnQueueWork")]
            Onqueuework,
            
            /// <summary>
            /// Enum Break for "Break"
            /// </summary>
            [EnumMember(Value = "Break")]
            Break,
            
            /// <summary>
            /// Enum Meal for "Meal"
            /// </summary>
            [EnumMember(Value = "Meal")]
            Meal,
            
            /// <summary>
            /// Enum Meeting for "Meeting"
            /// </summary>
            [EnumMember(Value = "Meeting")]
            Meeting,
            
            /// <summary>
            /// Enum Offqueuework for "OffQueueWork"
            /// </summary>
            [EnumMember(Value = "OffQueueWork")]
            Offqueuework,
            
            /// <summary>
            /// Enum Timeoff for "TimeOff"
            /// </summary>
            [EnumMember(Value = "TimeOff")]
            Timeoff,
            
            /// <summary>
            /// Enum Training for "Training"
            /// </summary>
            [EnumMember(Value = "Training")]
            Training,
            
            /// <summary>
            /// Enum Unavailable for "Unavailable"
            /// </summary>
            [EnumMember(Value = "Unavailable")]
            Unavailable,
            
            /// <summary>
            /// Enum Blank for "BLANK"
            /// </summary>
            [EnumMember(Value = "BLANK")]
            Blank
        }
        /// <summary>
        /// Actual underlying system presence value
        /// </summary>
        /// <value>Actual underlying system presence value</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SystemPresenceEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Available for "Available"
            /// </summary>
            [EnumMember(Value = "Available")]
            Available,
            
            /// <summary>
            /// Enum Away for "Away"
            /// </summary>
            [EnumMember(Value = "Away")]
            Away,
            
            /// <summary>
            /// Enum Busy for "Busy"
            /// </summary>
            [EnumMember(Value = "Busy")]
            Busy,
            
            /// <summary>
            /// Enum Offline for "Offline"
            /// </summary>
            [EnumMember(Value = "Offline")]
            Offline,
            
            /// <summary>
            /// Enum Idle for "Idle"
            /// </summary>
            [EnumMember(Value = "Idle")]
            Idle,
            
            /// <summary>
            /// Enum Onqueue for "OnQueue"
            /// </summary>
            [EnumMember(Value = "OnQueue")]
            Onqueue,
            
            /// <summary>
            /// Enum Meal for "Meal"
            /// </summary>
            [EnumMember(Value = "Meal")]
            Meal,
            
            /// <summary>
            /// Enum Training for "Training"
            /// </summary>
            [EnumMember(Value = "Training")]
            Training,
            
            /// <summary>
            /// Enum Meeting for "Meeting"
            /// </summary>
            [EnumMember(Value = "Meeting")]
            Meeting,
            
            /// <summary>
            /// Enum Break for "Break"
            /// </summary>
            [EnumMember(Value = "Break")]
            Break,
            
            /// <summary>
            /// Enum Blank for "BLANK"
            /// </summary>
            [EnumMember(Value = "BLANK")]
            Blank
        }
        /// <summary>
        /// Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue
        /// </summary>
        /// <value>Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RoutingStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum OffQueue for "OFF_QUEUE"
            /// </summary>
            [EnumMember(Value = "OFF_QUEUE")]
            OffQueue,
            
            /// <summary>
            /// Enum Idle for "IDLE"
            /// </summary>
            [EnumMember(Value = "IDLE")]
            Idle,
            
            /// <summary>
            /// Enum Interacting for "INTERACTING"
            /// </summary>
            [EnumMember(Value = "INTERACTING")]
            Interacting,
            
            /// <summary>
            /// Enum NotResponding for "NOT_RESPONDING"
            /// </summary>
            [EnumMember(Value = "NOT_RESPONDING")]
            NotResponding,
            
            /// <summary>
            /// Enum Communicating for "COMMUNICATING"
            /// </summary>
            [EnumMember(Value = "COMMUNICATING")]
            Communicating
        }
        /// <summary>
        /// Activity in which the user is actually engaged
        /// </summary>
        /// <value>Activity in which the user is actually engaged</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActualActivityCategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Onqueuework for "OnQueueWork"
            /// </summary>
            [EnumMember(Value = "OnQueueWork")]
            Onqueuework,
            
            /// <summary>
            /// Enum Break for "Break"
            /// </summary>
            [EnumMember(Value = "Break")]
            Break,
            
            /// <summary>
            /// Enum Meal for "Meal"
            /// </summary>
            [EnumMember(Value = "Meal")]
            Meal,
            
            /// <summary>
            /// Enum Meeting for "Meeting"
            /// </summary>
            [EnumMember(Value = "Meeting")]
            Meeting,
            
            /// <summary>
            /// Enum Offqueuework for "OffQueueWork"
            /// </summary>
            [EnumMember(Value = "OffQueueWork")]
            Offqueuework,
            
            /// <summary>
            /// Enum Timeoff for "TimeOff"
            /// </summary>
            [EnumMember(Value = "TimeOff")]
            Timeoff,
            
            /// <summary>
            /// Enum Training for "Training"
            /// </summary>
            [EnumMember(Value = "Training")]
            Training,
            
            /// <summary>
            /// Enum Unavailable for "Unavailable"
            /// </summary>
            [EnumMember(Value = "Unavailable")]
            Unavailable,
            
            /// <summary>
            /// Enum Blank for "BLANK"
            /// </summary>
            [EnumMember(Value = "BLANK")]
            Blank
        }
        /// <summary>
        /// The user's current adherence state
        /// </summary>
        /// <value>The user's current adherence state</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AdherenceStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inadherence for "InAdherence"
            /// </summary>
            [EnumMember(Value = "InAdherence")]
            Inadherence,
            
            /// <summary>
            /// Enum Outofadherence for "OutOfAdherence"
            /// </summary>
            [EnumMember(Value = "OutOfAdherence")]
            Outofadherence,
            
            /// <summary>
            /// Enum Unscheduled for "Unscheduled"
            /// </summary>
            [EnumMember(Value = "Unscheduled")]
            Unscheduled,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The impact of the user's current adherenceState
        /// </summary>
        /// <value>The impact of the user's current adherenceState</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ImpactEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Positive for "Positive"
            /// </summary>
            [EnumMember(Value = "Positive")]
            Positive,
            
            /// <summary>
            /// Enum Negative for "Negative"
            /// </summary>
            [EnumMember(Value = "Negative")]
            Negative,
            
            /// <summary>
            /// Enum Neutral for "Neutral"
            /// </summary>
            [EnumMember(Value = "Neutral")]
            Neutral,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Activity for which the user is scheduled
        /// </summary>
        /// <value>Activity for which the user is scheduled</value>
        [DataMember(Name="scheduledActivityCategory", EmitDefaultValue=false)]
        public ScheduledActivityCategoryEnum? ScheduledActivityCategory { get; set; }
        /// <summary>
        /// Actual underlying system presence value
        /// </summary>
        /// <value>Actual underlying system presence value</value>
        [DataMember(Name="systemPresence", EmitDefaultValue=false)]
        public SystemPresenceEnum? SystemPresence { get; set; }
        /// <summary>
        /// Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue
        /// </summary>
        /// <value>Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue</value>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public RoutingStatusEnum? RoutingStatus { get; set; }
        /// <summary>
        /// Activity in which the user is actually engaged
        /// </summary>
        /// <value>Activity in which the user is actually engaged</value>
        [DataMember(Name="actualActivityCategory", EmitDefaultValue=false)]
        public ActualActivityCategoryEnum? ActualActivityCategory { get; set; }
        /// <summary>
        /// The user's current adherence state
        /// </summary>
        /// <value>The user's current adherence state</value>
        [DataMember(Name="adherenceState", EmitDefaultValue=false)]
        public AdherenceStateEnum? AdherenceState { get; set; }
        /// <summary>
        /// The impact of the user's current adherenceState
        /// </summary>
        /// <value>The impact of the user's current adherenceState</value>
        [DataMember(Name="impact", EmitDefaultValue=false)]
        public ImpactEnum? Impact { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserScheduleAdherence" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="User">The user for whom this status applies.</param>
        /// <param name="ManagementUnit">The management unit to which this user belongs.</param>
        public UserScheduleAdherence(string Name = null, User User = null, ManagementUnit ManagementUnit = null)
        {
            this.Name = Name;
            this.User = User;
            this.ManagementUnit = ManagementUnit;
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
        /// The user for whom this status applies
        /// </summary>
        /// <value>The user for whom this status applies</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        /// <summary>
        /// The management unit to which this user belongs
        /// </summary>
        /// <value>The management unit to which this user belongs</value>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public ManagementUnit ManagementUnit { get; set; }
        /// <summary>
        /// Organization Secondary Presence Id.
        /// </summary>
        /// <value>Organization Secondary Presence Id.</value>
        [DataMember(Name="organizationSecondaryPresenceId", EmitDefaultValue=false)]
        public string OrganizationSecondaryPresenceId { get; private set; }
        /// <summary>
        /// Whether the user is marked OutOfOffice
        /// </summary>
        /// <value>Whether the user is marked OutOfOffice</value>
        [DataMember(Name="isOutOfOffice", EmitDefaultValue=false)]
        public bool? IsOutOfOffice { get; private set; }
        /// <summary>
        /// Time when the user entered the current adherenceState in ISO-8601 format
        /// </summary>
        /// <value>Time when the user entered the current adherenceState in ISO-8601 format</value>
        [DataMember(Name="timeOfAdherenceChange", EmitDefaultValue=false)]
        public string TimeOfAdherenceChange { get; private set; }
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
            sb.Append("class UserScheduleAdherence {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  ScheduledActivityCategory: ").Append(ScheduledActivityCategory).Append("\n");
            sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
            sb.Append("  OrganizationSecondaryPresenceId: ").Append(OrganizationSecondaryPresenceId).Append("\n");
            sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
            sb.Append("  ActualActivityCategory: ").Append(ActualActivityCategory).Append("\n");
            sb.Append("  IsOutOfOffice: ").Append(IsOutOfOffice).Append("\n");
            sb.Append("  AdherenceState: ").Append(AdherenceState).Append("\n");
            sb.Append("  Impact: ").Append(Impact).Append("\n");
            sb.Append("  TimeOfAdherenceChange: ").Append(TimeOfAdherenceChange).Append("\n");
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
            return this.Equals(obj as UserScheduleAdherence);
        }

        /// <summary>
        /// Returns true if UserScheduleAdherence instances are equal
        /// </summary>
        /// <param name="other">Instance of UserScheduleAdherence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserScheduleAdherence other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.ManagementUnit == other.ManagementUnit ||
                    this.ManagementUnit != null &&
                    this.ManagementUnit.Equals(other.ManagementUnit)
                ) &&
                (
                    this.ScheduledActivityCategory == other.ScheduledActivityCategory ||
                    this.ScheduledActivityCategory != null &&
                    this.ScheduledActivityCategory.Equals(other.ScheduledActivityCategory)
                ) &&
                (
                    this.SystemPresence == other.SystemPresence ||
                    this.SystemPresence != null &&
                    this.SystemPresence.Equals(other.SystemPresence)
                ) &&
                (
                    this.OrganizationSecondaryPresenceId == other.OrganizationSecondaryPresenceId ||
                    this.OrganizationSecondaryPresenceId != null &&
                    this.OrganizationSecondaryPresenceId.Equals(other.OrganizationSecondaryPresenceId)
                ) &&
                (
                    this.RoutingStatus == other.RoutingStatus ||
                    this.RoutingStatus != null &&
                    this.RoutingStatus.Equals(other.RoutingStatus)
                ) &&
                (
                    this.ActualActivityCategory == other.ActualActivityCategory ||
                    this.ActualActivityCategory != null &&
                    this.ActualActivityCategory.Equals(other.ActualActivityCategory)
                ) &&
                (
                    this.IsOutOfOffice == other.IsOutOfOffice ||
                    this.IsOutOfOffice != null &&
                    this.IsOutOfOffice.Equals(other.IsOutOfOffice)
                ) &&
                (
                    this.AdherenceState == other.AdherenceState ||
                    this.AdherenceState != null &&
                    this.AdherenceState.Equals(other.AdherenceState)
                ) &&
                (
                    this.Impact == other.Impact ||
                    this.Impact != null &&
                    this.Impact.Equals(other.Impact)
                ) &&
                (
                    this.TimeOfAdherenceChange == other.TimeOfAdherenceChange ||
                    this.TimeOfAdherenceChange != null &&
                    this.TimeOfAdherenceChange.Equals(other.TimeOfAdherenceChange)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.ManagementUnit != null)
                    hash = hash * 59 + this.ManagementUnit.GetHashCode();
                if (this.ScheduledActivityCategory != null)
                    hash = hash * 59 + this.ScheduledActivityCategory.GetHashCode();
                if (this.SystemPresence != null)
                    hash = hash * 59 + this.SystemPresence.GetHashCode();
                if (this.OrganizationSecondaryPresenceId != null)
                    hash = hash * 59 + this.OrganizationSecondaryPresenceId.GetHashCode();
                if (this.RoutingStatus != null)
                    hash = hash * 59 + this.RoutingStatus.GetHashCode();
                if (this.ActualActivityCategory != null)
                    hash = hash * 59 + this.ActualActivityCategory.GetHashCode();
                if (this.IsOutOfOffice != null)
                    hash = hash * 59 + this.IsOutOfOffice.GetHashCode();
                if (this.AdherenceState != null)
                    hash = hash * 59 + this.AdherenceState.GetHashCode();
                if (this.Impact != null)
                    hash = hash * 59 + this.Impact.GetHashCode();
                if (this.TimeOfAdherenceChange != null)
                    hash = hash * 59 + this.TimeOfAdherenceChange.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
