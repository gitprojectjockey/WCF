using System.Runtime.Serialization;

namespace Postal.Catalog.Contracts
{
    [KnownType(typeof(ZipCityData))]
    [KnownType(typeof(ZipCodeData))]
    [DataContract(Namespace = "http://www.goPostal.com/postalServices")]
    public class PostalDataBase
    {
        [DataMember]
        public string City { get; set; }
       
        [DataMember]
        public string ZipCode { get; set; }
    }
}
