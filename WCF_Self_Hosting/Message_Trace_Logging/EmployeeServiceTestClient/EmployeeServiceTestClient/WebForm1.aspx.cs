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
            if (IsPostBack) return;
            trAnnualSalary.Visible = false;
            trHourlyPay.Visible = false;
            trHoursWorked.Visible = false;
            trSetAnnualSalary.Visible = false;
            trSetHourlyPay.Visible = false;
            trSetHours.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient())
            {
                EmployeeService.Employee employee = new EmployeeService.Employee();
                employee = client.GetEmployee(Convert.ToInt32(txtEnterId.Text));

                txtId.Text = employee.Id.ToString();
                txtName.Text = employee.Name;
                txtGender.Text = employee.Gender;
                txtBirthDate.Text = employee.BirthDate.ToShortDateString();
                
                if (employee.Type == EmployeeService.EmployeePayType.FullTimeEmployee)
                {
                    txtType.Text = "Full Time";
                    txtSalary.Text = ((EmployeeService.FullTimeEmployee)employee).AnnualSalary.ToString();
                    trAnnualSalary.Visible = true;
                    trHourlyPay.Visible = false;
                    trHoursWorked.Visible = false;
                }
                else
                {
                    txtType.Text = "Part Time";
                    txtHourlyPay.Text = ((EmployeeService.PartTimeEmployee)employee).HourlyPay.ToString();
                    txtHoursWorked.Text = ((EmployeeService.PartTimeEmployee)employee).HoursWorked.ToString();
                    trAnnualSalary.Visible = false;
                    trHourlyPay.Visible = true;
                    trHoursWorked.Visible = true;
                }
            }
            lblGetStatus.Text = "Employee Recieved";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            if (ddlType.SelectedValue == "1")
            {
                using (EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient())
                {
                    EmployeeService.FullTimeEmployee employee = new EmployeeService.FullTimeEmployee();
                    employee.Id = Convert.ToInt32(txtSetId.Text);
                    employee.Name = txtSetName.Text;
                    employee.Gender = txtSetGender.Text;
                    employee.BirthDate = Convert.ToDateTime(txtSetBirthDate.Text);
                    employee.Type = ddlType.SelectedValue == "1" ? EmployeeService.EmployeePayType.FullTimeEmployee : EmployeeService.EmployeePayType.PartTimeEmployee;
                    employee.AnnualSalary = Convert.ToInt32(txtSetAnnualSalary.Text);
                    client.SetEmployee(employee);
                    lblSetStatus.Text = "Employee added.";
                }
            }
            else if (ddlType.SelectedValue == "2")
            {
                using (EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient())
                {
                    EmployeeService.PartTimeEmployee employee = new EmployeeService.PartTimeEmployee();
                    employee.Id = Convert.ToInt32(txtSetId.Text);
                    employee.Name = txtSetName.Text;
                    employee.Gender = txtSetGender.Text;
                    employee.BirthDate = Convert.ToDateTime(txtSetBirthDate.Text);
                    employee.Type = ddlType.SelectedValue == "1" ? EmployeeService.EmployeePayType.FullTimeEmployee : EmployeeService.EmployeePayType.PartTimeEmployee;
                    employee.HourlyPay = Convert.ToInt32(txtSetHourlyPay.Text);
                    employee.HoursWorked = Convert.ToInt32(txtSetHours.Text);
                    client.SetEmployee(employee);
                    lblSetStatus.Text = "Employee added.";
                }
            }
            else
            {
                lblSetStatus.Text = "Please select an employee type.";
            }
        }

        protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlType.SelectedValue == "-1")
            {
                trSetAnnualSalary.Visible = false;
                trSetHourlyPay.Visible = false;
                trSetHours.Visible = false;
            }
            else if (ddlType.SelectedValue == "1")
            {
                trSetAnnualSalary.Visible = true;
                trSetHourlyPay.Visible = false;
                trSetHours.Visible = false;
            }
            else
            {
                trSetAnnualSalary.Visible = false;
                trSetHourlyPay.Visible = true;
                trSetHours.Visible = true;
            }
        }
    }
}