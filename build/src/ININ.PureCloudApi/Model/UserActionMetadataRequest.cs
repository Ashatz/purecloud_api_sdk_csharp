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
    /// UserActionMetadataRequest
    /// </summary>
    [DataContract]
    public partial class UserActionMetadataRequest :  IEquatable<UserActionMetadataRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserActionMetadataRequest" /> class.
        /// </summary>
        /// <param name="Format">Format.</param>
        /// <param name="Method">Method.</param>
        /// <param name="InputSchemaUri">InputSchemaUri.</param>
        /// <param name="SuccessSchemaUri">SuccessSchemaUri.</param>
        /// <param name="InputSchema">InputSchema.</param>
        /// <param name="SuccessSchema">SuccessSchema.</param>
        public UserActionMetadataRequest(string Format = null, string Method = null, string InputSchemaUri = null, string SuccessSchemaUri = null, Object InputSchema = null, Object SuccessSchema = null)
        {
            this.Format = Format;
            this.Method = Method;
            this.InputSchemaUri = InputSchemaUri;
            this.SuccessSchemaUri = SuccessSchemaUri;
            this.InputSchema = InputSchema;
            this.SuccessSchema = SuccessSchema;
        }
        
        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }
        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }
        /// <summary>
        /// Gets or Sets InputSchemaUri
        /// </summary>
        [DataMember(Name="inputSchemaUri", EmitDefaultValue=false)]
        public string InputSchemaUri { get; set; }
        /// <summary>
        /// Gets or Sets SuccessSchemaUri
        /// </summary>
        [DataMember(Name="successSchemaUri", EmitDefaultValue=false)]
        public string SuccessSchemaUri { get; set; }
        /// <summary>
        /// Gets or Sets InputSchema
        /// </summary>
        [DataMember(Name="inputSchema", EmitDefaultValue=false)]
        public Object InputSchema { get; set; }
        /// <summary>
        /// Gets or Sets SuccessSchema
        /// </summary>
        [DataMember(Name="successSchema", EmitDefaultValue=false)]
        public Object SuccessSchema { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserActionMetadataRequest {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  InputSchemaUri: ").Append(InputSchemaUri).Append("\n");
            sb.Append("  SuccessSchemaUri: ").Append(SuccessSchemaUri).Append("\n");
            sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
            sb.Append("  SuccessSchema: ").Append(SuccessSchema).Append("\n");
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
            return this.Equals(obj as UserActionMetadataRequest);
        }

        /// <summary>
        /// Returns true if UserActionMetadataRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UserActionMetadataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserActionMetadataRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) &&
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) &&
                (
                    this.InputSchemaUri == other.InputSchemaUri ||
                    this.InputSchemaUri != null &&
                    this.InputSchemaUri.Equals(other.InputSchemaUri)
                ) &&
                (
                    this.SuccessSchemaUri == other.SuccessSchemaUri ||
                    this.SuccessSchemaUri != null &&
                    this.SuccessSchemaUri.Equals(other.SuccessSchemaUri)
                ) &&
                (
                    this.InputSchema == other.InputSchema ||
                    this.InputSchema != null &&
                    this.InputSchema.Equals(other.InputSchema)
                ) &&
                (
                    this.SuccessSchema == other.SuccessSchema ||
                    this.SuccessSchema != null &&
                    this.SuccessSchema.Equals(other.SuccessSchema)
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
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                if (this.InputSchemaUri != null)
                    hash = hash * 59 + this.InputSchemaUri.GetHashCode();
                if (this.SuccessSchemaUri != null)
                    hash = hash * 59 + this.SuccessSchemaUri.GetHashCode();
                if (this.InputSchema != null)
                    hash = hash * 59 + this.InputSchema.GetHashCode();
                if (this.SuccessSchema != null)
                    hash = hash * 59 + this.SuccessSchema.GetHashCode();
                return hash;
            }
        }
    }

}
