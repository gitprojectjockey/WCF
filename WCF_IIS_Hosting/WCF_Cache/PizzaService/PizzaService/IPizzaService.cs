using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PizzaService
{
   
    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface IPizzaService
    {
        [OperationContract]
        IEnumerable<string> GetAvailablePizzas();
    }
}
