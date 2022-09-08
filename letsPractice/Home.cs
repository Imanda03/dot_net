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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addStudents adStudent = new addStudents();
            adStudent.Show();
        }
    }
}