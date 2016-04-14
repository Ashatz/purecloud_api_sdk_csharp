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
    public partial class Trace :  IEquatable<Trace>
    { 

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LevelEnum {
            
            [EnumMember(Value = "ERROR")]
            Error,
            
            [EnumMember(Value = "WARN")]
            Warn,
            
            [EnumMember(Value = "INFO")]
            Info,
            
            [EnumMember(Value = "DEBUG")]
            Debug
        }

        
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Trace" />class.
        /// </summary>
        /// <param name="Topic">Topic.</param>
        /// <param name="Timestamp">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Level">Level.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Details">Details.</param>
        /// <param name="TimestampString">TimestampString.</param>
        /// <param name="DetailsString">DetailsString.</param>

        public Trace(string Topic = null, DateTime? Timestamp = null, LevelEnum? Level = null, string Message = null, Object Details = null, string TimestampString = null, string DetailsString = null)
        {
            this.Topic = Topic;
            this.Timestamp = Timestamp;
            this.Level = Level;
            this.Message = Message;
            this.Details = Details;
            this.TimestampString = TimestampString;
            this.DetailsString = DetailsString;
            
        }

    
        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [DataMember(Name="topic", EmitDefaultValue=false)]
        public string Topic { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
    
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
    
        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public Object Details { get; set; }
    
        /// <summary>
        /// Gets or Sets TimestampString
        /// </summary>
        [DataMember(Name="timestampString", EmitDefaultValue=false)]
        public string TimestampString { get; set; }
    
        /// <summary>
        /// Gets or Sets DetailsString
        /// </summary>
        [DataMember(Name="detailsString", EmitDefaultValue=false)]
        public string DetailsString { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Trace {\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  TimestampString: ").Append(TimestampString).Append("\n");
            sb.Append("  DetailsString: ").Append(DetailsString).Append("\n");
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
            return this.Equals(obj as Trace);
        }

        /// <summary>
        /// Returns true if Trace instances are equal
        /// </summary>
        /// <param name="other">Instance of Trace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trace other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Topic == other.Topic ||
                    this.Topic != null &&
                    this.Topic.Equals(other.Topic)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
                ) &&
                (
                    this.TimestampString == other.TimestampString ||
                    this.TimestampString != null &&
                    this.TimestampString.Equals(other.TimestampString)
                ) &&
                (
                    this.DetailsString == other.DetailsString ||
                    this.DetailsString != null &&
                    this.DetailsString.Equals(other.DetailsString)
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
                if (this.Topic != null)
                    hash = hash * 59 + this.Topic.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.TimestampString != null)
                    hash = hash * 59 + this.TimestampString.GetHashCode();
                if (this.DetailsString != null)
                    hash = hash * 59 + this.DetailsString.GetHashCode();
                return hash;
            }
        }

    }
}
