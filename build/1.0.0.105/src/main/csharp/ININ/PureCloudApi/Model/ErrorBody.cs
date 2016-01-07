using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ErrorBody :  IEquatable<ErrorBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorBody" /> class.
        /// </summary>
        public ErrorBody()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MessageWithParams
        /// </summary>
        [DataMember(Name="messageWithParams", EmitDefaultValue=false)]
        public string MessageWithParams { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MessageParams
        /// </summary>
        [DataMember(Name="messageParams", EmitDefaultValue=false)]
        public Dictionary<string, string> MessageParams { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ContextId
        /// </summary>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<Detail> Details { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorBody {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageWithParams: ").Append(MessageWithParams).Append("\n");
            sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            
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
            return this.Equals(obj as ErrorBody);
        }

        /// <summary>
        /// Returns true if ErrorBody instances are equal
        /// </summary>
        /// <param name="obj">Instance of ErrorBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.MessageWithParams == other.MessageWithParams ||
                    this.MessageWithParams != null &&
                    this.MessageWithParams.Equals(other.MessageWithParams)
                ) && 
                (
                    this.MessageParams == other.MessageParams ||
                    this.MessageParams != null &&
                    this.MessageParams.SequenceEqual(other.MessageParams)
                ) && 
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
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
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.Code != null)
                    hash = hash * 57 + this.Code.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 57 + this.Message.GetHashCode();
                
                if (this.MessageWithParams != null)
                    hash = hash * 57 + this.MessageWithParams.GetHashCode();
                
                if (this.MessageParams != null)
                    hash = hash * 57 + this.MessageParams.GetHashCode();
                
                if (this.ContextId != null)
                    hash = hash * 57 + this.ContextId.GetHashCode();
                
                if (this.Details != null)
                    hash = hash * 57 + this.Details.GetHashCode();
                
                return hash;
            }
        }

    }


}
