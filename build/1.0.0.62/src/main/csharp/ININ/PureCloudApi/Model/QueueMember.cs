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
    public class QueueMember :  IEquatable<QueueMember>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueMember" /> class.
        /// </summary>
        public QueueMember()
        {
            this.Joined = false;
            
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
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RingNumber
        /// </summary>
        [DataMember(Name="ringNumber", EmitDefaultValue=false)]
        public int? RingNumber { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Joined
        /// </summary>
        [DataMember(Name="joined", EmitDefaultValue=false)]
        public bool? Joined { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MemberBy
        /// </summary>
        [DataMember(Name="memberBy", EmitDefaultValue=false)]
        public string MemberBy { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RoutingStatus
        /// </summary>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public RoutingStatus RoutingStatus { get; set; }
  
        
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
            sb.Append("class QueueMember {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  RingNumber: ").Append(RingNumber).Append("\n");
            sb.Append("  Joined: ").Append(Joined).Append("\n");
            sb.Append("  MemberBy: ").Append(MemberBy).Append("\n");
            sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
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
            return this.Equals(obj as QueueMember);
        }

        /// <summary>
        /// Returns true if QueueMember instances are equal
        /// </summary>
        /// <param name="obj">Instance of QueueMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueMember other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.RingNumber == other.RingNumber ||
                    this.RingNumber != null &&
                    this.RingNumber.Equals(other.RingNumber)
                ) && 
                (
                    this.Joined == other.Joined ||
                    this.Joined != null &&
                    this.Joined.Equals(other.Joined)
                ) && 
                (
                    this.MemberBy == other.MemberBy ||
                    this.MemberBy != null &&
                    this.MemberBy.Equals(other.MemberBy)
                ) && 
                (
                    this.RoutingStatus == other.RoutingStatus ||
                    this.RoutingStatus != null &&
                    this.RoutingStatus.Equals(other.RoutingStatus)
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
                
                if (this.User != null)
                    hash = hash * 57 + this.User.GetHashCode();
                
                if (this.RingNumber != null)
                    hash = hash * 57 + this.RingNumber.GetHashCode();
                
                if (this.Joined != null)
                    hash = hash * 57 + this.Joined.GetHashCode();
                
                if (this.MemberBy != null)
                    hash = hash * 57 + this.MemberBy.GetHashCode();
                
                if (this.RoutingStatus != null)
                    hash = hash * 57 + this.RoutingStatus.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}