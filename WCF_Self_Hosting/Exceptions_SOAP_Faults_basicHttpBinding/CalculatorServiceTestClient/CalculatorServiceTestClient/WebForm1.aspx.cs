using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace CalculatorServiceTestClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (CalculatorService.CalculatorServiceClient client = new CalculatorService.CalculatorServiceClient())
            {
                try
                {
                    int result = client.Devide(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
                    Label1.Text = result.ToString();
                }
                catch (FaultException faultException)
                {
                    Label1.Text = faultException.Message;
                }
            }
        }
    }
}