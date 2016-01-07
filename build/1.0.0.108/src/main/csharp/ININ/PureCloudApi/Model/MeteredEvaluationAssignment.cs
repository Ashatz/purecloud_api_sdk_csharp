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
    public class MeteredEvaluationAssignment :  IEquatable<MeteredEvaluationAssignment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeteredEvaluationAssignment" /> class.
        /// </summary>
        public MeteredEvaluationAssignment()
        {
            this.AssignToActiveUser = false;
            
        }

        
        /// <summary>
        /// Gets or Sets EvaluationContextId
        /// </summary>
        [DataMember(Name="evaluationContextId", EmitDefaultValue=false)]
        public string EvaluationContextId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Evaluators
        /// </summary>
        [DataMember(Name="evaluators", EmitDefaultValue=false)]
        public List<User> Evaluators { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MaxNumberEvaluations
        /// </summary>
        [DataMember(Name="maxNumberEvaluations", EmitDefaultValue=false)]
        public int? MaxNumberEvaluations { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EvaluationForm
        /// </summary>
        [DataMember(Name="evaluationForm", EmitDefaultValue=false)]
        public EvaluationForm EvaluationForm { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AssignToActiveUser
        /// </summary>
        [DataMember(Name="assignToActiveUser", EmitDefaultValue=false)]
        public bool? AssignToActiveUser { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TimeInterval
        /// </summary>
        [DataMember(Name="timeInterval", EmitDefaultValue=false)]
        public TimeInterval TimeInterval { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeteredEvaluationAssignment {\n");
            sb.Append("  EvaluationContextId: ").Append(EvaluationContextId).Append("\n");
            sb.Append("  Evaluators: ").Append(Evaluators).Append("\n");
            sb.Append("  MaxNumberEvaluations: ").Append(MaxNumberEvaluations).Append("\n");
            sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
            sb.Append("  AssignToActiveUser: ").Append(AssignToActiveUser).Append("\n");
            sb.Append("  TimeInterval: ").Append(TimeInterval).Append("\n");
            
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
            return this.Equals(obj as MeteredEvaluationAssignment);
        }

        /// <summary>
        /// Returns true if MeteredEvaluationAssignment instances are equal
        /// </summary>
        /// <param name="obj">Instance of MeteredEvaluationAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeteredEvaluationAssignment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EvaluationContextId == other.EvaluationContextId ||
                    this.EvaluationContextId != null &&
                    this.EvaluationContextId.Equals(other.EvaluationContextId)
                ) && 
                (
                    this.Evaluators == other.Evaluators ||
                    this.Evaluators != null &&
                    this.Evaluators.SequenceEqual(other.Evaluators)
                ) && 
                (
                    this.MaxNumberEvaluations == other.MaxNumberEvaluations ||
                    this.MaxNumberEvaluations != null &&
                    this.MaxNumberEvaluations.Equals(other.MaxNumberEvaluations)
                ) && 
                (
                    this.EvaluationForm == other.EvaluationForm ||
                    this.EvaluationForm != null &&
                    this.EvaluationForm.Equals(other.EvaluationForm)
                ) && 
                (
                    this.AssignToActiveUser == other.AssignToActiveUser ||
                    this.AssignToActiveUser != null &&
                    this.AssignToActiveUser.Equals(other.AssignToActiveUser)
                ) && 
                (
                    this.TimeInterval == other.TimeInterval ||
                    this.TimeInterval != null &&
                    this.TimeInterval.Equals(other.TimeInterval)
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
                
                if (this.EvaluationContextId != null)
                    hash = hash * 57 + this.EvaluationContextId.GetHashCode();
                
                if (this.Evaluators != null)
                    hash = hash * 57 + this.Evaluators.GetHashCode();
                
                if (this.MaxNumberEvaluations != null)
                    hash = hash * 57 + this.MaxNumberEvaluations.GetHashCode();
                
                if (this.EvaluationForm != null)
                    hash = hash * 57 + this.EvaluationForm.GetHashCode();
                
                if (this.AssignToActiveUser != null)
                    hash = hash * 57 + this.AssignToActiveUser.GetHashCode();
                
                if (this.TimeInterval != null)
                    hash = hash * 57 + this.TimeInterval.GetHashCode();
                
                return hash;
            }
        }

    }


}