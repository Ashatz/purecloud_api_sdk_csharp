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
    /// RuleSetNotificationConditions
    /// </summary>
    [DataContract]
    public partial class RuleSetNotificationConditions :  IEquatable<RuleSetNotificationConditions>
    {
        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ValueTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum String for "STRING"
            /// </summary>
            [EnumMember(Value = "STRING")]
            String,
            
            /// <summary>
            /// Enum Numeric for "NUMERIC"
            /// </summary>
            [EnumMember(Value = "NUMERIC")]
            Numeric,
            
            /// <summary>
            /// Enum Datetime for "DATETIME"
            /// </summary>
            [EnumMember(Value = "DATETIME")]
            Datetime,
            
            /// <summary>
            /// Enum Period for "PERIOD"
            /// </summary>
            [EnumMember(Value = "PERIOD")]
            Period
        }
        /// <summary>
        /// Gets or Sets ComparisonOperator
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ComparisonOperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Equals for "EQUALS"
            /// </summary>
            [EnumMember(Value = "EQUALS")]
            Equals,
            
            /// <summary>
            /// Enum LessThan for "LESS_THAN"
            /// </summary>
            [EnumMember(Value = "LESS_THAN")]
            LessThan,
            
            /// <summary>
            /// Enum LessThanEquals for "LESS_THAN_EQUALS"
            /// </summary>
            [EnumMember(Value = "LESS_THAN_EQUALS")]
            LessThanEquals,
            
            /// <summary>
            /// Enum GreaterThan for "GREATER_THAN"
            /// </summary>
            [EnumMember(Value = "GREATER_THAN")]
            GreaterThan,
            
            /// <summary>
            /// Enum GreaterThanEquals for "GREATER_THAN_EQUALS"
            /// </summary>
            [EnumMember(Value = "GREATER_THAN_EQUALS")]
            GreaterThanEquals,
            
            /// <summary>
            /// Enum Contains for "CONTAINS"
            /// </summary>
            [EnumMember(Value = "CONTAINS")]
            Contains,
            
            /// <summary>
            /// Enum BeginsWith for "BEGINS_WITH"
            /// </summary>
            [EnumMember(Value = "BEGINS_WITH")]
            BeginsWith,
            
            /// <summary>
            /// Enum EndsWith for "ENDS_WITH"
            /// </summary>
            [EnumMember(Value = "ENDS_WITH")]
            EndsWith,
            
            /// <summary>
            /// Enum Before for "BEFORE"
            /// </summary>
            [EnumMember(Value = "BEFORE")]
            Before,
            
            /// <summary>
            /// Enum After for "AFTER"
            /// </summary>
            [EnumMember(Value = "AFTER")]
            After
        }
        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public ValueTypeEnum? ValueType { get; set; }
        /// <summary>
        /// Gets or Sets ComparisonOperator
        /// </summary>
        [DataMember(Name="comparisonOperator", EmitDefaultValue=false)]
        public ComparisonOperatorEnum? ComparisonOperator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSetNotificationConditions" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Inverted">Inverted.</param>
        /// <param name="AttributeName">AttributeName.</param>
        /// <param name="Value">Value.</param>
        /// <param name="ValueType">ValueType.</param>
        /// <param name="ComparisonOperator">ComparisonOperator.</param>
        /// <param name="Codes">Codes.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public RuleSetNotificationConditions(string Type = null, bool? Inverted = null, string AttributeName = null, string Value = null, ValueTypeEnum? ValueType = null, ComparisonOperatorEnum? ComparisonOperator = null, List<string> Codes = null, Object AdditionalProperties = null)
        {
            this.Type = Type;
            this.Inverted = Inverted;
            this.AttributeName = AttributeName;
            this.Value = Value;
            this.ValueType = ValueType;
            this.ComparisonOperator = ComparisonOperator;
            this.Codes = Codes;
            this.AdditionalProperties = AdditionalProperties;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Inverted
        /// </summary>
        [DataMember(Name="inverted", EmitDefaultValue=false)]
        public bool? Inverted { get; set; }
        /// <summary>
        /// Gets or Sets AttributeName
        /// </summary>
        [DataMember(Name="attributeName", EmitDefaultValue=false)]
        public string AttributeName { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Gets or Sets Codes
        /// </summary>
        [DataMember(Name="codes", EmitDefaultValue=false)]
        public List<string> Codes { get; set; }
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleSetNotificationConditions {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Inverted: ").Append(Inverted).Append("\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  ComparisonOperator: ").Append(ComparisonOperator).Append("\n");
            sb.Append("  Codes: ").Append(Codes).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as RuleSetNotificationConditions);
        }

        /// <summary>
        /// Returns true if RuleSetNotificationConditions instances are equal
        /// </summary>
        /// <param name="other">Instance of RuleSetNotificationConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleSetNotificationConditions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Inverted == other.Inverted ||
                    this.Inverted != null &&
                    this.Inverted.Equals(other.Inverted)
                ) &&
                (
                    this.AttributeName == other.AttributeName ||
                    this.AttributeName != null &&
                    this.AttributeName.Equals(other.AttributeName)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.ValueType == other.ValueType ||
                    this.ValueType != null &&
                    this.ValueType.Equals(other.ValueType)
                ) &&
                (
                    this.ComparisonOperator == other.ComparisonOperator ||
                    this.ComparisonOperator != null &&
                    this.ComparisonOperator.Equals(other.ComparisonOperator)
                ) &&
                (
                    this.Codes == other.Codes ||
                    this.Codes != null &&
                    this.Codes.SequenceEqual(other.Codes)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Inverted != null)
                    hash = hash * 59 + this.Inverted.GetHashCode();
                if (this.AttributeName != null)
                    hash = hash * 59 + this.AttributeName.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.ValueType != null)
                    hash = hash * 59 + this.ValueType.GetHashCode();
                if (this.ComparisonOperator != null)
                    hash = hash * 59 + this.ComparisonOperator.GetHashCode();
                if (this.Codes != null)
                    hash = hash * 59 + this.Codes.GetHashCode();
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                return hash;
            }
        }
    }

}
