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
    public partial class BatchCommand :  IEquatable<BatchCommand>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCommand" /> class.
        /// Initializes a new instance of the <see cref="BatchCommand" />class.
        /// </summary>
        /// <param name="Items">Items.</param>
        /// <param name="CommandId">CommandId.</param>

        public BatchCommand(List<BatchItem> Items = null, string CommandId = null)
        {
            this.Items = Items;
            this.CommandId = CommandId;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<BatchItem> Items { get; set; }
    
        /// <summary>
        /// Gets or Sets CommandId
        /// </summary>
        [DataMember(Name="commandId", EmitDefaultValue=false)]
        public string CommandId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCommand {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  CommandId: ").Append(CommandId).Append("\n");
            
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
            return this.Equals(obj as BatchCommand);
        }

        /// <summary>
        /// Returns true if BatchCommand instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchCommand other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.CommandId == other.CommandId ||
                    this.CommandId != null &&
                    this.CommandId.Equals(other.CommandId)
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
                
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                
                if (this.CommandId != null)
                    hash = hash * 59 + this.CommandId.GetHashCode();
                
                return hash;
            }
        }

    }
}
