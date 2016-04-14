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
    /// Data containing details to upload a flow definition to for post versioned flows.
    /// </summary>
    [DataContract]
    public partial class FlowUploadResponse :  IEquatable<FlowUploadResponse>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowUploadResponse" />class.
        /// </summary>
        /// <param name="Uri">uri destination to upload file to.</param>
        /// <param name="UploadToken">token to send along when creating versioned flow so the file can be bound to the metadata.</param>

        public FlowUploadResponse(string Uri = null, string UploadToken = null)
        {
            this.Uri = Uri;
            this.UploadToken = UploadToken;
            
        }

    
        /// <summary>
        /// uri destination to upload file to
        /// </summary>
        /// <value>uri destination to upload file to</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// token to send along when creating versioned flow so the file can be bound to the metadata
        /// </summary>
        /// <value>token to send along when creating versioned flow so the file can be bound to the metadata</value>
        [DataMember(Name="uploadToken", EmitDefaultValue=false)]
        public string UploadToken { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowUploadResponse {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  UploadToken: ").Append(UploadToken).Append("\n");
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
            return this.Equals(obj as FlowUploadResponse);
        }

        /// <summary>
        /// Returns true if FlowUploadResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowUploadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowUploadResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) &&
                (
                    this.UploadToken == other.UploadToken ||
                    this.UploadToken != null &&
                    this.UploadToken.Equals(other.UploadToken)
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
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                if (this.UploadToken != null)
                    hash = hash * 59 + this.UploadToken.GetHashCode();
                return hash;
            }
        }

    }
}
