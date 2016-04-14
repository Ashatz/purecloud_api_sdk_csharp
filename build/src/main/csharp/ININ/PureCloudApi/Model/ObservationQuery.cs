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
    public partial class ObservationQuery :  IEquatable<ObservationQuery>
    { 
        
        public static string Metrics_Tsegmentduration = "tSegmentDuration";
        public static string Metrics_Ototalcriticalscore = "oTotalCriticalScore";
        public static string Metrics_Ototalscore = "oTotalScore";
        public static string Metrics_Nevaluations = "nEvaluations";
        public static string Metrics_Tabandon = "tAbandon";
        public static string Metrics_Tivr = "tIvr";
        public static string Metrics_Tanswered = "tAnswered";
        public static string Metrics_Tacd = "tAcd";
        public static string Metrics_Ttalk = "tTalk";
        public static string Metrics_Theld = "tHeld";
        public static string Metrics_Ttalkcomplete = "tTalkComplete";
        public static string Metrics_Theldcomplete = "tHeldComplete";
        public static string Metrics_Tacw = "tAcw";
        public static string Metrics_Thandle = "tHandle";
        public static string Metrics_Twait = "tWait";
        public static string Metrics_Tagentroutingstatus = "tAgentRoutingStatus";
        public static string Metrics_Torganizationpresence = "tOrganizationPresence";
        public static string Metrics_Tsystempresence = "tSystemPresence";
        public static string Metrics_Tuserresponsetime = "tUserResponseTime";
        public static string Metrics_Tagentresponsetime = "tAgentResponseTime";
        public static string Metrics_Noffered = "nOffered";
        public static string Metrics_Noversla = "nOverSla";
        public static string Metrics_Ntransferred = "nTransferred";
        public static string Metrics_Noutboundattempted = "nOutboundAttempted";
        public static string Metrics_Noutboundconnected = "nOutboundConnected";
        public static string Metrics_Noutboundabandoned = "nOutboundAbandoned";
        public static string Metrics_Nerror = "nError";
        public static string Metrics_Oservicetarget = "oServiceTarget";
        public static string Metrics_Oservicelevel = "oServiceLevel";
        public static string Metrics_Tactive = "tActive";
        public static string Metrics_Tinactive = "tInactive";
        public static string Metrics_Oactiveusers = "oActiveUsers";
        public static string Metrics_Omemberusers = "oMemberUsers";
        public static string Metrics_Oactivequeues = "oActiveQueues";
        public static string Metrics_Omemberqueues = "oMemberQueues";
        public static string Metrics_Ointeracting = "oInteracting";
        public static string Metrics_Owaiting = "oWaiting";
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationQuery" />class.
        /// </summary>
        /// <param name="Filter">Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters.</param>
        /// <param name="Metrics">Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *)..</param>

        public ObservationQuery(AnalyticsQueryFilter Filter = null, List<string> Metrics = null)
        {
            this.Filter = Filter;
            this.Metrics = Metrics;
            
        }

    
        /// <summary>
        /// Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters
        /// </summary>
        /// <value>Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public AnalyticsQueryFilter Filter { get; set; }
    
        /// <summary>
        /// Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *).
        /// </summary>
        /// <value>Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *).</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<string> Metrics { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObservationQuery {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
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
            return this.Equals(obj as ObservationQuery);
        }

        /// <summary>
        /// Returns true if ObservationQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of ObservationQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObservationQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
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
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();
                return hash;
            }
        }

    }
}
