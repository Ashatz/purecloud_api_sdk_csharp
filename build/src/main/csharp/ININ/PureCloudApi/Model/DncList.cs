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
    public partial class DncList :  IEquatable<DncList>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DncList" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">required for updates, must match the version number of the most recent update.</param>
        /// <param name="PhoneNumberColumns">PhoneNumberColumns.</param>
        /// <param name="ImportStatus">ImportStatus.</param>
        /// <param name="FileKey">FileKey.</param>
        /// <param name="Size">Size.</param>

        public DncList(string Name = null, int? Version = null, List<string> PhoneNumberColumns = null, ImportStatus ImportStatus = null, string FileKey = null, long? Size = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.PhoneNumberColumns = PhoneNumberColumns;
            this.ImportStatus = ImportStatus;
            this.FileKey = FileKey;
            this.Size = Size;
            
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
        /// creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
    
        /// <summary>
        /// last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
    
        /// <summary>
        /// required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
    
        /// <summary>
        /// Gets or Sets PhoneNumberColumns
        /// </summary>
        [DataMember(Name="phoneNumberColumns", EmitDefaultValue=false)]
        public List<string> PhoneNumberColumns { get; set; }
    
        /// <summary>
        /// Gets or Sets ImportStatus
        /// </summary>
        [DataMember(Name="importStatus", EmitDefaultValue=false)]
        public ImportStatus ImportStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets FileKey
        /// </summary>
        [DataMember(Name="fileKey", EmitDefaultValue=false)]
        public string FileKey { get; set; }
    
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }
    
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
            sb.Append("class DncList {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  PhoneNumberColumns: ").Append(PhoneNumberColumns).Append("\n");
            sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
            sb.Append("  FileKey: ").Append(FileKey).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(obj as DncList);
        }

        /// <summary>
        /// Returns true if DncList instances are equal
        /// </summary>
        /// <param name="other">Instance of DncList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DncList other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.PhoneNumberColumns == other.PhoneNumberColumns ||
                    this.PhoneNumberColumns != null &&
                    this.PhoneNumberColumns.SequenceEqual(other.PhoneNumberColumns)
                ) &&
                (
                    this.ImportStatus == other.ImportStatus ||
                    this.ImportStatus != null &&
                    this.ImportStatus.Equals(other.ImportStatus)
                ) &&
                (
                    this.FileKey == other.FileKey ||
                    this.FileKey != null &&
                    this.FileKey.Equals(other.FileKey)
                ) &&
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
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
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.PhoneNumberColumns != null)
                    hash = hash * 59 + this.PhoneNumberColumns.GetHashCode();
                if (this.ImportStatus != null)
                    hash = hash * 59 + this.ImportStatus.GetHashCode();
                if (this.FileKey != null)
                    hash = hash * 59 + this.FileKey.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
