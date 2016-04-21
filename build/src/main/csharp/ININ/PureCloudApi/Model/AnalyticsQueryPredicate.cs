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
    public partial class AnalyticsQueryPredicate :  IEquatable<AnalyticsQueryPredicate>
    { 

        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum {
            
            [EnumMember(Value = "dimension")]
            Dimension,
            
            [EnumMember(Value = "property")]
            Property,
            
            [EnumMember(Value = "metric")]
            Metric
        }


        /// <summary>
        /// Left hand side for dimension predicates
        /// </summary>
        /// <value>Left hand side for dimension predicates</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DimensionEnum {
            
            [EnumMember(Value = "conversationId")]
            Conversationid,
            
            [EnumMember(Value = "sessionId")]
            Sessionid,
            
            [EnumMember(Value = "mediaType")]
            Mediatype,
            
            [EnumMember(Value = "queueId")]
            Queueid,
            
            [EnumMember(Value = "userId")]
            Userid,
            
            [EnumMember(Value = "participantId")]
            Participantid,
            
            [EnumMember(Value = "participantName")]
            Participantname,
            
            [EnumMember(Value = "direction")]
            Direction,
            
            [EnumMember(Value = "wrapUpCode")]
            Wrapupcode,
            
            [EnumMember(Value = "wrapUpNote")]
            Wrapupnote,
            
            [EnumMember(Value = "interactionType")]
            Interactiontype,
            
            [EnumMember(Value = "requestedRoutingSkillId")]
            Requestedroutingskillid,
            
            [EnumMember(Value = "requestedLanguageId")]
            Requestedlanguageid,
            
            [EnumMember(Value = "purpose")]
            Purpose,
            
            [EnumMember(Value = "participantType")]
            Participanttype,
            
            [EnumMember(Value = "segmentType")]
            Segmenttype,
            
            [EnumMember(Value = "disconnectType")]
            Disconnecttype,
            
            [EnumMember(Value = "errorCode")]
            Errorcode,
            
            [EnumMember(Value = "stationId")]
            Stationid,
            
            [EnumMember(Value = "edgeId")]
            Edgeid,
            
            [EnumMember(Value = "dnis")]
            Dnis,
            
            [EnumMember(Value = "ani")]
            Ani,
            
            [EnumMember(Value = "outboundCampaignId")]
            Outboundcampaignid,
            
            [EnumMember(Value = "outboundContactListId")]
            Outboundcontactlistid,
            
            [EnumMember(Value = "monitoredParticipantId")]
            Monitoredparticipantid,
            
            [EnumMember(Value = "sourceSessionId")]
            Sourcesessionid,
            
            [EnumMember(Value = "destinationSessionId")]
            Destinationsessionid,
            
            [EnumMember(Value = "sourceConversationId")]
            Sourceconversationid,
            
            [EnumMember(Value = "destinationConversationId")]
            Destinationconversationid,
            
            [EnumMember(Value = "remoteNameDisplayable")]
            Remotenamedisplayable,
            
            [EnumMember(Value = "sipResponseCode")]
            Sipresponsecode,
            
            [EnumMember(Value = "q850ResponseCode")]
            Q850responsecode,
            
            [EnumMember(Value = "conference")]
            Conference,
            
            [EnumMember(Value = "groupId")]
            Groupid,
            
            [EnumMember(Value = "roomId")]
            Roomid,
            
            [EnumMember(Value = "addressFrom")]
            Addressfrom,
            
            [EnumMember(Value = "addressTo")]
            Addressto,
            
            [EnumMember(Value = "evaluationId")]
            Evaluationid,
            
            [EnumMember(Value = "evaluatorId")]
            Evaluatorid,
            
            [EnumMember(Value = "contextId")]
            Contextid,
            
            [EnumMember(Value = "formId")]
            Formid,
            
            [EnumMember(Value = "formName")]
            Formname,
            
            [EnumMember(Value = "eventTime")]
            Eventtime
        }


        /// <summary>
        /// Left hand side for property predicates
        /// </summary>
        /// <value>Left hand side for property predicates</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PropertyTypeEnum {
            
            [EnumMember(Value = "bool")]
            Bool,
            
            [EnumMember(Value = "integer")]
            Integer,
            
            [EnumMember(Value = "real")]
            Real,
            
            [EnumMember(Value = "date")]
            Date,
            
            [EnumMember(Value = "string")]
            String,
            
            [EnumMember(Value = "uuid")]
            Uuid
        }


        /// <summary>
        /// Left hand side for metric predicates
        /// </summary>
        /// <value>Left hand side for metric predicates</value>
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
        /// Optional operator, default is matches
        /// </summary>
        /// <value>Optional operator, default is matches</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum _OperatorEnum {
            
            [EnumMember(Value = "matches")]
            Matches,
            
            [EnumMember(Value = "exists")]
            Exists,
            
            [EnumMember(Value = "notExists")]
            Notexists
        }

        
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Left hand side for dimension predicates
        /// </summary>
        /// <value>Left hand side for dimension predicates</value>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public DimensionEnum? Dimension { get; set; }
    
        /// <summary>
        /// Left hand side for property predicates
        /// </summary>
        /// <value>Left hand side for property predicates</value>
        [DataMember(Name="propertyType", EmitDefaultValue=false)]
        public PropertyTypeEnum? PropertyType { get; set; }
    
        /// <summary>
        /// Left hand side for metric predicates
        /// </summary>
        /// <value>Left hand side for metric predicates</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
    
        /// <summary>
        /// Optional operator, default is matches
        /// </summary>
        /// <value>Optional operator, default is matches</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public _OperatorEnum? _Operator { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPredicate" />class.
        /// </summary>
        /// <param name="Type">Optional type, can usually be inferred.</param>
        /// <param name="Dimension">Left hand side for dimension predicates.</param>
        /// <param name="PropertyType">Left hand side for property predicates.</param>
        /// <param name="Property">Left hand side for property predicates.</param>
        /// <param name="Metric">Left hand side for metric predicates.</param>
        /// <param name="_Operator">Optional operator, default is matches.</param>
        /// <param name="Value">Right hand side for dimension, property, or metric predicates.</param>
        /// <param name="Range">Right hand side for property or metric predicates.</param>

        public AnalyticsQueryPredicate(TypeEnum? Type = null, DimensionEnum? Dimension = null, PropertyTypeEnum? PropertyType = null, string Property = null, MetricEnum? Metric = null, _OperatorEnum? _Operator = null, string Value = null, NumericRange Range = null)
        {
            this.Type = Type;
            this.Dimension = Dimension;
            this.PropertyType = PropertyType;
            this.Property = Property;
            this.Metric = Metric;
            this._Operator = _Operator;
            this.Value = Value;
            this.Range = Range;
            
        }

    
        /// <summary>
        /// Left hand side for property predicates
        /// </summary>
        /// <value>Left hand side for property predicates</value>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }
    
        /// <summary>
        /// Right hand side for dimension, property, or metric predicates
        /// </summary>
        /// <value>Right hand side for dimension, property, or metric predicates</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
    
        /// <summary>
        /// Right hand side for property or metric predicates
        /// </summary>
        /// <value>Right hand side for property or metric predicates</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public NumericRange Range { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsQueryPredicate {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(obj as AnalyticsQueryPredicate);
        }

        /// <summary>
        /// Returns true if AnalyticsQueryPredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsQueryPredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsQueryPredicate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Dimension == other.Dimension ||
                    this.Dimension != null &&
                    this.Dimension.Equals(other.Dimension)
                ) &&
                (
                    this.PropertyType == other.PropertyType ||
                    this.PropertyType != null &&
                    this.PropertyType.Equals(other.PropertyType)
                ) &&
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Dimension != null)
                    hash = hash * 59 + this.Dimension.GetHashCode();
                if (this.PropertyType != null)
                    hash = hash * 59 + this.PropertyType.GetHashCode();
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();
                return hash;
            }
        }

    }
}
