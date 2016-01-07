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
    /// 
    /// </summary>
    [DataContract]
    public class ConversationHistoricalQueryRequestFilter :  IEquatable<ConversationHistoricalQueryRequestFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoricalQueryRequestFilter" /> class.
        /// </summary>
        public ConversationHistoricalQueryRequestFilter()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public string Target { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public string Operator { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationHistoricalQueryRequestFilter {\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return this.Equals(obj as ConversationHistoricalQueryRequestFilter);
        }

        /// <summary>
        /// Returns true if ConversationHistoricalQueryRequestFilter instances are equal
        /// </summary>
        /// <param name="obj">Instance of ConversationHistoricalQueryRequestFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationHistoricalQueryRequestFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) && 
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
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
                
                if (this.Target != null)
                    hash = hash * 57 + this.Target.GetHashCode();
                
                if (this.Operator != null)
                    hash = hash * 57 + this.Operator.GetHashCode();
                
                if (this.Values != null)
                    hash = hash * 57 + this.Values.GetHashCode();
                
                return hash;
            }
        }

    }


}
