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
    /// RoutingData
    /// </summary>
    [DataContract]
    public partial class RoutingData :  IEquatable<RoutingData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoutingData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingData" /> class.
        /// </summary>
        /// <param name="QueueId">The identifier of the routing queue (required).</param>
        /// <param name="LanguageId">The identifier of a language to be considered in routing.</param>
        /// <param name="Priority">The priority for routing.</param>
        /// <param name="SkillIds">A list of skill identifiers to be considered in routing.</param>
        /// <param name="PreferredAgentIds">A list of agents to be preferred in routing.</param>
        public RoutingData(string QueueId = null, string LanguageId = null, int? Priority = null, List<string> SkillIds = null, List<string> PreferredAgentIds = null)
        {
            // to ensure "QueueId" is required (not null)
            if (QueueId == null)
            {
                throw new InvalidDataException("QueueId is a required property for RoutingData and cannot be null");
            }
            else
            {
                this.QueueId = QueueId;
            }
            this.LanguageId = LanguageId;
            this.Priority = Priority;
            this.SkillIds = SkillIds;
            this.PreferredAgentIds = PreferredAgentIds;
        }
        
        /// <summary>
        /// The identifier of the routing queue
        /// </summary>
        /// <value>The identifier of the routing queue</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        /// <summary>
        /// The identifier of a language to be considered in routing
        /// </summary>
        /// <value>The identifier of a language to be considered in routing</value>
        [DataMember(Name="languageId", EmitDefaultValue=false)]
        public string LanguageId { get; set; }
        /// <summary>
        /// The priority for routing
        /// </summary>
        /// <value>The priority for routing</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }
        /// <summary>
        /// A list of skill identifiers to be considered in routing
        /// </summary>
        /// <value>A list of skill identifiers to be considered in routing</value>
        [DataMember(Name="skillIds", EmitDefaultValue=false)]
        public List<string> SkillIds { get; set; }
        /// <summary>
        /// A list of agents to be preferred in routing
        /// </summary>
        /// <value>A list of agents to be preferred in routing</value>
        [DataMember(Name="preferredAgentIds", EmitDefaultValue=false)]
        public List<string> PreferredAgentIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingData {\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
            sb.Append("  PreferredAgentIds: ").Append(PreferredAgentIds).Append("\n");
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
            return this.Equals(obj as RoutingData);
        }

        /// <summary>
        /// Returns true if RoutingData instances are equal
        /// </summary>
        /// <param name="other">Instance of RoutingData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.LanguageId == other.LanguageId ||
                    this.LanguageId != null &&
                    this.LanguageId.Equals(other.LanguageId)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.SkillIds == other.SkillIds ||
                    this.SkillIds != null &&
                    this.SkillIds.SequenceEqual(other.SkillIds)
                ) &&
                (
                    this.PreferredAgentIds == other.PreferredAgentIds ||
                    this.PreferredAgentIds != null &&
                    this.PreferredAgentIds.SequenceEqual(other.PreferredAgentIds)
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
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                if (this.LanguageId != null)
                    hash = hash * 59 + this.LanguageId.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.SkillIds != null)
                    hash = hash * 59 + this.SkillIds.GetHashCode();
                if (this.PreferredAgentIds != null)
                    hash = hash * 59 + this.PreferredAgentIds.GetHashCode();
                return hash;
            }
        }
    }

}
