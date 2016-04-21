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
    public partial class AvailableTopic :  IEquatable<AvailableTopic>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableTopic" />class.
        /// </summary>
<<<<<<< HEAD

        public AvailableTopic()
=======
        /// <param name="Description">Description.</param>
        /// <param name="Schema">Schema.</param>

        public AvailableTopic(string Description = null, Dictionary<string, Object> Schema = null)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        {
            this.Description = Description;
            this.Schema = Schema;
            
        }

    
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
    
<<<<<<< HEAD
=======
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public Dictionary<string, Object> Schema { get; set; }
    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableTopic {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
<<<<<<< HEAD
=======
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
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
            return this.Equals(obj as AvailableTopic);
        }

        /// <summary>
        /// Returns true if AvailableTopic instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailableTopic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableTopic other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.SequenceEqual(other.Schema)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
<<<<<<< HEAD
=======
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
