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
    /// Scene
    /// </summary>
    [DataContract]
    public partial class Scene :  IEquatable<Scene>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Primary for "PRIMARY"
            /// </summary>
            [EnumMember(Value = "PRIMARY")]
            Primary,
            
            /// <summary>
            /// Enum Secondary for "SECONDARY"
            /// </summary>
            [EnumMember(Value = "SECONDARY")]
            Secondary
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Scene" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="SceneGroup">SceneGroup.</param>
        /// <param name="Assets">Assets.</param>
        /// <param name="Thumbnail">Thumbnail.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Waypoints">Waypoints.</param>
        /// <param name="DefaultOrientationY">DefaultOrientationY.</param>
        /// <param name="Type">Type.</param>
        public Scene(string Name = null, SceneGroup SceneGroup = null, List<Asset> Assets = null, Thumbnail Thumbnail = null, string Description = null, List<Waypoint> Waypoints = null, double? DefaultOrientationY = null, TypeEnum? Type = null)
        {
            this.Name = Name;
            this.SceneGroup = SceneGroup;
            this.Assets = Assets;
            this.Thumbnail = Thumbnail;
            this.Description = Description;
            this.Waypoints = Waypoints;
            this.DefaultOrientationY = DefaultOrientationY;
            this.Type = Type;
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
        /// Gets or Sets SceneGroup
        /// </summary>
        [DataMember(Name="sceneGroup", EmitDefaultValue=false)]
        public SceneGroup SceneGroup { get; set; }
        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name="assets", EmitDefaultValue=false)]
        public List<Asset> Assets { get; set; }
        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public Thumbnail Thumbnail { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Waypoints
        /// </summary>
        [DataMember(Name="waypoints", EmitDefaultValue=false)]
        public List<Waypoint> Waypoints { get; set; }
        /// <summary>
        /// Gets or Sets DefaultOrientationY
        /// </summary>
        [DataMember(Name="defaultOrientationY", EmitDefaultValue=false)]
        public double? DefaultOrientationY { get; set; }
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
            sb.Append("class Scene {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SceneGroup: ").Append(SceneGroup).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Waypoints: ").Append(Waypoints).Append("\n");
            sb.Append("  DefaultOrientationY: ").Append(DefaultOrientationY).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as Scene);
        }

        /// <summary>
        /// Returns true if Scene instances are equal
        /// </summary>
        /// <param name="other">Instance of Scene to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Scene other)
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
                    this.SceneGroup == other.SceneGroup ||
                    this.SceneGroup != null &&
                    this.SceneGroup.Equals(other.SceneGroup)
                ) &&
                (
                    this.Assets == other.Assets ||
                    this.Assets != null &&
                    this.Assets.SequenceEqual(other.Assets)
                ) &&
                (
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.Equals(other.Thumbnail)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Waypoints == other.Waypoints ||
                    this.Waypoints != null &&
                    this.Waypoints.SequenceEqual(other.Waypoints)
                ) &&
                (
                    this.DefaultOrientationY == other.DefaultOrientationY ||
                    this.DefaultOrientationY != null &&
                    this.DefaultOrientationY.Equals(other.DefaultOrientationY)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.SceneGroup != null)
                    hash = hash * 59 + this.SceneGroup.GetHashCode();
                if (this.Assets != null)
                    hash = hash * 59 + this.Assets.GetHashCode();
                if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Waypoints != null)
                    hash = hash * 59 + this.Waypoints.GetHashCode();
                if (this.DefaultOrientationY != null)
                    hash = hash * 59 + this.DefaultOrientationY.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
