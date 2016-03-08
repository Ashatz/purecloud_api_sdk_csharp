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
    /// Represents a certificate to parse.
    /// </summary>
    [DataContract]
    public partial class Certificate :  IEquatable<Certificate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate" /> class.
        /// Initializes a new instance of the <see cref="Certificate" />class.
        /// </summary>
        /// <param name="Certificate">The certificate to parse. (required).</param>

        public Certificate(string Certificate = null)
        {
            // to ensure "Certificate" is required (not null)
            if (Certificate == null)
            {
                throw new InvalidDataException("Certificate is a required property for Certificate and cannot be null");
            }
            else
            {
                this.Certificate = Certificate;
            }
            
        }
        
    
        /// <summary>
        /// The certificate to parse.
        /// </summary>
        /// <value>The certificate to parse.</value>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Certificate {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            
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
            return this.Equals(obj as Certificate);
        }

        /// <summary>
        /// Returns true if Certificate instances are equal
        /// </summary>
        /// <param name="other">Instance of Certificate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Certificate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Certificate == other.Certificate ||
                    this.Certificate != null &&
                    this.Certificate.Equals(other.Certificate)
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
                
                if (this.Certificate != null)
                    hash = hash * 59 + this.Certificate.GetHashCode();
                
                return hash;
            }
        }

    }
}
