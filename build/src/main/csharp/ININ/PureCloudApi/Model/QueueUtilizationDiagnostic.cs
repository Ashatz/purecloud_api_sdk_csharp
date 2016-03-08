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
    public partial class QueueUtilizationDiagnostic :  IEquatable<QueueUtilizationDiagnostic>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueUtilizationDiagnostic" /> class.
        /// Initializes a new instance of the <see cref="QueueUtilizationDiagnostic" />class.
        /// </summary>
        /// <param name="Queue">Queue.</param>
        /// <param name="UsersInQueue">UsersInQueue.</param>
        /// <param name="ActiveUsersInQueue">ActiveUsersInQueue.</param>
        /// <param name="UsersOnQueue">UsersOnQueue.</param>
        /// <param name="UsersNotUtilized">UsersNotUtilized.</param>
        /// <param name="UsersOnQueueWithStation">UsersOnQueueWithStation.</param>
        /// <param name="UsersOnACampaignCall">UsersOnACampaignCall.</param>
        /// <param name="UsersOnANonCampaignCall">UsersOnANonCampaignCall.</param>

        public QueueUtilizationDiagnostic(UriReference Queue = null, int? UsersInQueue = null, int? ActiveUsersInQueue = null, int? UsersOnQueue = null, int? UsersNotUtilized = null, int? UsersOnQueueWithStation = null, int? UsersOnACampaignCall = null, int? UsersOnANonCampaignCall = null)
        {
            this.Queue = Queue;
            this.UsersInQueue = UsersInQueue;
            this.ActiveUsersInQueue = ActiveUsersInQueue;
            this.UsersOnQueue = UsersOnQueue;
            this.UsersNotUtilized = UsersNotUtilized;
            this.UsersOnQueueWithStation = UsersOnQueueWithStation;
            this.UsersOnACampaignCall = UsersOnACampaignCall;
            this.UsersOnANonCampaignCall = UsersOnANonCampaignCall;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public UriReference Queue { get; set; }
    
        /// <summary>
        /// Gets or Sets UsersInQueue
        /// </summary>
        [DataMember(Name="usersInQueue", EmitDefaultValue=false)]
        public int? UsersInQueue { get; set; }
    
        /// <summary>
        /// Gets or Sets ActiveUsersInQueue
        /// </summary>
        [DataMember(Name="activeUsersInQueue", EmitDefaultValue=false)]
        public int? ActiveUsersInQueue { get; set; }
    
        /// <summary>
        /// Gets or Sets UsersOnQueue
        /// </summary>
        [DataMember(Name="usersOnQueue", EmitDefaultValue=false)]
        public int? UsersOnQueue { get; set; }
    
        /// <summary>
        /// Gets or Sets UsersNotUtilized
        /// </summary>
        [DataMember(Name="usersNotUtilized", EmitDefaultValue=false)]
        public int? UsersNotUtilized { get; set; }
    
        /// <summary>
        /// Gets or Sets UsersOnQueueWithStation
        /// </summary>
        [DataMember(Name="usersOnQueueWithStation", EmitDefaultValue=false)]
        public int? UsersOnQueueWithStation { get; set; }
    
        /// <summary>
        /// Gets or Sets UsersOnACampaignCall
        /// </summary>
        [DataMember(Name="usersOnACampaignCall", EmitDefaultValue=false)]
        public int? UsersOnACampaignCall { get; set; }
    
        /// <summary>
        /// Gets or Sets UsersOnANonCampaignCall
        /// </summary>
        [DataMember(Name="usersOnANonCampaignCall", EmitDefaultValue=false)]
        public int? UsersOnANonCampaignCall { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueUtilizationDiagnostic {\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  UsersInQueue: ").Append(UsersInQueue).Append("\n");
            sb.Append("  ActiveUsersInQueue: ").Append(ActiveUsersInQueue).Append("\n");
            sb.Append("  UsersOnQueue: ").Append(UsersOnQueue).Append("\n");
            sb.Append("  UsersNotUtilized: ").Append(UsersNotUtilized).Append("\n");
            sb.Append("  UsersOnQueueWithStation: ").Append(UsersOnQueueWithStation).Append("\n");
            sb.Append("  UsersOnACampaignCall: ").Append(UsersOnACampaignCall).Append("\n");
            sb.Append("  UsersOnANonCampaignCall: ").Append(UsersOnANonCampaignCall).Append("\n");
            
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
            return this.Equals(obj as QueueUtilizationDiagnostic);
        }

        /// <summary>
        /// Returns true if QueueUtilizationDiagnostic instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueUtilizationDiagnostic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueUtilizationDiagnostic other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) && 
                (
                    this.UsersInQueue == other.UsersInQueue ||
                    this.UsersInQueue != null &&
                    this.UsersInQueue.Equals(other.UsersInQueue)
                ) && 
                (
                    this.ActiveUsersInQueue == other.ActiveUsersInQueue ||
                    this.ActiveUsersInQueue != null &&
                    this.ActiveUsersInQueue.Equals(other.ActiveUsersInQueue)
                ) && 
                (
                    this.UsersOnQueue == other.UsersOnQueue ||
                    this.UsersOnQueue != null &&
                    this.UsersOnQueue.Equals(other.UsersOnQueue)
                ) && 
                (
                    this.UsersNotUtilized == other.UsersNotUtilized ||
                    this.UsersNotUtilized != null &&
                    this.UsersNotUtilized.Equals(other.UsersNotUtilized)
                ) && 
                (
                    this.UsersOnQueueWithStation == other.UsersOnQueueWithStation ||
                    this.UsersOnQueueWithStation != null &&
                    this.UsersOnQueueWithStation.Equals(other.UsersOnQueueWithStation)
                ) && 
                (
                    this.UsersOnACampaignCall == other.UsersOnACampaignCall ||
                    this.UsersOnACampaignCall != null &&
                    this.UsersOnACampaignCall.Equals(other.UsersOnACampaignCall)
                ) && 
                (
                    this.UsersOnANonCampaignCall == other.UsersOnANonCampaignCall ||
                    this.UsersOnANonCampaignCall != null &&
                    this.UsersOnANonCampaignCall.Equals(other.UsersOnANonCampaignCall)
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
                
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                
                if (this.UsersInQueue != null)
                    hash = hash * 59 + this.UsersInQueue.GetHashCode();
                
                if (this.ActiveUsersInQueue != null)
                    hash = hash * 59 + this.ActiveUsersInQueue.GetHashCode();
                
                if (this.UsersOnQueue != null)
                    hash = hash * 59 + this.UsersOnQueue.GetHashCode();
                
                if (this.UsersNotUtilized != null)
                    hash = hash * 59 + this.UsersNotUtilized.GetHashCode();
                
                if (this.UsersOnQueueWithStation != null)
                    hash = hash * 59 + this.UsersOnQueueWithStation.GetHashCode();
                
                if (this.UsersOnACampaignCall != null)
                    hash = hash * 59 + this.UsersOnACampaignCall.GetHashCode();
                
                if (this.UsersOnANonCampaignCall != null)
                    hash = hash * 59 + this.UsersOnANonCampaignCall.GetHashCode();
                
                return hash;
            }
        }

    }
}
