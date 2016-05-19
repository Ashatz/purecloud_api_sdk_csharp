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
    /// TableTransform
    /// </summary>
    [DataContract]
    public partial class TableTransform :  IEquatable<TableTransform>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableTransform" /> class.
        /// </summary>
        /// <param name="HeaderRow">HeaderRow.</param>
        /// <param name="FirstData">FirstData.</param>
        /// <param name="HeaderReplaces">HeaderReplaces.</param>
        /// <param name="Columns">Columns.</param>
        /// <param name="Unpivots">Unpivots.</param>
        /// <param name="Collapses">Collapses.</param>
        public TableTransform(int? HeaderRow = null, int? FirstData = null, List<IndexedTransform> HeaderReplaces = null, List<IndexedTransform> Columns = null, List<UnpivotColumns> Unpivots = null, List<ColumnCollapse> Collapses = null)
        {
            this.HeaderRow = HeaderRow;
            this.FirstData = FirstData;
            this.HeaderReplaces = HeaderReplaces;
            this.Columns = Columns;
            this.Unpivots = Unpivots;
            this.Collapses = Collapses;
        }
        
        /// <summary>
        /// Gets or Sets HeaderRow
        /// </summary>
        [DataMember(Name="headerRow", EmitDefaultValue=false)]
        public int? HeaderRow { get; set; }
        /// <summary>
        /// Gets or Sets FirstData
        /// </summary>
        [DataMember(Name="firstData", EmitDefaultValue=false)]
        public int? FirstData { get; set; }
        /// <summary>
        /// Gets or Sets HeaderReplaces
        /// </summary>
        [DataMember(Name="headerReplaces", EmitDefaultValue=false)]
        public List<IndexedTransform> HeaderReplaces { get; set; }
        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<IndexedTransform> Columns { get; set; }
        /// <summary>
        /// Gets or Sets Unpivots
        /// </summary>
        [DataMember(Name="unpivots", EmitDefaultValue=false)]
        public List<UnpivotColumns> Unpivots { get; set; }
        /// <summary>
        /// Gets or Sets Collapses
        /// </summary>
        [DataMember(Name="collapses", EmitDefaultValue=false)]
        public List<ColumnCollapse> Collapses { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableTransform {\n");
            sb.Append("  HeaderRow: ").Append(HeaderRow).Append("\n");
            sb.Append("  FirstData: ").Append(FirstData).Append("\n");
            sb.Append("  HeaderReplaces: ").Append(HeaderReplaces).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Unpivots: ").Append(Unpivots).Append("\n");
            sb.Append("  Collapses: ").Append(Collapses).Append("\n");
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
            return this.Equals(obj as TableTransform);
        }

        /// <summary>
        /// Returns true if TableTransform instances are equal
        /// </summary>
        /// <param name="other">Instance of TableTransform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableTransform other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HeaderRow == other.HeaderRow ||
                    this.HeaderRow != null &&
                    this.HeaderRow.Equals(other.HeaderRow)
                ) && 
                (
                    this.FirstData == other.FirstData ||
                    this.FirstData != null &&
                    this.FirstData.Equals(other.FirstData)
                ) && 
                (
                    this.HeaderReplaces == other.HeaderReplaces ||
                    this.HeaderReplaces != null &&
                    this.HeaderReplaces.SequenceEqual(other.HeaderReplaces)
                ) && 
                (
                    this.Columns == other.Columns ||
                    this.Columns != null &&
                    this.Columns.SequenceEqual(other.Columns)
                ) && 
                (
                    this.Unpivots == other.Unpivots ||
                    this.Unpivots != null &&
                    this.Unpivots.SequenceEqual(other.Unpivots)
                ) && 
                (
                    this.Collapses == other.Collapses ||
                    this.Collapses != null &&
                    this.Collapses.SequenceEqual(other.Collapses)
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
                if (this.HeaderRow != null)
                    hash = hash * 59 + this.HeaderRow.GetHashCode();
                if (this.FirstData != null)
                    hash = hash * 59 + this.FirstData.GetHashCode();
                if (this.HeaderReplaces != null)
                    hash = hash * 59 + this.HeaderReplaces.GetHashCode();
                if (this.Columns != null)
                    hash = hash * 59 + this.Columns.GetHashCode();
                if (this.Unpivots != null)
                    hash = hash * 59 + this.Unpivots.GetHashCode();
                if (this.Collapses != null)
                    hash = hash * 59 + this.Collapses.GetHashCode();
                return hash;
            }
        }
    }

}
