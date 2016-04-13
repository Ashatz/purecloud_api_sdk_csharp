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
    public partial class DependencyObject :  IEquatable<DependencyObject>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "ACDLANGUAGE")]
            Acdlanguage,
            
            [EnumMember(Value = "ACDSKILL")]
            Acdskill,
            
            [EnumMember(Value = "ACDWRAPUPCODE")]
            Acdwrapupcode,
            
            [EnumMember(Value = "BRIDGEACTION")]
            Bridgeaction,
            
            [EnumMember(Value = "COMPOSERSCRIPT")]
            Composerscript,
            
            [EnumMember(Value = "CONTACTLIST")]
            Contactlist,
            
            [EnumMember(Value = "INBOUNDCALLFLOW")]
            Inboundcallflow,
            
            [EnumMember(Value = "INQUEUECALLFLOW")]
            Inqueuecallflow,
            
            [EnumMember(Value = "IVRCONFIGURATION")]
            Ivrconfiguration,
            
            [EnumMember(Value = "LANGUAGE")]
            Language,
            
            [EnumMember(Value = "OUTBOUNDCALLFLOW")]
            Outboundcallflow,
            
            [EnumMember(Value = "QUEUE")]
            Queue,
            
            [EnumMember(Value = "SYSTEMPROMPT")]
            Systemprompt,
            
            [EnumMember(Value = "USER")]
            User,
            
            [EnumMember(Value = "USERPROMPT")]
            Userprompt,
            
            [EnumMember(Value = "VOICEXML")]
            Voicexml
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyObject" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">Version.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Deleted">Deleted (default to false).</param>
        /// <param name="ConsumedResources">ConsumedResources.</param>
        /// <param name="ConsumingResources">ConsumingResources.</param>

        public DependencyObject(string Name = null, string Version = null, TypeEnum? Type = null, bool? Deleted = null, List<Dependency> ConsumedResources = null, List<Dependency> ConsumingResources = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.Type = Type;
            // use default value if no "Deleted" provided
            if (Deleted == null)
            {
                this.Deleted = false;
            }
            else
            {
                this.Deleted = Deleted;
            }
            this.ConsumedResources = ConsumedResources;
            this.ConsumingResources = ConsumingResources;
            
        }
        
    
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
    
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }
    
        /// <summary>
        /// Gets or Sets ConsumedResources
        /// </summary>
        [DataMember(Name="consumedResources", EmitDefaultValue=false)]
        public List<Dependency> ConsumedResources { get; set; }
    
        /// <summary>
        /// Gets or Sets ConsumingResources
        /// </summary>
        [DataMember(Name="consumingResources", EmitDefaultValue=false)]
        public List<Dependency> ConsumingResources { get; set; }
    
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DependencyObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  ConsumedResources: ").Append(ConsumedResources).Append("\n");
            sb.Append("  ConsumingResources: ").Append(ConsumingResources).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            
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
            return this.Equals(obj as DependencyObject);
        }

        /// <summary>
        /// Returns true if DependencyObject instances are equal
        /// </summary>
        /// <param name="other">Instance of DependencyObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DependencyObject other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Deleted == other.Deleted ||
                    this.Deleted != null &&
                    this.Deleted.Equals(other.Deleted)
                ) &&
                (
                    this.ConsumedResources == other.ConsumedResources ||
                    this.ConsumedResources != null &&
                    this.ConsumedResources.SequenceEqual(other.ConsumedResources)
                ) &&
                (
                    this.ConsumingResources == other.ConsumingResources ||
                    this.ConsumingResources != null &&
                    this.ConsumingResources.SequenceEqual(other.ConsumingResources)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Deleted != null)
                    hash = hash * 59 + this.Deleted.GetHashCode();
                
                if (this.ConsumedResources != null)
                    hash = hash * 59 + this.ConsumedResources.GetHashCode();
                
                if (this.ConsumingResources != null)
                    hash = hash * 59 + this.ConsumingResources.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
