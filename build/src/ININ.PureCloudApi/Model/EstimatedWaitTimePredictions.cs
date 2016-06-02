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
    /// EstimatedWaitTimePredictions
    /// </summary>
    [DataContract]
    public partial class EstimatedWaitTimePredictions :  IEquatable<EstimatedWaitTimePredictions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatedWaitTimePredictions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EstimatedWaitTimePredictions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatedWaitTimePredictions" /> class.
        /// </summary>
        /// <param name="Results">Returned upon a successful estimated wait time request. (required).</param>
        public EstimatedWaitTimePredictions(List<PredictionResults> Results = null)
        {
            // to ensure "Results" is required (not null)
            if (Results == null)
            {
                throw new InvalidDataException("Results is a required property for EstimatedWaitTimePredictions and cannot be null");
            }
            else
            {
                this.Results = Results;
            }
        }
        
        /// <summary>
        /// Returned upon a successful estimated wait time request.
        /// </summary>
        /// <value>Returned upon a successful estimated wait time request.</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<PredictionResults> Results { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstimatedWaitTimePredictions {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(obj as EstimatedWaitTimePredictions);
        }

        /// <summary>
        /// Returns true if EstimatedWaitTimePredictions instances are equal
        /// </summary>
        /// <param name="other">Instance of EstimatedWaitTimePredictions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimatedWaitTimePredictions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                return hash;
            }
        }
    }

}
