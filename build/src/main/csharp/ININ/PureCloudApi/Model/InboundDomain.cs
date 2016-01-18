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
    public class InboundDomain :  IEquatable<InboundDomain>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundDomain" /> class.
        /// </summary>
        public InboundDomain()
        {
            this.SubDomain = false;
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MxRecordStatus
        /// </summary>
        [DataMember(Name="mxRecordStatus", EmitDefaultValue=false)]
        public string MxRecordStatus { get; set; }
  
        
        /// <summary>
        /// Indicates if this a PureCloud sub-domain.  If true, then the appropriate DNS records are created for sending/receiving email.
        /// </summary>
        /// <value>Indicates if this a PureCloud sub-domain.  If true, then the appropriate DNS records are created for sending/receiving email.</value>
        [DataMember(Name="subDomain", EmitDefaultValue=false)]
        public bool? SubDomain { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundDomain {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MxRecordStatus: ").Append(MxRecordStatus).Append("\n");
            sb.Append("  SubDomain: ").Append(SubDomain).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            
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
            return this.Equals(obj as InboundDomain);
        }

        /// <summary>
        /// Returns true if InboundDomain instances are equal
        /// </summary>
        /// <param name="obj">Instance of InboundDomain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundDomain other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.MxRecordStatus == other.MxRecordStatus ||
                    this.MxRecordStatus != null &&
                    this.MxRecordStatus.Equals(other.MxRecordStatus)
                ) && 
                (
                    this.SubDomain == other.SubDomain ||
                    this.SubDomain != null &&
                    this.SubDomain.Equals(other.SubDomain)
                ) && 
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.MxRecordStatus != null)
                    hash = hash * 57 + this.MxRecordStatus.GetHashCode();
                
                if (this.SubDomain != null)
                    hash = hash * 57 + this.SubDomain.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
