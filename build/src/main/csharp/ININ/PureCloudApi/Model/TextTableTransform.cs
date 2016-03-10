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
    public partial class TextTableTransform :  IEquatable<TextTableTransform>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TextTableTransform" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="RestEndpoint">RestEndpoint.</param>
        /// <param name="FilenameTransforms">FilenameTransforms.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="CommentSymbol">CommentSymbol.</param>
        /// <param name="Delimiter">Delimiter.</param>
        /// <param name="Table">Table.</param>

        public TextTableTransform(string Name = null, TransformEndpoint RestEndpoint = null, List<BasicTransform> FilenameTransforms = null, List<TagModel> Tags = null, string CommentSymbol = null, string Delimiter = null, TableTransform Table = null)
        {
            this.Name = Name;
            this.RestEndpoint = RestEndpoint;
            this.FilenameTransforms = FilenameTransforms;
            this.Tags = Tags;
            this.CommentSymbol = CommentSymbol;
            this.Delimiter = Delimiter;
            this.Table = Table;
            
        }
        
    
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets RestEndpoint
        /// </summary>
        [DataMember(Name="restEndpoint", EmitDefaultValue=false)]
        public TransformEndpoint RestEndpoint { get; set; }
    
        /// <summary>
        /// Gets or Sets FilenameTransforms
        /// </summary>
        [DataMember(Name="filenameTransforms", EmitDefaultValue=false)]
        public List<BasicTransform> FilenameTransforms { get; set; }
    
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<TagModel> Tags { get; set; }
    
        /// <summary>
        /// Gets or Sets CommentSymbol
        /// </summary>
        [DataMember(Name="commentSymbol", EmitDefaultValue=false)]
        public string CommentSymbol { get; set; }
    
        /// <summary>
        /// Gets or Sets Delimiter
        /// </summary>
        [DataMember(Name="delimiter", EmitDefaultValue=false)]
        public string Delimiter { get; set; }
    
        /// <summary>
        /// Gets or Sets Table
        /// </summary>
        [DataMember(Name="table", EmitDefaultValue=false)]
        public TableTransform Table { get; set; }
    
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextTableTransform {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RestEndpoint: ").Append(RestEndpoint).Append("\n");
            sb.Append("  FilenameTransforms: ").Append(FilenameTransforms).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  CommentSymbol: ").Append(CommentSymbol).Append("\n");
            sb.Append("  Delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            
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
            return this.Equals(obj as TextTableTransform);
        }

        /// <summary>
        /// Returns true if TextTableTransform instances are equal
        /// </summary>
        /// <param name="other">Instance of TextTableTransform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextTableTransform other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.RestEndpoint == other.RestEndpoint ||
                    this.RestEndpoint != null &&
                    this.RestEndpoint.Equals(other.RestEndpoint)
                ) &&
                (
                    this.FilenameTransforms == other.FilenameTransforms ||
                    this.FilenameTransforms != null &&
                    this.FilenameTransforms.SequenceEqual(other.FilenameTransforms)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.CommentSymbol == other.CommentSymbol ||
                    this.CommentSymbol != null &&
                    this.CommentSymbol.Equals(other.CommentSymbol)
                ) &&
                (
                    this.Delimiter == other.Delimiter ||
                    this.Delimiter != null &&
                    this.Delimiter.Equals(other.Delimiter)
                ) &&
                (
                    this.Table == other.Table ||
                    this.Table != null &&
                    this.Table.Equals(other.Table)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.RestEndpoint != null)
                    hash = hash * 59 + this.RestEndpoint.GetHashCode();
                
                if (this.FilenameTransforms != null)
                    hash = hash * 59 + this.FilenameTransforms.GetHashCode();
                
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                
                if (this.CommentSymbol != null)
                    hash = hash * 59 + this.CommentSymbol.GetHashCode();
                
                if (this.Delimiter != null)
                    hash = hash * 59 + this.Delimiter.GetHashCode();
                
                if (this.Table != null)
                    hash = hash * 59 + this.Table.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
