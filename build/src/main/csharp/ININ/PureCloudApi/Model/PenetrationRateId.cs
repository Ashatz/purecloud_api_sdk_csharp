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
    public partial class PenetrationRateId :  IEquatable<PenetrationRateId>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PenetrationRateId" />class.
        /// </summary>
        /// <param name="ContactList">ContactList.</param>
        /// <param name="Qualifier">Qualifier.</param>

        public PenetrationRateId(UriReference ContactList = null, UriReference Qualifier = null)
        {
            this.ContactList = ContactList;
            this.Qualifier = Qualifier;
            
        }

    
        /// <summary>
        /// Gets or Sets ContactList
        /// </summary>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public UriReference ContactList { get; set; }
    
        /// <summary>
        /// Gets or Sets Qualifier
        /// </summary>
        [DataMember(Name="qualifier", EmitDefaultValue=false)]
        public UriReference Qualifier { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PenetrationRateId {\n");
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            sb.Append("  Qualifier: ").Append(Qualifier).Append("\n");
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
            return this.Equals(obj as PenetrationRateId);
        }

        /// <summary>
        /// Returns true if PenetrationRateId instances are equal
        /// </summary>
        /// <param name="other">Instance of PenetrationRateId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PenetrationRateId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContactList == other.ContactList ||
                    this.ContactList != null &&
                    this.ContactList.Equals(other.ContactList)
                ) &&
                (
                    this.Qualifier == other.Qualifier ||
                    this.Qualifier != null &&
                    this.Qualifier.Equals(other.Qualifier)
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
                if (this.ContactList != null)
                    hash = hash * 59 + this.ContactList.GetHashCode();
                if (this.Qualifier != null)
                    hash = hash * 59 + this.Qualifier.GetHashCode();
                return hash;
            }
        }

    }
}
