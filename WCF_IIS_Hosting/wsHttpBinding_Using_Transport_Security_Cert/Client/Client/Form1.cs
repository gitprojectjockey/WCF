using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {

            using (HelloSimpleServiceClient.HelloSimpleServiceClient client = new HelloSimpleServiceClient.HelloSimpleServiceClient())
            {
                client.ClientCredentials.UserName.UserName = "ewnordin@comcast.net";
                client.ClientCredentials.UserName.Password = "T@c0T1me232";
                txtMessage.Text = client.GetHelloMessage("Eric Nordin");
            }

            
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
