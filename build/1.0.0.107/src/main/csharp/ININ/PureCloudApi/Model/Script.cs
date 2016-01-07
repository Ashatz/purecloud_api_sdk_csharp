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
    public class Script :  IEquatable<Script>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Script" /> class.
        /// </summary>
        public Script()
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
        /// Gets or Sets VersionId
        /// </summary>
        [DataMember(Name="versionId", EmitDefaultValue=false)]
        public string VersionId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PublishedDate
        /// </summary>
        [DataMember(Name="publishedDate", EmitDefaultValue=false)]
        public DateTime? PublishedDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets VersionDate
        /// </summary>
        [DataMember(Name="versionDate", EmitDefaultValue=false)]
        public DateTime? VersionDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets StartPageId
        /// </summary>
        [DataMember(Name="startPageId", EmitDefaultValue=false)]
        public string StartPageId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets StartPageName
        /// </summary>
        [DataMember(Name="startPageName", EmitDefaultValue=false)]
        public string StartPageName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public Object Features { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public Object Variables { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CustomActions
        /// </summary>
        [DataMember(Name="customActions", EmitDefaultValue=false)]
        public Object CustomActions { get; set; }
  
        
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
            sb.Append("class Script {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  PublishedDate: ").Append(PublishedDate).Append("\n");
            sb.Append("  VersionDate: ").Append(VersionDate).Append("\n");
            sb.Append("  StartPageId: ").Append(StartPageId).Append("\n");
            sb.Append("  StartPageName: ").Append(StartPageName).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  CustomActions: ").Append(CustomActions).Append("\n");
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
            return this.Equals(obj as Script);
        }

        /// <summary>
        /// Returns true if Script instances are equal
        /// </summary>
        /// <param name="obj">Instance of Script to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Script other)
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
                    this.VersionId == other.VersionId ||
                    this.VersionId != null &&
                    this.VersionId.Equals(other.VersionId)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) && 
                (
                    this.PublishedDate == other.PublishedDate ||
                    this.PublishedDate != null &&
                    this.PublishedDate.Equals(other.PublishedDate)
                ) && 
                (
                    this.VersionDate == other.VersionDate ||
                    this.VersionDate != null &&
                    this.VersionDate.Equals(other.VersionDate)
                ) && 
                (
                    this.StartPageId == other.StartPageId ||
                    this.StartPageId != null &&
                    this.StartPageId.Equals(other.StartPageId)
                ) && 
                (
                    this.StartPageName == other.StartPageName ||
                    this.StartPageName != null &&
                    this.StartPageName.Equals(other.StartPageName)
                ) && 
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.Equals(other.Features)
                ) && 
                (
                    this.Variables == other.Variables ||
                    this.Variables != null &&
                    this.Variables.Equals(other.Variables)
                ) && 
                (
                    this.CustomActions == other.CustomActions ||
                    this.CustomActions != null &&
                    this.CustomActions.Equals(other.CustomActions)
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
                
                if (this.VersionId != null)
                    hash = hash * 57 + this.VersionId.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 57 + this.CreatedDate.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 57 + this.ModifiedDate.GetHashCode();
                
                if (this.PublishedDate != null)
                    hash = hash * 57 + this.PublishedDate.GetHashCode();
                
                if (this.VersionDate != null)
                    hash = hash * 57 + this.VersionDate.GetHashCode();
                
                if (this.StartPageId != null)
                    hash = hash * 57 + this.StartPageId.GetHashCode();
                
                if (this.StartPageName != null)
                    hash = hash * 57 + this.StartPageName.GetHashCode();
                
                if (this.Features != null)
                    hash = hash * 57 + this.Features.GetHashCode();
                
                if (this.Variables != null)
                    hash = hash * 57 + this.Variables.GetHashCode();
                
                if (this.CustomActions != null)
                    hash = hash * 57 + this.CustomActions.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}