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
    public class EvaluationQueryRequest :  IEquatable<EvaluationQueryRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationQueryRequest" /> class.
        /// </summary>
        public EvaluationQueryRequest()
        {
            this.IsReleased = false;
            this.AgentHasRead = false;
            this.ExpandAnswerTotalScores = false;
            
        }

        
        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets UserType
        /// </summary>
        [DataMember(Name="userType", EmitDefaultValue=false)]
        public string UserType { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CurrentUserId
        /// </summary>
        [DataMember(Name="currentUserId", EmitDefaultValue=false)]
        public string CurrentUserId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AgentId
        /// </summary>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EvaluationState
        /// </summary>
        [DataMember(Name="evaluationState", EmitDefaultValue=false)]
        public List<string> EvaluationState { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IsReleased
        /// </summary>
        [DataMember(Name="isReleased", EmitDefaultValue=false)]
        public bool? IsReleased { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AgentHasRead
        /// </summary>
        [DataMember(Name="agentHasRead", EmitDefaultValue=false)]
        public bool? AgentHasRead { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ExpandAnswerTotalScores
        /// </summary>
        [DataMember(Name="expandAnswerTotalScores", EmitDefaultValue=false)]
        public bool? ExpandAnswerTotalScores { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Maximum
        /// </summary>
        [DataMember(Name="maximum", EmitDefaultValue=false)]
        public int? Maximum { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationQueryRequest {\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
            sb.Append("  CurrentUserId: ").Append(CurrentUserId).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  EvaluationState: ").Append(EvaluationState).Append("\n");
            sb.Append("  IsReleased: ").Append(IsReleased).Append("\n");
            sb.Append("  AgentHasRead: ").Append(AgentHasRead).Append("\n");
            sb.Append("  ExpandAnswerTotalScores: ").Append(ExpandAnswerTotalScores).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
            
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
            return this.Equals(obj as EvaluationQueryRequest);
        }

        /// <summary>
        /// Returns true if EvaluationQueryRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of EvaluationQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationQueryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) && 
                (
                    this.UserType == other.UserType ||
                    this.UserType != null &&
                    this.UserType.Equals(other.UserType)
                ) && 
                (
                    this.CurrentUserId == other.CurrentUserId ||
                    this.CurrentUserId != null &&
                    this.CurrentUserId.Equals(other.CurrentUserId)
                ) && 
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) && 
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) && 
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) && 
                (
                    this.EvaluationState == other.EvaluationState ||
                    this.EvaluationState != null &&
                    this.EvaluationState.SequenceEqual(other.EvaluationState)
                ) && 
                (
                    this.IsReleased == other.IsReleased ||
                    this.IsReleased != null &&
                    this.IsReleased.Equals(other.IsReleased)
                ) && 
                (
                    this.AgentHasRead == other.AgentHasRead ||
                    this.AgentHasRead != null &&
                    this.AgentHasRead.Equals(other.AgentHasRead)
                ) && 
                (
                    this.ExpandAnswerTotalScores == other.ExpandAnswerTotalScores ||
                    this.ExpandAnswerTotalScores != null &&
                    this.ExpandAnswerTotalScores.Equals(other.ExpandAnswerTotalScores)
                ) && 
                (
                    this.Maximum == other.Maximum ||
                    this.Maximum != null &&
                    this.Maximum.Equals(other.Maximum)
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
                
                if (this.ConversationId != null)
                    hash = hash * 57 + this.ConversationId.GetHashCode();
                
                if (this.UserType != null)
                    hash = hash * 57 + this.UserType.GetHashCode();
                
                if (this.CurrentUserId != null)
                    hash = hash * 57 + this.CurrentUserId.GetHashCode();
                
                if (this.AgentId != null)
                    hash = hash * 57 + this.AgentId.GetHashCode();
                
                if (this.QueueId != null)
                    hash = hash * 57 + this.QueueId.GetHashCode();
                
                if (this.Interval != null)
                    hash = hash * 57 + this.Interval.GetHashCode();
                
                if (this.EvaluationState != null)
                    hash = hash * 57 + this.EvaluationState.GetHashCode();
                
                if (this.IsReleased != null)
                    hash = hash * 57 + this.IsReleased.GetHashCode();
                
                if (this.AgentHasRead != null)
                    hash = hash * 57 + this.AgentHasRead.GetHashCode();
                
                if (this.ExpandAnswerTotalScores != null)
                    hash = hash * 57 + this.ExpandAnswerTotalScores.GetHashCode();
                
                if (this.Maximum != null)
                    hash = hash * 57 + this.Maximum.GetHashCode();
                
                return hash;
            }
        }

    }


}