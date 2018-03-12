using System.Runtime.Serialization;

namespace GoPostal.Contracts
{
    [DataContract(Namespace = "http://www.goPostal.com/postalServices")]
    public class ZipCityData : GoPostalDatabase
    {
        [DataMember]
        public bool IsPrimaryState { get; set; }
    }
}
