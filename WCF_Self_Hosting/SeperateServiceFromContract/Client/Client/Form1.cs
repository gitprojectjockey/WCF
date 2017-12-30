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

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UserService.UserServiceClient client = new UserService.UserServiceClient())
            {
                UserService.User user = client.GetUserInformation();
                txtUser.Text = string.Format("User Name: {0}\r\nAuthenticated: {1}\r\nAuthentication Type: {2}", user.Name, user.IsAuthentic, user.AuthenticationType);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MtomService.MtomServiceClient client = new MtomService.MtomServiceClient())
            {
                MtomService.FileToDownload downloadedFile = client.GetFileData("LargeFile.pdf");
                string downloadDirectory = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Downloads");
                string fileName = Path.Combine(downloadDirectory, downloadedFile.FileName);
                File.WriteAllBytes(fileName, downloadedFile.File);
                label1.Text = string.Format("File: {0} was downloaded.", downloadedFile.FileName);
            }
        }
    }
}
