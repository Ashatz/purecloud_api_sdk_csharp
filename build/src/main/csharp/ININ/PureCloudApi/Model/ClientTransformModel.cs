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
    public partial class ClientTransformModel :  IEquatable<ClientTransformModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientTransformModel" /> class.
        /// </summary>
        public ClientTransformModel()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EndpointId
        /// </summary>
        [DataMember(Name="endpointId", EmitDefaultValue=false)]
        public string EndpointId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FilenameReplaces
        /// </summary>
        [DataMember(Name="filenameReplaces", EmitDefaultValue=false)]
        public List<BasicTransform> FilenameReplaces { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<TagModel> Tags { get; set; }
  
        
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
            sb.Append("class ClientTransformModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EndpointId: ").Append(EndpointId).Append("\n");
            sb.Append("  FilenameReplaces: ").Append(FilenameReplaces).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(obj as ClientTransformModel);
        }

        /// <summary>
        /// Returns true if ClientTransformModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ClientTransformModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientTransformModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.EndpointId == other.EndpointId ||
                    this.EndpointId != null &&
                    this.EndpointId.Equals(other.EndpointId)
                ) && 
                (
                    this.FilenameReplaces == other.FilenameReplaces ||
                    this.FilenameReplaces != null &&
                    this.FilenameReplaces.SequenceEqual(other.FilenameReplaces)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.EndpointId != null)
                    hash = hash * 59 + this.EndpointId.GetHashCode();
                
                if (this.FilenameReplaces != null)
                    hash = hash * 59 + this.FilenameReplaces.GetHashCode();
                
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }
}
