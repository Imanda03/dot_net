using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace letsPractice
{
    public partial class addStudents : Form
    {
            int index = 0;
            Student[] students = new Student[3];
        public addStudents()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = textBox1.Text;
            student.Address = textBox2.Text;
            student.Email = textBox3.Text;
            students[index] = student;
            index++;
            MessageBox.Show("Great Job!!");
            textBox1.Text = String.Empty;  //Textbox1 ma empty gardinxa
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayStudent displayStudent = new DisplayStudent(students);
            displayStudent.Show();
            //displayStudent.students = students; yesto lekda mathi ko students hataunya mathi kata ho kata public raknya
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
