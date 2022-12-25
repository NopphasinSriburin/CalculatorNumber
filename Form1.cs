namespace Number
{
    public partial class Form1 : Form
    {
        double input1 =  0;
        double result = 0;
        string opertion = "";
        string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtNumber.Text = this.txtNumber.Text + "1";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            this.txtNumber.Text = this.txtNumber.Text + "6";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            this.txtNumber.Text = this.txtNumber.Text + "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            this.txtNumber.Text = this.txtNumber.Text + "3";
        }
        private void B4_Click(object sender, EventArgs e)
        {
            this.txtNumber.Text = this.txtNumber.Text + "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            this.txtNumber.Text = this.txtNumber.Text + "5";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            this.txtNumber.Text = this.txtNumber.Text + "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            this.txtNumber.Text = this.txtNumber.Text + "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            this.txtNumber.Text = this.txtNumber.Text + "9";
        }

        private void Bouk_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.txtNumber.Text);
            this.txtNumber.Text = "";
            this.opertion = "-";
            this.label1.Text = input1.ToString()+opertion;
        }

        private void Textbox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.txtNumber.Text = "";
            this.label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtNumber.Text = this.txtNumber.Text + ".";
        }

        private void หาร_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.txtNumber.Text);
            this.txtNumber.Text = "";
            this.opertion = "/";
            this.label1.Text = input1 + opertion.ToString();
            this.label1.Text = input1.ToString("#,###.00");
        }

        private void บวก_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.txtNumber.Text);
            this.txtNumber.Text = "";
            this.opertion = "+";
            this.label1.Text = input1 + opertion.ToString();
            this.label1.Text = input1.ToString("#,###.00");
        }

        private void คูณ_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.txtNumber.Text);
            this.txtNumber.Text = "";
            this.opertion = "*";
            this.label1.Text = input1 + opertion.ToString();
            this.label1.Text = input1.ToString("#,###.00");
        }

        private void เท่ากับ_Click(object sender, EventArgs e)
        {
            double input2 = Double.Parse(this.txtNumber.Text);

            if (this.opertion == "+")
            {
                result = input1 + input2;
                this.txtNumber.Text = result.ToString("#,###.00");

            }
            else if (this.opertion == "-")
            {
                result = input1 - input2;
                this.txtNumber.Text = result.ToString("#,###.00");

            }
            else if (this.opertion == "*")
            {
                result = input1 * input2;
                this.txtNumber.Text = result.ToString("#,###.00");

            }
            else if (this.opertion == "/")
            {
                result = input1 / input2;
                this.txtNumber.Text = result.ToString("#,###.00");

            }
            string s = input1.ToString("#,###.00");
            string d = input2.ToString("#,###.00");
            this.label1.Text = s + opertion + d;




        }

        private void B0_Click(object sender, EventArgs e)
        {
            this.txtNumber.Text = this.txtNumber.Text + "0";
        }

        private void Shownumber_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.txtNumber.Text);
             this.txtNumber.Text = input1.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }
    }
}