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
        /// </summary>
        [JsonConstructorAttribute]
        protected Certificate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate" /> class.
        /// </summary>
        /// <param name="_Certificate">The certificate to parse. (required).</param>
        public Certificate(string _Certificate = null)
        {
            // to ensure "_Certificate" is required (not null)
            if (_Certificate == null)
            {
                throw new InvalidDataException("_Certificate is a required property for Certificate and cannot be null");
            }
            else
            {
                this._Certificate = _Certificate;
            }
        }
        
        /// <summary>
        /// The certificate to parse.
        /// </summary>
        /// <value>The certificate to parse.</value>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string _Certificate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Certificate {\n");
            sb.Append("  _Certificate: ").Append(_Certificate).Append("\n");
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
                    this._Certificate == other._Certificate ||
                    this._Certificate != null &&
                    this._Certificate.Equals(other._Certificate)
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
                if (this._Certificate != null)
                    hash = hash * 59 + this._Certificate.GetHashCode();
                return hash;
            }
        }
    }

}
