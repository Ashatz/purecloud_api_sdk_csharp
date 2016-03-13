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
    public partial class ServiceType :  IEquatable<ServiceType>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceType" />class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Parameters">Parameters.</param>
        /// <param name="Codecs">Codecs.</param>
        /// <param name="Strip">Prefix striping is a mechanism to remove digits from the beginning of a phone number before sending a call out to a carrier, such as international exit codes. This must be configurable on a per carrier basis as all carriers act differently..</param>
        /// <param name="CallingPartyId">CallingPartyId.</param>
        /// <param name="CallHistory">CallHistory.</param>
        /// <param name="Prefix">Prefix.</param>

        public ServiceType(string Type = null, Dictionary<string, string> Parameters = null, List<string> Codecs = null, string Strip = null, string CallingPartyId = null, string CallHistory = null, string Prefix = null)
        {
            this.Type = Type;
            this.Parameters = Parameters;
            this.Codecs = Codecs;
            this.Strip = Strip;
            this.CallingPartyId = CallingPartyId;
            this.CallHistory = CallHistory;
            this.Prefix = Prefix;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, string> Parameters { get; set; }
    
        /// <summary>
        /// Gets or Sets Codecs
        /// </summary>
        [DataMember(Name="codecs", EmitDefaultValue=false)]
        public List<string> Codecs { get; set; }
    
        /// <summary>
        /// Prefix striping is a mechanism to remove digits from the beginning of a phone number before sending a call out to a carrier, such as international exit codes. This must be configurable on a per carrier basis as all carriers act differently.
        /// </summary>
        /// <value>Prefix striping is a mechanism to remove digits from the beginning of a phone number before sending a call out to a carrier, such as international exit codes. This must be configurable on a per carrier basis as all carriers act differently.</value>
        [DataMember(Name="strip", EmitDefaultValue=false)]
        public string Strip { get; set; }
    
        /// <summary>
        /// Gets or Sets CallingPartyId
        /// </summary>
        [DataMember(Name="callingPartyId", EmitDefaultValue=false)]
        public string CallingPartyId { get; set; }
    
        /// <summary>
        /// Gets or Sets CallHistory
        /// </summary>
        [DataMember(Name="callHistory", EmitDefaultValue=false)]
        public string CallHistory { get; set; }
    
        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Codecs: ").Append(Codecs).Append("\n");
            sb.Append("  Strip: ").Append(Strip).Append("\n");
            sb.Append("  CallingPartyId: ").Append(CallingPartyId).Append("\n");
            sb.Append("  CallHistory: ").Append(CallHistory).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            
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
            return this.Equals(obj as ServiceType);
        }

        /// <summary>
        /// Returns true if ServiceType instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceType other)
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
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) &&
                (
                    this.Codecs == other.Codecs ||
                    this.Codecs != null &&
                    this.Codecs.SequenceEqual(other.Codecs)
                ) &&
                (
                    this.Strip == other.Strip ||
                    this.Strip != null &&
                    this.Strip.Equals(other.Strip)
                ) &&
                (
                    this.CallingPartyId == other.CallingPartyId ||
                    this.CallingPartyId != null &&
                    this.CallingPartyId.Equals(other.CallingPartyId)
                ) &&
                (
                    this.CallHistory == other.CallHistory ||
                    this.CallHistory != null &&
                    this.CallHistory.Equals(other.CallHistory)
                ) &&
                (
                    this.Prefix == other.Prefix ||
                    this.Prefix != null &&
                    this.Prefix.Equals(other.Prefix)
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
                
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                
                if (this.Codecs != null)
                    hash = hash * 59 + this.Codecs.GetHashCode();
                
                if (this.Strip != null)
                    hash = hash * 59 + this.Strip.GetHashCode();
                
                if (this.CallingPartyId != null)
                    hash = hash * 59 + this.CallingPartyId.GetHashCode();
                
                if (this.CallHistory != null)
                    hash = hash * 59 + this.CallHistory.GetHashCode();
                
                if (this.Prefix != null)
                    hash = hash * 59 + this.Prefix.GetHashCode();
                
                return hash;
            }
        }

    }
}
