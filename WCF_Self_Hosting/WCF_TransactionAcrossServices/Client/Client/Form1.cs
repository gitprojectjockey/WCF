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
            try
            {
                string connectionString = @connectionString = "Data Source=XPS;Initial Catalog=DemoData;Integrated Security=true";

                using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required))
                {
                    InsertDataServiceOne.InsertDataService1Client clientOne = new InsertDataServiceOne.InsertDataService1Client();
                    clientOne.SetData(connectionString);

                    //you can also have the error on the client side and transaction control will flow from the client to the server. Wow!
                    //int p = 1;
                    //int q = 0;
                    //int x = p / q;


                    //This service will throw an exception at the service implementation level which will make the first service role back its data. Wow!
                    InsertDataServiceTwo.InsertDataService2Client clientTwo = new InsertDataServiceTwo.InsertDataService2Client();
                    clientTwo.SetData(connectionString);
                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
                string x = ex.Message;
            }

        }
    }
}
