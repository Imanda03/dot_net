using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WorldCup
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress01; Initial Catalog=WorldCup; Integrated Security=True");
            //  SqlCommand cmd = new SqlCommand("insert into Player values('" + textBox1.Text + "', '" + comboBox1.Text + "', " + Convert.ToInt32(comboBox2.Text) + ", 1)", conn);
            var sqldata = new SqlDataAdapter("select * from Player",conn);
            try
            {
                DataSet dataSet = new DataSet();
                sqldata.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch 
            {
                MessageBox.Show("Milya na fuchya");
            }
            }
    }
}
