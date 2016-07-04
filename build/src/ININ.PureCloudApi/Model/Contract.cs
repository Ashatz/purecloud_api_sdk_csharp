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
    /// Contract
    /// </summary>
    [DataContract]
    public partial class Contract :  IEquatable<Contract>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Contract() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Quote">Quote (required).</param>
        /// <param name="SignerUrl">Signer URL (required).</param>
        /// <param name="Job">Job (required).</param>
        public Contract(string Name = null, Quote Quote = null, string SignerUrl = null, ContractJob Job = null)
        {
            // to ensure "Quote" is required (not null)
            if (Quote == null)
            {
                throw new InvalidDataException("Quote is a required property for Contract and cannot be null");
            }
            else
            {
                this.Quote = Quote;
            }
            // to ensure "SignerUrl" is required (not null)
            if (SignerUrl == null)
            {
                throw new InvalidDataException("SignerUrl is a required property for Contract and cannot be null");
            }
            else
            {
                this.SignerUrl = SignerUrl;
            }
            // to ensure "Job" is required (not null)
            if (Job == null)
            {
                throw new InvalidDataException("Job is a required property for Contract and cannot be null");
            }
            else
            {
                this.Job = Job;
            }
            this.Name = Name;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Quote
        /// </summary>
        /// <value>Quote</value>
        [DataMember(Name="quote", EmitDefaultValue=false)]
        public Quote Quote { get; set; }
        /// <summary>
        /// Signer URL
        /// </summary>
        /// <value>Signer URL</value>
        [DataMember(Name="signerUrl", EmitDefaultValue=false)]
        public string SignerUrl { get; set; }
        /// <summary>
        /// Job
        /// </summary>
        /// <value>Job</value>
        [DataMember(Name="job", EmitDefaultValue=false)]
        public ContractJob Job { get; set; }
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contract {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quote: ").Append(Quote).Append("\n");
            sb.Append("  SignerUrl: ").Append(SignerUrl).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
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
            return this.Equals(obj as Contract);
        }

        /// <summary>
        /// Returns true if Contract instances are equal
        /// </summary>
        /// <param name="other">Instance of Contract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contract other)
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
                    this.Quote == other.Quote ||
                    this.Quote != null &&
                    this.Quote.Equals(other.Quote)
                ) &&
                (
                    this.SignerUrl == other.SignerUrl ||
                    this.SignerUrl != null &&
                    this.SignerUrl.Equals(other.SignerUrl)
                ) &&
                (
                    this.Job == other.Job ||
                    this.Job != null &&
                    this.Job.Equals(other.Job)
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
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Quote != null)
                    hash = hash * 59 + this.Quote.GetHashCode();
                if (this.SignerUrl != null)
                    hash = hash * 59 + this.SignerUrl.GetHashCode();
                if (this.Job != null)
                    hash = hash * 59 + this.Job.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
