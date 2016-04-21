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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceQueryRequest.cs
    public partial class InstanceQueryRequest :  IEquatable<InstanceQueryRequest>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceQueryRequest" />class.
        /// </summary>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="Sort">Sort.</param>
        /// <param name="Members">Members.</param>

        public InstanceQueryRequest(int? PageNumber = null, int? PageSize = null, List<SortItem> Sort = null, List<InstanceMemberFilter> Members = null)
        {
            this.PageNumber = PageNumber;
            this.PageSize = PageSize;
            this.Sort = Sort;
            this.Members = Members;
=======
    public partial class PagingSpec :  IEquatable<PagingSpec>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PagingSpec" />class.
        /// </summary>
        /// <param name="PageSize">How many results per page.</param>
        /// <param name="PageNumber">How many pages in.</param>

        public PagingSpec(int? PageSize = null, int? PageNumber = null)
        {
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/PagingSpec.cs
            
        }

    
        /// <summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceQueryRequest.cs
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets PageSize
=======
        /// How many results per page
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/PagingSpec.cs
        /// </summary>
        /// <value>How many results per page</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
    
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceQueryRequest.cs
        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<SortItem> Sort { get; set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/PagingSpec.cs
        /// <summary>
        /// How many pages in
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceQueryRequest.cs
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<InstanceMemberFilter> Members { get; set; }
=======
        /// <value>How many pages in</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/PagingSpec.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PagingSpec {\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceQueryRequest.cs
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
=======
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/PagingSpec.cs
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
            return this.Equals(obj as PagingSpec);
        }

        /// <summary>
        /// Returns true if PagingSpec instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceQueryRequest.cs
        /// <param name="other">Instance of InstanceQueryRequest to be compared</param>
=======
        /// <param name="other">Instance of PagingSpec to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/PagingSpec.cs
        /// <returns>Boolean</returns>
        public bool Equals(PagingSpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceQueryRequest.cs
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/PagingSpec.cs
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceQueryRequest.cs
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
                ) &&
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(other.Members)
=======
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/PagingSpec.cs
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/InstanceQueryRequest.cs
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.Members != null)
                    hash = hash * 59 + this.Members.GetHashCode();
=======
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/PagingSpec.cs
                return hash;
            }
        }

    }
}
