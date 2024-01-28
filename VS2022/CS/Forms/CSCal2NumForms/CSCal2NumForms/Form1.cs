namespace CSCal2NumForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tB1.Text);
            double b = Convert.ToDouble(tB2.Text);
            tB3.Text = (a + b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tB1.Text);
            double b = Convert.ToDouble(tB2.Text);
            tB3.Text = (a - b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tB1.Text);
            double b = Convert.ToDouble(tB2.Text);
            tB3.Text = (a * b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tB1.Text);
            double b = Convert.ToDouble(tB2.Text);
            tB3.Text = (a / b).ToString();
        }
    }
}