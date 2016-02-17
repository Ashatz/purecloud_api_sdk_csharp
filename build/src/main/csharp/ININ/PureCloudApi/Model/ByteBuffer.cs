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
    public partial class ByteBuffer :  IEquatable<ByteBuffer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ByteBuffer" /> class.
        /// </summary>
        public ByteBuffer()
        {
            this.Direct = false;
            this.ReadOnly = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Short
        /// </summary>
        [DataMember(Name="short", EmitDefaultValue=false)]
        public int? Short { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Char
        /// </summary>
        [DataMember(Name="char", EmitDefaultValue=false)]
        public string Char { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Int
        /// </summary>
        [DataMember(Name="int", EmitDefaultValue=false)]
        public int? Int { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Long
        /// </summary>
        [DataMember(Name="long", EmitDefaultValue=false)]
        public long? Long { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Float
        /// </summary>
        [DataMember(Name="float", EmitDefaultValue=false)]
        public float? Float { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Double
        /// </summary>
        [DataMember(Name="double", EmitDefaultValue=false)]
        public double? Double { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Direct
        /// </summary>
        [DataMember(Name="direct", EmitDefaultValue=false)]
        public bool? Direct { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? ReadOnly { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ByteBuffer {\n");
            sb.Append("  Short: ").Append(Short).Append("\n");
            sb.Append("  Char: ").Append(Char).Append("\n");
            sb.Append("  Int: ").Append(Int).Append("\n");
            sb.Append("  Long: ").Append(Long).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  Double: ").Append(Double).Append("\n");
            sb.Append("  Direct: ").Append(Direct).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            
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
            return this.Equals(obj as ByteBuffer);
        }

        /// <summary>
        /// Returns true if ByteBuffer instances are equal
        /// </summary>
        /// <param name="other">Instance of ByteBuffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ByteBuffer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Short == other.Short ||
                    this.Short != null &&
                    this.Short.Equals(other.Short)
                ) && 
                (
                    this.Char == other.Char ||
                    this.Char != null &&
                    this.Char.Equals(other.Char)
                ) && 
                (
                    this.Int == other.Int ||
                    this.Int != null &&
                    this.Int.Equals(other.Int)
                ) && 
                (
                    this.Long == other.Long ||
                    this.Long != null &&
                    this.Long.Equals(other.Long)
                ) && 
                (
                    this.Float == other.Float ||
                    this.Float != null &&
                    this.Float.Equals(other.Float)
                ) && 
                (
                    this.Double == other.Double ||
                    this.Double != null &&
                    this.Double.Equals(other.Double)
                ) && 
                (
                    this.Direct == other.Direct ||
                    this.Direct != null &&
                    this.Direct.Equals(other.Direct)
                ) && 
                (
                    this.ReadOnly == other.ReadOnly ||
                    this.ReadOnly != null &&
                    this.ReadOnly.Equals(other.ReadOnly)
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
                
                if (this.Short != null)
                    hash = hash * 59 + this.Short.GetHashCode();
                
                if (this.Char != null)
                    hash = hash * 59 + this.Char.GetHashCode();
                
                if (this.Int != null)
                    hash = hash * 59 + this.Int.GetHashCode();
                
                if (this.Long != null)
                    hash = hash * 59 + this.Long.GetHashCode();
                
                if (this.Float != null)
                    hash = hash * 59 + this.Float.GetHashCode();
                
                if (this.Double != null)
                    hash = hash * 59 + this.Double.GetHashCode();
                
                if (this.Direct != null)
                    hash = hash * 59 + this.Direct.GetHashCode();
                
                if (this.ReadOnly != null)
                    hash = hash * 59 + this.ReadOnly.GetHashCode();
                
                return hash;
            }
        }

    }
}
