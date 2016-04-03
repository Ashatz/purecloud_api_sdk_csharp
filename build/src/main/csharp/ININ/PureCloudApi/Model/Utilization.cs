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
    public partial class Utilization :  IEquatable<Utilization>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Utilization" />class.
        /// </summary>
        /// <param name="UtilizationProperty">Map of media types to utilization settings.  Map keys can be: call, chat, email, or socialExpression.</param>

        public Utilization(Dictionary<string, OrgMediaUtilization> UtilizationProperty = null)
        {
            this.UtilizationProperty = UtilizationProperty;
            
        }
        
    
        /// <summary>
        /// Map of media types to utilization settings.  Map keys can be: call, chat, email, or socialExpression
        /// </summary>
        /// <value>Map of media types to utilization settings.  Map keys can be: call, chat, email, or socialExpression</value>
        [DataMember(Name="utilization", EmitDefaultValue=false)]
        public Dictionary<string, OrgMediaUtilization> UtilizationProperty { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Utilization {\n");
            sb.Append("  UtilizationProperty: ").Append(UtilizationProperty).Append("\n");
            
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
            return this.Equals(obj as Utilization);
        }

        /// <summary>
        /// Returns true if Utilization instances are equal
        /// </summary>
        /// <param name="other">Instance of Utilization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Utilization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UtilizationProperty == other.UtilizationProperty ||
                    this.UtilizationProperty != null &&
                    this.UtilizationProperty.SequenceEqual(other.UtilizationProperty)
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
                
                if (this.UtilizationProperty != null)
                    hash = hash * 59 + this.UtilizationProperty.GetHashCode();
                
                return hash;
            }
        }

    }
}
