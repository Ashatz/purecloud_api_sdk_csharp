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
    /// ForecastModificationCreation
    /// </summary>
    [DataContract]
    public partial class ForecastModificationCreation :  IEquatable<ForecastModificationCreation>
    {
        /// <summary>
        /// The metric the modification is appied to
        /// </summary>
        /// <value>The metric the modification is appied to</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MetricEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum CallVolume for "CALL_VOLUME"
            /// </summary>
            [EnumMember(Value = "CALL_VOLUME")]
            CallVolume,
            
            /// <summary>
            /// Enum Att for "ATT"
            /// </summary>
            [EnumMember(Value = "ATT")]
            Att,
            
            /// <summary>
            /// Enum Acw for "ACW"
            /// </summary>
            [EnumMember(Value = "ACW")]
            Acw,
            
            /// <summary>
            /// Enum ChatVolume for "CHAT_VOLUME"
            /// </summary>
            [EnumMember(Value = "CHAT_VOLUME")]
            ChatVolume
        }
        /// <summary>
        /// The type of modification
        /// </summary>
        /// <value>The type of modification</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModificationTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum MinimumPerInterval for "MINIMUM_PER_INTERVAL"
            /// </summary>
            [EnumMember(Value = "MINIMUM_PER_INTERVAL")]
            MinimumPerInterval,
            
            /// <summary>
            /// Enum MaximumPerInterval for "MAXIMUM_PER_INTERVAL"
            /// </summary>
            [EnumMember(Value = "MAXIMUM_PER_INTERVAL")]
            MaximumPerInterval,
            
            /// <summary>
            /// Enum SetValuePerInterval for "SET_VALUE_PER_INTERVAL"
            /// </summary>
            [EnumMember(Value = "SET_VALUE_PER_INTERVAL")]
            SetValuePerInterval,
            
            /// <summary>
            /// Enum ChangeValuePerInterval for "CHANGE_VALUE_PER_INTERVAL"
            /// </summary>
            [EnumMember(Value = "CHANGE_VALUE_PER_INTERVAL")]
            ChangeValuePerInterval,
            
            /// <summary>
            /// Enum ChangePercentPerInterval for "CHANGE_PERCENT_PER_INTERVAL"
            /// </summary>
            [EnumMember(Value = "CHANGE_PERCENT_PER_INTERVAL")]
            ChangePercentPerInterval,
            
            /// <summary>
            /// Enum SetValueOverRange for "SET_VALUE_OVER_RANGE"
            /// </summary>
            [EnumMember(Value = "SET_VALUE_OVER_RANGE")]
            SetValueOverRange,
            
            /// <summary>
            /// Enum ChangeValueOverRange for "CHANGE_VALUE_OVER_RANGE"
            /// </summary>
            [EnumMember(Value = "CHANGE_VALUE_OVER_RANGE")]
            ChangeValueOverRange
        }
        /// <summary>
        /// The metric the modification is appied to
        /// </summary>
        /// <value>The metric the modification is appied to</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
        /// <summary>
        /// The type of modification
        /// </summary>
        /// <value>The type of modification</value>
        [DataMember(Name="modificationType", EmitDefaultValue=false)]
        public ModificationTypeEnum? ModificationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastModificationCreation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ForecastModificationCreation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastModificationCreation" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ForecastId">The id of the associated forecast (required).</param>
        /// <param name="Priority">The priority in which the modification is applied (required).</param>
        /// <param name="Metric">The metric the modification is appied to (required).</param>
        /// <param name="ModificationType">The type of modification (required).</param>
        /// <param name="ModificationValue">The value of the modification (required).</param>
        /// <param name="StartDate">The start of the modified time period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (required).</param>
        /// <param name="EndDate">The end of the modified time period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (required).</param>
        /// <param name="Attributes">The filters for the modification (required).</param>
        /// <param name="Enabled">Determined if the modification is currently applied (required) (default to false).</param>
        /// <param name="Notes">Any notes associated with the modification (required).</param>
        public ForecastModificationCreation(string Name = null, string ForecastId = null, int? Priority = null, MetricEnum? Metric = null, ModificationTypeEnum? ModificationType = null, double? ModificationValue = null, DateTime? StartDate = null, DateTime? EndDate = null, ForecastFilterAttributes Attributes = null, bool? Enabled = null, string Notes = null)
        {
            // to ensure "ForecastId" is required (not null)
            if (ForecastId == null)
            {
                throw new InvalidDataException("ForecastId is a required property for ForecastModificationCreation and cannot be null");
            }
            else
            {
                this.ForecastId = ForecastId;
            }
            // to ensure "Priority" is required (not null)
            if (Priority == null)
            {
                throw new InvalidDataException("Priority is a required property for ForecastModificationCreation and cannot be null");
            }
            else
            {
                this.Priority = Priority;
            }
            // to ensure "Metric" is required (not null)
            if (Metric == null)
            {
                throw new InvalidDataException("Metric is a required property for ForecastModificationCreation and cannot be null");
            }
            else
            {
                this.Metric = Metric;
            }
            // to ensure "ModificationType" is required (not null)
            if (ModificationType == null)
            {
                throw new InvalidDataException("ModificationType is a required property for ForecastModificationCreation and cannot be null");
            }
            else
            {
                this.ModificationType = ModificationType;
            }
            // to ensure "ModificationValue" is required (not null)
            if (ModificationValue == null)
            {
                throw new InvalidDataException("ModificationValue is a required property for ForecastModificationCreation and cannot be null");
            }
            else
            {
                this.ModificationValue = ModificationValue;
            }
            // to ensure "StartDate" is required (not null)
            if (StartDate == null)
            {
                throw new InvalidDataException("StartDate is a required property for ForecastModificationCreation and cannot be null");
            }
            else
            {
                this.StartDate = StartDate;
            }
            // to ensure "EndDate" is required (not null)
            if (EndDate == null)
            {
                throw new InvalidDataException("EndDate is a required property for ForecastModificationCreation and cannot be null");
            }
            else
            {
                this.EndDate = EndDate;
            }
            // to ensure "Attributes" is required (not null)
            if (Attributes == null)
            {
                throw new InvalidDataException("Attributes is a required property for ForecastModificationCreation and cannot be null");
            }
            else
            {
                this.Attributes = Attributes;
            }
            // to ensure "Enabled" is required (not null)
            if (Enabled == null)
            {
                throw new InvalidDataException("Enabled is a required property for ForecastModificationCreation and cannot be null");
            }
            else
            {
                this.Enabled = Enabled;
            }
            // to ensure "Notes" is required (not null)
            if (Notes == null)
            {
                throw new InvalidDataException("Notes is a required property for ForecastModificationCreation and cannot be null");
            }
            else
            {
                this.Notes = Notes;
            }
            this.Name = Name;
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
        /// The id of the associated forecast
        /// </summary>
        /// <value>The id of the associated forecast</value>
        [DataMember(Name="forecastId", EmitDefaultValue=false)]
        public string ForecastId { get; set; }
        /// <summary>
        /// The priority in which the modification is applied
        /// </summary>
        /// <value>The priority in which the modification is applied</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }
        /// <summary>
        /// The value of the modification
        /// </summary>
        /// <value>The value of the modification</value>
        [DataMember(Name="modificationValue", EmitDefaultValue=false)]
        public double? ModificationValue { get; set; }
        /// <summary>
        /// The start of the modified time period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The start of the modified time period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// The end of the modified time period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The end of the modified time period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// The filters for the modification
        /// </summary>
        /// <value>The filters for the modification</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public ForecastFilterAttributes Attributes { get; set; }
        /// <summary>
        /// Determined if the modification is currently applied
        /// </summary>
        /// <value>Determined if the modification is currently applied</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Any notes associated with the modification
        /// </summary>
        /// <value>Any notes associated with the modification</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
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
            sb.Append("class ForecastModificationCreation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ForecastId: ").Append(ForecastId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  ModificationType: ").Append(ModificationType).Append("\n");
            sb.Append("  ModificationValue: ").Append(ModificationValue).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(obj as ForecastModificationCreation);
        }

        /// <summary>
        /// Returns true if ForecastModificationCreation instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastModificationCreation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastModificationCreation other)
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
                    this.ForecastId == other.ForecastId ||
                    this.ForecastId != null &&
                    this.ForecastId.Equals(other.ForecastId)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.ModificationType == other.ModificationType ||
                    this.ModificationType != null &&
                    this.ModificationType.Equals(other.ModificationType)
                ) &&
                (
                    this.ModificationValue == other.ModificationValue ||
                    this.ModificationValue != null &&
                    this.ModificationValue.Equals(other.ModificationValue)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.Equals(other.Attributes)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
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
                if (this.ForecastId != null)
                    hash = hash * 59 + this.ForecastId.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();
                if (this.ModificationType != null)
                    hash = hash * 59 + this.ModificationType.GetHashCode();
                if (this.ModificationValue != null)
                    hash = hash * 59 + this.ModificationValue.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
