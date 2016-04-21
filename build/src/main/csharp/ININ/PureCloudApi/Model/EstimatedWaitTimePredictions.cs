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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/MetricThreshold.cs
    public partial class MetricThreshold :  IEquatable<MetricThreshold>
    { 

        /// <summary>
        /// Gets or Sets Op
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OpEnum {
            
            [EnumMember(Value = "GT")]
            Gt,
=======
    public partial class EstimatedWaitTimePredictions :  IEquatable<EstimatedWaitTimePredictions>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatedWaitTimePredictions" />class.
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/EstimatedWaitTimePredictions.cs
            
            [EnumMember(Value = "GE")]
            Ge,
            
            [EnumMember(Value = "LT")]
            Lt,
            
            [EnumMember(Value = "LE")]
            Le,
            
            [EnumMember(Value = "EQ")]
            Eq,
            
            [EnumMember(Value = "NE")]
            Ne
        }

<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/MetricThreshold.cs
        

=======
    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/EstimatedWaitTimePredictions.cs
        /// <summary>
        /// Returned upon a successful estimated wait time request.
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/MetricThreshold.cs
        [DataMember(Name="op", EmitDefaultValue=false)]
        public OpEnum? Op { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricThreshold" />class.
        /// </summary>
        /// <param name="Op">Op.</param>
        /// <param name="Value">Value.</param>

        public MetricThreshold(OpEnum? Op = null, double? Value = null)
        {
            this.Op = Op;
            this.Value = Value;
            
        }

    
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }
=======
        /// <value>Returned upon a successful estimated wait time request.</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<PredictionResults> Results { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/EstimatedWaitTimePredictions.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/MetricThreshold.cs
            sb.Append("class MetricThreshold {\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
=======
            sb.Append("class EstimatedWaitTimePredictions {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/EstimatedWaitTimePredictions.cs
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/MetricThreshold.cs
        /// <param name="other">Instance of MetricThreshold to be compared</param>
=======
        /// <param name="other">Instance of EstimatedWaitTimePredictions to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/EstimatedWaitTimePredictions.cs
        /// <returns>Boolean</returns>
        public bool Equals(EstimatedWaitTimePredictions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/MetricThreshold.cs
                (
                    this.Op == other.Op ||
                    this.Op != null &&
                    this.Op.Equals(other.Op)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/EstimatedWaitTimePredictions.cs
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/MetricThreshold.cs
                if (this.Op != null)
                    hash = hash * 59 + this.Op.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
=======
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/EstimatedWaitTimePredictions.cs
                return hash;
            }
        }

    }
}
