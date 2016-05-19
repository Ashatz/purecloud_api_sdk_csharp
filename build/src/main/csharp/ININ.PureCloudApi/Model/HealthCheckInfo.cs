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
    /// HealthCheckInfo
    /// </summary>
    [DataContract]
    public partial class HealthCheckInfo :  IEquatable<HealthCheckInfo>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Ok for "OK"
            /// </summary>
            [EnumMember(Value = "OK")]
            Ok,
            
            /// <summary>
            /// Enum Created for "CREATED"
            /// </summary>
            [EnumMember(Value = "CREATED")]
            Created,
            
            /// <summary>
            /// Enum Accepted for "ACCEPTED"
            /// </summary>
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            
            /// <summary>
            /// Enum NoContent for "NO_CONTENT"
            /// </summary>
            [EnumMember(Value = "NO_CONTENT")]
            NoContent,
            
            /// <summary>
            /// Enum ResetContent for "RESET_CONTENT"
            /// </summary>
            [EnumMember(Value = "RESET_CONTENT")]
            ResetContent,
            
            /// <summary>
            /// Enum PartialContent for "PARTIAL_CONTENT"
            /// </summary>
            [EnumMember(Value = "PARTIAL_CONTENT")]
            PartialContent,
            
            /// <summary>
            /// Enum MovedPermanently for "MOVED_PERMANENTLY"
            /// </summary>
            [EnumMember(Value = "MOVED_PERMANENTLY")]
            MovedPermanently,
            
            /// <summary>
            /// Enum Found for "FOUND"
            /// </summary>
            [EnumMember(Value = "FOUND")]
            Found,
            
            /// <summary>
            /// Enum SeeOther for "SEE_OTHER"
            /// </summary>
            [EnumMember(Value = "SEE_OTHER")]
            SeeOther,
            
            /// <summary>
            /// Enum NotModified for "NOT_MODIFIED"
            /// </summary>
            [EnumMember(Value = "NOT_MODIFIED")]
            NotModified,
            
            /// <summary>
            /// Enum UseProxy for "USE_PROXY"
            /// </summary>
            [EnumMember(Value = "USE_PROXY")]
            UseProxy,
            
            /// <summary>
            /// Enum TemporaryRedirect for "TEMPORARY_REDIRECT"
            /// </summary>
            [EnumMember(Value = "TEMPORARY_REDIRECT")]
            TemporaryRedirect,
            
            /// <summary>
            /// Enum BadRequest for "BAD_REQUEST"
            /// </summary>
            [EnumMember(Value = "BAD_REQUEST")]
            BadRequest,
            
            /// <summary>
            /// Enum Unauthorized for "UNAUTHORIZED"
            /// </summary>
            [EnumMember(Value = "UNAUTHORIZED")]
            Unauthorized,
            
            /// <summary>
            /// Enum PaymentRequired for "PAYMENT_REQUIRED"
            /// </summary>
            [EnumMember(Value = "PAYMENT_REQUIRED")]
            PaymentRequired,
            
            /// <summary>
            /// Enum Forbidden for "FORBIDDEN"
            /// </summary>
            [EnumMember(Value = "FORBIDDEN")]
            Forbidden,
            
            /// <summary>
            /// Enum NotFound for "NOT_FOUND"
            /// </summary>
            [EnumMember(Value = "NOT_FOUND")]
            NotFound,
            
            /// <summary>
            /// Enum MethodNotAllowed for "METHOD_NOT_ALLOWED"
            /// </summary>
            [EnumMember(Value = "METHOD_NOT_ALLOWED")]
            MethodNotAllowed,
            
            /// <summary>
            /// Enum NotAcceptable for "NOT_ACCEPTABLE"
            /// </summary>
            [EnumMember(Value = "NOT_ACCEPTABLE")]
            NotAcceptable,
            
            /// <summary>
            /// Enum ProxyAuthenticationRequired for "PROXY_AUTHENTICATION_REQUIRED"
            /// </summary>
            [EnumMember(Value = "PROXY_AUTHENTICATION_REQUIRED")]
            ProxyAuthenticationRequired,
            
            /// <summary>
            /// Enum RequestTimeout for "REQUEST_TIMEOUT"
            /// </summary>
            [EnumMember(Value = "REQUEST_TIMEOUT")]
            RequestTimeout,
            
            /// <summary>
            /// Enum Conflict for "CONFLICT"
            /// </summary>
            [EnumMember(Value = "CONFLICT")]
            Conflict,
            
            /// <summary>
            /// Enum Gone for "GONE"
            /// </summary>
            [EnumMember(Value = "GONE")]
            Gone,
            
            /// <summary>
            /// Enum LengthRequired for "LENGTH_REQUIRED"
            /// </summary>
            [EnumMember(Value = "LENGTH_REQUIRED")]
            LengthRequired,
            
            /// <summary>
            /// Enum PreconditionFailed for "PRECONDITION_FAILED"
            /// </summary>
            [EnumMember(Value = "PRECONDITION_FAILED")]
            PreconditionFailed,
            
            /// <summary>
            /// Enum RequestEntityTooLarge for "REQUEST_ENTITY_TOO_LARGE"
            /// </summary>
            [EnumMember(Value = "REQUEST_ENTITY_TOO_LARGE")]
            RequestEntityTooLarge,
            
            /// <summary>
            /// Enum RequestUriTooLong for "REQUEST_URI_TOO_LONG"
            /// </summary>
            [EnumMember(Value = "REQUEST_URI_TOO_LONG")]
            RequestUriTooLong,
            
            /// <summary>
            /// Enum UnsupportedMediaType for "UNSUPPORTED_MEDIA_TYPE"
            /// </summary>
            [EnumMember(Value = "UNSUPPORTED_MEDIA_TYPE")]
            UnsupportedMediaType,
            
            /// <summary>
            /// Enum RequestedRangeNotSatisfiable for "REQUESTED_RANGE_NOT_SATISFIABLE"
            /// </summary>
            [EnumMember(Value = "REQUESTED_RANGE_NOT_SATISFIABLE")]
            RequestedRangeNotSatisfiable,
            
            /// <summary>
            /// Enum ExpectationFailed for "EXPECTATION_FAILED"
            /// </summary>
            [EnumMember(Value = "EXPECTATION_FAILED")]
            ExpectationFailed,
            
            /// <summary>
            /// Enum InternalServerError for "INTERNAL_SERVER_ERROR"
            /// </summary>
            [EnumMember(Value = "INTERNAL_SERVER_ERROR")]
            InternalServerError,
            
            /// <summary>
            /// Enum NotImplemented for "NOT_IMPLEMENTED"
            /// </summary>
            [EnumMember(Value = "NOT_IMPLEMENTED")]
            NotImplemented,
            
            /// <summary>
            /// Enum BadGateway for "BAD_GATEWAY"
            /// </summary>
            [EnumMember(Value = "BAD_GATEWAY")]
            BadGateway,
            
            /// <summary>
            /// Enum ServiceUnavailable for "SERVICE_UNAVAILABLE"
            /// </summary>
            [EnumMember(Value = "SERVICE_UNAVAILABLE")]
            ServiceUnavailable,
            
            /// <summary>
            /// Enum GatewayTimeout for "GATEWAY_TIMEOUT"
            /// </summary>
            [EnumMember(Value = "GATEWAY_TIMEOUT")]
            GatewayTimeout,
            
            /// <summary>
            /// Enum HttpVersionNotSupported for "HTTP_VERSION_NOT_SUPPORTED"
            /// </summary>
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
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="BuildTime">BuildTime.</param>
        /// <param name="BuildVersion">BuildVersion.</param>
        /// <param name="ImplementationVersion">ImplementationVersion.</param>
        /// <param name="Status">Status.</param>
        /// <param name="PingMs">PingMs.</param>
        /// <param name="Date">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public HealthCheckInfo(, string Name = null, string BuildTime = null, string BuildVersion = null, string ImplementationVersion = null, StatusEnum? Status = null, int? PingMs = null, DateTime? Date = null)
        {
            this.Name = Name;
            this.BuildTime = BuildTime;
            this.BuildVersion = BuildVersion;
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
