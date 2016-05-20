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
    /// PolicyActions
    /// </summary>
    [DataContract]
    public partial class PolicyActions :  IEquatable<PolicyActions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyActions" /> class.
        /// </summary>
        /// <param name="RetainRecording">RetainRecording (default to false).</param>
        /// <param name="DeleteRecording">DeleteRecording (default to false).</param>
        /// <param name="AssignEvaluations">AssignEvaluations.</param>
        /// <param name="AssignMeteredEvaluations">AssignMeteredEvaluations.</param>
        /// <param name="AssignCalibrations">AssignCalibrations.</param>
        /// <param name="RetentionDuration">RetentionDuration.</param>
        /// <param name="InitiateScreenRecording">InitiateScreenRecording.</param>
        public PolicyActions(bool? RetainRecording = null, bool? DeleteRecording = null, List<EvaluationAssignment> AssignEvaluations = null, List<MeteredEvaluationAssignment> AssignMeteredEvaluations = null, List<CalibrationAssignment> AssignCalibrations = null, RetentionDuration RetentionDuration = null, InitiateScreenRecording InitiateScreenRecording = null)
        {
            // use default value if no "RetainRecording" provided
            if (RetainRecording == null)
            {
                this.RetainRecording = false;
            }
            else
            {
                this.RetainRecording = RetainRecording;
            }
            // use default value if no "DeleteRecording" provided
            if (DeleteRecording == null)
            {
                this.DeleteRecording = false;
            }
            else
            {
                this.DeleteRecording = DeleteRecording;
            }
            this.AssignEvaluations = AssignEvaluations;
            this.AssignMeteredEvaluations = AssignMeteredEvaluations;
            this.AssignCalibrations = AssignCalibrations;
            this.RetentionDuration = RetentionDuration;
            this.InitiateScreenRecording = InitiateScreenRecording;
        }
        
        /// <summary>
        /// Gets or Sets RetainRecording
        /// </summary>
        [DataMember(Name="retainRecording", EmitDefaultValue=false)]
        public bool? RetainRecording { get; set; }
        /// <summary>
        /// Gets or Sets DeleteRecording
        /// </summary>
        [DataMember(Name="deleteRecording", EmitDefaultValue=false)]
        public bool? DeleteRecording { get; set; }
        /// <summary>
        /// Gets or Sets AssignEvaluations
        /// </summary>
        [DataMember(Name="assignEvaluations", EmitDefaultValue=false)]
        public List<EvaluationAssignment> AssignEvaluations { get; set; }
        /// <summary>
        /// Gets or Sets AssignMeteredEvaluations
        /// </summary>
        [DataMember(Name="assignMeteredEvaluations", EmitDefaultValue=false)]
        public List<MeteredEvaluationAssignment> AssignMeteredEvaluations { get; set; }
        /// <summary>
        /// Gets or Sets AssignCalibrations
        /// </summary>
        [DataMember(Name="assignCalibrations", EmitDefaultValue=false)]
        public List<CalibrationAssignment> AssignCalibrations { get; set; }
        /// <summary>
        /// Gets or Sets RetentionDuration
        /// </summary>
        [DataMember(Name="retentionDuration", EmitDefaultValue=false)]
        public RetentionDuration RetentionDuration { get; set; }
        /// <summary>
        /// Gets or Sets InitiateScreenRecording
        /// </summary>
        [DataMember(Name="initiateScreenRecording", EmitDefaultValue=false)]
        public InitiateScreenRecording InitiateScreenRecording { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyActions {\n");
            sb.Append("  RetainRecording: ").Append(RetainRecording).Append("\n");
            sb.Append("  DeleteRecording: ").Append(DeleteRecording).Append("\n");
            sb.Append("  AssignEvaluations: ").Append(AssignEvaluations).Append("\n");
            sb.Append("  AssignMeteredEvaluations: ").Append(AssignMeteredEvaluations).Append("\n");
            sb.Append("  AssignCalibrations: ").Append(AssignCalibrations).Append("\n");
            sb.Append("  RetentionDuration: ").Append(RetentionDuration).Append("\n");
            sb.Append("  InitiateScreenRecording: ").Append(InitiateScreenRecording).Append("\n");
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
            return this.Equals(obj as PolicyActions);
        }

        /// <summary>
        /// Returns true if PolicyActions instances are equal
        /// </summary>
        /// <param name="other">Instance of PolicyActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyActions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RetainRecording == other.RetainRecording ||
                    this.RetainRecording != null &&
                    this.RetainRecording.Equals(other.RetainRecording)
                ) &&
                (
                    this.DeleteRecording == other.DeleteRecording ||
                    this.DeleteRecording != null &&
                    this.DeleteRecording.Equals(other.DeleteRecording)
                ) &&
                (
                    this.AssignEvaluations == other.AssignEvaluations ||
                    this.AssignEvaluations != null &&
                    this.AssignEvaluations.SequenceEqual(other.AssignEvaluations)
                ) &&
                (
                    this.AssignMeteredEvaluations == other.AssignMeteredEvaluations ||
                    this.AssignMeteredEvaluations != null &&
                    this.AssignMeteredEvaluations.SequenceEqual(other.AssignMeteredEvaluations)
                ) &&
                (
                    this.AssignCalibrations == other.AssignCalibrations ||
                    this.AssignCalibrations != null &&
                    this.AssignCalibrations.SequenceEqual(other.AssignCalibrations)
                ) &&
                (
                    this.RetentionDuration == other.RetentionDuration ||
                    this.RetentionDuration != null &&
                    this.RetentionDuration.Equals(other.RetentionDuration)
                ) &&
                (
                    this.InitiateScreenRecording == other.InitiateScreenRecording ||
                    this.InitiateScreenRecording != null &&
                    this.InitiateScreenRecording.Equals(other.InitiateScreenRecording)
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
                if (this.RetainRecording != null)
                    hash = hash * 59 + this.RetainRecording.GetHashCode();
                if (this.DeleteRecording != null)
                    hash = hash * 59 + this.DeleteRecording.GetHashCode();
                if (this.AssignEvaluations != null)
                    hash = hash * 59 + this.AssignEvaluations.GetHashCode();
                if (this.AssignMeteredEvaluations != null)
                    hash = hash * 59 + this.AssignMeteredEvaluations.GetHashCode();
                if (this.AssignCalibrations != null)
                    hash = hash * 59 + this.AssignCalibrations.GetHashCode();
                if (this.RetentionDuration != null)
                    hash = hash * 59 + this.RetentionDuration.GetHashCode();
                if (this.InitiateScreenRecording != null)
                    hash = hash * 59 + this.InitiateScreenRecording.GetHashCode();
                return hash;
            }
        }
    }

}
