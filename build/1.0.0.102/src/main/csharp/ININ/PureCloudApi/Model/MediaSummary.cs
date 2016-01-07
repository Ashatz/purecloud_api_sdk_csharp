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
    public class MediaSummary :  IEquatable<MediaSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSummary" /> class.
        /// </summary>
        public MediaSummary()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets ContactCenter
        /// </summary>
        [DataMember(Name="contactCenter", EmitDefaultValue=false)]
        public int? ContactCenter { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Enterprise
        /// </summary>
        [DataMember(Name="enterprise", EmitDefaultValue=false)]
        public int? Enterprise { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaSummary {\n");
            sb.Append("  ContactCenter: ").Append(ContactCenter).Append("\n");
            sb.Append("  Enterprise: ").Append(Enterprise).Append("\n");
            
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
            return this.Equals(obj as MediaSummary);
        }

        /// <summary>
        /// Returns true if MediaSummary instances are equal
        /// </summary>
        /// <param name="obj">Instance of MediaSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContactCenter == other.ContactCenter ||
                    this.ContactCenter != null &&
                    this.ContactCenter.Equals(other.ContactCenter)
                ) && 
                (
                    this.Enterprise == other.Enterprise ||
                    this.Enterprise != null &&
                    this.Enterprise.Equals(other.Enterprise)
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
                
                if (this.ContactCenter != null)
                    hash = hash * 57 + this.ContactCenter.GetHashCode();
                
                if (this.Enterprise != null)
                    hash = hash * 57 + this.Enterprise.GetHashCode();
                
                return hash;
            }
        }

    }


}