using System.Runtime.Serialization;

namespace NALS.GeoLibrary.Contracts
{
    [DataContract(Namespace = "http://www.geo.com/nalocationServices")]
    public class StateCodeData
    {
        [DataMember]
        public int StateId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string SSCode { get; set; }

        [DataMember]
        public string Abbreviation { get; set; }
    }
}
