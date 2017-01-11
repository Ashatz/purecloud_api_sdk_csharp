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
    /// ContactListNotificationPhoneColumn_
    /// </summary>
    [DataContract]
    public partial class ContactListNotificationPhoneColumn_ :  IEquatable<ContactListNotificationPhoneColumn_>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListNotificationPhoneColumn_" /> class.
        /// </summary>
        /// <param name="ColumnName">ColumnName.</param>
        /// <param name="Type">Type.</param>
        /// <param name="CallableTimeColumn">CallableTimeColumn.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public ContactListNotificationPhoneColumn_(string ColumnName = null, string Type = null, string CallableTimeColumn = null, Object AdditionalProperties = null)
        {
            this.ColumnName = ColumnName;
            this.Type = Type;
            this.CallableTimeColumn = CallableTimeColumn;
            this.AdditionalProperties = AdditionalProperties;
        }
        
        /// <summary>
        /// Gets or Sets ColumnName
        /// </summary>
        [DataMember(Name="columnName", EmitDefaultValue=false)]
        public string ColumnName { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets CallableTimeColumn
        /// </summary>
        [DataMember(Name="callableTimeColumn", EmitDefaultValue=false)]
        public string CallableTimeColumn { get; set; }
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
            sb.Append("class ContactListNotificationPhoneColumn_ {\n");
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CallableTimeColumn: ").Append(CallableTimeColumn).Append("\n");
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
            return this.Equals(obj as ContactListNotificationPhoneColumn_);
        }

        /// <summary>
        /// Returns true if ContactListNotificationPhoneColumn_ instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactListNotificationPhoneColumn_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListNotificationPhoneColumn_ other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ColumnName == other.ColumnName ||
                    this.ColumnName != null &&
                    this.ColumnName.Equals(other.ColumnName)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.CallableTimeColumn == other.CallableTimeColumn ||
                    this.CallableTimeColumn != null &&
                    this.CallableTimeColumn.Equals(other.CallableTimeColumn)
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
                if (this.ColumnName != null)
                    hash = hash * 59 + this.ColumnName.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.CallableTimeColumn != null)
                    hash = hash * 59 + this.CallableTimeColumn.GetHashCode();
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                return hash;
            }
        }
    }

}
