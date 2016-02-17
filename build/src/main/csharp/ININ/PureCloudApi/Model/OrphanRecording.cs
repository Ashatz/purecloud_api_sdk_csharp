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
    public class OrphanRecording :  IEquatable<OrphanRecording>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrphanRecording" /> class.
        /// </summary>
        public OrphanRecording()
        {
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdTime", EmitDefaultValue=false)]
        public DateTime? CreatedTime { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="recoveredTime", EmitDefaultValue=false)]
        public DateTime? RecoveredTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ProviderType
        /// </summary>
        [DataMember(Name="providerType", EmitDefaultValue=false)]
        public string ProviderType { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MediaSizeBytes
        /// </summary>
        [DataMember(Name="mediaSizeBytes", EmitDefaultValue=false)]
        public long? MediaSizeBytes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public string MediaType { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FileState
        /// </summary>
        [DataMember(Name="fileState", EmitDefaultValue=false)]
        public string FileState { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ProviderEndpoint
        /// </summary>
        [DataMember(Name="providerEndpoint", EmitDefaultValue=false)]
        public Endpoint ProviderEndpoint { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Recording
        /// </summary>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public Recording Recording { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrphanRecording {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  RecoveredTime: ").Append(RecoveredTime).Append("\n");
            sb.Append("  ProviderType: ").Append(ProviderType).Append("\n");
            sb.Append("  MediaSizeBytes: ").Append(MediaSizeBytes).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  FileState: ").Append(FileState).Append("\n");
            sb.Append("  ProviderEndpoint: ").Append(ProviderEndpoint).Append("\n");
            sb.Append("  Recording: ").Append(Recording).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            
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
            return this.Equals(obj as OrphanRecording);
        }

        /// <summary>
        /// Returns true if OrphanRecording instances are equal
        /// </summary>
        /// <param name="obj">Instance of OrphanRecording to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrphanRecording other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.CreatedTime == other.CreatedTime ||
                    this.CreatedTime != null &&
                    this.CreatedTime.Equals(other.CreatedTime)
                ) && 
                (
                    this.RecoveredTime == other.RecoveredTime ||
                    this.RecoveredTime != null &&
                    this.RecoveredTime.Equals(other.RecoveredTime)
                ) && 
                (
                    this.ProviderType == other.ProviderType ||
                    this.ProviderType != null &&
                    this.ProviderType.Equals(other.ProviderType)
                ) && 
                (
                    this.MediaSizeBytes == other.MediaSizeBytes ||
                    this.MediaSizeBytes != null &&
                    this.MediaSizeBytes.Equals(other.MediaSizeBytes)
                ) && 
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) && 
                (
                    this.FileState == other.FileState ||
                    this.FileState != null &&
                    this.FileState.Equals(other.FileState)
                ) && 
                (
                    this.ProviderEndpoint == other.ProviderEndpoint ||
                    this.ProviderEndpoint != null &&
                    this.ProviderEndpoint.Equals(other.ProviderEndpoint)
                ) && 
                (
                    this.Recording == other.Recording ||
                    this.Recording != null &&
                    this.Recording.Equals(other.Recording)
                ) && 
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.CreatedTime != null)
                    hash = hash * 57 + this.CreatedTime.GetHashCode();
                
                if (this.RecoveredTime != null)
                    hash = hash * 57 + this.RecoveredTime.GetHashCode();
                
                if (this.ProviderType != null)
                    hash = hash * 57 + this.ProviderType.GetHashCode();
                
                if (this.MediaSizeBytes != null)
                    hash = hash * 57 + this.MediaSizeBytes.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 57 + this.MediaType.GetHashCode();
                
                if (this.FileState != null)
                    hash = hash * 57 + this.FileState.GetHashCode();
                
                if (this.ProviderEndpoint != null)
                    hash = hash * 57 + this.ProviderEndpoint.GetHashCode();
                
                if (this.Recording != null)
                    hash = hash * 57 + this.Recording.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
