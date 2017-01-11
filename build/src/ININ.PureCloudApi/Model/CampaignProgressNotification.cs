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
using ININ.PureCloudApi.Client;

namespace ININ.PureCloudApi.Model
{
    /// <summary>
    /// CampaignProgressNotification
    /// </summary>
    [DataContract]
    public partial class CampaignProgressNotification :  IEquatable<CampaignProgressNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignProgressNotification" /> class.
        /// </summary>
        /// <param name="Campaign">Campaign.</param>
        /// <param name="NumberOfContactsCalled">NumberOfContactsCalled.</param>
        /// <param name="TotalNumberOfContacts">TotalNumberOfContacts.</param>
        /// <param name="Percentage">Percentage.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public CampaignProgressNotification(DocumentDataNotificationCreatedBy Campaign = null, double? NumberOfContactsCalled = null, double? TotalNumberOfContacts = null, int? Percentage = null, Object AdditionalProperties = null)
        {
            this.Campaign = Campaign;
            this.NumberOfContactsCalled = NumberOfContactsCalled;
            this.TotalNumberOfContacts = TotalNumberOfContacts;
            this.Percentage = Percentage;
            this.AdditionalProperties = AdditionalProperties;
        }
        
        /// <summary>
        /// Gets or Sets Campaign
        /// </summary>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public DocumentDataNotificationCreatedBy Campaign { get; set; }
        /// <summary>
        /// Gets or Sets NumberOfContactsCalled
        /// </summary>
        [DataMember(Name="numberOfContactsCalled", EmitDefaultValue=false)]
        public double? NumberOfContactsCalled { get; set; }
        /// <summary>
        /// Gets or Sets TotalNumberOfContacts
        /// </summary>
        [DataMember(Name="totalNumberOfContacts", EmitDefaultValue=false)]
        public double? TotalNumberOfContacts { get; set; }
        /// <summary>
        /// Gets or Sets Percentage
        /// </summary>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public int? Percentage { get; set; }
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignProgressNotification {\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  NumberOfContactsCalled: ").Append(NumberOfContactsCalled).Append("\n");
            sb.Append("  TotalNumberOfContacts: ").Append(TotalNumberOfContacts).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as CampaignProgressNotification);
        }

        /// <summary>
        /// Returns true if CampaignProgressNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignProgressNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignProgressNotification other)
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
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                if (this.NumberOfContactsCalled != null)
                    hash = hash * 59 + this.NumberOfContactsCalled.GetHashCode();
                if (this.TotalNumberOfContacts != null)
                    hash = hash * 59 + this.TotalNumberOfContacts.GetHashCode();
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                return hash;
            }
        }
    }

}
