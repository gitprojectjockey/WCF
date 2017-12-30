using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace CalculatorServiceTestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            textBox3.Text = "A WCF service should be throwing a FaultException or FaultException<T> instead of Dot Net exceptions. This is because of the following 2 reasons.\r\n\r\n 1. An unhandled .NET exception will cause the channel between the client and the server to fault. Once the channel is in a faulted state we cannot use the client proxy anymore. We will have to re-create the proxy. We discussed this in Part 17 of the WCF tutorial. On the other hand faultexceptions will not cause the communication channel to fault. \r\n\r\n 2.  As .NET exceptions are platform specific, they can only be understood by a client that is also .NET. If you want the WCF service to be interoperable, then the service should be throwing FaultExceptions.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CalculatorService.CalculatorServiceClient client = new CalculatorService.CalculatorServiceClient())
            {
                try
                {
                    int result = client.Divide(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    label3.Text = result.ToString();
                }
                catch (FaultException<CalculatorService.DivideByZeroFault> faultException)
                {
                    label3.Text = faultException.Detail.Error + " - " + faultException.Detail.Details;
                }
            }
        }
    }
}
