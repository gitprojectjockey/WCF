using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorServiceTestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CalculatorService.CalculatorServiceClient client = new CalculatorService.CalculatorServiceClient())
            {
                try
                {
                    int result = client.Devide(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    label3.Text = result.ToString();
                }
                catch (System.ServiceModel.FaultException faultException)
                {
                    label3.Text = faultException.Message;
                }
            }
        }
    }
}
