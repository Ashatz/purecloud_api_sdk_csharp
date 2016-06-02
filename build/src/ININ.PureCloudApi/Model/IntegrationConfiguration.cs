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
    /// Configuration for an Integration
    /// </summary>
    [DataContract]
    public partial class IntegrationConfiguration :  IEquatable<IntegrationConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationConfiguration" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Properties">Key-value configuration settings described by the schema in the propertiesSchemaUri field..</param>
        /// <param name="Advanced">Advanced configuration described by the schema in the advancedSchemaUri field..</param>
        public IntegrationConfiguration(string Name = null, Object Properties = null, Object Advanced = null)
        {
            this.Name = Name;
            this.Properties = Properties;
            this.Advanced = Advanced;
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
        /// Version number required for updates.
        /// </summary>
        /// <value>Version number required for updates.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }
        /// <summary>
        /// URI for the JSON Schema describing the configuration properties in the properties field.
        /// </summary>
        /// <value>URI for the JSON Schema describing the configuration properties in the properties field.</value>
        [DataMember(Name="propertiesSchemaUri", EmitDefaultValue=false)]
        public string PropertiesSchemaUri { get; private set; }
        /// <summary>
        /// URI for the JSON Schema describing the advanced configuration
        /// </summary>
        /// <value>URI for the JSON Schema describing the advanced configuration</value>
        [DataMember(Name="advancedSchemaUri", EmitDefaultValue=false)]
        public string AdvancedSchemaUri { get; private set; }
        /// <summary>
        /// Key-value configuration settings described by the schema in the propertiesSchemaUri field.
        /// </summary>
        /// <value>Key-value configuration settings described by the schema in the propertiesSchemaUri field.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Object Properties { get; set; }
        /// <summary>
        /// Advanced configuration described by the schema in the advancedSchemaUri field.
        /// </summary>
        /// <value>Advanced configuration described by the schema in the advancedSchemaUri field.</value>
        [DataMember(Name="advanced", EmitDefaultValue=false)]
        public Object Advanced { get; set; }
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
            sb.Append("class IntegrationConfiguration {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  PropertiesSchemaUri: ").Append(PropertiesSchemaUri).Append("\n");
            sb.Append("  AdvancedSchemaUri: ").Append(AdvancedSchemaUri).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Advanced: ").Append(Advanced).Append("\n");
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
            return this.Equals(obj as IntegrationConfiguration);
        }

        /// <summary>
        /// Returns true if IntegrationConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrationConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationConfiguration other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.PropertiesSchemaUri == other.PropertiesSchemaUri ||
                    this.PropertiesSchemaUri != null &&
                    this.PropertiesSchemaUri.Equals(other.PropertiesSchemaUri)
                ) &&
                (
                    this.AdvancedSchemaUri == other.AdvancedSchemaUri ||
                    this.AdvancedSchemaUri != null &&
                    this.AdvancedSchemaUri.Equals(other.AdvancedSchemaUri)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
                ) &&
                (
                    this.Advanced == other.Advanced ||
                    this.Advanced != null &&
                    this.Advanced.Equals(other.Advanced)
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
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.PropertiesSchemaUri != null)
                    hash = hash * 59 + this.PropertiesSchemaUri.GetHashCode();
                if (this.AdvancedSchemaUri != null)
                    hash = hash * 59 + this.AdvancedSchemaUri.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                if (this.Advanced != null)
                    hash = hash * 59 + this.Advanced.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
