﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
    
    [ServiceContract(Namespace="http://ESoft.EServices/CalculatorService")]
    public interface ICalculatorService
    {
        [FaultContract(typeof(DivideByZeroFault))]
        [OperationContract]
        int Divide(int enumerator, int denominator);
    }
}