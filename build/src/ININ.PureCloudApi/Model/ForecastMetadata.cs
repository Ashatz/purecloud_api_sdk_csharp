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
    /// ForecastMetadata
    /// </summary>
    [DataContract]
    public partial class ForecastMetadata :  IEquatable<ForecastMetadata>
    {
        /// <summary>
        /// The frequency of the period
        /// </summary>
        /// <value>The frequency of the period</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodFrequencyEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Week for "WEEK"
            /// </summary>
            [EnumMember(Value = "WEEK")]
            Week
        }
        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MetricsEnum
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
        /// The status of the creation of the forecast
        /// </summary>
        /// <value>The status of the creation of the forecast</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Success for "SUCCESS"
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            Success,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed
        }
        /// <summary>
        /// The frequency of the period
        /// </summary>
        /// <value>The frequency of the period</value>
        [DataMember(Name="periodFrequency", EmitDefaultValue=false)]
        public PeriodFrequencyEnum? PeriodFrequency { get; set; }
        /// <summary>
        /// The status of the creation of the forecast
        /// </summary>
        /// <value>The status of the creation of the forecast</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ForecastMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastMetadata" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="NumberOfPeriods">The number of periods to be forecasted for (required).</param>
        /// <param name="PeriodFrequency">The frequency of the period (required).</param>
        /// <param name="Description">The description of the forecast to be created (required).</param>
        /// <param name="Metrics">The metrics the forecast is for (required).</param>
        /// <param name="LastModifiedBy">The person who last modified this object.</param>
        public ForecastMetadata(string Name = null, int? NumberOfPeriods = null, PeriodFrequencyEnum? PeriodFrequency = null, string Description = null, List<MetricsEnum> Metrics = null, User LastModifiedBy = null)
        {
            // to ensure "NumberOfPeriods" is required (not null)
            if (NumberOfPeriods == null)
            {
                throw new InvalidDataException("NumberOfPeriods is a required property for ForecastMetadata and cannot be null");
            }
            else
            {
                this.NumberOfPeriods = NumberOfPeriods;
            }
            // to ensure "PeriodFrequency" is required (not null)
            if (PeriodFrequency == null)
            {
                throw new InvalidDataException("PeriodFrequency is a required property for ForecastMetadata and cannot be null");
            }
            else
            {
                this.PeriodFrequency = PeriodFrequency;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ForecastMetadata and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Metrics" is required (not null)
            if (Metrics == null)
            {
                throw new InvalidDataException("Metrics is a required property for ForecastMetadata and cannot be null");
            }
            else
            {
                this.Metrics = Metrics;
            }
            this.Name = Name;
            this.LastModifiedBy = LastModifiedBy;
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
        /// The number of periods to be forecasted for
        /// </summary>
        /// <value>The number of periods to be forecasted for</value>
        [DataMember(Name="numberOfPeriods", EmitDefaultValue=false)]
        public int? NumberOfPeriods { get; set; }
        /// <summary>
        /// The description of the forecast to be created
        /// </summary>
        /// <value>The description of the forecast to be created</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The metrics the forecast is for
        /// </summary>
        /// <value>The metrics the forecast is for</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<MetricsEnum> Metrics { get; set; }
        /// <summary>
        /// The last modified date time of this object. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The last modified date time of this object. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="lastModifiedDate", EmitDefaultValue=false)]
        public DateTime? LastModifiedDate { get; private set; }
        /// <summary>
        /// The person who last modified this object
        /// </summary>
        /// <value>The person who last modified this object</value>
        [DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
        public User LastModifiedBy { get; set; }
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
            sb.Append("class ForecastMetadata {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
            sb.Append("  PeriodFrequency: ").Append(PeriodFrequency).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as ForecastMetadata);
        }

        /// <summary>
        /// Returns true if ForecastMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastMetadata other)
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
                    this.NumberOfPeriods == other.NumberOfPeriods ||
                    this.NumberOfPeriods != null &&
                    this.NumberOfPeriods.Equals(other.NumberOfPeriods)
                ) &&
                (
                    this.PeriodFrequency == other.PeriodFrequency ||
                    this.PeriodFrequency != null &&
                    this.PeriodFrequency.Equals(other.PeriodFrequency)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.LastModifiedDate == other.LastModifiedDate ||
                    this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(other.LastModifiedDate)
                ) &&
                (
                    this.LastModifiedBy == other.LastModifiedBy ||
                    this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(other.LastModifiedBy)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.NumberOfPeriods != null)
                    hash = hash * 59 + this.NumberOfPeriods.GetHashCode();
                if (this.PeriodFrequency != null)
                    hash = hash * 59 + this.PeriodFrequency.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();
                if (this.LastModifiedDate != null)
                    hash = hash * 59 + this.LastModifiedDate.GetHashCode();
                if (this.LastModifiedBy != null)
                    hash = hash * 59 + this.LastModifiedBy.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
