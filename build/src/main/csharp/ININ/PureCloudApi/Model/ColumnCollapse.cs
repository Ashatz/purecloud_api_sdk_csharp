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
    public partial class ColumnCollapse :  IEquatable<ColumnCollapse>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnCollapse" />class.
        /// </summary>
        /// <param name="Label">Label.</param>
        /// <param name="Columns">Columns.</param>

        public ColumnCollapse(string Label = null, List<int?> Columns = null)
        {
            this.Label = Label;
            this.Columns = Columns;
            
        }

    
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
    
        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<int?> Columns { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColumnCollapse {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
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
            return this.Equals(obj as ColumnCollapse);
        }

        /// <summary>
        /// Returns true if ColumnCollapse instances are equal
        /// </summary>
        /// <param name="other">Instance of ColumnCollapse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ColumnCollapse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) &&
                (
                    this.Columns == other.Columns ||
                    this.Columns != null &&
                    this.Columns.SequenceEqual(other.Columns)
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
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Columns != null)
                    hash = hash * 59 + this.Columns.GetHashCode();
                return hash;
            }
        }

    }
}
