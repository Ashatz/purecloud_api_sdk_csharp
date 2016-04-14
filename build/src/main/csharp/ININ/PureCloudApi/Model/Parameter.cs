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
    public partial class Parameter :  IEquatable<Parameter>
    { 

        /// <summary>
        /// Gets or Sets ParameterType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ParameterTypeEnum {
            
            [EnumMember(Value = "UUID")]
            Uuid,
            
            [EnumMember(Value = "STRING")]
            String,
            
            [EnumMember(Value = "UUIDLIST")]
            Uuidlist,
            
            [EnumMember(Value = "STRINGLIST")]
            Stringlist
        }


        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DomainEnum {
            
            [EnumMember(Value = "USERID")]
            Userid,
            
            [EnumMember(Value = "QUEUEID")]
            Queueid,
            
            [EnumMember(Value = "MEDIATYPE")]
            Mediatype,
            
            [EnumMember(Value = "DIALERCAMPAIGNID")]
            Dialercampaignid,
            
            [EnumMember(Value = "QMEVALFORMID")]
            Qmevalformid,
            
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        }

        
        /// <summary>
        /// Gets or Sets ParameterType
        /// </summary>
        [DataMember(Name="parameterType", EmitDefaultValue=false)]
        public ParameterTypeEnum? ParameterType { get; set; }
    
        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public DomainEnum? Domain { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ParameterType">ParameterType.</param>
        /// <param name="Domain">Domain.</param>
        /// <param name="Required">Required (default to false).</param>

        public Parameter(string Name = null, ParameterTypeEnum? ParameterType = null, DomainEnum? Domain = null, bool? Required = null)
        {
            this.Name = Name;
            this.ParameterType = ParameterType;
            this.Domain = Domain;
            // use default value if no "Required" provided
            if (Required == null)
            {
                this.Required = false;
            }
            else
            {
                this.Required = Required;
            }
            
        }

    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Parameter {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParameterType: ").Append(ParameterType).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
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
            return this.Equals(obj as Parameter);
        }

        /// <summary>
        /// Returns true if Parameter instances are equal
        /// </summary>
        /// <param name="other">Instance of Parameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Parameter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ParameterType == other.ParameterType ||
                    this.ParameterType != null &&
                    this.ParameterType.Equals(other.ParameterType)
                ) &&
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) &&
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ParameterType != null)
                    hash = hash * 59 + this.ParameterType.GetHashCode();
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                return hash;
            }
        }

    }
}
