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
    /// CampaignDiagnostics
    /// </summary>
    [DataContract]
    public partial class CampaignDiagnostics :  IEquatable<CampaignDiagnostics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignDiagnostics" /> class.
        /// </summary>
        /// <param name="CallableContacts">Campaign properties that can impact which contacts are callable.</param>
        /// <param name="QueueUtilizationDiagnostic">Information regarding the campaign&#39;s queue.</param>
        /// <param name="RuleSetDiagnostics">Information regarding the campaign&#39;s rule sets.</param>
        public CampaignDiagnostics(CallableContactsDiagnostic CallableContacts = null, QueueUtilizationDiagnostic QueueUtilizationDiagnostic = null, List<RuleSetDiagnostic> RuleSetDiagnostics = null)
        {
            this.CallableContacts = CallableContacts;
            this.QueueUtilizationDiagnostic = QueueUtilizationDiagnostic;
            this.RuleSetDiagnostics = RuleSetDiagnostics;
        }
        
        /// <summary>
        /// Campaign properties that can impact which contacts are callable
        /// </summary>
        /// <value>Campaign properties that can impact which contacts are callable</value>
        [DataMember(Name="callableContacts", EmitDefaultValue=false)]
        public CallableContactsDiagnostic CallableContacts { get; set; }
        /// <summary>
        /// Information regarding the campaign&#39;s queue
        /// </summary>
        /// <value>Information regarding the campaign&#39;s queue</value>
        [DataMember(Name="queueUtilizationDiagnostic", EmitDefaultValue=false)]
        public QueueUtilizationDiagnostic QueueUtilizationDiagnostic { get; set; }
        /// <summary>
        /// Information regarding the campaign&#39;s rule sets
        /// </summary>
        /// <value>Information regarding the campaign&#39;s rule sets</value>
        [DataMember(Name="ruleSetDiagnostics", EmitDefaultValue=false)]
        public List<RuleSetDiagnostic> RuleSetDiagnostics { get; set; }
        /// <summary>
        /// Current number of outstanding interactions on the campaign
        /// </summary>
        /// <value>Current number of outstanding interactions on the campaign</value>
        [DataMember(Name="outstandingInteractionsCount", EmitDefaultValue=false)]
        public int? OutstandingInteractionsCount { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignDiagnostics {\n");
            sb.Append("  CallableContacts: ").Append(CallableContacts).Append("\n");
            sb.Append("  QueueUtilizationDiagnostic: ").Append(QueueUtilizationDiagnostic).Append("\n");
            sb.Append("  RuleSetDiagnostics: ").Append(RuleSetDiagnostics).Append("\n");
            sb.Append("  OutstandingInteractionsCount: ").Append(OutstandingInteractionsCount).Append("\n");
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
            return this.Equals(obj as CampaignDiagnostics);
        }

        /// <summary>
        /// Returns true if CampaignDiagnostics instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignDiagnostics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignDiagnostics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CallableContacts == other.CallableContacts ||
                    this.CallableContacts != null &&
                    this.CallableContacts.Equals(other.CallableContacts)
                ) &&
                (
                    this.QueueUtilizationDiagnostic == other.QueueUtilizationDiagnostic ||
                    this.QueueUtilizationDiagnostic != null &&
                    this.QueueUtilizationDiagnostic.Equals(other.QueueUtilizationDiagnostic)
                ) &&
                (
                    this.RuleSetDiagnostics == other.RuleSetDiagnostics ||
                    this.RuleSetDiagnostics != null &&
                    this.RuleSetDiagnostics.SequenceEqual(other.RuleSetDiagnostics)
                ) &&
                (
                    this.OutstandingInteractionsCount == other.OutstandingInteractionsCount ||
                    this.OutstandingInteractionsCount != null &&
                    this.OutstandingInteractionsCount.Equals(other.OutstandingInteractionsCount)
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
                if (this.CallableContacts != null)
                    hash = hash * 59 + this.CallableContacts.GetHashCode();
                if (this.QueueUtilizationDiagnostic != null)
                    hash = hash * 59 + this.QueueUtilizationDiagnostic.GetHashCode();
                if (this.RuleSetDiagnostics != null)
                    hash = hash * 59 + this.RuleSetDiagnostics.GetHashCode();
                if (this.OutstandingInteractionsCount != null)
                    hash = hash * 59 + this.OutstandingInteractionsCount.GetHashCode();
                return hash;
            }
        }
    }

}
