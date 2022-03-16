using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SampleCode
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server=SAUMYADIP\SQLEXPRESS;Database=Capgemini Training;Integrated Security=True");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
         try
            {
                string qry = "select MAX(Id) from Employee";
                con.Open();
                cmd = new SqlCommand(qry, con);
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    txtId.Text = "1";
                }
                else
                {
                    int id = Convert.ToInt32(obj);
                    id++;
                    txtId.Text = id.ToString();
                }
                txtId.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Employee values(@id,@name,@design,@salary)";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@design", txtDesig.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtSal.Text));
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record saved successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesig_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Employee where Id=@id";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                dr = cmd.ExecuteReader();
                // if record is present HasRows returns true else false
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        txtName.Text = dr["Name"].ToString();
                        txtDesig.Text = dr["Designation"].ToString();
                        txtSal.Text = dr["Salary"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Employee where Id=@id";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                int result = Convert.ToInt32(cmd.ExecuteReader());
                
                if (result==1)
                {
                    
                MessageBox.Show("Record deleted succesfully");
                txtId.Clear();
                txtName.Clear();
                txtDesig.Clear();
                txtSal.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
