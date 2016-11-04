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
using ININ.PureCloudApi.Client;

namespace ININ.PureCloudApi.Model
{
    /// <summary>
    /// Predicate
    /// </summary>
    [DataContract]
    public partial class Predicate :  IEquatable<Predicate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Predicate" /> class.
        /// </summary>
        /// <param name="QuestionId">QuestionId.</param>
        /// <param name="AnswerId">AnswerId.</param>
        public Predicate(string QuestionId = null, string AnswerId = null)
        {
            this.QuestionId = QuestionId;
            this.AnswerId = AnswerId;
        }
        
        /// <summary>
        /// Gets or Sets QuestionId
        /// </summary>
        [DataMember(Name="questionId", EmitDefaultValue=false)]
        public string QuestionId { get; set; }
        /// <summary>
        /// Gets or Sets AnswerId
        /// </summary>
        [DataMember(Name="answerId", EmitDefaultValue=false)]
        public string AnswerId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Predicate {\n");
            sb.Append("  QuestionId: ").Append(QuestionId).Append("\n");
            sb.Append("  AnswerId: ").Append(AnswerId).Append("\n");
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
            return this.Equals(obj as Predicate);
        }

        /// <summary>
        /// Returns true if Predicate instances are equal
        /// </summary>
        /// <param name="other">Instance of Predicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Predicate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QuestionId == other.QuestionId ||
                    this.QuestionId != null &&
                    this.QuestionId.Equals(other.QuestionId)
                ) &&
                (
                    this.AnswerId == other.AnswerId ||
                    this.AnswerId != null &&
                    this.AnswerId.Equals(other.AnswerId)
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
                if (this.QuestionId != null)
                    hash = hash * 59 + this.QuestionId.GetHashCode();
                if (this.AnswerId != null)
                    hash = hash * 59 + this.AnswerId.GetHashCode();
                return hash;
            }
        }
    }

}
