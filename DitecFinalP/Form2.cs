using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace DitecFinalP
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True");
        SqlCommand com;

        public Form2()
        {
            InitializeComponent();
        }

        private void lblskill_Click(object sender, EventArgs e)
        {

        }

        private void btnreg_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string gender = radmale.Checked ? "Male" : "Female";
                string Sql = "insert into Registration (firstName,lastName,dateOfBirth,gender,address,email,mobilePhone,homePhone,parentName,nic,contactNo) values(' " + txtfn.Text + " ',' " + txtln.Text + " ',' " + dateTimePicker1.Text + " ',' " + gender + " ',' " + txtadd.Text + " ',' " + txtem.Text + " ',' " + txtmp.Text + " ',' " + txthp.Text + " ',' " + txtpn.Text + " ',' " + txtnic.Text + " ',' " + txtcn.Text + " ')";

                if (radmale.Checked)
                {
                    gender = "Male";

                }
                else if (radfemale.Checked)
                {
                    gender = "Female";
                }

                com = new SqlCommand(Sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record Added Succesfully");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            {
                con.Close();
            }

        }

        private void cborg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grpbasic_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cborg_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         


            try
            {
                con.Open();
                String SqlSelect = " select * from Registration where regNo = ' " + cborg.Text + " '";
                com = new SqlCommand(SqlSelect, con);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())

                {
                    txtfn.Text = dr[1].ToString();
                    txtln.Text = dr[2].ToString();
                    txtadd.Text = dr[5].ToString();
                    txtem.Text = dr[6].ToString();
                    txtmp.Text = dr[7].ToString();
                    txthp.Text = dr[8].ToString();
                    txtpn.Text = dr[9].ToString();
                    txtnic.Text = dr[10].ToString();
                    txtcn.Text = dr[11].ToString();
                    if (dr[4].ToString() == " Male ")
                    {
                        radmale.Checked = true;
                    }
                    else
                    {
                        radfemale.Checked = true;
                    }

                    dateTimePicker1.Text = dr[3].ToString();



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

        private void llbllog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlog f1 = new frmlog();
            this.Hide();
            f1.Show();
        }

        private void btncclearr_Click(object sender, EventArgs e)
        {
            txtfn.Text = " ";
            txtln.Text = " ";
            txtadd.Text = " ";
            txtem.Text = " ";
            txtmp.Text = " ";
            txthp.Text = " ";
            txtpn.Text = " ";
            txtnic.Text = " ";
            txtcn.Text = " ";
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            cborg.Text = " ";
            cborg.Focus();

        }

        private void btnupd_Click(object sender, EventArgs e)
        {


            try
            {
                con.Open();
                string gender = radmale.Checked ? "Male" : "Female";
                string SqlUpdate = "Update Registration set firstName = ' "+txtfn.Text+" ', lastName = ' "+txtln.Text+" ', dateOfBirth = ' "+dateTimePicker1.Text+" ', gender = ' "+gender+" ', address = ' "+txtadd.Text+" ', email = ' "+txtem.Text+" ', mobilePhone = ' "+txtmp.Text+" ', parentName = ' "+txtpn.Text+" ', nic = ' "+txtnic.Text+" ', contactNo = ' "+txtcn.Text+" ' where regNo = ' "+cborg.Text+" '";

                if (radmale.Checked)
                {
                    gender = "Male";

                }
                else if (radfemale.Checked)
                {
                    gender = "Female";
                }

                com = new SqlCommand(SqlUpdate, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record Updated Succesfully");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            {
                con.Close();
            }




        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (DialogResult.Yes == answer)
                {
                    con.Open();
                    string Sqldelete = "delete from Registration where regNo = ' " + cborg.Text + " '";
                    com = new SqlCommand(Sqldelete, con);
                    com.ExecuteNonQuery();
                    txtfn.Text = " ";
                    txtln.Text = " ";
                    txtadd.Text = " ";
                    txtem.Text = " ";
                    txtmp.Text = " ";
                    txthp.Text = " ";
                    txtpn.Text = " ";
                    txtnic.Text = " ";
                    txtcn.Text = " ";
                    dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
                    cborg.Text = " ";

                    cborg.Focus();
                    MessageBox.Show("Record Deleted Succesfully");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally{
                con.Close();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void llblexit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult answer = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
