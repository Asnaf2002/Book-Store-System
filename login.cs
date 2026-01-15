using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_front
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = txtUS.Text.Trim();
            string pass = txtPS.Text.Trim();

            if (uname == "" || pass == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (uname == "admin" && pass == "1234")
            {
               // MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                book boo = new book();
                boo.Show();
                this.Hide();
            }
            else
             if (uname == "user" && pass == "12345")
            {
                // MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                user use= new user();
                use.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPS_TextChanged(object sender, EventArgs e)
        {
            txtPS.PasswordChar = '*';
        }

        private void txtUS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
