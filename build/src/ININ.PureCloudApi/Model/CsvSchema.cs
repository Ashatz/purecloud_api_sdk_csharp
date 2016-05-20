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
    /// CsvSchema
    /// </summary>
    [DataContract]
    public partial class CsvSchema :  IEquatable<CsvSchema>
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
        /// Initializes a new instance of the <see cref="CsvSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CsvSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CsvSchema" /> class.
        /// </summary>
        /// <param name="HeaderRow">Row number for the CSV&#39;s headers.  This is zero indexed (i.e. 0 is row 1). (required).</param>
        /// <param name="DataRow">Row number of the first line of data.  This is zero indexed (i.e. 0 is row 1). (required).</param>
        /// <param name="HeaderMappings">CSV header name to object name mappings. For example, \&quot;ROUTE_TEL_PREFIX\&quot; to \&quot;Prefix\&quot; might be one such mapping. (required).</param>
        /// <param name="RateType">Rate type for the sheet. (required).</param>
        /// <param name="Name">Human readable name for schema. (required).</param>
        /// <param name="DateFormat">A date format that represents the date time stamp you want to parse. This is based on the reference time of Mon Jan 2 15:04:05 MST 2006. For example, if you had the date 13-OCT-2015, this parameter should be 02-Jan-2006. As another example, if you have the date 2014-09-20, this parameter should be 2006-01-02..</param>
        public CsvSchema(int? HeaderRow = null, int? DataRow = null, Dictionary<string, string> HeaderMappings = null, RateTypeEnum? RateType = null, string Name = null, string DateFormat = null)
        {
            // to ensure "HeaderRow" is required (not null)
            if (HeaderRow == null)
            {
                throw new InvalidDataException("HeaderRow is a required property for CsvSchema and cannot be null");
            }
            else
            {
                this.HeaderRow = HeaderRow;
            }
            // to ensure "DataRow" is required (not null)
            if (DataRow == null)
            {
                throw new InvalidDataException("DataRow is a required property for CsvSchema and cannot be null");
            }
            else
            {
                this.DataRow = DataRow;
            }
            // to ensure "HeaderMappings" is required (not null)
            if (HeaderMappings == null)
            {
                throw new InvalidDataException("HeaderMappings is a required property for CsvSchema and cannot be null");
            }
            else
            {
                this.HeaderMappings = HeaderMappings;
            }
            // to ensure "RateType" is required (not null)
            if (RateType == null)
            {
                throw new InvalidDataException("RateType is a required property for CsvSchema and cannot be null");
            }
            else
            {
                this.RateType = RateType;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CsvSchema and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.DateFormat = DateFormat;
        }
        
        /// <summary>
        /// Carrier ID associated with this CSV schema.
        /// </summary>
        /// <value>Carrier ID associated with this CSV schema.</value>
        [DataMember(Name="CarrierId", EmitDefaultValue=false)]
        public string CarrierId { get; private set; }
        /// <summary>
        /// Row number for the CSV&#39;s headers.  This is zero indexed (i.e. 0 is row 1).
        /// </summary>
        /// <value>Row number for the CSV&#39;s headers.  This is zero indexed (i.e. 0 is row 1).</value>
        [DataMember(Name="HeaderRow", EmitDefaultValue=false)]
        public int? HeaderRow { get; set; }
        /// <summary>
        /// Row number of the first line of data.  This is zero indexed (i.e. 0 is row 1).
        /// </summary>
        /// <value>Row number of the first line of data.  This is zero indexed (i.e. 0 is row 1).</value>
        [DataMember(Name="DataRow", EmitDefaultValue=false)]
        public int? DataRow { get; set; }
        /// <summary>
        /// CSV header name to object name mappings. For example, \&quot;ROUTE_TEL_PREFIX\&quot; to \&quot;Prefix\&quot; might be one such mapping.
        /// </summary>
        /// <value>CSV header name to object name mappings. For example, \&quot;ROUTE_TEL_PREFIX\&quot; to \&quot;Prefix\&quot; might be one such mapping.</value>
        [DataMember(Name="HeaderMappings", EmitDefaultValue=false)]
        public Dictionary<string, string> HeaderMappings { get; set; }
        /// <summary>
        /// Human readable name for schema.
        /// </summary>
        /// <value>Human readable name for schema.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
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
            sb.Append("class CsvSchema {\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            sb.Append("  HeaderRow: ").Append(HeaderRow).Append("\n");
            sb.Append("  DataRow: ").Append(DataRow).Append("\n");
            sb.Append("  HeaderMappings: ").Append(HeaderMappings).Append("\n");
            sb.Append("  RateType: ").Append(RateType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as CsvSchema);
        }

        /// <summary>
        /// Returns true if CsvSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of CsvSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsvSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CarrierId == other.CarrierId ||
                    this.CarrierId != null &&
                    this.CarrierId.Equals(other.CarrierId)
                ) &&
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.CarrierId != null)
                    hash = hash * 59 + this.CarrierId.GetHashCode();
                if (this.HeaderRow != null)
                    hash = hash * 59 + this.HeaderRow.GetHashCode();
                if (this.DataRow != null)
                    hash = hash * 59 + this.DataRow.GetHashCode();
                if (this.HeaderMappings != null)
                    hash = hash * 59 + this.HeaderMappings.GetHashCode();
                if (this.RateType != null)
                    hash = hash * 59 + this.RateType.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.DateFormat != null)
                    hash = hash * 59 + this.DateFormat.GetHashCode();
                return hash;
            }
        }
    }

}
