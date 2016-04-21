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
    public partial class WorkItemActions :  IEquatable<WorkItemActions>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemActions" />class.
        /// </summary>
<<<<<<< HEAD

        public WorkItemActions()
=======
        /// <param name="CanSubmit">CanSubmit (default to false).</param>

        public WorkItemActions(bool? CanSubmit = null)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        {
            // use default value if no "CanSubmit" provided
            if (CanSubmit == null)
            {
                this.CanSubmit = false;
            }
            else
            {
                this.CanSubmit = CanSubmit;
            }
            
        }

    
<<<<<<< HEAD
=======
        /// <summary>
        /// Gets or Sets CanSubmit
        /// </summary>
        [DataMember(Name="canSubmit", EmitDefaultValue=false)]
        public bool? CanSubmit { get; set; }
    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemActions {\n");
<<<<<<< HEAD
=======
            sb.Append("  CanSubmit: ").Append(CanSubmit).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            return this.Equals(obj as WorkItemActions);
        }

        /// <summary>
        /// Returns true if WorkItemActions instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkItemActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemActions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

<<<<<<< HEAD
            return true && false;
=======
            return true &&
                (
                    this.CanSubmit == other.CanSubmit ||
                    this.CanSubmit != null &&
                    this.CanSubmit.Equals(other.CanSubmit)
                );
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
                if (this.CanSubmit != null)
                    hash = hash * 59 + this.CanSubmit.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
