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
    public partial class SignatureDocumentInfo :  IEquatable<SignatureDocumentInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureDocumentInfo" /> class.
        /// Initializes a new instance of the <see cref="SignatureDocumentInfo" />class.
        /// </summary>
        /// <param name="Org">Org.</param>
        /// <param name="User">User.</param>
        /// <param name="ReturnUrl">ReturnUrl.</param>

        public SignatureDocumentInfo(Organization Org = null, User User = null, string ReturnUrl = null)
        {
            this.Org = Org;
            this.User = User;
            this.ReturnUrl = ReturnUrl;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Org
        /// </summary>
        [DataMember(Name="org", EmitDefaultValue=false)]
        public Organization Org { get; set; }
    
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
    
        /// <summary>
        /// Gets or Sets ReturnUrl
        /// </summary>
        [DataMember(Name="returnUrl", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignatureDocumentInfo {\n");
            sb.Append("  Org: ").Append(Org).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            
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
            return this.Equals(obj as SignatureDocumentInfo);
        }

        /// <summary>
        /// Returns true if SignatureDocumentInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of SignatureDocumentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureDocumentInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Org == other.Org ||
                    this.Org != null &&
                    this.Org.Equals(other.Org)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.ReturnUrl == other.ReturnUrl ||
                    this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(other.ReturnUrl)
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
                
                if (this.Org != null)
                    hash = hash * 59 + this.Org.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.ReturnUrl != null)
                    hash = hash * 59 + this.ReturnUrl.GetHashCode();
                
                return hash;
            }
        }

    }
}
