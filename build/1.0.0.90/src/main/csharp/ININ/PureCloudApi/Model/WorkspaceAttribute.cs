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
    public class WorkspaceAttribute :  IEquatable<WorkspaceAttribute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceAttribute" /> class.
        /// </summary>
        public WorkspaceAttribute()
        {
            this.MultipleValues = false;
            this.InUse = false;
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Restrictions
        /// </summary>
        [DataMember(Name="restrictions", EmitDefaultValue=false)]
        public AttributeRestrictions Restrictions { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MultipleValues
        /// </summary>
        [DataMember(Name="multipleValues", EmitDefaultValue=false)]
        public bool? MultipleValues { get; set; }
  
        
        /// <summary>
        /// Gets or Sets InUse
        /// </summary>
        [DataMember(Name="inUse", EmitDefaultValue=false)]
        public bool? InUse { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MemberAttributes
        /// </summary>
        [DataMember(Name="memberAttributes", EmitDefaultValue=false)]
        public List<string> MemberAttributes { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceAttribute {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Restrictions: ").Append(Restrictions).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  MultipleValues: ").Append(MultipleValues).Append("\n");
            sb.Append("  InUse: ").Append(InUse).Append("\n");
            sb.Append("  MemberAttributes: ").Append(MemberAttributes).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            
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
            return this.Equals(obj as WorkspaceAttribute);
        }

        /// <summary>
        /// Returns true if WorkspaceAttribute instances are equal
        /// </summary>
        /// <param name="obj">Instance of WorkspaceAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceAttribute other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Restrictions == other.Restrictions ||
                    this.Restrictions != null &&
                    this.Restrictions.Equals(other.Restrictions)
                ) && 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.MultipleValues == other.MultipleValues ||
                    this.MultipleValues != null &&
                    this.MultipleValues.Equals(other.MultipleValues)
                ) && 
                (
                    this.InUse == other.InUse ||
                    this.InUse != null &&
                    this.InUse.Equals(other.InUse)
                ) && 
                (
                    this.MemberAttributes == other.MemberAttributes ||
                    this.MemberAttributes != null &&
                    this.MemberAttributes.SequenceEqual(other.MemberAttributes)
                ) && 
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.Restrictions != null)
                    hash = hash * 57 + this.Restrictions.GetHashCode();
                
                if (this.Format != null)
                    hash = hash * 57 + this.Format.GetHashCode();
                
                if (this.MultipleValues != null)
                    hash = hash * 57 + this.MultipleValues.GetHashCode();
                
                if (this.InUse != null)
                    hash = hash * 57 + this.InUse.GetHashCode();
                
                if (this.MemberAttributes != null)
                    hash = hash * 57 + this.MemberAttributes.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
