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
    /// AuthzPerm
    /// </summary>
    [DataContract]
    public partial class AuthzPerm :  IEquatable<AuthzPerm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzPerm" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Permitted">Permitted (default to false).</param>
        public AuthzPerm(string Name = null, bool? Permitted = null)
        {
            this.Name = Name;
            // use default value if no "Permitted" provided
            if (Permitted == null)
            {
                this.Permitted = false;
            }
            else
            {
                this.Permitted = Permitted;
            }
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Permitted
        /// </summary>
        [DataMember(Name="permitted", EmitDefaultValue=false)]
        public bool? Permitted { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthzPerm {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permitted: ").Append(Permitted).Append("\n");
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
            return this.Equals(obj as AuthzPerm);
        }

        /// <summary>
        /// Returns true if AuthzPerm instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthzPerm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthzPerm other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Permitted == other.Permitted ||
                    this.Permitted != null &&
                    this.Permitted.Equals(other.Permitted)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Permitted != null)
                    hash = hash * 59 + this.Permitted.GetHashCode();
                return hash;
            }
        }
    }

}
