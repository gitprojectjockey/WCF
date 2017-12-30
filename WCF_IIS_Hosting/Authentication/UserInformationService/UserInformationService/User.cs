using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace UserInformationService
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool IsAuthentic { get; set; }
        [DataMember]
        public string AuthenticationType { get; set; }
    }
}
