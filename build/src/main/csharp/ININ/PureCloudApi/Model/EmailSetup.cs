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
    public class EmailSetup :  IEquatable<EmailSetup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSetup" /> class.
        /// </summary>
        public EmailSetup()
        {
            
        }

        
        /// <summary>
        /// The root PureCloud domain that all sub-domains are created from.
        /// </summary>
        /// <value>The root PureCloud domain that all sub-domains are created from.</value>
        [DataMember(Name="rootDomain", EmitDefaultValue=false)]
        public string RootDomain { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MxRecordEntries
        /// </summary>
        [DataMember(Name="mxRecordEntries", EmitDefaultValue=false)]
        public List<MxRecordEntry> MxRecordEntries { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailSetup {\n");
            sb.Append("  RootDomain: ").Append(RootDomain).Append("\n");
            sb.Append("  MxRecordEntries: ").Append(MxRecordEntries).Append("\n");
            
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
            return this.Equals(obj as EmailSetup);
        }

        /// <summary>
        /// Returns true if EmailSetup instances are equal
        /// </summary>
        /// <param name="obj">Instance of EmailSetup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailSetup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RootDomain == other.RootDomain ||
                    this.RootDomain != null &&
                    this.RootDomain.Equals(other.RootDomain)
                ) && 
                (
                    this.MxRecordEntries == other.MxRecordEntries ||
                    this.MxRecordEntries != null &&
                    this.MxRecordEntries.SequenceEqual(other.MxRecordEntries)
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
                
                if (this.RootDomain != null)
                    hash = hash * 57 + this.RootDomain.GetHashCode();
                
                if (this.MxRecordEntries != null)
                    hash = hash * 57 + this.MxRecordEntries.GetHashCode();
                
                return hash;
            }
        }

    }


}
