using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
namespace SimpleThrottleService
{
    //With the above throttling settings a maximum of 3 concurrent calls are processed.
    //In addition to maxConcurrentCalls property, maxConcurrentInstances and maxConcurrentSessions may also impact the number of calls processed concurrently.
    //For example, if we set maxConcurrentCalls="3", maxConcurrentInstances="2", and maxConcurrentSessions="100", 
    //With a PerCall instance context mode, only 2 calls are processed concurrently. This is because every call requires a new service instance, and here we are allowing only a maximum of 2 concurrent instances to be created.
    //With a Single instance context mode, 3 calls are processed concurrently. This is because with a singleton service there is only one service instance which handles all the requests from all the clients. With singleton maxConcurrentInstances property does not have any influence.

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ThrottleService : IThrottleService
    {
        public void DoWork()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thread {0} processing request @ {1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToLongTimeString());
        
        }
    }
}
