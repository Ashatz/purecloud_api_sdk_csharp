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
    public class Workspace :  IEquatable<Workspace>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Workspace" /> class.
        /// </summary>
        public Workspace()
        {
            this.IsCurrentUserWorkspace = false;
            
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
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IsCurrentUserWorkspace
        /// </summary>
        [DataMember(Name="isCurrentUserWorkspace", EmitDefaultValue=false)]
        public bool? IsCurrentUserWorkspace { get; set; }
  
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UriReference User { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Bucket
        /// </summary>
        [DataMember(Name="bucket", EmitDefaultValue=false)]
        public string Bucket { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public WorkspaceSummary Summary { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Acl
        /// </summary>
        [DataMember(Name="acl", EmitDefaultValue=false)]
        public List<string> Acl { get; set; }
  
        
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
            sb.Append("class Workspace {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsCurrentUserWorkspace: ").Append(IsCurrentUserWorkspace).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Acl: ").Append(Acl).Append("\n");
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
            return this.Equals(obj as Workspace);
        }

        /// <summary>
        /// Returns true if Workspace instances are equal
        /// </summary>
        /// <param name="obj">Instance of Workspace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Workspace other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.IsCurrentUserWorkspace == other.IsCurrentUserWorkspace ||
                    this.IsCurrentUserWorkspace != null &&
                    this.IsCurrentUserWorkspace.Equals(other.IsCurrentUserWorkspace)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Bucket == other.Bucket ||
                    this.Bucket != null &&
                    this.Bucket.Equals(other.Bucket)
                ) && 
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) && 
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) && 
                (
                    this.Summary == other.Summary ||
                    this.Summary != null &&
                    this.Summary.Equals(other.Summary)
                ) && 
                (
                    this.Acl == other.Acl ||
                    this.Acl != null &&
                    this.Acl.SequenceEqual(other.Acl)
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
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.IsCurrentUserWorkspace != null)
                    hash = hash * 57 + this.IsCurrentUserWorkspace.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 57 + this.User.GetHashCode();
                
                if (this.Bucket != null)
                    hash = hash * 57 + this.Bucket.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 57 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 57 + this.DateModified.GetHashCode();
                
                if (this.Summary != null)
                    hash = hash * 57 + this.Summary.GetHashCode();
                
                if (this.Acl != null)
                    hash = hash * 57 + this.Acl.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
