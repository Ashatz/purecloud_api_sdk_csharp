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
    public partial class DocumentUpdate :  IEquatable<DocumentUpdate>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentUpdate" />class.
        /// </summary>
        /// <param name="ChangeNumber">ChangeNumber.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Read">Read (default to false).</param>
<<<<<<< HEAD
        /// <param name="UpdateAttributes">UpdateAttributes.</param>
        /// <param name="RemoveAttributes">RemoveAttributes.</param>
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <param name="AddTags">AddTags.</param>
        /// <param name="RemoveTags">RemoveTags.</param>
        /// <param name="AddTagIds">AddTagIds.</param>
        /// <param name="RemoveTagIds">RemoveTagIds.</param>
<<<<<<< HEAD
        /// <param name="AddAttributeGroupInstanceIds">AddAttributeGroupInstanceIds.</param>
        /// <param name="RemoveAttributeGroupInstanceIds">RemoveAttributeGroupInstanceIds.</param>

        public DocumentUpdate(int? ChangeNumber = null, string Name = null, bool? Read = null, List<AttributeValue> UpdateAttributes = null, List<string> RemoveAttributes = null, List<string> AddTags = null, List<string> RemoveTags = null, List<string> AddTagIds = null, List<string> RemoveTagIds = null, List<string> AddAttributeGroupInstanceIds = null, List<string> RemoveAttributeGroupInstanceIds = null)
=======
        /// <param name="UpdateAttributes">UpdateAttributes.</param>
        /// <param name="RemoveAttributes">RemoveAttributes.</param>

        public DocumentUpdate(int? ChangeNumber = null, string Name = null, bool? Read = null, List<string> AddTags = null, List<string> RemoveTags = null, List<string> AddTagIds = null, List<string> RemoveTagIds = null, List<DocumentAttribute> UpdateAttributes = null, List<string> RemoveAttributes = null)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        {
            this.ChangeNumber = ChangeNumber;
            this.Name = Name;
            // use default value if no "Read" provided
            if (Read == null)
            {
                this.Read = false;
            }
            else
            {
                this.Read = Read;
            }
<<<<<<< HEAD
            this.UpdateAttributes = UpdateAttributes;
            this.RemoveAttributes = RemoveAttributes;
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            this.AddTags = AddTags;
            this.RemoveTags = RemoveTags;
            this.AddTagIds = AddTagIds;
            this.RemoveTagIds = RemoveTagIds;
<<<<<<< HEAD
            this.AddAttributeGroupInstanceIds = AddAttributeGroupInstanceIds;
            this.RemoveAttributeGroupInstanceIds = RemoveAttributeGroupInstanceIds;
=======
            this.UpdateAttributes = UpdateAttributes;
            this.RemoveAttributes = RemoveAttributes;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    
        /// <summary>
        /// Gets or Sets ChangeNumber
        /// </summary>
        [DataMember(Name="changeNumber", EmitDefaultValue=false)]
        public int? ChangeNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }
    
<<<<<<< HEAD
        /// <summary>
        /// Gets or Sets UpdateAttributes
        /// </summary>
        [DataMember(Name="updateAttributes", EmitDefaultValue=false)]
        public List<AttributeValue> UpdateAttributes { get; set; }
    
        /// <summary>
        /// Gets or Sets RemoveAttributes
        /// </summary>
        [DataMember(Name="removeAttributes", EmitDefaultValue=false)]
        public List<string> RemoveAttributes { get; set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Gets or Sets AddTags
        /// </summary>
        [DataMember(Name="addTags", EmitDefaultValue=false)]
        public List<string> AddTags { get; set; }
    
        /// <summary>
        /// Gets or Sets RemoveTags
        /// </summary>
        [DataMember(Name="removeTags", EmitDefaultValue=false)]
        public List<string> RemoveTags { get; set; }
    
        /// <summary>
        /// Gets or Sets AddTagIds
        /// </summary>
        [DataMember(Name="addTagIds", EmitDefaultValue=false)]
        public List<string> AddTagIds { get; set; }
    
        /// <summary>
        /// Gets or Sets RemoveTagIds
        /// </summary>
        [DataMember(Name="removeTagIds", EmitDefaultValue=false)]
        public List<string> RemoveTagIds { get; set; }
    
        /// <summary>
        /// Gets or Sets UpdateAttributes
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="addAttributeGroupInstanceIds", EmitDefaultValue=false)]
        public List<string> AddAttributeGroupInstanceIds { get; set; }
=======
        [DataMember(Name="updateAttributes", EmitDefaultValue=false)]
        public List<DocumentAttribute> UpdateAttributes { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets RemoveAttributes
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="removeAttributeGroupInstanceIds", EmitDefaultValue=false)]
        public List<string> RemoveAttributeGroupInstanceIds { get; set; }
