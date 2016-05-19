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
    /// DataItem
    /// </summary>
    [DataContract]
    public partial class DataItem :  IEquatable<DataItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataItem" /> class.
        /// </summary>
        /// <param name="DataItemId">DataItemId.</param>
        /// <param name="Value">Value.</param>
        /// <param name="Type">Type.</param>
        public DataItem(string DataItemId = null, string Value = null, string Type = null)
        {
            this.DataItemId = DataItemId;
            this.Value = Value;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets DataItemId
        /// </summary>
        [DataMember(Name="dataItemId", EmitDefaultValue=false)]
        public string DataItemId { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataItem {\n");
            sb.Append("  DataItemId: ").Append(DataItemId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as DataItem);
        }

        /// <summary>
        /// Returns true if DataItem instances are equal
        /// </summary>
        /// <param name="other">Instance of DataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataItemId == other.DataItemId ||
                    this.DataItemId != null &&
                    this.DataItemId.Equals(other.DataItemId)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.DataItemId != null)
                    hash = hash * 59 + this.DataItemId.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }
    }

}
