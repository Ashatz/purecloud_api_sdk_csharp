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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTransformModel.cs
    public partial class ClientTransformModel :  IEquatable<ClientTransformModel>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientTransformModel" />class.
=======
    public partial class ClientTextTableTransform :  IEquatable<ClientTextTableTransform>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientTextTableTransform" />class.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTextTableTransform.cs
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="EndpointId">EndpointId.</param>
        /// <param name="FilenameReplaces">FilenameReplaces.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Name">Name.</param>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTransformModel.cs

        public ClientTransformModel(string Id = null, string EndpointId = null, List<BasicTransform> FilenameReplaces = null, List<TagModel> Tags = null, string Name = null)
=======
        /// <param name="Comments">Comments.</param>
        /// <param name="Delimiter">Delimiter.</param>
        /// <param name="Table">Table.</param>

        public ClientTextTableTransform(string Id = null, string EndpointId = null, List<BasicTransform> FilenameReplaces = null, List<TagModel> Tags = null, string Name = null, string Comments = null, string Delimiter = null, TableTransform Table = null)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTextTableTransform.cs
        {
            this.Id = Id;
            this.EndpointId = EndpointId;
            this.FilenameReplaces = FilenameReplaces;
            this.Tags = Tags;
            this.Name = Name;
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTransformModel.cs
=======
            this.Comments = Comments;
            this.Delimiter = Delimiter;
            this.Table = Table;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTextTableTransform.cs
            
        }

    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets EndpointId
        /// </summary>
        [DataMember(Name="endpointId", EmitDefaultValue=false)]
        public string EndpointId { get; set; }
    
        /// <summary>
        /// Gets or Sets FilenameReplaces
        /// </summary>
        [DataMember(Name="filenameReplaces", EmitDefaultValue=false)]
        public List<BasicTransform> FilenameReplaces { get; set; }
    
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<TagModel> Tags { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTransformModel.cs
=======
        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }
    
        /// <summary>
        /// Gets or Sets Delimiter
        /// </summary>
        [DataMember(Name="delimiter", EmitDefaultValue=false)]
        public string Delimiter { get; set; }
    
        /// <summary>
        /// Gets or Sets Table
        /// </summary>
        [DataMember(Name="table", EmitDefaultValue=false)]
        public TableTransform Table { get; set; }
    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTextTableTransform.cs
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientTextTableTransform {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EndpointId: ").Append(EndpointId).Append("\n");
            sb.Append("  FilenameReplaces: ").Append(FilenameReplaces).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTransformModel.cs
=======
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTextTableTransform.cs
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
            return this.Equals(obj as ClientTextTableTransform);
        }

        /// <summary>
        /// Returns true if ClientTextTableTransform instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTransformModel.cs
        /// <param name="other">Instance of ClientTransformModel to be compared</param>
=======
        /// <param name="other">Instance of ClientTextTableTransform to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTextTableTransform.cs
        /// <returns>Boolean</returns>
        public bool Equals(ClientTextTableTransform other)
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
                    this.EndpointId == other.EndpointId ||
                    this.EndpointId != null &&
                    this.EndpointId.Equals(other.EndpointId)
                ) &&
                (
                    this.FilenameReplaces == other.FilenameReplaces ||
                    this.FilenameReplaces != null &&
                    this.FilenameReplaces.SequenceEqual(other.FilenameReplaces)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
                ) &&
                (
                    this.Delimiter == other.Delimiter ||
                    this.Delimiter != null &&
                    this.Delimiter.Equals(other.Delimiter)
                ) &&
                (
                    this.Table == other.Table ||
                    this.Table != null &&
                    this.Table.Equals(other.Table)
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
                if (this.EndpointId != null)
                    hash = hash * 59 + this.EndpointId.GetHashCode();
                if (this.FilenameReplaces != null)
                    hash = hash * 59 + this.FilenameReplaces.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTransformModel.cs
=======
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                if (this.Delimiter != null)
                    hash = hash * 59 + this.Delimiter.GetHashCode();
                if (this.Table != null)
                    hash = hash * 59 + this.Table.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/ClientTextTableTransform.cs
                return hash;
            }
        }

    }
}
