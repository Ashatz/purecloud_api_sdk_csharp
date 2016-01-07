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
    /// Contains information about the Document associated with a workItem
    /// </summary>
    [DataContract]
    public class AssociatedDocument :  IEquatable<AssociatedDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedDocument" /> class.
        /// </summary>
        public AssociatedDocument()
        {
            
        }

        
        /// <summary>
        /// the document associated with the workitem
        /// </summary>
        /// <value>the document associated with the workitem</value>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public Document Document { get; set; }
  
        
        /// <summary>
        /// the document association type
        /// </summary>
        /// <value>the document association type</value>
        [DataMember(Name="documentAssociationType", EmitDefaultValue=false)]
        public string DocumentAssociationType { get; set; }
  
        
  
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
        /// <param name="obj">Instance of AssociatedDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssociatedDocument other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    hash = hash * 57 + this.Document.GetHashCode();
                
                if (this.DocumentAssociationType != null)
                    hash = hash * 57 + this.DocumentAssociationType.GetHashCode();
                
                return hash;
            }
        }

    }


}
