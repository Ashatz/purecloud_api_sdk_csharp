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
    public class Destination :  IEquatable<Destination>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Destination" /> class.
        /// </summary>
        public Destination()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets AccountCodeDigits
        /// </summary>
        [DataMember(Name="accountCodeDigits", EmitDefaultValue=false)]
        public string AccountCodeDigits { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PostConnectDigits
        /// </summary>
        [DataMember(Name="postConnectDigits", EmitDefaultValue=false)]
        public string PostConnectDigits { get; set; }
  
        
        /// <summary>
        /// Address or phone number.
        /// </summary>
        /// <value>Address or phone number.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Destination {\n");
            sb.Append("  AccountCodeDigits: ").Append(AccountCodeDigits).Append("\n");
            sb.Append("  PostConnectDigits: ").Append(PostConnectDigits).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            
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
            return this.Equals(obj as Destination);
        }

        /// <summary>
        /// Returns true if Destination instances are equal
        /// </summary>
        /// <param name="obj">Instance of Destination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Destination other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountCodeDigits == other.AccountCodeDigits ||
                    this.AccountCodeDigits != null &&
                    this.AccountCodeDigits.Equals(other.AccountCodeDigits)
                ) && 
                (
                    this.PostConnectDigits == other.PostConnectDigits ||
                    this.PostConnectDigits != null &&
                    this.PostConnectDigits.Equals(other.PostConnectDigits)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
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
                
                if (this.AccountCodeDigits != null)
                    hash = hash * 57 + this.AccountCodeDigits.GetHashCode();
                
                if (this.PostConnectDigits != null)
                    hash = hash * 57 + this.PostConnectDigits.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 57 + this.Address.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 57 + this.UserId.GetHashCode();
                
                if (this.QueueId != null)
                    hash = hash * 57 + this.QueueId.GetHashCode();
                
                return hash;
            }
        }

    }


}
