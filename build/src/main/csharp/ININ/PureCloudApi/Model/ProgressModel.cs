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
    public partial class ProgressModel :  IEquatable<ProgressModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressModel" /> class.
        /// </summary>
        public ProgressModel()
        {
            
        }

        
        /// <summary>
        /// Human readable progress
        /// </summary>
        /// <value>Human readable progress</value>
        [DataMember(Name="phase", EmitDefaultValue=false)]
        public string Phase { get; set; }
  
        
        /// <summary>
        /// Number of iterations performed
        /// </summary>
        /// <value>Number of iterations performed</value>
        [DataMember(Name="iterationsDone", EmitDefaultValue=false)]
        public int? IterationsDone { get; set; }
  
        
        /// <summary>
        /// Approximate number of iterations to perform in this phase
        /// </summary>
        /// <value>Approximate number of iterations to perform in this phase</value>
        [DataMember(Name="iterationsInPhase", EmitDefaultValue=false)]
        public int? IterationsInPhase { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgressModel {\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  IterationsDone: ").Append(IterationsDone).Append("\n");
            sb.Append("  IterationsInPhase: ").Append(IterationsInPhase).Append("\n");
            
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
            return this.Equals(obj as ProgressModel);
        }

        /// <summary>
        /// Returns true if ProgressModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgressModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgressModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Phase == other.Phase ||
                    this.Phase != null &&
                    this.Phase.Equals(other.Phase)
                ) && 
                (
                    this.IterationsDone == other.IterationsDone ||
                    this.IterationsDone != null &&
                    this.IterationsDone.Equals(other.IterationsDone)
                ) && 
                (
                    this.IterationsInPhase == other.IterationsInPhase ||
                    this.IterationsInPhase != null &&
                    this.IterationsInPhase.Equals(other.IterationsInPhase)
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
                
                if (this.Phase != null)
                    hash = hash * 59 + this.Phase.GetHashCode();
                
                if (this.IterationsDone != null)
                    hash = hash * 59 + this.IterationsDone.GetHashCode();
                
                if (this.IterationsInPhase != null)
                    hash = hash * 59 + this.IterationsInPhase.GetHashCode();
                
                return hash;
            }
        }

    }
}
