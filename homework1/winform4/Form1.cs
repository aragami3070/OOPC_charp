namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Output.Text = "Лаб. раб. N1. Ст. гр. 251 Смирнов Е.И";
            x0Input.Text = "-1";
            XkInput.Text = "4";
            xdInput.Text = "0,5";
            bInput.Text = "2,3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.Text = "";
            try
            {
                double x0 = double.Parse(x0Input.Text);
                double xk = double.Parse(XkInput.Text);
                double xd = double.Parse(xdInput.Text);
                double b = double.Parse(bInput.Text);
                if (x0 >= (xk + xd) / 2)
                {
                    throw new Exception();
                }

                if (sender == button2)
                {
                    xd = xd / 2;
                }

                if (xd == 0)
                {
                    throw new DivideByZeroException();
                }
                double x = x0;
                while (x <= (xk + xd / 2))
                {
                    double y = 0.0025 * b * Math.Pow(x, 3) * Math.Sqrt(x + Math.Exp(0.82));
                    Output.Text += "x=" + Convert.ToString(x) +
                                     "; y=" + Convert.ToString(y)
                                     + Environment.NewLine;
                    x = x + xd;
                }

            }
            catch (DivideByZeroException)
            {
                Output.Text = "Ошибка: dx не может быть равно 0, иначе бесконечный цикл.";
            }
            catch (Exception)
            {
                Output.Text = "Ошибка: Не верный ввод(если число дробное, то вводим так 11,11) или слишком большой X0 или ошибка в вычислениях";
            }

        }
    }
}