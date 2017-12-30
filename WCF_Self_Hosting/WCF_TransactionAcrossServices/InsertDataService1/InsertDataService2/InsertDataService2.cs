using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace InsertDataService2
{
    public class InsertDataService2 : IInsertDataService2
    {
        public void SetData(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                int p = 1;
                int q = 0;
                int x = p / q;

                conn.Open();
                SqlCommand comm = new SqlCommand("insert into dbo.Employee values('88888','WCF Transaction Test','M','Detroit')", conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
