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
    public partial class FacetResultItem :  IEquatable<FacetResultItem>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FacetResultItem" /> class.
        /// Initializes a new instance of the <see cref="FacetResultItem" />class.
        /// </summary>
        /// <param name="Name">For TERM facets this will contain the value of the term that was found userid, docid, etc..</param>
        /// <param name="Count">The number of items that matched the facetRequest..</param>
        /// <param name="Document">Document.</param>
        /// <param name="User">User.</param>
        /// <param name="Queue">Queue.</param>
        /// <param name="FlowConfigId">FlowConfigId.</param>
        /// <param name="Workspace">Workspace.</param>

        public FacetResultItem(string Name = null, long? Count = null, Document Document = null, User User = null, Queue Queue = null, FlowConfigId FlowConfigId = null, Workspace Workspace = null)
        {
            this.Name = Name;
            this.Count = Count;
            this.Document = Document;
            this.User = User;
            this.Queue = Queue;
            this.FlowConfigId = FlowConfigId;
            this.Workspace = Workspace;
            
        }
        
    
        /// <summary>
        /// For TERM facets this will contain the value of the term that was found userid, docid, etc.
        /// </summary>
        /// <value>For TERM facets this will contain the value of the term that was found userid, docid, etc.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// The number of items that matched the facetRequest.
        /// </summary>
        /// <value>The number of items that matched the facetRequest.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }
    
        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public Document Document { get; set; }
    
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
    
        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public Queue Queue { get; set; }
    
        /// <summary>
        /// Gets or Sets FlowConfigId
        /// </summary>
        [DataMember(Name="flowConfigId", EmitDefaultValue=false)]
        public FlowConfigId FlowConfigId { get; set; }
    
        /// <summary>
        /// Gets or Sets Workspace
        /// </summary>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public Workspace Workspace { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacetResultItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  FlowConfigId: ").Append(FlowConfigId).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            
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
            return this.Equals(obj as FacetResultItem);
        }

        /// <summary>
        /// Returns true if FacetResultItem instances are equal
        /// </summary>
        /// <param name="other">Instance of FacetResultItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacetResultItem other)
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
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Document == other.Document ||
                    this.Document != null &&
                    this.Document.Equals(other.Document)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) && 
                (
                    this.FlowConfigId == other.FlowConfigId ||
                    this.FlowConfigId != null &&
                    this.FlowConfigId.Equals(other.FlowConfigId)
                ) && 
                (
                    this.Workspace == other.Workspace ||
                    this.Workspace != null &&
                    this.Workspace.Equals(other.Workspace)
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
                
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                
                if (this.Document != null)
                    hash = hash * 59 + this.Document.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                
                if (this.FlowConfigId != null)
                    hash = hash * 59 + this.FlowConfigId.GetHashCode();
                
                if (this.Workspace != null)
                    hash = hash * 59 + this.Workspace.GetHashCode();
                
                return hash;
            }
        }

    }
}
