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
    public partial class ManageStudent: Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }


        // A list for the students objects
        private List<Student> StudentList = new List<Student>();


        // STATIC DATA
        
        private void STATICDATA()
        {  
            //creating new student objects
         Student a = new Student()
        {
            NAME = "Ali",
            AGE = "18",
            COURSE = "CSC101",
            RD = "3/8/2025"
        };
        Student b = new Student()
        {
            NAME = "Muhammed",
            AGE = "22",
            COURSE = "CSC231",
            RD = "1/29/2025"
        };
            // Adding the student variables to the student list
            StudentList.Add(a);
            StudentList.Add(b);
        }
        
        
        


        // a function to display the students to the list view
        private void DisplayData(List<Student> temp)
        {
            foreach (Student student in temp)
            {
                string[] row1 = { student.NAME, student.AGE, student.RD, student.COURSE };
                var item1 = new ListViewItem(row1);
                listDisplayStudents.Items.Add(item1);
            }
        }

        // function that starts when the form is loaded. used to set the static data and display them
        private void ManageStudent_Load(object sender, EventArgs e)
        {
            STATICDATA();
            DisplayData(StudentList);
            
        }
        
        // function to filter the data based on the paramters
        private void Filters()
        {
           

            List<Student> FilteredStudents = new List<Student>();

            // check if the course combobox and the student name field are not empty
            if (CourseFilter.SelectedIndex != -1 || StudentNameFilter.Text != "")
            {
                // loop through every student in the normal student list
                foreach (Student student in StudentList)
                {
                    // check if the course combobox is not empty, and if the student course is equal to it, then check if if the student name contains text from the text field
                    if ((CourseFilter.SelectedIndex != -1 &&  student.COURSE == CourseFilter.SelectedItem.ToString()) && student.NAME.Contains(StudentNameFilter.Text))
                    {
                        // add the student to the filtered list if true
                        FilteredStudents.Add(student);
                    }
                    // check if the student name contains text from the name filter field and if the course combo box is empty
                    else if (student.NAME.Contains(StudentNameFilter.Text) && CourseFilter.SelectedIndex == -1)
                    {
                        // if the above is true add the student to the filter
                        FilteredStudents.Add(student);
                    }
                }
            }
            // if all the filters are empty, display the normal list
            else
                DisplayData(StudentList);

            // display filtered students
            DisplayData(FilteredStudents);

        }


        // filter students when the filter button is clicked
        private void btnFilter_Click(object sender, EventArgs e)
        {
            listDisplayStudents.Items.Clear();
            Filters();
        }

        // reset the filters when the reset button is clicked
        private void btnReset_Click(object sender, EventArgs e)
        {
            listDisplayStudents.Items.Clear();
            CourseFilter.SelectedIndex = -1;
            StudentNameFilter.Text = "";
            DisplayData(StudentList);
        }
    }
}
