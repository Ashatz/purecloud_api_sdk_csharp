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
    public partial class FavoriteTemplateRequestData :  IEquatable<FavoriteTemplateRequestData>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteTemplateRequestData" />class.
        /// </summary>
        /// <param name="TemplateId">TemplateId.</param>

        public FavoriteTemplateRequestData(string TemplateId = null)
        {
            this.TemplateId = TemplateId;
            
        }
        
    
        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FavoriteTemplateRequestData {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            
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
            return this.Equals(obj as FavoriteTemplateRequestData);
        }

        /// <summary>
        /// Returns true if FavoriteTemplateRequestData instances are equal
        /// </summary>
        /// <param name="other">Instance of FavoriteTemplateRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavoriteTemplateRequestData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
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
                
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                
                return hash;
            }
        }

    }
}
