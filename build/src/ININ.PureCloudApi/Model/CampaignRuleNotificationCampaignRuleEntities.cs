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
    /// CampaignRuleNotificationCampaignRuleEntities
    /// </summary>
    [DataContract]
    public partial class CampaignRuleNotificationCampaignRuleEntities :  IEquatable<CampaignRuleNotificationCampaignRuleEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleNotificationCampaignRuleEntities" /> class.
        /// </summary>
        /// <param name="Campaigns">Campaigns.</param>
        /// <param name="Sequences">Sequences.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public CampaignRuleNotificationCampaignRuleEntities(List<string> Campaigns = null, List<string> Sequences = null, Object AdditionalProperties = null)
        {
            this.Campaigns = Campaigns;
            this.Sequences = Sequences;
            this.AdditionalProperties = AdditionalProperties;
        }
        
        /// <summary>
        /// Gets or Sets Campaigns
        /// </summary>
        [DataMember(Name="campaigns", EmitDefaultValue=false)]
        public List<string> Campaigns { get; set; }
        /// <summary>
        /// Gets or Sets Sequences
        /// </summary>
        [DataMember(Name="sequences", EmitDefaultValue=false)]
        public List<string> Sequences { get; set; }
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
            sb.Append("class CampaignRuleNotificationCampaignRuleEntities {\n");
            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
            sb.Append("  Sequences: ").Append(Sequences).Append("\n");
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
            return this.Equals(obj as CampaignRuleNotificationCampaignRuleEntities);
        }

        /// <summary>
        /// Returns true if CampaignRuleNotificationCampaignRuleEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleNotificationCampaignRuleEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleNotificationCampaignRuleEntities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Campaigns == other.Campaigns ||
                    this.Campaigns != null &&
                    this.Campaigns.SequenceEqual(other.Campaigns)
                ) &&
                (
                    this.Sequences == other.Sequences ||
                    this.Sequences != null &&
                    this.Sequences.SequenceEqual(other.Sequences)
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
                if (this.Campaigns != null)
                    hash = hash * 59 + this.Campaigns.GetHashCode();
                if (this.Sequences != null)
                    hash = hash * 59 + this.Sequences.GetHashCode();
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                return hash;
            }
        }
    }

}
