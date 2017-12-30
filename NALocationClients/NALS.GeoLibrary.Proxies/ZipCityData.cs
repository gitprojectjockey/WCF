using System.Runtime.Serialization;

namespace NALS.GeoLibrary.Contracts
{
    [DataContract(Namespace = "http://www.geo.com/nalocationServices")]
    public class ZipCityData
    {
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string ZipCode { get; set; }
    }
}
