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
    /// Keyword
    /// </summary>
    [DataContract]
    public partial class Keyword :  IEquatable<Keyword>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Keyword" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Phrase">Phrase.</param>
        /// <param name="Confidence">Confidence.</param>
        /// <param name="AgentScoreModifier">AgentScoreModifier.</param>
        /// <param name="CustomerScoreModifier">CustomerScoreModifier.</param>
        /// <param name="AlternateSpellings">AlternateSpellings.</param>
        public Keyword(string Id = null, string Name = null, string Phrase = null, int? Confidence = null, int? AgentScoreModifier = null, int? CustomerScoreModifier = null, List<string> AlternateSpellings = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Phrase = Phrase;
            this.Confidence = Confidence;
            this.AgentScoreModifier = AgentScoreModifier;
            this.CustomerScoreModifier = CustomerScoreModifier;
            this.AlternateSpellings = AlternateSpellings;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Phrase
        /// </summary>
        [DataMember(Name="phrase", EmitDefaultValue=false)]
        public string Phrase { get; set; }
        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public int? Confidence { get; set; }
        /// <summary>
        /// Gets or Sets AgentScoreModifier
        /// </summary>
        [DataMember(Name="agentScoreModifier", EmitDefaultValue=false)]
        public int? AgentScoreModifier { get; set; }
        /// <summary>
        /// Gets or Sets CustomerScoreModifier
        /// </summary>
        [DataMember(Name="customerScoreModifier", EmitDefaultValue=false)]
        public int? CustomerScoreModifier { get; set; }
        /// <summary>
        /// Gets or Sets AlternateSpellings
        /// </summary>
        [DataMember(Name="alternateSpellings", EmitDefaultValue=false)]
        public List<string> AlternateSpellings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Keyword {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phrase: ").Append(Phrase).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  AgentScoreModifier: ").Append(AgentScoreModifier).Append("\n");
            sb.Append("  CustomerScoreModifier: ").Append(CustomerScoreModifier).Append("\n");
            sb.Append("  AlternateSpellings: ").Append(AlternateSpellings).Append("\n");
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
            return this.Equals(obj as Keyword);
        }

        /// <summary>
        /// Returns true if Keyword instances are equal
        /// </summary>
        /// <param name="other">Instance of Keyword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Keyword other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Phrase == other.Phrase ||
                    this.Phrase != null &&
                    this.Phrase.Equals(other.Phrase)
                ) &&
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
                ) &&
                (
                    this.AgentScoreModifier == other.AgentScoreModifier ||
                    this.AgentScoreModifier != null &&
                    this.AgentScoreModifier.Equals(other.AgentScoreModifier)
                ) &&
                (
                    this.CustomerScoreModifier == other.CustomerScoreModifier ||
                    this.CustomerScoreModifier != null &&
                    this.CustomerScoreModifier.Equals(other.CustomerScoreModifier)
                ) &&
                (
                    this.AlternateSpellings == other.AlternateSpellings ||
                    this.AlternateSpellings != null &&
                    this.AlternateSpellings.SequenceEqual(other.AlternateSpellings)
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
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Phrase != null)
                    hash = hash * 59 + this.Phrase.GetHashCode();
                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();
                if (this.AgentScoreModifier != null)
                    hash = hash * 59 + this.AgentScoreModifier.GetHashCode();
                if (this.CustomerScoreModifier != null)
                    hash = hash * 59 + this.CustomerScoreModifier.GetHashCode();
                if (this.AlternateSpellings != null)
                    hash = hash * 59 + this.AlternateSpellings.GetHashCode();
                return hash;
            }
        }
    }

}
