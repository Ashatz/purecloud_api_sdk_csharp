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
    /// DncList
    /// </summary>
    [DataContract]
    public partial class DncList :  IEquatable<DncList>
    {
        /// <summary>
        /// the type of dnc list being created, rds (csv file), gryphon, or dnc.com
        /// </summary>
        /// <value>the type of dnc list being created, rds (csv file), gryphon, or dnc.com</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DncSourceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Rds for "RDS"
            /// </summary>
            [EnumMember(Value = "RDS")]
            Rds,
            
            /// <summary>
            /// Enum DncDotCom for "DNC_DOT_COM"
            /// </summary>
            [EnumMember(Value = "DNC_DOT_COM")]
            DncDotCom,
            
            /// <summary>
            /// Enum Gryphon for "GRYPHON"
            /// </summary>
            [EnumMember(Value = "GRYPHON")]
            Gryphon
        }
        /// <summary>
        /// the type of dnc list being created, rds (csv file), gryphon, or dnc.com
        /// </summary>
        /// <value>the type of dnc list being created, rds (csv file), gryphon, or dnc.com</value>
        [DataMember(Name="dncSourceType", EmitDefaultValue=false)]
        public DncSourceTypeEnum? DncSourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DncList" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        /// <param name="ImportStatus">the status of the import process.</param>
        /// <param name="DncCodes">the list of dnc.com codes to be treated as DNC.</param>
        public DncList(string Name = null, int? Version = null, ImportStatus ImportStatus = null, List<string> DncCodes = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.ImportStatus = ImportStatus;
            this.DncCodes = DncCodes;
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
        /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// the status of the import process
        /// </summary>
        /// <value>the status of the import process</value>
        [DataMember(Name="importStatus", EmitDefaultValue=false)]
        public ImportStatus ImportStatus { get; set; }
        /// <summary>
        /// the number of phone numbers in the do not call list
        /// </summary>
        /// <value>the number of phone numbers in the do not call list</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; private set; }
        /// <summary>
        /// the loginId if the dncSourceType is dnc.com
        /// </summary>
        /// <value>the loginId if the dncSourceType is dnc.com</value>
        [DataMember(Name="loginId", EmitDefaultValue=false)]
        public string LoginId { get; private set; }
        /// <summary>
        /// the list of dnc.com codes to be treated as DNC
        /// </summary>
        /// <value>the list of dnc.com codes to be treated as DNC</value>
        [DataMember(Name="dncCodes", EmitDefaultValue=false)]
        public List<string> DncCodes { get; set; }
        /// <summary>
        /// the license number if the dncSourceType is gryphon
        /// </summary>
        /// <value>the license number if the dncSourceType is gryphon</value>
        [DataMember(Name="licenseId", EmitDefaultValue=false)]
        public string LicenseId { get; private set; }
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
            sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  DncSourceType: ").Append(DncSourceType).Append("\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  DncCodes: ").Append(DncCodes).Append("\n");
            sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
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
                    this.ImportStatus == other.ImportStatus ||
                    this.ImportStatus != null &&
                    this.ImportStatus.Equals(other.ImportStatus)
                ) &&
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) &&
                (
                    this.DncSourceType == other.DncSourceType ||
                    this.DncSourceType != null &&
                    this.DncSourceType.Equals(other.DncSourceType)
                ) &&
                (
                    this.LoginId == other.LoginId ||
                    this.LoginId != null &&
                    this.LoginId.Equals(other.LoginId)
                ) &&
                (
                    this.DncCodes == other.DncCodes ||
                    this.DncCodes != null &&
                    this.DncCodes.SequenceEqual(other.DncCodes)
                ) &&
                (
                    this.LicenseId == other.LicenseId ||
                    this.LicenseId != null &&
                    this.LicenseId.Equals(other.LicenseId)
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
                if (this.ImportStatus != null)
                    hash = hash * 59 + this.ImportStatus.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.DncSourceType != null)
                    hash = hash * 59 + this.DncSourceType.GetHashCode();
                if (this.LoginId != null)
                    hash = hash * 59 + this.LoginId.GetHashCode();
                if (this.DncCodes != null)
                    hash = hash * 59 + this.DncCodes.GetHashCode();
                if (this.LicenseId != null)
                    hash = hash * 59 + this.LicenseId.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
