using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class LineStatus :  IEquatable<LineStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineStatus" /> class.
        /// </summary>
        public LineStatus()
        {
            this.Reachable = false;
            
        }

        
        /// <summary>
        /// The id of this line
        /// </summary>
        /// <value>The id of this line</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Indicates whether the edge can reach the line.
        /// </summary>
        /// <value>Indicates whether the edge can reach the line.</value>
        [DataMember(Name="reachable", EmitDefaultValue=false)]
        public bool? Reachable { get; set; }
  
        
        /// <summary>
        /// The line's address of record.
        /// </summary>
        /// <value>The line's address of record.</value>
        [DataMember(Name="addressOfRecord", EmitDefaultValue=false)]
        public string AddressOfRecord { get; set; }
  
        
        /// <summary>
        /// The addresses used to contact the line.
        /// </summary>
        /// <value>The addresses used to contact the line.</value>
        [DataMember(Name="contactAddresses", EmitDefaultValue=false)]
        public List<string> ContactAddresses { get; set; }
  
        
        /// <summary>
        /// The time the line entered its current reachable state.
        /// </summary>
        /// <value>The time the line entered its current reachable state.</value>
        [DataMember(Name="reachableStateTime", EmitDefaultValue=false)]
        public DateTime? ReachableStateTime { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineStatus {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reachable: ").Append(Reachable).Append("\n");
            sb.Append("  AddressOfRecord: ").Append(AddressOfRecord).Append("\n");
            sb.Append("  ContactAddresses: ").Append(ContactAddresses).Append("\n");
            sb.Append("  ReachableStateTime: ").Append(ReachableStateTime).Append("\n");
            
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
            return this.Equals(obj as LineStatus);
        }

        /// <summary>
        /// Returns true if LineStatus instances are equal
        /// </summary>
        /// <param name="obj">Instance of LineStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineStatus other)
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
                    this.Reachable == other.Reachable ||
                    this.Reachable != null &&
                    this.Reachable.Equals(other.Reachable)
                ) && 
                (
                    this.AddressOfRecord == other.AddressOfRecord ||
                    this.AddressOfRecord != null &&
                    this.AddressOfRecord.Equals(other.AddressOfRecord)
                ) && 
                (
                    this.ContactAddresses == other.ContactAddresses ||
                    this.ContactAddresses != null &&
                    this.ContactAddresses.SequenceEqual(other.ContactAddresses)
                ) && 
                (
                    this.ReachableStateTime == other.ReachableStateTime ||
                    this.ReachableStateTime != null &&
                    this.ReachableStateTime.Equals(other.ReachableStateTime)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Reachable != null)
                    hash = hash * 57 + this.Reachable.GetHashCode();
                
                if (this.AddressOfRecord != null)
                    hash = hash * 57 + this.AddressOfRecord.GetHashCode();
                
                if (this.ContactAddresses != null)
                    hash = hash * 57 + this.ContactAddresses.GetHashCode();
                
                if (this.ReachableStateTime != null)
                    hash = hash * 57 + this.ReachableStateTime.GetHashCode();
                
                return hash;
            }
        }

    }


}