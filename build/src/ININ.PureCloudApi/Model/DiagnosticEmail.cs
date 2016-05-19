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
    /// DiagnosticEmail
    /// </summary>
    [DataContract]
    public partial class DiagnosticEmail :  IEquatable<DiagnosticEmail>
    {
        /// <summary>
        /// Functional Area of Issue
        /// </summary>
        /// <value>Functional Area of Issue</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TopicEnum
        {
            
            /// <summary>
            /// Enum Admin for "Admin"
            /// </summary>
            [EnumMember(Value = "Admin")]
            Admin,
            
            /// <summary>
            /// Enum Documents for "Documents"
            /// </summary>
            [EnumMember(Value = "Documents")]
            Documents,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum VideoChat for "Video Chat"
            /// </summary>
            [EnumMember(Value = "Video Chat")]
            VideoChat,
            
            /// <summary>
            /// Enum Login for "Login"
            /// </summary>
            [EnumMember(Value = "Login")]
            Login,
            
            /// <summary>
            /// Enum Slowness for "Slowness"
            /// </summary>
            [EnumMember(Value = "Slowness")]
            Slowness,
            
            /// <summary>
            /// Enum Other for "Other"
            /// </summary>
            [EnumMember(Value = "Other")]
            Other
        }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriorityEnum
        {
            
            /// <summary>
            /// Enum Low for "LOW"
            /// </summary>
            [EnumMember(Value = "LOW")]
            Low,
            
            /// <summary>
            /// Enum Medium for "MEDIUM"
            /// </summary>
            [EnumMember(Value = "MEDIUM")]
            Medium,
            
            /// <summary>
            /// Enum High for "HIGH"
            /// </summary>
            [EnumMember(Value = "HIGH")]
            High,
            
            /// <summary>
            /// Enum Critical for "CRITICAL"
            /// </summary>
            [EnumMember(Value = "CRITICAL")]
            Critical
        }

        /// <summary>
        /// Type of Issue
        /// </summary>
        /// <value>Type of Issue</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Problem for "Problem"
            /// </summary>
            [EnumMember(Value = "Problem")]
            Problem,
            
            /// <summary>
            /// Enum Question for "Question"
            /// </summary>
            [EnumMember(Value = "Question")]
            Question,
            
            /// <summary>
            /// Enum EnhancementRequest for "Enhancement Request"
            /// </summary>
            [EnumMember(Value = "Enhancement Request")]
            EnhancementRequest
        }

        /// <summary>
        /// Functional Area of Issue
        /// </summary>
        /// <value>Functional Area of Issue</value>
        [DataMember(Name="topic", EmitDefaultValue=false)]
        public TopicEnum? Topic { get; set; }
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Type of Issue
        /// </summary>
        /// <value>Type of Issue</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticEmail" /> class.
        /// </summary>
        /// <param name="Subject">Subject of Issue Report.</param>
        /// <param name="Topic">Functional Area of Issue.</param>
        /// <param name="Description">Detailed Description of Issue.</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="Type">Type of Issue.</param>
        /// <param name="Data">Json blob of data to be included with this report..</param>
        public DiagnosticEmail(, string Subject = null, TopicEnum? Topic = null, string Description = null, PriorityEnum? Priority = null, TypeEnum? Type = null, Object Data = null)
        {
            this.Subject = Subject;
            this.Topic = Topic;
            this.Description = Description;
            this.Priority = Priority;
            this.Type = Type;
            this.Data = Data;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Subject of Issue Report
        /// </summary>
        /// <value>Subject of Issue Report</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
        /// <summary>
        /// Detailed Description of Issue
        /// </summary>
        /// <value>Detailed Description of Issue</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Json blob of data to be included with this report.
        /// </summary>
        /// <value>Json blob of data to be included with this report.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Object Data { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagnosticEmail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(obj as DiagnosticEmail);
        }

        /// <summary>
        /// Returns true if DiagnosticEmail instances are equal
        /// </summary>
        /// <param name="other">Instance of DiagnosticEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagnosticEmail other)
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
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.Topic == other.Topic ||
                    this.Topic != null &&
                    this.Topic.Equals(other.Topic)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
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
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                if (this.Topic != null)
                    hash = hash * 59 + this.Topic.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                return hash;
            }
        }
    }

}
