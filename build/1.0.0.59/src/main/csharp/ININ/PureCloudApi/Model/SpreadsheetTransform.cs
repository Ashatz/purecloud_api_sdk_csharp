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
    public class SpreadsheetTransform :  IEquatable<SpreadsheetTransform>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetTransform" /> class.
        /// </summary>
        public SpreadsheetTransform()
        {
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
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
        /// Gets or Sets SheetNameTransforms
        /// </summary>
        [DataMember(Name="sheetNameTransforms", EmitDefaultValue=false)]
        public List<IndexedTransform> SheetNameTransforms { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Sheets
        /// </summary>
        [DataMember(Name="sheets", EmitDefaultValue=false)]
        public List<SheetTransform> Sheets { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ClientTransformModel
        /// </summary>
        [DataMember(Name="clientTransformModel", EmitDefaultValue=false)]
        public ClientSpreadsheetTransform ClientTransformModel { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpreadsheetTransform {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RestEndpoint: ").Append(RestEndpoint).Append("\n");
            sb.Append("  FilenameTransforms: ").Append(FilenameTransforms).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  SheetNameTransforms: ").Append(SheetNameTransforms).Append("\n");
            sb.Append("  Sheets: ").Append(Sheets).Append("\n");
            sb.Append("  ClientTransformModel: ").Append(ClientTransformModel).Append("\n");
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
            return this.Equals(obj as SpreadsheetTransform);
        }

        /// <summary>
        /// Returns true if SpreadsheetTransform instances are equal
        /// </summary>
        /// <param name="obj">Instance of SpreadsheetTransform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpreadsheetTransform other)
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
                    this.SheetNameTransforms == other.SheetNameTransforms ||
                    this.SheetNameTransforms != null &&
                    this.SheetNameTransforms.SequenceEqual(other.SheetNameTransforms)
                ) && 
                (
                    this.Sheets == other.Sheets ||
                    this.Sheets != null &&
                    this.Sheets.SequenceEqual(other.Sheets)
                ) && 
                (
                    this.ClientTransformModel == other.ClientTransformModel ||
                    this.ClientTransformModel != null &&
                    this.ClientTransformModel.Equals(other.ClientTransformModel)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.RestEndpoint != null)
                    hash = hash * 57 + this.RestEndpoint.GetHashCode();
                
                if (this.FilenameTransforms != null)
                    hash = hash * 57 + this.FilenameTransforms.GetHashCode();
                
                if (this.Tags != null)
                    hash = hash * 57 + this.Tags.GetHashCode();
                
                if (this.SheetNameTransforms != null)
                    hash = hash * 57 + this.SheetNameTransforms.GetHashCode();
                
                if (this.Sheets != null)
                    hash = hash * 57 + this.Sheets.GetHashCode();
                
                if (this.ClientTransformModel != null)
                    hash = hash * 57 + this.ClientTransformModel.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
