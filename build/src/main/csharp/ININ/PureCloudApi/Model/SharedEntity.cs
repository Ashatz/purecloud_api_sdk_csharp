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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ListDefinition.cs
    public partial class ListDefinition :  IEquatable<ListDefinition>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDefinition" />class.
        /// </summary>
        /// <param name="Values">Values.</param>

        public ListDefinition(List<string> Values = null)
        {
            this.Values = Values;
=======
    public partial class SharedEntity :  IEquatable<SharedEntity>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedEntity" />class.
        /// </summary>
        /// <param name="Id">Id.</param>

        public SharedEntity(string Id = null)
        {
            this.Id = Id;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/SharedEntity.cs
            
        }

    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ListDefinition.cs
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }
=======
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/SharedEntity.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ListDefinition.cs
            sb.Append("class ListDefinition {\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
=======
            sb.Append("class SharedEntity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/SharedEntity.cs
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
            return this.Equals(obj as SharedEntity);
        }

        /// <summary>
        /// Returns true if SharedEntity instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ListDefinition.cs
        /// <param name="other">Instance of ListDefinition to be compared</param>
=======
        /// <param name="other">Instance of SharedEntity to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/SharedEntity.cs
        /// <returns>Boolean</returns>
        public bool Equals(SharedEntity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ListDefinition.cs
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
=======
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/SharedEntity.cs
                return hash;
            }
        }

    }
}
