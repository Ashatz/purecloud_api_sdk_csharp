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
    /// IndexedTransform
    /// </summary>
    [DataContract]
    public partial class IndexedTransform :  IEquatable<IndexedTransform>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedTransform" /> class.
        /// </summary>
        /// <param name="Replaces">Replaces.</param>
        /// <param name="EntityPath">EntityPath.</param>
        /// <param name="Index">Index.</param>
        /// <param name="Name">Name.</param>
        public IndexedTransform(List<TransformLens> Replaces = null, List<string> EntityPath = null, int? Index = null, string Name = null)
        {
            this.Replaces = Replaces;
            this.EntityPath = EntityPath;
            this.Index = Index;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets Replaces
        /// </summary>
        [DataMember(Name="replaces", EmitDefaultValue=false)]
        public List<TransformLens> Replaces { get; set; }
        /// <summary>
        /// Gets or Sets EntityPath
        /// </summary>
        [DataMember(Name="entityPath", EmitDefaultValue=false)]
        public List<string> EntityPath { get; set; }
        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndexedTransform {\n");
            sb.Append("  Replaces: ").Append(Replaces).Append("\n");
            sb.Append("  EntityPath: ").Append(EntityPath).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as IndexedTransform);
        }

        /// <summary>
        /// Returns true if IndexedTransform instances are equal
        /// </summary>
        /// <param name="other">Instance of IndexedTransform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexedTransform other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Replaces == other.Replaces ||
                    this.Replaces != null &&
                    this.Replaces.SequenceEqual(other.Replaces)
                ) && 
                (
                    this.EntityPath == other.EntityPath ||
                    this.EntityPath != null &&
                    this.EntityPath.SequenceEqual(other.EntityPath)
                ) && 
                (
                    this.Index == other.Index ||
                    this.Index != null &&
                    this.Index.Equals(other.Index)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Replaces != null)
                    hash = hash * 59 + this.Replaces.GetHashCode();
                if (this.EntityPath != null)
                    hash = hash * 59 + this.EntityPath.GetHashCode();
                if (this.Index != null)
                    hash = hash * 59 + this.Index.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }
    }

}
