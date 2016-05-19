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
    /// SheetSchema
    /// </summary>
    [DataContract]
    public partial class SheetSchema :  IEquatable<SheetSchema>
    {
        /// <summary>
        /// Rate type for the sheet.
        /// </summary>
        /// <value>Rate type for the sheet.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RateTypeEnum
        {
            
            /// <summary>
            /// Enum Intrastate for "INTRASTATE"
            /// </summary>
            [EnumMember(Value = "INTRASTATE")]
            Intrastate,
            
            /// <summary>
            /// Enum Interstate for "INTERSTATE"
            /// </summary>
            [EnumMember(Value = "INTERSTATE")]
            Interstate,
            
            /// <summary>
            /// Enum International for "INTERNATIONAL"
            /// </summary>
            [EnumMember(Value = "INTERNATIONAL")]
            International
        }

        /// <summary>
        /// Rate type for the sheet.
        /// </summary>
        /// <value>Rate type for the sheet.</value>
        [DataMember(Name="RateType", EmitDefaultValue=false)]
        public RateTypeEnum? RateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SheetSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SheetSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SheetSchema" /> class.
        /// </summary>
        /// <param name="HeaderRow">Row number for the XLSX sheet&#39;s headers.  This is zero indexed (i.e. 0 is row 1). (required).</param>
        /// <param name="DataRow">Row number of the first line of data in the sheet.  This is zero indexed (i.e. 0 is row 1) (required).</param>
        /// <param name="HeaderMappings">XLSX sheet header name to object name mappings. For example, \&quot;ROUTE_TEL_PREFIX\&quot; to \&quot;Prefix\&quot; might be one such mapping. (required).</param>
        /// <param name="RateType">Rate type for the sheet. (required).</param>
        /// <param name="SheetNumber">Sheet number within the XLSX file.  This is zero indexed (i.e. 0 is page 1). (required).</param>
        /// <param name="DateFormat">A date format that represents the date time stamp you want to parse. This is based on the reference time of Mon Jan 2 15:04:05 MST 2006. For example, if you had the date 13-OCT-2015, this parameter should be 02-Jan-2006. As another example, if you have the date 2014-09-20, this parameter should be 2006-01-02..</param>
        public SheetSchema(int? HeaderRow = null, int? DataRow = null, Dictionary<string, string> HeaderMappings = null, RateTypeEnum? RateType = null, int? SheetNumber = null, string DateFormat = null)
        {
            // to ensure "HeaderRow" is required (not null)
            if (HeaderRow == null)
            {
                throw new InvalidDataException("HeaderRow is a required property for SheetSchema and cannot be null");
            }
            else
            {
                this.HeaderRow = HeaderRow;
            }
            // to ensure "DataRow" is required (not null)
            if (DataRow == null)
            {
                throw new InvalidDataException("DataRow is a required property for SheetSchema and cannot be null");
            }
            else
            {
                this.DataRow = DataRow;
            }
            // to ensure "HeaderMappings" is required (not null)
            if (HeaderMappings == null)
            {
                throw new InvalidDataException("HeaderMappings is a required property for SheetSchema and cannot be null");
            }
            else
            {
                this.HeaderMappings = HeaderMappings;
            }
            // to ensure "RateType" is required (not null)
            if (RateType == null)
            {
                throw new InvalidDataException("RateType is a required property for SheetSchema and cannot be null");
            }
            else
            {
                this.RateType = RateType;
            }
            // to ensure "SheetNumber" is required (not null)
            if (SheetNumber == null)
            {
                throw new InvalidDataException("SheetNumber is a required property for SheetSchema and cannot be null");
            }
            else
            {
                this.SheetNumber = SheetNumber;
            }
            this.DateFormat = DateFormat;
        }
        
        /// <summary>
        /// Row number for the XLSX sheet&#39;s headers.  This is zero indexed (i.e. 0 is row 1).
        /// </summary>
        /// <value>Row number for the XLSX sheet&#39;s headers.  This is zero indexed (i.e. 0 is row 1).</value>
        [DataMember(Name="HeaderRow", EmitDefaultValue=false)]
        public int? HeaderRow { get; set; }
        /// <summary>
        /// Row number of the first line of data in the sheet.  This is zero indexed (i.e. 0 is row 1)
        /// </summary>
        /// <value>Row number of the first line of data in the sheet.  This is zero indexed (i.e. 0 is row 1)</value>
        [DataMember(Name="DataRow", EmitDefaultValue=false)]
        public int? DataRow { get; set; }
        /// <summary>
        /// XLSX sheet header name to object name mappings. For example, \&quot;ROUTE_TEL_PREFIX\&quot; to \&quot;Prefix\&quot; might be one such mapping.
        /// </summary>
        /// <value>XLSX sheet header name to object name mappings. For example, \&quot;ROUTE_TEL_PREFIX\&quot; to \&quot;Prefix\&quot; might be one such mapping.</value>
        [DataMember(Name="HeaderMappings", EmitDefaultValue=false)]
        public Dictionary<string, string> HeaderMappings { get; set; }
        /// <summary>
        /// Sheet number within the XLSX file.  This is zero indexed (i.e. 0 is page 1).
        /// </summary>
        /// <value>Sheet number within the XLSX file.  This is zero indexed (i.e. 0 is page 1).</value>
        [DataMember(Name="SheetNumber", EmitDefaultValue=false)]
        public int? SheetNumber { get; set; }
        /// <summary>
        /// A date format that represents the date time stamp you want to parse. This is based on the reference time of Mon Jan 2 15:04:05 MST 2006. For example, if you had the date 13-OCT-2015, this parameter should be 02-Jan-2006. As another example, if you have the date 2014-09-20, this parameter should be 2006-01-02.
        /// </summary>
        /// <value>A date format that represents the date time stamp you want to parse. This is based on the reference time of Mon Jan 2 15:04:05 MST 2006. For example, if you had the date 13-OCT-2015, this parameter should be 02-Jan-2006. As another example, if you have the date 2014-09-20, this parameter should be 2006-01-02.</value>
        [DataMember(Name="DateFormat", EmitDefaultValue=false)]
        public string DateFormat { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SheetSchema {\n");
            sb.Append("  HeaderRow: ").Append(HeaderRow).Append("\n");
            sb.Append("  DataRow: ").Append(DataRow).Append("\n");
            sb.Append("  HeaderMappings: ").Append(HeaderMappings).Append("\n");
            sb.Append("  RateType: ").Append(RateType).Append("\n");
            sb.Append("  SheetNumber: ").Append(SheetNumber).Append("\n");
            sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
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
            return this.Equals(obj as SheetSchema);
        }

        /// <summary>
        /// Returns true if SheetSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of SheetSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SheetSchema other)
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
                    this.DataRow == other.DataRow ||
                    this.DataRow != null &&
                    this.DataRow.Equals(other.DataRow)
                ) && 
                (
                    this.HeaderMappings == other.HeaderMappings ||
                    this.HeaderMappings != null &&
                    this.HeaderMappings.SequenceEqual(other.HeaderMappings)
                ) && 
                (
                    this.RateType == other.RateType ||
                    this.RateType != null &&
                    this.RateType.Equals(other.RateType)
                ) && 
                (
                    this.SheetNumber == other.SheetNumber ||
                    this.SheetNumber != null &&
                    this.SheetNumber.Equals(other.SheetNumber)
                ) && 
                (
                    this.DateFormat == other.DateFormat ||
                    this.DateFormat != null &&
                    this.DateFormat.Equals(other.DateFormat)
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
                if (this.DataRow != null)
                    hash = hash * 59 + this.DataRow.GetHashCode();
                if (this.HeaderMappings != null)
                    hash = hash * 59 + this.HeaderMappings.GetHashCode();
                if (this.RateType != null)
                    hash = hash * 59 + this.RateType.GetHashCode();
                if (this.SheetNumber != null)
                    hash = hash * 59 + this.SheetNumber.GetHashCode();
                if (this.DateFormat != null)
                    hash = hash * 59 + this.DateFormat.GetHashCode();
                return hash;
            }
        }
    }

}
