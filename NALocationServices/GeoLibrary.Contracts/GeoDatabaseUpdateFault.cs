using System.Runtime.Serialization;

namespace GeoLibrary.Contracts
{
    [DataContract(Namespace = "http://www.geo.com/nalocationServices")]
    public class GeoDatabaseUpdateFault
    {
        private string _issue;
        public GeoDatabaseUpdateFault(string message)
        {
            _issue = message;
        }

        [DataMember]
        public string IssueDetail { get; set; }

        [DataMember]
        public string Issue { get => _issue; set => _issue = value; }
    }
}
