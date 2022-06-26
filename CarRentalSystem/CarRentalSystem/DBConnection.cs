using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    class DBConnection
    {
        private static string DBConnectionString = @"Data Source =.\SQLEXPRESS;Initial Catalog = CarRentalSystem; Integrated Security = True";


        public static SqlConnection OpendbConnection()
        {

            SqlConnection sqlConnection = new SqlConnection();
            try

            {
                sqlConnection.ConnectionString = DBConnectionString;
                sqlConnection.Open();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return sqlConnection;
        }
    }
}
