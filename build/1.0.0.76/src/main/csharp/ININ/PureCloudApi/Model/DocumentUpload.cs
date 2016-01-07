using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class DocumentUpload :  IEquatable<DocumentUpload>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentUpload" /> class.
        /// </summary>
        public DocumentUpload()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Workspace
        /// </summary>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public UriReference Workspace { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TagIds
        /// </summary>
        [DataMember(Name="tagIds", EmitDefaultValue=false)]
        public List<string> TagIds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<AttributeValue> Attributes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AttributeGroupInstances
        /// </summary>
        [DataMember(Name="attributeGroupInstances", EmitDefaultValue=false)]
        public List<AttributeGroupInstance> AttributeGroupInstances { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentUpload {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  AttributeGroupInstances: ").Append(AttributeGroupInstances).Append("\n");
            
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
            return this.Equals(obj as DocumentUpload);
        }

        /// <summary>
        /// Returns true if DocumentUpload instances are equal
        /// </summary>
        /// <param name="obj">Instance of DocumentUpload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentUpload other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Workspace == other.Workspace ||
                    this.Workspace != null &&
                    this.Workspace.Equals(other.Workspace)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.TagIds == other.TagIds ||
                    this.TagIds != null &&
                    this.TagIds.SequenceEqual(other.TagIds)
                ) && 
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) && 
                (
                    this.AttributeGroupInstances == other.AttributeGroupInstances ||
                    this.AttributeGroupInstances != null &&
                    this.AttributeGroupInstances.SequenceEqual(other.AttributeGroupInstances)
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
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Workspace != null)
                    hash = hash * 57 + this.Workspace.GetHashCode();
                
                if (this.Tags != null)
                    hash = hash * 57 + this.Tags.GetHashCode();
                
                if (this.TagIds != null)
                    hash = hash * 57 + this.TagIds.GetHashCode();
                
                if (this.Attributes != null)
                    hash = hash * 57 + this.Attributes.GetHashCode();
                
                if (this.AttributeGroupInstances != null)
                    hash = hash * 57 + this.AttributeGroupInstances.GetHashCode();
                
                return hash;
            }
        }

    }


}
