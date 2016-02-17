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
    public partial class WorkItemCache :  IEquatable<WorkItemCache>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemCache" /> class.
        /// </summary>
        public WorkItemCache()
        {
            
        }

        
        /// <summary>
        /// The workItem instance ID that owns this cache.
        /// </summary>
        /// <value>The workItem instance ID that owns this cache.</value>
        [DataMember(Name="workItemExecId", EmitDefaultValue=false)]
        public string WorkItemExecId { get; set; }
  
        
        /// <summary>
        /// The time that the workItem cache was last saved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time that the workItem cache was last saved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="saveTime", EmitDefaultValue=false)]
        public DateTime? SaveTime { get; set; }
  
        
        /// <summary>
        /// The user that last saved the workItem cache.
        /// </summary>
        /// <value>The user that last saved the workItem cache.</value>
        [DataMember(Name="saveUser", EmitDefaultValue=false)]
        public User SaveUser { get; set; }
  
        
        /// <summary>
        /// An optional comment made during the last save
        /// </summary>
        /// <value>An optional comment made during the last save</value>
        [DataMember(Name="saveComment", EmitDefaultValue=false)]
        public string SaveComment { get; set; }
  
        
        /// <summary>
        /// The data items that are present within the cache.
        /// </summary>
        /// <value>The data items that are present within the cache.</value>
        [DataMember(Name="dataItems", EmitDefaultValue=false)]
        public List<DataItem> DataItems { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemCache {\n");
            sb.Append("  WorkItemExecId: ").Append(WorkItemExecId).Append("\n");
            sb.Append("  SaveTime: ").Append(SaveTime).Append("\n");
            sb.Append("  SaveUser: ").Append(SaveUser).Append("\n");
            sb.Append("  SaveComment: ").Append(SaveComment).Append("\n");
            sb.Append("  DataItems: ").Append(DataItems).Append("\n");
            
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
            return this.Equals(obj as WorkItemCache);
        }

        /// <summary>
        /// Returns true if WorkItemCache instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkItemCache to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemCache other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WorkItemExecId == other.WorkItemExecId ||
                    this.WorkItemExecId != null &&
                    this.WorkItemExecId.Equals(other.WorkItemExecId)
                ) && 
                (
                    this.SaveTime == other.SaveTime ||
                    this.SaveTime != null &&
                    this.SaveTime.Equals(other.SaveTime)
                ) && 
                (
                    this.SaveUser == other.SaveUser ||
                    this.SaveUser != null &&
                    this.SaveUser.Equals(other.SaveUser)
                ) && 
                (
                    this.SaveComment == other.SaveComment ||
                    this.SaveComment != null &&
                    this.SaveComment.Equals(other.SaveComment)
                ) && 
                (
                    this.DataItems == other.DataItems ||
                    this.DataItems != null &&
                    this.DataItems.SequenceEqual(other.DataItems)
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
                
                if (this.WorkItemExecId != null)
                    hash = hash * 59 + this.WorkItemExecId.GetHashCode();
                
                if (this.SaveTime != null)
                    hash = hash * 59 + this.SaveTime.GetHashCode();
                
                if (this.SaveUser != null)
                    hash = hash * 59 + this.SaveUser.GetHashCode();
                
                if (this.SaveComment != null)
                    hash = hash * 59 + this.SaveComment.GetHashCode();
                
                if (this.DataItems != null)
                    hash = hash * 59 + this.DataItems.GetHashCode();
                
                return hash;
            }
        }

    }
}
