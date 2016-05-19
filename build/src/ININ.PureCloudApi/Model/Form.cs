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
    /// Form
    /// </summary>
    [DataContract]
    public partial class Form :  IEquatable<Form>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form" /> class.
        /// </summary>
        /// <param name="Controls">Controls.</param>
        public Form(List<Control> Controls = null)
        {
            this.Controls = Controls;
        }
        
        /// <summary>
        /// Gets or Sets Controls
        /// </summary>
        [DataMember(Name="controls", EmitDefaultValue=false)]
        public List<Control> Controls { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Form {\n");
            sb.Append("  Controls: ").Append(Controls).Append("\n");
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
            return this.Equals(obj as Form);
        }

        /// <summary>
        /// Returns true if Form instances are equal
        /// </summary>
        /// <param name="other">Instance of Form to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Form other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Controls == other.Controls ||
                    this.Controls != null &&
                    this.Controls.SequenceEqual(other.Controls)
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
                if (this.Controls != null)
                    hash = hash * 59 + this.Controls.GetHashCode();
                return hash;
            }
        }
    }

}
