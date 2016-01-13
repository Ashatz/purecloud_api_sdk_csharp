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
    public class ReportRunEntry :  IEquatable<ReportRunEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRunEntry" /> class.
        /// </summary>
        public ReportRunEntry()
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
        /// Gets or Sets ReportId
        /// </summary>
        [DataMember(Name="reportId", EmitDefaultValue=false)]
        public string ReportId { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="runTime", EmitDefaultValue=false)]
        public DateTime? RunTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RunStatus
        /// </summary>
        [DataMember(Name="runStatus", EmitDefaultValue=false)]
        public string RunStatus { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RunDurationMsec
        /// </summary>
        [DataMember(Name="runDurationMsec", EmitDefaultValue=false)]
        public long? RunDurationMsec { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ReportUrl
        /// </summary>
        [DataMember(Name="reportUrl", EmitDefaultValue=false)]
        public string ReportUrl { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ReportFormat
        /// </summary>
        [DataMember(Name="reportFormat", EmitDefaultValue=false)]
        public string ReportFormat { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ScheduleUri
        /// </summary>
        [DataMember(Name="scheduleUri", EmitDefaultValue=false)]
        public string ScheduleUri { get; set; }
  
        
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
            sb.Append("class ReportRunEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  RunTime: ").Append(RunTime).Append("\n");
            sb.Append("  RunStatus: ").Append(RunStatus).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  RunDurationMsec: ").Append(RunDurationMsec).Append("\n");
            sb.Append("  ReportUrl: ").Append(ReportUrl).Append("\n");
            sb.Append("  ReportFormat: ").Append(ReportFormat).Append("\n");
            sb.Append("  ScheduleUri: ").Append(ScheduleUri).Append("\n");
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
            return this.Equals(obj as ReportRunEntry);
        }

        /// <summary>
        /// Returns true if ReportRunEntry instances are equal
        /// </summary>
        /// <param name="obj">Instance of ReportRunEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportRunEntry other)
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
                    this.ReportId == other.ReportId ||
                    this.ReportId != null &&
                    this.ReportId.Equals(other.ReportId)
                ) && 
                (
                    this.RunTime == other.RunTime ||
                    this.RunTime != null &&
                    this.RunTime.Equals(other.RunTime)
                ) && 
                (
                    this.RunStatus == other.RunStatus ||
                    this.RunStatus != null &&
                    this.RunStatus.Equals(other.RunStatus)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    this.RunDurationMsec == other.RunDurationMsec ||
                    this.RunDurationMsec != null &&
                    this.RunDurationMsec.Equals(other.RunDurationMsec)
                ) && 
                (
                    this.ReportUrl == other.ReportUrl ||
                    this.ReportUrl != null &&
                    this.ReportUrl.Equals(other.ReportUrl)
                ) && 
                (
                    this.ReportFormat == other.ReportFormat ||
                    this.ReportFormat != null &&
                    this.ReportFormat.Equals(other.ReportFormat)
                ) && 
                (
                    this.ScheduleUri == other.ScheduleUri ||
                    this.ScheduleUri != null &&
                    this.ScheduleUri.Equals(other.ScheduleUri)
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
                
                if (this.ReportId != null)
                    hash = hash * 57 + this.ReportId.GetHashCode();
                
                if (this.RunTime != null)
                    hash = hash * 57 + this.RunTime.GetHashCode();
                
                if (this.RunStatus != null)
                    hash = hash * 57 + this.RunStatus.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 57 + this.ErrorMessage.GetHashCode();
                
                if (this.RunDurationMsec != null)
                    hash = hash * 57 + this.RunDurationMsec.GetHashCode();
                
                if (this.ReportUrl != null)
                    hash = hash * 57 + this.ReportUrl.GetHashCode();
                
                if (this.ReportFormat != null)
                    hash = hash * 57 + this.ReportFormat.GetHashCode();
                
                if (this.ScheduleUri != null)
                    hash = hash * 57 + this.ScheduleUri.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
