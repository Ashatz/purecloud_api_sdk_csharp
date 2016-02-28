using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class MediaPolicy :  IEquatable<MediaPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaPolicy" /> class.
        /// </summary>
        public MediaPolicy()
        {
            
        }

        
        /// <summary>
        /// When conditions are evaluation and actions applied
        /// </summary>
        /// <value>When conditions are evaluation and actions applied</value>
        [DataMember(Name="evaluationCriteria", EmitDefaultValue=false)]
        public List<string> EvaluationCriteria { get; set; }
  
        
        /// <summary>
        /// Conditions for when actions should be applied
        /// </summary>
        /// <value>Conditions for when actions should be applied</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public PolicyConditions Conditions { get; set; }
  
        
        /// <summary>
        /// Actions applied when specified conditions are met
        /// </summary>
        /// <value>Actions applied when specified conditions are met</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public PolicyActions Actions { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaPolicy {\n");
            sb.Append("  EvaluationCriteria: ").Append(EvaluationCriteria).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            
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
            return this.Equals(obj as MediaPolicy);
        }

        /// <summary>
        /// Returns true if MediaPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaPolicy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EvaluationCriteria == other.EvaluationCriteria ||
                    this.EvaluationCriteria != null &&
                    this.EvaluationCriteria.SequenceEqual(other.EvaluationCriteria)
                ) && 
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.Equals(other.Conditions)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.Equals(other.Actions)
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
                
                if (this.EvaluationCriteria != null)
                    hash = hash * 59 + this.EvaluationCriteria.GetHashCode();
                
                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();
                
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                
                return hash;
            }
        }

    }
}
