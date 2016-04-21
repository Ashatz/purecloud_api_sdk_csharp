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
    public partial class SortField :  IEquatable<SortField>
    { 

        /// <summary>
        /// Gets or Sets SortType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SortTypeEnum {
            
            [EnumMember(Value = "ASCENDING")]
            Ascending,
            
            [EnumMember(Value = "DESCENDING")]
            Descending
        }

        

        /// <summary>
        /// Gets or Sets SortType
        /// </summary>
        [DataMember(Name="sortType", EmitDefaultValue=false)]
        public SortTypeEnum? SortType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SortField" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="SortType">SortType.</param>

        public SortField(string Name = null, SortTypeEnum? SortType = null)
        {
            this.Name = Name;
            this.SortType = SortType;
            
        }

    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SortField {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SortType: ").Append(SortType).Append("\n");
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
            return this.Equals(obj as SortField);
        }

        /// <summary>
        /// Returns true if SortField instances are equal
        /// </summary>
        /// <param name="other">Instance of SortField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SortField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.SortType == other.SortType ||
                    this.SortType != null &&
                    this.SortType.Equals(other.SortType)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SortType != null)
                    hash = hash * 59 + this.SortType.GetHashCode();
                return hash;
            }
        }

    }
}
