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
    public partial class CampaignProgress :  IEquatable<CampaignProgress>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignProgress" />class.
        /// </summary>
        /// <param name="Campaign">Campaign.</param>
        /// <param name="ContactList">ContactList.</param>
        /// <param name="NumberOfContactsCalled">NumberOfContactsCalled.</param>
        /// <param name="TotalNumberOfContacts">TotalNumberOfContacts.</param>
        /// <param name="Percentage">Percentage.</param>

        public CampaignProgress(UriReference Campaign = null, UriReference ContactList = null, long? NumberOfContactsCalled = null, long? TotalNumberOfContacts = null, long? Percentage = null)
        {
            this.Campaign = Campaign;
            this.ContactList = ContactList;
            this.NumberOfContactsCalled = NumberOfContactsCalled;
            this.TotalNumberOfContacts = TotalNumberOfContacts;
            this.Percentage = Percentage;
            
        }

    
        /// <summary>
        /// Gets or Sets Campaign
        /// </summary>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public UriReference Campaign { get; set; }
    
        /// <summary>
        /// Gets or Sets ContactList
        /// </summary>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public UriReference ContactList { get; set; }
    
        /// <summary>
        /// Gets or Sets NumberOfContactsCalled
        /// </summary>
        [DataMember(Name="numberOfContactsCalled", EmitDefaultValue=false)]
        public long? NumberOfContactsCalled { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalNumberOfContacts
        /// </summary>
        [DataMember(Name="totalNumberOfContacts", EmitDefaultValue=false)]
        public long? TotalNumberOfContacts { get; set; }
    
        /// <summary>
        /// Gets or Sets Percentage
        /// </summary>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public long? Percentage { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignProgress {\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            sb.Append("  NumberOfContactsCalled: ").Append(NumberOfContactsCalled).Append("\n");
            sb.Append("  TotalNumberOfContacts: ").Append(TotalNumberOfContacts).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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
            return this.Equals(obj as CampaignProgress);
        }

        /// <summary>
        /// Returns true if CampaignProgress instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignProgress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignProgress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.NumberOfContactsCalled == other.NumberOfContactsCalled ||
                    this.NumberOfContactsCalled != null &&
                    this.NumberOfContactsCalled.Equals(other.NumberOfContactsCalled)
                ) &&
                (
                    this.TotalNumberOfContacts == other.TotalNumberOfContacts ||
                    this.TotalNumberOfContacts != null &&
                    this.TotalNumberOfContacts.Equals(other.TotalNumberOfContacts)
                ) &&
                (
                    this.Percentage == other.Percentage ||
                    this.Percentage != null &&
                    this.Percentage.Equals(other.Percentage)
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
                if (this.Campaign != null)
                    hash = hash * 59 + this.Campaign.GetHashCode();
                if (this.ContactList != null)
                    hash = hash * 59 + this.ContactList.GetHashCode();
                if (this.NumberOfContactsCalled != null)
                    hash = hash * 59 + this.NumberOfContactsCalled.GetHashCode();
                if (this.TotalNumberOfContacts != null)
                    hash = hash * 59 + this.TotalNumberOfContacts.GetHashCode();
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();
                return hash;
            }
        }

    }
}
