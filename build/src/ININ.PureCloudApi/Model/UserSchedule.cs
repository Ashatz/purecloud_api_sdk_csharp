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
using ININ.PureCloudApi.Client;

namespace ININ.PureCloudApi.Model
{
    /// <summary>
    /// A schedule for a single user over a given time range
    /// </summary>
    [DataContract]
    public partial class UserSchedule :  IEquatable<UserSchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSchedule" /> class.
        /// </summary>
        /// <param name="Shifts">The shifts that belong to this schedule.</param>
        /// <param name="FullDayTimeOffMarkers">Markers to indicate a full day time off request, relative to the management unit time zone.</param>
        public UserSchedule(List<UserScheduleShift> Shifts = null, List<UserScheduleFullDayTimeOffMarker> FullDayTimeOffMarkers = null)
        {
            this.Shifts = Shifts;
            this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;
        }
        
        /// <summary>
        /// The shifts that belong to this schedule
        /// </summary>
        /// <value>The shifts that belong to this schedule</value>
        [DataMember(Name="shifts", EmitDefaultValue=false)]
        public List<UserScheduleShift> Shifts { get; set; }
        /// <summary>
        /// Markers to indicate a full day time off request, relative to the management unit time zone
        /// </summary>
        /// <value>Markers to indicate a full day time off request, relative to the management unit time zone</value>
        [DataMember(Name="fullDayTimeOffMarkers", EmitDefaultValue=false)]
        public List<UserScheduleFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSchedule {\n");
            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
            sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
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
            return this.Equals(obj as UserSchedule);
        }

        /// <summary>
        /// Returns true if UserSchedule instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSchedule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Shifts == other.Shifts ||
                    this.Shifts != null &&
                    this.Shifts.SequenceEqual(other.Shifts)
                ) &&
                (
                    this.FullDayTimeOffMarkers == other.FullDayTimeOffMarkers ||
                    this.FullDayTimeOffMarkers != null &&
                    this.FullDayTimeOffMarkers.SequenceEqual(other.FullDayTimeOffMarkers)
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
                if (this.Shifts != null)
                    hash = hash * 59 + this.Shifts.GetHashCode();
                if (this.FullDayTimeOffMarkers != null)
                    hash = hash * 59 + this.FullDayTimeOffMarkers.GetHashCode();
                return hash;
            }
        }
    }

}
