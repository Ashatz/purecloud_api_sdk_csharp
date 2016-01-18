using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AutomateQueue :  IEquatable<AutomateQueue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomateQueue" /> class.
        /// </summary>
        public AutomateQueue()
        {
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// The description for the queue object.
        /// </summary>
        /// <value>The description for the queue object.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
        /// <summary>
        /// The members for the queue object.
        /// </summary>
        /// <value>The members for the queue object.</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<User> Members { get; set; }
  
        
        /// <summary>
        /// The last time that the queue was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The last time that the queue was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="lastUpdateTime", EmitDefaultValue=false)]
        public DateTime? LastUpdateTime { get; set; }
  
        
        /// <summary>
        /// The user who last performed an update.
        /// </summary>
        /// <value>The user who last performed an update.</value>
        [DataMember(Name="lastUpdateUser", EmitDefaultValue=false)]
        public User LastUpdateUser { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomateQueue {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  LastUpdateUser: ").Append(LastUpdateUser).Append("\n");
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
            return this.Equals(obj as AutomateQueue);
        }

        /// <summary>
        /// Returns true if AutomateQueue instances are equal
        /// </summary>
        /// <param name="obj">Instance of AutomateQueue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomateQueue other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(other.Members)
                ) && 
                (
                    this.LastUpdateTime == other.LastUpdateTime ||
                    this.LastUpdateTime != null &&
                    this.LastUpdateTime.Equals(other.LastUpdateTime)
                ) && 
                (
                    this.LastUpdateUser == other.LastUpdateUser ||
                    this.LastUpdateUser != null &&
                    this.LastUpdateUser.Equals(other.LastUpdateUser)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 57 + this.Description.GetHashCode();
                
                if (this.Members != null)
                    hash = hash * 57 + this.Members.GetHashCode();
                
                if (this.LastUpdateTime != null)
                    hash = hash * 57 + this.LastUpdateTime.GetHashCode();
                
                if (this.LastUpdateUser != null)
                    hash = hash * 57 + this.LastUpdateUser.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
