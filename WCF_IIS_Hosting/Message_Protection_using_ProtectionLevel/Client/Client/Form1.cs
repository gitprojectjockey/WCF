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
            using (SimpleService.SimpleServiceClient client = new SimpleService.SimpleServiceClient())
            {
                string message = client.GetMessageWithNoProtection();
                MessageBox.Show(message, "Message with no signing or encryption protection", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SimpleService.SimpleServiceClient client = new SimpleService.SimpleServiceClient())
            {
                string message = client.GetSignedMessage();
                MessageBox.Show(message, "Message is signed but no encryption", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SimpleService.SimpleServiceClient client = new SimpleService.SimpleServiceClient())
            {
                string message = client.GetSignedAndEncryptedMessage();
                MessageBox.Show(message, "Message is signed and encrypted", MessageBoxButtons.OK);
            }
        }
    }
}
