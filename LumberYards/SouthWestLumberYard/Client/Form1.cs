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

        private void button1_Click(object sender, EventArgs e)
        {
            using (ToothPickService.ToothPickServiceClient client = new ToothPickService.ToothPickServiceClient())
            {
                client.ClientCredentials.UserName.UserName =textBox1.Text.Trim().ToLower();
                client.ClientCredentials.UserName.Password = textBox2.Text.Trim().ToLower(); ;
                List<ToothPickService.ToothPick> tpList = client.GetToothPickList().ToList<ToothPickService.ToothPick>();
                listBox1.DataSource = tpList.Select(i => i.Flavor).ToList<string>();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ToothPickService.ToothPickServiceClient client = new ToothPickService.ToothPickServiceClient())
            {
                client.ClientCredentials.UserName.UserName = textBox1.Text.Trim().ToLower();
                client.ClientCredentials.UserName.Password = textBox2.Text.Trim().ToLower(); ;
                this.Text = client.GetLocation();
            }
        }
    }
}
                