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
    public partial class CreateCallbackCommand :  IEquatable<CreateCallbackCommand>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallbackCommand" />class.
        /// </summary>
        /// <param name="ScriptId">ScriptId.</param>
        /// <param name="QueueId">QueueId.</param>
        /// <param name="CallbackUserName">CallbackUserName.</param>
        /// <param name="CallbackNumbers">CallbackNumbers.</param>
        /// <param name="CallbackScheduledTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="CountryCode">CountryCode.</param>
        /// <param name="SkipEnabled">SkipEnabled (default to false).</param>

        public CreateCallbackCommand(string ScriptId = null, string QueueId = null, string CallbackUserName = null, List<string> CallbackNumbers = null, DateTime? CallbackScheduledTime = null, string CountryCode = null, bool? SkipEnabled = null)
        {
            this.ScriptId = ScriptId;
            this.QueueId = QueueId;
            this.CallbackUserName = CallbackUserName;
            this.CallbackNumbers = CallbackNumbers;
            this.CallbackScheduledTime = CallbackScheduledTime;
            this.CountryCode = CountryCode;
            // use default value if no "SkipEnabled" provided
            if (SkipEnabled == null)
            {
                this.SkipEnabled = false;
            }
            else
            {
                this.SkipEnabled = SkipEnabled;
            }
            
        }

    
        /// <summary>
        /// Gets or Sets ScriptId
        /// </summary>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public string ScriptId { get; set; }
    
        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
    
        /// <summary>
        /// Gets or Sets CallbackUserName
        /// </summary>
        [DataMember(Name="callbackUserName", EmitDefaultValue=false)]
        public string CallbackUserName { get; set; }
    
        /// <summary>
        /// Gets or Sets CallbackNumbers
        /// </summary>
        [DataMember(Name="callbackNumbers", EmitDefaultValue=false)]
        public List<string> CallbackNumbers { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="callbackScheduledTime", EmitDefaultValue=false)]
        public DateTime? CallbackScheduledTime { get; set; }
    
        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
    
        /// <summary>
        /// Gets or Sets SkipEnabled
        /// </summary>
        [DataMember(Name="skipEnabled", EmitDefaultValue=false)]
        public bool? SkipEnabled { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCallbackCommand {\n");
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  CallbackUserName: ").Append(CallbackUserName).Append("\n");
            sb.Append("  CallbackNumbers: ").Append(CallbackNumbers).Append("\n");
            sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  SkipEnabled: ").Append(SkipEnabled).Append("\n");
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
            return this.Equals(obj as CreateCallbackCommand);
        }

        /// <summary>
        /// Returns true if CreateCallbackCommand instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCallbackCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCallbackCommand other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ScriptId == other.ScriptId ||
                    this.ScriptId != null &&
                    this.ScriptId.Equals(other.ScriptId)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.CallbackUserName == other.CallbackUserName ||
                    this.CallbackUserName != null &&
                    this.CallbackUserName.Equals(other.CallbackUserName)
                ) &&
                (
                    this.CallbackNumbers == other.CallbackNumbers ||
                    this.CallbackNumbers != null &&
                    this.CallbackNumbers.SequenceEqual(other.CallbackNumbers)
                ) &&
                (
                    this.CallbackScheduledTime == other.CallbackScheduledTime ||
                    this.CallbackScheduledTime != null &&
                    this.CallbackScheduledTime.Equals(other.CallbackScheduledTime)
                ) &&
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) &&
                (
                    this.SkipEnabled == other.SkipEnabled ||
                    this.SkipEnabled != null &&
                    this.SkipEnabled.Equals(other.SkipEnabled)
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
                if (this.ScriptId != null)
                    hash = hash * 59 + this.ScriptId.GetHashCode();
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                if (this.CallbackUserName != null)
                    hash = hash * 59 + this.CallbackUserName.GetHashCode();
                if (this.CallbackNumbers != null)
                    hash = hash * 59 + this.CallbackNumbers.GetHashCode();
                if (this.CallbackScheduledTime != null)
                    hash = hash * 59 + this.CallbackScheduledTime.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.SkipEnabled != null)
                    hash = hash * 59 + this.SkipEnabled.GetHashCode();
                return hash;
            }
        }

    }
}
