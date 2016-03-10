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
    public partial class QuestionGroupScore :  IEquatable<QuestionGroupScore>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionGroupScore" />class.
        /// </summary>
        /// <param name="QuestionGroupId">QuestionGroupId.</param>
        /// <param name="TotalScore">TotalScore.</param>
        /// <param name="MaxTotalScore">MaxTotalScore.</param>
        /// <param name="TotalCriticalScore">TotalCriticalScore.</param>
        /// <param name="MaxTotalCriticalScore">MaxTotalCriticalScore.</param>
        /// <param name="TotalScoreUnweighted">TotalScoreUnweighted.</param>
        /// <param name="MaxTotalScoreUnweighted">MaxTotalScoreUnweighted.</param>
        /// <param name="TotalCriticalScoreUnweighted">TotalCriticalScoreUnweighted.</param>
        /// <param name="MaxTotalCriticalScoreUnweighted">MaxTotalCriticalScoreUnweighted.</param>
        /// <param name="MarkedNA">MarkedNA (default to false).</param>
        /// <param name="QuestionScores">QuestionScores.</param>

        public QuestionGroupScore(string QuestionGroupId = null, float? TotalScore = null, float? MaxTotalScore = null, float? TotalCriticalScore = null, float? MaxTotalCriticalScore = null, float? TotalScoreUnweighted = null, float? MaxTotalScoreUnweighted = null, float? TotalCriticalScoreUnweighted = null, float? MaxTotalCriticalScoreUnweighted = null, bool? MarkedNA = null, List<QuestionScore> QuestionScores = null)
        {
            this.QuestionGroupId = QuestionGroupId;
            this.TotalScore = TotalScore;
            this.MaxTotalScore = MaxTotalScore;
            this.TotalCriticalScore = TotalCriticalScore;
            this.MaxTotalCriticalScore = MaxTotalCriticalScore;
            this.TotalScoreUnweighted = TotalScoreUnweighted;
            this.MaxTotalScoreUnweighted = MaxTotalScoreUnweighted;
            this.TotalCriticalScoreUnweighted = TotalCriticalScoreUnweighted;
            this.MaxTotalCriticalScoreUnweighted = MaxTotalCriticalScoreUnweighted;
            // use default value if no "MarkedNA" provided
            if (MarkedNA == null)
            {
                this.MarkedNA = false;
            }
            else
            {
                this.MarkedNA = MarkedNA;
            }
            this.QuestionScores = QuestionScores;
            
        }
        
    
        /// <summary>
        /// Gets or Sets QuestionGroupId
        /// </summary>
        [DataMember(Name="questionGroupId", EmitDefaultValue=false)]
        public string QuestionGroupId { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalScore
        /// </summary>
        [DataMember(Name="totalScore", EmitDefaultValue=false)]
        public float? TotalScore { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxTotalScore
        /// </summary>
        [DataMember(Name="maxTotalScore", EmitDefaultValue=false)]
        public float? MaxTotalScore { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalCriticalScore
        /// </summary>
        [DataMember(Name="totalCriticalScore", EmitDefaultValue=false)]
        public float? TotalCriticalScore { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxTotalCriticalScore
        /// </summary>
        [DataMember(Name="maxTotalCriticalScore", EmitDefaultValue=false)]
        public float? MaxTotalCriticalScore { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalScoreUnweighted
        /// </summary>
        [DataMember(Name="totalScoreUnweighted", EmitDefaultValue=false)]
        public float? TotalScoreUnweighted { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxTotalScoreUnweighted
        /// </summary>
        [DataMember(Name="maxTotalScoreUnweighted", EmitDefaultValue=false)]
        public float? MaxTotalScoreUnweighted { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalCriticalScoreUnweighted
        /// </summary>
        [DataMember(Name="totalCriticalScoreUnweighted", EmitDefaultValue=false)]
        public float? TotalCriticalScoreUnweighted { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxTotalCriticalScoreUnweighted
        /// </summary>
        [DataMember(Name="maxTotalCriticalScoreUnweighted", EmitDefaultValue=false)]
        public float? MaxTotalCriticalScoreUnweighted { get; set; }
    
        /// <summary>
        /// Gets or Sets MarkedNA
        /// </summary>
        [DataMember(Name="markedNA", EmitDefaultValue=false)]
        public bool? MarkedNA { get; set; }
    
        /// <summary>
        /// Gets or Sets QuestionScores
        /// </summary>
        [DataMember(Name="questionScores", EmitDefaultValue=false)]
        public List<QuestionScore> QuestionScores { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuestionGroupScore {\n");
            sb.Append("  QuestionGroupId: ").Append(QuestionGroupId).Append("\n");
            sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
            sb.Append("  MaxTotalScore: ").Append(MaxTotalScore).Append("\n");
            sb.Append("  TotalCriticalScore: ").Append(TotalCriticalScore).Append("\n");
            sb.Append("  MaxTotalCriticalScore: ").Append(MaxTotalCriticalScore).Append("\n");
            sb.Append("  TotalScoreUnweighted: ").Append(TotalScoreUnweighted).Append("\n");
            sb.Append("  MaxTotalScoreUnweighted: ").Append(MaxTotalScoreUnweighted).Append("\n");
            sb.Append("  TotalCriticalScoreUnweighted: ").Append(TotalCriticalScoreUnweighted).Append("\n");
            sb.Append("  MaxTotalCriticalScoreUnweighted: ").Append(MaxTotalCriticalScoreUnweighted).Append("\n");
            sb.Append("  MarkedNA: ").Append(MarkedNA).Append("\n");
            sb.Append("  QuestionScores: ").Append(QuestionScores).Append("\n");
            
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
            return this.Equals(obj as QuestionGroupScore);
        }

        /// <summary>
        /// Returns true if QuestionGroupScore instances are equal
        /// </summary>
        /// <param name="other">Instance of QuestionGroupScore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuestionGroupScore other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QuestionGroupId == other.QuestionGroupId ||
                    this.QuestionGroupId != null &&
                    this.QuestionGroupId.Equals(other.QuestionGroupId)
                ) &&
                (
                    this.TotalScore == other.TotalScore ||
                    this.TotalScore != null &&
                    this.TotalScore.Equals(other.TotalScore)
                ) &&
                (
                    this.MaxTotalScore == other.MaxTotalScore ||
                    this.MaxTotalScore != null &&
                    this.MaxTotalScore.Equals(other.MaxTotalScore)
                ) &&
                (
                    this.TotalCriticalScore == other.TotalCriticalScore ||
                    this.TotalCriticalScore != null &&
                    this.TotalCriticalScore.Equals(other.TotalCriticalScore)
                ) &&
                (
                    this.MaxTotalCriticalScore == other.MaxTotalCriticalScore ||
                    this.MaxTotalCriticalScore != null &&
                    this.MaxTotalCriticalScore.Equals(other.MaxTotalCriticalScore)
                ) &&
                (
                    this.TotalScoreUnweighted == other.TotalScoreUnweighted ||
                    this.TotalScoreUnweighted != null &&
                    this.TotalScoreUnweighted.Equals(other.TotalScoreUnweighted)
                ) &&
                (
                    this.MaxTotalScoreUnweighted == other.MaxTotalScoreUnweighted ||
                    this.MaxTotalScoreUnweighted != null &&
                    this.MaxTotalScoreUnweighted.Equals(other.MaxTotalScoreUnweighted)
                ) &&
                (
                    this.TotalCriticalScoreUnweighted == other.TotalCriticalScoreUnweighted ||
                    this.TotalCriticalScoreUnweighted != null &&
                    this.TotalCriticalScoreUnweighted.Equals(other.TotalCriticalScoreUnweighted)
                ) &&
                (
                    this.MaxTotalCriticalScoreUnweighted == other.MaxTotalCriticalScoreUnweighted ||
                    this.MaxTotalCriticalScoreUnweighted != null &&
                    this.MaxTotalCriticalScoreUnweighted.Equals(other.MaxTotalCriticalScoreUnweighted)
                ) &&
                (
                    this.MarkedNA == other.MarkedNA ||
                    this.MarkedNA != null &&
                    this.MarkedNA.Equals(other.MarkedNA)
                ) &&
                (
                    this.QuestionScores == other.QuestionScores ||
                    this.QuestionScores != null &&
                    this.QuestionScores.SequenceEqual(other.QuestionScores)
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
                
                if (this.QuestionGroupId != null)
                    hash = hash * 59 + this.QuestionGroupId.GetHashCode();
                
                if (this.TotalScore != null)
                    hash = hash * 59 + this.TotalScore.GetHashCode();
                
                if (this.MaxTotalScore != null)
                    hash = hash * 59 + this.MaxTotalScore.GetHashCode();
                
                if (this.TotalCriticalScore != null)
                    hash = hash * 59 + this.TotalCriticalScore.GetHashCode();
                
                if (this.MaxTotalCriticalScore != null)
                    hash = hash * 59 + this.MaxTotalCriticalScore.GetHashCode();
                
                if (this.TotalScoreUnweighted != null)
                    hash = hash * 59 + this.TotalScoreUnweighted.GetHashCode();
                
                if (this.MaxTotalScoreUnweighted != null)
                    hash = hash * 59 + this.MaxTotalScoreUnweighted.GetHashCode();
                
                if (this.TotalCriticalScoreUnweighted != null)
                    hash = hash * 59 + this.TotalCriticalScoreUnweighted.GetHashCode();
                
                if (this.MaxTotalCriticalScoreUnweighted != null)
                    hash = hash * 59 + this.MaxTotalCriticalScoreUnweighted.GetHashCode();
                
                if (this.MarkedNA != null)
                    hash = hash * 59 + this.MarkedNA.GetHashCode();
                
                if (this.QuestionScores != null)
                    hash = hash * 59 + this.QuestionScores.GetHashCode();
                
                return hash;
            }
        }

    }
}
