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
    public partial class FlowBodyFormat :  IEquatable<FlowBodyFormat>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowBodyFormat" />class.
        /// </summary>
<<<<<<< HEAD
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="SchemaUri">SchemaUri.</param>

        public FlowBodyFormat(string Name = null, string Description = null, string SchemaUri = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.SchemaUri = SchemaUri;
=======
        /// <param name="SchemaUri">SchemaUri.</param>
        /// <param name="Description">Description.</param>

        public FlowBodyFormat(string SchemaUri = null, string Description = null)
        {
            this.SchemaUri = SchemaUri;
            this.Description = Description;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    
        /// <summary>
        /// Gets or Sets SchemaUri
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
=======
        [DataMember(Name="schemaUri", EmitDefaultValue=false)]
        public string SchemaUri { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
<<<<<<< HEAD
        /// <summary>
        /// Gets or Sets SchemaUri
        /// </summary>
        [DataMember(Name="schemaUri", EmitDefaultValue=false)]
        public string SchemaUri { get; set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowBodyFormat {\n");
            sb.Append("  SchemaUri: ").Append(SchemaUri).Append("\n");
<<<<<<< HEAD
=======
            sb.Append("  Description: ").Append(Description).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            return this.Equals(obj as FlowBodyFormat);
        }

        /// <summary>
        /// Returns true if FlowBodyFormat instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowBodyFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowBodyFormat other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
<<<<<<< HEAD
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
=======
                    this.SchemaUri == other.SchemaUri ||
                    this.SchemaUri != null &&
                    this.SchemaUri.Equals(other.SchemaUri)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
<<<<<<< HEAD
                ) &&
                (
                    this.SchemaUri == other.SchemaUri ||
                    this.SchemaUri != null &&
                    this.SchemaUri.Equals(other.SchemaUri)
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.SchemaUri != null)
                    hash = hash * 59 + this.SchemaUri.GetHashCode();
=======
                if (this.SchemaUri != null)
                    hash = hash * 59 + this.SchemaUri.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
