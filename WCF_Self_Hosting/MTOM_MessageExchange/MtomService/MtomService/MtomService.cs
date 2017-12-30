using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace MtomService
{
    public class MtomService : IMtomService
    {
        public FileToDownload GetFileData(string fileName)
        {
            try
            {
                string assemblyDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                
                string absoluteFile = Path.Combine(assemblyDir, fileName);
                FileToDownload fileToDownload = new FileToDownload();
                fileToDownload.FileName = fileName;
                fileToDownload.File = File.ReadAllBytes(absoluteFile);
                return fileToDownload;
            }
            catch (IOException ex)
            {
                IOFault ioFault = new IOFault();
                ioFault.Error = ex.Message;
                ioFault.Details = "A System IO error occured in Mtomservice.GetFileData.";
                throw new FaultException<IOFault>(ioFault, new FaultReason("A System IO error occured in Mtomservice.GetFileData."));
            }
        }
    }
}
