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
    public partial class User :  IEquatable<User>
    { 
<<<<<<< HEAD
        
        /// <summary>
        /// Initializes a new instance of the <see cref="User" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Username">Username.</param>
        /// <param name="Email">Email.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="PhoneNumber">PhoneNumber.</param>
        /// <param name="UserImages">UserImages.</param>
        /// <param name="Chat">Chat.</param>
        /// <param name="Roles">Roles.</param>
        /// <param name="VoicemailEnabled">VoicemailEnabled (default to false).</param>
        /// <param name="Department">Department.</param>
        /// <param name="Title">Title.</param>
        /// <param name="RoutingStatus">RoutingStatus.</param>
        /// <param name="Password">Password.</param>
        /// <param name="PrimaryPresence">PrimaryPresence.</param>
        /// <param name="Conversations">Conversations.</param>
        /// <param name="ConversationSummary">ConversationSummary.</param>
        /// <param name="OutOfOffice">OutOfOffice.</param>
        /// <param name="Geolocation">Geolocation.</param>
        /// <param name="Permissions">Permissions.</param>
        /// <param name="RequestedStatus">RequestedStatus.</param>
        /// <param name="DefaultStationUri">DefaultStationUri.</param>
        /// <param name="StationUri">StationUri.</param>

        public User(string Name = null, string Username = null, string Email = null, string DisplayName = null, string PhoneNumber = null, List<UserImage> UserImages = null, Chat Chat = null, List<DomainOrganizationRole> Roles = null, bool? VoicemailEnabled = null, string Department = null, string Title = null, RoutingStatus RoutingStatus = null, string Password = null, UserPresence PrimaryPresence = null, UserConversationSummary Conversations = null, UserConversationSummary ConversationSummary = null, OutOfOffice OutOfOffice = null, Geolocation Geolocation = null, List<string> Permissions = nullUserStatus RequestedStatus = null, string DefaultStationUri = null, string StationUri = null)
        {
            this.Name = Name;
            this.Username = Username;
            this.Email = Email;
            this.DisplayName = DisplayName;
            this.PhoneNumber = PhoneNumber;
            this.UserImages = UserImages;
            this.Chat = Chat;
            this.Roles = Roles;
            // use default value if no "VoicemailEnabled" provided
            if (VoicemailEnabled == null)
            {
                this.VoicemailEnabled = false;
            }
            else
            {
                this.VoicemailEnabled = VoicemailEnabled;
            }
            this.Department = Department;
            this.Title = Title;
            this.RoutingStatus = RoutingStatus;
            this.Password = Password;
            this.PrimaryPresence = PrimaryPresence;
            this.Conversations = Conversations;
            this.ConversationSummary = ConversationSummary;
            this.OutOfOffice = OutOfOffice;
            this.Geolocation = Geolocation;
            this.Permissions = Permissions;
            this.RequestedStatus = RequestedStatus;
            this.DefaultStationUri = DefaultStationUri;
            this.StationUri = StationUri;
=======

        /// <summary>
        /// The current state for this user.
        /// </summary>
        /// <value>The current state for this user.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum {
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            
            [EnumMember(Value = "DELETED")]
            Deleted
        }

    
        /// <summary>
        /// The current state for this user.
        /// </summary>
        /// <value>The current state for this user.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="User" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Chat">Chat.</param>
        /// <param name="Department">Department.</param>
        /// <param name="Email">Email.</param>
        /// <param name="PrimaryContactInfo">Auto populated from addresses..</param>
        /// <param name="Addresses">Email addresses and phone numbers for this user.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Username">Username.</param>
        /// <param name="Images">Images.</param>
        /// <param name="RoutingStatus">ACD routing status.</param>
        /// <param name="Presence">Active presence.</param>
        /// <param name="ConversationSummary">Summary of conversion statistics for conversation types..</param>
        /// <param name="OutOfOffice">Determine if out of office is enabled.</param>
        /// <param name="Geolocation">Current geolocation position.</param>
        /// <param name="Station">Effective, default, and last station information.</param>
        /// <param name="Authorization">Roles and permissions assigned to the user.</param>

        public User(string Name = null, Chat Chat = null, string Department = null, string Email = null, List<Contact> PrimaryContactInfo = null, List<Contact> Addresses = null, string Title = null, string Username = null, List<UserImage> Images = null, RoutingStatus RoutingStatus = null, UserPresence Presence = null, UserConversationSummary ConversationSummary = null, OutOfOffice OutOfOffice = null, Geolocation Geolocation = null, UserStations Station = null, UserAuthorization Authorization = null)
        {
            this.Name = Name;
            this.Chat = Chat;
            this.Department = Department;
            this.Email = Email;
            this.PrimaryContactInfo = PrimaryContactInfo;
            this.Addresses = Addresses;
            this.Title = Title;
            this.Username = Username;
            this.Images = Images;
            this.RoutingStatus = RoutingStatus;
            this.Presence = Presence;
            this.ConversationSummary = ConversationSummary;
            this.OutOfOffice = OutOfOffice;
            this.Geolocation = Geolocation;
            this.Station = Station;
            this.Authorization = Authorization;
            
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
        /// Gets or Sets Chat
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
=======
        [DataMember(Name="chat", EmitDefaultValue=false)]
        public Chat Chat { get; set; }
    
        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Auto populated from addresses.
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
=======
        /// <value>Auto populated from addresses.</value>
        [DataMember(Name="primaryContactInfo", EmitDefaultValue=false)]
        public List<Contact> PrimaryContactInfo { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Email addresses and phone numbers for this user
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets UserImages
        /// </summary>
        [DataMember(Name="userImages", EmitDefaultValue=false)]
        public List<UserImage> UserImages { get; set; }
    
        /// <summary>
        /// Gets or Sets Chat
        /// </summary>
        [DataMember(Name="chat", EmitDefaultValue=false)]
        public Chat Chat { get; set; }
    
        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<DomainOrganizationRole> Roles { get; set; }
=======
        /// <value>Email addresses and phone numbers for this user</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<Contact> Addresses { get; set; }
    
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="voicemailEnabled", EmitDefaultValue=false)]
        public bool? VoicemailEnabled { get; set; }
=======
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets Images
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
=======
        [DataMember(Name="images", EmitDefaultValue=false)]
        public List<UserImage> Images { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Required when updating. Version must be the current version. Only the system can assign version.
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
=======
        /// <value>Required when updating. Version must be the current version. Only the system can assign version.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; private set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// ACD routing status
        /// </summary>
        /// <value>ACD routing status</value>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public RoutingStatus RoutingStatus { get; set; }
    
<<<<<<< HEAD
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
    
        /// <summary>
        /// Gets or Sets PrimaryPresence
        /// </summary>
        [DataMember(Name="primaryPresence", EmitDefaultValue=false)]
        public UserPresence PrimaryPresence { get; set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Active presence
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="conversations", EmitDefaultValue=false)]
        public UserConversationSummary Conversations { get; set; }
=======
        /// <value>Active presence</value>
        [DataMember(Name="presence", EmitDefaultValue=false)]
        public UserPresence Presence { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Summary of conversion statistics for conversation types.
        /// </summary>
        /// <value>Summary of conversion statistics for conversation types.</value>
        [DataMember(Name="conversationSummary", EmitDefaultValue=false)]
        public UserConversationSummary ConversationSummary { get; set; }
    
        /// <summary>
        /// Determine if out of office is enabled
        /// </summary>
        /// <value>Determine if out of office is enabled</value>
        [DataMember(Name="outOfOffice", EmitDefaultValue=false)]
        public OutOfOffice OutOfOffice { get; set; }
    
        /// <summary>
        /// Current geolocation position
        /// </summary>
        /// <value>Current geolocation position</value>
        [DataMember(Name="geolocation", EmitDefaultValue=false)]
        public Geolocation Geolocation { get; set; }
    
        /// <summary>
        /// Effective, default, and last station information
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; set; }
=======
        /// <value>Effective, default, and last station information</value>
        [DataMember(Name="station", EmitDefaultValue=false)]
        public UserStations Station { get; set; }
    
        /// <summary>
        /// Roles and permissions assigned to the user
        /// </summary>
        /// <value>Roles and permissions assigned to the user</value>
        [DataMember(Name="authorization", EmitDefaultValue=false)]
        public UserAuthorization Authorization { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
    
<<<<<<< HEAD
        /// <summary>
        /// Gets or Sets RequestedStatus
        /// </summary>
        [DataMember(Name="requestedStatus", EmitDefaultValue=false)]
        public UserStatus RequestedStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets DefaultStationUri
        /// </summary>
        [DataMember(Name="defaultStationUri", EmitDefaultValue=false)]
        public string DefaultStationUri { get; set; }
    
        /// <summary>
        /// Gets or Sets StationUri
        /// </summary>
        [DataMember(Name="stationUri", EmitDefaultValue=false)]
        public string StationUri { get; set; }
    
        /// <summary>
        /// Gets or Sets LastStationUri
        /// </summary>
        [DataMember(Name="lastStationUri", EmitDefaultValue=false)]
        public string LastStationUri { get; private set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PrimaryContactInfo: ").Append(PrimaryContactInfo).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
            sb.Append("  ConversationSummary: ").Append(ConversationSummary).Append("\n");
            sb.Append("  OutOfOffice: ").Append(OutOfOffice).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
            sb.Append("  Station: ").Append(Station).Append("\n");
            sb.Append("  Authorization: ").Append(Authorization).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
<<<<<<< HEAD
            sb.Append("  RequestedStatus: ").Append(RequestedStatus).Append("\n");
            sb.Append("  DefaultStationUri: ").Append(DefaultStationUri).Append("\n");
            sb.Append("  StationUri: ").Append(StationUri).Append("\n");
            sb.Append("  LastStationUri: ").Append(LastStationUri).Append("\n");
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            return this.Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
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
<<<<<<< HEAD
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) &&
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) &&
                (
                    this.UserImages == other.UserImages ||
                    this.UserImages != null &&
                    this.UserImages.SequenceEqual(other.UserImages)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                (
                    this.Chat == other.Chat ||
                    this.Chat != null &&
                    this.Chat.Equals(other.Chat)
                ) &&
<<<<<<< HEAD
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
                ) &&
                (
                    this.VoicemailEnabled == other.VoicemailEnabled ||
                    this.VoicemailEnabled != null &&
                    this.VoicemailEnabled.Equals(other.VoicemailEnabled)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) &&
<<<<<<< HEAD
=======
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) &&
                (
                    this.PrimaryContactInfo == other.PrimaryContactInfo ||
                    this.PrimaryContactInfo != null &&
                    this.PrimaryContactInfo.SequenceEqual(other.PrimaryContactInfo)
                ) &&
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
<<<<<<< HEAD
=======
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) &&
                (
                    this.Images == other.Images ||
                    this.Images != null &&
                    this.Images.SequenceEqual(other.Images)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                (
                    this.RoutingStatus == other.RoutingStatus ||
                    this.RoutingStatus != null &&
                    this.RoutingStatus.Equals(other.RoutingStatus)
                ) &&
<<<<<<< HEAD
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) &&
                (
                    this.PrimaryPresence == other.PrimaryPresence ||
                    this.PrimaryPresence != null &&
                    this.PrimaryPresence.Equals(other.PrimaryPresence)
                ) &&
                (
                    this.Conversations == other.Conversations ||
                    this.Conversations != null &&
                    this.Conversations.Equals(other.Conversations)
=======
                (
                    this.Presence == other.Presence ||
                    this.Presence != null &&
                    this.Presence.Equals(other.Presence)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                ) &&
                (
                    this.ConversationSummary == other.ConversationSummary ||
                    this.ConversationSummary != null &&
                    this.ConversationSummary.Equals(other.ConversationSummary)
                ) &&
                (
                    this.OutOfOffice == other.OutOfOffice ||
                    this.OutOfOffice != null &&
                    this.OutOfOffice.Equals(other.OutOfOffice)
                ) &&
                (
                    this.Geolocation == other.Geolocation ||
                    this.Geolocation != null &&
                    this.Geolocation.Equals(other.Geolocation)
                ) &&
<<<<<<< HEAD
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
=======
                (
                    this.Station == other.Station ||
                    this.Station != null &&
                    this.Station.Equals(other.Station)
                ) &&
                (
                    this.Authorization == other.Authorization ||
                    this.Authorization != null &&
                    this.Authorization.Equals(other.Authorization)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
<<<<<<< HEAD
                ) &&
                (
                    this.RequestedStatus == other.RequestedStatus ||
                    this.RequestedStatus != null &&
                    this.RequestedStatus.Equals(other.RequestedStatus)
                ) &&
                (
                    this.DefaultStationUri == other.DefaultStationUri ||
                    this.DefaultStationUri != null &&
                    this.DefaultStationUri.Equals(other.DefaultStationUri)
                ) &&
                (
                    this.StationUri == other.StationUri ||
                    this.StationUri != null &&
                    this.StationUri.Equals(other.StationUri)
                ) &&
                (
                    this.LastStationUri == other.LastStationUri ||
                    this.LastStationUri != null &&
                    this.LastStationUri.Equals(other.LastStationUri)
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.UserImages != null)
                    hash = hash * 59 + this.UserImages.GetHashCode();
                if (this.Chat != null)
                    hash = hash * 59 + this.Chat.GetHashCode();
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                if (this.VoicemailEnabled != null)
                    hash = hash * 59 + this.VoicemailEnabled.GetHashCode();
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.RoutingStatus != null)
                    hash = hash * 59 + this.RoutingStatus.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.PrimaryPresence != null)
                    hash = hash * 59 + this.PrimaryPresence.GetHashCode();
                if (this.Conversations != null)
                    hash = hash * 59 + this.Conversations.GetHashCode();
