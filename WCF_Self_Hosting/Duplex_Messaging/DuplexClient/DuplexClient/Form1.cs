using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplexClient
{

    //NOTE NOTE NOTE: the implementation of the ReportService call back contract
    public partial class Form1 : Form, ReportService.IReportServiceCallback
    {
        ReportService.ReportServiceClient client = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessReport_Click(object sender, EventArgs e)
        {
            //Do not use a USING or it will shut down the comm channel before all the events have been raised back to the client
            InstanceContext instanceContext = new InstanceContext(this);
            client = new ReportService.ReportServiceClient(instanceContext);
            client.ProcessReport();
        }

        public void Progress(int percentComplete)
        {
            txtPercent.Text = string.Format("Report process is {0} percent complete", percentComplete);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //NOTE NOTE NOTE
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null && client.State == System.ServiceModel.CommunicationState.Opened)
            {
                client.Close();
            }
        }
    }
}
