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
    /// Details about a specific Flow Definition version.
    /// </summary>
    [DataContract]
    public class FlowVersionConfigMetaData :  IEquatable<FlowVersionConfigMetaData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowVersionConfigMetaData" /> class.
        /// </summary>
        public FlowVersionConfigMetaData()
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
        /// Checkin comment for this specific flow version.
        /// </summary>
        /// <value>Checkin comment for this specific flow version.</value>
        [DataMember(Name="versionSpecificComment", EmitDefaultValue=false)]
        public string VersionSpecificComment { get; set; }
  
        
        /// <summary>
        /// Uri location for the flow definition contents.
        /// </summary>
        /// <value>Uri location for the flow definition contents.</value>
        [DataMember(Name="flowDefinitionUri", EmitDefaultValue=false)]
        public string FlowDefinitionUri { get; set; }
  
        
        /// <summary>
        /// If known, the user who created this flow version.
        /// </summary>
        /// <value>If known, the user who created this flow version.</value>
        [DataMember(Name="createdByUser", EmitDefaultValue=false)]
        public User CreatedByUser { get; set; }
  
        
        /// <summary>
        /// The date and time that the version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date and time that the version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
        /// <summary>
        /// Version of this flow config.
        /// </summary>
        /// <value>Version of this flow config.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowVersionConfigMetaData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VersionSpecificComment: ").Append(VersionSpecificComment).Append("\n");
            sb.Append("  FlowDefinitionUri: ").Append(FlowDefinitionUri).Append("\n");
            sb.Append("  CreatedByUser: ").Append(CreatedByUser).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            
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
            return this.Equals(obj as FlowVersionConfigMetaData);
        }

        /// <summary>
        /// Returns true if FlowVersionConfigMetaData instances are equal
        /// </summary>
        /// <param name="obj">Instance of FlowVersionConfigMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowVersionConfigMetaData other)
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
                    this.VersionSpecificComment == other.VersionSpecificComment ||
                    this.VersionSpecificComment != null &&
                    this.VersionSpecificComment.Equals(other.VersionSpecificComment)
                ) && 
                (
                    this.FlowDefinitionUri == other.FlowDefinitionUri ||
                    this.FlowDefinitionUri != null &&
                    this.FlowDefinitionUri.Equals(other.FlowDefinitionUri)
                ) && 
                (
                    this.CreatedByUser == other.CreatedByUser ||
                    this.CreatedByUser != null &&
                    this.CreatedByUser.Equals(other.CreatedByUser)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                
                if (this.VersionSpecificComment != null)
                    hash = hash * 57 + this.VersionSpecificComment.GetHashCode();
                
                if (this.FlowDefinitionUri != null)
                    hash = hash * 57 + this.FlowDefinitionUri.GetHashCode();
                
                if (this.CreatedByUser != null)
                    hash = hash * 57 + this.CreatedByUser.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 57 + this.CreatedDate.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 57 + this.Version.GetHashCode();
                
                return hash;
            }
        }

    }


}
