using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstClassExample
{
    
    public partial class Form1 : Form
    {
        // Login credintials variables set
        private string tempUsername = "Admin";
        private string tempPassword = "123";
        
        
        public Form1()
        {
            InitializeComponent();
        }

        
        // Submit button code
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Simple check to see if both the username and password are correct
            if((txtUsername.Text == tempUsername) && (txtPassword.Text == tempPassword))
            {
                var form2 = new Dashboard();
                form2.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }

        }

       

        // Setting the password characters to appear as *
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        // Fully closing the application on exit
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
