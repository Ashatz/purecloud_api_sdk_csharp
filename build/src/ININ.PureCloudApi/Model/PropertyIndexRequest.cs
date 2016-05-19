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
    /// PropertyIndexRequest
    /// </summary>
    [DataContract]
    public partial class PropertyIndexRequest :  IEquatable<PropertyIndexRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIndexRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertyIndexRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIndexRequest" /> class.
        /// </summary>
        /// <param name="SessionId">Attach properties to a segment in the indicated session. Also requires a timestamp..</param>
        /// <param name="Timestamp">Attach properties to a segment covering a specific point in time. Also requries a sessionId..</param>
        /// <param name="Properties">The list of properties to index (required).</param>
        public PropertyIndexRequest(string SessionId = null, long? Timestamp = null, List<AnalyticsProperty> Properties = null)
        {
            // to ensure "Properties" is required (not null)
            if (Properties == null)
            {
                throw new InvalidDataException("Properties is a required property for PropertyIndexRequest and cannot be null");
            }
            else
            {
                this.Properties = Properties;
            }
            this.SessionId = SessionId;
            this.Timestamp = Timestamp;
        }
        
        /// <summary>
        /// Attach properties to a segment in the indicated session. Also requires a timestamp.
        /// </summary>
        /// <value>Attach properties to a segment in the indicated session. Also requires a timestamp.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }
        /// <summary>
        /// Attach properties to a segment covering a specific point in time. Also requries a sessionId.
        /// </summary>
        /// <value>Attach properties to a segment covering a specific point in time. Also requries a sessionId.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }
        /// <summary>
        /// The list of properties to index
        /// </summary>
        /// <value>The list of properties to index</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<AnalyticsProperty> Properties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyIndexRequest {\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as PropertyIndexRequest);
        }

        /// <summary>
        /// Returns true if PropertyIndexRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PropertyIndexRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyIndexRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
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
                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                return hash;
            }
        }
    }

}
