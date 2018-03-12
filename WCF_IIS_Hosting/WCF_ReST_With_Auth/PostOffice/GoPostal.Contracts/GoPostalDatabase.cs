using System.Runtime.Serialization;

namespace GoPostal.Contracts
{
    [KnownType(typeof(ZipCityData))]
    [KnownType(typeof(ZipCodeData))]
    [DataContract(Namespace = "http://www.goPostal.com/postalServices")]
    public class GoPostalDatabase
    {
        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string ZipCode { get; set; }
    }
}
