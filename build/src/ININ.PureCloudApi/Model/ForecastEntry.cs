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
    /// ForecastEntry
    /// </summary>
    [DataContract]
    public partial class ForecastEntry :  IEquatable<ForecastEntry>
    {
        /// <summary>
        /// The metric of the entry
        /// </summary>
        /// <value>The metric of the entry</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
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
        /// The metric of the entry
        /// </summary>
        /// <value>The metric of the entry</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastEntry" /> class.
        /// </summary>
        /// <param name="Dimensions">The dimensions of the entry.</param>
        /// <param name="Values">The forecasted values.</param>
        public ForecastEntry(ForecastDimensions Dimensions = null, List<double?> Values = null)
        {
            this.Dimensions = Dimensions;
            this.Values = Values;
        }
        
        /// <summary>
        /// The dimensions of the entry
        /// </summary>
        /// <value>The dimensions of the entry</value>
        [DataMember(Name="dimensions", EmitDefaultValue=false)]
        public ForecastDimensions Dimensions { get; set; }
        /// <summary>
        /// The forecasted values
        /// </summary>
        /// <value>The forecasted values</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<double?> Values { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastEntry {\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as ForecastEntry);
        }

        /// <summary>
        /// Returns true if ForecastEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.Dimensions == other.Dimensions ||
                    this.Dimensions != null &&
                    this.Dimensions.Equals(other.Dimensions)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();
                if (this.Dimensions != null)
                    hash = hash * 59 + this.Dimensions.GetHashCode();
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                return hash;
            }
        }
    }

}
