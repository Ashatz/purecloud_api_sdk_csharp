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
    /// Details about the current state of a Flow Instance
    /// </summary>
    [DataContract]
    public partial class FlowDetails :  IEquatable<FlowDetails>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LaunchTypeEnum {
            
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            [EnumMember(Value = "NORMAL")]
            Normal,
            
            [EnumMember(Value = "TEST")]
            Test,
            
            [EnumMember(Value = "AUTOMATIC")]
            Automatic
        }
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            [EnumMember(Value = "RUNNING")]
            Running,
            
            [EnumMember(Value = "ERROR")]
            Error,
            
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            
            [EnumMember(Value = "COMPLETED")]
            Completed
        }
        
        /// <summary>
        /// The launch mode for this flow instance.
        /// </summary>
        /// <value>The launch mode for this flow instance.</value>
        [DataMember(Name="launchType", EmitDefaultValue=false)]
        public LaunchTypeEnum? LaunchType { get; set; }
    
        /// <summary>
        /// The flow's running status, which indicates whether the flow is running normally or completed, etc.
        /// </summary>
        /// <value>The flow's running status, which indicates whether the flow is running normally or completed, etc.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowDetails" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="FlowConfigId">The FlowConfigId that was used to launch this flow. (required).</param>
        /// <param name="LaunchTime">The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (required).</param>
        /// <param name="LaunchType">The launch mode for this flow instance. (required).</param>
        /// <param name="LaunchedBy">The user who launched the flow, if the flow was launched as the result of that user&#39;s action..</param>
        /// <param name="Status">The flow&#39;s running status, which indicates whether the flow is running normally or completed, etc..</param>
        /// <param name="AssociatedDocuments">The documents associated with this flow..</param>
        /// <param name="FlowCompletionTime">The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="FlowCompletionReason">The completion reason set at the flow completion time, if applicable..</param>
        /// <param name="FlowErrorInfo">Additional information if the flow is in error.</param>

        public FlowDetails(string Name = null, FlowConfigId FlowConfigId = null, DateTime? LaunchTime = null, LaunchTypeEnum? LaunchType = null, User LaunchedBy = null, StatusEnum? Status = null, List<AssociatedDocument> AssociatedDocuments = null, DateTime? FlowCompletionTime = null, string FlowCompletionReason = null, ErrorBody FlowErrorInfo = null, )
        {
            // to ensure "FlowConfigId" is required (not null)
            if (FlowConfigId == null)
            {
                throw new InvalidDataException("FlowConfigId is a required property for FlowDetails and cannot be null");
            }
            else
            {
                this.FlowConfigId = FlowConfigId;
            }
            // to ensure "LaunchTime" is required (not null)
            if (LaunchTime == null)
            {
                throw new InvalidDataException("LaunchTime is a required property for FlowDetails and cannot be null");
            }
            else
            {
                this.LaunchTime = LaunchTime;
            }
            // to ensure "LaunchType" is required (not null)
            if (LaunchType == null)
            {
                throw new InvalidDataException("LaunchType is a required property for FlowDetails and cannot be null");
            }
            else
            {
                this.LaunchType = LaunchType;
            }
            this.Name = Name;
            this.LaunchedBy = LaunchedBy;
            this.Status = Status;
            this.AssociatedDocuments = AssociatedDocuments;
            this.FlowCompletionTime = FlowCompletionTime;
            this.FlowCompletionReason = FlowCompletionReason;
            this.FlowErrorInfo = FlowErrorInfo;
            
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
        /// The FlowConfigId that was used to launch this flow.
        /// </summary>
        /// <value>The FlowConfigId that was used to launch this flow.</value>
        [DataMember(Name="flowConfigId", EmitDefaultValue=false)]
        public FlowConfigId FlowConfigId { get; set; }
    
        /// <summary>
        /// The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="launchTime", EmitDefaultValue=false)]
        public DateTime? LaunchTime { get; set; }
    
        /// <summary>
        /// The user who launched the flow, if the flow was launched as the result of that user's action.
        /// </summary>
        /// <value>The user who launched the flow, if the flow was launched as the result of that user's action.</value>
        [DataMember(Name="launchedBy", EmitDefaultValue=false)]
        public User LaunchedBy { get; set; }
    
        /// <summary>
        /// The documents associated with this flow.
        /// </summary>
        /// <value>The documents associated with this flow.</value>
        [DataMember(Name="associatedDocuments", EmitDefaultValue=false)]
        public List<AssociatedDocument> AssociatedDocuments { get; set; }
    
        /// <summary>
        /// The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="flowCompletionTime", EmitDefaultValue=false)]
        public DateTime? FlowCompletionTime { get; set; }
    
        /// <summary>
        /// The completion reason set at the flow completion time, if applicable.
        /// </summary>
        /// <value>The completion reason set at the flow completion time, if applicable.</value>
        [DataMember(Name="flowCompletionReason", EmitDefaultValue=false)]
        public string FlowCompletionReason { get; set; }
    
        /// <summary>
        /// Additional information if the flow is in error
        /// </summary>
        /// <value>Additional information if the flow is in error</value>
        [DataMember(Name="flowErrorInfo", EmitDefaultValue=false)]
        public ErrorBody FlowErrorInfo { get; set; }
    
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
            sb.Append("class FlowDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FlowConfigId: ").Append(FlowConfigId).Append("\n");
            sb.Append("  LaunchTime: ").Append(LaunchTime).Append("\n");
            sb.Append("  LaunchType: ").Append(LaunchType).Append("\n");
            sb.Append("  LaunchedBy: ").Append(LaunchedBy).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AssociatedDocuments: ").Append(AssociatedDocuments).Append("\n");
            sb.Append("  FlowCompletionTime: ").Append(FlowCompletionTime).Append("\n");
            sb.Append("  FlowCompletionReason: ").Append(FlowCompletionReason).Append("\n");
            sb.Append("  FlowErrorInfo: ").Append(FlowErrorInfo).Append("\n");
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
            return this.Equals(obj as FlowDetails);
        }

        /// <summary>
        /// Returns true if FlowDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowDetails other)
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
                    this.FlowConfigId == other.FlowConfigId ||
                    this.FlowConfigId != null &&
                    this.FlowConfigId.Equals(other.FlowConfigId)
                ) &&
                (
                    this.LaunchTime == other.LaunchTime ||
                    this.LaunchTime != null &&
                    this.LaunchTime.Equals(other.LaunchTime)
                ) &&
                (
                    this.LaunchType == other.LaunchType ||
                    this.LaunchType != null &&
                    this.LaunchType.Equals(other.LaunchType)
                ) &&
                (
                    this.LaunchedBy == other.LaunchedBy ||
                    this.LaunchedBy != null &&
                    this.LaunchedBy.Equals(other.LaunchedBy)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.AssociatedDocuments == other.AssociatedDocuments ||
                    this.AssociatedDocuments != null &&
                    this.AssociatedDocuments.SequenceEqual(other.AssociatedDocuments)
                ) &&
                (
                    this.FlowCompletionTime == other.FlowCompletionTime ||
                    this.FlowCompletionTime != null &&
                    this.FlowCompletionTime.Equals(other.FlowCompletionTime)
                ) &&
                (
                    this.FlowCompletionReason == other.FlowCompletionReason ||
                    this.FlowCompletionReason != null &&
                    this.FlowCompletionReason.Equals(other.FlowCompletionReason)
                ) &&
                (
                    this.FlowErrorInfo == other.FlowErrorInfo ||
                    this.FlowErrorInfo != null &&
                    this.FlowErrorInfo.Equals(other.FlowErrorInfo)
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
                
                if (this.FlowConfigId != null)
                    hash = hash * 59 + this.FlowConfigId.GetHashCode();
                
                if (this.LaunchTime != null)
                    hash = hash * 59 + this.LaunchTime.GetHashCode();
                
                if (this.LaunchType != null)
                    hash = hash * 59 + this.LaunchType.GetHashCode();
                
                if (this.LaunchedBy != null)
                    hash = hash * 59 + this.LaunchedBy.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.AssociatedDocuments != null)
                    hash = hash * 59 + this.AssociatedDocuments.GetHashCode();
                
                if (this.FlowCompletionTime != null)
                    hash = hash * 59 + this.FlowCompletionTime.GetHashCode();
                
                if (this.FlowCompletionReason != null)
                    hash = hash * 59 + this.FlowCompletionReason.GetHashCode();
                
                if (this.FlowErrorInfo != null)
                    hash = hash * 59 + this.FlowErrorInfo.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
