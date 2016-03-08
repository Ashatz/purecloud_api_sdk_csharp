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
    public partial class SheetTransform :  IEquatable<SheetTransform>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SheetTransform" /> class.
        /// Initializes a new instance of the <see cref="SheetTransform" />class.
        /// </summary>
        /// <param name="Sheet">Sheet.</param>
        /// <param name="SheetName">SheetName.</param>
        /// <param name="Table">Table.</param>

        public SheetTransform(int? Sheet = null, string SheetName = null, TableTransform Table = null)
        {
            this.Sheet = Sheet;
            this.SheetName = SheetName;
            this.Table = Table;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Sheet
        /// </summary>
        [DataMember(Name="sheet", EmitDefaultValue=false)]
        public int? Sheet { get; set; }
    
        /// <summary>
        /// Gets or Sets SheetName
        /// </summary>
        [DataMember(Name="sheetName", EmitDefaultValue=false)]
        public string SheetName { get; set; }
    
        /// <summary>
        /// Gets or Sets Table
        /// </summary>
        [DataMember(Name="table", EmitDefaultValue=false)]
        public TableTransform Table { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SheetTransform {\n");
            sb.Append("  Sheet: ").Append(Sheet).Append("\n");
            sb.Append("  SheetName: ").Append(SheetName).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            
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
            return this.Equals(obj as SheetTransform);
        }

        /// <summary>
        /// Returns true if SheetTransform instances are equal
        /// </summary>
        /// <param name="other">Instance of SheetTransform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SheetTransform other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sheet == other.Sheet ||
                    this.Sheet != null &&
                    this.Sheet.Equals(other.Sheet)
                ) && 
                (
                    this.SheetName == other.SheetName ||
                    this.SheetName != null &&
                    this.SheetName.Equals(other.SheetName)
                ) && 
                (
                    this.Table == other.Table ||
                    this.Table != null &&
                    this.Table.Equals(other.Table)
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
                
                if (this.Sheet != null)
                    hash = hash * 59 + this.Sheet.GetHashCode();
                
                if (this.SheetName != null)
                    hash = hash * 59 + this.SheetName.GetHashCode();
                
                if (this.Table != null)
                    hash = hash * 59 + this.Table.GetHashCode();
                
                return hash;
            }
        }

    }
}
