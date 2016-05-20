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
    /// TraceList
    /// </summary>
    [DataContract]
    public partial class TraceList :  IEquatable<TraceList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TraceList" /> class.
        /// </summary>
        /// <param name="App">App.</param>
        /// <param name="Traces">Traces.</param>
        public TraceList(App App = null, List<Trace> Traces = null)
        {
            this.App = App;
            this.Traces = Traces;
        }
        
        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name="app", EmitDefaultValue=false)]
        public App App { get; set; }
        /// <summary>
        /// Gets or Sets Traces
        /// </summary>
        [DataMember(Name="traces", EmitDefaultValue=false)]
        public List<Trace> Traces { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TraceList {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  Traces: ").Append(Traces).Append("\n");
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
            return this.Equals(obj as TraceList);
        }

        /// <summary>
        /// Returns true if TraceList instances are equal
        /// </summary>
        /// <param name="other">Instance of TraceList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TraceList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.App == other.App ||
                    this.App != null &&
                    this.App.Equals(other.App)
                ) &&
                (
                    this.Traces == other.Traces ||
                    this.Traces != null &&
                    this.Traces.SequenceEqual(other.Traces)
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
                if (this.App != null)
                    hash = hash * 59 + this.App.GetHashCode();
                if (this.Traces != null)
                    hash = hash * 59 + this.Traces.GetHashCode();
                return hash;
            }
        }
    }

}
