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
    public partial class EdgeLine :  IEquatable<EdgeLine>
    { 

        /// <summary>
        /// Gets or Sets LineType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LineTypeEnum {
            
            [EnumMember(Value = "TIE")]
            Tie,
            
            [EnumMember(Value = "NETWORK")]
            Network,
            
            [EnumMember(Value = "TRUNK")]
            Trunk,
            
            [EnumMember(Value = "STATION")]
            Station
        }

        

        /// <summary>
        /// Gets or Sets LineType
        /// </summary>
        [DataMember(Name="lineType", EmitDefaultValue=false)]
        public LineTypeEnum? LineType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeLine" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Schema">Schema.</param>
        /// <param name="Properties">Properties.</param>
        /// <param name="Edge">Edge.</param>
        /// <param name="EdgeGroup">EdgeGroup.</param>
        /// <param name="LineType">LineType.</param>
        /// <param name="Endpoint">Endpoint.</param>
        /// <param name="IpAddress">IpAddress.</param>
        /// <param name="LogicalInterfaceId">LogicalInterfaceId.</param>

        public EdgeLine(string Name = null, UriReference Schema = null, Dictionary<string, Object> Properties = null, Edge Edge = null, EdgeGroup EdgeGroup = null, LineTypeEnum? LineType = null, Endpoint Endpoint = null, string IpAddress = null, string LogicalInterfaceId = null)
        {
            this.Name = Name;
            this.Schema = Schema;
            this.Properties = Properties;
            this.Edge = Edge;
            this.EdgeGroup = EdgeGroup;
            this.LineType = LineType;
            this.Endpoint = Endpoint;
            this.IpAddress = IpAddress;
            this.LogicalInterfaceId = LogicalInterfaceId;
            
        }

    
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public UriReference Schema { get; set; }
    
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, Object> Properties { get; set; }
    
        /// <summary>
        /// Gets or Sets Edge
        /// </summary>
        [DataMember(Name="edge", EmitDefaultValue=false)]
        public Edge Edge { get; set; }
    
        /// <summary>
        /// Gets or Sets EdgeGroup
        /// </summary>
        [DataMember(Name="edgeGroup", EmitDefaultValue=false)]
        public EdgeGroup EdgeGroup { get; set; }
    
        /// <summary>
        /// Gets or Sets Endpoint
        /// </summary>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        public Endpoint Endpoint { get; set; }
    
        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets LogicalInterfaceId
        /// </summary>
        [DataMember(Name="logicalInterfaceId", EmitDefaultValue=false)]
        public string LogicalInterfaceId { get; set; }
    
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeLine {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Edge: ").Append(Edge).Append("\n");
            sb.Append("  EdgeGroup: ").Append(EdgeGroup).Append("\n");
            sb.Append("  LineType: ").Append(LineType).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  LogicalInterfaceId: ").Append(LogicalInterfaceId).Append("\n");
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
            return this.Equals(obj as EdgeLine);
        }

        /// <summary>
        /// Returns true if EdgeLine instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeLine other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) &&
                (
                    this.Edge == other.Edge ||
                    this.Edge != null &&
                    this.Edge.Equals(other.Edge)
                ) &&
                (
                    this.EdgeGroup == other.EdgeGroup ||
                    this.EdgeGroup != null &&
                    this.EdgeGroup.Equals(other.EdgeGroup)
                ) &&
                (
                    this.LineType == other.LineType ||
                    this.LineType != null &&
                    this.LineType.Equals(other.LineType)
                ) &&
                (
                    this.Endpoint == other.Endpoint ||
                    this.Endpoint != null &&
                    this.Endpoint.Equals(other.Endpoint)
                ) &&
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) &&
                (
                    this.LogicalInterfaceId == other.LogicalInterfaceId ||
                    this.LogicalInterfaceId != null &&
                    this.LogicalInterfaceId.Equals(other.LogicalInterfaceId)
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
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                if (this.Edge != null)
                    hash = hash * 59 + this.Edge.GetHashCode();
                if (this.EdgeGroup != null)
                    hash = hash * 59 + this.EdgeGroup.GetHashCode();
                if (this.LineType != null)
                    hash = hash * 59 + this.LineType.GetHashCode();
                if (this.Endpoint != null)
                    hash = hash * 59 + this.Endpoint.GetHashCode();
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                if (this.LogicalInterfaceId != null)
                    hash = hash * 59 + this.LogicalInterfaceId.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
