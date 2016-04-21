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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FacetItem.cs
    public partial class FacetItem :  IEquatable<FacetItem>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FacetItem" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="FilterValue">FilterValue.</param>
        /// <param name="Count">Count.</param>

        public FacetItem(string Name = null, string FilterValue = null, int? Count = null)
        {
            this.Name = Name;
            this.FilterValue = FilterValue;
            this.Count = Count;
=======
    public partial class DomainRole :  IEquatable<DomainRole>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainRole" />class.
        /// </summary>
        /// <param name="Id">The ID of the role.</param>
        /// <param name="Name">The name of the role.</param>

        public DomainRole(string Id = null, string Name = null)
        {
            this.Id = Id;
            this.Name = Name;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DomainRole.cs
            
        }

    
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FacetItem.cs
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DomainRole.cs
        /// <summary>
        /// The ID of the role
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FacetItem.cs
        [DataMember(Name="filterValue", EmitDefaultValue=false)]
        public string FilterValue { get; set; }
=======
        /// <value>The ID of the role</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DomainRole.cs
    
        /// <summary>
        /// The name of the role
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FacetItem.cs
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
=======
        /// <value>The name of the role</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DomainRole.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainRole {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FacetItem.cs
            sb.Append("  FilterValue: ").Append(FilterValue).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DomainRole.cs
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
            return this.Equals(obj as DomainRole);
        }

        /// <summary>
        /// Returns true if DomainRole instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FacetItem.cs
        /// <param name="other">Instance of FacetItem to be compared</param>
=======
        /// <param name="other">Instance of DomainRole to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DomainRole.cs
        /// <returns>Boolean</returns>
        public bool Equals(DomainRole other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FacetItem.cs
=======
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DomainRole.cs
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FacetItem.cs
                ) &&
                (
                    this.FilterValue == other.FilterValue ||
                    this.FilterValue != null &&
                    this.FilterValue.Equals(other.FilterValue)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DomainRole.cs
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/FacetItem.cs
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.FilterValue != null)
                    hash = hash * 59 + this.FilterValue.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
=======
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/DomainRole.cs
                return hash;
            }
        }

    }
}
