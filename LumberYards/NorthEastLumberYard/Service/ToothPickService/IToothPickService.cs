using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ToothPickService
{
    [ServiceContract(Namespace = "http://ESoft.EServices.ToothPickService", SessionMode = SessionMode.Allowed)]
    public interface IToothPickService
    {
        [OperationContract]
        IEnumerable<ToothPick> GetToothPickList();

        [OperationContract]
        string GetLocation();

        [OperationContract]
        IEnumerable<string> GetIdentityInformation();
    }

    [DataContract(Namespace = "http://ESoft.EServices.ToothPickService.ToothPick")]
    public class ToothPick
    {
        [DataMember(Order = 1)]
        public string ProductCode { get; set; }

        [DataMember(Order = 2)]
        public int Length { get; set; }

        [DataMember(Order = 3)]
        public string Flavor { get; set; }

        [DataMember(Order = 4)]
        public string Name { get; set; }

        [DataMember(Order = 5)]
        public int BoxCount { get; set; }

        [DataMember(Order = 6)]
        public decimal BoxCost { get; set; }
    }
}
