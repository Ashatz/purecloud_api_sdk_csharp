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
    public partial class PutManagementUnit :  IEquatable<PutManagementUnit>
    { 

        /// <summary>
        /// Gets or Sets StartDayOfWeek
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StartDayOfWeekEnum {
            
            [EnumMember(Value = "MONDAY")]
            Monday,
            
            [EnumMember(Value = "TUESDAY")]
            Tuesday,
            
            [EnumMember(Value = "WEDNESDAY")]
            Wednesday,
            
            [EnumMember(Value = "THURSDAY")]
            Thursday,
            
            [EnumMember(Value = "FRIDAY")]
            Friday,
            
            [EnumMember(Value = "SATURDAY")]
            Saturday,
            
            [EnumMember(Value = "SUNDAY")]
            Sunday
        }

        

        /// <summary>
        /// Gets or Sets StartDayOfWeek
        /// </summary>
        [DataMember(Name="startDayOfWeek", EmitDefaultValue=false)]
        public StartDayOfWeekEnum? StartDayOfWeek { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PutManagementUnit" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="StartDayOfWeek">StartDayOfWeek.</param>
        /// <param name="Timezone">Timezone.</param>

        public PutManagementUnit(string Name = null, StartDayOfWeekEnum? StartDayOfWeek = null, string Timezone = null)
        {
            this.Name = Name;
            this.StartDayOfWeek = StartDayOfWeek;
            this.Timezone = Timezone;
            
        }

    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutManagementUnit {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(obj as PutManagementUnit);
        }

        /// <summary>
        /// Returns true if PutManagementUnit instances are equal
        /// </summary>
        /// <param name="other">Instance of PutManagementUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PutManagementUnit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.StartDayOfWeek == other.StartDayOfWeek ||
                    this.StartDayOfWeek != null &&
                    this.StartDayOfWeek.Equals(other.StartDayOfWeek)
                ) &&
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.StartDayOfWeek != null)
                    hash = hash * 59 + this.StartDayOfWeek.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                return hash;
            }
        }

    }
}
