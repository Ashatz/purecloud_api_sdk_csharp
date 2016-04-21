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
    public partial class Entity :  IEquatable<Entity>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" />class.
        /// </summary>
<<<<<<< HEAD
        /// <param name="Kind">Kind.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>

        public Entity(string Kind = null, string Id = null, string Name = null)
        {
            this.Kind = Kind;
            this.Id = Id;
            this.Name = Name;
=======
        /// <param name="Type">Type.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="SelfUri">SelfUri.</param>

        public Entity(string Type = null, string Id = null, string Name = null, string SelfUri = null)
        {
            this.Type = Type;
            this.Id = Id;
            this.Name = Name;
            this.SelfUri = SelfUri;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }
=======
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
<<<<<<< HEAD
=======
        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entity {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
<<<<<<< HEAD
=======
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as Entity);
        }

        /// <summary>
        /// Returns true if Entity instances are equal
        /// </summary>
        /// <param name="other">Instance of Entity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Entity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
<<<<<<< HEAD
                    this.Kind == other.Kind ||
                    this.Kind != null &&
                    this.Kind.Equals(other.Kind)
=======
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Kind != null)
                    hash = hash * 59 + this.Kind.GetHashCode();
=======
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
<<<<<<< HEAD
=======
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
