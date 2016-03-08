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
    public partial class MediaResult :  IEquatable<MediaResult>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaResult" /> class.
        /// Initializes a new instance of the <see cref="MediaResult" />class.
        /// </summary>
        /// <param name="WaveUri">WaveUri.</param>
        /// <param name="MediaUri">MediaUri.</param>
        /// <param name="WaveformData">WaveformData.</param>

        public MediaResult(string WaveUri = null, string MediaUri = null, List<float?> WaveformData = null)
        {
            this.WaveUri = WaveUri;
            this.MediaUri = MediaUri;
            this.WaveformData = WaveformData;
            
        }
        
    
        /// <summary>
        /// Gets or Sets WaveUri
        /// </summary>
        [DataMember(Name="waveUri", EmitDefaultValue=false)]
        public string WaveUri { get; set; }
    
        /// <summary>
        /// Gets or Sets MediaUri
        /// </summary>
        [DataMember(Name="mediaUri", EmitDefaultValue=false)]
        public string MediaUri { get; set; }
    
        /// <summary>
        /// Gets or Sets WaveformData
        /// </summary>
        [DataMember(Name="waveformData", EmitDefaultValue=false)]
        public List<float?> WaveformData { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaResult {\n");
            sb.Append("  WaveUri: ").Append(WaveUri).Append("\n");
            sb.Append("  MediaUri: ").Append(MediaUri).Append("\n");
            sb.Append("  WaveformData: ").Append(WaveformData).Append("\n");
            
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
            return this.Equals(obj as MediaResult);
        }

        /// <summary>
        /// Returns true if MediaResult instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WaveUri == other.WaveUri ||
                    this.WaveUri != null &&
                    this.WaveUri.Equals(other.WaveUri)
                ) && 
                (
                    this.MediaUri == other.MediaUri ||
                    this.MediaUri != null &&
                    this.MediaUri.Equals(other.MediaUri)
                ) && 
                (
                    this.WaveformData == other.WaveformData ||
                    this.WaveformData != null &&
                    this.WaveformData.SequenceEqual(other.WaveformData)
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
                
                if (this.WaveUri != null)
                    hash = hash * 59 + this.WaveUri.GetHashCode();
                
                if (this.MediaUri != null)
                    hash = hash * 59 + this.MediaUri.GetHashCode();
                
                if (this.WaveformData != null)
                    hash = hash * 59 + this.WaveformData.GetHashCode();
                
                return hash;
            }
        }

    }
}
