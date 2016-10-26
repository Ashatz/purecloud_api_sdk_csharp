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
    /// Forecast
    /// </summary>
    [DataContract]
    public partial class Forecast :  IEquatable<Forecast>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Forecast" /> class.
        /// </summary>
        /// <param name="Metadata">The metadata of the forecast.</param>
        /// <param name="ForecastEntries">The entries of forecasted values and their dimensions.</param>
        public Forecast(ForecastMetadata Metadata = null, List<ForecastEntry> ForecastEntries = null)
        {
            this.Metadata = Metadata;
            this.ForecastEntries = ForecastEntries;
        }
        
        /// <summary>
        /// The metadata of the forecast
        /// </summary>
        /// <value>The metadata of the forecast</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ForecastMetadata Metadata { get; set; }
        /// <summary>
        /// The start date time of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The start date time of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; private set; }
        /// <summary>
        /// The entries of forecasted values and their dimensions
        /// </summary>
        /// <value>The entries of forecasted values and their dimensions</value>
        [DataMember(Name="forecastEntries", EmitDefaultValue=false)]
        public List<ForecastEntry> ForecastEntries { get; set; }
        /// <summary>
        /// The error happening when producing the forecasts
        /// </summary>
        /// <value>The error happening when producing the forecasts</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Forecast {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ForecastEntries: ").Append(ForecastEntries).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(obj as Forecast);
        }

        /// <summary>
        /// Returns true if Forecast instances are equal
        /// </summary>
        /// <param name="other">Instance of Forecast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Forecast other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.ForecastEntries == other.ForecastEntries ||
                    this.ForecastEntries != null &&
                    this.ForecastEntries.SequenceEqual(other.ForecastEntries)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
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
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.ForecastEntries != null)
                    hash = hash * 59 + this.ForecastEntries.GetHashCode();
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                return hash;
            }
        }
    }

}
