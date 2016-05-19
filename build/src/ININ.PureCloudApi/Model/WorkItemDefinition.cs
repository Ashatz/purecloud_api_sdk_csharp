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
    /// WorkItemDefinition
    /// </summary>
    [DataContract]
    public partial class WorkItemDefinition :  IEquatable<WorkItemDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemDefinition" /> class.
        /// </summary>
        /// <param name="Id">The configuration ID for this workItem (required).</param>
        /// <param name="Name">Name.</param>
        /// <param name="CommandCategories">The commands that can be performed on this work item.</param>
        /// <param name="Form">The simple work item form containging the control to present for this work item.</param>
        public WorkItemDefinition(string Id = null, string Name = null, List<WorkItemCommandGroup> CommandCategories = null, Form Form = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for WorkItemDefinition and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Name = Name;
            this.CommandCategories = CommandCategories;
            this.Form = Form;
        }
        
        /// <summary>
        /// The configuration ID for this workItem
        /// </summary>
        /// <value>The configuration ID for this workItem</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The commands that can be performed on this work item
        /// </summary>
        /// <value>The commands that can be performed on this work item</value>
        [DataMember(Name="commandCategories", EmitDefaultValue=false)]
        public List<WorkItemCommandGroup> CommandCategories { get; set; }
        /// <summary>
        /// The simple work item form containging the control to present for this work item
        /// </summary>
        /// <value>The simple work item form containging the control to present for this work item</value>
        [DataMember(Name="form", EmitDefaultValue=false)]
        public Form Form { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemDefinition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CommandCategories: ").Append(CommandCategories).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
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
            return this.Equals(obj as WorkItemDefinition);
        }

        /// <summary>
        /// Returns true if WorkItemDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkItemDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemDefinition other)
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
                    this.CommandCategories == other.CommandCategories ||
                    this.CommandCategories != null &&
                    this.CommandCategories.SequenceEqual(other.CommandCategories)
                ) && 
                (
                    this.Form == other.Form ||
                    this.Form != null &&
                    this.Form.Equals(other.Form)
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
                if (this.CommandCategories != null)
                    hash = hash * 59 + this.CommandCategories.GetHashCode();
                if (this.Form != null)
                    hash = hash * 59 + this.Form.GetHashCode();
                return hash;
            }
        }
    }

}
