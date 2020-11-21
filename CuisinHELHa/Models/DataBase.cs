using System;
using System.Data;
using System.Data.SqlClient;

namespace CuisinHELHa.Models
{
    public class DataBase
    {
        // TODO - PUT CONNECTION_STRING HERE
        
        public static SqlConnection GetConnection(){
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            return connection;
        }
    }
}