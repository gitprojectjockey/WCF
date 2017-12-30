using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace ESoft.EServices.ServiceContracts
{
    [ServiceContract]
    public interface IMtomService
    {
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
