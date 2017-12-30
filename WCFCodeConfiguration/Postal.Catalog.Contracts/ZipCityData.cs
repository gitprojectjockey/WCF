using System.Runtime.Serialization;

namespace Postal.Catalog.Contracts
{
    [DataContract(Namespace = "http://www.goPostal.com/postalServices")]
    public class ZipCityData :  PostalDataBase
    {
        [DataMember]
        public bool IsPrimaryState { get; set; }
    }
}
