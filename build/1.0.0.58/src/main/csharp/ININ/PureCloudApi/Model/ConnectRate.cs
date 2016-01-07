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
    public class ConnectRate :  IEquatable<ConnectRate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectRate" /> class.
        /// </summary>
        public ConnectRate()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Attempts
        /// </summary>
        [DataMember(Name="attempts", EmitDefaultValue=false)]
        public long? Attempts { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Connects
        /// </summary>
        [DataMember(Name="connects", EmitDefaultValue=false)]
        public long? Connects { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ConnectRatio
        /// </summary>
        [DataMember(Name="connectRatio", EmitDefaultValue=false)]
        public double? ConnectRatio { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectRate {\n");
            sb.Append("  Attempts: ").Append(Attempts).Append("\n");
            sb.Append("  Connects: ").Append(Connects).Append("\n");
            sb.Append("  ConnectRatio: ").Append(ConnectRatio).Append("\n");
            
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
            return this.Equals(obj as ConnectRate);
        }

        /// <summary>
        /// Returns true if ConnectRate instances are equal
        /// </summary>
        /// <param name="obj">Instance of ConnectRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectRate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Attempts == other.Attempts ||
                    this.Attempts != null &&
                    this.Attempts.Equals(other.Attempts)
                ) && 
                (
                    this.Connects == other.Connects ||
                    this.Connects != null &&
                    this.Connects.Equals(other.Connects)
                ) && 
                (
                    this.ConnectRatio == other.ConnectRatio ||
                    this.ConnectRatio != null &&
                    this.ConnectRatio.Equals(other.ConnectRatio)
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
                
                if (this.Attempts != null)
                    hash = hash * 57 + this.Attempts.GetHashCode();
                
                if (this.Connects != null)
                    hash = hash * 57 + this.Connects.GetHashCode();
                
                if (this.ConnectRatio != null)
                    hash = hash * 57 + this.ConnectRatio.GetHashCode();
                
                return hash;
            }
        }

    }


}
