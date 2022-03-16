using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCode
{
    public partial class Form4 : Form
    {
        EmployeeEntities dbcontext = new EmployeeEntities();
        public Form4()
        {
            InitializeComponent();
        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //step 1
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Designation = txtDesig.Text;
                emp.Salary = Convert.ToDecimal(txtSal.Text);
                // step 2
                dbcontext.Employees.Add(emp);
                //step 3 reflect the changes to the DB
                int result = dbcontext.SaveChanges();
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
                Employee emp = dbcontext.Employees.Find(Convert.ToInt32(txtId.Text));
                if (emp != null)
                {
                    emp.Name = txtName.Text;
                    emp.Designation = txtDesig.Text;
                    emp.Salary = Convert.ToDecimal(txtSal.Text);
                    int result = dbcontext.SaveChanges();
                    if (result == 1)
                    {
                        MessageBox.Show("Record updated");
                    }
                }
                else
                {
                    MessageBox.Show("Emp id does not exsit");
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
                Employee emp = dbcontext.Employees.Find(Convert.ToInt32(txtId.Text));
                if (emp != null)
                {
                    txtName.Text = emp.Name;
                    txtDesig.Text = emp.Designation;
                    txtSal.Text = emp.Salary.ToString();
                }
                else
                {
                    MessageBox.Show("Emp id does not exsit");
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
                Employee emp = dbcontext.Employees.Find(Convert.ToInt32(txtId.Text));
                if (emp != null)
                {
                    dbcontext.Employees.Remove(emp);
                    dbcontext.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Emp id does not exsit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
