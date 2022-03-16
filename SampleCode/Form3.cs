using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace SampleCode
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlCommandBuilder scb;
        DataSet ds;
        SqlDataAdapter da;
        public Form3()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server=SAUMYADIP\SQLEXPRESS;Database=Capgemini Training;Integrated Security=True");
        }
        public DataSet GetEmloyees()
        {
            // created DataSet object
            ds = new DataSet();
            // assign query to DataAdapter
            da = new SqlDataAdapter("select * from Employee", con);
            // fetch data from DB & store in the ds(object)
            // Emp is the table name we have given, DataTable name
            // add SqlCommandBuilder to track
            scb = new SqlCommandBuilder(da);
            // Add PK constraint to the Col in DataTable as well
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // Fill() implicitly open a connection with DB & once data fetched closed the connection
            da.Fill(ds, "Emp");
            return ds;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmloyees();
                DataRow row = ds.Tables["Emp"].NewRow();
                row["Id"] = txtId.Text;
                row["Name"] = txtName.Text;
                row["Designation"] = txtDesig.Text;
                row["Salary"] = txtSal.Text;
                ds.Tables["Emp"].Rows.Add(row);
                // update the chages from DataSet to DB
                int result = da.Update(ds.Tables["Emp"]);
                if (result == 1)
                {
                    MessageBox.Show("Record Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmloyees();
                DataRow row = ds.Tables["Emp"].Rows.Find(Convert.ToInt32(txtId.Text));
                if (row != null)
                {
                    row["Name"] = txtName.Text;
                    row["Designation"] = txtDesig.Text;
                    row["Salary"] = txtSal.Text;
                    int result = da.Update(ds.Tables["Emp"]);
                    if(result == 1)
                    {
                        MessageBox.Show("Record Updated");
                    }
                }
                else
                {
                    MessageBox.Show("Not found record to Update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmloyees();
                // Find() can only find data where you have applied PK
                DataRow row = ds.Tables["Emp"].Rows.Find(Convert.ToInt32(txtId.Text));
                if (row != null)
                {
                    txtName.Text = row["Name"].ToString();
                    txtDesig.Text = row["Designation"].ToString();
                    txtSal.Text = row["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show("Not found record");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmloyees();
                // Find() can only find data where you have applied PK
                DataRow row = ds.Tables["Emp"].Rows.Find(Convert.ToInt32(txtId.Text));
                if (row != null)
                {
                    ds.Tables["Emp"].Rows.Remove(row);
                    int result = da.Update(ds.Tables["Emp"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record updated");
                    }
                }
                else
                {
                    MessageBox.Show("Not found record to update");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
