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
    public class ConsultTransfer :  IEquatable<ConsultTransfer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultTransfer" /> class.
        /// </summary>
        public ConsultTransfer()
        {
            
        }

        
        /// <summary>
        /// Determines to whom the initiating participant is speaking. Defaults to DESTINATION
        /// </summary>
        /// <value>Determines to whom the initiating participant is speaking. Defaults to DESTINATION</value>
        [DataMember(Name="speakTo", EmitDefaultValue=false)]
        public string SpeakTo { get; set; }
  
        
        /// <summary>
        /// Destination phone number and name.
        /// </summary>
        /// <value>Destination phone number and name.</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public Destination Destination { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultTransfer {\n");
            sb.Append("  SpeakTo: ").Append(SpeakTo).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            
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
            return this.Equals(obj as ConsultTransfer);
        }

        /// <summary>
        /// Returns true if ConsultTransfer instances are equal
        /// </summary>
        /// <param name="obj">Instance of ConsultTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultTransfer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SpeakTo == other.SpeakTo ||
                    this.SpeakTo != null &&
                    this.SpeakTo.Equals(other.SpeakTo)
                ) && 
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
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
                
                if (this.SpeakTo != null)
                    hash = hash * 57 + this.SpeakTo.GetHashCode();
                
                if (this.Destination != null)
                    hash = hash * 57 + this.Destination.GetHashCode();
                
                return hash;
            }
        }

    }


}