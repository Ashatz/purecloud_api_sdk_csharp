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
        [JsonConstructorAttribute]
        protected Keyword() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Keyword" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Phrase">The word or phrase which is being looked for with speech recognition. (required).</param>
        /// <param name="Confidence">A sensitivity threshold that can be increased to lower false positives or decreased to reduce false negatives. (required).</param>
        /// <param name="AgentScoreModifier">A modifier to the evaluation score when the phrase is spotted in the agent channel (required).</param>
        /// <param name="CustomerScoreModifier">A modifier to the evaluation score when the phrase is spotted in the customer channel (required).</param>
        /// <param name="AlternateSpellings">AlternateSpellings.</param>
        /// <param name="SpotabilityIndex">A prediction of how easy it is to unambiguously spot the keyword within its language based on spelling..</param>
        /// <param name="MarginOfError">MarginOfError.</param>
        /// <param name="Pronunciation">Pronunciation.</param>
        public Keyword(string Id = null, string Name = null, string Phrase = null, int? Confidence = null, int? AgentScoreModifier = null, int? CustomerScoreModifier = null, List<string> AlternateSpellings = null, double? SpotabilityIndex = null, double? MarginOfError = null, string Pronunciation = null)
        {
            // to ensure "Phrase" is required (not null)
            if (Phrase == null)
            {
                throw new InvalidDataException("Phrase is a required property for Keyword and cannot be null");
            }
            else
            {
                this.Phrase = Phrase;
            }
            // to ensure "Confidence" is required (not null)
            if (Confidence == null)
            {
                throw new InvalidDataException("Confidence is a required property for Keyword and cannot be null");
            }
            else
            {
                this.Confidence = Confidence;
            }
            // to ensure "AgentScoreModifier" is required (not null)
            if (AgentScoreModifier == null)
            {
                throw new InvalidDataException("AgentScoreModifier is a required property for Keyword and cannot be null");
            }
            else
            {
                this.AgentScoreModifier = AgentScoreModifier;
            }
            // to ensure "CustomerScoreModifier" is required (not null)
            if (CustomerScoreModifier == null)
            {
                throw new InvalidDataException("CustomerScoreModifier is a required property for Keyword and cannot be null");
            }
            else
            {
                this.CustomerScoreModifier = CustomerScoreModifier;
            }
            this.Id = Id;
            this.Name = Name;
            this.AlternateSpellings = AlternateSpellings;
            this.SpotabilityIndex = SpotabilityIndex;
            this.MarginOfError = MarginOfError;
            this.Pronunciation = Pronunciation;
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
        /// The word or phrase which is being looked for with speech recognition.
        /// </summary>
        /// <value>The word or phrase which is being looked for with speech recognition.</value>
        [DataMember(Name="phrase", EmitDefaultValue=false)]
        public string Phrase { get; set; }
        /// <summary>
        /// A sensitivity threshold that can be increased to lower false positives or decreased to reduce false negatives.
        /// </summary>
        /// <value>A sensitivity threshold that can be increased to lower false positives or decreased to reduce false negatives.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public int? Confidence { get; set; }
        /// <summary>
        /// A modifier to the evaluation score when the phrase is spotted in the agent channel
        /// </summary>
        /// <value>A modifier to the evaluation score when the phrase is spotted in the agent channel</value>
        [DataMember(Name="agentScoreModifier", EmitDefaultValue=false)]
        public int? AgentScoreModifier { get; set; }
        /// <summary>
        /// A modifier to the evaluation score when the phrase is spotted in the customer channel
        /// </summary>
        /// <value>A modifier to the evaluation score when the phrase is spotted in the customer channel</value>
        [DataMember(Name="customerScoreModifier", EmitDefaultValue=false)]
        public int? CustomerScoreModifier { get; set; }
        /// <summary>
        /// Gets or Sets AlternateSpellings
        /// </summary>
        [DataMember(Name="alternateSpellings", EmitDefaultValue=false)]
        public List<string> AlternateSpellings { get; set; }
        /// <summary>
        /// A prediction of how easy it is to unambiguously spot the keyword within its language based on spelling.
        /// </summary>
        /// <value>A prediction of how easy it is to unambiguously spot the keyword within its language based on spelling.</value>
        [DataMember(Name="spotabilityIndex", EmitDefaultValue=false)]
        public double? SpotabilityIndex { get; set; }
        /// <summary>
        /// Gets or Sets MarginOfError
        /// </summary>
        [DataMember(Name="marginOfError", EmitDefaultValue=false)]
        public double? MarginOfError { get; set; }
        /// <summary>
        /// Gets or Sets Pronunciation
        /// </summary>
        [DataMember(Name="pronunciation", EmitDefaultValue=false)]
        public string Pronunciation { get; set; }
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
            sb.Append("  SpotabilityIndex: ").Append(SpotabilityIndex).Append("\n");
            sb.Append("  MarginOfError: ").Append(MarginOfError).Append("\n");
            sb.Append("  Pronunciation: ").Append(Pronunciation).Append("\n");
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
                ) &&
                (
                    this.SpotabilityIndex == other.SpotabilityIndex ||
                    this.SpotabilityIndex != null &&
                    this.SpotabilityIndex.Equals(other.SpotabilityIndex)
                ) &&
                (
                    this.MarginOfError == other.MarginOfError ||
                    this.MarginOfError != null &&
                    this.MarginOfError.Equals(other.MarginOfError)
                ) &&
                (
                    this.Pronunciation == other.Pronunciation ||
                    this.Pronunciation != null &&
                    this.Pronunciation.Equals(other.Pronunciation)
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
                if (this.SpotabilityIndex != null)
                    hash = hash * 59 + this.SpotabilityIndex.GetHashCode();
                if (this.MarginOfError != null)
                    hash = hash * 59 + this.MarginOfError.GetHashCode();
                if (this.Pronunciation != null)
                    hash = hash * 59 + this.Pronunciation.GetHashCode();
                return hash;
            }
        }
    }

}
