namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "182,5";
            maskedTextBox2.Text = "18,225";
            maskedTextBox3.Text = "-0,03298";
            Output.Text = "Лаб. раб. N1. Ст. гр. 251 Смирнов Е.И";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.Text = "Лаб. раб. N1. Ст. гр. 251 Смирнов Е.И";
            try
            {
                double x = double.Parse(maskedTextBox1.Text);
                double y = double.Parse(maskedTextBox2.Text);
                double z = double.Parse(maskedTextBox3.Text);

                double res = Math.Abs(Math.Pow(x, (y / x)) - Math.Pow((y / x), 1.0 / 3)) +
                    (y - x) * (Math.Cos(y) - z / (y - x)) / (1 + ((y - x) * (y - x)));

                if ((x == 0) || (y - x == 0))
                {
                    throw new DivideByZeroException();
                }
                else if (y / x < 0)
                {
                    throw new Exception();
                }
                Output.Text += Environment.NewLine + "X = " + x.ToString() +
                    Environment.NewLine + "Y = " + y.ToString() +
                    Environment.NewLine + "Z = " + z.ToString() +
                    Environment.NewLine + "Result = " + res.ToString();
            }
            catch (DivideByZeroException)
            {
                Output.Text += Environment.NewLine + "Ошибка: деление на ноль";
            }
            catch (Exception)
            {
                Output.Text += Environment.NewLine + "Ошибка: не верный ввод (дробь нужно вводить так: 11,11) или отрицательный корень";
            }

        }
    }
}