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
    public partial class AggregateMetricData :  IEquatable<AggregateMetricData>
    { 

        /// <summary>
        /// Gets or Sets Metric
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum MetricEnum {
            
            [EnumMember(Value = "tSegmentDuration")]
            Tsegmentduration,
            
            [EnumMember(Value = "oTotalCriticalScore")]
            Ototalcriticalscore,
            
            [EnumMember(Value = "oTotalScore")]
            Ototalscore,
            
            [EnumMember(Value = "nEvaluations")]
            Nevaluations,
            
            [EnumMember(Value = "tAbandon")]
            Tabandon,
            
            [EnumMember(Value = "tIvr")]
            Tivr,
            
            [EnumMember(Value = "tAnswered")]
            Tanswered,
            
            [EnumMember(Value = "tAcd")]
            Tacd,
            
            [EnumMember(Value = "tTalk")]
            Ttalk,
            
            [EnumMember(Value = "tHeld")]
            Theld,
            
            [EnumMember(Value = "tTalkComplete")]
            Ttalkcomplete,
            
            [EnumMember(Value = "tHeldComplete")]
            Theldcomplete,
            
            [EnumMember(Value = "tAcw")]
            Tacw,
            
            [EnumMember(Value = "tHandle")]
            Thandle,
            
            [EnumMember(Value = "tWait")]
            Twait,
            
            [EnumMember(Value = "tAgentRoutingStatus")]
            Tagentroutingstatus,
            
            [EnumMember(Value = "tOrganizationPresence")]
            Torganizationpresence,
            
            [EnumMember(Value = "tSystemPresence")]
            Tsystempresence,
            
            [EnumMember(Value = "tUserResponseTime")]
            Tuserresponsetime,
            
            [EnumMember(Value = "tAgentResponseTime")]
            Tagentresponsetime,
            
            [EnumMember(Value = "nOffered")]
            Noffered,
            
            [EnumMember(Value = "nOverSla")]
            Noversla,
            
            [EnumMember(Value = "nTransferred")]
            Ntransferred,
            
            [EnumMember(Value = "nOutboundAttempted")]
            Noutboundattempted,
            
            [EnumMember(Value = "nOutboundConnected")]
            Noutboundconnected,
            
            [EnumMember(Value = "nOutboundAbandoned")]
            Noutboundabandoned,
            
            [EnumMember(Value = "nError")]
            Nerror,
            
            [EnumMember(Value = "oServiceTarget")]
            Oservicetarget,
            
            [EnumMember(Value = "oServiceLevel")]
            Oservicelevel,
            
            [EnumMember(Value = "tActive")]
            Tactive,
            
            [EnumMember(Value = "tInactive")]
            Tinactive,
            
            [EnumMember(Value = "oActiveUsers")]
            Oactiveusers,
            
            [EnumMember(Value = "oMemberUsers")]
            Omemberusers,
            
            [EnumMember(Value = "oActiveQueues")]
            Oactivequeues,
            
            [EnumMember(Value = "oMemberQueues")]
            Omemberqueues,
            
            [EnumMember(Value = "oInteracting")]
            Ointeracting,
            
            [EnumMember(Value = "oWaiting")]
            Owaiting
        }

        

        /// <summary>
        /// Gets or Sets Metric
        /// </summary>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateMetricData" />class.
        /// </summary>
        /// <param name="Metric">Metric.</param>
        /// <param name="Qualifier">Qualifier.</param>
        /// <param name="Stats">Stats.</param>

        public AggregateMetricData(MetricEnum? Metric = null, string Qualifier = null, StatisticalSummary Stats = null)
        {
            this.Metric = Metric;
            this.Qualifier = Qualifier;
            this.Stats = Stats;
            
        }

    
        /// <summary>
        /// Gets or Sets Qualifier
        /// </summary>
        [DataMember(Name="qualifier", EmitDefaultValue=false)]
        public string Qualifier { get; set; }
    
        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public StatisticalSummary Stats { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregateMetricData {\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Qualifier: ").Append(Qualifier).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
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
            return this.Equals(obj as AggregateMetricData);
        }

        /// <summary>
        /// Returns true if AggregateMetricData instances are equal
        /// </summary>
        /// <param name="other">Instance of AggregateMetricData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregateMetricData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.Qualifier == other.Qualifier ||
                    this.Qualifier != null &&
                    this.Qualifier.Equals(other.Qualifier)
                ) &&
                (
                    this.Stats == other.Stats ||
                    this.Stats != null &&
                    this.Stats.Equals(other.Stats)
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
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();
                if (this.Qualifier != null)
                    hash = hash * 59 + this.Qualifier.GetHashCode();
                if (this.Stats != null)
                    hash = hash * 59 + this.Stats.GetHashCode();
                return hash;
            }
        }

    }
}
