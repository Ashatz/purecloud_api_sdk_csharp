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
    public partial class ContactList :  IEquatable<ContactList>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactList" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Version">Version.</param>
        /// <param name="ColumnNames">ColumnNames.</param>
        /// <param name="PhoneColumns">PhoneColumns.</param>
        /// <param name="ImportStatus">ImportStatus.</param>
        /// <param name="PreviewModeColumnName">PreviewModeColumnName.</param>
        /// <param name="PreviewModeAcceptedValues">PreviewModeAcceptedValues.</param>
        /// <param name="Size">Size.</param>

<<<<<<< HEAD
        public ContactList(string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null, List<string> ColumnNames = null, List<PhoneNumberColumn> PhoneColumns = null, ImportStatus ImportStatus = null, string PreviewModeColumnName = null, List<string> PreviewModeAcceptedValues = null, long? Size = null)
=======
        public ContactList(string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null, List<string> ColumnNames = null, List<ContactPhoneNumberColumn> PhoneColumns = null, ImportStatus ImportStatus = null, string PreviewModeColumnName = null, List<string> PreviewModeAcceptedValues = null, long? Size = null)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        {
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            this.ColumnNames = ColumnNames;
            this.PhoneColumns = PhoneColumns;
            this.ImportStatus = ImportStatus;
            this.PreviewModeColumnName = PreviewModeColumnName;
            this.PreviewModeAcceptedValues = PreviewModeAcceptedValues;
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
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
    
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
    
        /// <summary>
        /// Gets or Sets ColumnNames
        /// </summary>
        [DataMember(Name="columnNames", EmitDefaultValue=false)]
        public List<string> ColumnNames { get; set; }
    
        /// <summary>
        /// Gets or Sets PhoneColumns
        /// </summary>
        [DataMember(Name="phoneColumns", EmitDefaultValue=false)]
<<<<<<< HEAD
        public List<PhoneNumberColumn> PhoneColumns { get; set; }
=======
        public List<ContactPhoneNumberColumn> PhoneColumns { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets ImportStatus
        /// </summary>
        [DataMember(Name="importStatus", EmitDefaultValue=false)]
        public ImportStatus ImportStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets PreviewModeColumnName
        /// </summary>
        [DataMember(Name="previewModeColumnName", EmitDefaultValue=false)]
        public string PreviewModeColumnName { get; set; }
    
        /// <summary>
        /// Gets or Sets PreviewModeAcceptedValues
        /// </summary>
        [DataMember(Name="previewModeAcceptedValues", EmitDefaultValue=false)]
        public List<string> PreviewModeAcceptedValues { get; set; }
    
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
            sb.Append("class ContactList {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
            sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
            sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
            sb.Append("  PreviewModeColumnName: ").Append(PreviewModeColumnName).Append("\n");
            sb.Append("  PreviewModeAcceptedValues: ").Append(PreviewModeAcceptedValues).Append("\n");
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
            return this.Equals(obj as ContactList);
        }

        /// <summary>
        /// Returns true if ContactList instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactList other)
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
                    this.ColumnNames == other.ColumnNames ||
                    this.ColumnNames != null &&
                    this.ColumnNames.SequenceEqual(other.ColumnNames)
                ) &&
                (
                    this.PhoneColumns == other.PhoneColumns ||
                    this.PhoneColumns != null &&
                    this.PhoneColumns.SequenceEqual(other.PhoneColumns)
                ) &&
                (
                    this.ImportStatus == other.ImportStatus ||
                    this.ImportStatus != null &&
                    this.ImportStatus.Equals(other.ImportStatus)
                ) &&
                (
                    this.PreviewModeColumnName == other.PreviewModeColumnName ||
                    this.PreviewModeColumnName != null &&
                    this.PreviewModeColumnName.Equals(other.PreviewModeColumnName)
                ) &&
                (
                    this.PreviewModeAcceptedValues == other.PreviewModeAcceptedValues ||
                    this.PreviewModeAcceptedValues != null &&
                    this.PreviewModeAcceptedValues.SequenceEqual(other.PreviewModeAcceptedValues)
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
                if (this.ColumnNames != null)
                    hash = hash * 59 + this.ColumnNames.GetHashCode();
                if (this.PhoneColumns != null)
                    hash = hash * 59 + this.PhoneColumns.GetHashCode();
                if (this.ImportStatus != null)
                    hash = hash * 59 + this.ImportStatus.GetHashCode();
                if (this.PreviewModeColumnName != null)
                    hash = hash * 59 + this.PreviewModeColumnName.GetHashCode();
                if (this.PreviewModeAcceptedValues != null)
                    hash = hash * 59 + this.PreviewModeAcceptedValues.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
