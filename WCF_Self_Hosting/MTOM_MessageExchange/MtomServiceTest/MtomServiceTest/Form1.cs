using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MtomServiceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MtomService.MtomServiceClient client = new MtomService.MtomServiceClient())
                {
                    MtomService.FileToDownload downloadedFile = new MtomService.FileToDownload();
                    downloadedFile = client.GetFileData("LargeFile.pdf");
                    string downloadDirectory = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Downloads");
                    string fileName = Path.Combine(downloadDirectory, downloadedFile.FileName);
                    File.WriteAllBytes(fileName, downloadedFile.File);
                    label3.Text = string.Format("File: {0} was downloaded.", downloadedFile.FileName);
                }
            }
            catch (System.ServiceModel.FaultException<MtomService.IOFault> faultException)
            {
                label3.Text = faultException.Detail.Error + " - " + faultException.Detail.Details;
            }
        }
    }
}
