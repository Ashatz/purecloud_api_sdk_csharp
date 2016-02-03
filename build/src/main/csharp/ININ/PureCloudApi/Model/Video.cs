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
    public class Video :  IEquatable<Video>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Video" /> class.
        /// </summary>
        public Video()
        {
            this.AudioMuted = false;
            this.VideoMuted = false;
            this.SharingScreen = false;
            
        }

        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AudioMuted
        /// </summary>
        [DataMember(Name="audioMuted", EmitDefaultValue=false)]
        public bool? AudioMuted { get; set; }
  
        
        /// <summary>
        /// Gets or Sets VideoMuted
        /// </summary>
        [DataMember(Name="videoMuted", EmitDefaultValue=false)]
        public bool? VideoMuted { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SharingScreen
        /// </summary>
        [DataMember(Name="sharingScreen", EmitDefaultValue=false)]
        public bool? SharingScreen { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PeerCount
        /// </summary>
        [DataMember(Name="peerCount", EmitDefaultValue=false)]
        public int? PeerCount { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public string DisconnectType { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Video {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  AudioMuted: ").Append(AudioMuted).Append("\n");
            sb.Append("  VideoMuted: ").Append(VideoMuted).Append("\n");
            sb.Append("  SharingScreen: ").Append(SharingScreen).Append("\n");
            sb.Append("  PeerCount: ").Append(PeerCount).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            
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
            return this.Equals(obj as Video);
        }

        /// <summary>
        /// Returns true if Video instances are equal
        /// </summary>
        /// <param name="obj">Instance of Video to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Video other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
                ) && 
                (
                    this.AudioMuted == other.AudioMuted ||
                    this.AudioMuted != null &&
                    this.AudioMuted.Equals(other.AudioMuted)
                ) && 
                (
                    this.VideoMuted == other.VideoMuted ||
                    this.VideoMuted != null &&
                    this.VideoMuted.Equals(other.VideoMuted)
                ) && 
                (
                    this.SharingScreen == other.SharingScreen ||
                    this.SharingScreen != null &&
                    this.SharingScreen.Equals(other.SharingScreen)
                ) && 
                (
                    this.PeerCount == other.PeerCount ||
                    this.PeerCount != null &&
                    this.PeerCount.Equals(other.PeerCount)
                ) && 
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
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
                
                if (this.State != null)
                    hash = hash * 57 + this.State.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Context != null)
                    hash = hash * 57 + this.Context.GetHashCode();
                
                if (this.AudioMuted != null)
                    hash = hash * 57 + this.AudioMuted.GetHashCode();
                
                if (this.VideoMuted != null)
                    hash = hash * 57 + this.VideoMuted.GetHashCode();
                
                if (this.SharingScreen != null)
                    hash = hash * 57 + this.SharingScreen.GetHashCode();
                
                if (this.PeerCount != null)
                    hash = hash * 57 + this.PeerCount.GetHashCode();
                
                if (this.DisconnectType != null)
                    hash = hash * 57 + this.DisconnectType.GetHashCode();
                
                return hash;
            }
        }

    }


}
