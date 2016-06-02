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
    /// Used as the body to the submitWorkItem request.
    /// </summary>
    [DataContract]
    public partial class WorkItemSubmitRequest :  IEquatable<WorkItemSubmitRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemSubmitRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemSubmitRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemSubmitRequest" /> class.
        /// </summary>
        /// <param name="CommandId">The command associated with the submit request. Often it is the button pressed on the user interface. (required).</param>
        /// <param name="DataItems">The data items that should be a part of the submit request..</param>
        public WorkItemSubmitRequest(string CommandId = null, List<DataItem> DataItems = null)
        {
            // to ensure "CommandId" is required (not null)
            if (CommandId == null)
            {
                throw new InvalidDataException("CommandId is a required property for WorkItemSubmitRequest and cannot be null");
            }
            else
            {
                this.CommandId = CommandId;
            }
            this.DataItems = DataItems;
        }
        
        /// <summary>
        /// The command associated with the submit request. Often it is the button pressed on the user interface.
        /// </summary>
        /// <value>The command associated with the submit request. Often it is the button pressed on the user interface.</value>
        [DataMember(Name="commandId", EmitDefaultValue=false)]
        public string CommandId { get; set; }
        /// <summary>
        /// The data items that should be a part of the submit request.
        /// </summary>
        /// <value>The data items that should be a part of the submit request.</value>
        [DataMember(Name="dataItems", EmitDefaultValue=false)]
        public List<DataItem> DataItems { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemSubmitRequest {\n");
            sb.Append("  CommandId: ").Append(CommandId).Append("\n");
            sb.Append("  DataItems: ").Append(DataItems).Append("\n");
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
            return this.Equals(obj as WorkItemSubmitRequest);
        }

        /// <summary>
        /// Returns true if WorkItemSubmitRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkItemSubmitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemSubmitRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CommandId == other.CommandId ||
                    this.CommandId != null &&
                    this.CommandId.Equals(other.CommandId)
                ) &&
                (
                    this.DataItems == other.DataItems ||
                    this.DataItems != null &&
                    this.DataItems.SequenceEqual(other.DataItems)
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
                if (this.CommandId != null)
                    hash = hash * 59 + this.CommandId.GetHashCode();
                if (this.DataItems != null)
                    hash = hash * 59 + this.DataItems.GetHashCode();
                return hash;
            }
        }
    }

}
