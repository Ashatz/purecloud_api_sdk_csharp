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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FlowActivateRequest.cs
    public partial class FlowActivateRequest :  IEquatable<FlowActivateRequest>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowActivateRequest" />class.
        /// </summary>
        /// <param name="Activated">Change the activated state of the flow definition.  True to activate the flow definition so it can be launched, false to disable the flow. (required) (default to false).</param>

        public FlowActivateRequest(bool? Activated = null)
        {
            // to ensure "Activated" is required (not null)
            if (Activated == null)
            {
                throw new InvalidDataException("Activated is a required property for FlowActivateRequest and cannot be null");
            }
            else
            {
                this.Activated = Activated;
            }
=======
    public partial class RecordingSettings :  IEquatable<RecordingSettings>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingSettings" />class.
        /// </summary>
        /// <param name="MaxSimultaneousStreams">MaxSimultaneousStreams.</param>

        public RecordingSettings(int? MaxSimultaneousStreams = null)
        {
            this.MaxSimultaneousStreams = MaxSimultaneousStreams;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/RecordingSettings.cs
            
        }

    
        /// <summary>
        /// Gets or Sets MaxSimultaneousStreams
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FlowActivateRequest.cs
        /// <value>Change the activated state of the flow definition.  True to activate the flow definition so it can be launched, false to disable the flow.</value>
        [DataMember(Name="activated", EmitDefaultValue=false)]
        public bool? Activated { get; set; }
=======
        [DataMember(Name="maxSimultaneousStreams", EmitDefaultValue=false)]
        public int? MaxSimultaneousStreams { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/RecordingSettings.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FlowActivateRequest.cs
            sb.Append("class FlowActivateRequest {\n");
            sb.Append("  Activated: ").Append(Activated).Append("\n");
=======
            sb.Append("class RecordingSettings {\n");
            sb.Append("  MaxSimultaneousStreams: ").Append(MaxSimultaneousStreams).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/RecordingSettings.cs
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
            return this.Equals(obj as RecordingSettings);
        }

        /// <summary>
        /// Returns true if RecordingSettings instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FlowActivateRequest.cs
        /// <param name="other">Instance of FlowActivateRequest to be compared</param>
=======
        /// <param name="other">Instance of RecordingSettings to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/RecordingSettings.cs
        /// <returns>Boolean</returns>
        public bool Equals(RecordingSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FlowActivateRequest.cs
                if (this.Activated != null)
                    hash = hash * 59 + this.Activated.GetHashCode();
=======
                if (this.MaxSimultaneousStreams != null)
                    hash = hash * 59 + this.MaxSimultaneousStreams.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/RecordingSettings.cs
                return hash;
            }
        }

    }
}
