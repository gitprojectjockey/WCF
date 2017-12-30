using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ReportService
{
    [ServiceContract(CallbackContract = typeof(IReportServiceCallBack))]
    public interface IReportService
    {
        //We do not want the client to wait for this long process so we will implement a Duplex Callback Contract messaging pattern.
        //This way the client can implement a callback "Evemt Listener" and retrieve updates to this long process while the client moves on a completes other processes.
        //IS ONE WAY = TRUE
        [OperationContract(IsOneWay=true)]
        void ProcessReport();
    }

    public interface IReportServiceCallBack
    {
        [OperationContract(IsOneWay = true)]
        void Progress(int percentComplete);
    }
}
