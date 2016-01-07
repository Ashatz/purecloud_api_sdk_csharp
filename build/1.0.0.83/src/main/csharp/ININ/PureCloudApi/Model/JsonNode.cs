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
    public class JsonNode :  IEquatable<JsonNode>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonNode" /> class.
        /// </summary>
        public JsonNode()
        {
            this.Object = false;
            this.Pojo = false;
            this.Number = false;
            this.IntegralNumber = false;
            this.FloatingPointNumber = false;
            this.Short = false;
            this.Int = false;
            this.Long = false;
            this.Float = false;
            this.Double = false;
            this.BigDecimal = false;
            this.BigInteger = false;
            this.Textual = false;
            this.Boolean = false;
            this.Binary = false;
            this.ValueNode = false;
            this.ContainerNode = false;
            this.MissingNode = false;
            this.Array = false;
            this.Null = false;
            
        }

        
        /// <summary>
        /// Gets or Sets NodeType
        /// </summary>
        [DataMember(Name="nodeType", EmitDefaultValue=false)]
        public string NodeType { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public bool? Object { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Pojo
        /// </summary>
        [DataMember(Name="pojo", EmitDefaultValue=false)]
        public bool? Pojo { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public bool? Number { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IntegralNumber
        /// </summary>
        [DataMember(Name="integralNumber", EmitDefaultValue=false)]
        public bool? IntegralNumber { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FloatingPointNumber
        /// </summary>
        [DataMember(Name="floatingPointNumber", EmitDefaultValue=false)]
        public bool? FloatingPointNumber { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Short
        /// </summary>
        [DataMember(Name="short", EmitDefaultValue=false)]
        public bool? Short { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Int
        /// </summary>
        [DataMember(Name="int", EmitDefaultValue=false)]
        public bool? Int { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Long
        /// </summary>
        [DataMember(Name="long", EmitDefaultValue=false)]
        public bool? Long { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Float
        /// </summary>
        [DataMember(Name="float", EmitDefaultValue=false)]
        public bool? Float { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Double
        /// </summary>
        [DataMember(Name="double", EmitDefaultValue=false)]
        public bool? Double { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BigDecimal
        /// </summary>
        [DataMember(Name="bigDecimal", EmitDefaultValue=false)]
        public bool? BigDecimal { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BigInteger
        /// </summary>
        [DataMember(Name="bigInteger", EmitDefaultValue=false)]
        public bool? BigInteger { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Textual
        /// </summary>
        [DataMember(Name="textual", EmitDefaultValue=false)]
        public bool? Textual { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Boolean
        /// </summary>
        [DataMember(Name="boolean", EmitDefaultValue=false)]
        public bool? Boolean { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Binary
        /// </summary>
        [DataMember(Name="binary", EmitDefaultValue=false)]
        public bool? Binary { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ValueNode
        /// </summary>
        [DataMember(Name="valueNode", EmitDefaultValue=false)]
        public bool? ValueNode { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ContainerNode
        /// </summary>
        [DataMember(Name="containerNode", EmitDefaultValue=false)]
        public bool? ContainerNode { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MissingNode
        /// </summary>
        [DataMember(Name="missingNode", EmitDefaultValue=false)]
        public bool? MissingNode { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Array
        /// </summary>
        [DataMember(Name="array", EmitDefaultValue=false)]
        public bool? Array { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Null
        /// </summary>
        [DataMember(Name="null", EmitDefaultValue=false)]
        public bool? Null { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonNode {\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Pojo: ").Append(Pojo).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  IntegralNumber: ").Append(IntegralNumber).Append("\n");
            sb.Append("  FloatingPointNumber: ").Append(FloatingPointNumber).Append("\n");
            sb.Append("  Short: ").Append(Short).Append("\n");
            sb.Append("  Int: ").Append(Int).Append("\n");
            sb.Append("  Long: ").Append(Long).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  Double: ").Append(Double).Append("\n");
            sb.Append("  BigDecimal: ").Append(BigDecimal).Append("\n");
            sb.Append("  BigInteger: ").Append(BigInteger).Append("\n");
            sb.Append("  Textual: ").Append(Textual).Append("\n");
            sb.Append("  Boolean: ").Append(Boolean).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  ValueNode: ").Append(ValueNode).Append("\n");
            sb.Append("  ContainerNode: ").Append(ContainerNode).Append("\n");
            sb.Append("  MissingNode: ").Append(MissingNode).Append("\n");
            sb.Append("  Array: ").Append(Array).Append("\n");
            sb.Append("  Null: ").Append(Null).Append("\n");
            
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
            return this.Equals(obj as JsonNode);
        }

        /// <summary>
        /// Returns true if JsonNode instances are equal
        /// </summary>
        /// <param name="obj">Instance of JsonNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonNode other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NodeType == other.NodeType ||
                    this.NodeType != null &&
                    this.NodeType.Equals(other.NodeType)
                ) && 
                (
                    this.Object == other.Object ||
                    this.Object != null &&
                    this.Object.Equals(other.Object)
                ) && 
                (
                    this.Pojo == other.Pojo ||
                    this.Pojo != null &&
                    this.Pojo.Equals(other.Pojo)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.IntegralNumber == other.IntegralNumber ||
                    this.IntegralNumber != null &&
                    this.IntegralNumber.Equals(other.IntegralNumber)
                ) && 
                (
                    this.FloatingPointNumber == other.FloatingPointNumber ||
                    this.FloatingPointNumber != null &&
                    this.FloatingPointNumber.Equals(other.FloatingPointNumber)
                ) && 
                (
                    this.Short == other.Short ||
                    this.Short != null &&
                    this.Short.Equals(other.Short)
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
                    this.BigDecimal == other.BigDecimal ||
                    this.BigDecimal != null &&
                    this.BigDecimal.Equals(other.BigDecimal)
                ) && 
                (
                    this.BigInteger == other.BigInteger ||
                    this.BigInteger != null &&
                    this.BigInteger.Equals(other.BigInteger)
                ) && 
                (
                    this.Textual == other.Textual ||
                    this.Textual != null &&
                    this.Textual.Equals(other.Textual)
                ) && 
                (
                    this.Boolean == other.Boolean ||
                    this.Boolean != null &&
                    this.Boolean.Equals(other.Boolean)
                ) && 
                (
                    this.Binary == other.Binary ||
                    this.Binary != null &&
                    this.Binary.Equals(other.Binary)
                ) && 
                (
                    this.ValueNode == other.ValueNode ||
                    this.ValueNode != null &&
                    this.ValueNode.Equals(other.ValueNode)
                ) && 
                (
                    this.ContainerNode == other.ContainerNode ||
                    this.ContainerNode != null &&
                    this.ContainerNode.Equals(other.ContainerNode)
                ) && 
                (
                    this.MissingNode == other.MissingNode ||
                    this.MissingNode != null &&
                    this.MissingNode.Equals(other.MissingNode)
                ) && 
                (
                    this.Array == other.Array ||
                    this.Array != null &&
                    this.Array.Equals(other.Array)
                ) && 
                (
                    this.Null == other.Null ||
                    this.Null != null &&
                    this.Null.Equals(other.Null)
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
                
                if (this.NodeType != null)
                    hash = hash * 57 + this.NodeType.GetHashCode();
                
                if (this.Object != null)
                    hash = hash * 57 + this.Object.GetHashCode();
                
                if (this.Pojo != null)
                    hash = hash * 57 + this.Pojo.GetHashCode();
                
                if (this.Number != null)
                    hash = hash * 57 + this.Number.GetHashCode();
                
                if (this.IntegralNumber != null)
                    hash = hash * 57 + this.IntegralNumber.GetHashCode();
                
                if (this.FloatingPointNumber != null)
                    hash = hash * 57 + this.FloatingPointNumber.GetHashCode();
                
                if (this.Short != null)
                    hash = hash * 57 + this.Short.GetHashCode();
                
                if (this.Int != null)
                    hash = hash * 57 + this.Int.GetHashCode();
                
                if (this.Long != null)
                    hash = hash * 57 + this.Long.GetHashCode();
                
                if (this.Float != null)
                    hash = hash * 57 + this.Float.GetHashCode();
                
                if (this.Double != null)
                    hash = hash * 57 + this.Double.GetHashCode();
                
                if (this.BigDecimal != null)
                    hash = hash * 57 + this.BigDecimal.GetHashCode();
                
                if (this.BigInteger != null)
                    hash = hash * 57 + this.BigInteger.GetHashCode();
                
                if (this.Textual != null)
                    hash = hash * 57 + this.Textual.GetHashCode();
                
                if (this.Boolean != null)
                    hash = hash * 57 + this.Boolean.GetHashCode();
                
                if (this.Binary != null)
                    hash = hash * 57 + this.Binary.GetHashCode();
                
                if (this.ValueNode != null)
                    hash = hash * 57 + this.ValueNode.GetHashCode();
                
                if (this.ContainerNode != null)
                    hash = hash * 57 + this.ContainerNode.GetHashCode();
                
                if (this.MissingNode != null)
                    hash = hash * 57 + this.MissingNode.GetHashCode();
                
                if (this.Array != null)
                    hash = hash * 57 + this.Array.GetHashCode();
                
                if (this.Null != null)
                    hash = hash * 57 + this.Null.GetHashCode();
                
                return hash;
            }
        }

    }


}
