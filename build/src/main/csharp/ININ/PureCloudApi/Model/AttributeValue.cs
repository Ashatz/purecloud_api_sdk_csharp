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
    /// 
    /// </summary>
    [DataContract]
    public partial class AttributeValue :  IEquatable<AttributeValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeValue" /> class.
        /// </summary>
        public AttributeValue()
        {
            this.Null = false;
            this.Bool = false;
            
        }

        
        /// <summary>
        /// Gets or Sets S
        /// </summary>
        [DataMember(Name="s", EmitDefaultValue=false)]
        public string S { get; set; }
  
        
        /// <summary>
        /// Gets or Sets N
        /// </summary>
        [DataMember(Name="n", EmitDefaultValue=false)]
        public string N { get; set; }
  
        
        /// <summary>
        /// Gets or Sets B
        /// </summary>
        [DataMember(Name="b", EmitDefaultValue=false)]
        public ByteBuffer B { get; set; }
  
        
        /// <summary>
        /// Gets or Sets M
        /// </summary>
        [DataMember(Name="m", EmitDefaultValue=false)]
        public Dictionary<string, AttributeValue> M { get; set; }
  
        
        /// <summary>
        /// Gets or Sets L
        /// </summary>
        [DataMember(Name="l", EmitDefaultValue=false)]
        public List<AttributeValue> L { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Ss
        /// </summary>
        [DataMember(Name="ss", EmitDefaultValue=false)]
        public List<string> Ss { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Ns
        /// </summary>
        [DataMember(Name="ns", EmitDefaultValue=false)]
        public List<string> Ns { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Bs
        /// </summary>
        [DataMember(Name="bs", EmitDefaultValue=false)]
        public List<ByteBuffer> Bs { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Null
        /// </summary>
        [DataMember(Name="null", EmitDefaultValue=false)]
        public bool? Null { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Bool
        /// </summary>
        [DataMember(Name="bool", EmitDefaultValue=false)]
        public bool? Bool { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttributeValue {\n");
            sb.Append("  S: ").Append(S).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  B: ").Append(B).Append("\n");
            sb.Append("  M: ").Append(M).Append("\n");
            sb.Append("  L: ").Append(L).Append("\n");
            sb.Append("  Ss: ").Append(Ss).Append("\n");
            sb.Append("  Ns: ").Append(Ns).Append("\n");
            sb.Append("  Bs: ").Append(Bs).Append("\n");
            sb.Append("  Null: ").Append(Null).Append("\n");
            sb.Append("  Bool: ").Append(Bool).Append("\n");
            
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
            return this.Equals(obj as AttributeValue);
        }

        /// <summary>
        /// Returns true if AttributeValue instances are equal
        /// </summary>
        /// <param name="other">Instance of AttributeValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.S == other.S ||
                    this.S != null &&
                    this.S.Equals(other.S)
                ) && 
                (
                    this.N == other.N ||
                    this.N != null &&
                    this.N.Equals(other.N)
                ) && 
                (
                    this.B == other.B ||
                    this.B != null &&
                    this.B.Equals(other.B)
                ) && 
                (
                    this.M == other.M ||
                    this.M != null &&
                    this.M.SequenceEqual(other.M)
                ) && 
                (
                    this.L == other.L ||
                    this.L != null &&
                    this.L.SequenceEqual(other.L)
                ) && 
                (
                    this.Ss == other.Ss ||
                    this.Ss != null &&
                    this.Ss.SequenceEqual(other.Ss)
                ) && 
                (
                    this.Ns == other.Ns ||
                    this.Ns != null &&
                    this.Ns.SequenceEqual(other.Ns)
                ) && 
                (
                    this.Bs == other.Bs ||
                    this.Bs != null &&
                    this.Bs.SequenceEqual(other.Bs)
                ) && 
                (
                    this.Null == other.Null ||
                    this.Null != null &&
                    this.Null.Equals(other.Null)
                ) && 
                (
                    this.Bool == other.Bool ||
                    this.Bool != null &&
                    this.Bool.Equals(other.Bool)
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
                
                if (this.S != null)
                    hash = hash * 59 + this.S.GetHashCode();
                
                if (this.N != null)
                    hash = hash * 59 + this.N.GetHashCode();
                
                if (this.B != null)
                    hash = hash * 59 + this.B.GetHashCode();
                
                if (this.M != null)
                    hash = hash * 59 + this.M.GetHashCode();
                
                if (this.L != null)
                    hash = hash * 59 + this.L.GetHashCode();
                
                if (this.Ss != null)
                    hash = hash * 59 + this.Ss.GetHashCode();
                
                if (this.Ns != null)
                    hash = hash * 59 + this.Ns.GetHashCode();
                
                if (this.Bs != null)
                    hash = hash * 59 + this.Bs.GetHashCode();
                
                if (this.Null != null)
                    hash = hash * 59 + this.Null.GetHashCode();
                
                if (this.Bool != null)
                    hash = hash * 59 + this.Bool.GetHashCode();
                
                return hash;
            }
        }

    }
}
