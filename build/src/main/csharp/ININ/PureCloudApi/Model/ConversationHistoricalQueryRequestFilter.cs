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
    /// Historical conversation request filter
    /// </summary>
    [DataContract]
    public partial class ConversationHistoricalQueryRequestFilter :  IEquatable<ConversationHistoricalQueryRequestFilter>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetEnum {
            
            [EnumMember(Value = "active")]
            Active,
            
            [EnumMember(Value = "agentId")]
            Agentid,
            
            [EnumMember(Value = "ani")]
            Ani,
            
            [EnumMember(Value = "connectedOnly")]
            Connectedonly,
            
            [EnumMember(Value = "dialerCampaignId")]
            Dialercampaignid,
            
            [EnumMember(Value = "disconnectType")]
            Disconnecttype,
            
            [EnumMember(Value = "dnis")]
            Dnis,
            
            [EnumMember(Value = "duration")]
            Duration,
            
            [EnumMember(Value = "interval")]
            Interval,
            
            [EnumMember(Value = "freeText")]
            Freetext,
            
            [EnumMember(Value = "mediaType")]
            Mediatype,
            
            [EnumMember(Value = "qualityEvaluationAgent")]
            Qualityevaluationagent,
            
            [EnumMember(Value = "qualityEvaluationCriticalScore")]
            Qualityevaluationcriticalscore,
            
            [EnumMember(Value = "qualityEvaluationForm")]
            Qualityevaluationform,
            
            [EnumMember(Value = "qualityEvaluationScore")]
            Qualityevaluationscore,
            
            [EnumMember(Value = "qualityEvaluator")]
            Qualityevaluator,
            
            [EnumMember(Value = "queueId")]
            Queueid,
            
            [EnumMember(Value = "purpose")]
            Purpose,
            
            [EnumMember(Value = "recordingRestored")]
            Recordingrestored,
            
            [EnumMember(Value = "wrapUpCode")]
            Wrapupcode
        }
    
        /// <summary>
        /// Filter target
        /// </summary>
        /// <value>Filter target</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public TargetEnum? Target { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoricalQueryRequestFilter" /> class.
        /// Initializes a new instance of the <see cref="ConversationHistoricalQueryRequestFilter" />class.
        /// </summary>
        /// <param name="Target">Filter target (required).</param>
        /// <param name="_Operator">Filter operator. For target &#39;interval&#39; allowable values are &#39;=&#39;, &#39;between&#39;, &#39;&lt;=&#39;, &#39;before&#39;, &#39;&gt;=&#39;, &#39;after&#39;. For targets &#39;active&#39;, &#39;agentId&#39;, &#39;connectedOnly&#39;, &#39;dialerCampaignId&#39;, &#39;disconnectType&#39;, &#39;mediaType&#39;, &#39;purpose&#39;, &#39;qualityEvaluationAgent&#39;, &#39;qualityEvaluationForm&#39;, &#39;qualityEvaluator&#39;, &#39;queueId&#39;, &#39;wrapUpCode&#39; allowable value is &#39;=&#39;. For target &#39;duration&#39; allowable values are &#39;=&#39;, &#39;&lt;&#39;, &#39;&lt;=&#39;, &#39;&gt;&#39;, &#39;&gt;=&#39;. For targets &#39;ani&#39;, &#39;dnis&#39;, &#39;freeText&#39; allowable value is &#39;contains&#39;. For targets &#39;recordingRestored&#39;, &#39;qualityEvaluationCriticalScore&#39;, &#39;, qualityEvaluationScore&#39; no operator is required (required).</param>
        /// <param name="Values">Filter values. For target &#39;interval&#39; with operators &#39;=&#39; or &#39;between&#39;, only 1 value is allowed in the form of 2 ISO-8601 dates separated by a &#39;/&#39; with no spaces. For target &#39;interval&#39; with operators &#39;&lt;=&#39;, &#39;before&#39;, &#39;&gt;=&#39;, &#39;after&#39;, only 1 value is allowed in the form of 1 ISO-8601 date. For targets &#39;agentId&#39;, &#39;dialerCampaignId&#39;, &#39;qualityEvaluationAgent&#39;, &#39;qualityEvaluationForm&#39;, &#39;qualityEvaluator&#39;, &#39;queueId&#39;, &#39;wrapUpCode&#39; multiple values are allowed. All values are UUIDs. For target &#39;disconnectType&#39; multiple values are allowed. Values can be one of &#39;TRANSFER&#39;, &#39;CLIENT&#39;, &#39;REMOTE&#39;. For target &#39;mediaType&#39; multiple values are allowed. Values can be one of &#39;VOICE&#39;, &#39;CHAT&#39;, &#39;EMAIL&#39;.For target &#39;purpose&#39; multiple values are allowed. For targets &#39;active&#39;, &#39;connectedOnly&#39;1 value is required and it must be either &#39;true&#39; or &#39;false&#39;. For target &#39;duration&#39; 2 values are required for operator &#39;=&#39;. For all other operators, 1 value is required. For targets &#39;ani&#39;, &#39;dnis&#39;, &#39;freeText&#39; only a single value is allowed. For targets &#39;recordingRestored&#39;, &#39;qualityEvaluationCriticalScore&#39;, &#39;, qualityEvaluationScore&#39; no values are required. (required).</param>

        public ConversationHistoricalQueryRequestFilter(TargetEnum? Target = null, string _Operator = null, List<string> Values = null)
        {
            // to ensure "Target" is required (not null)
            if (Target == null)
            {
                throw new InvalidDataException("Target is a required property for ConversationHistoricalQueryRequestFilter and cannot be null");
            }
            else
            {
                this.Target = Target;
            }
            // to ensure "_Operator" is required (not null)
            if (_Operator == null)
            {
                throw new InvalidDataException("_Operator is a required property for ConversationHistoricalQueryRequestFilter and cannot be null");
            }
            else
            {
                this._Operator = _Operator;
            }
            // to ensure "Values" is required (not null)
            if (Values == null)
            {
                throw new InvalidDataException("Values is a required property for ConversationHistoricalQueryRequestFilter and cannot be null");
            }
            else
            {
                this.Values = Values;
            }
            
        }
        
    
        /// <summary>
        /// Filter operator. For target 'interval' allowable values are '=', 'between', '<=', 'before', '>=', 'after'. For targets 'active', 'agentId', 'connectedOnly', 'dialerCampaignId', 'disconnectType', 'mediaType', 'purpose', 'qualityEvaluationAgent', 'qualityEvaluationForm', 'qualityEvaluator', 'queueId', 'wrapUpCode' allowable value is '='. For target 'duration' allowable values are '=', '<', '<=', '>', '>='. For targets 'ani', 'dnis', 'freeText' allowable value is 'contains'. For targets 'recordingRestored', 'qualityEvaluationCriticalScore', ', qualityEvaluationScore' no operator is required
        /// </summary>
        /// <value>Filter operator. For target 'interval' allowable values are '=', 'between', '<=', 'before', '>=', 'after'. For targets 'active', 'agentId', 'connectedOnly', 'dialerCampaignId', 'disconnectType', 'mediaType', 'purpose', 'qualityEvaluationAgent', 'qualityEvaluationForm', 'qualityEvaluator', 'queueId', 'wrapUpCode' allowable value is '='. For target 'duration' allowable values are '=', '<', '<=', '>', '>='. For targets 'ani', 'dnis', 'freeText' allowable value is 'contains'. For targets 'recordingRestored', 'qualityEvaluationCriticalScore', ', qualityEvaluationScore' no operator is required</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public string _Operator { get; set; }
    
        /// <summary>
        /// Filter values. For target 'interval' with operators '=' or 'between', only 1 value is allowed in the form of 2 ISO-8601 dates separated by a '/' with no spaces. For target 'interval' with operators '<=', 'before', '>=', 'after', only 1 value is allowed in the form of 1 ISO-8601 date. For targets 'agentId', 'dialerCampaignId', 'qualityEvaluationAgent', 'qualityEvaluationForm', 'qualityEvaluator', 'queueId', 'wrapUpCode' multiple values are allowed. All values are UUIDs. For target 'disconnectType' multiple values are allowed. Values can be one of 'TRANSFER', 'CLIENT', 'REMOTE'. For target 'mediaType' multiple values are allowed. Values can be one of 'VOICE', 'CHAT', 'EMAIL'.For target 'purpose' multiple values are allowed. For targets 'active', 'connectedOnly'1 value is required and it must be either 'true' or 'false'. For target 'duration' 2 values are required for operator '='. For all other operators, 1 value is required. For targets 'ani', 'dnis', 'freeText' only a single value is allowed. For targets 'recordingRestored', 'qualityEvaluationCriticalScore', ', qualityEvaluationScore' no values are required.
        /// </summary>
        /// <value>Filter values. For target 'interval' with operators '=' or 'between', only 1 value is allowed in the form of 2 ISO-8601 dates separated by a '/' with no spaces. For target 'interval' with operators '<=', 'before', '>=', 'after', only 1 value is allowed in the form of 1 ISO-8601 date. For targets 'agentId', 'dialerCampaignId', 'qualityEvaluationAgent', 'qualityEvaluationForm', 'qualityEvaluator', 'queueId', 'wrapUpCode' multiple values are allowed. All values are UUIDs. For target 'disconnectType' multiple values are allowed. Values can be one of 'TRANSFER', 'CLIENT', 'REMOTE'. For target 'mediaType' multiple values are allowed. Values can be one of 'VOICE', 'CHAT', 'EMAIL'.For target 'purpose' multiple values are allowed. For targets 'active', 'connectedOnly'1 value is required and it must be either 'true' or 'false'. For target 'duration' 2 values are required for operator '='. For all other operators, 1 value is required. For targets 'ani', 'dnis', 'freeText' only a single value is allowed. For targets 'recordingRestored', 'qualityEvaluationCriticalScore', ', qualityEvaluationScore' no values are required.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationHistoricalQueryRequestFilter {\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            
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
            return this.Equals(obj as ConversationHistoricalQueryRequestFilter);
        }

        /// <summary>
        /// Returns true if ConversationHistoricalQueryRequestFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationHistoricalQueryRequestFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationHistoricalQueryRequestFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) && 
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) && 
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                
                return hash;
            }
        }

    }
}
