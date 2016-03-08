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
    public partial class HealthCheckInfo :  IEquatable<HealthCheckInfo>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "OK")]
            Ok,
            
            [EnumMember(Value = "CREATED")]
            Created,
            
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            
            [EnumMember(Value = "NO_CONTENT")]
            NoContent,
            
            [EnumMember(Value = "RESET_CONTENT")]
            ResetContent,
            
            [EnumMember(Value = "PARTIAL_CONTENT")]
            PartialContent,
            
            [EnumMember(Value = "MOVED_PERMANENTLY")]
            MovedPermanently,
            
            [EnumMember(Value = "FOUND")]
            Found,
            
            [EnumMember(Value = "SEE_OTHER")]
            SeeOther,
            
            [EnumMember(Value = "NOT_MODIFIED")]
            NotModified,
            
            [EnumMember(Value = "USE_PROXY")]
            UseProxy,
            
            [EnumMember(Value = "TEMPORARY_REDIRECT")]
            TemporaryRedirect,
            
            [EnumMember(Value = "BAD_REQUEST")]
            BadRequest,
            
            [EnumMember(Value = "UNAUTHORIZED")]
            Unauthorized,
            
            [EnumMember(Value = "PAYMENT_REQUIRED")]
            PaymentRequired,
            
            [EnumMember(Value = "FORBIDDEN")]
            Forbidden,
            
            [EnumMember(Value = "NOT_FOUND")]
            NotFound,
            
            [EnumMember(Value = "METHOD_NOT_ALLOWED")]
            MethodNotAllowed,
            
            [EnumMember(Value = "NOT_ACCEPTABLE")]
            NotAcceptable,
            
            [EnumMember(Value = "PROXY_AUTHENTICATION_REQUIRED")]
            ProxyAuthenticationRequired,
            
            [EnumMember(Value = "REQUEST_TIMEOUT")]
            RequestTimeout,
            
            [EnumMember(Value = "CONFLICT")]
            Conflict,
            
            [EnumMember(Value = "GONE")]
            Gone,
            
            [EnumMember(Value = "LENGTH_REQUIRED")]
            LengthRequired,
            
            [EnumMember(Value = "PRECONDITION_FAILED")]
            PreconditionFailed,
            
            [EnumMember(Value = "REQUEST_ENTITY_TOO_LARGE")]
            RequestEntityTooLarge,
            
            [EnumMember(Value = "REQUEST_URI_TOO_LONG")]
            RequestUriTooLong,
            
            [EnumMember(Value = "UNSUPPORTED_MEDIA_TYPE")]
            UnsupportedMediaType,
            
            [EnumMember(Value = "REQUESTED_RANGE_NOT_SATISFIABLE")]
            RequestedRangeNotSatisfiable,
            
            [EnumMember(Value = "EXPECTATION_FAILED")]
            ExpectationFailed,
            
            [EnumMember(Value = "INTERNAL_SERVER_ERROR")]
            InternalServerError,
            
            [EnumMember(Value = "NOT_IMPLEMENTED")]
            NotImplemented,
            
            [EnumMember(Value = "BAD_GATEWAY")]
            BadGateway,
            
            [EnumMember(Value = "SERVICE_UNAVAILABLE")]
            ServiceUnavailable,
            
            [EnumMember(Value = "GATEWAY_TIMEOUT")]
            GatewayTimeout,
            
            [EnumMember(Value = "HTTP_VERSION_NOT_SUPPORTED")]
            HttpVersionNotSupported
        }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheckInfo" /> class.
        /// Initializes a new instance of the <see cref="HealthCheckInfo" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="BuildTime">BuildTime.</param>
        /// <param name="BuildVersion">BuildVersion.</param>
        /// <param name="BuildJdk">BuildJdk.</param>
        /// <param name="BuiltBy">BuiltBy.</param>
        /// <param name="ImplementationBuild">ImplementationBuild.</param>
        /// <param name="ImplementationVersion">ImplementationVersion.</param>
        /// <param name="Status">Status.</param>
        /// <param name="PingMs">PingMs.</param>
        /// <param name="Date">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>

        public HealthCheckInfo(string Name = null, string BuildTime = null, string BuildVersion = null, string BuildJdk = null, string BuiltBy = null, string ImplementationBuild = null, string ImplementationVersion = null, StatusEnum? Status = null, int? PingMs = null, DateTime? Date = null)
        {
            this.Name = Name;
            this.BuildTime = BuildTime;
            this.BuildVersion = BuildVersion;
            this.BuildJdk = BuildJdk;
            this.BuiltBy = BuiltBy;
            this.ImplementationBuild = ImplementationBuild;
            this.ImplementationVersion = ImplementationVersion;
            this.Status = Status;
            this.PingMs = PingMs;
            this.Date = Date;
            
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
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
    
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
