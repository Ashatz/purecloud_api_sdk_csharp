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
    public partial class BackendWorkItemDataElement :  IEquatable<BackendWorkItemDataElement>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BackendWorkItemDataElement" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Prompt">Prompt.</param>
        /// <param name="DataItemId">DataItemId.</param>
        /// <param name="ControlType">ControlType.</param>

        public BackendWorkItemDataElement(string Id = null, string Prompt = null, string DataItemId = null, string ControlType = null)
        {
            this.Id = Id;
            this.Prompt = Prompt;
            this.DataItemId = DataItemId;
            this.ControlType = ControlType;
            
        }

    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Prompt
        /// </summary>
        [DataMember(Name="prompt", EmitDefaultValue=false)]
        public string Prompt { get; set; }
    
        /// <summary>
        /// Gets or Sets DataItemId
        /// </summary>
        [DataMember(Name="dataItemId", EmitDefaultValue=false)]
        public string DataItemId { get; set; }
    
        /// <summary>
        /// Gets or Sets ControlType
        /// </summary>
        [DataMember(Name="controlType", EmitDefaultValue=false)]
        public string ControlType { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackendWorkItemDataElement {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  DataItemId: ").Append(DataItemId).Append("\n");
            sb.Append("  ControlType: ").Append(ControlType).Append("\n");
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
            return this.Equals(obj as BackendWorkItemDataElement);
        }

        /// <summary>
        /// Returns true if BackendWorkItemDataElement instances are equal
        /// </summary>
        /// <param name="other">Instance of BackendWorkItemDataElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackendWorkItemDataElement other)
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
                    this.Prompt == other.Prompt ||
                    this.Prompt != null &&
                    this.Prompt.Equals(other.Prompt)
                ) &&
                (
                    this.DataItemId == other.DataItemId ||
                    this.DataItemId != null &&
                    this.DataItemId.Equals(other.DataItemId)
                ) &&
                (
                    this.ControlType == other.ControlType ||
                    this.ControlType != null &&
                    this.ControlType.Equals(other.ControlType)
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
                if (this.Prompt != null)
                    hash = hash * 59 + this.Prompt.GetHashCode();
                if (this.DataItemId != null)
                    hash = hash * 59 + this.DataItemId.GetHashCode();
                if (this.ControlType != null)
                    hash = hash * 59 + this.ControlType.GetHashCode();
                return hash;
            }
        }

    }
}
