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
    public class DateTimeField :  IEquatable<DateTimeField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeField" /> class.
        /// </summary>
        public DateTimeField()
        {
            this.Lenient = false;
            this.Supported = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Lenient
        /// </summary>
        [DataMember(Name="lenient", EmitDefaultValue=false)]
        public bool? Lenient { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RangeDurationField
        /// </summary>
        [DataMember(Name="rangeDurationField", EmitDefaultValue=false)]
        public DurationField RangeDurationField { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LeapDurationField
        /// </summary>
        [DataMember(Name="leapDurationField", EmitDefaultValue=false)]
        public DurationField LeapDurationField { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MinimumValue
        /// </summary>
        [DataMember(Name="minimumValue", EmitDefaultValue=false)]
        public int? MinimumValue { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MaximumValue
        /// </summary>
        [DataMember(Name="maximumValue", EmitDefaultValue=false)]
        public int? MaximumValue { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DurationField
        /// </summary>
        [DataMember(Name="durationField", EmitDefaultValue=false)]
        public DurationField DurationField { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public DateTimeFieldType Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Supported
        /// </summary>
        [DataMember(Name="supported", EmitDefaultValue=false)]
        public bool? Supported { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateTimeField {\n");
            sb.Append("  Lenient: ").Append(Lenient).Append("\n");
            sb.Append("  RangeDurationField: ").Append(RangeDurationField).Append("\n");
            sb.Append("  LeapDurationField: ").Append(LeapDurationField).Append("\n");
            sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
            sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
            sb.Append("  DurationField: ").Append(DurationField).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Supported: ").Append(Supported).Append("\n");
            
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
            return this.Equals(obj as DateTimeField);
        }

        /// <summary>
        /// Returns true if DateTimeField instances are equal
        /// </summary>
        /// <param name="obj">Instance of DateTimeField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateTimeField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Lenient == other.Lenient ||
                    this.Lenient != null &&
                    this.Lenient.Equals(other.Lenient)
                ) && 
                (
                    this.RangeDurationField == other.RangeDurationField ||
                    this.RangeDurationField != null &&
                    this.RangeDurationField.Equals(other.RangeDurationField)
                ) && 
                (
                    this.LeapDurationField == other.LeapDurationField ||
                    this.LeapDurationField != null &&
                    this.LeapDurationField.Equals(other.LeapDurationField)
                ) && 
                (
                    this.MinimumValue == other.MinimumValue ||
                    this.MinimumValue != null &&
                    this.MinimumValue.Equals(other.MinimumValue)
                ) && 
                (
                    this.MaximumValue == other.MaximumValue ||
                    this.MaximumValue != null &&
                    this.MaximumValue.Equals(other.MaximumValue)
                ) && 
                (
                    this.DurationField == other.DurationField ||
                    this.DurationField != null &&
                    this.DurationField.Equals(other.DurationField)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Supported == other.Supported ||
                    this.Supported != null &&
                    this.Supported.Equals(other.Supported)
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
                
                if (this.Lenient != null)
                    hash = hash * 57 + this.Lenient.GetHashCode();
                
                if (this.RangeDurationField != null)
                    hash = hash * 57 + this.RangeDurationField.GetHashCode();
                
                if (this.LeapDurationField != null)
                    hash = hash * 57 + this.LeapDurationField.GetHashCode();
                
                if (this.MinimumValue != null)
                    hash = hash * 57 + this.MinimumValue.GetHashCode();
                
                if (this.MaximumValue != null)
                    hash = hash * 57 + this.MaximumValue.GetHashCode();
                
                if (this.DurationField != null)
                    hash = hash * 57 + this.DurationField.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.Supported != null)
                    hash = hash * 57 + this.Supported.GetHashCode();
                
                return hash;
            }
        }

    }


}
