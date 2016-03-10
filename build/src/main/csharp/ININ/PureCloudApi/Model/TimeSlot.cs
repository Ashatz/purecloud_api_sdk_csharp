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
    public partial class TimeSlot :  IEquatable<TimeSlot>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlot" />class.
        /// </summary>
        /// <param name="StartTime">StartTime.</param>
        /// <param name="StopTime">StopTime.</param>
        /// <param name="Day">Day.</param>

        public TimeSlot(string StartTime = null, string StopTime = null, int? Day = null)
        {
            this.StartTime = StartTime;
            this.StopTime = StopTime;
            this.Day = Day;
            
        }
        
    
        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }
    
        /// <summary>
        /// Gets or Sets StopTime
        /// </summary>
        [DataMember(Name="stopTime", EmitDefaultValue=false)]
        public string StopTime { get; set; }
    
        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public int? Day { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSlot {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  StopTime: ").Append(StopTime).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            
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
            return this.Equals(obj as TimeSlot);
        }

        /// <summary>
        /// Returns true if TimeSlot instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeSlot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSlot other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.StopTime == other.StopTime ||
                    this.StopTime != null &&
                    this.StopTime.Equals(other.StopTime)
                ) &&
                (
                    this.Day == other.Day ||
                    this.Day != null &&
                    this.Day.Equals(other.Day)
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
                
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                
                if (this.StopTime != null)
                    hash = hash * 59 + this.StopTime.GetHashCode();
                
                if (this.Day != null)
                    hash = hash * 59 + this.Day.GetHashCode();
                
                return hash;
            }
        }

    }
}
