using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class BasicTransform :  IEquatable<BasicTransform>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicTransform" /> class.
        /// </summary>
        public BasicTransform()
        {
            
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasicTransform {\n");
            sb.Append("  Replaces: ").Append(Replaces).Append("\n");
            sb.Append("  EntityPath: ").Append(EntityPath).Append("\n");
            
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
            return this.Equals(obj as BasicTransform);
        }

        /// <summary>
        /// Returns true if BasicTransform instances are equal
        /// </summary>
        /// <param name="other">Instance of BasicTransform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasicTransform other)
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
                
                return hash;
            }
        }

    }
}
