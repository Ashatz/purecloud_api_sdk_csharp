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
    /// EmbeddedSignatureView
    /// </summary>
    [DataContract]
    public partial class EmbeddedSignatureView :  IEquatable<EmbeddedSignatureView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedSignatureView" /> class.
        /// </summary>
        /// <param name="View">View.</param>
        public EmbeddedSignatureView(View View = null)
        {
            this.View = View;
        }
        
        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [DataMember(Name="view", EmitDefaultValue=false)]
        public View View { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedSignatureView {\n");
            sb.Append("  View: ").Append(View).Append("\n");
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
            return this.Equals(obj as EmbeddedSignatureView);
        }

        /// <summary>
        /// Returns true if EmbeddedSignatureView instances are equal
        /// </summary>
        /// <param name="other">Instance of EmbeddedSignatureView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedSignatureView other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.View == other.View ||
                    this.View != null &&
                    this.View.Equals(other.View)
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
                if (this.View != null)
                    hash = hash * 59 + this.View.GetHashCode();
                return hash;
            }
        }
    }

}
