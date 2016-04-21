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
    public partial class EdgeLogsJobFile :  IEquatable<EdgeLogsJobFile>
    { 

        /// <summary>
        /// The status of the upload of this file from the Edge to the cloud.  Use /upload to start an upload.
        /// </summary>
        /// <value>The status of the upload of this file from the Edge to the cloud.  Use /upload to start an upload.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UploadStatusEnum {
            
            [EnumMember(Value = "UPLOADING")]
            Uploading,
            
            [EnumMember(Value = "NOT_UPLOADED")]
            NotUploaded,
            
            [EnumMember(Value = "UPLOADED")]
            Uploaded,
            
            [EnumMember(Value = "ERROR_ON_UPLOAD")]
            ErrorOnUpload
        }

        
        /// <summary>
        /// The status of the upload of this file from the Edge to the cloud.  Use /upload to start an upload.
        /// </summary>
        /// <value>The status of the upload of this file from the Edge to the cloud.  Use /upload to start an upload.</value>
        [DataMember(Name="uploadStatus", EmitDefaultValue=false)]
        public UploadStatusEnum? UploadStatus { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeLogsJobFile" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="TimeCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="TimeModified">The time this log file was last modified on the Edge. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="SizeBytes">The size of this file in bytes..</param>
        /// <param name="UploadStatus">The status of the upload of this file from the Edge to the cloud.  Use /upload to start an upload..</param>
        /// <param name="EdgePath">The path of this file on the Edge..</param>
        /// <param name="DownloadId">The download ID to use with the downloads API..</param>

        public EdgeLogsJobFile(string Name = null, DateTime? TimeCreated = null, DateTime? TimeModified = null, double? SizeBytes = null, UploadStatusEnum? UploadStatus = null, string EdgePath = null, string DownloadId = null)
        {
            this.Name = Name;
            this.TimeCreated = TimeCreated;
            this.TimeModified = TimeModified;
            this.SizeBytes = SizeBytes;
            this.UploadStatus = UploadStatus;
            this.EdgePath = EdgePath;
            this.DownloadId = DownloadId;
            
        }

    
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="timeCreated", EmitDefaultValue=false)]
        public DateTime? TimeCreated { get; set; }
    
        /// <summary>
        /// The time this log file was last modified on the Edge. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time this log file was last modified on the Edge. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="timeModified", EmitDefaultValue=false)]
        public DateTime? TimeModified { get; set; }
    
        /// <summary>
        /// The size of this file in bytes.
        /// </summary>
        /// <value>The size of this file in bytes.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=false)]
        public double? SizeBytes { get; set; }
    
        /// <summary>
        /// The path of this file on the Edge.
        /// </summary>
        /// <value>The path of this file on the Edge.</value>
        [DataMember(Name="edgePath", EmitDefaultValue=false)]
        public string EdgePath { get; set; }
    
        /// <summary>
        /// The download ID to use with the downloads API.
        /// </summary>
        /// <value>The download ID to use with the downloads API.</value>
        [DataMember(Name="downloadId", EmitDefaultValue=false)]
        public string DownloadId { get; set; }
    
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeLogsJobFile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TimeCreated: ").Append(TimeCreated).Append("\n");
            sb.Append("  TimeModified: ").Append(TimeModified).Append("\n");
            sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
            sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
            sb.Append("  EdgePath: ").Append(EdgePath).Append("\n");
            sb.Append("  DownloadId: ").Append(DownloadId).Append("\n");
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

            return true &&
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
                    this.UploadStatus == other.UploadStatus ||
                    this.UploadStatus != null &&
                    this.UploadStatus.Equals(other.UploadStatus)
                ) &&
                (
                    this.EdgePath == other.EdgePath ||
                    this.EdgePath != null &&
                    this.EdgePath.Equals(other.EdgePath)
                ) &&
                (
                    this.DownloadId == other.DownloadId ||
                    this.DownloadId != null &&
                    this.DownloadId.Equals(other.DownloadId)
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
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.TimeCreated != null)
                    hash = hash * 59 + this.TimeCreated.GetHashCode();
                if (this.TimeModified != null)
                    hash = hash * 59 + this.TimeModified.GetHashCode();
                if (this.SizeBytes != null)
                    hash = hash * 59 + this.SizeBytes.GetHashCode();
                if (this.UploadStatus != null)
                    hash = hash * 59 + this.UploadStatus.GetHashCode();
                if (this.EdgePath != null)
                    hash = hash * 59 + this.EdgePath.GetHashCode();
                if (this.DownloadId != null)
                    hash = hash * 59 + this.DownloadId.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
