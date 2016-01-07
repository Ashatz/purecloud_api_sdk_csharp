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
    public class Interval :  IEquatable<Interval>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Interval" /> class.
        /// </summary>
        public Interval()
        {
            this.BeforeNow = false;
            this.AfterNow = false;
            
        }

        
        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public DateTime? End { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public DateTime? Start { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Chronology
        /// </summary>
        [DataMember(Name="chronology", EmitDefaultValue=false)]
        public Chronology Chronology { get; set; }
  
        
        /// <summary>
        /// Gets or Sets StartMillis
        /// </summary>
        [DataMember(Name="startMillis", EmitDefaultValue=false)]
        public long? StartMillis { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EndMillis
        /// </summary>
        [DataMember(Name="endMillis", EmitDefaultValue=false)]
        public long? EndMillis { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BeforeNow
        /// </summary>
        [DataMember(Name="beforeNow", EmitDefaultValue=false)]
        public bool? BeforeNow { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AfterNow
        /// </summary>
        [DataMember(Name="afterNow", EmitDefaultValue=false)]
        public bool? AfterNow { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Interval {\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Chronology: ").Append(Chronology).Append("\n");
            sb.Append("  StartMillis: ").Append(StartMillis).Append("\n");
            sb.Append("  EndMillis: ").Append(EndMillis).Append("\n");
            sb.Append("  BeforeNow: ").Append(BeforeNow).Append("\n");
            sb.Append("  AfterNow: ").Append(AfterNow).Append("\n");
            
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
            return this.Equals(obj as Interval);
        }

        /// <summary>
        /// Returns true if Interval instances are equal
        /// </summary>
        /// <param name="obj">Instance of Interval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Interval other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.End == other.End ||
                    this.End != null &&
                    this.End.Equals(other.End)
                ) && 
                (
                    this.Start == other.Start ||
                    this.Start != null &&
                    this.Start.Equals(other.Start)
                ) && 
                (
                    this.Chronology == other.Chronology ||
                    this.Chronology != null &&
                    this.Chronology.Equals(other.Chronology)
                ) && 
                (
                    this.StartMillis == other.StartMillis ||
                    this.StartMillis != null &&
                    this.StartMillis.Equals(other.StartMillis)
                ) && 
                (
                    this.EndMillis == other.EndMillis ||
                    this.EndMillis != null &&
                    this.EndMillis.Equals(other.EndMillis)
                ) && 
                (
                    this.BeforeNow == other.BeforeNow ||
                    this.BeforeNow != null &&
                    this.BeforeNow.Equals(other.BeforeNow)
                ) && 
                (
                    this.AfterNow == other.AfterNow ||
                    this.AfterNow != null &&
                    this.AfterNow.Equals(other.AfterNow)
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
                
                if (this.End != null)
                    hash = hash * 57 + this.End.GetHashCode();
                
                if (this.Start != null)
                    hash = hash * 57 + this.Start.GetHashCode();
                
                if (this.Chronology != null)
                    hash = hash * 57 + this.Chronology.GetHashCode();
                
                if (this.StartMillis != null)
                    hash = hash * 57 + this.StartMillis.GetHashCode();
                
                if (this.EndMillis != null)
                    hash = hash * 57 + this.EndMillis.GetHashCode();
                
                if (this.BeforeNow != null)
                    hash = hash * 57 + this.BeforeNow.GetHashCode();
                
                if (this.AfterNow != null)
                    hash = hash * 57 + this.AfterNow.GetHashCode();
                
                return hash;
            }
        }

    }


}
