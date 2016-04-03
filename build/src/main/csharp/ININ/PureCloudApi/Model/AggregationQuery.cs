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
    public partial class AggregationQuery :  IEquatable<AggregationQuery>
    { 
        
        public static string GroupBy_Conversationid = "conversationId";
        public static string GroupBy_Sessionid = "sessionId";
        public static string GroupBy_Mediatype = "mediaType";
        public static string GroupBy_Queueid = "queueId";
        public static string GroupBy_Userid = "userId";
        public static string GroupBy_Participantid = "participantId";
        public static string GroupBy_Participantname = "participantName";
        public static string GroupBy_Direction = "direction";
        public static string GroupBy_Wrapupcode = "wrapUpCode";
        public static string GroupBy_Wrapupnote = "wrapUpNote";
        public static string GroupBy_Interactiontype = "interactionType";
        public static string GroupBy_Requestedroutingskillid = "requestedRoutingSkillId";
        public static string GroupBy_Requestedlanguageid = "requestedLanguageId";
        public static string GroupBy_Purpose = "purpose";
        public static string GroupBy_Participanttype = "participantType";
        public static string GroupBy_Segmenttype = "segmentType";
        public static string GroupBy_Disconnecttype = "disconnectType";
        public static string GroupBy_Errorcode = "errorCode";
        public static string GroupBy_Stationid = "stationId";
        public static string GroupBy_Edgeid = "edgeId";
        public static string GroupBy_Dnis = "dnis";
        public static string GroupBy_Ani = "ani";
        public static string GroupBy_Outboundcampaignid = "outboundCampaignId";
        public static string GroupBy_Outboundcontactlistid = "outboundContactListId";
        public static string GroupBy_Monitoredparticipantid = "monitoredParticipantId";
        public static string GroupBy_Sourcesessionid = "sourceSessionId";
        public static string GroupBy_Destinationsessionid = "destinationSessionId";
        public static string GroupBy_Sourceconversationid = "sourceConversationId";
        public static string GroupBy_Destinationconversationid = "destinationConversationId";
        public static string GroupBy_Remotenamedisplayable = "remoteNameDisplayable";
        public static string GroupBy_Sipresponsecode = "sipResponseCode";
        public static string GroupBy_Q850responsecode = "q850ResponseCode";
        public static string GroupBy_Conference = "conference";
        public static string GroupBy_Groupid = "groupId";
        public static string GroupBy_Roomid = "roomId";
        public static string GroupBy_Addressfrom = "addressFrom";
        public static string GroupBy_Addressto = "addressTo";
        public static string GroupBy_Evaluationid = "evaluationId";
        public static string GroupBy_Evaluatorid = "evaluatorId";
        public static string GroupBy_Contextid = "contextId";
        public static string GroupBy_Formid = "formId";
        public static string GroupBy_Formname = "formName";
        public static string GroupBy_Eventtime = "eventTime";
        
        
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
        /// Initializes a new instance of the <see cref="AggregationQuery" />class.
        /// </summary>
        /// <param name="Interval">Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
        /// <param name="Granularity">Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H.</param>
        /// <param name="GroupBy">Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group..</param>
        /// <param name="Filter">Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters.</param>
        /// <param name="Metrics">Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *)..</param>
        /// <param name="FlattenMultivaluedDimensions">Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;) (default to false).</param>

        public AggregationQuery(DateTime? Interval = null, DateTime? Granularity = null, List<string> GroupBy = null, AnalyticsQueryFilter Filter = null, List<string> Metrics = null, bool? FlattenMultivaluedDimensions = null)
        {
            this.Interval = Interval;
            this.Granularity = Granularity;
            this.GroupBy = GroupBy;
            this.Filter = Filter;
            this.Metrics = Metrics;
            // use default value if no "FlattenMultivaluedDimensions" provided
            if (FlattenMultivaluedDimensions == null)
            {
                this.FlattenMultivaluedDimensions = false;
            }
            else
            {
                this.FlattenMultivaluedDimensions = FlattenMultivaluedDimensions;
            }
            
        }
        
    
        /// <summary>
        /// Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public DateTime? Interval { get; set; }
    
        /// <summary>
        /// Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
        /// </summary>
        /// <value>Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public DateTime? Granularity { get; set; }
    
        /// <summary>
        /// Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.
        /// </summary>
        /// <value>Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.</value>
        [DataMember(Name="groupBy", EmitDefaultValue=false)]
        public List<string> GroupBy { get; set; }
    
        /// <summary>
        /// Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters
        /// </summary>
        /// <value>Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public AnalyticsQueryFilter Filter { get; set; }
    
        /// <summary>
        /// Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *).
        /// </summary>
        /// <value>Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *).</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<string> Metrics { get; set; }
    
        /// <summary>
        /// Flattens any multivalued dimensions used in response groups (e.g. ['a','b','c']->'a,b,c')
        /// </summary>
        /// <value>Flattens any multivalued dimensions used in response groups (e.g. ['a','b','c']->'a,b,c')</value>
        [DataMember(Name="flattenMultivaluedDimensions", EmitDefaultValue=false)]
        public bool? FlattenMultivaluedDimensions { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregationQuery {\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  FlattenMultivaluedDimensions: ").Append(FlattenMultivaluedDimensions).Append("\n");
            
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
            return this.Equals(obj as AggregationQuery);
        }

        /// <summary>
        /// Returns true if AggregationQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of AggregationQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregationQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.GroupBy == other.GroupBy ||
                    this.GroupBy != null &&
                    this.GroupBy.SequenceEqual(other.GroupBy)
                ) &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.FlattenMultivaluedDimensions == other.FlattenMultivaluedDimensions ||
                    this.FlattenMultivaluedDimensions != null &&
                    this.FlattenMultivaluedDimensions.Equals(other.FlattenMultivaluedDimensions)
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
                
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();
                
                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();
                
                if (this.GroupBy != null)
                    hash = hash * 59 + this.GroupBy.GetHashCode();
                
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                
                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();
                
                if (this.FlattenMultivaluedDimensions != null)
                    hash = hash * 59 + this.FlattenMultivaluedDimensions.GetHashCode();
                
                return hash;
            }
        }

    }
}