=======
                if (this.Chat != null)
                    hash = hash * 59 + this.Chat.GetHashCode();
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.PrimaryContactInfo != null)
                    hash = hash * 59 + this.PrimaryContactInfo.GetHashCode();
                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.RoutingStatus != null)
                    hash = hash * 59 + this.RoutingStatus.GetHashCode();
                if (this.Presence != null)
                    hash = hash * 59 + this.Presence.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.ConversationSummary != null)
                    hash = hash * 59 + this.ConversationSummary.GetHashCode();
                if (this.OutOfOffice != null)
                    hash = hash * 59 + this.OutOfOffice.GetHashCode();
                if (this.Geolocation != null)
                    hash = hash * 59 + this.Geolocation.GetHashCode();
<<<<<<< HEAD
                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                if (this.RequestedStatus != null)
                    hash = hash * 59 + this.RequestedStatus.GetHashCode();
                if (this.DefaultStationUri != null)
                    hash = hash * 59 + this.DefaultStationUri.GetHashCode();
                if (this.StationUri != null)
                    hash = hash * 59 + this.StationUri.GetHashCode();
                if (this.LastStationUri != null)
                    hash = hash * 59 + this.LastStationUri.GetHashCode();
=======
                if (this.Station != null)
                    hash = hash * 59 + this.Station.GetHashCode();
                if (this.Authorization != null)
                    hash = hash * 59 + this.Authorization.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
