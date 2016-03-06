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
    public partial class RecordingConfiguration :  IEquatable<RecordingConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingConfiguration" /> class.
        /// </summary>
        public RecordingConfiguration()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets MaxSimultaneousStreams
        /// </summary>
        [DataMember(Name="maxSimultaneousStreams", EmitDefaultValue=false)]
        public int? MaxSimultaneousStreams { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingConfiguration {\n");
            sb.Append("  MaxSimultaneousStreams: ").Append(MaxSimultaneousStreams).Append("\n");
            
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
            return this.Equals(obj as RecordingConfiguration);
        }

        /// <summary>
        /// Returns true if RecordingConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MaxSimultaneousStreams == other.MaxSimultaneousStreams ||
                    this.MaxSimultaneousStreams != null &&
                    this.MaxSimultaneousStreams.Equals(other.MaxSimultaneousStreams)
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
                
                if (this.MaxSimultaneousStreams != null)
                    hash = hash * 59 + this.MaxSimultaneousStreams.GetHashCode();
                
                return hash;
            }
        }

    }
}
