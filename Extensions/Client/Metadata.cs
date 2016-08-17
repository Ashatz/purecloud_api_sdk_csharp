using System.Runtime.Serialization;

namespace ININ.PureCloudApi.Client
{
    public class Metadata
    {
        [DataMember(EmitDefaultValue = false, Name = "CorrelationId")]
        public string CorrelationId { get; set; }
    }
}