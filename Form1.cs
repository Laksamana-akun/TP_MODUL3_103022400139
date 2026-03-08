namespace TP_MODUL3_103022400139
{
    public partial class Form1 : Form
    {
        double total = 0;
        bool tambah = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            total += Convert.ToDouble(lblOutput.Text);
            lblOutput.Text = total.ToString();
            total = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn4_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "4";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "9";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            total += Convert.ToDouble(lblOutput.Text);
            lblOutput.Text = "";
        }
    }
}
