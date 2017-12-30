using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ESoft.EServices.Services
{
    public class MtomService : ESoft.EServices.ServiceContracts.IMtomService
    {
        public ESoft.EServices.ServiceContracts.FileToDownload GetFileData(string fileName)
        {
            string assemblyDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string absoluteFile = Path.Combine(assemblyDir, fileName);
            ESoft.EServices.ServiceContracts.FileToDownload fileToDownload = new ESoft.EServices.ServiceContracts.FileToDownload();
            fileToDownload.FileName = fileName;
            fileToDownload.File = File.ReadAllBytes(absoluteFile);
            return fileToDownload;
        }
    }
}
