using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ESoft.EServices.Data
{
    public static class Employee
    {
        public static DataSet GetEmployeeManagersByBusinessEntity(int businessEntityID, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("uspGetEmployeeManagers", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BusinessEntityID", businessEntityID);
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
        }
    }
}
