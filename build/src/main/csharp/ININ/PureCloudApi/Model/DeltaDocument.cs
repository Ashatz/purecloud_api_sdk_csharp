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
    public partial class DeltaDocument :  IEquatable<DeltaDocument>
    { 

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OperationEnum {
            
            [EnumMember(Value = "CREATED")]
            Created,
            
            [EnumMember(Value = "UPDATED")]
            Updated,
            
            [EnumMember(Value = "REPLACED")]
            Replaced,
            
            [EnumMember(Value = "DELETED")]
            Deleted
        }

        

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public OperationEnum? Operation { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeltaDocument" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Filename">Filename.</param>
        /// <param name="ContentType">ContentType.</param>
        /// <param name="ContentLengthBytes">ContentLengthBytes.</param>
        /// <param name="Operation">Operation.</param>
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>

        public DeltaDocument(string Id = null, string Name = null, string Filename = null, string ContentType = null, long? ContentLengthBytes = null, OperationEnum? Operation = null, DateTime? DateModified = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Filename = Filename;
            this.ContentType = ContentType;
            this.ContentLengthBytes = ContentLengthBytes;
            this.Operation = Operation;
            this.DateModified = DateModified;
            
        }

    
        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public OperationEnum? Operation { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeltaDocument" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Filename">Filename.</param>
        /// <param name="ContentType">ContentType.</param>
        /// <param name="ContentLengthBytes">ContentLengthBytes.</param>
        /// <param name="Operation">Operation.</param>
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>

        public DeltaDocument(string Id = null, string Name = null, string Filename = null, string ContentType = null, long? ContentLengthBytes = null, OperationEnum? Operation = null, DateTime? DateModified = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Filename = Filename;
            this.ContentType = ContentType;
            this.ContentLengthBytes = ContentLengthBytes;
            this.Operation = Operation;
            this.DateModified = DateModified;
            
        }

    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }
    
        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
    
        /// <summary>
        /// Gets or Sets ContentLengthBytes
        /// </summary>
        [DataMember(Name="contentLengthBytes", EmitDefaultValue=false)]
        public long? ContentLengthBytes { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeltaDocument {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ContentLengthBytes: ").Append(ContentLengthBytes).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as DeltaDocument);
        }

        /// <summary>
        /// Returns true if DeltaDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of DeltaDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeltaDocument other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Filename == other.Filename ||
                    this.Filename != null &&
                    this.Filename.Equals(other.Filename)
                ) &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.ContentLengthBytes == other.ContentLengthBytes ||
                    this.ContentLengthBytes != null &&
                    this.ContentLengthBytes.Equals(other.ContentLengthBytes)
                ) &&
                (
                    this.Operation == other.Operation ||
                    this.Operation != null &&
                    this.Operation.Equals(other.Operation)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Filename != null)
                    hash = hash * 59 + this.Filename.GetHashCode();
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                if (this.ContentLengthBytes != null)
                    hash = hash * 59 + this.ContentLengthBytes.GetHashCode();
                if (this.Operation != null)
                    hash = hash * 59 + this.Operation.GetHashCode();
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                return hash;
            }
        }

    }
}
