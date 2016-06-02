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
    /// UploadProgress
    /// </summary>
    [DataContract]
    public partial class UploadProgress :  IEquatable<UploadProgress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProgress" /> class.
        /// </summary>
        public UploadProgress()
        {
        }
        
        /// <summary>
        /// Carrier id associated with the ratesheet that was uploaded.
        /// </summary>
        /// <value>Carrier id associated with the ratesheet that was uploaded.</value>
        [DataMember(Name="CarrierId", EmitDefaultValue=false)]
        public string CarrierId { get; private set; }
        /// <summary>
        /// Human readable name for the schema that was used to parse the ratesheet.
        /// </summary>
        /// <value>Human readable name for the schema that was used to parse the ratesheet.</value>
        [DataMember(Name="SchemaName", EmitDefaultValue=false)]
        public string SchemaName { get; private set; }
        /// <summary>
        /// Human readable status for progress of the ratesheet upload. This may be an error, the number of rates upload, or a completion message.
        /// </summary>
        /// <value>Human readable status for progress of the ratesheet upload. This may be an error, the number of rates upload, or a completion message.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; private set; }
        /// <summary>
        /// Filename of the ratesheet that was uploaded by the user.
        /// </summary>
        /// <value>Filename of the ratesheet that was uploaded by the user.</value>
        [DataMember(Name="Filename", EmitDefaultValue=false)]
        public string Filename { get; private set; }
        /// <summary>
        /// Media type of the file.
        /// </summary>
        /// <value>Media type of the file.</value>
        [DataMember(Name="Filetype", EmitDefaultValue=false)]
        public string Filetype { get; private set; }
        /// <summary>
        /// Time at which the uploaded ratesheet was started to be parsed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Time at which the uploaded ratesheet was started to be parsed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="Created", EmitDefaultValue=false)]
        public DateTime? Created { get; private set; }
        /// <summary>
        /// Time at which the progress of the upload was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Time at which the progress of the upload was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="Updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadProgress {\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            sb.Append("  SchemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Filetype: ").Append(Filetype).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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
            return this.Equals(obj as UploadProgress);
        }

        /// <summary>
        /// Returns true if UploadProgress instances are equal
        /// </summary>
        /// <param name="other">Instance of UploadProgress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadProgress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CarrierId == other.CarrierId ||
                    this.CarrierId != null &&
                    this.CarrierId.Equals(other.CarrierId)
                ) &&
                (
                    this.SchemaName == other.SchemaName ||
                    this.SchemaName != null &&
                    this.SchemaName.Equals(other.SchemaName)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Filename == other.Filename ||
                    this.Filename != null &&
                    this.Filename.Equals(other.Filename)
                ) &&
                (
                    this.Filetype == other.Filetype ||
                    this.Filetype != null &&
                    this.Filetype.Equals(other.Filetype)
                ) &&
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) &&
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
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
                if (this.CarrierId != null)
                    hash = hash * 59 + this.CarrierId.GetHashCode();
                if (this.SchemaName != null)
                    hash = hash * 59 + this.SchemaName.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Filename != null)
                    hash = hash * 59 + this.Filename.GetHashCode();
                if (this.Filetype != null)
                    hash = hash * 59 + this.Filetype.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                return hash;
            }
        }
    }

}
