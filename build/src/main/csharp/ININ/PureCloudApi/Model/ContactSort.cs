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
    /// 
    /// </summary>
    [DataContract]
    public partial class ContactSort :  IEquatable<ContactSort>
    { 

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DirectionEnum {
            
            [EnumMember(Value = "ASC")]
            Asc,
            
            [EnumMember(Value = "DESC")]
            Desc
        }

        

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactSort" />class.
        /// </summary>
        /// <param name="FieldName">FieldName.</param>
        /// <param name="Direction">Direction.</param>

        public ContactSort(string FieldName = null, DirectionEnum? Direction = null)
        {
            this.FieldName = FieldName;
            this.Direction = Direction;
            
        }

    
        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactSort {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(obj as ContactSort);
        }

        /// <summary>
        /// Returns true if ContactSort instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactSort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactSort other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
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
                if (this.FieldName != null)
                    hash = hash * 59 + this.FieldName.GetHashCode();
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                return hash;
            }
        }

    }
}
