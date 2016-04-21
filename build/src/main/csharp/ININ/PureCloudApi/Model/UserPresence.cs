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
    public partial class UserPresence :  IEquatable<UserPresence>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPresence" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
<<<<<<< HEAD
        /// <param name="User">User.</param>
        /// <param name="Source">Represents the source where the Presence was set. Some examples are: PURECLOUD, LYNC, OUTLOOK, etc..</param>
        /// <param name="PresenceDefinition">PresenceDefinition.</param>
        /// <param name="Message">Message.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>

        public UserPresence(string Name = null, User User = null, string Source = null, OrganizationPresence PresenceDefinition = null, string Message = null, User ModifiedBy = null, DateTime? ModifiedDate = null)
        {
            this.Name = Name;
            this.User = User;
            this.Source = Source;
            this.PresenceDefinition = PresenceDefinition;
            this.Message = Message;
            this.ModifiedBy = ModifiedBy;
            this.ModifiedDate = ModifiedDate;
=======
        /// <param name="Source">Represents the source where the Presence was set. Some examples are: PURECLOUD, LYNC, OUTLOOK, etc..</param>
        /// <param name="Primary">A boolean used to tell whether or not to set this presence source as the primary on a PATCH (default to false).</param>
        /// <param name="PresenceDefinition">PresenceDefinition.</param>
        /// <param name="Message">Message.</param>

        public UserPresence(string Name = null, string Source = null, bool? Primary = null, OrganizationPresence PresenceDefinition = null, string Message = null)
        {
            this.Name = Name;
            this.Source = Source;
            // use default value if no "Primary" provided
            if (Primary == null)
            {
                this.Primary = false;
            }
            else
            {
                this.Primary = Primary;
            }
            this.PresenceDefinition = PresenceDefinition;
            this.Message = Message;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
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
    
<<<<<<< HEAD
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Represents the source where the Presence was set. Some examples are: PURECLOUD, LYNC, OUTLOOK, etc.
        /// </summary>
        /// <value>Represents the source where the Presence was set. Some examples are: PURECLOUD, LYNC, OUTLOOK, etc.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }
    
<<<<<<< HEAD
=======
        /// <summary>
        /// A boolean used to tell whether or not to set this presence source as the primary on a PATCH
        /// </summary>
        /// <value>A boolean used to tell whether or not to set this presence source as the primary on a PATCH</value>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public bool? Primary { get; set; }
    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Gets or Sets PresenceDefinition
        /// </summary>
        [DataMember(Name="presenceDefinition", EmitDefaultValue=false)]
        public OrganizationPresence PresenceDefinition { get; set; }
    
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
    
<<<<<<< HEAD
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public User ModifiedBy { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            sb.Append("class UserPresence {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  PresenceDefinition: ").Append(PresenceDefinition).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as UserPresence);
        }

        /// <summary>
        /// Returns true if UserPresence instances are equal
        /// </summary>
        /// <param name="other">Instance of UserPresence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPresence other)
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
<<<<<<< HEAD
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
<<<<<<< HEAD
=======
                (
                    this.Primary == other.Primary ||
                    this.Primary != null &&
                    this.Primary.Equals(other.Primary)
                ) &&
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                (
                    this.PresenceDefinition == other.PresenceDefinition ||
                    this.PresenceDefinition != null &&
                    this.PresenceDefinition.Equals(other.PresenceDefinition)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
<<<<<<< HEAD
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
=======
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.Primary != null)
                    hash = hash * 59 + this.Primary.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.PresenceDefinition != null)
                    hash = hash * 59 + this.PresenceDefinition.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
<<<<<<< HEAD
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
