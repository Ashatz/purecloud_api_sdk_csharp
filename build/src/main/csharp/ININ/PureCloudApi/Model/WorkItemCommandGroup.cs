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
    public partial class WorkItemCommandGroup :  IEquatable<WorkItemCommandGroup>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemCommandGroup" />class.
        /// </summary>
        /// <param name="Category">Category.</param>
        /// <param name="DefaultCommandId">DefaultCommandId.</param>
        /// <param name="Commands">Commands.</param>

        public WorkItemCommandGroup(string Category = null, string DefaultCommandId = null, List<WorkItemCommand> Commands = null)
        {
            this.Category = Category;
            this.DefaultCommandId = DefaultCommandId;
            this.Commands = Commands;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
    
        /// <summary>
        /// Gets or Sets DefaultCommandId
        /// </summary>
        [DataMember(Name="defaultCommandId", EmitDefaultValue=false)]
        public string DefaultCommandId { get; set; }
    
        /// <summary>
        /// Gets or Sets Commands
        /// </summary>
        [DataMember(Name="commands", EmitDefaultValue=false)]
        public List<WorkItemCommand> Commands { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemCommandGroup {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DefaultCommandId: ").Append(DefaultCommandId).Append("\n");
            sb.Append("  Commands: ").Append(Commands).Append("\n");
            
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
            return this.Equals(obj as WorkItemCommandGroup);
        }

        /// <summary>
        /// Returns true if WorkItemCommandGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkItemCommandGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemCommandGroup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.DefaultCommandId == other.DefaultCommandId ||
                    this.DefaultCommandId != null &&
                    this.DefaultCommandId.Equals(other.DefaultCommandId)
                ) &&
                (
                    this.Commands == other.Commands ||
                    this.Commands != null &&
                    this.Commands.SequenceEqual(other.Commands)
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
                
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                
                if (this.DefaultCommandId != null)
                    hash = hash * 59 + this.DefaultCommandId.GetHashCode();
                
                if (this.Commands != null)
                    hash = hash * 59 + this.Commands.GetHashCode();
                
                return hash;
            }
        }

    }
}
