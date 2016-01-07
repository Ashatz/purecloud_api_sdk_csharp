using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CsvSchema :  IEquatable<CsvSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsvSchema" /> class.
        /// </summary>
        public CsvSchema()
        {
            
        }

        
        /// <summary>
        /// Carrier ID associated with this CSV schema.
        /// </summary>
        /// <value>Carrier ID associated with this CSV schema.</value>
        [DataMember(Name="CarrierId", EmitDefaultValue=false)]
        public string CarrierId { get; set; }
  
        
        /// <summary>
        /// Row number for the CSV's headers.  This is zero indexed (i.e. 0 is row 1).
        /// </summary>
        /// <value>Row number for the CSV's headers.  This is zero indexed (i.e. 0 is row 1).</value>
        [DataMember(Name="HeaderRow", EmitDefaultValue=false)]
        public int? HeaderRow { get; set; }
  
        
        /// <summary>
        /// Row number of the first line of data.  This is zero indexed (i.e. 0 is row 1).
        /// </summary>
        /// <value>Row number of the first line of data.  This is zero indexed (i.e. 0 is row 1).</value>
        [DataMember(Name="DataRow", EmitDefaultValue=false)]
        public int? DataRow { get; set; }
  
        
        /// <summary>
        /// CSV header name to object name mappings. For example, \"ROUTE_TEL_PREFIX\" to \"Prefix\" might be one such mapping.
        /// </summary>
        /// <value>CSV header name to object name mappings. For example, \"ROUTE_TEL_PREFIX\" to \"Prefix\" might be one such mapping.</value>
        [DataMember(Name="HeaderMappings", EmitDefaultValue=false)]
        public Dictionary<string, string> HeaderMappings { get; set; }
  
        
        /// <summary>
        /// Rate type for the sheet.
        /// </summary>
        /// <value>Rate type for the sheet.</value>
        [DataMember(Name="RateType", EmitDefaultValue=false)]
        public string RateType { get; set; }
  
        
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
        /// <param name="obj">Instance of CsvSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsvSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    hash = hash * 57 + this.CarrierId.GetHashCode();
                
                if (this.HeaderRow != null)
                    hash = hash * 57 + this.HeaderRow.GetHashCode();
                
                if (this.DataRow != null)
                    hash = hash * 57 + this.DataRow.GetHashCode();
                
                if (this.HeaderMappings != null)
                    hash = hash * 57 + this.HeaderMappings.GetHashCode();
                
                if (this.RateType != null)
                    hash = hash * 57 + this.RateType.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.DateFormat != null)
                    hash = hash * 57 + this.DateFormat.GetHashCode();
                
                return hash;
            }
        }

    }


}