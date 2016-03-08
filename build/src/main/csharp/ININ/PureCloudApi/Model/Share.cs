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
    public partial class Share :  IEquatable<Share>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SharedEntityTypeEnum {
            
            [EnumMember(Value = "DOCUMENT")]
            Document
        }
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MemberTypeEnum {
            
            [EnumMember(Value = "USER")]
            User,
            
            [EnumMember(Value = "PUBLIC")]
            Public
        }
    
        /// <summary>
        /// Gets or Sets SharedEntityType
        /// </summary>
        [DataMember(Name="sharedEntityType", EmitDefaultValue=false)]
        public SharedEntityTypeEnum? SharedEntityType { get; set; }
    
        /// <summary>
        /// Gets or Sets MemberType
        /// </summary>
        [DataMember(Name="memberType", EmitDefaultValue=false)]
        public MemberTypeEnum? MemberType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Share" /> class.
        /// Initializes a new instance of the <see cref="Share" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="SharedEntityType">SharedEntityType.</param>
        /// <param name="SharedEntity">SharedEntity.</param>
        /// <param name="MemberType">MemberType.</param>
        /// <param name="Member">Member.</param>
        /// <param name="SharedBy">SharedBy.</param>
        /// <param name="Workspace">Workspace.</param>
        /// <param name="User">User.</param>

        public Share(string Name = null, SharedEntityTypeEnum? SharedEntityType = null, UriReference SharedEntity = null, MemberTypeEnum? MemberType = null, UriReference Member = null, UriReference SharedBy = null, UriReference Workspace = null, User User = null, )
        {
            this.Name = Name;
            this.SharedEntityType = SharedEntityType;
            this.SharedEntity = SharedEntity;
            this.MemberType = MemberType;
            this.Member = Member;
            this.SharedBy = SharedBy;
            this.Workspace = Workspace;
            this.User = User;
            
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
        /// Gets or Sets SharedEntity
        /// </summary>
        [DataMember(Name="sharedEntity", EmitDefaultValue=false)]
        public UriReference SharedEntity { get; set; }
    
        /// <summary>
        /// Gets or Sets Member
        /// </summary>
        [DataMember(Name="member", EmitDefaultValue=false)]
        public UriReference Member { get; set; }
    
        /// <summary>
        /// Gets or Sets SharedBy
        /// </summary>
        [DataMember(Name="sharedBy", EmitDefaultValue=false)]
        public UriReference SharedBy { get; set; }
    
        /// <summary>
        /// Gets or Sets Workspace
        /// </summary>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public UriReference Workspace { get; set; }
    
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
    
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
            sb.Append("class Share {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SharedEntityType: ").Append(SharedEntityType).Append("\n");
            sb.Append("  SharedEntity: ").Append(SharedEntity).Append("\n");
            sb.Append("  MemberType: ").Append(MemberType).Append("\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
            sb.Append("  SharedBy: ").Append(SharedBy).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as Share);
        }

        /// <summary>
        /// Returns true if Share instances are equal
        /// </summary>
        /// <param name="other">Instance of Share to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Share other)
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
                    this.SharedEntityType == other.SharedEntityType ||
                    this.SharedEntityType != null &&
                    this.SharedEntityType.Equals(other.SharedEntityType)
                ) && 
                (
                    this.SharedEntity == other.SharedEntity ||
                    this.SharedEntity != null &&
                    this.SharedEntity.Equals(other.SharedEntity)
                ) && 
                (
                    this.MemberType == other.MemberType ||
                    this.MemberType != null &&
                    this.MemberType.Equals(other.MemberType)
                ) && 
                (
                    this.Member == other.Member ||
                    this.Member != null &&
                    this.Member.Equals(other.Member)
                ) && 
                (
                    this.SharedBy == other.SharedBy ||
                    this.SharedBy != null &&
                    this.SharedBy.Equals(other.SharedBy)
                ) && 
                (
                    this.Workspace == other.Workspace ||
                    this.Workspace != null &&
                    this.Workspace.Equals(other.Workspace)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                
                if (this.SharedEntityType != null)
                    hash = hash * 59 + this.SharedEntityType.GetHashCode();
                
                if (this.SharedEntity != null)
                    hash = hash * 59 + this.SharedEntity.GetHashCode();
                
                if (this.MemberType != null)
                    hash = hash * 59 + this.MemberType.GetHashCode();
                
                if (this.Member != null)
                    hash = hash * 59 + this.Member.GetHashCode();
                
                if (this.SharedBy != null)
                    hash = hash * 59 + this.SharedBy.GetHashCode();
                
                if (this.Workspace != null)
                    hash = hash * 59 + this.Workspace.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
