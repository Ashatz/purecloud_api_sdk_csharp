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
    public partial class ConversationHistoricalQueryRequestFilter :  IEquatable<ConversationHistoricalQueryRequestFilter>
    { 

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TargetEnum {
            
            [EnumMember(Value = "interval")]
            Interval,
            
            [EnumMember(Value = "agentId")]
            Agentid,
            
            [EnumMember(Value = "queueId")]
            Queueid,
            
            [EnumMember(Value = "purpose")]
            Purpose,
            
            [EnumMember(Value = "duration")]
            Duration,
            
            [EnumMember(Value = "active")]
            Active,
            
            [EnumMember(Value = "freeText")]
            Freetext,
            
            [EnumMember(Value = "recordingRestored")]
            Recordingrestored,
            
            [EnumMember(Value = "connectedOnly")]
            Connectedonly,
            
            [EnumMember(Value = "dialerCampaignId")]
            Dialercampaignid,
            
            [EnumMember(Value = "wrapupCode")]
            Wrapupcode,
            
            [EnumMember(Value = "direction")]
            Direction,
            
            [EnumMember(Value = "mediaType")]
            Mediatype,
            
            [EnumMember(Value = "disconnectType")]
            Disconnecttype,
            
            [EnumMember(Value = "ani")]
            Ani,
            
            [EnumMember(Value = "dnis")]
            Dnis,
            
            [EnumMember(Value = "qualityEvaluationAgent")]
            Qualityevaluationagent,
            
            [EnumMember(Value = "qualityEvaluator")]
            Qualityevaluator,
            
            [EnumMember(Value = "qualityEvaluationForm")]
            Qualityevaluationform,
            
            [EnumMember(Value = "qualityEvaluationScore")]
            Qualityevaluationscore,
            
            [EnumMember(Value = "qualityEvaluationCriticalScore")]
            Qualityevaluationcriticalscore
        }


        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum _OperatorEnum {
            
            [EnumMember(Value = "equals")]
            Equals,
            
            [EnumMember(Value = "lessthan")]
            Lessthan,
            
            [EnumMember(Value = "lessthanequals")]
            Lessthanequals,
            
            [EnumMember(Value = "greaterthan")]
            Greaterthan,
            
            [EnumMember(Value = "greaterthanequals")]
            Greaterthanequals,
            
            [EnumMember(Value = "between")]
            Between,
            
            [EnumMember(Value = "before")]
            Before,
            
            [EnumMember(Value = "after")]
            After,
            
            [EnumMember(Value = "contains")]
            Contains
        }

        

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public TargetEnum? Target { get; set; }
    

        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public _OperatorEnum? _Operator { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoricalQueryRequestFilter" />class.
        /// </summary>
        /// <param name="Target">Target.</param>
        /// <param name="_Operator">_Operator.</param>
        /// <param name="Values">Values.</param>

        public ConversationHistoricalQueryRequestFilter(TargetEnum? Target = null, _OperatorEnum? _Operator = null, List<string> Values = null)
        {
            this.Target = Target;
            this._Operator = _Operator;
            this.Values = Values;
            
        }

    
        /// <summary>
        /// Gets or Sets Values
        /// </summary>
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

            return true &&
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
