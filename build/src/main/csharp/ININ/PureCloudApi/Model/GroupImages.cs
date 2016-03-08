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
    public partial class GroupImages :  IEquatable<GroupImages>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupImages" /> class.
        /// Initializes a new instance of the <see cref="GroupImages" />class.
        /// </summary>
        /// <param name="ActiveImages">ActiveImages.</param>

        public GroupImages(List<UserImage> ActiveImages = null)
        {
            this.ActiveImages = ActiveImages;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ActiveImages
        /// </summary>
        [DataMember(Name="activeImages", EmitDefaultValue=false)]
        public List<UserImage> ActiveImages { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupImages {\n");
            sb.Append("  ActiveImages: ").Append(ActiveImages).Append("\n");
            
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
            return this.Equals(obj as GroupImages);
        }

        /// <summary>
        /// Returns true if GroupImages instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupImages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupImages other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActiveImages == other.ActiveImages ||
                    this.ActiveImages != null &&
                    this.ActiveImages.SequenceEqual(other.ActiveImages)
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
                
                if (this.ActiveImages != null)
                    hash = hash * 59 + this.ActiveImages.GetHashCode();
                
                return hash;
            }
        }

    }
}
