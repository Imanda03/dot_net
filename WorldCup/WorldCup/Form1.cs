using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorldCup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> jersyNo = new List<int>();
            for(int i=1;i<=100; i++)
            {
                jersyNo.Add(i);
            }
            comboBox2.DataSource = jersyNo;
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress01; Initial Catalog=WorldCup; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Player values('"+textBox1.Text+"', '"+comboBox1.Text+"', "+Convert.ToInt32(comboBox2.Text)+", 1)",conn);
        try{
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("SuccessFully saved");
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
