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
    public partial class Group :  IEquatable<Group>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GroupTypeEnum {
            
            [EnumMember(Value = "OFFICIAL")]
            Official,
            
            [EnumMember(Value = "DISTRIBUTION_GROUP")]
            DistributionGroup
        }
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GroupStateEnum {
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            
            [EnumMember(Value = "DELETED")]
            Deleted
        }
        
        /// <summary>
        /// Gets or Sets GroupType
        /// </summary>
        [DataMember(Name="groupType", EmitDefaultValue=false)]
        public GroupTypeEnum? GroupType { get; set; }
    
        /// <summary>
        /// Gets or Sets GroupState
        /// </summary>
        [DataMember(Name="groupState", EmitDefaultValue=false)]
        public GroupStateEnum? GroupState { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="MemberCount">MemberCount.</param>
        /// <param name="GroupType">GroupType.</param>
        /// <param name="GroupImages">GroupImages.</param>
        /// <param name="GroupState">GroupState.</param>

        public Group(string Name = null, string Description = null, long? MemberCount = null, GroupTypeEnum? GroupType = null, GroupImages GroupImages = null, GroupStateEnum? GroupState = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.MemberCount = MemberCount;
            this.GroupType = GroupType;
            this.GroupImages = GroupImages;
            this.GroupState = GroupState;
            
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets MemberCount
        /// </summary>
        [DataMember(Name="memberCount", EmitDefaultValue=false)]
        public long? MemberCount { get; set; }
    
        /// <summary>
        /// Gets or Sets GroupImages
        /// </summary>
        [DataMember(Name="groupImages", EmitDefaultValue=false)]
        public GroupImages GroupImages { get; set; }
    
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
            sb.Append("class Group {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  GroupImages: ").Append(GroupImages).Append("\n");
            sb.Append("  GroupState: ").Append(GroupState).Append("\n");
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
            return this.Equals(obj as Group);
        }

        /// <summary>
        /// Returns true if Group instances are equal
        /// </summary>
        /// <param name="other">Instance of Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Group other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.MemberCount == other.MemberCount ||
                    this.MemberCount != null &&
                    this.MemberCount.Equals(other.MemberCount)
                ) &&
                (
                    this.GroupType == other.GroupType ||
                    this.GroupType != null &&
                    this.GroupType.Equals(other.GroupType)
                ) &&
                (
                    this.GroupImages == other.GroupImages ||
                    this.GroupImages != null &&
                    this.GroupImages.Equals(other.GroupImages)
                ) &&
                (
                    this.GroupState == other.GroupState ||
                    this.GroupState != null &&
                    this.GroupState.Equals(other.GroupState)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.MemberCount != null)
                    hash = hash * 59 + this.MemberCount.GetHashCode();
                
                if (this.GroupType != null)
                    hash = hash * 59 + this.GroupType.GetHashCode();
                
                if (this.GroupImages != null)
                    hash = hash * 59 + this.GroupImages.GetHashCode();
                
                if (this.GroupState != null)
                    hash = hash * 59 + this.GroupState.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
