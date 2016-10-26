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
    /// ForecastDimensions
    /// </summary>
    [DataContract]
    public partial class ForecastDimensions :  IEquatable<ForecastDimensions>
    {
        /// <summary>
        /// The media of the forecast
        /// </summary>
        /// <value>The media of the forecast</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MediaEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "VOICE"
            /// </summary>
            [EnumMember(Value = "VOICE")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "CHAT"
            /// </summary>
            [EnumMember(Value = "CHAT")]
            Chat,
            
            /// <summary>
            /// Enum Email for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            Email
        }
        /// <summary>
        /// The media of the forecast
        /// </summary>
        /// <value>The media of the forecast</value>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public MediaEnum? Media { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastDimensions" /> class.
        /// </summary>
        /// <param name="Language">The language of the forecast.</param>
        /// <param name="Queue">The queue of the forecast.</param>
        public ForecastDimensions(Language Language = null, Queue Queue = null)
        {
            this.Language = Language;
            this.Queue = Queue;
        }
        
        /// <summary>
        /// The language of the forecast
        /// </summary>
        /// <value>The language of the forecast</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public Language Language { get; set; }
        /// <summary>
        /// The queue of the forecast
        /// </summary>
        /// <value>The queue of the forecast</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public Queue Queue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastDimensions {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
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
            return this.Equals(obj as ForecastDimensions);
        }

        /// <summary>
        /// Returns true if ForecastDimensions instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastDimensions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastDimensions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.Equals(other.Media)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
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
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                return hash;
            }
        }
    }

}
