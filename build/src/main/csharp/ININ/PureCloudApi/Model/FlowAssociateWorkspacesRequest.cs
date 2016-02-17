using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// Used as the body to the associateWithWorkspaces request.
    /// </summary>
    [DataContract]
    public partial class FlowAssociateWorkspacesRequest :  IEquatable<FlowAssociateWorkspacesRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowAssociateWorkspacesRequest" /> class.
        /// </summary>
        public FlowAssociateWorkspacesRequest()
        {
            
        }

        
        /// <summary>
        /// The list of Workspaces to associate with a flow.  Can be null/empty to remove associations.
        /// </summary>
        /// <value>The list of Workspaces to associate with a flow.  Can be null/empty to remove associations.</value>
        [DataMember(Name="workspaces", EmitDefaultValue=false)]
        public List<string> Workspaces { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowAssociateWorkspacesRequest {\n");
            sb.Append("  Workspaces: ").Append(Workspaces).Append("\n");
            
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
            return this.Equals(obj as FlowAssociateWorkspacesRequest);
        }

        /// <summary>
        /// Returns true if FlowAssociateWorkspacesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowAssociateWorkspacesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowAssociateWorkspacesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Workspaces == other.Workspaces ||
                    this.Workspaces != null &&
                    this.Workspaces.SequenceEqual(other.Workspaces)
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
                
                if (this.Workspaces != null)
                    hash = hash * 59 + this.Workspaces.GetHashCode();
                
                return hash;
            }
        }

    }
}
