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
    /// PredictionResults
    /// </summary>
    [DataContract]
    public partial class PredictionResults :  IEquatable<PredictionResults>
    {
        /// <summary>
        /// Indicates the estimated wait time Formula
        /// </summary>
        /// <value>Indicates the estimated wait time Formula</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormulaEnum
        {
            
            /// <summary>
            /// Enum Best for "BEST"
            /// </summary>
            [EnumMember(Value = "BEST")]
            Best,
            
            /// <summary>
            /// Enum Simple for "SIMPLE"
            /// </summary>
            [EnumMember(Value = "SIMPLE")]
            Simple,
            
            /// <summary>
            /// Enum Abandon for "ABANDON"
            /// </summary>
            [EnumMember(Value = "ABANDON")]
            Abandon,
            
            /// <summary>
            /// Enum Patienceabandon for "PATIENCEABANDON"
            /// </summary>
            [EnumMember(Value = "PATIENCEABANDON")]
            Patienceabandon
        }

        /// <summary>
        /// Indicates the estimated wait time Formula
        /// </summary>
        /// <value>Indicates the estimated wait time Formula</value>
        [DataMember(Name="formula", EmitDefaultValue=false)]
        public FormulaEnum? Formula { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionResults" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PredictionResults() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionResults" /> class.
        /// </summary>
        /// <param name="Formula">Indicates the estimated wait time Formula (required).</param>
        /// <param name="EstimatedWaitTimeSeconds">Estimated wait time in seconds (required).</param>
        public PredictionResults(FormulaEnum? Formula = null, int? EstimatedWaitTimeSeconds = null)
        {
            // to ensure "Formula" is required (not null)
            if (Formula == null)
            {
                throw new InvalidDataException("Formula is a required property for PredictionResults and cannot be null");
            }
            else
            {
                this.Formula = Formula;
            }
            // to ensure "EstimatedWaitTimeSeconds" is required (not null)
            if (EstimatedWaitTimeSeconds == null)
            {
                throw new InvalidDataException("EstimatedWaitTimeSeconds is a required property for PredictionResults and cannot be null");
            }
            else
            {
                this.EstimatedWaitTimeSeconds = EstimatedWaitTimeSeconds;
            }
        }
        
        /// <summary>
        /// Estimated wait time in seconds
        /// </summary>
        /// <value>Estimated wait time in seconds</value>
        [DataMember(Name="estimatedWaitTimeSeconds", EmitDefaultValue=false)]
        public int? EstimatedWaitTimeSeconds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PredictionResults {\n");
            sb.Append("  Formula: ").Append(Formula).Append("\n");
            sb.Append("  EstimatedWaitTimeSeconds: ").Append(EstimatedWaitTimeSeconds).Append("\n");
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
            return this.Equals(obj as PredictionResults);
        }

        /// <summary>
        /// Returns true if PredictionResults instances are equal
        /// </summary>
        /// <param name="other">Instance of PredictionResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PredictionResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Formula == other.Formula ||
                    this.Formula != null &&
                    this.Formula.Equals(other.Formula)
                ) &&
                (
                    this.EstimatedWaitTimeSeconds == other.EstimatedWaitTimeSeconds ||
                    this.EstimatedWaitTimeSeconds != null &&
                    this.EstimatedWaitTimeSeconds.Equals(other.EstimatedWaitTimeSeconds)
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
                if (this.Formula != null)
                    hash = hash * 59 + this.Formula.GetHashCode();
                if (this.EstimatedWaitTimeSeconds != null)
                    hash = hash * 59 + this.EstimatedWaitTimeSeconds.GetHashCode();
                return hash;
            }
        }
    }

}
