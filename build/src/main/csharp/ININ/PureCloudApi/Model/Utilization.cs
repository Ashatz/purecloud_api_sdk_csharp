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
    public partial class Utilization :  IEquatable<Utilization>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Utilization" />class.
        /// </summary>
<<<<<<< HEAD
        /// <param name="Name">Name.</param>
        /// <param name="_Utilization">Map of media types to utilization settings.  Map keys can be: call, chat, email, or socialExpression.</param>

        public Utilization(string Name = null, Dictionary<string, OrgMediaUtilization> _Utilization = null)
        {
            this.Name = Name;
=======
        /// <param name="_Utilization">Map of media types to utilization settings.  Map keys can be: call, chat, email, or socialExpression.</param>

        public Utilization(Dictionary<string, OrgMediaUtilization> _Utilization = null)
        {
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            this._Utilization = _Utilization;
            
        }

    
<<<<<<< HEAD
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
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Map of media types to utilization settings.  Map keys can be: call, chat, email, or socialExpression
        /// </summary>
        /// <value>Map of media types to utilization settings.  Map keys can be: call, chat, email, or socialExpression</value>
        [DataMember(Name="utilization", EmitDefaultValue=false)]
        public Dictionary<string, OrgMediaUtilization> _Utilization { get; set; }
    
<<<<<<< HEAD
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Utilization {\n");
            sb.Append("  _Utilization: ").Append(_Utilization).Append("\n");
<<<<<<< HEAD
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            return this.Equals(obj as Utilization);
        }

        /// <summary>
        /// Returns true if Utilization instances are equal
        /// </summary>
        /// <param name="other">Instance of Utilization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Utilization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
<<<<<<< HEAD
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
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                (
                    this._Utilization == other._Utilization ||
                    this._Utilization != null &&
                    this._Utilization.SequenceEqual(other._Utilization)
<<<<<<< HEAD
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this._Utilization != null)
                    hash = hash * 59 + this._Utilization.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
=======
                if (this._Utilization != null)
                    hash = hash * 59 + this._Utilization.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
