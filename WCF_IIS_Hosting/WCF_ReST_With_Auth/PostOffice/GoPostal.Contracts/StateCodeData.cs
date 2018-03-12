using System.Runtime.Serialization;

namespace GoPostal.Contracts
{
    [DataContract(Namespace = "http://www.goPostal.com/postalServices")]
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
