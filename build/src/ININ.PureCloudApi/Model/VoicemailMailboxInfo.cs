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
using ININ.PureCloudApi.Client;

namespace ININ.PureCloudApi.Model
{
    /// <summary>
    /// VoicemailMailboxInfo
    /// </summary>
    [DataContract]
    public partial class VoicemailMailboxInfo :  IEquatable<VoicemailMailboxInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailMailboxInfo" /> class.
        /// </summary>
        /// <param name="UsageSizeBytes">UsageSizeBytes.</param>
        /// <param name="TotalCount">TotalCount.</param>
        /// <param name="UnreadCount">UnreadCount.</param>
        /// <param name="VoicemailPolicy">VoicemailPolicy.</param>
        /// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public VoicemailMailboxInfo(long? UsageSizeBytes = null, int? TotalCount = null, int? UnreadCount = null, VoicemailUserPolicy VoicemailPolicy = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null)
        {
            this.UsageSizeBytes = UsageSizeBytes;
            this.TotalCount = TotalCount;
            this.UnreadCount = UnreadCount;
            this.VoicemailPolicy = VoicemailPolicy;
            this.CreatedDate = CreatedDate;
            this.ModifiedDate = ModifiedDate;
        }
        
        /// <summary>
        /// Gets or Sets UsageSizeBytes
        /// </summary>
        [DataMember(Name="usageSizeBytes", EmitDefaultValue=false)]
        public long? UsageSizeBytes { get; set; }
        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }
        /// <summary>
        /// Gets or Sets UnreadCount
        /// </summary>
        [DataMember(Name="unreadCount", EmitDefaultValue=false)]
        public int? UnreadCount { get; set; }
        /// <summary>
        /// Gets or Sets VoicemailPolicy
        /// </summary>
        [DataMember(Name="voicemailPolicy", EmitDefaultValue=false)]
        public VoicemailUserPolicy VoicemailPolicy { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicemailMailboxInfo {\n");
            sb.Append("  UsageSizeBytes: ").Append(UsageSizeBytes).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  UnreadCount: ").Append(UnreadCount).Append("\n");
            sb.Append("  VoicemailPolicy: ").Append(VoicemailPolicy).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(obj as VoicemailMailboxInfo);
        }

        /// <summary>
        /// Returns true if VoicemailMailboxInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailMailboxInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailMailboxInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UsageSizeBytes == other.UsageSizeBytes ||
                    this.UsageSizeBytes != null &&
                    this.UsageSizeBytes.Equals(other.UsageSizeBytes)
                ) &&
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
                ) &&
                (
                    this.UnreadCount == other.UnreadCount ||
                    this.UnreadCount != null &&
                    this.UnreadCount.Equals(other.UnreadCount)
                ) &&
                (
                    this.VoicemailPolicy == other.VoicemailPolicy ||
                    this.VoicemailPolicy != null &&
                    this.VoicemailPolicy.Equals(other.VoicemailPolicy)
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
                if (this.UsageSizeBytes != null)
                    hash = hash * 59 + this.UsageSizeBytes.GetHashCode();
                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();
                if (this.UnreadCount != null)
                    hash = hash * 59 + this.UnreadCount.GetHashCode();
                if (this.VoicemailPolicy != null)
                    hash = hash * 59 + this.VoicemailPolicy.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                return hash;
            }
        }
    }

}
