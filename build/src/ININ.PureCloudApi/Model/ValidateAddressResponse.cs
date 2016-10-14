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
    /// ValidateAddressResponse
    /// </summary>
    [DataContract]
    public partial class ValidateAddressResponse :  IEquatable<ValidateAddressResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateAddressResponse" /> class.
        /// </summary>
        /// <param name="Valid">Valid (default to false).</param>
        /// <param name="Response">Response.</param>
        public ValidateAddressResponse(bool? Valid = null, SubscriberResponse Response = null)
        {
            // use default value if no "Valid" provided
            if (Valid == null)
            {
                this.Valid = false;
            }
            else
            {
                this.Valid = Valid;
            }
            this.Response = Response;
        }
        
        /// <summary>
        /// Gets or Sets Valid
        /// </summary>
        [DataMember(Name="valid", EmitDefaultValue=false)]
        public bool? Valid { get; set; }
        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public SubscriberResponse Response { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateAddressResponse {\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
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
            return this.Equals(obj as ValidateAddressResponse);
        }

        /// <summary>
        /// Returns true if ValidateAddressResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidateAddressResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateAddressResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Valid == other.Valid ||
                    this.Valid != null &&
                    this.Valid.Equals(other.Valid)
                ) &&
                (
                    this.Response == other.Response ||
                    this.Response != null &&
                    this.Response.Equals(other.Response)
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
                if (this.Valid != null)
                    hash = hash * 59 + this.Valid.GetHashCode();
                if (this.Response != null)
                    hash = hash * 59 + this.Response.GetHashCode();
                return hash;
            }
        }
    }

}
