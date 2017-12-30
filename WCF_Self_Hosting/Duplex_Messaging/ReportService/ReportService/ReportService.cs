using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace ReportService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class ReportService : IReportService
    {
        public void ProcessReport()
        {
            for (int i = 1; i < 101; i++)
            {
                //Artificial processing logic.
                Thread.Sleep(100);

                //Invoke the IReportServiceCallBack
                System.ServiceModel.OperationContext.Current.GetCallbackChannel<IReportServiceCallBack>().Progress(i);
            }
        }
    }
}
