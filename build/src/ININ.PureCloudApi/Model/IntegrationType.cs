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
    /// Descriptor for a type of Integration.
    /// </summary>
    [DataContract]
    public partial class IntegrationType :  IEquatable<IntegrationType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntegrationType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationType" /> class.
        /// </summary>
        /// <param name="Id">The ID of the integration type. (required).</param>
        /// <param name="Name">Name.</param>
        /// <param name="Images">Collection of logos..</param>
        public IntegrationType(string Id = null, string Name = null, List<UserImage> Images = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for IntegrationType and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Name = Name;
            this.Images = Images;
        }
        
        /// <summary>
        /// The ID of the integration type.
        /// </summary>
        /// <value>The ID of the integration type.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Localized description of the integration type.
        /// </summary>
        /// <value>Localized description of the integration type.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }
        /// <summary>
        /// PureCloud provider of the integration type.
        /// </summary>
        /// <value>PureCloud provider of the integration type.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; private set; }
        /// <summary>
        /// Collection of logos.
        /// </summary>
        /// <value>Collection of logos.</value>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public List<UserImage> Images { get; set; }
        /// <summary>
        /// URI of the schema describing the key-value properties needed to configure an integration of this type.
        /// </summary>
        /// <value>URI of the schema describing the key-value properties needed to configure an integration of this type.</value>
        [DataMember(Name="configPropertiesSchemaUri", EmitDefaultValue=false)]
        public string ConfigPropertiesSchemaUri { get; private set; }
        /// <summary>
        /// URI of the schema describing the advanced JSON document needed to configure an integration of this type.
        /// </summary>
        /// <value>URI of the schema describing the advanced JSON document needed to configure an integration of this type.</value>
        [DataMember(Name="configAdvancedSchemaUri", EmitDefaultValue=false)]
        public string ConfigAdvancedSchemaUri { get; private set; }
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
            sb.Append("class IntegrationType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  ConfigPropertiesSchemaUri: ").Append(ConfigPropertiesSchemaUri).Append("\n");
            sb.Append("  ConfigAdvancedSchemaUri: ").Append(ConfigAdvancedSchemaUri).Append("\n");
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
            return this.Equals(obj as IntegrationType);
        }

        /// <summary>
        /// Returns true if IntegrationType instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationType other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.Images == other.Images ||
                    this.Images != null &&
                    this.Images.SequenceEqual(other.Images)
                ) &&
                (
                    this.ConfigPropertiesSchemaUri == other.ConfigPropertiesSchemaUri ||
                    this.ConfigPropertiesSchemaUri != null &&
                    this.ConfigPropertiesSchemaUri.Equals(other.ConfigPropertiesSchemaUri)
                ) &&
                (
                    this.ConfigAdvancedSchemaUri == other.ConfigAdvancedSchemaUri ||
                    this.ConfigAdvancedSchemaUri != null &&
                    this.ConfigAdvancedSchemaUri.Equals(other.ConfigAdvancedSchemaUri)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();
                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();
                if (this.ConfigPropertiesSchemaUri != null)
                    hash = hash * 59 + this.ConfigPropertiesSchemaUri.GetHashCode();
                if (this.ConfigAdvancedSchemaUri != null)
                    hash = hash * 59 + this.ConfigAdvancedSchemaUri.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
