namespace my_Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        clases.suma obj = new clases.suma();
        clases.multiplica obj2 = new clases.multiplica();
        clases.resta obj3 = new clases.resta();
        clases.divide obj4 = new clases.divide();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textBox1.Text);

            double sud;
            double res;
            double mult;
            double divi;

            switch (operador)
            {
                case "+":

                    sud = obj.sumar((primero), (segundo));
                    textBox1.Text = sud.ToString();
                    break;

                case "*":

                    mult = obj2.multiplicar((primero), (segundo));
                    textBox1.Text = mult.ToString();
                    break;

                case "-":

                    res = obj3.restar((primero), (segundo));
                    textBox1.Text = res.ToString();
                    break;

                case "/":

                    divi = obj4.divider((primero), (segundo));
                    textBox1.Text = divi.ToString();
                    break;

            }
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnmultiplica_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Yeral martinez";
            label1.Text = "Calculadora pro max";


        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}