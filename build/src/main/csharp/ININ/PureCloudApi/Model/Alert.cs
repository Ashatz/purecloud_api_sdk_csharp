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
    public partial class Alert :  IEquatable<Alert>
    { 

        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum MediaTypeEnum {
            
            [EnumMember(Value = "VOICE")]
            Voice,
            
            [EnumMember(Value = "CHAT")]
            Chat
        }


        /// <summary>
        /// Gets or Sets Statistic
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatisticEnum {
            
            [EnumMember(Value = "COUNT")]
            Count,
            
            [EnumMember(Value = "SUM")]
            Sum,
            
            [EnumMember(Value = "AVG")]
            Avg,
            
            [EnumMember(Value = "RATIO")]
            Ratio
        }

        

        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
    

        /// <summary>
        /// Gets or Sets Statistic
        /// </summary>
        [DataMember(Name="statistic", EmitDefaultValue=false)]
        public StatisticEnum? Statistic { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Alert" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Unread">Unread (default to false).</param>
        /// <param name="Entity">Entity.</param>
        /// <param name="Metric">Metric.</param>
        /// <param name="MetricThresholds">MetricThresholds.</param>
        /// <param name="MetricValue">MetricValue.</param>
        /// <param name="StartTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="EndTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="Statistic">Statistic.</param>
        /// <param name="RuleUri">RuleUri.</param>

        public Alert(string Name = null, string Title = null, string Description = null, bool? Unread = null, Entity Entity = null, string Metric = null, List<MetricThreshold> MetricThresholds = null, double? MetricValue = null, DateTime? StartTime = null, DateTime? EndTime = null, MediaTypeEnum? MediaType = null, StatisticEnum? Statistic = null, string RuleUri = null)
        {
            this.Name = Name;
            this.Title = Title;
            this.Description = Description;
            // use default value if no "Unread" provided
            if (Unread == null)
            {
                this.Unread = false;
            }
            else
            {
                this.Unread = Unread;
            }
            this.Entity = Entity;
            this.Metric = Metric;
            this.MetricThresholds = MetricThresholds;
            this.MetricValue = MetricValue;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.MediaType = MediaType;
            this.Statistic = Statistic;
            this.RuleUri = RuleUri;
            
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
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets Unread
        /// </summary>
        [DataMember(Name="unread", EmitDefaultValue=false)]
        public bool? Unread { get; set; }
    
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public Entity Entity { get; set; }
    
        /// <summary>
        /// Gets or Sets Metric
        /// </summary>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public string Metric { get; set; }
    
        /// <summary>
        /// Gets or Sets MetricThresholds
        /// </summary>
        [DataMember(Name="metricThresholds", EmitDefaultValue=false)]
        public List<MetricThreshold> MetricThresholds { get; set; }
    
        /// <summary>
        /// Gets or Sets MetricValue
        /// </summary>
        [DataMember(Name="metricValue", EmitDefaultValue=false)]
        public double? MetricValue { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }
    
        /// <summary>
        /// Gets or Sets RuleUri
        /// </summary>
        [DataMember(Name="ruleUri", EmitDefaultValue=false)]
        public string RuleUri { get; set; }
    
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
            sb.Append("class Alert {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Unread: ").Append(Unread).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  MetricThresholds: ").Append(MetricThresholds).Append("\n");
            sb.Append("  MetricValue: ").Append(MetricValue).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Statistic: ").Append(Statistic).Append("\n");
            sb.Append("  RuleUri: ").Append(RuleUri).Append("\n");
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
            return this.Equals(obj as Alert);
        }

        /// <summary>
        /// Returns true if Alert instances are equal
        /// </summary>
        /// <param name="other">Instance of Alert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Alert other)
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
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Unread == other.Unread ||
                    this.Unread != null &&
                    this.Unread.Equals(other.Unread)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.MetricThresholds == other.MetricThresholds ||
                    this.MetricThresholds != null &&
                    this.MetricThresholds.SequenceEqual(other.MetricThresholds)
                ) &&
                (
                    this.MetricValue == other.MetricValue ||
                    this.MetricValue != null &&
                    this.MetricValue.Equals(other.MetricValue)
                ) &&
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.Statistic == other.Statistic ||
                    this.Statistic != null &&
                    this.Statistic.Equals(other.Statistic)
                ) &&
                (
                    this.RuleUri == other.RuleUri ||
                    this.RuleUri != null &&
                    this.RuleUri.Equals(other.RuleUri)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Unread != null)
                    hash = hash * 59 + this.Unread.GetHashCode();
                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();
                if (this.MetricThresholds != null)
                    hash = hash * 59 + this.MetricThresholds.GetHashCode();
                if (this.MetricValue != null)
                    hash = hash * 59 + this.MetricValue.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                if (this.Statistic != null)
                    hash = hash * 59 + this.Statistic.GetHashCode();
                if (this.RuleUri != null)
                    hash = hash * 59 + this.RuleUri.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
