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
    public partial class Campaign :  IEquatable<Campaign>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="PhoneNumberColumns">PhoneNumberColumns.</param>
        /// <param name="SkipPreviewDisabled">SkipPreviewDisabled (default to false).</param>
        /// <param name="PreviewTimeOutSeconds">PreviewTimeOutSeconds.</param>

        public Campaign(string Id = null, string Name = null, string SelfUri = null, List<PhoneNumberColumn> PhoneNumberColumns = null, bool? SkipPreviewDisabled = null, int? PreviewTimeOutSeconds = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.SelfUri = SelfUri;
            this.PhoneNumberColumns = PhoneNumberColumns;
            // use default value if no "SkipPreviewDisabled" provided
            if (SkipPreviewDisabled == null)
            {
                this.SkipPreviewDisabled = false;
            }
            else
            {
                this.SkipPreviewDisabled = SkipPreviewDisabled;
            }
            this.PreviewTimeOutSeconds = PreviewTimeOutSeconds;
            
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
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
    
        /// <summary>
        /// Gets or Sets PhoneNumberColumns
        /// </summary>
        [DataMember(Name="phoneNumberColumns", EmitDefaultValue=false)]
        public List<PhoneNumberColumn> PhoneNumberColumns { get; set; }
    
        /// <summary>
        /// Gets or Sets SkipPreviewDisabled
        /// </summary>
        [DataMember(Name="skipPreviewDisabled", EmitDefaultValue=false)]
        public bool? SkipPreviewDisabled { get; set; }
    
        /// <summary>
        /// Gets or Sets PreviewTimeOutSeconds
        /// </summary>
        [DataMember(Name="previewTimeOutSeconds", EmitDefaultValue=false)]
        public int? PreviewTimeOutSeconds { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Campaign {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  PhoneNumberColumns: ").Append(PhoneNumberColumns).Append("\n");
            sb.Append("  SkipPreviewDisabled: ").Append(SkipPreviewDisabled).Append("\n");
            sb.Append("  PreviewTimeOutSeconds: ").Append(PreviewTimeOutSeconds).Append("\n");
            
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
            return this.Equals(obj as Campaign);
        }

        /// <summary>
        /// Returns true if Campaign instances are equal
        /// </summary>
        /// <param name="other">Instance of Campaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Campaign other)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.PhoneNumberColumns == other.PhoneNumberColumns ||
                    this.PhoneNumberColumns != null &&
                    this.PhoneNumberColumns.SequenceEqual(other.PhoneNumberColumns)
                ) &&
                (
                    this.SkipPreviewDisabled == other.SkipPreviewDisabled ||
                    this.SkipPreviewDisabled != null &&
                    this.SkipPreviewDisabled.Equals(other.SkipPreviewDisabled)
                ) &&
                (
                    this.PreviewTimeOutSeconds == other.PreviewTimeOutSeconds ||
                    this.PreviewTimeOutSeconds != null &&
                    this.PreviewTimeOutSeconds.Equals(other.PreviewTimeOutSeconds)
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
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.PhoneNumberColumns != null)
                    hash = hash * 59 + this.PhoneNumberColumns.GetHashCode();
                
                if (this.SkipPreviewDisabled != null)
                    hash = hash * 59 + this.SkipPreviewDisabled.GetHashCode();
                
                if (this.PreviewTimeOutSeconds != null)
                    hash = hash * 59 + this.PreviewTimeOutSeconds.GetHashCode();
                
                return hash;
            }
        }

    }
}
