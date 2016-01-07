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
    /// Represents the details of a parsed certificate.
    /// </summary>
    [DataContract]
    public class CertificateDetails :  IEquatable<CertificateDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateDetails" /> class.
        /// </summary>
        public CertificateDetails()
        {
            this.Expired = false;
            this.SignatureValid = false;
            this.Valid = false;
            
        }

        
        /// <summary>
        /// Information about the issuer of the certificate.  The value of this property is a comma separated key=value format.  Each key is one of the attribute names supported by X.500.
        /// </summary>
        /// <value>Information about the issuer of the certificate.  The value of this property is a comma separated key=value format.  Each key is one of the attribute names supported by X.500.</value>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public string Issuer { get; set; }
  
        
        /// <summary>
        /// Information about the subject of the certificate.  The value of this property is a comma separated key=value format.  Each key is one of the attribute names supported by X.500.
        /// </summary>
        /// <value>Information about the subject of the certificate.  The value of this property is a comma separated key=value format.  Each key is one of the attribute names supported by X.500.</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
  
        
        /// <summary>
        /// The expiration date of the certificate.
        /// </summary>
        /// <value>The expiration date of the certificate.</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }
  
        
        /// <summary>
        /// The issue date of the certificate.
        /// </summary>
        /// <value>The issue date of the certificate.</value>
        [DataMember(Name="issueDate", EmitDefaultValue=false)]
        public DateTime? IssueDate { get; set; }
  
        
        /// <summary>
        /// True if the certificate is expired, false otherwise.
        /// </summary>
        /// <value>True if the certificate is expired, false otherwise.</value>
        [DataMember(Name="expired", EmitDefaultValue=false)]
        public bool? Expired { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SignatureValid
        /// </summary>
        [DataMember(Name="signatureValid", EmitDefaultValue=false)]
        public bool? SignatureValid { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Valid
        /// </summary>
        [DataMember(Name="valid", EmitDefaultValue=false)]
        public bool? Valid { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificateDetails {\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  SignatureValid: ").Append(SignatureValid).Append("\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            
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
            return this.Equals(obj as CertificateDetails);
        }

        /// <summary>
        /// Returns true if CertificateDetails instances are equal
        /// </summary>
        /// <param name="obj">Instance of CertificateDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Issuer == other.Issuer ||
                    this.Issuer != null &&
                    this.Issuer.Equals(other.Issuer)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.IssueDate == other.IssueDate ||
                    this.IssueDate != null &&
                    this.IssueDate.Equals(other.IssueDate)
                ) && 
                (
                    this.Expired == other.Expired ||
                    this.Expired != null &&
                    this.Expired.Equals(other.Expired)
                ) && 
                (
                    this.SignatureValid == other.SignatureValid ||
                    this.SignatureValid != null &&
                    this.SignatureValid.Equals(other.SignatureValid)
                ) && 
                (
                    this.Valid == other.Valid ||
                    this.Valid != null &&
                    this.Valid.Equals(other.Valid)
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
                
                if (this.Issuer != null)
                    hash = hash * 57 + this.Issuer.GetHashCode();
                
                if (this.Subject != null)
                    hash = hash * 57 + this.Subject.GetHashCode();
                
                if (this.ExpirationDate != null)
                    hash = hash * 57 + this.ExpirationDate.GetHashCode();
                
                if (this.IssueDate != null)
                    hash = hash * 57 + this.IssueDate.GetHashCode();
                
                if (this.Expired != null)
                    hash = hash * 57 + this.Expired.GetHashCode();
                
                if (this.SignatureValid != null)
                    hash = hash * 57 + this.SignatureValid.GetHashCode();
                
                if (this.Valid != null)
                    hash = hash * 57 + this.Valid.GetHashCode();
                
                return hash;
            }
        }

    }


}
