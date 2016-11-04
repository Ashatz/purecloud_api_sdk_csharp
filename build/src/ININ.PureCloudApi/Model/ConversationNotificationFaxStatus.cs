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
using ININ.PureCloudApi.Client;

namespace ININ.PureCloudApi.Model
{
    /// <summary>
    /// ConversationNotificationFaxStatus
    /// </summary>
    [DataContract]
    public partial class ConversationNotificationFaxStatus :  IEquatable<ConversationNotificationFaxStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNotificationFaxStatus" /> class.
        /// </summary>
        /// <param name="Direction">Direction.</param>
        /// <param name="ExpectedPages">ExpectedPages.</param>
        /// <param name="ActivePage">ActivePage.</param>
        /// <param name="LinesTransmitted">LinesTransmitted.</param>
        /// <param name="BytesTransmitted">BytesTransmitted.</param>
        /// <param name="BaudRate">BaudRate.</param>
        /// <param name="PageErrors">PageErrors.</param>
        /// <param name="LineErrors">LineErrors.</param>
        public ConversationNotificationFaxStatus(string Direction = null, int? ExpectedPages = null, int? ActivePage = null, int? LinesTransmitted = null, int? BytesTransmitted = null, int? BaudRate = null, int? PageErrors = null, int? LineErrors = null)
        {
            this.Direction = Direction;
            this.ExpectedPages = ExpectedPages;
            this.ActivePage = ActivePage;
            this.LinesTransmitted = LinesTransmitted;
            this.BytesTransmitted = BytesTransmitted;
            this.BaudRate = BaudRate;
            this.PageErrors = PageErrors;
            this.LineErrors = LineErrors;
        }
        
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public string Direction { get; set; }
        /// <summary>
        /// Gets or Sets ExpectedPages
        /// </summary>
        [DataMember(Name="expectedPages", EmitDefaultValue=false)]
        public int? ExpectedPages { get; set; }
        /// <summary>
        /// Gets or Sets ActivePage
        /// </summary>
        [DataMember(Name="activePage", EmitDefaultValue=false)]
        public int? ActivePage { get; set; }
        /// <summary>
        /// Gets or Sets LinesTransmitted
        /// </summary>
        [DataMember(Name="linesTransmitted", EmitDefaultValue=false)]
        public int? LinesTransmitted { get; set; }
        /// <summary>
        /// Gets or Sets BytesTransmitted
        /// </summary>
        [DataMember(Name="bytesTransmitted", EmitDefaultValue=false)]
        public int? BytesTransmitted { get; set; }
        /// <summary>
        /// Gets or Sets BaudRate
        /// </summary>
        [DataMember(Name="baudRate", EmitDefaultValue=false)]
        public int? BaudRate { get; set; }
        /// <summary>
        /// Gets or Sets PageErrors
        /// </summary>
        [DataMember(Name="pageErrors", EmitDefaultValue=false)]
        public int? PageErrors { get; set; }
        /// <summary>
        /// Gets or Sets LineErrors
        /// </summary>
        [DataMember(Name="lineErrors", EmitDefaultValue=false)]
        public int? LineErrors { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationNotificationFaxStatus {\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  ExpectedPages: ").Append(ExpectedPages).Append("\n");
            sb.Append("  ActivePage: ").Append(ActivePage).Append("\n");
            sb.Append("  LinesTransmitted: ").Append(LinesTransmitted).Append("\n");
            sb.Append("  BytesTransmitted: ").Append(BytesTransmitted).Append("\n");
            sb.Append("  BaudRate: ").Append(BaudRate).Append("\n");
            sb.Append("  PageErrors: ").Append(PageErrors).Append("\n");
            sb.Append("  LineErrors: ").Append(LineErrors).Append("\n");
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
            return this.Equals(obj as ConversationNotificationFaxStatus);
        }

        /// <summary>
        /// Returns true if ConversationNotificationFaxStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationNotificationFaxStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationNotificationFaxStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.ExpectedPages == other.ExpectedPages ||
                    this.ExpectedPages != null &&
                    this.ExpectedPages.Equals(other.ExpectedPages)
                ) &&
                (
                    this.ActivePage == other.ActivePage ||
                    this.ActivePage != null &&
                    this.ActivePage.Equals(other.ActivePage)
                ) &&
                (
                    this.LinesTransmitted == other.LinesTransmitted ||
                    this.LinesTransmitted != null &&
                    this.LinesTransmitted.Equals(other.LinesTransmitted)
                ) &&
                (
                    this.BytesTransmitted == other.BytesTransmitted ||
                    this.BytesTransmitted != null &&
                    this.BytesTransmitted.Equals(other.BytesTransmitted)
                ) &&
                (
                    this.BaudRate == other.BaudRate ||
                    this.BaudRate != null &&
                    this.BaudRate.Equals(other.BaudRate)
                ) &&
                (
                    this.PageErrors == other.PageErrors ||
                    this.PageErrors != null &&
                    this.PageErrors.Equals(other.PageErrors)
                ) &&
                (
                    this.LineErrors == other.LineErrors ||
                    this.LineErrors != null &&
                    this.LineErrors.Equals(other.LineErrors)
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
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                if (this.ExpectedPages != null)
                    hash = hash * 59 + this.ExpectedPages.GetHashCode();
                if (this.ActivePage != null)
                    hash = hash * 59 + this.ActivePage.GetHashCode();
                if (this.LinesTransmitted != null)
                    hash = hash * 59 + this.LinesTransmitted.GetHashCode();
                if (this.BytesTransmitted != null)
                    hash = hash * 59 + this.BytesTransmitted.GetHashCode();
                if (this.BaudRate != null)
                    hash = hash * 59 + this.BaudRate.GetHashCode();
                if (this.PageErrors != null)
                    hash = hash * 59 + this.PageErrors.GetHashCode();
                if (this.LineErrors != null)
                    hash = hash * 59 + this.LineErrors.GetHashCode();
                return hash;
            }
        }
    }

}
