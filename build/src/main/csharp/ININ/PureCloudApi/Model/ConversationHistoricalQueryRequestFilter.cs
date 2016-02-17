using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// Historical conversation request filter
    /// </summary>
    [DataContract]
    public partial class ConversationHistoricalQueryRequestFilter :  IEquatable<ConversationHistoricalQueryRequestFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoricalQueryRequestFilter" /> class.
        /// </summary>
        public ConversationHistoricalQueryRequestFilter()
        {
            
        }

        
        /// <summary>
        /// Filter target
        /// </summary>
        /// <value>Filter target</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public string Target { get; set; }
  
        
        /// <summary>
        /// Filter operator. For target 'interval' allowable values are '=', 'between', '<=', 'before', '>=', 'after'. For targets 'active', 'agentId', 'connectedOnly', 'dialerCampaignId', 'disconnectType', 'mediaType', 'purpose', 'qualityEvaluationAgent', 'qualityEvaluationForm', 'qualityEvaluator', 'queueId', 'wrapUpCode' allowable value is '='. For target 'duration' allowable values are '=', '<', '<=', '>', '>='. For targets 'ani', 'dnis', 'freeText' allowable value is 'contains'. For targets 'recordingRestored', 'qualityEvaluationCriticalScore', ', qualityEvaluationScore' no operator is required
        /// </summary>
        /// <value>Filter operator. For target 'interval' allowable values are '=', 'between', '<=', 'before', '>=', 'after'. For targets 'active', 'agentId', 'connectedOnly', 'dialerCampaignId', 'disconnectType', 'mediaType', 'purpose', 'qualityEvaluationAgent', 'qualityEvaluationForm', 'qualityEvaluator', 'queueId', 'wrapUpCode' allowable value is '='. For target 'duration' allowable values are '=', '<', '<=', '>', '>='. For targets 'ani', 'dnis', 'freeText' allowable value is 'contains'. For targets 'recordingRestored', 'qualityEvaluationCriticalScore', ', qualityEvaluationScore' no operator is required</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public string Operator { get; set; }
  
        
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
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
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
                
                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();
                
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                
                return hash;
            }
        }

    }
}
