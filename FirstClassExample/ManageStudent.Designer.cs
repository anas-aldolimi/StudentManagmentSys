namespace FirstClassExample
{
    partial class ManageStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listDisplayStudents = new System.Windows.Forms.ListView();
            this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegistrationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.CourseFilter = new System.Windows.Forms.ComboBox();
            this.StudentNameFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDisplayStudents
            // 
            this.listDisplayStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentName,
            this.Age,
            this.RegistrationDate,
            this.Course});
            this.listDisplayStudents.HideSelection = false;
            this.listDisplayStudents.Location = new System.Drawing.Point(12, 97);
            this.listDisplayStudents.Name = "listDisplayStudents";
            this.listDisplayStudents.Size = new System.Drawing.Size(405, 230);
            this.listDisplayStudents.TabIndex = 0;
            this.listDisplayStudents.UseCompatibleStateImageBehavior = false;
            this.listDisplayStudents.View = System.Windows.Forms.View.Details;
            // 
            // StudentName
            // 
            this.StudentName.Text = "Name";
            this.StudentName.Width = 100;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 100;
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.Text = "Registration Date";
            this.RegistrationDate.Width = 100;
            // 
            // Course
            // 
            this.Course.Text = "Course";
            this.Course.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filters:";
            // 
            // CourseFilter
            // 
            this.CourseFilter.FormattingEnabled = true;
            this.CourseFilter.Items.AddRange(new object[] {
            "CSC101",
            "CSC231"});
            this.CourseFilter.Location = new System.Drawing.Point(116, 39);
            this.CourseFilter.Name = "CourseFilter";
            this.CourseFilter.Size = new System.Drawing.Size(121, 21);
            this.CourseFilter.TabIndex = 2;
            // 
            // StudentNameFilter
            // 
            this.StudentNameFilter.AccessibleName = "";
            this.StudentNameFilter.Location = new System.Drawing.Point(116, 13);
            this.StudentNameFilter.Name = "StudentNameFilter";
            this.StudentNameFilter.Size = new System.Drawing.Size(121, 20);
            this.StudentNameFilter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentNameFilter);
            this.Controls.Add(this.CourseFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDisplayStudents);
            this.Name = "ManageStudent";
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listDisplayStudents;
        private System.Windows.Forms.ColumnHeader StudentName;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader RegistrationDate;
        private System.Windows.Forms.ColumnHeader Course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CourseFilter;
        private System.Windows.Forms.TextBox StudentNameFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}