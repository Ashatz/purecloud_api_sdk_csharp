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
    public class OrganizationAddress :  IEquatable<OrganizationAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationAddress" /> class.
        /// </summary>
        public OrganizationAddress()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Display
        /// </summary>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public string Display { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public string MediaType { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationAddress {\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            
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
            return this.Equals(obj as OrganizationAddress);
        }

        /// <summary>
        /// Returns true if OrganizationAddress instances are equal
        /// </summary>
        /// <param name="obj">Instance of OrganizationAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Display == other.Display ||
                    this.Display != null &&
                    this.Display.Equals(other.Display)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
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
                
                if (this.Display != null)
                    hash = hash * 57 + this.Display.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 57 + this.Address.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 57 + this.MediaType.GetHashCode();
                
                return hash;
            }
        }

    }


}
