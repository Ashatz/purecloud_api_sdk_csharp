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
    public partial class UserStation :  IEquatable<UserStation>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStation" />class.
        /// </summary>
        /// <param name="AssociatedUser">AssociatedUser.</param>
        /// <param name="AssociatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DefaultUser">DefaultUser.</param>

        public UserStation(User AssociatedUser = null, DateTime? AssociatedDate = null, User DefaultUser = null)
        {
            this.AssociatedUser = AssociatedUser;
            this.AssociatedDate = AssociatedDate;
            this.DefaultUser = DefaultUser;
            
        }
        
    
        /// <summary>
        /// A globally unique identifier for this station
        /// </summary>
        /// <value>A globally unique identifier for this station</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets AssociatedUser
        /// </summary>
        [DataMember(Name="associatedUser", EmitDefaultValue=false)]
        public User AssociatedUser { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="associatedDate", EmitDefaultValue=false)]
        public DateTime? AssociatedDate { get; set; }
    
        /// <summary>
        /// Gets or Sets DefaultUser
        /// </summary>
        [DataMember(Name="defaultUser", EmitDefaultValue=false)]
        public User DefaultUser { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserStation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssociatedUser: ").Append(AssociatedUser).Append("\n");
            sb.Append("  AssociatedDate: ").Append(AssociatedDate).Append("\n");
            sb.Append("  DefaultUser: ").Append(DefaultUser).Append("\n");
            
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
            return this.Equals(obj as UserStation);
        }

        /// <summary>
        /// Returns true if UserStation instances are equal
        /// </summary>
        /// <param name="other">Instance of UserStation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserStation other)
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
                    this.AssociatedUser == other.AssociatedUser ||
                    this.AssociatedUser != null &&
                    this.AssociatedUser.Equals(other.AssociatedUser)
                ) &&
                (
                    this.AssociatedDate == other.AssociatedDate ||
                    this.AssociatedDate != null &&
                    this.AssociatedDate.Equals(other.AssociatedDate)
                ) &&
                (
                    this.DefaultUser == other.DefaultUser ||
                    this.DefaultUser != null &&
                    this.DefaultUser.Equals(other.DefaultUser)
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
                
                if (this.AssociatedUser != null)
                    hash = hash * 59 + this.AssociatedUser.GetHashCode();
                
                if (this.AssociatedDate != null)
                    hash = hash * 59 + this.AssociatedDate.GetHashCode();
                
                if (this.DefaultUser != null)
                    hash = hash * 59 + this.DefaultUser.GetHashCode();
                
                return hash;
            }
        }

    }
}
