using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    class dbConnection
    {

        private static string DBConnectionString = @"Data Source =.\SQLEXPRESS;Initial Catalog = FAST-University; Integrated Security = True";
        private static string DBOnlineConnectionString = @"Data Source =192.168.104.239,1433\\SQLEXPRESS UserCatalog;Initial Catalog = FAST-University; Integrated Security = True";


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

