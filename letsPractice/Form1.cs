namespace letsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fName = textBox1.Text;
            string lName = textBox2.Text;
            string userName = fName + ' ' + lName;
            MessageBox.Show(userName, "I can guess your fullName and it is:");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}