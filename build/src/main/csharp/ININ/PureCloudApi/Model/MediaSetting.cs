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
    public partial class MediaSetting :  IEquatable<MediaSetting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSetting" /> class.
        /// </summary>
        public MediaSetting()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets AlertingTimeoutSeconds
        /// </summary>
        [DataMember(Name="alertingTimeoutSeconds", EmitDefaultValue=false)]
        public int? AlertingTimeoutSeconds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ServiceLevel
        /// </summary>
        [DataMember(Name="serviceLevel", EmitDefaultValue=false)]
        public ServiceLevel ServiceLevel { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaSetting {\n");
            sb.Append("  AlertingTimeoutSeconds: ").Append(AlertingTimeoutSeconds).Append("\n");
            sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
            
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
            return this.Equals(obj as MediaSetting);
        }

        /// <summary>
        /// Returns true if MediaSetting instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaSetting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AlertingTimeoutSeconds == other.AlertingTimeoutSeconds ||
                    this.AlertingTimeoutSeconds != null &&
                    this.AlertingTimeoutSeconds.Equals(other.AlertingTimeoutSeconds)
                ) && 
                (
                    this.ServiceLevel == other.ServiceLevel ||
                    this.ServiceLevel != null &&
                    this.ServiceLevel.Equals(other.ServiceLevel)
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
                
                if (this.AlertingTimeoutSeconds != null)
                    hash = hash * 59 + this.AlertingTimeoutSeconds.GetHashCode();
                
                if (this.ServiceLevel != null)
                    hash = hash * 59 + this.ServiceLevel.GetHashCode();
                
                return hash;
            }
        }

    }
}
