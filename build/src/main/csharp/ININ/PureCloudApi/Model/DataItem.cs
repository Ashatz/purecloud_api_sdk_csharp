using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// Data elements associated with a history event
    /// </summary>
    [DataContract]
    public class DataItem :  IEquatable<DataItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataItem" /> class.
        /// </summary>
        public DataItem()
        {
            
        }

        
        /// <summary>
        /// The name of the data element associated with a history event.
        /// </summary>
        /// <value>The name of the data element associated with a history event.</value>
        [DataMember(Name="parameterName", EmitDefaultValue=false)]
        public string ParameterName { get; set; }
  
        
        /// <summary>
        /// The type of the data element associated with a history event.
        /// </summary>
        /// <value>The type of the data element associated with a history event.</value>
        [DataMember(Name="parameterType", EmitDefaultValue=false)]
        public string ParameterType { get; set; }
  
        
        /// <summary>
        /// The values of the data element associated with a history event.
        /// </summary>
        /// <value>The values of the data element associated with a history event.</value>
        [DataMember(Name="parameterValues", EmitDefaultValue=false)]
        public Value ParameterValues { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataItem {\n");
            sb.Append("  ParameterName: ").Append(ParameterName).Append("\n");
            sb.Append("  ParameterType: ").Append(ParameterType).Append("\n");
            sb.Append("  ParameterValues: ").Append(ParameterValues).Append("\n");
            
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
        /// <param name="obj">Instance of DataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ParameterName == other.ParameterName ||
                    this.ParameterName != null &&
                    this.ParameterName.Equals(other.ParameterName)
                ) && 
                (
                    this.ParameterType == other.ParameterType ||
                    this.ParameterType != null &&
                    this.ParameterType.Equals(other.ParameterType)
                ) && 
                (
                    this.ParameterValues == other.ParameterValues ||
                    this.ParameterValues != null &&
                    this.ParameterValues.Equals(other.ParameterValues)
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
                
                if (this.ParameterName != null)
                    hash = hash * 57 + this.ParameterName.GetHashCode();
                
                if (this.ParameterType != null)
                    hash = hash * 57 + this.ParameterType.GetHashCode();
                
                if (this.ParameterValues != null)
                    hash = hash * 57 + this.ParameterValues.GetHashCode();
                
                return hash;
            }
        }

    }


}
