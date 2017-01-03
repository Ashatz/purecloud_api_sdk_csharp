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
    /// VoicemailGroupPolicy
    /// </summary>
    [DataContract]
    public partial class VoicemailGroupPolicy :  IEquatable<VoicemailGroupPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailGroupPolicy" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Group">The group associated with the policy.</param>
        /// <param name="Enabled">Whether voicemail is enabled for the group.</param>
        /// <param name="SendEmailNotifications">Whether email notifications are sent to group members when a new voicemail is received.</param>
        /// <param name="RotateCallsSecs">How many seconds to ring before rotating to the next member in the group.</param>
        /// <param name="StopRingingAfterRotations">How many rotations to go through.</param>
        public VoicemailGroupPolicy(string Name = null, Group Group = null, bool? Enabled = null, bool? SendEmailNotifications = null, int? RotateCallsSecs = null, int? StopRingingAfterRotations = null)
        {
            this.Name = Name;
            this.Group = Group;
            this.Enabled = Enabled;
            this.SendEmailNotifications = SendEmailNotifications;
            this.RotateCallsSecs = RotateCallsSecs;
            this.StopRingingAfterRotations = StopRingingAfterRotations;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The group associated with the policy
        /// </summary>
        /// <value>The group associated with the policy</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public Group Group { get; set; }
        /// <summary>
        /// Whether voicemail is enabled for the group
        /// </summary>
        /// <value>Whether voicemail is enabled for the group</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Whether email notifications are sent to group members when a new voicemail is received
        /// </summary>
        /// <value>Whether email notifications are sent to group members when a new voicemail is received</value>
        [DataMember(Name="sendEmailNotifications", EmitDefaultValue=false)]
        public bool? SendEmailNotifications { get; set; }
        /// <summary>
        /// How many seconds to ring before rotating to the next member in the group
        /// </summary>
        /// <value>How many seconds to ring before rotating to the next member in the group</value>
        [DataMember(Name="rotateCallsSecs", EmitDefaultValue=false)]
        public int? RotateCallsSecs { get; set; }
        /// <summary>
        /// How many rotations to go through
        /// </summary>
        /// <value>How many rotations to go through</value>
        [DataMember(Name="stopRingingAfterRotations", EmitDefaultValue=false)]
        public int? StopRingingAfterRotations { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicemailGroupPolicy {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SendEmailNotifications: ").Append(SendEmailNotifications).Append("\n");
            sb.Append("  RotateCallsSecs: ").Append(RotateCallsSecs).Append("\n");
            sb.Append("  StopRingingAfterRotations: ").Append(StopRingingAfterRotations).Append("\n");
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
            return this.Equals(obj as VoicemailGroupPolicy);
        }

        /// <summary>
        /// Returns true if VoicemailGroupPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailGroupPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailGroupPolicy other)
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
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.SendEmailNotifications == other.SendEmailNotifications ||
                    this.SendEmailNotifications != null &&
                    this.SendEmailNotifications.Equals(other.SendEmailNotifications)
                ) &&
                (
                    this.RotateCallsSecs == other.RotateCallsSecs ||
                    this.RotateCallsSecs != null &&
                    this.RotateCallsSecs.Equals(other.RotateCallsSecs)
                ) &&
                (
                    this.StopRingingAfterRotations == other.StopRingingAfterRotations ||
                    this.StopRingingAfterRotations != null &&
                    this.StopRingingAfterRotations.Equals(other.StopRingingAfterRotations)
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
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.SendEmailNotifications != null)
                    hash = hash * 59 + this.SendEmailNotifications.GetHashCode();
                if (this.RotateCallsSecs != null)
                    hash = hash * 59 + this.RotateCallsSecs.GetHashCode();
                if (this.StopRingingAfterRotations != null)
                    hash = hash * 59 + this.StopRingingAfterRotations.GetHashCode();
                return hash;
            }
        }
    }

}
