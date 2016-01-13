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
    public class DomainEdgeSoftwareUpdateDto :  IEquatable<DomainEdgeSoftwareUpdateDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainEdgeSoftwareUpdateDto" /> class.
        /// </summary>
        public DomainEdgeSoftwareUpdateDto()
        {
            this.ExecuteOnIdle = false;
            this.Current = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public DomainEdgeSoftwareVersionDto Version { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MaxDownloadRate
        /// </summary>
        [DataMember(Name="maxDownloadRate", EmitDefaultValue=false)]
        public int? MaxDownloadRate { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="downloadStartTime", EmitDefaultValue=false)]
        public DateTime? DownloadStartTime { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="executeStartTime", EmitDefaultValue=false)]
        public DateTime? ExecuteStartTime { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="executeStopTime", EmitDefaultValue=false)]
        public DateTime? ExecuteStopTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ExecuteOnIdle
        /// </summary>
        [DataMember(Name="executeOnIdle", EmitDefaultValue=false)]
        public bool? ExecuteOnIdle { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EdgeUri
        /// </summary>
        [DataMember(Name="edgeUri", EmitDefaultValue=false)]
        public string EdgeUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Current
        /// </summary>
        [DataMember(Name="current", EmitDefaultValue=false)]
        public bool? Current { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainEdgeSoftwareUpdateDto {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  MaxDownloadRate: ").Append(MaxDownloadRate).Append("\n");
            sb.Append("  DownloadStartTime: ").Append(DownloadStartTime).Append("\n");
            sb.Append("  ExecuteStartTime: ").Append(ExecuteStartTime).Append("\n");
            sb.Append("  ExecuteStopTime: ").Append(ExecuteStopTime).Append("\n");
            sb.Append("  ExecuteOnIdle: ").Append(ExecuteOnIdle).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EdgeUri: ").Append(EdgeUri).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            
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
            return this.Equals(obj as DomainEdgeSoftwareUpdateDto);
        }

        /// <summary>
        /// Returns true if DomainEdgeSoftwareUpdateDto instances are equal
        /// </summary>
        /// <param name="obj">Instance of DomainEdgeSoftwareUpdateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainEdgeSoftwareUpdateDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.MaxDownloadRate == other.MaxDownloadRate ||
                    this.MaxDownloadRate != null &&
                    this.MaxDownloadRate.Equals(other.MaxDownloadRate)
                ) && 
                (
                    this.DownloadStartTime == other.DownloadStartTime ||
                    this.DownloadStartTime != null &&
                    this.DownloadStartTime.Equals(other.DownloadStartTime)
                ) && 
                (
                    this.ExecuteStartTime == other.ExecuteStartTime ||
                    this.ExecuteStartTime != null &&
                    this.ExecuteStartTime.Equals(other.ExecuteStartTime)
                ) && 
                (
                    this.ExecuteStopTime == other.ExecuteStopTime ||
                    this.ExecuteStopTime != null &&
                    this.ExecuteStopTime.Equals(other.ExecuteStopTime)
                ) && 
                (
                    this.ExecuteOnIdle == other.ExecuteOnIdle ||
                    this.ExecuteOnIdle != null &&
                    this.ExecuteOnIdle.Equals(other.ExecuteOnIdle)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.EdgeUri == other.EdgeUri ||
                    this.EdgeUri != null &&
                    this.EdgeUri.Equals(other.EdgeUri)
                ) && 
                (
                    this.Current == other.Current ||
                    this.Current != null &&
                    this.Current.Equals(other.Current)
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
                
                if (this.Version != null)
                    hash = hash * 57 + this.Version.GetHashCode();
                
                if (this.MaxDownloadRate != null)
                    hash = hash * 57 + this.MaxDownloadRate.GetHashCode();
                
                if (this.DownloadStartTime != null)
                    hash = hash * 57 + this.DownloadStartTime.GetHashCode();
                
                if (this.ExecuteStartTime != null)
                    hash = hash * 57 + this.ExecuteStartTime.GetHashCode();
                
                if (this.ExecuteStopTime != null)
                    hash = hash * 57 + this.ExecuteStopTime.GetHashCode();
                
                if (this.ExecuteOnIdle != null)
                    hash = hash * 57 + this.ExecuteOnIdle.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.EdgeUri != null)
                    hash = hash * 57 + this.EdgeUri.GetHashCode();
                
                if (this.Current != null)
                    hash = hash * 57 + this.Current.GetHashCode();
                
                return hash;
            }
        }

    }


}
