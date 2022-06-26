using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StudentManagment : Form
    {
        public StudentManagment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        int RowIndex;
        private void button2_Click(object sender, EventArgs e)                // Delete  Button click ! 
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row ?", " Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            if (dialogResult == DialogResult.Yes)
            {
                DgpRecoeds.Rows.RemoveAt(RowIndex);
                DgpRecoeds.Update();
                DgpRecoeds.Refresh();


            }

        }

        private void DgpRecoeds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        static SqlDataReader dataReader;
        static SqlDataAdapter dataAdaptor;
        static DataSet dataSet;
        static DataTable dataTable;
        static SqlCommand sqlCommand;
        static SqlTransaction sqlTransaction;
        private object studentsTableAdaptor;
        private object _FAST_university;

        DataTable GetStudents()
        {

            try
            {
                SqlConnection con = dbConnection.OpendbConnection();

                if (con.State == ConnectionState.Open)
                {
                    

                    dataAdaptor = new SqlDataAdapter(@" SELECT  [Roll Number]
      ,[Name]
      ,[Section]
      ,[Session]
      ,[Cell_no]
  FROM[FAST - University].[dbo].[students]", con);


                    dataAdaptor.Fill(dataTable);
                    dataAdaptor.Dispose();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }

            return dataTable;


        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != string.Empty && txt_section.Text != string.Empty && txt_session.Text != string.Empty && txt_rollno.Text != string.Empty && txtCellno.Text != string.Empty)
            {

                try
                {
                    SqlConnection con = dbConnection.OpendbConnection();

                    if (con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(  @"   INSERT INTO [FAST-University].[dbo].[students]
           ([Roll Number]
           ,[Name]
           ,[Section]
           ,[Session]
           ,[Cell_no])
     VALUES
           (" + txt_rollno.Text + ", '" + txt_name.Text + "' , '" + txt_section.Text + "', '" + txt_session.Text + "' ,'" + txtCellno.Text + "'); ", con);

                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                        con.Close();

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
                MessageBox.Show("Please Fill all fields", "Field Required",MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
        }

        private void DgpRecoeds_Click(object sender, EventArgs e)
        {
           
        }

        private void DgpRecoeds_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {


                if (e.RowIndex >= 0)
                {
                    
                    RowIndex = e.RowIndex;
                    txt_name.Text = DgpRecoeds.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    txt_section.Text = DgpRecoeds.Rows[e.RowIndex].Cells["Section"].Value.ToString();
                    txt_session.Text = DgpRecoeds.Rows[e.RowIndex].Cells["Session"].Value.ToString();
                    txt_rollno.Text = DgpRecoeds.Rows[e.RowIndex].Cells["Roll_no"].Value.ToString();
                    txtCellno.Text = DgpRecoeds.Rows[e.RowIndex].Cells["Cell_no"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {


                DgpRecoeds.Rows[RowIndex].Cells["Name"].Value = txt_name.Text;
                DgpRecoeds.Rows[RowIndex].Cells["Section"].Value = txt_section.Text;
                DgpRecoeds.Rows[RowIndex].Cells["Session"].Value = txt_session.Text;
                DgpRecoeds.Rows[RowIndex].Cells["Roll_No"].Value = txt_rollno.Text;
                DgpRecoeds.Rows[RowIndex].Cells["Cell_No"].Value = txtCellno.Text;
                DgpRecoeds.Rows[RowIndex].Selected = true;
                DgpRecoeds.Update();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void StudentManagment_Load(object sender, EventArgs e)
        {
          //  this.studentsTableAdaptor.Fill(this._FAST_UniversityDataSet.Students);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
    }

