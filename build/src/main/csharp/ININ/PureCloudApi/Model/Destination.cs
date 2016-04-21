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
    public partial class Destination :  IEquatable<Destination>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Destination" />class.
        /// </summary>
<<<<<<< HEAD
        /// <param name="AccountCodeDigits">AccountCodeDigits.</param>
        /// <param name="PostConnectDigits">PostConnectDigits.</param>
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <param name="Address">Address or phone number. (required).</param>
        /// <param name="Name">Name.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="QueueId">QueueId.</param>

<<<<<<< HEAD
        public Destination(string AccountCodeDigits = null, string PostConnectDigits = null, string Address = null, string Name = null, string UserId = null, string QueueId = null)
=======
        public Destination(string Address = null, string Name = null, string UserId = null, string QueueId = null)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        {
            // to ensure "Address" is required (not null)
            if (Address == null)
            {
                throw new InvalidDataException("Address is a required property for Destination and cannot be null");
            }
            else
            {
                this.Address = Address;
            }
<<<<<<< HEAD
            this.AccountCodeDigits = AccountCodeDigits;
            this.PostConnectDigits = PostConnectDigits;
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            this.Name = Name;
            this.UserId = UserId;
            this.QueueId = QueueId;
            
        }

    
<<<<<<< HEAD
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
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
        /// <param name="other">Instance of Destination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Destination other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
<<<<<<< HEAD
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
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                if (this.AccountCodeDigits != null)
                    hash = hash * 59 + this.AccountCodeDigits.GetHashCode();
                if (this.PostConnectDigits != null)
                    hash = hash * 59 + this.PostConnectDigits.GetHashCode();
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                return hash;
            }
        }

    }
}
