using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FirstClassExample
{
    public partial class AddStudent : Form
    {
        // global boolians used for checking if the inputs are valid
        bool isTextValid = false;
        bool isAgeValid = false;
        bool isClassValid = false;

        public AddStudent()
        {
            
            InitializeComponent();
            
        }
        
        // function to check if the course combobox is empty or not
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
                isClassValid = true;
            else
                isClassValid = false;
        }

        // function to check if the Name field is empty or not
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (IsNumeric(txtName.Text))
            {
                isTextValid = false;
                txtName.Text = "";
            }
            else if (txtName.Text != "")
            {
                isTextValid = true;
            }
            else
                isTextValid = false;
        }

        // function to stop the user from inputing strings that aren't numbers into the Age field and to set the isAgeValid boolean
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            string Age = "";

            if (!IsNumeric(txtAge.Text))
            {
                isAgeValid = false;
                txtAge.Text = "";
              
            }
            else if (IsNumeric(txtAge.Text) && txtAge.Text != "")
            {
                Age = txtAge.Text;
                int tempVar = Convert.ToInt16(Age);
                if ((tempVar < 18 || tempVar > 99))
                    {
                    isAgeValid = false;

                    }
                
            }

            else
                isAgeValid = true;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            
        }

        
        // function for submiting the information
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            

            // checking if all the boolians are true
            if (isAgeValid && isTextValid && isClassValid)
            {
                MessageBox.Show("Student Added");
            }
            else
            {
                ErrorChecks(isAgeValid, isTextValid, isClassValid);
                MessageBox.Show("Information Invalid");
            }
                
            
        }

        // function to check if multiple kinds of errors that might occur
        private void ErrorChecks (bool ageCheck, bool nameCheck, bool courseCheck)
        {
            if (!ageCheck)
            {
                var Age = txtAge.Text;
                int tempVar = Convert.ToInt16(Age);
                if (txtAge.Text == "")
                    lbAgeError.Text = "This field should not be empty";
                
                else if ((tempVar < 18 || tempVar > 99))
                {

                    lbAgeError.Text = "Please insert a valid age between 18 and 99";
                }
            }

            if (!nameCheck)
            {
                if (txtName.Text == "")
                    lbNameError.Text = "This field should not be empty";
            }
            if (!courseCheck)
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    lbCourseError.Text = "This field should not be empty";
                }
                else
                    lbCourseError.Text = "Please insert a valid input from the list";
            }
        }
        // a function that checks if an inputed string has a digit in it
        private bool IsNumeric(string input)
        {
            return input.All(char.IsDigit);
        }
    }
}
