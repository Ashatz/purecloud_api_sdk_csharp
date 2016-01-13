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
    public class Wrapup :  IEquatable<Wrapup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wrapup" /> class.
        /// </summary>
        public Wrapup()
        {
            this.Provisional = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DurationSeconds
        /// </summary>
        [DataMember(Name="durationSeconds", EmitDefaultValue=false)]
        public int? DurationSeconds { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Provisional
        /// </summary>
        [DataMember(Name="provisional", EmitDefaultValue=false)]
        public bool? Provisional { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Wrapup {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Provisional: ").Append(Provisional).Append("\n");
            
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
            return this.Equals(obj as Wrapup);
        }

        /// <summary>
        /// Returns true if Wrapup instances are equal
        /// </summary>
        /// <param name="obj">Instance of Wrapup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Wrapup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.DurationSeconds == other.DurationSeconds ||
                    this.DurationSeconds != null &&
                    this.DurationSeconds.Equals(other.DurationSeconds)
                ) && 
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) && 
                (
                    this.Provisional == other.Provisional ||
                    this.Provisional != null &&
                    this.Provisional.Equals(other.Provisional)
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
                
                if (this.Code != null)
                    hash = hash * 57 + this.Code.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 57 + this.Notes.GetHashCode();
                
                if (this.Tags != null)
                    hash = hash * 57 + this.Tags.GetHashCode();
                
                if (this.DurationSeconds != null)
                    hash = hash * 57 + this.DurationSeconds.GetHashCode();
                
                if (this.EndTime != null)
                    hash = hash * 57 + this.EndTime.GetHashCode();
                
                if (this.Provisional != null)
                    hash = hash * 57 + this.Provisional.GetHashCode();
                
                return hash;
            }
        }

    }


}
