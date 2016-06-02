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
    /// VoicemailMessage
    /// </summary>
    [DataContract]
    public partial class VoicemailMessage :  IEquatable<VoicemailMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailMessage" /> class.
        /// </summary>
        /// <param name="Conversation">Conversation.</param>
        /// <param name="Read">Read (default to false).</param>
        /// <param name="AudioRecordingDurationSeconds">AudioRecordingDurationSeconds.</param>
        /// <param name="AudioRecordingSizeBytes">AudioRecordingSizeBytes.</param>
        /// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="CallerAddress">CallerAddress.</param>
        /// <param name="CallerName">CallerName.</param>
        /// <param name="CallerUser">CallerUser.</param>
        public VoicemailMessage(Conversation Conversation = null, bool? Read = null, int? AudioRecordingDurationSeconds = null, long? AudioRecordingSizeBytes = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null, string CallerAddress = null, string CallerName = null, User CallerUser = null)
        {
            this.Conversation = Conversation;
            // use default value if no "Read" provided
            if (Read == null)
            {
                this.Read = false;
            }
            else
            {
                this.Read = Read;
            }
            this.AudioRecordingDurationSeconds = AudioRecordingDurationSeconds;
            this.AudioRecordingSizeBytes = AudioRecordingSizeBytes;
            this.CreatedDate = CreatedDate;
            this.ModifiedDate = ModifiedDate;
            this.CallerAddress = CallerAddress;
            this.CallerName = CallerName;
            this.CallerUser = CallerUser;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public Conversation Conversation { get; set; }
        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }
        /// <summary>
        /// Gets or Sets AudioRecordingDurationSeconds
        /// </summary>
        [DataMember(Name="audioRecordingDurationSeconds", EmitDefaultValue=false)]
        public int? AudioRecordingDurationSeconds { get; set; }
        /// <summary>
        /// Gets or Sets AudioRecordingSizeBytes
        /// </summary>
        [DataMember(Name="audioRecordingSizeBytes", EmitDefaultValue=false)]
        public long? AudioRecordingSizeBytes { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Gets or Sets CallerAddress
        /// </summary>
        [DataMember(Name="callerAddress", EmitDefaultValue=false)]
        public string CallerAddress { get; set; }
        /// <summary>
        /// Gets or Sets CallerName
        /// </summary>
        [DataMember(Name="callerName", EmitDefaultValue=false)]
        public string CallerName { get; set; }
        /// <summary>
        /// Gets or Sets CallerUser
        /// </summary>
        [DataMember(Name="callerUser", EmitDefaultValue=false)]
        public User CallerUser { get; set; }
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
            sb.Append("class VoicemailMessage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  AudioRecordingDurationSeconds: ").Append(AudioRecordingDurationSeconds).Append("\n");
            sb.Append("  AudioRecordingSizeBytes: ").Append(AudioRecordingSizeBytes).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
            sb.Append("  CallerName: ").Append(CallerName).Append("\n");
            sb.Append("  CallerUser: ").Append(CallerUser).Append("\n");
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
            return this.Equals(obj as VoicemailMessage);
        }

        /// <summary>
        /// Returns true if VoicemailMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailMessage other)
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
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
                ) &&
                (
                    this.AudioRecordingDurationSeconds == other.AudioRecordingDurationSeconds ||
                    this.AudioRecordingDurationSeconds != null &&
                    this.AudioRecordingDurationSeconds.Equals(other.AudioRecordingDurationSeconds)
                ) &&
                (
                    this.AudioRecordingSizeBytes == other.AudioRecordingSizeBytes ||
                    this.AudioRecordingSizeBytes != null &&
                    this.AudioRecordingSizeBytes.Equals(other.AudioRecordingSizeBytes)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.CallerAddress == other.CallerAddress ||
                    this.CallerAddress != null &&
                    this.CallerAddress.Equals(other.CallerAddress)
                ) &&
                (
                    this.CallerName == other.CallerName ||
                    this.CallerName != null &&
                    this.CallerName.Equals(other.CallerName)
                ) &&
                (
                    this.CallerUser == other.CallerUser ||
                    this.CallerUser != null &&
                    this.CallerUser.Equals(other.CallerUser)
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
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();
                if (this.Read != null)
                    hash = hash * 59 + this.Read.GetHashCode();
                if (this.AudioRecordingDurationSeconds != null)
                    hash = hash * 59 + this.AudioRecordingDurationSeconds.GetHashCode();
                if (this.AudioRecordingSizeBytes != null)
                    hash = hash * 59 + this.AudioRecordingSizeBytes.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                if (this.CallerAddress != null)
                    hash = hash * 59 + this.CallerAddress.GetHashCode();
                if (this.CallerName != null)
                    hash = hash * 59 + this.CallerName.GetHashCode();
                if (this.CallerUser != null)
                    hash = hash * 59 + this.CallerUser.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
