using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                try
                {
                SalaryReportss salaryReportss = new SalaryReportss();
                    SqlConnection con = dbConnection.OpendbConnection();

                    if (con.State == ConnectionState.Open)
                    {
                    DataAdapter = new SqlDataAdapter(@" Select [ID]
           ([Salary]
           ,[EmpName])
           From [EmailRecords].[dbo].[salary] where [ID] like '" + button1.Text.Trim() + "'OR [Empname] like '" + button1.Text.Trim() + "' ", con);

                    dataTable.Clear();
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();

                    SalaryReportss.SetDatabaseLogon("fast", "fast");
                    SalaryReportss.SetDatabaseLogon(dataTable);

                    SalaryReportss.PrinttoPrinter(1, true, 0 , 0); 
                    con.Close();
                    con.Dispose();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());


                }
                //int RowIndex = DgpRecoeds.Rows.Add();
                //DgpRecoeds.Rows[RowIndex].Cells["Name"].Value = txt_name.Text;
                //DgpRecoeds.Rows[RowIndex].Cells["Section"].Value = txt_section.Text;
                //DgpRecoeds.Rows[RowIndex].Cells["Session"].Value = txt_session.Text;
                //DgpRecoeds.Rows[RowIndex].Cells["Roll_No"].Value = txt_rollno.Text;
                //DgpRecoeds.Rows[RowIndex].Cells["Cell_No"].Value = txtCellno.Text;
                //DgpRecoeds.Rows[RowIndex].Selected = true;
                //DgpRecoeds.Update();
            }


            else
            {
                MessageBox.Show("Please Fill all fields", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
        }
    }
}
