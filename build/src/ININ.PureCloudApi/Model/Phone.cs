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
    /// Phone
    /// </summary>
    [DataContract]
    public partial class Phone :  IEquatable<Phone>
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
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Phone" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Phone() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Phone" /> class.
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
        /// <param name="Site">The site associated to the phone. (required).</param>
        /// <param name="PhoneBaseSettings">Phone Base Settings (required).</param>
        /// <param name="LineBaseSettings">LineBaseSettings.</param>
        /// <param name="PhoneMetaBase">PhoneMetaBase.</param>
        /// <param name="Lines">Lines (required).</param>
        /// <param name="Status">The status of the phone and lines from the primary Edge..</param>
        /// <param name="SecondaryStatus">The status of the phone and lines from the secondary Edge..</param>
        /// <param name="UserAgentInfo">User Agent Information for this phone. This includes model, firmware version, and manufacturer..</param>
        /// <param name="Properties">Properties.</param>
        /// <param name="Capabilities">Capabilities.</param>
        /// <param name="WebRtcUser">This is the user associated with a WebRTC type phone.  It is required for all WebRTC phones..</param>
        public Phone(string Name = null, string Description = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, StateEnum? State = null, string ModifiedByApp = null, string CreatedByApp = null, UriReference Site = null, UriReference PhoneBaseSettings = null, UriReference LineBaseSettings = null, UriReference PhoneMetaBase = null, List<Line> Lines = null, PhoneStatus Status = null, PhoneStatus SecondaryStatus = null, UserAgentInfo UserAgentInfo = null, Dictionary<string, Object> Properties = null, PhoneCapabilities Capabilities = null, UriReference WebRtcUser = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Phone and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Site" is required (not null)
            if (Site == null)
            {
                throw new InvalidDataException("Site is a required property for Phone and cannot be null");
            }
            else
            {
                this.Site = Site;
            }
            // to ensure "PhoneBaseSettings" is required (not null)
            if (PhoneBaseSettings == null)
            {
                throw new InvalidDataException("PhoneBaseSettings is a required property for Phone and cannot be null");
            }
            else
            {
                this.PhoneBaseSettings = PhoneBaseSettings;
            }
            // to ensure "Lines" is required (not null)
            if (Lines == null)
            {
                throw new InvalidDataException("Lines is a required property for Phone and cannot be null");
            }
            else
            {
                this.Lines = Lines;
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
            this.LineBaseSettings = LineBaseSettings;
            this.PhoneMetaBase = PhoneMetaBase;
            this.Status = Status;
            this.SecondaryStatus = SecondaryStatus;
            this.UserAgentInfo = UserAgentInfo;
            this.Properties = Properties;
            this.Capabilities = Capabilities;
            this.WebRtcUser = WebRtcUser;
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
        /// The site associated to the phone.
        /// </summary>
        /// <value>The site associated to the phone.</value>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public UriReference Site { get; set; }
        /// <summary>
        /// Phone Base Settings
        /// </summary>
        /// <value>Phone Base Settings</value>
        [DataMember(Name="phoneBaseSettings", EmitDefaultValue=false)]
        public UriReference PhoneBaseSettings { get; set; }
        /// <summary>
        /// Gets or Sets LineBaseSettings
        /// </summary>
        [DataMember(Name="lineBaseSettings", EmitDefaultValue=false)]
        public UriReference LineBaseSettings { get; set; }
        /// <summary>
        /// Gets or Sets PhoneMetaBase
        /// </summary>
        [DataMember(Name="phoneMetaBase", EmitDefaultValue=false)]
        public UriReference PhoneMetaBase { get; set; }
        /// <summary>
        /// Lines
        /// </summary>
        /// <value>Lines</value>
        [DataMember(Name="lines", EmitDefaultValue=false)]
        public List<Line> Lines { get; set; }
        /// <summary>
        /// The status of the phone and lines from the primary Edge.
        /// </summary>
        /// <value>The status of the phone and lines from the primary Edge.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public PhoneStatus Status { get; set; }
        /// <summary>
        /// The status of the phone and lines from the secondary Edge.
        /// </summary>
        /// <value>The status of the phone and lines from the secondary Edge.</value>
        [DataMember(Name="secondaryStatus", EmitDefaultValue=false)]
        public PhoneStatus SecondaryStatus { get; set; }
        /// <summary>
        /// User Agent Information for this phone. This includes model, firmware version, and manufacturer.
        /// </summary>
        /// <value>User Agent Information for this phone. This includes model, firmware version, and manufacturer.</value>
        [DataMember(Name="userAgentInfo", EmitDefaultValue=false)]
        public UserAgentInfo UserAgentInfo { get; set; }
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, Object> Properties { get; set; }
        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public PhoneCapabilities Capabilities { get; set; }
        /// <summary>
        /// This is the user associated with a WebRTC type phone.  It is required for all WebRTC phones.
        /// </summary>
        /// <value>This is the user associated with a WebRTC type phone.  It is required for all WebRTC phones.</value>
        [DataMember(Name="webRtcUser", EmitDefaultValue=false)]
        public UriReference WebRtcUser { get; set; }
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
            sb.Append("class Phone {\n");
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
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  PhoneBaseSettings: ").Append(PhoneBaseSettings).Append("\n");
            sb.Append("  LineBaseSettings: ").Append(LineBaseSettings).Append("\n");
            sb.Append("  PhoneMetaBase: ").Append(PhoneMetaBase).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SecondaryStatus: ").Append(SecondaryStatus).Append("\n");
            sb.Append("  UserAgentInfo: ").Append(UserAgentInfo).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  WebRtcUser: ").Append(WebRtcUser).Append("\n");
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
            return this.Equals(obj as Phone);
        }

        /// <summary>
        /// Returns true if Phone instances are equal
        /// </summary>
        /// <param name="other">Instance of Phone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Phone other)
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
                    this.Site == other.Site ||
                    this.Site != null &&
                    this.Site.Equals(other.Site)
                ) &&
                (
                    this.PhoneBaseSettings == other.PhoneBaseSettings ||
                    this.PhoneBaseSettings != null &&
                    this.PhoneBaseSettings.Equals(other.PhoneBaseSettings)
                ) &&
                (
                    this.LineBaseSettings == other.LineBaseSettings ||
                    this.LineBaseSettings != null &&
                    this.LineBaseSettings.Equals(other.LineBaseSettings)
                ) &&
                (
                    this.PhoneMetaBase == other.PhoneMetaBase ||
                    this.PhoneMetaBase != null &&
                    this.PhoneMetaBase.Equals(other.PhoneMetaBase)
                ) &&
                (
                    this.Lines == other.Lines ||
                    this.Lines != null &&
                    this.Lines.SequenceEqual(other.Lines)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.SecondaryStatus == other.SecondaryStatus ||
                    this.SecondaryStatus != null &&
                    this.SecondaryStatus.Equals(other.SecondaryStatus)
                ) &&
                (
                    this.UserAgentInfo == other.UserAgentInfo ||
                    this.UserAgentInfo != null &&
                    this.UserAgentInfo.Equals(other.UserAgentInfo)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) &&
                (
                    this.Capabilities == other.Capabilities ||
                    this.Capabilities != null &&
                    this.Capabilities.Equals(other.Capabilities)
                ) &&
                (
                    this.WebRtcUser == other.WebRtcUser ||
                    this.WebRtcUser != null &&
                    this.WebRtcUser.Equals(other.WebRtcUser)
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
                if (this.Site != null)
                    hash = hash * 59 + this.Site.GetHashCode();
                if (this.PhoneBaseSettings != null)
                    hash = hash * 59 + this.PhoneBaseSettings.GetHashCode();
                if (this.LineBaseSettings != null)
                    hash = hash * 59 + this.LineBaseSettings.GetHashCode();
                if (this.PhoneMetaBase != null)
                    hash = hash * 59 + this.PhoneMetaBase.GetHashCode();
                if (this.Lines != null)
                    hash = hash * 59 + this.Lines.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.SecondaryStatus != null)
                    hash = hash * 59 + this.SecondaryStatus.GetHashCode();
                if (this.UserAgentInfo != null)
                    hash = hash * 59 + this.UserAgentInfo.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                if (this.Capabilities != null)
                    hash = hash * 59 + this.Capabilities.GetHashCode();
                if (this.WebRtcUser != null)
                    hash = hash * 59 + this.WebRtcUser.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
