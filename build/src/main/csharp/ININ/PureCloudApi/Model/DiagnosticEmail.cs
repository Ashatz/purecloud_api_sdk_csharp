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
    public partial class DiagnosticEmail :  IEquatable<DiagnosticEmail>
    { 

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PriorityEnum {
            
            [EnumMember(Value = "LOW")]
            Low,
            
            [EnumMember(Value = "MEDIUM")]
            Medium,
            
            [EnumMember(Value = "HIGH")]
            High
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum {
            
            [EnumMember(Value = "PROBLEM")]
            Problem,
            
            [EnumMember(Value = "FEATURE_REQUEST")]
            FeatureRequest,
            
            [EnumMember(Value = "QUESTION")]
            Question,
            
            [EnumMember(Value = "TECHNICAL_ISSUE")]
            TechnicalIssue,
            
            [EnumMember(Value = "NON_TECHNICAL_ISSUE")]
            NonTechnicalIssue
        }

        

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public PriorityEnum? Priority { get; set; }
    

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticEmail" />class.
        /// </summary>
        /// <param name="Subject">Subject.</param>
        /// <param name="Topic">Topic.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Data">Data.</param>

        public DiagnosticEmail(string Subject = null, string Topic = null, string Description = null, PriorityEnum? Priority = null, TypeEnum? Type = null, Object Data = null)
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
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [DataMember(Name="topic", EmitDefaultValue=false)]
        public string Topic { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
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

            return true &&
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
