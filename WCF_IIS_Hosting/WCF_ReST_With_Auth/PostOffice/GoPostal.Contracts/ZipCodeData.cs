using System.Runtime.Serialization;

namespace GoPostal.Contracts
{
    [DataContract(Namespace = "http://www.goPostal.com/postalServices")]
    public class ZipCodeData
    {
        [DataMember]
        public string State { get; set; }
    }
}
