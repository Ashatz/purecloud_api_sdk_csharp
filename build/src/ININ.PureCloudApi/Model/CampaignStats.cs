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
    /// CampaignStats
    /// </summary>
    [DataContract]
    public partial class CampaignStats :  IEquatable<CampaignStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignStats" /> class.
        /// </summary>
        /// <param name="ContactRate">Information regarding the campaign&#39;s connect rate.</param>
        public CampaignStats(ConnectRate ContactRate = null)
        {
            this.ContactRate = ContactRate;
        }
        
        /// <summary>
        /// Information regarding the campaign&#39;s connect rate
        /// </summary>
        /// <value>Information regarding the campaign&#39;s connect rate</value>
        [DataMember(Name="contactRate", EmitDefaultValue=false)]
        public ConnectRate ContactRate { get; set; }
        /// <summary>
        /// Number of available agents not currently being utilized
        /// </summary>
        /// <value>Number of available agents not currently being utilized</value>
        [DataMember(Name="idleAgents", EmitDefaultValue=false)]
        public int? IdleAgents { get; private set; }
        /// <summary>
        /// Calls per agent adjusted by pace
        /// </summary>
        /// <value>Calls per agent adjusted by pace</value>
        [DataMember(Name="adjustedCallsPerAgent", EmitDefaultValue=false)]
        public double? AdjustedCallsPerAgent { get; private set; }
        /// <summary>
        /// Number of campaign calls currently ongoing
        /// </summary>
        /// <value>Number of campaign calls currently ongoing</value>
        [DataMember(Name="outstandingCalls", EmitDefaultValue=false)]
        public int? OutstandingCalls { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignStats {\n");
            sb.Append("  ContactRate: ").Append(ContactRate).Append("\n");
            sb.Append("  IdleAgents: ").Append(IdleAgents).Append("\n");
            sb.Append("  AdjustedCallsPerAgent: ").Append(AdjustedCallsPerAgent).Append("\n");
            sb.Append("  OutstandingCalls: ").Append(OutstandingCalls).Append("\n");
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
            return this.Equals(obj as CampaignStats);
        }

        /// <summary>
        /// Returns true if CampaignStats instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignStats other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContactRate == other.ContactRate ||
                    this.ContactRate != null &&
                    this.ContactRate.Equals(other.ContactRate)
                ) &&
                (
                    this.IdleAgents == other.IdleAgents ||
                    this.IdleAgents != null &&
                    this.IdleAgents.Equals(other.IdleAgents)
                ) &&
                (
                    this.AdjustedCallsPerAgent == other.AdjustedCallsPerAgent ||
                    this.AdjustedCallsPerAgent != null &&
                    this.AdjustedCallsPerAgent.Equals(other.AdjustedCallsPerAgent)
                ) &&
                (
                    this.OutstandingCalls == other.OutstandingCalls ||
                    this.OutstandingCalls != null &&
                    this.OutstandingCalls.Equals(other.OutstandingCalls)
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
                if (this.ContactRate != null)
                    hash = hash * 59 + this.ContactRate.GetHashCode();
                if (this.IdleAgents != null)
                    hash = hash * 59 + this.IdleAgents.GetHashCode();
                if (this.AdjustedCallsPerAgent != null)
                    hash = hash * 59 + this.AdjustedCallsPerAgent.GetHashCode();
                if (this.OutstandingCalls != null)
                    hash = hash * 59 + this.OutstandingCalls.GetHashCode();
                return hash;
            }
        }
    }

}
