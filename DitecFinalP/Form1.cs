using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DitecFinalP
{
    public partial class frmlog : Form
    {
        public frmlog()
        {
            InitializeComponent();
        }

        private void lblsi_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtun.Text == "Admin" && txtpass.Text == "Skills@123")
             {

                 Form2 f2 = new Form2();
                 this.Hide();
                 f2.Show();

             } 


             else { MessageBox.Show("Invalid Login credentials, please check Username and Password and try again","Invalid login Details",MessageBoxButtons.OK,MessageBoxIcon.Error); }
             

           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtun.Text =" ";
            txtpass.Text =" ";
            txtun.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure, Do you really want to Exit...?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

              if(answer == DialogResult.Yes)
             {
                 Application.Exit();
             }
        }

    }
}
