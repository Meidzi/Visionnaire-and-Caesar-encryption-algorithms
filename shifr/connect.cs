using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace shifr
{
    internal class connect
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DELOREAN; Initial Catalog=shifr_words; Integrated Security=True");

        public void OpenConnection()
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlCon;
        }
    }
}
