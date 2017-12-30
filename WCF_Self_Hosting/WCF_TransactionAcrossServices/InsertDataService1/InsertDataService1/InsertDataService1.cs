using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;


namespace InsertDataService1
{
    public class InsertDataService1 : IInsertDataService1
    {
        [OperationBehavior(TransactionScopeRequired = true)]
        public void SetData(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("insert into dbo.Employee values('99999','WCF Transaction Test','M','Detroit')",conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
