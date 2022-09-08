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
    public partial class DisplayStudent : Form
    {
        Student[] students = new Student[3];

        
        public DisplayStudent(Student[] students)
        {
            this.students = students;
            InitializeComponent();
        }

        private void DisplayStudent_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = students;
        }
    }
}
