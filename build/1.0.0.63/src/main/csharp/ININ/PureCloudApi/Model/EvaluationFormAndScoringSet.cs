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
    public class EvaluationFormAndScoringSet :  IEquatable<EvaluationFormAndScoringSet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationFormAndScoringSet" /> class.
        /// </summary>
        public EvaluationFormAndScoringSet()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets EvaluationForm
        /// </summary>
        [DataMember(Name="evaluationForm", EmitDefaultValue=false)]
        public EvaluationForm EvaluationForm { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Answers
        /// </summary>
        [DataMember(Name="answers", EmitDefaultValue=false)]
        public EvaluationScoringSet Answers { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationFormAndScoringSet {\n");
            sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
            sb.Append("  Answers: ").Append(Answers).Append("\n");
            
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
            return this.Equals(obj as EvaluationFormAndScoringSet);
        }

        /// <summary>
        /// Returns true if EvaluationFormAndScoringSet instances are equal
        /// </summary>
        /// <param name="obj">Instance of EvaluationFormAndScoringSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationFormAndScoringSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EvaluationForm == other.EvaluationForm ||
                    this.EvaluationForm != null &&
                    this.EvaluationForm.Equals(other.EvaluationForm)
                ) && 
                (
                    this.Answers == other.Answers ||
                    this.Answers != null &&
                    this.Answers.Equals(other.Answers)
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
                
                if (this.EvaluationForm != null)
                    hash = hash * 57 + this.EvaluationForm.GetHashCode();
                
                if (this.Answers != null)
                    hash = hash * 57 + this.Answers.GetHashCode();
                
                return hash;
            }
        }

    }


}
