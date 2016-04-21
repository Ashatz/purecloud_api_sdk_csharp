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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/GroupImages.cs
    public partial class GroupImages :  IEquatable<GroupImages>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupImages" />class.
        /// </summary>
        /// <param name="ActiveImages">ActiveImages.</param>

        public GroupImages(List<UserImage> ActiveImages = null)
        {
            this.ActiveImages = ActiveImages;
=======
    public partial class CallCommand :  IEquatable<CallCommand>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="CallCommand" />class.
        /// </summary>
        /// <param name="CallNumber">CallNumber.</param>

        public CallCommand(string CallNumber = null)
        {
            this.CallNumber = CallNumber;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/CallCommand.cs
            
        }

    
        /// <summary>
        /// Gets or Sets CallNumber
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/GroupImages.cs
        [DataMember(Name="activeImages", EmitDefaultValue=false)]
        public List<UserImage> ActiveImages { get; set; }
=======
        [DataMember(Name="callNumber", EmitDefaultValue=false)]
        public string CallNumber { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/CallCommand.cs
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/GroupImages.cs
            sb.Append("class GroupImages {\n");
            sb.Append("  ActiveImages: ").Append(ActiveImages).Append("\n");
=======
            sb.Append("class CallCommand {\n");
            sb.Append("  CallNumber: ").Append(CallNumber).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/CallCommand.cs
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
            return this.Equals(obj as CallCommand);
        }

        /// <summary>
        /// Returns true if CallCommand instances are equal
        /// </summary>
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/GroupImages.cs
        /// <param name="other">Instance of GroupImages to be compared</param>
=======
        /// <param name="other">Instance of CallCommand to be compared</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/CallCommand.cs
        /// <returns>Boolean</returns>
        public bool Equals(CallCommand other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CallNumber == other.CallNumber ||
                    this.CallNumber != null &&
                    this.CallNumber.Equals(other.CallNumber)
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
<<<<<<< HEAD:build/src/main/csharp/ININ/PureCloudApi/Model/GroupImages.cs
                if (this.ActiveImages != null)
                    hash = hash * 59 + this.ActiveImages.GetHashCode();
=======
                if (this.CallNumber != null)
                    hash = hash * 59 + this.CallNumber.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548:build/src/main/csharp/ININ/PureCloudApi/Model/CallCommand.cs
                return hash;
            }
        }

    }
}
