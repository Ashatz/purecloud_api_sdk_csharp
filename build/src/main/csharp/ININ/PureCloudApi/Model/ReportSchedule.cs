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
    public class ReportSchedule :  IEquatable<ReportSchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportSchedule" /> class.
        /// </summary>
        public ReportSchedule()
        {
            this.Enabled = false;
            
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
        /// Gets or Sets QuartzCronExpression
        /// </summary>
        [DataMember(Name="quartzCronExpression", EmitDefaultValue=false)]
        public string QuartzCronExpression { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="nextFireTime", EmitDefaultValue=false)]
        public DateTime? NextFireTime { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TimePeriod
        /// </summary>
        [DataMember(Name="timePeriod", EmitDefaultValue=false)]
        public string TimePeriod { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public CampaignScheduleIntervals Interval { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ReportFormat
        /// </summary>
        [DataMember(Name="reportFormat", EmitDefaultValue=false)]
        public string ReportFormat { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ReportId
        /// </summary>
        [DataMember(Name="reportId", EmitDefaultValue=false)]
        public string ReportId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, LineProperties> Parameters { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LastRun
        /// </summary>
        [DataMember(Name="lastRun", EmitDefaultValue=false)]
        public ReportRunEntry LastRun { get; set; }
  
        
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
            sb.Append("class ReportSchedule {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  QuartzCronExpression: ").Append(QuartzCronExpression).Append("\n");
            sb.Append("  NextFireTime: ").Append(NextFireTime).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  TimePeriod: ").Append(TimePeriod).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  ReportFormat: ").Append(ReportFormat).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  LastRun: ").Append(LastRun).Append("\n");
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
            return this.Equals(obj as ReportSchedule);
        }

        /// <summary>
        /// Returns true if ReportSchedule instances are equal
        /// </summary>
        /// <param name="obj">Instance of ReportSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportSchedule other)
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
                    this.QuartzCronExpression == other.QuartzCronExpression ||
                    this.QuartzCronExpression != null &&
                    this.QuartzCronExpression.Equals(other.QuartzCronExpression)
                ) && 
                (
                    this.NextFireTime == other.NextFireTime ||
                    this.NextFireTime != null &&
                    this.NextFireTime.Equals(other.NextFireTime)
                ) && 
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) && 
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.TimePeriod == other.TimePeriod ||
                    this.TimePeriod != null &&
                    this.TimePeriod.Equals(other.TimePeriod)
                ) && 
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) && 
                (
                    this.ReportFormat == other.ReportFormat ||
                    this.ReportFormat != null &&
                    this.ReportFormat.Equals(other.ReportFormat)
                ) && 
                (
                    this.Locale == other.Locale ||
                    this.Locale != null &&
                    this.Locale.Equals(other.Locale)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.ReportId == other.ReportId ||
                    this.ReportId != null &&
                    this.ReportId.Equals(other.ReportId)
                ) && 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    this.LastRun == other.LastRun ||
                    this.LastRun != null &&
                    this.LastRun.Equals(other.LastRun)
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
                
                if (this.QuartzCronExpression != null)
                    hash = hash * 57 + this.QuartzCronExpression.GetHashCode();
                
                if (this.NextFireTime != null)
                    hash = hash * 57 + this.NextFireTime.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 57 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 57 + this.DateModified.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 57 + this.Description.GetHashCode();
                
                if (this.TimeZone != null)
                    hash = hash * 57 + this.TimeZone.GetHashCode();
                
                if (this.TimePeriod != null)
                    hash = hash * 57 + this.TimePeriod.GetHashCode();
                
                if (this.Interval != null)
                    hash = hash * 57 + this.Interval.GetHashCode();
                
                if (this.ReportFormat != null)
                    hash = hash * 57 + this.ReportFormat.GetHashCode();
                
                if (this.Locale != null)
                    hash = hash * 57 + this.Locale.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 57 + this.Enabled.GetHashCode();
                
                if (this.ReportId != null)
                    hash = hash * 57 + this.ReportId.GetHashCode();
                
                if (this.Parameters != null)
                    hash = hash * 57 + this.Parameters.GetHashCode();
                
                if (this.LastRun != null)
                    hash = hash * 57 + this.LastRun.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
