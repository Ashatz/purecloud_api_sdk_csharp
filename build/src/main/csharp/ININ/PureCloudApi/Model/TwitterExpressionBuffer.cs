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
    public partial class TwitterExpressionBuffer :  IEquatable<TwitterExpressionBuffer>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterExpressionBuffer" /> class.
        /// Initializes a new instance of the <see cref="TwitterExpressionBuffer" />class.
        /// </summary>
        /// <param name="BufferContent">The list of TwitterExpressions currently in the buffer..</param>

        public TwitterExpressionBuffer(List<TwitterExpression> BufferContent = null)
        {
            this.BufferContent = BufferContent;
            
        }
        
    
        /// <summary>
        /// The list of TwitterExpressions currently in the buffer.
        /// </summary>
        /// <value>The list of TwitterExpressions currently in the buffer.</value>
        [DataMember(Name="bufferContent", EmitDefaultValue=false)]
        public List<TwitterExpression> BufferContent { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TwitterExpressionBuffer {\n");
            sb.Append("  BufferContent: ").Append(BufferContent).Append("\n");
            
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
            return this.Equals(obj as TwitterExpressionBuffer);
        }

        /// <summary>
        /// Returns true if TwitterExpressionBuffer instances are equal
        /// </summary>
        /// <param name="other">Instance of TwitterExpressionBuffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwitterExpressionBuffer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BufferContent == other.BufferContent ||
                    this.BufferContent != null &&
                    this.BufferContent.SequenceEqual(other.BufferContent)
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
                
                if (this.BufferContent != null)
                    hash = hash * 59 + this.BufferContent.GetHashCode();
                
                return hash;
            }
        }

    }
}
