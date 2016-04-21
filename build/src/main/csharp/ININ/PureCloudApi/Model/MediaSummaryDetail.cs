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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerCall.cs
    public partial class DialerCall :  IEquatable<DialerCall>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCall" />class.
        /// </summary>
        /// <param name="CallId">CallId.</param>
        /// <param name="ConversationId">ConversationId.</param>

        public DialerCall(string CallId = null, string ConversationId = null)
        {
            this.CallId = CallId;
            this.ConversationId = ConversationId;
=======
    public partial class MediaSummaryDetail :  IEquatable<MediaSummaryDetail>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSummaryDetail" />class.
        /// </summary>
        /// <param name="Active">Active.</param>
        /// <param name="Acw">Acw.</param>

        public MediaSummaryDetail(int? Active = null, int? Acw = null)
        {
            this.Active = Active;
            this.Acw = Acw;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MediaSummaryDetail.cs
            
        }

    
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerCall.cs
        [DataMember(Name="callId", EmitDefaultValue=false)]
        public string CallId { get; set; }
=======
        [DataMember(Name="active", EmitDefaultValue=false)]
        public int? Active { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MediaSummaryDetail.cs
    
        /// <summary>
        /// Gets or Sets Acw
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerCall.cs
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
=======
        [DataMember(Name="acw", EmitDefaultValue=false)]
        public int? Acw { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MediaSummaryDetail.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerCall.cs
            sb.Append("class DialerCall {\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
=======
            sb.Append("class MediaSummaryDetail {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Acw: ").Append(Acw).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MediaSummaryDetail.cs
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
            return this.Equals(obj as MediaSummaryDetail);
        }

        /// <summary>
        /// Returns true if MediaSummaryDetail instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerCall.cs
        /// <param name="other">Instance of DialerCall to be compared</param>
=======
        /// <param name="other">Instance of MediaSummaryDetail to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MediaSummaryDetail.cs
        /// <returns>Boolean</returns>
        public bool Equals(MediaSummaryDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerCall.cs
                    this.CallId == other.CallId ||
                    this.CallId != null &&
                    this.CallId.Equals(other.CallId)
=======
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MediaSummaryDetail.cs
                ) &&
                (
                    this.Acw == other.Acw ||
                    this.Acw != null &&
                    this.Acw.Equals(other.Acw)
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/DialerCall.cs
                if (this.CallId != null)
                    hash = hash * 59 + this.CallId.GetHashCode();
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
=======
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.Acw != null)
                    hash = hash * 59 + this.Acw.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/MediaSummaryDetail.cs
                return hash;
            }
        }

    }
}
