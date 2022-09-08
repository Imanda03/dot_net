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
    public partial class GraphicText : Form
    {
        public GraphicText()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Point point = new Point(350, 200);
            button1.Location = point;
        }
    }
}
