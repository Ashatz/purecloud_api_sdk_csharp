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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PrimaryUserPresenceSource.cs
    public partial class PrimaryUserPresenceSource :  IEquatable<PrimaryUserPresenceSource>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryUserPresenceSource" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="User">User.</param>
        /// <param name="PrimarySource">PrimarySource.</param>

        public PrimaryUserPresenceSource(string Name = null, User User = null, string PrimarySource = null)
        {
            this.Name = Name;
            this.User = User;
            this.PrimarySource = PrimarySource;
=======
    public partial class Currency :  IEquatable<Currency>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Currency" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DecimalPlaces">DecimalPlaces.</param>

        public Currency(string Name = null, int? DecimalPlaces = null)
        {
            this.Name = Name;
            this.DecimalPlaces = DecimalPlaces;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Currency.cs
            
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
    
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PrimaryUserPresenceSource.cs
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Currency.cs
        /// <summary>
        /// Gets or Sets DecimalPlaces
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PrimaryUserPresenceSource.cs
        [DataMember(Name="primarySource", EmitDefaultValue=false)]
        public string PrimarySource { get; set; }
=======
        [DataMember(Name="decimalPlaces", EmitDefaultValue=false)]
        public int? DecimalPlaces { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Currency.cs
    
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
            sb.Append("class Currency {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
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
            return this.Equals(obj as Currency);
        }

        /// <summary>
        /// Returns true if Currency instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PrimaryUserPresenceSource.cs
        /// <param name="other">Instance of PrimaryUserPresenceSource to be compared</param>
=======
        /// <param name="other">Instance of Currency to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Currency.cs
        /// <returns>Boolean</returns>
        public bool Equals(Currency other)
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PrimaryUserPresenceSource.cs
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.PrimarySource == other.PrimarySource ||
                    this.PrimarySource != null &&
                    this.PrimarySource.Equals(other.PrimarySource)
=======
                (
                    this.DecimalPlaces == other.DecimalPlaces ||
                    this.DecimalPlaces != null &&
                    this.DecimalPlaces.Equals(other.DecimalPlaces)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Currency.cs
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PrimaryUserPresenceSource.cs
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.PrimarySource != null)
                    hash = hash * 59 + this.PrimarySource.GetHashCode();
=======
                if (this.DecimalPlaces != null)
                    hash = hash * 59 + this.DecimalPlaces.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Currency.cs
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