=======
        [DataMember(Name="removeAttributes", EmitDefaultValue=false)]
        public List<string> RemoveAttributes { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentUpdate {\n");
            sb.Append("  ChangeNumber: ").Append(ChangeNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  AddTags: ").Append(AddTags).Append("\n");
            sb.Append("  RemoveTags: ").Append(RemoveTags).Append("\n");
            sb.Append("  AddTagIds: ").Append(AddTagIds).Append("\n");
            sb.Append("  RemoveTagIds: ").Append(RemoveTagIds).Append("\n");
<<<<<<< HEAD
            sb.Append("  AddAttributeGroupInstanceIds: ").Append(AddAttributeGroupInstanceIds).Append("\n");
            sb.Append("  RemoveAttributeGroupInstanceIds: ").Append(RemoveAttributeGroupInstanceIds).Append("\n");
=======
            sb.Append("  UpdateAttributes: ").Append(UpdateAttributes).Append("\n");
            sb.Append("  RemoveAttributes: ").Append(RemoveAttributes).Append("\n");
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
            return this.Equals(obj as DocumentUpdate);
        }

        /// <summary>
        /// Returns true if DocumentUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ChangeNumber == other.ChangeNumber ||
                    this.ChangeNumber != null &&
                    this.ChangeNumber.Equals(other.ChangeNumber)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
                ) &&
<<<<<<< HEAD
                (
                    this.UpdateAttributes == other.UpdateAttributes ||
                    this.UpdateAttributes != null &&
                    this.UpdateAttributes.SequenceEqual(other.UpdateAttributes)
                ) &&
                (
                    this.RemoveAttributes == other.RemoveAttributes ||
                    this.RemoveAttributes != null &&
                    this.RemoveAttributes.SequenceEqual(other.RemoveAttributes)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                (
                    this.AddTags == other.AddTags ||
                    this.AddTags != null &&
                    this.AddTags.SequenceEqual(other.AddTags)
                ) &&
                (
                    this.RemoveTags == other.RemoveTags ||
                    this.RemoveTags != null &&
                    this.RemoveTags.SequenceEqual(other.RemoveTags)
                ) &&
                (
                    this.AddTagIds == other.AddTagIds ||
                    this.AddTagIds != null &&
                    this.AddTagIds.SequenceEqual(other.AddTagIds)
                ) &&
                (
                    this.RemoveTagIds == other.RemoveTagIds ||
                    this.RemoveTagIds != null &&
                    this.RemoveTagIds.SequenceEqual(other.RemoveTagIds)
                ) &&
                (
<<<<<<< HEAD
                    this.AddAttributeGroupInstanceIds == other.AddAttributeGroupInstanceIds ||
                    this.AddAttributeGroupInstanceIds != null &&
                    this.AddAttributeGroupInstanceIds.SequenceEqual(other.AddAttributeGroupInstanceIds)
=======
                    this.UpdateAttributes == other.UpdateAttributes ||
                    this.UpdateAttributes != null &&
                    this.UpdateAttributes.SequenceEqual(other.UpdateAttributes)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                ) &&
                (
                    this.RemoveAttributes == other.RemoveAttributes ||
                    this.RemoveAttributes != null &&
                    this.RemoveAttributes.SequenceEqual(other.RemoveAttributes)
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
                if (this.ChangeNumber != null)
                    hash = hash * 59 + this.ChangeNumber.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Read != null)
                    hash = hash * 59 + this.Read.GetHashCode();
<<<<<<< HEAD
                if (this.UpdateAttributes != null)
                    hash = hash * 59 + this.UpdateAttributes.GetHashCode();
                if (this.RemoveAttributes != null)
                    hash = hash * 59 + this.RemoveAttributes.GetHashCode();
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.AddTags != null)
                    hash = hash * 59 + this.AddTags.GetHashCode();
                if (this.RemoveTags != null)
                    hash = hash * 59 + this.RemoveTags.GetHashCode();
                if (this.AddTagIds != null)
                    hash = hash * 59 + this.AddTagIds.GetHashCode();
                if (this.RemoveTagIds != null)
                    hash = hash * 59 + this.RemoveTagIds.GetHashCode();
<<<<<<< HEAD
                if (this.AddAttributeGroupInstanceIds != null)
                    hash = hash * 59 + this.AddAttributeGroupInstanceIds.GetHashCode();
                if (this.RemoveAttributeGroupInstanceIds != null)
                    hash = hash * 59 + this.RemoveAttributeGroupInstanceIds.GetHashCode();
=======
                if (this.UpdateAttributes != null)
                    hash = hash * 59 + this.UpdateAttributes.GetHashCode();
                if (this.RemoveAttributes != null)
                    hash = hash * 59 + this.RemoveAttributes.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
