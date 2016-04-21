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
    public partial class TermAttribute :  IEquatable<TermAttribute>
    { 

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum {
<<<<<<< HEAD
            
            [EnumMember(Value = "NUMBER")]
            Number,
            
            [EnumMember(Value = "STRING")]
            String,
            
            [EnumMember(Value = "DATE")]
            Date,
            
            [EnumMember(Value = "BOOLEAN")]
            Boolean,
            
            [EnumMember(Value = "LIST")]
            List,
            
            [EnumMember(Value = "GROUP")]
            Group
=======
            
            [EnumMember(Value = "NUMBER")]
            Number,
            
            [EnumMember(Value = "STRING")]
            String,
            
            [EnumMember(Value = "DATE")]
            Date,
            
            [EnumMember(Value = "BOOLEAN")]
            Boolean,
            
            [EnumMember(Value = "LIST")]
            List
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        }

        

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TermAttribute" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="WorkspaceId">WorkspaceId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Restrictions">Restrictions.</param>
        /// <param name="Format">Format.</param>
        /// <param name="MultipleValues">MultipleValues (default to false).</param>

        public TermAttribute(string Id = null, string WorkspaceId = null, string Name = null, TypeEnum? Type = null, AttributeRestrictions Restrictions = null, string Format = null, bool? MultipleValues = null)
        {
            this.Id = Id;
            this.WorkspaceId = WorkspaceId;
            this.Name = Name;
            this.Type = Type;
            this.Restrictions = Restrictions;
            this.Format = Format;
            // use default value if no "MultipleValues" provided
            if (MultipleValues == null)
            {
                this.MultipleValues = false;
            }
            else
            {
                this.MultipleValues = MultipleValues;
            }
            
        }

    
        /// <summary>
<<<<<<< HEAD
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets WorkspaceId
        /// </summary>
        [DataMember(Name="workspaceId", EmitDefaultValue=false)]
        public string WorkspaceId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
=======
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TermAttribute" />class.
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="restrictions", EmitDefaultValue=false)]
        public AttributeRestrictions Restrictions { get; set; }
=======
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>

        public TermAttribute(string Id = null, string Name = null, TypeEnum? Type = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Type = Type;
            
        }

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }
=======
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="multipleValues", EmitDefaultValue=false)]
        public bool? MultipleValues { get; set; }
=======
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TermAttribute {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
<<<<<<< HEAD
            sb.Append("  Restrictions: ").Append(Restrictions).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  MultipleValues: ").Append(MultipleValues).Append("\n");
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            return this.Equals(obj as TermAttribute);
        }

        /// <summary>
        /// Returns true if TermAttribute instances are equal
        /// </summary>
        /// <param name="other">Instance of TermAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TermAttribute other)
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
<<<<<<< HEAD
                (
                    this.WorkspaceId == other.WorkspaceId ||
                    this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(other.WorkspaceId)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
<<<<<<< HEAD
                ) &&
                (
                    this.Restrictions == other.Restrictions ||
                    this.Restrictions != null &&
                    this.Restrictions.Equals(other.Restrictions)
                ) &&
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) &&
                (
                    this.MultipleValues == other.MultipleValues ||
                    this.MultipleValues != null &&
                    this.MultipleValues.Equals(other.MultipleValues)
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                if (this.WorkspaceId != null)
                    hash = hash * 59 + this.WorkspaceId.GetHashCode();
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
<<<<<<< HEAD
                if (this.Restrictions != null)
                    hash = hash * 59 + this.Restrictions.GetHashCode();
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                if (this.MultipleValues != null)
                    hash = hash * 59 + this.MultipleValues.GetHashCode();
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
