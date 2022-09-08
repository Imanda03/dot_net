using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shape shape = new ShapeProvider().GetShape("circle");
            MessageBox.Show("The area of circle is " + shape.Area().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shape rectangle = new ShapeProvider().GetShape("rectangle");
            MessageBox.Show("The area of rectangle is " + rectangle.Area().ToString());
        }
    }
}
