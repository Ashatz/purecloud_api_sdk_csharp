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
    /// BillingTaskResult
    /// </summary>
    [DataContract]
    public partial class BillingTaskResult :  IEquatable<BillingTaskResult>
    {
        /// <summary>
        /// Gets or Sets TaskType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaskTypeEnum
        {
            
            /// <summary>
            /// Enum GeneratePcvUsageReport for "GENERATE_PCV_USAGE_REPORT"
            /// </summary>
            [EnumMember(Value = "GENERATE_PCV_USAGE_REPORT")]
            GeneratePcvUsageReport,
            
            /// <summary>
            /// Enum GenerateBillableUsageReport for "GENERATE_BILLABLE_USAGE_REPORT"
            /// </summary>
            [EnumMember(Value = "GENERATE_BILLABLE_USAGE_REPORT")]
            GenerateBillableUsageReport,
            
            /// <summary>
            /// Enum GenerateConcurrentUsageReport for "GENERATE_CONCURRENT_USAGE_REPORT"
            /// </summary>
            [EnumMember(Value = "GENERATE_CONCURRENT_USAGE_REPORT")]
            GenerateConcurrentUsageReport,
            
            /// <summary>
            /// Enum CreateQuote for "CREATE_QUOTE"
            /// </summary>
            [EnumMember(Value = "CREATE_QUOTE")]
            CreateQuote,
            
            /// <summary>
            /// Enum CreateSalesforceAccount for "CREATE_SALESFORCE_ACCOUNT"
            /// </summary>
            [EnumMember(Value = "CREATE_SALESFORCE_ACCOUNT")]
            CreateSalesforceAccount,
            
            /// <summary>
            /// Enum SubmitQuote for "SUBMIT_QUOTE"
            /// </summary>
            [EnumMember(Value = "SUBMIT_QUOTE")]
            SubmitQuote,
            
            /// <summary>
            /// Enum GenerateContract for "GENERATE_CONTRACT"
            /// </summary>
            [EnumMember(Value = "GENERATE_CONTRACT")]
            GenerateContract,
            
            /// <summary>
            /// Enum Other for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            Other
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum InProgress for "IN_PROGRESS"
            /// </summary>
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            
            /// <summary>
            /// Enum Succeeded for "SUCCEEDED"
            /// </summary>
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed
        }

        /// <summary>
        /// Gets or Sets TaskType
        /// </summary>
        [DataMember(Name="taskType", EmitDefaultValue=false)]
        public TaskTypeEnum? TaskType { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingTaskResult" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="TaskType">TaskType.</param>
        /// <param name="Status">Status.</param>
        /// <param name="ResultId">ResultId.</param>
        /// <param name="ResultUri">ResultUri.</param>
        /// <param name="ResultDownloadUrl">ResultDownloadUrl.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        public BillingTaskResult(string Name = null, TaskTypeEnum? TaskType = null, StatusEnum? Status = null, string ResultId = null, string ResultUri = null, string ResultDownloadUrl = null, string ErrorCode = null)
        {
            this.Name = Name;
            this.TaskType = TaskType;
            this.Status = Status;
            this.ResultId = ResultId;
            this.ResultUri = ResultUri;
            this.ResultDownloadUrl = ResultDownloadUrl;
            this.ErrorCode = ErrorCode;
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
        /// Gets or Sets ResultId
        /// </summary>
        [DataMember(Name="resultId", EmitDefaultValue=false)]
        public string ResultId { get; set; }
        /// <summary>
        /// Gets or Sets ResultUri
        /// </summary>
        [DataMember(Name="resultUri", EmitDefaultValue=false)]
        public string ResultUri { get; set; }
        /// <summary>
        /// Gets or Sets ResultDownloadUrl
        /// </summary>
        [DataMember(Name="resultDownloadUrl", EmitDefaultValue=false)]
        public string ResultDownloadUrl { get; set; }
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }
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
            sb.Append("class BillingTaskResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TaskType: ").Append(TaskType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ResultId: ").Append(ResultId).Append("\n");
            sb.Append("  ResultUri: ").Append(ResultUri).Append("\n");
            sb.Append("  ResultDownloadUrl: ").Append(ResultDownloadUrl).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
            return this.Equals(obj as BillingTaskResult);
        }

        /// <summary>
        /// Returns true if BillingTaskResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingTaskResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingTaskResult other)
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
                    this.TaskType == other.TaskType ||
                    this.TaskType != null &&
                    this.TaskType.Equals(other.TaskType)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ResultId == other.ResultId ||
                    this.ResultId != null &&
                    this.ResultId.Equals(other.ResultId)
                ) &&
                (
                    this.ResultUri == other.ResultUri ||
                    this.ResultUri != null &&
                    this.ResultUri.Equals(other.ResultUri)
                ) &&
                (
                    this.ResultDownloadUrl == other.ResultDownloadUrl ||
                    this.ResultDownloadUrl != null &&
                    this.ResultDownloadUrl.Equals(other.ResultDownloadUrl)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
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
                if (this.TaskType != null)
                    hash = hash * 59 + this.TaskType.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ResultId != null)
                    hash = hash * 59 + this.ResultId.GetHashCode();
                if (this.ResultUri != null)
                    hash = hash * 59 + this.ResultUri.GetHashCode();
                if (this.ResultDownloadUrl != null)
                    hash = hash * 59 + this.ResultDownloadUrl.GetHashCode();
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
