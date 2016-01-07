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
    public class Calibration :  IEquatable<Calibration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Calibration" /> class.
        /// </summary>
        public Calibration()
        {
            
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
        /// Gets or Sets Calibrator
        /// </summary>
        [DataMember(Name="calibrator", EmitDefaultValue=false)]
        public User Calibrator { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public User Agent { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public Conversation Conversation { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EvaluationForm
        /// </summary>
        [DataMember(Name="evaluationForm", EmitDefaultValue=false)]
        public EvaluationForm EvaluationForm { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ContextId
        /// </summary>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AverageScore
        /// </summary>
        [DataMember(Name="averageScore", EmitDefaultValue=false)]
        public int? AverageScore { get; set; }
  
        
        /// <summary>
        /// Gets or Sets HighScore
        /// </summary>
        [DataMember(Name="highScore", EmitDefaultValue=false)]
        public int? HighScore { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LowScore
        /// </summary>
        [DataMember(Name="lowScore", EmitDefaultValue=false)]
        public int? LowScore { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Evaluations
        /// </summary>
        [DataMember(Name="evaluations", EmitDefaultValue=false)]
        public List<Evaluation> Evaluations { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Evaluators
        /// </summary>
        [DataMember(Name="evaluators", EmitDefaultValue=false)]
        public List<User> Evaluators { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ScoringIndex
        /// </summary>
        [DataMember(Name="scoringIndex", EmitDefaultValue=false)]
        public Evaluation ScoringIndex { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ExpertEvaluator
        /// </summary>
        [DataMember(Name="expertEvaluator", EmitDefaultValue=false)]
        public User ExpertEvaluator { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Calibration {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Calibrator: ").Append(Calibrator).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  AverageScore: ").Append(AverageScore).Append("\n");
            sb.Append("  HighScore: ").Append(HighScore).Append("\n");
            sb.Append("  LowScore: ").Append(LowScore).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Evaluations: ").Append(Evaluations).Append("\n");
            sb.Append("  Evaluators: ").Append(Evaluators).Append("\n");
            sb.Append("  ScoringIndex: ").Append(ScoringIndex).Append("\n");
            sb.Append("  ExpertEvaluator: ").Append(ExpertEvaluator).Append("\n");
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
            return this.Equals(obj as Calibration);
        }

        /// <summary>
        /// Returns true if Calibration instances are equal
        /// </summary>
        /// <param name="obj">Instance of Calibration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Calibration other)
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
                    this.Calibrator == other.Calibrator ||
                    this.Calibrator != null &&
                    this.Calibrator.Equals(other.Calibrator)
                ) && 
                (
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
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
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) && 
                (
                    this.AverageScore == other.AverageScore ||
                    this.AverageScore != null &&
                    this.AverageScore.Equals(other.AverageScore)
                ) && 
                (
                    this.HighScore == other.HighScore ||
                    this.HighScore != null &&
                    this.HighScore.Equals(other.HighScore)
                ) && 
                (
                    this.LowScore == other.LowScore ||
                    this.LowScore != null &&
                    this.LowScore.Equals(other.LowScore)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Evaluations == other.Evaluations ||
                    this.Evaluations != null &&
                    this.Evaluations.SequenceEqual(other.Evaluations)
                ) && 
                (
                    this.Evaluators == other.Evaluators ||
                    this.Evaluators != null &&
                    this.Evaluators.SequenceEqual(other.Evaluators)
                ) && 
                (
                    this.ScoringIndex == other.ScoringIndex ||
                    this.ScoringIndex != null &&
                    this.ScoringIndex.Equals(other.ScoringIndex)
                ) && 
                (
                    this.ExpertEvaluator == other.ExpertEvaluator ||
                    this.ExpertEvaluator != null &&
                    this.ExpertEvaluator.Equals(other.ExpertEvaluator)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Calibrator != null)
                    hash = hash * 57 + this.Calibrator.GetHashCode();
                
                if (this.Agent != null)
                    hash = hash * 57 + this.Agent.GetHashCode();
                
                if (this.Conversation != null)
                    hash = hash * 57 + this.Conversation.GetHashCode();
                
                if (this.EvaluationForm != null)
                    hash = hash * 57 + this.EvaluationForm.GetHashCode();
                
                if (this.ContextId != null)
                    hash = hash * 57 + this.ContextId.GetHashCode();
                
                if (this.AverageScore != null)
                    hash = hash * 57 + this.AverageScore.GetHashCode();
                
                if (this.HighScore != null)
                    hash = hash * 57 + this.HighScore.GetHashCode();
                
                if (this.LowScore != null)
                    hash = hash * 57 + this.LowScore.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 57 + this.CreatedDate.GetHashCode();
                
                if (this.Evaluations != null)
                    hash = hash * 57 + this.Evaluations.GetHashCode();
                
                if (this.Evaluators != null)
                    hash = hash * 57 + this.Evaluators.GetHashCode();
                
                if (this.ScoringIndex != null)
                    hash = hash * 57 + this.ScoringIndex.GetHashCode();
                
                if (this.ExpertEvaluator != null)
                    hash = hash * 57 + this.ExpertEvaluator.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
