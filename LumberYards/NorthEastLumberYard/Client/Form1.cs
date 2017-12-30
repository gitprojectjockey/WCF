using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                client.ClientCredentials.UserName.UserName = textBox1.Text.Trim();
                client.ClientCredentials.UserName.Password = textBox2.Text.Trim();
                List<ToothPickService.ToothPick> tpList = client.GetToothPickList().ToList<ToothPickService.ToothPick>();
                listBox1.DataSource = tpList.Select(i => i.Flavor).ToList<string>();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            using (ToothPickService.ToothPickServiceClient client = new ToothPickService.ToothPickServiceClient())
            {
                client.ClientCredentials.UserName.UserName = textBox1.Text.Trim();
                client.ClientCredentials.UserName.Password = textBox2.Text.Trim();
                this.Text = client.GetLocation();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            using (ToothPickService.ToothPickServiceClient client = new ToothPickService.ToothPickServiceClient())
            {
                client.ClientCredentials.UserName.UserName = textBox1.Text.Trim();
                client.ClientCredentials.UserName.Password = textBox2.Text.Trim();
                List<string> idList = client.GetIdentityInformation().ToList<string>();
                foreach (var id in idList)
                {
                    listBox2.Items.Add(id);
                }
            }
        }
    }
}
                