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
    /// Contains information about the Document associated with a workItem
    /// </summary>
    [DataContract]
    public partial class AssociatedDocument :  IEquatable<AssociatedDocument>
    {
        /// <summary>
        /// the document association type
        /// </summary>
        /// <value>the document association type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentAssociationTypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Main for "MAIN"
            /// </summary>
            [EnumMember(Value = "MAIN")]
            Main,
            
            /// <summary>
            /// Enum Secondary for "SECONDARY"
            /// </summary>
            [EnumMember(Value = "SECONDARY")]
            Secondary
        }

        /// <summary>
        /// the document association type
        /// </summary>
        /// <value>the document association type</value>
        [DataMember(Name="documentAssociationType", EmitDefaultValue=false)]
        public DocumentAssociationTypeEnum? DocumentAssociationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedDocument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssociatedDocument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedDocument" /> class.
        /// </summary>
        /// <param name="Document">the document associated with the workitem (required).</param>
        /// <param name="DocumentAssociationType">the document association type.</param>
        public AssociatedDocument(Document Document = null, DocumentAssociationTypeEnum? DocumentAssociationType = null)
        {
            // to ensure "Document" is required (not null)
            if (Document == null)
            {
                throw new InvalidDataException("Document is a required property for AssociatedDocument and cannot be null");
            }
            else
            {
                this.Document = Document;
            }
            this.DocumentAssociationType = DocumentAssociationType;
        }
        
        /// <summary>
        /// the document associated with the workitem
        /// </summary>
        /// <value>the document associated with the workitem</value>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public Document Document { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociatedDocument {\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  DocumentAssociationType: ").Append(DocumentAssociationType).Append("\n");
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
            return this.Equals(obj as AssociatedDocument);
        }

        /// <summary>
        /// Returns true if AssociatedDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of AssociatedDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssociatedDocument other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Document == other.Document ||
                    this.Document != null &&
                    this.Document.Equals(other.Document)
                ) &&
                (
                    this.DocumentAssociationType == other.DocumentAssociationType ||
                    this.DocumentAssociationType != null &&
                    this.DocumentAssociationType.Equals(other.DocumentAssociationType)
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
                if (this.Document != null)
                    hash = hash * 59 + this.Document.GetHashCode();
                if (this.DocumentAssociationType != null)
                    hash = hash * 59 + this.DocumentAssociationType.GetHashCode();
                return hash;
            }
        }
    }

}
