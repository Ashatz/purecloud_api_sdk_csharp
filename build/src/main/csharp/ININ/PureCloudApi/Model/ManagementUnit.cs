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
    public partial class ManagementUnit :  IEquatable<ManagementUnit>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementUnit" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Id">Id.</param>
        /// <param name="StartDayOfWeek">StartDayOfWeek.</param>
        /// <param name="Timezone">Timezone.</param>
        /// <param name="Version">Version.</param>

        public ManagementUnit(string Name = null, string Id = null, string StartDayOfWeek = null, string Timezone = null, int? Version = null)
        {
            this.Name = Name;
            this.Id = Id;
            this.StartDayOfWeek = StartDayOfWeek;
            this.Timezone = Timezone;
            this.Version = Version;
            
        }

    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets StartDayOfWeek
        /// </summary>
        [DataMember(Name="startDayOfWeek", EmitDefaultValue=false)]
        public string StartDayOfWeek { get; set; }
    
        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }
    
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagementUnit {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as ManagementUnit);
        }

        /// <summary>
        /// Returns true if ManagementUnit instances are equal
        /// </summary>
        /// <param name="other">Instance of ManagementUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagementUnit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.StartDayOfWeek == other.StartDayOfWeek ||
                    this.StartDayOfWeek != null &&
                    this.StartDayOfWeek.Equals(other.StartDayOfWeek)
                ) &&
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.StartDayOfWeek != null)
                    hash = hash * 59 + this.StartDayOfWeek.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }
}
