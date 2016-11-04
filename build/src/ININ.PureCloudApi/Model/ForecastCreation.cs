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
    /// ForecastCreation
    /// </summary>
    [DataContract]
    public partial class ForecastCreation :  IEquatable<ForecastCreation>
    {
        /// <summary>
        /// The frequency of the period
        /// </summary>
        /// <value>The frequency of the period</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
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
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
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
        /// The frequency of the period
        /// </summary>
        /// <value>The frequency of the period</value>
        [DataMember(Name="periodFrequency", EmitDefaultValue=false)]
        public PeriodFrequencyEnum? PeriodFrequency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastCreation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ForecastCreation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastCreation" /> class.
        /// </summary>
        /// <param name="NumberOfPeriods">The number of periods to be forecasted for (required).</param>
        /// <param name="PeriodFrequency">The frequency of the period (required).</param>
        /// <param name="Description">The description of the forecast to be created (required).</param>
        /// <param name="Metrics">The metrics the forecast is for (required).</param>
        /// <param name="ManagementUnitId">The id of the management unit to which the new forecast belongs.</param>
        public ForecastCreation(int? NumberOfPeriods = null, PeriodFrequencyEnum? PeriodFrequency = null, string Description = null, List<MetricsEnum> Metrics = null, string ManagementUnitId = null)
        {
            // to ensure "NumberOfPeriods" is required (not null)
            if (NumberOfPeriods == null)
            {
                throw new InvalidDataException("NumberOfPeriods is a required property for ForecastCreation and cannot be null");
            }
            else
            {
                this.NumberOfPeriods = NumberOfPeriods;
            }
            // to ensure "PeriodFrequency" is required (not null)
            if (PeriodFrequency == null)
            {
                throw new InvalidDataException("PeriodFrequency is a required property for ForecastCreation and cannot be null");
            }
            else
            {
                this.PeriodFrequency = PeriodFrequency;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ForecastCreation and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Metrics" is required (not null)
            if (Metrics == null)
            {
                throw new InvalidDataException("Metrics is a required property for ForecastCreation and cannot be null");
            }
            else
            {
                this.Metrics = Metrics;
            }
            this.ManagementUnitId = ManagementUnitId;
        }
        
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
        /// The id of the management unit to which the new forecast belongs
        /// </summary>
        /// <value>The id of the management unit to which the new forecast belongs</value>
        [DataMember(Name="managementUnitId", EmitDefaultValue=false)]
        public string ManagementUnitId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastCreation {\n");
            sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
            sb.Append("  PeriodFrequency: ").Append(PeriodFrequency).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
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
            return this.Equals(obj as ForecastCreation);
        }

        /// <summary>
        /// Returns true if ForecastCreation instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastCreation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastCreation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.ManagementUnitId == other.ManagementUnitId ||
                    this.ManagementUnitId != null &&
                    this.ManagementUnitId.Equals(other.ManagementUnitId)
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
                if (this.NumberOfPeriods != null)
                    hash = hash * 59 + this.NumberOfPeriods.GetHashCode();
                if (this.PeriodFrequency != null)
                    hash = hash * 59 + this.PeriodFrequency.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();
                if (this.ManagementUnitId != null)
                    hash = hash * 59 + this.ManagementUnitId.GetHashCode();
                return hash;
            }
        }
    }

}
