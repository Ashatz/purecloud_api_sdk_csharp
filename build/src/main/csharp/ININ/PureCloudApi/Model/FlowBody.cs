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
    public partial class FlowBody :  IEquatable<FlowBody>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowBody" /> class.
        /// Initializes a new instance of the <see cref="FlowBody" />class.
        /// </summary>
        /// <param name="Format">The &#39;format&#39; indicates the particular format of the &#39;body&#39; contents.  Reference the Automate documentation for format information..</param>
        /// <param name="Body">The flow definition body according to the syntax supported by the &#39;format&#39;.  Use the /processautomation/flows/schemas endpoint to get detailed syntax information for each format..</param>

        public FlowBody(string Format = null, Dictionary<string, Object> Body = null)
        {
            this.Format = Format;
            this.Body = Body;
            
        }
        
    
        /// <summary>
        /// The 'format' indicates the particular format of the 'body' contents.  Reference the Automate documentation for format information.
        /// </summary>
        /// <value>The 'format' indicates the particular format of the 'body' contents.  Reference the Automate documentation for format information.</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }
    
        /// <summary>
        /// The flow definition body according to the syntax supported by the 'format'.  Use the /processautomation/flows/schemas endpoint to get detailed syntax information for each format.
        /// </summary>
        /// <value>The flow definition body according to the syntax supported by the 'format'.  Use the /processautomation/flows/schemas endpoint to get detailed syntax information for each format.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public Dictionary<string, Object> Body { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowBody {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            
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
            return this.Equals(obj as FlowBody);
        }

        /// <summary>
        /// Returns true if FlowBody instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.SequenceEqual(other.Body)
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
                
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                
                return hash;
            }
        }

    }
}
