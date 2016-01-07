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
    public class Preview :  IEquatable<Preview>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Preview" /> class.
        /// </summary>
        public Preview()
        {
            this.TimedOut = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Campaign
        /// </summary>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public Campaign Campaign { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ContactList
        /// </summary>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public ContactList ContactList { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public Contact Contact { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AvailablePhoneNumbers
        /// </summary>
        [DataMember(Name="availablePhoneNumbers", EmitDefaultValue=false)]
        public List<string> AvailablePhoneNumbers { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RemainingSeconds
        /// </summary>
        [DataMember(Name="remainingSeconds", EmitDefaultValue=false)]
        public int? RemainingSeconds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ScriptId
        /// </summary>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public string ScriptId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TimedOut
        /// </summary>
        [DataMember(Name="timedOut", EmitDefaultValue=false)]
        public bool? TimedOut { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Preview {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  AvailablePhoneNumbers: ").Append(AvailablePhoneNumbers).Append("\n");
            sb.Append("  RemainingSeconds: ").Append(RemainingSeconds).Append("\n");
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  TimedOut: ").Append(TimedOut).Append("\n");
            
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
            return this.Equals(obj as Preview);
        }

        /// <summary>
        /// Returns true if Preview instances are equal
        /// </summary>
        /// <param name="obj">Instance of Preview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Preview other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) && 
                (
                    this.Campaign == other.Campaign ||
                    this.Campaign != null &&
                    this.Campaign.Equals(other.Campaign)
                ) && 
                (
                    this.ContactList == other.ContactList ||
                    this.ContactList != null &&
                    this.ContactList.Equals(other.ContactList)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.AvailablePhoneNumbers == other.AvailablePhoneNumbers ||
                    this.AvailablePhoneNumbers != null &&
                    this.AvailablePhoneNumbers.SequenceEqual(other.AvailablePhoneNumbers)
                ) && 
                (
                    this.RemainingSeconds == other.RemainingSeconds ||
                    this.RemainingSeconds != null &&
                    this.RemainingSeconds.Equals(other.RemainingSeconds)
                ) && 
                (
                    this.ScriptId == other.ScriptId ||
                    this.ScriptId != null &&
                    this.ScriptId.Equals(other.ScriptId)
                ) && 
                (
                    this.TimedOut == other.TimedOut ||
                    this.TimedOut != null &&
                    this.TimedOut.Equals(other.TimedOut)
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
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                if (this.Campaign != null)
                    hash = hash * 57 + this.Campaign.GetHashCode();
                
                if (this.ContactList != null)
                    hash = hash * 57 + this.ContactList.GetHashCode();
                
                if (this.Contact != null)
                    hash = hash * 57 + this.Contact.GetHashCode();
                
                if (this.AvailablePhoneNumbers != null)
                    hash = hash * 57 + this.AvailablePhoneNumbers.GetHashCode();
                
                if (this.RemainingSeconds != null)
                    hash = hash * 57 + this.RemainingSeconds.GetHashCode();
                
                if (this.ScriptId != null)
                    hash = hash * 57 + this.ScriptId.GetHashCode();
                
                if (this.TimedOut != null)
                    hash = hash * 57 + this.TimedOut.GetHashCode();
                
                return hash;
            }
        }

    }


}
