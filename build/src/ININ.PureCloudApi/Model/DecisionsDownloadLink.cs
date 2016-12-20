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
using ININ.PureCloudApi.Client;

namespace ININ.PureCloudApi.Model
{
    /// <summary>
    /// DecisionsDownloadLink
    /// </summary>
    [DataContract]
    public partial class DecisionsDownloadLink :  IEquatable<DecisionsDownloadLink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsDownloadLink" /> class.
        /// </summary>
        public DecisionsDownloadLink()
        {
        }
        
        /// <summary>
        /// The id of the download link
        /// </summary>
        /// <value>The id of the download link</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The full path of the url
        /// </summary>
        /// <value>The full path of the url</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionsDownloadLink {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as DecisionsDownloadLink);
        }

        /// <summary>
        /// Returns true if DecisionsDownloadLink instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionsDownloadLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionsDownloadLink other)
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
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                return hash;
            }
        }
    }

}
