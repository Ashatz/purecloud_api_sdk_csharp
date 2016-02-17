using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class VoicemailOrganizationPolicy :  IEquatable<VoicemailOrganizationPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailOrganizationPolicy" /> class.
        /// </summary>
        public VoicemailOrganizationPolicy()
        {
            this.Enabled = false;
            this.CompressSilence = false;
            this.PinRequired = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RetentionTimeDays
        /// </summary>
        [DataMember(Name="retentionTimeDays", EmitDefaultValue=false)]
        public int? RetentionTimeDays { get; set; }
  
        
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
        /// Gets or Sets CompressSilence
        /// </summary>
        [DataMember(Name="compressSilence", EmitDefaultValue=false)]
        public bool? CompressSilence { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PinConfiguration
        /// </summary>
        [DataMember(Name="pinConfiguration", EmitDefaultValue=false)]
        public PINConfiguration PinConfiguration { get; set; }
  
        
        /// <summary>
        /// Gets or Sets QuotaSizeBytes
        /// </summary>
        [DataMember(Name="quotaSizeBytes", EmitDefaultValue=false)]
        public long? QuotaSizeBytes { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
  
        
        /// <summary>
        /// The extension for voicemail retrieval.  The default value is *86.
        /// </summary>
        /// <value>The extension for voicemail retrieval.  The default value is *86.</value>
        [DataMember(Name="voicemailExtension", EmitDefaultValue=false)]
        public string VoicemailExtension { get; set; }
  
        
        /// <summary>
        /// If this is true, a PIN is required when accessing a user's voicemail from a phone.
        /// </summary>
        /// <value>If this is true, a PIN is required when accessing a user's voicemail from a phone.</value>
        [DataMember(Name="pinRequired", EmitDefaultValue=false)]
        public bool? PinRequired { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicemailOrganizationPolicy {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  RetentionTimeDays: ").Append(RetentionTimeDays).Append("\n");
            sb.Append("  AlertTimeoutSeconds: ").Append(AlertTimeoutSeconds).Append("\n");
            sb.Append("  MinimumRecordingTimeSeconds: ").Append(MinimumRecordingTimeSeconds).Append("\n");
            sb.Append("  MaximumRecordingTimeSeconds: ").Append(MaximumRecordingTimeSeconds).Append("\n");
            sb.Append("  UnavailableMessageUri: ").Append(UnavailableMessageUri).Append("\n");
            sb.Append("  NamePromptMessageUri: ").Append(NamePromptMessageUri).Append("\n");
            sb.Append("  FullMessageUri: ").Append(FullMessageUri).Append("\n");
            sb.Append("  CompressSilence: ").Append(CompressSilence).Append("\n");
            sb.Append("  PinConfiguration: ").Append(PinConfiguration).Append("\n");
            sb.Append("  QuotaSizeBytes: ").Append(QuotaSizeBytes).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  VoicemailExtension: ").Append(VoicemailExtension).Append("\n");
            sb.Append("  PinRequired: ").Append(PinRequired).Append("\n");
            
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
            return this.Equals(obj as VoicemailOrganizationPolicy);
        }

        /// <summary>
        /// Returns true if VoicemailOrganizationPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailOrganizationPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailOrganizationPolicy other)
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
                    this.RetentionTimeDays == other.RetentionTimeDays ||
                    this.RetentionTimeDays != null &&
                    this.RetentionTimeDays.Equals(other.RetentionTimeDays)
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
                    this.CompressSilence == other.CompressSilence ||
                    this.CompressSilence != null &&
                    this.CompressSilence.Equals(other.CompressSilence)
                ) && 
                (
                    this.PinConfiguration == other.PinConfiguration ||
                    this.PinConfiguration != null &&
                    this.PinConfiguration.Equals(other.PinConfiguration)
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
                ) && 
                (
                    this.VoicemailExtension == other.VoicemailExtension ||
                    this.VoicemailExtension != null &&
                    this.VoicemailExtension.Equals(other.VoicemailExtension)
                ) && 
                (
                    this.PinRequired == other.PinRequired ||
                    this.PinRequired != null &&
                    this.PinRequired.Equals(other.PinRequired)
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
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.RetentionTimeDays != null)
                    hash = hash * 59 + this.RetentionTimeDays.GetHashCode();
                
                if (this.AlertTimeoutSeconds != null)
                    hash = hash * 59 + this.AlertTimeoutSeconds.GetHashCode();
                
                if (this.MinimumRecordingTimeSeconds != null)
                    hash = hash * 59 + this.MinimumRecordingTimeSeconds.GetHashCode();
                
                if (this.MaximumRecordingTimeSeconds != null)
                    hash = hash * 59 + this.MaximumRecordingTimeSeconds.GetHashCode();
                
                if (this.UnavailableMessageUri != null)
                    hash = hash * 59 + this.UnavailableMessageUri.GetHashCode();
                
                if (this.NamePromptMessageUri != null)
                    hash = hash * 59 + this.NamePromptMessageUri.GetHashCode();
                
                if (this.FullMessageUri != null)
                    hash = hash * 59 + this.FullMessageUri.GetHashCode();
                
                if (this.CompressSilence != null)
                    hash = hash * 59 + this.CompressSilence.GetHashCode();
                
                if (this.PinConfiguration != null)
                    hash = hash * 59 + this.PinConfiguration.GetHashCode();
                
                if (this.QuotaSizeBytes != null)
                    hash = hash * 59 + this.QuotaSizeBytes.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                if (this.VoicemailExtension != null)
                    hash = hash * 59 + this.VoicemailExtension.GetHashCode();
                
                if (this.PinRequired != null)
                    hash = hash * 59 + this.PinRequired.GetHashCode();
                
                return hash;
            }
        }

    }
}
