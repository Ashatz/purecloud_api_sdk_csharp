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
    public class Value :  IEquatable<Value>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class.
        /// </summary>
        public Value()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets StringItems
        /// </summary>
        [DataMember(Name="stringItems", EmitDefaultValue=false)]
        public List<string> StringItems { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IntegerItems
        /// </summary>
        [DataMember(Name="integerItems", EmitDefaultValue=false)]
        public List<string> IntegerItems { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RealItems
        /// </summary>
        [DataMember(Name="realItems", EmitDefaultValue=false)]
        public List<string> RealItems { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DateItems
        /// </summary>
        [DataMember(Name="dateItems", EmitDefaultValue=false)]
        public List<DateTime?> DateItems { get; set; }
  
        
        /// <summary>
        /// Gets or Sets UserItems
        /// </summary>
        [DataMember(Name="userItems", EmitDefaultValue=false)]
        public List<User> UserItems { get; set; }
  
        
        /// <summary>
        /// Gets or Sets QueueItems
        /// </summary>
        [DataMember(Name="queueItems", EmitDefaultValue=false)]
        public List<Queue> QueueItems { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DataItems
        /// </summary>
        [DataMember(Name="dataItems", EmitDefaultValue=false)]
        public List<SubDataItem> DataItems { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Value {\n");
            sb.Append("  StringItems: ").Append(StringItems).Append("\n");
            sb.Append("  IntegerItems: ").Append(IntegerItems).Append("\n");
            sb.Append("  RealItems: ").Append(RealItems).Append("\n");
            sb.Append("  DateItems: ").Append(DateItems).Append("\n");
            sb.Append("  UserItems: ").Append(UserItems).Append("\n");
            sb.Append("  QueueItems: ").Append(QueueItems).Append("\n");
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
            return this.Equals(obj as Value);
        }

        /// <summary>
        /// Returns true if Value instances are equal
        /// </summary>
        /// <param name="obj">Instance of Value to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Value other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StringItems == other.StringItems ||
                    this.StringItems != null &&
                    this.StringItems.SequenceEqual(other.StringItems)
                ) && 
                (
                    this.IntegerItems == other.IntegerItems ||
                    this.IntegerItems != null &&
                    this.IntegerItems.SequenceEqual(other.IntegerItems)
                ) && 
                (
                    this.RealItems == other.RealItems ||
                    this.RealItems != null &&
                    this.RealItems.SequenceEqual(other.RealItems)
                ) && 
                (
                    this.DateItems == other.DateItems ||
                    this.DateItems != null &&
                    this.DateItems.SequenceEqual(other.DateItems)
                ) && 
                (
                    this.UserItems == other.UserItems ||
                    this.UserItems != null &&
                    this.UserItems.SequenceEqual(other.UserItems)
                ) && 
                (
                    this.QueueItems == other.QueueItems ||
                    this.QueueItems != null &&
                    this.QueueItems.SequenceEqual(other.QueueItems)
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
                
                if (this.StringItems != null)
                    hash = hash * 57 + this.StringItems.GetHashCode();
                
                if (this.IntegerItems != null)
                    hash = hash * 57 + this.IntegerItems.GetHashCode();
                
                if (this.RealItems != null)
                    hash = hash * 57 + this.RealItems.GetHashCode();
                
                if (this.DateItems != null)
                    hash = hash * 57 + this.DateItems.GetHashCode();
                
                if (this.UserItems != null)
                    hash = hash * 57 + this.UserItems.GetHashCode();
                
                if (this.QueueItems != null)
                    hash = hash * 57 + this.QueueItems.GetHashCode();
                
                if (this.DataItems != null)
                    hash = hash * 57 + this.DataItems.GetHashCode();
                
                return hash;
            }
        }

    }


}