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
    /// CreateUser
    /// </summary>
    [DataContract]
    public partial class CreateUser :  IEquatable<CreateUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUser" /> class.
        /// </summary>
        /// <param name="Name">User&#39;s full name (required).</param>
        /// <param name="Department">Department.</param>
        /// <param name="Email">User&#39;s email and username (required).</param>
        /// <param name="Addresses">Email addresses and phone numbers for this user.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Password">User&#39;s password (required).</param>
        public CreateUser(string Name = null, string Department = null, string Email = null, List<Contact> Addresses = null, string Title = null, string Password = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CreateUser and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for CreateUser and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for CreateUser and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            this.Department = Department;
            this.Addresses = Addresses;
            this.Title = Title;
        }
        
        /// <summary>
        /// User&#39;s full name
        /// </summary>
        /// <value>User&#39;s full name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
        /// <summary>
        /// User&#39;s email and username
        /// </summary>
        /// <value>User&#39;s email and username</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Email addresses and phone numbers for this user
        /// </summary>
        /// <value>Email addresses and phone numbers for this user</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<Contact> Addresses { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// User&#39;s password
        /// </summary>
        /// <value>User&#39;s password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUser {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(obj as CreateUser);
        }

        /// <summary>
        /// Returns true if CreateUser instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUser other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                return hash;
            }
        }
    }

}
