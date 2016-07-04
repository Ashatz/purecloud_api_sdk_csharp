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
    /// Operation
    /// </summary>
    [DataContract]
    public partial class Operation :  IEquatable<Operation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Operation" /> class.
        /// </summary>
        /// <param name="User">User.</param>
        /// <param name="Action">Action.</param>
        /// <param name="Status">Status.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        public Operation(User User = null, string Action = null, string Status = null, string ErrorMessage = null)
        {
            this.User = User;
            this.Action = Action;
            this.Status = Status;
            this.ErrorMessage = ErrorMessage;
        }
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Operation {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(obj as Operation);
        }

        /// <summary>
        /// Returns true if Operation instances are equal
        /// </summary>
        /// <param name="other">Instance of Operation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Operation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                return hash;
            }
        }
    }

}
