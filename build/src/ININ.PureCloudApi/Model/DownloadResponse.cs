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
    /// DownloadResponse
    /// </summary>
    [DataContract]
    public partial class DownloadResponse :  IEquatable<DownloadResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadResponse" /> class.
        /// </summary>
        /// <param name="ContentLocationUri">ContentLocationUri.</param>
        /// <param name="ImageUri">ImageUri.</param>
        public DownloadResponse(string ContentLocationUri = null, string ImageUri = null)
        {
            this.ContentLocationUri = ContentLocationUri;
            this.ImageUri = ImageUri;
        }
        
        /// <summary>
        /// Gets or Sets ContentLocationUri
        /// </summary>
        [DataMember(Name="contentLocationUri", EmitDefaultValue=false)]
        public string ContentLocationUri { get; set; }
        /// <summary>
        /// Gets or Sets ImageUri
        /// </summary>
        [DataMember(Name="imageUri", EmitDefaultValue=false)]
        public string ImageUri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadResponse {\n");
            sb.Append("  ContentLocationUri: ").Append(ContentLocationUri).Append("\n");
            sb.Append("  ImageUri: ").Append(ImageUri).Append("\n");
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
            return this.Equals(obj as DownloadResponse);
        }

        /// <summary>
        /// Returns true if DownloadResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DownloadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContentLocationUri == other.ContentLocationUri ||
                    this.ContentLocationUri != null &&
                    this.ContentLocationUri.Equals(other.ContentLocationUri)
                ) && 
                (
                    this.ImageUri == other.ImageUri ||
                    this.ImageUri != null &&
                    this.ImageUri.Equals(other.ImageUri)
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
                if (this.ContentLocationUri != null)
                    hash = hash * 59 + this.ContentLocationUri.GetHashCode();
                if (this.ImageUri != null)
                    hash = hash * 59 + this.ImageUri.GetHashCode();
                return hash;
            }
        }
    }

}
