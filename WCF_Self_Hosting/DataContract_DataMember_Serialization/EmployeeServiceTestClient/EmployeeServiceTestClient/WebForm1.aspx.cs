using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeServiceTestClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient())
            {

                EmployeeService.Employee employee = new EmployeeService.Employee();

                


                employee = client.GetEmployee(1);
                TextBox1.Text = employee.Id.ToString();
                TextBox2.Text = employee.Name;
                TextBox3.Text = employee.Gender;
                TextBox4.Text = employee.BirthDate.ToShortDateString();
                TextBox5.Text = employee.Type == 0 ? "Hourly" : "Salary"; 
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient())
            {
                EmployeeService.Employee employee = new EmployeeService.Employee();
                employee.Id = Convert.ToInt32(TextBox7.Text);
                employee.Name = TextBox8.Text;
                employee.Gender = TextBox9.Text;
                employee.BirthDate = DateTime.Now;
                employee.Type = Convert.ToInt32(TextBox11.Text);
                

                client.SetEmployee(employee);
            }
        }
    }
}