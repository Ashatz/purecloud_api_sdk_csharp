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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/SessionRequest.cs
    public partial class SessionRequest :  IEquatable<SessionRequest>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequest" />class.
        /// </summary>
        /// <param name="MinutesToLive">MinutesToLive.</param>

        public SessionRequest(long? MinutesToLive = null)
        {
            this.MinutesToLive = MinutesToLive;
=======
    public partial class UnreadStatus :  IEquatable<UnreadStatus>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UnreadStatus" />class.
        /// </summary>
        /// <param name="Unread">Sets if the alert is read or unread. (default to false).</param>

        public UnreadStatus(bool? Unread = null)
        {
            // use default value if no "Unread" provided
            if (Unread == null)
            {
                this.Unread = false;
            }
            else
            {
                this.Unread = Unread;
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/UnreadStatus.cs
            
        }

    
        /// <summary>
        /// Sets if the alert is read or unread.
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/SessionRequest.cs
        [DataMember(Name="minutesToLive", EmitDefaultValue=false)]
        public long? MinutesToLive { get; set; }
=======
        /// <value>Sets if the alert is read or unread.</value>
        [DataMember(Name="unread", EmitDefaultValue=false)]
        public bool? Unread { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/UnreadStatus.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/SessionRequest.cs
            sb.Append("class SessionRequest {\n");
            sb.Append("  MinutesToLive: ").Append(MinutesToLive).Append("\n");
=======
            sb.Append("class UnreadStatus {\n");
            sb.Append("  Unread: ").Append(Unread).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/UnreadStatus.cs
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
            return this.Equals(obj as UnreadStatus);
        }

        /// <summary>
        /// Returns true if UnreadStatus instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/SessionRequest.cs
        /// <param name="other">Instance of SessionRequest to be compared</param>
=======
        /// <param name="other">Instance of UnreadStatus to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/UnreadStatus.cs
        /// <returns>Boolean</returns>
        public bool Equals(UnreadStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Unread == other.Unread ||
                    this.Unread != null &&
                    this.Unread.Equals(other.Unread)
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/SessionRequest.cs
                if (this.MinutesToLive != null)
                    hash = hash * 59 + this.MinutesToLive.GetHashCode();
=======
                if (this.Unread != null)
                    hash = hash * 59 + this.Unread.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/UnreadStatus.cs
                return hash;
            }
        }

    }
}
