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
    /// An additional data element that was set by the user for this event.
    /// </summary>
    [DataContract]
    public partial class SubDataItem :  IEquatable<SubDataItem>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SubDataItem" />class.
        /// </summary>
        /// <param name="Id">The id of this element (required).</param>
        /// <param name="Type">The &#39;type&#39; of the element, this may be a system value, EG &#39;STRING&#39; or a user defined type (required).</param>
        /// <param name="Value">The value of the element itself - This may be a simple value or more complex serialized data. (required).</param>
        /// <param name="Prompt">The prompt displayed to the user that this data item was set from. (required).</param>
        /// <param name="DisplayValue">The display value that was offered to the user (as opposed to the actual value used internally (required).</param>

        public SubDataItem(string Id = null, string Type = null, string Value = null, string Prompt = null, string DisplayValue = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for SubDataItem and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for SubDataItem and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for SubDataItem and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
            // to ensure "Prompt" is required (not null)
            if (Prompt == null)
            {
                throw new InvalidDataException("Prompt is a required property for SubDataItem and cannot be null");
            }
            else
            {
                this.Prompt = Prompt;
            }
            // to ensure "DisplayValue" is required (not null)
            if (DisplayValue == null)
            {
                throw new InvalidDataException("DisplayValue is a required property for SubDataItem and cannot be null");
            }
            else
            {
                this.DisplayValue = DisplayValue;
            }
            
        }
        
    
        /// <summary>
        /// The id of this element
        /// </summary>
        /// <value>The id of this element</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// The 'type' of the element, this may be a system value, EG 'STRING' or a user defined type
        /// </summary>
        /// <value>The 'type' of the element, this may be a system value, EG 'STRING' or a user defined type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
        /// <summary>
        /// The value of the element itself - This may be a simple value or more complex serialized data.
        /// </summary>
        /// <value>The value of the element itself - This may be a simple value or more complex serialized data.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
    
        /// <summary>
        /// The prompt displayed to the user that this data item was set from.
        /// </summary>
        /// <value>The prompt displayed to the user that this data item was set from.</value>
        [DataMember(Name="prompt", EmitDefaultValue=false)]
        public string Prompt { get; set; }
    
        /// <summary>
        /// The display value that was offered to the user (as opposed to the actual value used internally
        /// </summary>
        /// <value>The display value that was offered to the user (as opposed to the actual value used internally</value>
        [DataMember(Name="displayValue", EmitDefaultValue=false)]
        public string DisplayValue { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubDataItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  DisplayValue: ").Append(DisplayValue).Append("\n");
            
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
            return this.Equals(obj as SubDataItem);
        }

        /// <summary>
        /// Returns true if SubDataItem instances are equal
        /// </summary>
        /// <param name="other">Instance of SubDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubDataItem other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Prompt == other.Prompt ||
                    this.Prompt != null &&
                    this.Prompt.Equals(other.Prompt)
                ) &&
                (
                    this.DisplayValue == other.DisplayValue ||
                    this.DisplayValue != null &&
                    this.DisplayValue.Equals(other.DisplayValue)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.Prompt != null)
                    hash = hash * 59 + this.Prompt.GetHashCode();
                
                if (this.DisplayValue != null)
                    hash = hash * 59 + this.DisplayValue.GetHashCode();
                
                return hash;
            }
        }

    }
}
