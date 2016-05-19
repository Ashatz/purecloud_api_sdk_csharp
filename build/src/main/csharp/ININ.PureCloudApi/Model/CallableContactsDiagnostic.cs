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
    /// CallableContactsDiagnostic
    /// </summary>
    [DataContract]
    public partial class CallableContactsDiagnostic :  IEquatable<CallableContactsDiagnostic>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallableContactsDiagnostic" /> class.
        /// </summary>
        /// <param name="DncLists">Do not call lists for the campaign.</param>
        /// <param name="CallableTimeSet">Callable time sets for the campaign.</param>
        /// <param name="RuleSets">Rule sets for the campaign.</param>
        public CallableContactsDiagnostic(List<UriReference> DncLists = null, UriReference CallableTimeSet = null, List<UriReference> RuleSets = null)
        {
            this.DncLists = DncLists;
            this.CallableTimeSet = CallableTimeSet;
            this.RuleSets = RuleSets;
        }
        
        /// <summary>
        /// Do not call lists for the campaign
        /// </summary>
        /// <value>Do not call lists for the campaign</value>
        [DataMember(Name="dncLists", EmitDefaultValue=false)]
        public List<UriReference> DncLists { get; set; }
        /// <summary>
        /// Callable time sets for the campaign
        /// </summary>
        /// <value>Callable time sets for the campaign</value>
        [DataMember(Name="callableTimeSet", EmitDefaultValue=false)]
        public UriReference CallableTimeSet { get; set; }
        /// <summary>
        /// Rule sets for the campaign
        /// </summary>
        /// <value>Rule sets for the campaign</value>
        [DataMember(Name="ruleSets", EmitDefaultValue=false)]
        public List<UriReference> RuleSets { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallableContactsDiagnostic {\n");
            sb.Append("  DncLists: ").Append(DncLists).Append("\n");
            sb.Append("  CallableTimeSet: ").Append(CallableTimeSet).Append("\n");
            sb.Append("  RuleSets: ").Append(RuleSets).Append("\n");
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
            return this.Equals(obj as CallableContactsDiagnostic);
        }

        /// <summary>
        /// Returns true if CallableContactsDiagnostic instances are equal
        /// </summary>
        /// <param name="other">Instance of CallableContactsDiagnostic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallableContactsDiagnostic other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DncLists == other.DncLists ||
                    this.DncLists != null &&
                    this.DncLists.SequenceEqual(other.DncLists)
                ) && 
                (
                    this.CallableTimeSet == other.CallableTimeSet ||
                    this.CallableTimeSet != null &&
                    this.CallableTimeSet.Equals(other.CallableTimeSet)
                ) && 
                (
                    this.RuleSets == other.RuleSets ||
                    this.RuleSets != null &&
                    this.RuleSets.SequenceEqual(other.RuleSets)
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
                if (this.DncLists != null)
                    hash = hash * 59 + this.DncLists.GetHashCode();
                if (this.CallableTimeSet != null)
                    hash = hash * 59 + this.CallableTimeSet.GetHashCode();
                if (this.RuleSets != null)
                    hash = hash * 59 + this.RuleSets.GetHashCode();
                return hash;
            }
        }
    }

}
