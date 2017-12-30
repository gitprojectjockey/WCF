using System.Runtime.Serialization;

namespace NALS.GeoLibrary.Contracts
{
    [DataContract(Namespace = "http://www.geo.com/nalocationServices")]
    public class ZipCodeData
    {
        [DataMember]
        public string  City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string  ZipCode { get; set; }
    }
}
