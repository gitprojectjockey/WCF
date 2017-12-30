using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class GlobalErrorHandler : IErrorHandler
    {
        //This method gets called asyn so if you want to do some extensive message processing (write to database etc.) the client does not have to wait to
        //recieve the error message.
        public bool HandleError(Exception error)
        {
            //Database code for example...
            return true;
        }

        //This method is called automatically first and returns the message immediatly to the client. Then Handle error is called.
        //Here we can convert a .net exception to a more friendly WCF SOAP fault for the client to consume.
        public void ProvideFault(Exception error, System.ServiceModel.Channels.MessageVersion version, ref System.ServiceModel.Channels.Message fault)
        {
            if (error is FaultException) { return; }

            FaultException ex = new FaultException("A general service error occured");
            MessageFault messageFault = ex.CreateMessageFault();
            fault = Message.CreateMessage(version, messageFault, null); 
        }
    }
}
