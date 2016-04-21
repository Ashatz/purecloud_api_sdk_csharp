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
    public partial class Evaluation :  IEquatable<Evaluation>
    { 

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum {
            
            [EnumMember(Value = "PENDING")]
            Pending,
            
            [EnumMember(Value = "INPROGRESS")]
            Inprogress,
            
            [EnumMember(Value = "FINISHED")]
            Finished
        }


        /// <summary>
        /// The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.
        /// </summary>
        /// <value>The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ResourceTypeEnum {
            
            [EnumMember(Value = "Email")]
            Email
        }

        

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    

        /// <summary>
        /// The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.
        /// </summary>
        /// <value>The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.</value>
        [DataMember(Name="resourceType", EmitDefaultValue=false)]
        public ResourceTypeEnum? ResourceType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Evaluation" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Conversation">Conversation.</param>
        /// <param name="EvaluationForm">Evaluation form used for evaluation..</param>
        /// <param name="Evaluator">Evaluator.</param>
        /// <param name="Agent">Agent.</param>
        /// <param name="Calibration">Calibration.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Answers">Answers.</param>
        /// <param name="AgentHasRead">AgentHasRead (default to false).</param>
        /// <param name="ReleaseDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="AssignedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ChangedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Queue">Queue.</param>
        /// <param name="ResourceId">Only used for email evaluations. Will be null for all other evaluations..</param>
        /// <param name="ResourceType">The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources..</param>
        /// <param name="Redacted">Is only true when the user making the request does not have sufficient permissions to see evaluation (default to false).</param>
        /// <param name="IsScoringIndex">IsScoringIndex (default to false).</param>

        public Evaluation(string Name = null, Conversation Conversation = null, EvaluationForm EvaluationForm = null, User Evaluator = null, User Agent = null, Calibration Calibration = null, StatusEnum? Status = null, EvaluationScoringSet Answers = null, bool? AgentHasRead = null, DateTime? ReleaseDate = null, DateTime? AssignedDate = null, DateTime? ChangedDate = null, Queue Queue = null, string ResourceId = null, ResourceTypeEnum? ResourceType = null, bool? Redacted = null, bool? IsScoringIndex = null)
        {
            this.Name = Name;
            this.Conversation = Conversation;
            this.EvaluationForm = EvaluationForm;
            this.Evaluator = Evaluator;
            this.Agent = Agent;
            this.Calibration = Calibration;
            this.Status = Status;
            this.Answers = Answers;
            // use default value if no "AgentHasRead" provided
            if (AgentHasRead == null)
            {
                this.AgentHasRead = false;
            }
            else
            {
                this.AgentHasRead = AgentHasRead;
            }
            this.ReleaseDate = ReleaseDate;
            this.AssignedDate = AssignedDate;
            this.ChangedDate = ChangedDate;
            this.Queue = Queue;
            this.ResourceId = ResourceId;
            this.ResourceType = ResourceType;
            // use default value if no "Redacted" provided
            if (Redacted == null)
            {
                this.Redacted = false;
            }
            else
            {
                this.Redacted = Redacted;
            }
            // use default value if no "IsScoringIndex" provided
            if (IsScoringIndex == null)
            {
                this.IsScoringIndex = false;
            }
            else
            {
                this.IsScoringIndex = IsScoringIndex;
            }
            
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
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public Conversation Conversation { get; set; }
    
        /// <summary>
        /// Evaluation form used for evaluation.
        /// </summary>
        /// <value>Evaluation form used for evaluation.</value>
        [DataMember(Name="evaluationForm", EmitDefaultValue=false)]
        public EvaluationForm EvaluationForm { get; set; }
    
        /// <summary>
        /// Gets or Sets Evaluator
        /// </summary>
        [DataMember(Name="evaluator", EmitDefaultValue=false)]
        public User Evaluator { get; set; }
    
        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public User Agent { get; set; }
    
        /// <summary>
        /// Gets or Sets Calibration
        /// </summary>
        [DataMember(Name="calibration", EmitDefaultValue=false)]
        public Calibration Calibration { get; set; }
    
        /// <summary>
        /// Gets or Sets Answers
        /// </summary>
        [DataMember(Name="answers", EmitDefaultValue=false)]
        public EvaluationScoringSet Answers { get; set; }
    
        /// <summary>
        /// Gets or Sets AgentHasRead
        /// </summary>
        [DataMember(Name="agentHasRead", EmitDefaultValue=false)]
        public bool? AgentHasRead { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="releaseDate", EmitDefaultValue=false)]
        public DateTime? ReleaseDate { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="assignedDate", EmitDefaultValue=false)]
        public DateTime? AssignedDate { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="changedDate", EmitDefaultValue=false)]
        public DateTime? ChangedDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public Queue Queue { get; set; }
    
        /// <summary>
        /// Only used for email evaluations. Will be null for all other evaluations.
        /// </summary>
        /// <value>Only used for email evaluations. Will be null for all other evaluations.</value>
        [DataMember(Name="resourceId", EmitDefaultValue=false)]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Is only true when the user making the request does not have sufficient permissions to see evaluation
        /// </summary>
        /// <value>Is only true when the user making the request does not have sufficient permissions to see evaluation</value>
        [DataMember(Name="redacted", EmitDefaultValue=false)]
        public bool? Redacted { get; set; }
    
        /// <summary>
        /// Gets or Sets IsScoringIndex
        /// </summary>
        [DataMember(Name="isScoringIndex", EmitDefaultValue=false)]
        public bool? IsScoringIndex { get; set; }
    
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
            sb.Append("class Evaluation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
            sb.Append("  Evaluator: ").Append(Evaluator).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Calibration: ").Append(Calibration).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Answers: ").Append(Answers).Append("\n");
            sb.Append("  AgentHasRead: ").Append(AgentHasRead).Append("\n");
            sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
            sb.Append("  AssignedDate: ").Append(AssignedDate).Append("\n");
            sb.Append("  ChangedDate: ").Append(ChangedDate).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Redacted: ").Append(Redacted).Append("\n");
            sb.Append("  IsScoringIndex: ").Append(IsScoringIndex).Append("\n");
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
            return this.Equals(obj as Evaluation);
        }

        /// <summary>
        /// Returns true if Evaluation instances are equal
        /// </summary>
        /// <param name="other">Instance of Evaluation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Evaluation other)
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
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.EvaluationForm == other.EvaluationForm ||
                    this.EvaluationForm != null &&
                    this.EvaluationForm.Equals(other.EvaluationForm)
                ) &&
                (
                    this.Evaluator == other.Evaluator ||
                    this.Evaluator != null &&
                    this.Evaluator.Equals(other.Evaluator)
                ) &&
                (
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.Calibration == other.Calibration ||
                    this.Calibration != null &&
                    this.Calibration.Equals(other.Calibration)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Answers == other.Answers ||
                    this.Answers != null &&
                    this.Answers.Equals(other.Answers)
                ) &&
                (
                    this.AgentHasRead == other.AgentHasRead ||
                    this.AgentHasRead != null &&
                    this.AgentHasRead.Equals(other.AgentHasRead)
                ) &&
                (
                    this.ReleaseDate == other.ReleaseDate ||
                    this.ReleaseDate != null &&
                    this.ReleaseDate.Equals(other.ReleaseDate)
                ) &&
                (
                    this.AssignedDate == other.AssignedDate ||
                    this.AssignedDate != null &&
                    this.AssignedDate.Equals(other.AssignedDate)
                ) &&
                (
                    this.ChangedDate == other.ChangedDate ||
                    this.ChangedDate != null &&
                    this.ChangedDate.Equals(other.ChangedDate)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.ResourceId == other.ResourceId ||
                    this.ResourceId != null &&
                    this.ResourceId.Equals(other.ResourceId)
                ) &&
                (
                    this.ResourceType == other.ResourceType ||
                    this.ResourceType != null &&
                    this.ResourceType.Equals(other.ResourceType)
                ) &&
                (
                    this.Redacted == other.Redacted ||
                    this.Redacted != null &&
                    this.Redacted.Equals(other.Redacted)
                ) &&
                (
                    this.IsScoringIndex == other.IsScoringIndex ||
                    this.IsScoringIndex != null &&
                    this.IsScoringIndex.Equals(other.IsScoringIndex)
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
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();
                if (this.EvaluationForm != null)
                    hash = hash * 59 + this.EvaluationForm.GetHashCode();
                if (this.Evaluator != null)
                    hash = hash * 59 + this.Evaluator.GetHashCode();
                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();
                if (this.Calibration != null)
                    hash = hash * 59 + this.Calibration.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Answers != null)
                    hash = hash * 59 + this.Answers.GetHashCode();
                if (this.AgentHasRead != null)
                    hash = hash * 59 + this.AgentHasRead.GetHashCode();
                if (this.ReleaseDate != null)
                    hash = hash * 59 + this.ReleaseDate.GetHashCode();
                if (this.AssignedDate != null)
                    hash = hash * 59 + this.AssignedDate.GetHashCode();
                if (this.ChangedDate != null)
                    hash = hash * 59 + this.ChangedDate.GetHashCode();
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                if (this.ResourceId != null)
                    hash = hash * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceType != null)
                    hash = hash * 59 + this.ResourceType.GetHashCode();
                if (this.Redacted != null)
                    hash = hash * 59 + this.Redacted.GetHashCode();
                if (this.IsScoringIndex != null)
                    hash = hash * 59 + this.IsScoringIndex.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
