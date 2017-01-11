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
    /// WrapUpCodeMappingNotification
    /// </summary>
    [DataContract]
    public partial class WrapUpCodeMappingNotification :  IEquatable<WrapUpCodeMappingNotification>
    {
        /// <summary>
        /// Gets or Sets Flag
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlagEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum ContactUncallable for "Contact_UnCallable"
            /// </summary>
            [EnumMember(Value = "Contact_UnCallable")]
            ContactUncallable,
            
            /// <summary>
            /// Enum NumberUncallable for "Number_UnCallable"
            /// </summary>
            [EnumMember(Value = "Number_UnCallable")]
            NumberUncallable,
            
            /// <summary>
            /// Enum RightPartyContact for "Right_Party_Contact"
            /// </summary>
            [EnumMember(Value = "Right_Party_Contact")]
            RightPartyContact
        }
        /// <summary>
        /// Gets or Sets DefaultSet
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DefaultSetEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum ContactUncallable for "Contact_UnCallable"
            /// </summary>
            [EnumMember(Value = "Contact_UnCallable")]
            ContactUncallable,
            
            /// <summary>
            /// Enum NumberUncallable for "Number_UnCallable"
            /// </summary>
            [EnumMember(Value = "Number_UnCallable")]
            NumberUncallable,
            
            /// <summary>
            /// Enum RightPartyContact for "Right_Party_Contact"
            /// </summary>
            [EnumMember(Value = "Right_Party_Contact")]
            RightPartyContact
        }
        /// <summary>
        /// Gets or Sets Flag
        /// </summary>
        [DataMember(Name="flag", EmitDefaultValue=false)]
        public FlagEnum? Flag { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WrapUpCodeMappingNotification" /> class.
        /// </summary>
        /// <param name="Flag">Flag.</param>
        /// <param name="DefaultSet">DefaultSet.</param>
        /// <param name="Mapping">Mapping.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="Version">Version.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public WrapUpCodeMappingNotification(FlagEnum? Flag = null, List<DefaultSetEnum> DefaultSet = null, Dictionary<string, List<string>> Mapping = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null, Object AdditionalProperties = null)
        {
            this.Flag = Flag;
            this.DefaultSet = DefaultSet;
            this.Mapping = Mapping;
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            this.AdditionalProperties = AdditionalProperties;
        }
        
        /// <summary>
        /// Gets or Sets DefaultSet
        /// </summary>
        [DataMember(Name="defaultSet", EmitDefaultValue=false)]
        public List<DefaultSetEnum> DefaultSet { get; set; }
        /// <summary>
        /// Gets or Sets Mapping
        /// </summary>
        [DataMember(Name="mapping", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> Mapping { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WrapUpCodeMappingNotification {\n");
            sb.Append("  Flag: ").Append(Flag).Append("\n");
            sb.Append("  DefaultSet: ").Append(DefaultSet).Append("\n");
            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as WrapUpCodeMappingNotification);
        }

        /// <summary>
        /// Returns true if WrapUpCodeMappingNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WrapUpCodeMappingNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WrapUpCodeMappingNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Flag == other.Flag ||
                    this.Flag != null &&
                    this.Flag.Equals(other.Flag)
                ) &&
                (
                    this.DefaultSet == other.DefaultSet ||
                    this.DefaultSet != null &&
                    this.DefaultSet.SequenceEqual(other.DefaultSet)
                ) &&
                (
                    this.Mapping == other.Mapping ||
                    this.Mapping != null &&
                    this.Mapping.SequenceEqual(other.Mapping)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                if (this.Flag != null)
                    hash = hash * 59 + this.Flag.GetHashCode();
                if (this.DefaultSet != null)
                    hash = hash * 59 + this.DefaultSet.GetHashCode();
                if (this.Mapping != null)
                    hash = hash * 59 + this.Mapping.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                return hash;
            }
        }
    }

}
