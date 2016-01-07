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
    public class VoicemailUserPolicy :  IEquatable<VoicemailUserPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailUserPolicy" /> class.
        /// </summary>
        public VoicemailUserPolicy()
        {
            this.Enabled = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AlertTimeoutSeconds
        /// </summary>
        [DataMember(Name="alertTimeoutSeconds", EmitDefaultValue=false)]
        public int? AlertTimeoutSeconds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MinimumRecordingTimeSeconds
        /// </summary>
        [DataMember(Name="minimumRecordingTimeSeconds", EmitDefaultValue=false)]
        public int? MinimumRecordingTimeSeconds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MaximumRecordingTimeSeconds
        /// </summary>
        [DataMember(Name="maximumRecordingTimeSeconds", EmitDefaultValue=false)]
        public int? MaximumRecordingTimeSeconds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets UnavailableMessageUri
        /// </summary>
        [DataMember(Name="unavailableMessageUri", EmitDefaultValue=false)]
        public string UnavailableMessageUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets NamePromptMessageUri
        /// </summary>
        [DataMember(Name="namePromptMessageUri", EmitDefaultValue=false)]
        public string NamePromptMessageUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FullMessageUri
        /// </summary>
        [DataMember(Name="fullMessageUri", EmitDefaultValue=false)]
        public string FullMessageUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Pin
        /// </summary>
        [DataMember(Name="pin", EmitDefaultValue=false)]
        public string Pin { get; set; }
  
        
        /// <summary>
        /// Gets or Sets QuotaSizeBytes
        /// </summary>
        [DataMember(Name="quotaSizeBytes", EmitDefaultValue=false)]
        public long? QuotaSizeBytes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicemailUserPolicy {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  AlertTimeoutSeconds: ").Append(AlertTimeoutSeconds).Append("\n");
            sb.Append("  MinimumRecordingTimeSeconds: ").Append(MinimumRecordingTimeSeconds).Append("\n");
            sb.Append("  MaximumRecordingTimeSeconds: ").Append(MaximumRecordingTimeSeconds).Append("\n");
            sb.Append("  UnavailableMessageUri: ").Append(UnavailableMessageUri).Append("\n");
            sb.Append("  NamePromptMessageUri: ").Append(NamePromptMessageUri).Append("\n");
            sb.Append("  FullMessageUri: ").Append(FullMessageUri).Append("\n");
            sb.Append("  Pin: ").Append(Pin).Append("\n");
            sb.Append("  QuotaSizeBytes: ").Append(QuotaSizeBytes).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            
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
            return this.Equals(obj as VoicemailUserPolicy);
        }

        /// <summary>
        /// Returns true if VoicemailUserPolicy instances are equal
        /// </summary>
        /// <param name="obj">Instance of VoicemailUserPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailUserPolicy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.AlertTimeoutSeconds == other.AlertTimeoutSeconds ||
                    this.AlertTimeoutSeconds != null &&
                    this.AlertTimeoutSeconds.Equals(other.AlertTimeoutSeconds)
                ) && 
                (
                    this.MinimumRecordingTimeSeconds == other.MinimumRecordingTimeSeconds ||
                    this.MinimumRecordingTimeSeconds != null &&
                    this.MinimumRecordingTimeSeconds.Equals(other.MinimumRecordingTimeSeconds)
                ) && 
                (
                    this.MaximumRecordingTimeSeconds == other.MaximumRecordingTimeSeconds ||
                    this.MaximumRecordingTimeSeconds != null &&
                    this.MaximumRecordingTimeSeconds.Equals(other.MaximumRecordingTimeSeconds)
                ) && 
                (
                    this.UnavailableMessageUri == other.UnavailableMessageUri ||
                    this.UnavailableMessageUri != null &&
                    this.UnavailableMessageUri.Equals(other.UnavailableMessageUri)
                ) && 
                (
                    this.NamePromptMessageUri == other.NamePromptMessageUri ||
                    this.NamePromptMessageUri != null &&
                    this.NamePromptMessageUri.Equals(other.NamePromptMessageUri)
                ) && 
                (
                    this.FullMessageUri == other.FullMessageUri ||
                    this.FullMessageUri != null &&
                    this.FullMessageUri.Equals(other.FullMessageUri)
                ) && 
                (
                    this.Pin == other.Pin ||
                    this.Pin != null &&
                    this.Pin.Equals(other.Pin)
                ) && 
                (
                    this.QuotaSizeBytes == other.QuotaSizeBytes ||
                    this.QuotaSizeBytes != null &&
                    this.QuotaSizeBytes.Equals(other.QuotaSizeBytes)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
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
                
                if (this.Enabled != null)
                    hash = hash * 57 + this.Enabled.GetHashCode();
                
                if (this.AlertTimeoutSeconds != null)
                    hash = hash * 57 + this.AlertTimeoutSeconds.GetHashCode();
                
                if (this.MinimumRecordingTimeSeconds != null)
                    hash = hash * 57 + this.MinimumRecordingTimeSeconds.GetHashCode();
                
                if (this.MaximumRecordingTimeSeconds != null)
                    hash = hash * 57 + this.MaximumRecordingTimeSeconds.GetHashCode();
                
                if (this.UnavailableMessageUri != null)
                    hash = hash * 57 + this.UnavailableMessageUri.GetHashCode();
                
                if (this.NamePromptMessageUri != null)
                    hash = hash * 57 + this.NamePromptMessageUri.GetHashCode();
                
                if (this.FullMessageUri != null)
                    hash = hash * 57 + this.FullMessageUri.GetHashCode();
                
                if (this.Pin != null)
                    hash = hash * 57 + this.Pin.GetHashCode();
                
                if (this.QuotaSizeBytes != null)
                    hash = hash * 57 + this.QuotaSizeBytes.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 57 + this.CreatedDate.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 57 + this.ModifiedDate.GetHashCode();
                
                return hash;
            }
        }

    }


}
