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
    /// EntryFeatureBoolean
    /// </summary>
    [DataContract]
    public partial class EntryFeatureBoolean :  IEquatable<EntryFeatureBoolean>
    {
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum KeyEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Realtimecic for "realtimeCIC"
            /// </summary>
            [EnumMember(Value = "realtimeCIC")]
            Realtimecic,
            
            /// <summary>
            /// Enum Purecloud for "purecloud"
            /// </summary>
            [EnumMember(Value = "purecloud")]
            Purecloud,
            
            /// <summary>
            /// Enum Hipaa for "hipaa"
            /// </summary>
            [EnumMember(Value = "hipaa")]
            Hipaa,
            
            /// <summary>
            /// Enum Ucenabled for "ucEnabled"
            /// </summary>
            [EnumMember(Value = "ucEnabled")]
            Ucenabled,
            
            /// <summary>
            /// Enum Pci for "pci"
            /// </summary>
            [EnumMember(Value = "pci")]
            Pci,
            
            /// <summary>
            /// Enum Purecloudvoice for "purecloudVoice"
            /// </summary>
            [EnumMember(Value = "purecloudVoice")]
            Purecloudvoice,
            
            /// <summary>
            /// Enum Xmppfederation for "xmppFederation"
            /// </summary>
            [EnumMember(Value = "xmppFederation")]
            Xmppfederation,
            
            /// <summary>
            /// Enum Chat for "chat"
            /// </summary>
            [EnumMember(Value = "chat")]
            Chat,
            
            /// <summary>
            /// Enum Informalphotos for "informalPhotos"
            /// </summary>
            [EnumMember(Value = "informalPhotos")]
            Informalphotos,
            
            /// <summary>
            /// Enum Directory for "directory"
            /// </summary>
            [EnumMember(Value = "directory")]
            Directory,
            
            /// <summary>
            /// Enum Contactcenter for "contactCenter"
            /// </summary>
            [EnumMember(Value = "contactCenter")]
            Contactcenter,
            
            /// <summary>
            /// Enum Unifiedcommunications for "unifiedCommunications"
            /// </summary>
            [EnumMember(Value = "unifiedCommunications")]
            Unifiedcommunications,
            
            /// <summary>
            /// Enum Custserv for "custserv"
            /// </summary>
            [EnumMember(Value = "custserv")]
            Custserv
        }
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public KeyEnum? Key { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryFeatureBoolean" /> class.
        /// </summary>
        /// <param name="Value">Value.</param>
        /// <param name="Key">Key.</param>
        public EntryFeatureBoolean(bool? Value = null, KeyEnum? Key = null)
        {
            this.Value = Value;
            this.Key = Key;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public bool? Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntryFeatureBoolean {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(obj as EntryFeatureBoolean);
        }

        /// <summary>
        /// Returns true if EntryFeatureBoolean instances are equal
        /// </summary>
        /// <param name="other">Instance of EntryFeatureBoolean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntryFeatureBoolean other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                return hash;
            }
        }
    }

}
