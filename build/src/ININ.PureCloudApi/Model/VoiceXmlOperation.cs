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
    /// VoiceXmlOperation
    /// </summary>
    [DataContract]
    public partial class VoiceXmlOperation :  IEquatable<VoiceXmlOperation>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Goto for "GOTO"
            /// </summary>
            [EnumMember(Value = "GOTO")]
            Goto,
            
            /// <summary>
            /// Enum CallAndReturn for "CALL_AND_RETURN"
            /// </summary>
            [EnumMember(Value = "CALL_AND_RETURN")]
            CallAndReturn
        }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            
            /// <summary>
            /// Enum Get for "GET"
            /// </summary>
            [EnumMember(Value = "GET")]
            Get,
            
            /// <summary>
            /// Enum Put for "PUT"
            /// </summary>
            [EnumMember(Value = "PUT")]
            Put,
            
            /// <summary>
            /// Enum Post for "POST"
            /// </summary>
            [EnumMember(Value = "POST")]
            Post,
            
            /// <summary>
            /// Enum Delete for "DELETE"
            /// </summary>
            [EnumMember(Value = "DELETE")]
            Delete
        }

        /// <summary>
        /// Gets or Sets Encoding
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncodingEnum
        {
            
            /// <summary>
            /// Enum MultipartFormData for "MULTIPART_FORM_DATA"
            /// </summary>
            [EnumMember(Value = "MULTIPART_FORM_DATA")]
            MultipartFormData,
            
            /// <summary>
            /// Enum FormUrlEncoded for "FORM_URL_ENCODED"
            /// </summary>
            [EnumMember(Value = "FORM_URL_ENCODED")]
            FormUrlEncoded,
            
            /// <summary>
            /// Enum Json for "JSON"
            /// </summary>
            [EnumMember(Value = "JSON")]
            Json
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public MethodEnum? Method { get; set; }
        /// <summary>
        /// Gets or Sets Encoding
        /// </summary>
        [DataMember(Name="encoding", EmitDefaultValue=false)]
        public EncodingEnum? Encoding { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceXmlOperation" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Method">Method.</param>
        /// <param name="Encoding">Encoding.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Uri">Uri.</param>
        /// <param name="Inputs">Inputs.</param>
        /// <param name="Outputs">Outputs.</param>
        /// <param name="FetchAudio">FetchAudio.</param>
        /// <param name="TimeoutMS">TimeoutMS.</param>
        public VoiceXmlOperation(, string Name = null, TypeEnum? Type = null, MethodEnum? Method = null, EncodingEnum? Encoding = null, string Description = null, string Uri = null, string Inputs = null, string Outputs = null, string FetchAudio = null, int? TimeoutMS = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.Method = Method;
            this.Encoding = Encoding;
            this.Description = Description;
            this.Uri = Uri;
            this.Inputs = Inputs;
            this.Outputs = Outputs;
            this.FetchAudio = FetchAudio;
            this.TimeoutMS = TimeoutMS;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public string Inputs { get; set; }
        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public string Outputs { get; set; }
        /// <summary>
        /// Gets or Sets FetchAudio
        /// </summary>
        [DataMember(Name="fetchAudio", EmitDefaultValue=false)]
        public string FetchAudio { get; set; }
        /// <summary>
        /// Gets or Sets TimeoutMS
        /// </summary>
        [DataMember(Name="timeoutMS", EmitDefaultValue=false)]
        public int? TimeoutMS { get; set; }
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoiceXmlOperation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  FetchAudio: ").Append(FetchAudio).Append("\n");
            sb.Append("  TimeoutMS: ").Append(TimeoutMS).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as VoiceXmlOperation);
        }

        /// <summary>
        /// Returns true if VoiceXmlOperation instances are equal
        /// </summary>
        /// <param name="other">Instance of VoiceXmlOperation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoiceXmlOperation other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.Encoding == other.Encoding ||
                    this.Encoding != null &&
                    this.Encoding.Equals(other.Encoding)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.Inputs == other.Inputs ||
                    this.Inputs != null &&
                    this.Inputs.Equals(other.Inputs)
                ) && 
                (
                    this.Outputs == other.Outputs ||
                    this.Outputs != null &&
                    this.Outputs.Equals(other.Outputs)
                ) && 
                (
                    this.FetchAudio == other.FetchAudio ||
                    this.FetchAudio != null &&
                    this.FetchAudio.Equals(other.FetchAudio)
                ) && 
                (
                    this.TimeoutMS == other.TimeoutMS ||
                    this.TimeoutMS != null &&
                    this.TimeoutMS.Equals(other.TimeoutMS)
                )
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                if (this.Encoding != null)
                    hash = hash * 59 + this.Encoding.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                if (this.Inputs != null)
                    hash = hash * 59 + this.Inputs.GetHashCode();
                if (this.Outputs != null)
                    hash = hash * 59 + this.Outputs.GetHashCode();
                if (this.FetchAudio != null)
                    hash = hash * 59 + this.FetchAudio.GetHashCode();
                if (this.TimeoutMS != null)
                    hash = hash * 59 + this.TimeoutMS.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
