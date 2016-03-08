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
    public partial class Queue :  IEquatable<Queue>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum {
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "DELETED")]
            Deleted,
            
            [EnumMember(Value = "INACTIVE")]
            Inactive
        }
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SkillEvaluationMethodEnum {
            
            [EnumMember(Value = "NONE")]
            None,
            
            [EnumMember(Value = "BEST")]
            Best,
            
            [EnumMember(Value = "ALL")]
            All
        }
    
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
    
        /// <summary>
        /// Gets or Sets SkillEvaluationMethod
        /// </summary>
        [DataMember(Name="skillEvaluationMethod", EmitDefaultValue=false)]
        public SkillEvaluationMethodEnum? SkillEvaluationMethod { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Queue" /> class.
        /// Initializes a new instance of the <see cref="Queue" />class.
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
        /// <param name="WrapupCodes">WrapupCodes.</param>
        /// <param name="MediaSettings">MediaSettings.</param>
        /// <param name="Bullseye">Bullseye.</param>
        /// <param name="AcwSettings">AcwSettings.</param>
        /// <param name="PhoneNumber">PhoneNumber.</param>
        /// <param name="SkillEvaluationMethod">SkillEvaluationMethod.</param>
        /// <param name="QueueFlow">QueueFlow.</param>
        /// <param name="CallingPartyName">CallingPartyName.</param>
        /// <param name="CallingPartyNumber">CallingPartyNumber.</param>
        /// <param name="MemberCount">MemberCount.</param>

        public Queue(string Name = null, string Description = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, StateEnum? State = null, string ModifiedByApp = null, string CreatedByApp = null, List<UriReference> WrapupCodes = null, Dictionary<string, MediaSetting> MediaSettings = null, Bullseye Bullseye = null, AcwSettings AcwSettings = null, string PhoneNumber = null, SkillEvaluationMethodEnum? SkillEvaluationMethod = null, UriReference QueueFlow = null, string CallingPartyName = null, string CallingPartyNumber = null, int? MemberCount = null, )
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
            this.WrapupCodes = WrapupCodes;
            this.MediaSettings = MediaSettings;
            this.Bullseye = Bullseye;
            this.AcwSettings = AcwSettings;
            this.PhoneNumber = PhoneNumber;
            this.SkillEvaluationMethod = SkillEvaluationMethod;
            this.QueueFlow = QueueFlow;
            this.CallingPartyName = CallingPartyName;
            this.CallingPartyNumber = CallingPartyNumber;
            this.MemberCount = MemberCount;
            
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
        /// Gets or Sets WrapupCodes
        /// </summary>
        [DataMember(Name="wrapupCodes", EmitDefaultValue=false)]
        public List<UriReference> WrapupCodes { get; set; }
    
        /// <summary>
        /// Gets or Sets MediaSettings
        /// </summary>
        [DataMember(Name="mediaSettings", EmitDefaultValue=false)]
        public Dictionary<string, MediaSetting> MediaSettings { get; set; }
    
        /// <summary>
        /// Gets or Sets Bullseye
        /// </summary>
        [DataMember(Name="bullseye", EmitDefaultValue=false)]
        public Bullseye Bullseye { get; set; }
    
        /// <summary>
        /// Gets or Sets AcwSettings
        /// </summary>
        [DataMember(Name="acwSettings", EmitDefaultValue=false)]
        public AcwSettings AcwSettings { get; set; }
    
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets QueueFlow
        /// </summary>
        [DataMember(Name="queueFlow", EmitDefaultValue=false)]
        public UriReference QueueFlow { get; set; }
    
        /// <summary>
        /// Gets or Sets CallingPartyName
        /// </summary>
        [DataMember(Name="callingPartyName", EmitDefaultValue=false)]
        public string CallingPartyName { get; set; }
    
        /// <summary>
        /// Gets or Sets CallingPartyNumber
        /// </summary>
        [DataMember(Name="callingPartyNumber", EmitDefaultValue=false)]
        public string CallingPartyNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets MemberCount
        /// </summary>
        [DataMember(Name="memberCount", EmitDefaultValue=false)]
        public int? MemberCount { get; set; }
    
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
            sb.Append("class Queue {\n");
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
            sb.Append("  WrapupCodes: ").Append(WrapupCodes).Append("\n");
            sb.Append("  MediaSettings: ").Append(MediaSettings).Append("\n");
            sb.Append("  Bullseye: ").Append(Bullseye).Append("\n");
            sb.Append("  AcwSettings: ").Append(AcwSettings).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  SkillEvaluationMethod: ").Append(SkillEvaluationMethod).Append("\n");
            sb.Append("  QueueFlow: ").Append(QueueFlow).Append("\n");
            sb.Append("  CallingPartyName: ").Append(CallingPartyName).Append("\n");
            sb.Append("  CallingPartyNumber: ").Append(CallingPartyNumber).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
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
            return this.Equals(obj as Queue);
        }

        /// <summary>
        /// Returns true if Queue instances are equal
        /// </summary>
        /// <param name="other">Instance of Queue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Queue other)
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
                    this.WrapupCodes == other.WrapupCodes ||
                    this.WrapupCodes != null &&
                    this.WrapupCodes.SequenceEqual(other.WrapupCodes)
                ) && 
                (
                    this.MediaSettings == other.MediaSettings ||
                    this.MediaSettings != null &&
                    this.MediaSettings.SequenceEqual(other.MediaSettings)
                ) && 
                (
                    this.Bullseye == other.Bullseye ||
                    this.Bullseye != null &&
                    this.Bullseye.Equals(other.Bullseye)
                ) && 
                (
                    this.AcwSettings == other.AcwSettings ||
                    this.AcwSettings != null &&
                    this.AcwSettings.Equals(other.AcwSettings)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.SkillEvaluationMethod == other.SkillEvaluationMethod ||
                    this.SkillEvaluationMethod != null &&
                    this.SkillEvaluationMethod.Equals(other.SkillEvaluationMethod)
                ) && 
                (
                    this.QueueFlow == other.QueueFlow ||
                    this.QueueFlow != null &&
                    this.QueueFlow.Equals(other.QueueFlow)
                ) && 
                (
                    this.CallingPartyName == other.CallingPartyName ||
                    this.CallingPartyName != null &&
                    this.CallingPartyName.Equals(other.CallingPartyName)
                ) && 
                (
                    this.CallingPartyNumber == other.CallingPartyNumber ||
                    this.CallingPartyNumber != null &&
                    this.CallingPartyNumber.Equals(other.CallingPartyNumber)
                ) && 
                (
                    this.MemberCount == other.MemberCount ||
                    this.MemberCount != null &&
                    this.MemberCount.Equals(other.MemberCount)
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
                
                if (this.WrapupCodes != null)
                    hash = hash * 59 + this.WrapupCodes.GetHashCode();
                
                if (this.MediaSettings != null)
                    hash = hash * 59 + this.MediaSettings.GetHashCode();
                
                if (this.Bullseye != null)
                    hash = hash * 59 + this.Bullseye.GetHashCode();
                
                if (this.AcwSettings != null)
                    hash = hash * 59 + this.AcwSettings.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.SkillEvaluationMethod != null)
                    hash = hash * 59 + this.SkillEvaluationMethod.GetHashCode();
                
                if (this.QueueFlow != null)
                    hash = hash * 59 + this.QueueFlow.GetHashCode();
                
                if (this.CallingPartyName != null)
                    hash = hash * 59 + this.CallingPartyName.GetHashCode();
                
                if (this.CallingPartyNumber != null)
                    hash = hash * 59 + this.CallingPartyNumber.GetHashCode();
                
                if (this.MemberCount != null)
                    hash = hash * 59 + this.MemberCount.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
