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
    public partial class HealthCheckInfo :  IEquatable<HealthCheckInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheckInfo" /> class.
        /// </summary>
        public HealthCheckInfo()
        {
            
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
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BuildTime
        /// </summary>
        [DataMember(Name="Build-Time", EmitDefaultValue=false)]
        public string BuildTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BuildVersion
        /// </summary>
        [DataMember(Name="Build-Version", EmitDefaultValue=false)]
        public string BuildVersion { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BuildJdk
        /// </summary>
        [DataMember(Name="Build-Jdk", EmitDefaultValue=false)]
        public string BuildJdk { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BuiltBy
        /// </summary>
        [DataMember(Name="Built-By", EmitDefaultValue=false)]
        public string BuiltBy { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ImplementationBuild
        /// </summary>
        [DataMember(Name="Implementation-Build", EmitDefaultValue=false)]
        public string ImplementationBuild { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ImplementationVersion
        /// </summary>
        [DataMember(Name="Implementation-Version", EmitDefaultValue=false)]
        public string ImplementationVersion { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PingMs
        /// </summary>
        [DataMember(Name="Ping-Ms", EmitDefaultValue=false)]
        public int? PingMs { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HealthCheckInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  BuildTime: ").Append(BuildTime).Append("\n");
            sb.Append("  BuildVersion: ").Append(BuildVersion).Append("\n");
            sb.Append("  BuildJdk: ").Append(BuildJdk).Append("\n");
            sb.Append("  BuiltBy: ").Append(BuiltBy).Append("\n");
            sb.Append("  ImplementationBuild: ").Append(ImplementationBuild).Append("\n");
            sb.Append("  ImplementationVersion: ").Append(ImplementationVersion).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PingMs: ").Append(PingMs).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            
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
            return this.Equals(obj as HealthCheckInfo);
        }

        /// <summary>
        /// Returns true if HealthCheckInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of HealthCheckInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthCheckInfo other)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) && 
                (
                    this.BuildTime == other.BuildTime ||
                    this.BuildTime != null &&
                    this.BuildTime.Equals(other.BuildTime)
                ) && 
                (
                    this.BuildVersion == other.BuildVersion ||
                    this.BuildVersion != null &&
                    this.BuildVersion.Equals(other.BuildVersion)
                ) && 
                (
                    this.BuildJdk == other.BuildJdk ||
                    this.BuildJdk != null &&
                    this.BuildJdk.Equals(other.BuildJdk)
                ) && 
                (
                    this.BuiltBy == other.BuiltBy ||
                    this.BuiltBy != null &&
                    this.BuiltBy.Equals(other.BuiltBy)
                ) && 
                (
                    this.ImplementationBuild == other.ImplementationBuild ||
                    this.ImplementationBuild != null &&
                    this.ImplementationBuild.Equals(other.ImplementationBuild)
                ) && 
                (
                    this.ImplementationVersion == other.ImplementationVersion ||
                    this.ImplementationVersion != null &&
                    this.ImplementationVersion.Equals(other.ImplementationVersion)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.PingMs == other.PingMs ||
                    this.PingMs != null &&
                    this.PingMs.Equals(other.PingMs)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
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
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.BuildTime != null)
                    hash = hash * 59 + this.BuildTime.GetHashCode();
                
                if (this.BuildVersion != null)
                    hash = hash * 59 + this.BuildVersion.GetHashCode();
                
                if (this.BuildJdk != null)
                    hash = hash * 59 + this.BuildJdk.GetHashCode();
                
                if (this.BuiltBy != null)
                    hash = hash * 59 + this.BuiltBy.GetHashCode();
                
                if (this.ImplementationBuild != null)
                    hash = hash * 59 + this.ImplementationBuild.GetHashCode();
                
                if (this.ImplementationVersion != null)
                    hash = hash * 59 + this.ImplementationVersion.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.PingMs != null)
                    hash = hash * 59 + this.PingMs.GetHashCode();
                
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                
                return hash;
            }
        }

    }
}
