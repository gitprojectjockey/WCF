using System.Runtime.Serialization;

namespace Postal.Catalog.Contracts
{
    [DataContract(Namespace = "http://www.goPostal.com/postalServices")]
    public class ZipCodeData : PostalDataBase
    {
        [DataMember]
        public string State { get; set; }
    }
}
