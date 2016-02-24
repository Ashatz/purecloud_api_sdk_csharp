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
    public partial class EdgeLogsJobFile :  IEquatable<EdgeLogsJobFile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeLogsJobFile" /> class.
        /// </summary>
        public EdgeLogsJobFile()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="timeCreated", EmitDefaultValue=false)]
        public DateTime? TimeCreated { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="timeModified", EmitDefaultValue=false)]
        public DateTime? TimeModified { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SizeBytes
        /// </summary>
        [DataMember(Name="sizeBytes", EmitDefaultValue=false)]
        public double? SizeBytes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }
  
        
        /// <summary>
        /// Gets or Sets UploadStatus
        /// </summary>
        [DataMember(Name="uploadStatus", EmitDefaultValue=false)]
        public string UploadStatus { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EdgePath
        /// </summary>
        [DataMember(Name="edgePath", EmitDefaultValue=false)]
        public string EdgePath { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeLogsJobFile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TimeCreated: ").Append(TimeCreated).Append("\n");
            sb.Append("  TimeModified: ").Append(TimeModified).Append("\n");
            sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
            sb.Append("  EdgePath: ").Append(EdgePath).Append("\n");
            
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
            return this.Equals(obj as EdgeLogsJobFile);
        }

        /// <summary>
        /// Returns true if EdgeLogsJobFile instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeLogsJobFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeLogsJobFile other)
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
                    this.TimeCreated == other.TimeCreated ||
                    this.TimeCreated != null &&
                    this.TimeCreated.Equals(other.TimeCreated)
                ) && 
                (
                    this.TimeModified == other.TimeModified ||
                    this.TimeModified != null &&
                    this.TimeModified.Equals(other.TimeModified)
                ) && 
                (
                    this.SizeBytes == other.SizeBytes ||
                    this.SizeBytes != null &&
                    this.SizeBytes.Equals(other.SizeBytes)
                ) && 
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) && 
                (
                    this.UploadStatus == other.UploadStatus ||
                    this.UploadStatus != null &&
                    this.UploadStatus.Equals(other.UploadStatus)
                ) && 
                (
                    this.EdgePath == other.EdgePath ||
                    this.EdgePath != null &&
                    this.EdgePath.Equals(other.EdgePath)
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
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.TimeCreated != null)
                    hash = hash * 59 + this.TimeCreated.GetHashCode();
                
                if (this.TimeModified != null)
                    hash = hash * 59 + this.TimeModified.GetHashCode();
                
                if (this.SizeBytes != null)
                    hash = hash * 59 + this.SizeBytes.GetHashCode();
                
                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();
                
                if (this.UploadStatus != null)
                    hash = hash * 59 + this.UploadStatus.GetHashCode();
                
                if (this.EdgePath != null)
                    hash = hash * 59 + this.EdgePath.GetHashCode();
                
                return hash;
            }
        }

    }
}
