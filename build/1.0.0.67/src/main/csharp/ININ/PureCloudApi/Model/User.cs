using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class User :  IEquatable<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
            this.VoicemailEnabled = false;
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
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
  
        
        /// <summary>
        /// Gets or Sets VoicemailEnabled
        /// </summary>
        [DataMember(Name="voicemailEnabled", EmitDefaultValue=false)]
        public bool? VoicemailEnabled { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RoutingStatus
        /// </summary>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public RoutingStatus RoutingStatus { get; set; }
  
        
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
  
        
        /// <summary>
        /// Gets or Sets Conversations
        /// </summary>
        [DataMember(Name="conversations", EmitDefaultValue=false)]
        public UserConversationSummary Conversations { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ConversationSummary
        /// </summary>
        [DataMember(Name="conversationSummary", EmitDefaultValue=false)]
        public UserConversationSummary ConversationSummary { get; set; }
  
        
        /// <summary>
        /// Gets or Sets OutOfOffice
        /// </summary>
        [DataMember(Name="outOfOffice", EmitDefaultValue=false)]
        public OutOfOffice OutOfOffice { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
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
        public string LastStationUri { get; set; }
  
        
  
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
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  UserImages: ").Append(UserImages).Append("\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  VoicemailEnabled: ").Append(VoicemailEnabled).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PrimaryPresence: ").Append(PrimaryPresence).Append("\n");
            sb.Append("  Conversations: ").Append(Conversations).Append("\n");
            sb.Append("  ConversationSummary: ").Append(ConversationSummary).Append("\n");
            sb.Append("  OutOfOffice: ").Append(OutOfOffice).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  RequestedStatus: ").Append(RequestedStatus).Append("\n");
            sb.Append("  DefaultStationUri: ").Append(DefaultStationUri).Append("\n");
            sb.Append("  StationUri: ").Append(StationUri).Append("\n");
            sb.Append("  LastStationUri: ").Append(LastStationUri).Append("\n");
            
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
        /// <param name="obj">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                (
                    this.Chat == other.Chat ||
                    this.Chat != null &&
                    this.Chat.Equals(other.Chat)
                ) && 
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
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.RoutingStatus == other.RoutingStatus ||
                    this.RoutingStatus != null &&
                    this.RoutingStatus.Equals(other.RoutingStatus)
                ) && 
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
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
                ) && 
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Username != null)
                    hash = hash * 57 + this.Username.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 57 + this.Email.GetHashCode();
                
                if (this.DisplayName != null)
                    hash = hash * 57 + this.DisplayName.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 57 + this.PhoneNumber.GetHashCode();
                
                if (this.UserImages != null)
                    hash = hash * 57 + this.UserImages.GetHashCode();
                
                if (this.Chat != null)
                    hash = hash * 57 + this.Chat.GetHashCode();
                
                if (this.Roles != null)
                    hash = hash * 57 + this.Roles.GetHashCode();
                
                if (this.VoicemailEnabled != null)
                    hash = hash * 57 + this.VoicemailEnabled.GetHashCode();
                
                if (this.Department != null)
                    hash = hash * 57 + this.Department.GetHashCode();
                
                if (this.Title != null)
                    hash = hash * 57 + this.Title.GetHashCode();
                
                if (this.RoutingStatus != null)
                    hash = hash * 57 + this.RoutingStatus.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 57 + this.Password.GetHashCode();
                
                if (this.PrimaryPresence != null)
                    hash = hash * 57 + this.PrimaryPresence.GetHashCode();
                
                if (this.Conversations != null)
                    hash = hash * 57 + this.Conversations.GetHashCode();
                
                if (this.ConversationSummary != null)
                    hash = hash * 57 + this.ConversationSummary.GetHashCode();
                
                if (this.OutOfOffice != null)
                    hash = hash * 57 + this.OutOfOffice.GetHashCode();
                
                if (this.Permissions != null)
                    hash = hash * 57 + this.Permissions.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                if (this.RequestedStatus != null)
                    hash = hash * 57 + this.RequestedStatus.GetHashCode();
                
                if (this.DefaultStationUri != null)
                    hash = hash * 57 + this.DefaultStationUri.GetHashCode();
                
                if (this.StationUri != null)
                    hash = hash * 57 + this.StationUri.GetHashCode();
                
                if (this.LastStationUri != null)
                    hash = hash * 57 + this.LastStationUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
