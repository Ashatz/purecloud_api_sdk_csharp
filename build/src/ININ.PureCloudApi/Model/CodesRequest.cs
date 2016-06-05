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
    /// CodesRequest
    /// </summary>
    [DataContract]
    public partial class CodesRequest :  IEquatable<CodesRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodesRequest" /> class.
        /// </summary>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="AddCommunicationCode">AddCommunicationCode.</param>
        public CodesRequest(string OrganizationId = null, string AddCommunicationCode = null)
        {
            this.OrganizationId = OrganizationId;
            this.AddCommunicationCode = AddCommunicationCode;
        }
        
        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }
        /// <summary>
        /// Gets or Sets AddCommunicationCode
        /// </summary>
        [DataMember(Name="addCommunicationCode", EmitDefaultValue=false)]
        public string AddCommunicationCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodesRequest {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  AddCommunicationCode: ").Append(AddCommunicationCode).Append("\n");
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
            return this.Equals(obj as CodesRequest);
        }

        /// <summary>
        /// Returns true if CodesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CodesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) &&
                (
                    this.AddCommunicationCode == other.AddCommunicationCode ||
                    this.AddCommunicationCode != null &&
                    this.AddCommunicationCode.Equals(other.AddCommunicationCode)
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
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.AddCommunicationCode != null)
                    hash = hash * 59 + this.AddCommunicationCode.GetHashCode();
                return hash;
            }
        }
    }

}
