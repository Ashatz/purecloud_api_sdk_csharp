using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class DataValueInfo :  IEquatable<DataValueInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataValueInfo" /> class.
        /// </summary>
        public DataValueInfo()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets DataItems
        /// </summary>
        [DataMember(Name="dataItems", EmitDefaultValue=false)]
        public List<DataItem> DataItems { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataValueInfo {\n");
            sb.Append("  DataItems: ").Append(DataItems).Append("\n");
            
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
            return this.Equals(obj as DataValueInfo);
        }

        /// <summary>
        /// Returns true if DataValueInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of DataValueInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataValueInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataItems == other.DataItems ||
                    this.DataItems != null &&
                    this.DataItems.SequenceEqual(other.DataItems)
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
                
                if (this.DataItems != null)
                    hash = hash * 59 + this.DataItems.GetHashCode();
                
                return hash;
            }
        }

    }
}
