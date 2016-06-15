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
    /// DependencyStatus
    /// </summary>
    [DataContract]
    public partial class DependencyStatus :  IEquatable<DependencyStatus>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Buildinitializing for "BUILDINITIALIZING"
            /// </summary>
            [EnumMember(Value = "BUILDINITIALIZING")]
            Buildinitializing,
            
            /// <summary>
            /// Enum Buildinprogress for "BUILDINPROGRESS"
            /// </summary>
            [EnumMember(Value = "BUILDINPROGRESS")]
            Buildinprogress,
            
            /// <summary>
            /// Enum Notbuilt for "NOTBUILT"
            /// </summary>
            [EnumMember(Value = "NOTBUILT")]
            Notbuilt,
            
            /// <summary>
            /// Enum Operational for "OPERATIONAL"
            /// </summary>
            [EnumMember(Value = "OPERATIONAL")]
            Operational,
            
            /// <summary>
            /// Enum Operationalneedsrebuild for "OPERATIONALNEEDSREBUILD"
            /// </summary>
            [EnumMember(Value = "OPERATIONALNEEDSREBUILD")]
            Operationalneedsrebuild
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyStatus" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="User">User.</param>
        /// <param name="BuildId">BuildId.</param>
        /// <param name="DateStarted">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateCompleted">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Status">Status.</param>
        /// <param name="FailedObjects">FailedObjects.</param>
        public DependencyStatus(string Name = null, User User = null, string BuildId = null, DateTime? DateStarted = null, DateTime? DateCompleted = null, StatusEnum? Status = null, List<FailedObject> FailedObjects = null)
        {
            this.Name = Name;
            this.User = User;
            this.BuildId = BuildId;
            this.DateStarted = DateStarted;
            this.DateCompleted = DateCompleted;
            this.Status = Status;
            this.FailedObjects = FailedObjects;
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
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        /// <summary>
        /// Gets or Sets BuildId
        /// </summary>
        [DataMember(Name="buildId", EmitDefaultValue=false)]
        public string BuildId { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateStarted", EmitDefaultValue=false)]
        public DateTime? DateStarted { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCompleted", EmitDefaultValue=false)]
        public DateTime? DateCompleted { get; set; }
        /// <summary>
        /// Gets or Sets FailedObjects
        /// </summary>
        [DataMember(Name="failedObjects", EmitDefaultValue=false)]
        public List<FailedObject> FailedObjects { get; set; }
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
            sb.Append("class DependencyStatus {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  BuildId: ").Append(BuildId).Append("\n");
            sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
            sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FailedObjects: ").Append(FailedObjects).Append("\n");
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
            return this.Equals(obj as DependencyStatus);
        }

        /// <summary>
        /// Returns true if DependencyStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of DependencyStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DependencyStatus other)
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
                    this.BuildId == other.BuildId ||
                    this.BuildId != null &&
                    this.BuildId.Equals(other.BuildId)
                ) &&
                (
                    this.DateStarted == other.DateStarted ||
                    this.DateStarted != null &&
                    this.DateStarted.Equals(other.DateStarted)
                ) &&
                (
                    this.DateCompleted == other.DateCompleted ||
                    this.DateCompleted != null &&
                    this.DateCompleted.Equals(other.DateCompleted)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.FailedObjects == other.FailedObjects ||
                    this.FailedObjects != null &&
                    this.FailedObjects.SequenceEqual(other.FailedObjects)
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
                if (this.BuildId != null)
                    hash = hash * 59 + this.BuildId.GetHashCode();
                if (this.DateStarted != null)
                    hash = hash * 59 + this.DateStarted.GetHashCode();
                if (this.DateCompleted != null)
                    hash = hash * 59 + this.DateCompleted.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.FailedObjects != null)
                    hash = hash * 59 + this.FailedObjects.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}