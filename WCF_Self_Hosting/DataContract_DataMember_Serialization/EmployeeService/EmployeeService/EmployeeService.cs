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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        public Employee GetEmployee(int Id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("WCF_GetEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", Id);
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataSet);

                Employee employee = dataSet.Tables[0].AsEnumerable().Select(r => new Employee 
                {
                    Id = (int)r["EmployeeID"],
                    Name = (string)r["Name"],
                    Gender=(string)r["Gender"],
                    BirthDate=(DateTime)r["BirthDate"],
                    Type=(int)r["Type"],
                    Salary = !r["Salary"].Equals(DBNull.Value) ? (int?)r["Salary"] : null,
                    HourlyPay = !r["HourlyPay"].Equals(DBNull.Value) ? (int?)r["HourlyPay"] : null,
                    Hours = !r["Hours"].Equals(DBNull.Value) ? (int?)r["Hours"] : null,
                }).Single();

                return employee;
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

                if (employee.Salary != null)
                {
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Salary", DBNull.Value);
                }

                if (employee.HourlyPay!= null)
                {
                    cmd.Parameters.AddWithValue("@HourlyPay", employee.HourlyPay);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@HourlyPay", DBNull.Value);
                }

                if (employee.Hours != null)
                {
                    cmd.Parameters.AddWithValue("@Hours", employee.Hours);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Hours", DBNull.Value);
                }
                cmd.ExecuteNonQuery();
            }
        }
    }
}
