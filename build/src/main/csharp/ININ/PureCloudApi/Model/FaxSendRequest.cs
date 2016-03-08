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
    public partial class FaxSendRequest :  IEquatable<FaxSendRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaxSendRequest" /> class.
        /// Initializes a new instance of the <see cref="FaxSendRequest" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Addresses">Addresses.</param>
        /// <param name="OriginalFilename">OriginalFilename.</param>
        /// <param name="ContentType">ContentType.</param>
        /// <param name="Workspace">Workspace.</param>
        /// <param name="CoverSheet">CoverSheet.</param>

        public FaxSendRequest(string Name = null, List<string> Addresses = null, string OriginalFilename = null, string ContentType = null, Workspace Workspace = null, CoverSheet CoverSheet = null, )
        {
            this.Name = Name;
            this.Addresses = Addresses;
            this.OriginalFilename = OriginalFilename;
            this.ContentType = ContentType;
            this.Workspace = Workspace;
            this.CoverSheet = CoverSheet;
            
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
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<string> Addresses { get; set; }
    
        /// <summary>
        /// Gets or Sets OriginalFilename
        /// </summary>
        [DataMember(Name="originalFilename", EmitDefaultValue=false)]
        public string OriginalFilename { get; set; }
    
        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
    
        /// <summary>
        /// Gets or Sets Workspace
        /// </summary>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public Workspace Workspace { get; set; }
    
        /// <summary>
        /// Gets or Sets CoverSheet
        /// </summary>
        [DataMember(Name="coverSheet", EmitDefaultValue=false)]
        public CoverSheet CoverSheet { get; set; }
    
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
            sb.Append("class FaxSendRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  OriginalFilename: ").Append(OriginalFilename).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  CoverSheet: ").Append(CoverSheet).Append("\n");
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
            return this.Equals(obj as FaxSendRequest);
        }

        /// <summary>
        /// Returns true if FaxSendRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FaxSendRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaxSendRequest other)
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
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) && 
                (
                    this.OriginalFilename == other.OriginalFilename ||
                    this.OriginalFilename != null &&
                    this.OriginalFilename.Equals(other.OriginalFilename)
                ) && 
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) && 
                (
                    this.Workspace == other.Workspace ||
                    this.Workspace != null &&
                    this.Workspace.Equals(other.Workspace)
                ) && 
                (
                    this.CoverSheet == other.CoverSheet ||
                    this.CoverSheet != null &&
                    this.CoverSheet.Equals(other.CoverSheet)
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
                
                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                
                if (this.OriginalFilename != null)
                    hash = hash * 59 + this.OriginalFilename.GetHashCode();
                
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                
                if (this.Workspace != null)
                    hash = hash * 59 + this.Workspace.GetHashCode();
                
                if (this.CoverSheet != null)
                    hash = hash * 59 + this.CoverSheet.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
