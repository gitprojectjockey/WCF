using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in both code and config file together.
    public class CalculatorService : ICalculatorService
    {
        public int Divide(int enumerator, int denominator)
        {
            try
            {
                return enumerator / denominator;
            }
            catch (DivideByZeroException ex)
            {
                DivideByZeroFault divideByZeroFault = new DivideByZeroFault();
                divideByZeroFault.Error = ex.Message;
                divideByZeroFault.Details = "The Denominator cannot be ZERO.";
                throw new FaultException<DivideByZeroFault>(divideByZeroFault, new FaultReason("The Denominator cannot be ZERO."));
            }
        }
    }
}
