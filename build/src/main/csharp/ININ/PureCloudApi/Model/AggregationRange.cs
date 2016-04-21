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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerPlaceCallCommand.cs
    public partial class DialerPlaceCallCommand :  IEquatable<DialerPlaceCallCommand>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerPlaceCallCommand" />class.
        /// </summary>
        /// <param name="CallId">CallId.</param>
        /// <param name="PhoneNumber">PhoneNumber.</param>

        public DialerPlaceCallCommand(string CallId = null, string PhoneNumber = null)
        {
            this.CallId = CallId;
            this.PhoneNumber = PhoneNumber;
=======
    public partial class AggregationRange :  IEquatable<AggregationRange>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationRange" />class.
        /// </summary>
        /// <param name="Gte">Greater than or equal to.</param>
        /// <param name="Lt">Less than.</param>

        public AggregationRange(double? Gte = null, double? Lt = null)
        {
            this.Gte = Gte;
            this.Lt = Lt;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AggregationRange.cs
            
        }

    
        /// <summary>
        /// Greater than or equal to
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerPlaceCallCommand.cs
        [DataMember(Name="callId", EmitDefaultValue=false)]
        public string CallId { get; set; }
=======
        /// <value>Greater than or equal to</value>
        [DataMember(Name="gte", EmitDefaultValue=false)]
        public double? Gte { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AggregationRange.cs
    
        /// <summary>
        /// Less than
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerPlaceCallCommand.cs
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
=======
        /// <value>Less than</value>
        [DataMember(Name="lt", EmitDefaultValue=false)]
        public double? Lt { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AggregationRange.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerPlaceCallCommand.cs
            sb.Append("class DialerPlaceCallCommand {\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
=======
            sb.Append("class AggregationRange {\n");
            sb.Append("  Gte: ").Append(Gte).Append("\n");
            sb.Append("  Lt: ").Append(Lt).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AggregationRange.cs
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
            return this.Equals(obj as AggregationRange);
        }

        /// <summary>
        /// Returns true if AggregationRange instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerPlaceCallCommand.cs
        /// <param name="other">Instance of DialerPlaceCallCommand to be compared</param>
=======
        /// <param name="other">Instance of AggregationRange to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AggregationRange.cs
        /// <returns>Boolean</returns>
        public bool Equals(AggregationRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerPlaceCallCommand.cs
                    this.CallId == other.CallId ||
                    this.CallId != null &&
                    this.CallId.Equals(other.CallId)
=======
                    this.Gte == other.Gte ||
                    this.Gte != null &&
                    this.Gte.Equals(other.Gte)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AggregationRange.cs
                ) &&
                (
                    this.Lt == other.Lt ||
                    this.Lt != null &&
                    this.Lt.Equals(other.Lt)
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerPlaceCallCommand.cs
                if (this.CallId != null)
                    hash = hash * 59 + this.CallId.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
=======
                if (this.Gte != null)
                    hash = hash * 59 + this.Gte.GetHashCode();
                if (this.Lt != null)
                    hash = hash * 59 + this.Lt.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/AggregationRange.cs
                return hash;
            }
        }

    }
}
