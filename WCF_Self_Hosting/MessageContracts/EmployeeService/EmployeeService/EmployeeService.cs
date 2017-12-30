using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeResponseObject GetEmployee(EmployeeRequestObject employeeRequest)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
            {
                string key = employeeRequest.LicenceKey;

                connection.Open();
                SqlCommand command = new SqlCommand("WCF_GetEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", employeeRequest.EmployeeID);
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataSet);

                Employee employee = null;

                if ((int)dataSet.Tables[0].Rows[0]["Type"] == (int)Employee.PayType.FullTimeEmployee)
                {
                    employee = dataSet.Tables[0].AsEnumerable().Select(r => new FullTimeEmployee
                    {
                        Id = (int)r["EmployeeID"],
                        Name = (string)r["Name"],
                        Gender = (string)r["Gender"],
                        BirthDate = (DateTime)r["BirthDate"],
                        Type = Employee.PayType.FullTimeEmployee,
                        AnnualSalary = !r["Salary"].Equals(DBNull.Value) ? (int?)r["Salary"] : null
                    }).Single();
                }
                else
                {
                    employee = dataSet.Tables[0].AsEnumerable().Select(r => new PartTimeEmployee
                    {
                        Id = (int)r["EmployeeID"],
                        Name = (string)r["Name"],
                        Gender = (string)r["Gender"],
                        BirthDate = (DateTime)r["BirthDate"],
                        Type = Employee.PayType.PartTimeEmployee,
                        HourlyPay = !r["HourlyPay"].Equals(DBNull.Value) ? (int?)r["HourlyPay"] : null,
                        HoursWorked = !r["Hours"].Equals(DBNull.Value) ? (int?)r["Hours"] : null,
                    }).Single();
                }
                return new EmployeeResponseObject(employee);
            }
        }

        public void SetEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("WCF_SetEmployee", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", employee.Id);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                cmd.Parameters.AddWithValue("@BirthDate", employee.BirthDate);
                cmd.Parameters.AddWithValue("@Type", employee.Type);

                if (employee.GetType() == typeof(FullTimeEmployee))
                {
                    cmd.Parameters.AddWithValue("@Salary", ((FullTimeEmployee)employee).AnnualSalary);
                    cmd.Parameters.AddWithValue("@HourlyPay", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Hours", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Salary", DBNull.Value);
                    cmd.Parameters.AddWithValue("@HourlyPay", ((PartTimeEmployee)employee).HourlyPay);
                    cmd.Parameters.AddWithValue("@Hours", ((PartTimeEmployee)employee).HoursWorked);
                }

                cmd.ExecuteNonQuery();
            }
        }
    }
}