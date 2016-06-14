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
    /// Waypoint
    /// </summary>
    [DataContract]
    public partial class Waypoint :  IEquatable<Waypoint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Waypoint" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="TargetScene">TargetScene.</param>
        /// <param name="RotationY">RotationY.</param>
        /// <param name="RotationX">RotationX.</param>
        /// <param name="SceneRotationY">SceneRotationY.</param>
        /// <param name="Distance">Distance.</param>
        public Waypoint(string Name = null, Scene TargetScene = null, double? RotationY = null, double? RotationX = null, double? SceneRotationY = null, double? Distance = null)
        {
            this.Name = Name;
            this.TargetScene = TargetScene;
            this.RotationY = RotationY;
            this.RotationX = RotationX;
            this.SceneRotationY = SceneRotationY;
            this.Distance = Distance;
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
        /// Gets or Sets TargetScene
        /// </summary>
        [DataMember(Name="targetScene", EmitDefaultValue=false)]
        public Scene TargetScene { get; set; }
        /// <summary>
        /// Gets or Sets RotationY
        /// </summary>
        [DataMember(Name="rotationY", EmitDefaultValue=false)]
        public double? RotationY { get; set; }
        /// <summary>
        /// Gets or Sets RotationX
        /// </summary>
        [DataMember(Name="rotationX", EmitDefaultValue=false)]
        public double? RotationX { get; set; }
        /// <summary>
        /// Gets or Sets SceneRotationY
        /// </summary>
        [DataMember(Name="sceneRotationY", EmitDefaultValue=false)]
        public double? SceneRotationY { get; set; }
        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public double? Distance { get; set; }
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
            sb.Append("class Waypoint {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TargetScene: ").Append(TargetScene).Append("\n");
            sb.Append("  RotationY: ").Append(RotationY).Append("\n");
            sb.Append("  RotationX: ").Append(RotationX).Append("\n");
            sb.Append("  SceneRotationY: ").Append(SceneRotationY).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
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
            return this.Equals(obj as Waypoint);
        }

        /// <summary>
        /// Returns true if Waypoint instances are equal
        /// </summary>
        /// <param name="other">Instance of Waypoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Waypoint other)
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
                    this.TargetScene == other.TargetScene ||
                    this.TargetScene != null &&
                    this.TargetScene.Equals(other.TargetScene)
                ) &&
                (
                    this.RotationY == other.RotationY ||
                    this.RotationY != null &&
                    this.RotationY.Equals(other.RotationY)
                ) &&
                (
                    this.RotationX == other.RotationX ||
                    this.RotationX != null &&
                    this.RotationX.Equals(other.RotationX)
                ) &&
                (
                    this.SceneRotationY == other.SceneRotationY ||
                    this.SceneRotationY != null &&
                    this.SceneRotationY.Equals(other.SceneRotationY)
                ) &&
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
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
                if (this.TargetScene != null)
                    hash = hash * 59 + this.TargetScene.GetHashCode();
                if (this.RotationY != null)
                    hash = hash * 59 + this.RotationY.GetHashCode();
                if (this.RotationX != null)
                    hash = hash * 59 + this.RotationX.GetHashCode();
                if (this.SceneRotationY != null)
                    hash = hash * 59 + this.SceneRotationY.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
