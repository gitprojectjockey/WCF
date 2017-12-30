using System.Runtime.Serialization;

namespace NALS.GeoLibrary.Contracts
{
    [DataContract(Namespace = "http://www.geo.com/nalocationServices")]
    public class GeoDatabaseUpdateFault
    {
        [DataMember]
        public string Issue { get; set; }

        [DataMember]
        public string IssueDetail { get; set; }
    }
}
