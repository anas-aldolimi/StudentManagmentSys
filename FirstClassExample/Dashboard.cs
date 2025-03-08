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
    public partial class Dashboard : Form
    {
        // Setting the current form variable for use in functions
        private Form currentForm;



        public Dashboard()
        {
            InitializeComponent();
        }

        // Closing the application when the exit button is clicked
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        // Closing the application when the exit button inside the menu strip is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Return to the login screen when the logout button in the menu strip is clicked
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loginScreen = new Form1();
            this.Hide();
            loginScreen.Show();
            
        }
        //  Shows a message box about the application information
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a student management app \n Expect more features soon!");
        }

        //**************************************************
        // Start of the buttons logic
        private void AddStudent_Click(object sender, EventArgs e)
        {
            PanelContentReplacer(0);
        }

        private void ViewStudents_Click(object sender, EventArgs e)
        {
            PanelContentReplacer(1);
            MessageBox.Show("This feature is cominng soon");
        }

        private void SearchStudents_Click(object sender, EventArgs e)
        {
            PanelContentReplacer(2);
        }
        // End of button logic
        //*******************************************************


        // Custom function for replacing forms in the main panel
        // TODO: add a variable to pick the new layer when called
        private void PanelContentReplacer(int FormCode = 1)
        {
            Form form = null;
            // Removes the old form if there was one
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            // Set up the new form
            if(FormCode == 0)
            {
                form = new AddStudent();
            }
            else if (FormCode == 2)
            {
                form = new ManageStudent();
            }
            else
            {
                form = new ComingSoonForm();
            }
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Add and show the form in the content panel
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(form);
            form.Show();
        }

        
    }
}




