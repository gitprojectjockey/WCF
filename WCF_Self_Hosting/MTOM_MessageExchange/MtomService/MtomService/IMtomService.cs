using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MtomService
{
    
    [ServiceContract(Namespace="http://ESoft.EServices/MtomService")]
    public interface IMtomService
    {
        [FaultContract(typeof(IOFault))]
        [OperationContract]
        FileToDownload GetFileData(string fileName);
    }
   
    [DataContract]
    public class FileToDownload
    {
        [DataMember]
        public string FileName { get; set; }
        [DataMember]
        public byte[] File { get; set; }
    }
}
