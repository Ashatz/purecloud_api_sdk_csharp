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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PutManagementUnit.cs
    public partial class PutManagementUnit :  IEquatable<PutManagementUnit>
    { 

        /// <summary>
        /// Gets or Sets StartDayOfWeek
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StartDayOfWeekEnum {
            
            [EnumMember(Value = "MONDAY")]
            Monday,
            
            [EnumMember(Value = "TUESDAY")]
            Tuesday,
            
            [EnumMember(Value = "WEDNESDAY")]
            Wednesday,
=======
    public partial class Permissions :  IEquatable<Permissions>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Permissions" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Ids">Ids.</param>

        public Permissions(string Name = null, List<string> Ids = null)
        {
            this.Name = Name;
            this.Ids = Ids;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Permissions.cs
            
            [EnumMember(Value = "THURSDAY")]
            Thursday,
            
            [EnumMember(Value = "FRIDAY")]
            Friday,
            
            [EnumMember(Value = "SATURDAY")]
            Saturday,
            
            [EnumMember(Value = "SUNDAY")]
            Sunday
        }

<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PutManagementUnit.cs
        

        /// <summary>
        /// Gets or Sets StartDayOfWeek
        /// </summary>
        [DataMember(Name="startDayOfWeek", EmitDefaultValue=false)]
        public StartDayOfWeekEnum? StartDayOfWeek { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PutManagementUnit" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="StartDayOfWeek">StartDayOfWeek.</param>
        /// <param name="Timezone">Timezone.</param>

        public PutManagementUnit(string Name = null, StartDayOfWeekEnum? StartDayOfWeek = null, string Timezone = null)
        {
            this.Name = Name;
            this.StartDayOfWeek = StartDayOfWeek;
            this.Timezone = Timezone;
            
        }

=======
    
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Permissions.cs
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PutManagementUnit.cs
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }
=======
        /// Gets or Sets Ids
        /// </summary>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<string> Ids { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Permissions.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Permissions {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PutManagementUnit.cs
            sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
=======
            sb.Append("  Ids: ").Append(Ids).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Permissions.cs
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
            return this.Equals(obj as Permissions);
        }

        /// <summary>
        /// Returns true if Permissions instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PutManagementUnit.cs
        /// <param name="other">Instance of PutManagementUnit to be compared</param>
=======
        /// <param name="other">Instance of Permissions to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Permissions.cs
        /// <returns>Boolean</returns>
        public bool Equals(Permissions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PutManagementUnit.cs
=======
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Permissions.cs
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PutManagementUnit.cs
                (
                    this.StartDayOfWeek == other.StartDayOfWeek ||
                    this.StartDayOfWeek != null &&
                    this.StartDayOfWeek.Equals(other.StartDayOfWeek)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Permissions.cs
                (
                    this.Ids == other.Ids ||
                    this.Ids != null &&
                    this.Ids.SequenceEqual(other.Ids)
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/PutManagementUnit.cs
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.StartDayOfWeek != null)
                    hash = hash * 59 + this.StartDayOfWeek.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
=======
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Ids != null)
                    hash = hash * 59 + this.Ids.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/Permissions.cs
                return hash;
            }
        }

    }
}
