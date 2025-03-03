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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            
            InitializeComponent();
            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InputStdAge_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                textBox2.Text = "";
            }
        }
    }
}
