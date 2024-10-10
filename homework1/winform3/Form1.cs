namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            output.Text = string.Empty;
            try
            {
                output.Text = "Лаб. раб. N1. Ст. гр. 251 Смирнов Е.И";
                double x = double.Parse(textBox1.Text);
                if (x > 236)
                {
                    throw new DivideByZeroException();
                }
                double p = double.Parse(textBox2.Text);
                double fx;
                double res;

                if (check1.Checked)
                {
                    fx = (Math.Exp(x) - Math.Exp(-x)) / 2;
                }
                else if (check2.Checked)
                {
                    fx = x * x;
                }
                else
                {
                     fx = Math.Exp(x);
                }

                if (x > Math.Abs(p))
                {
                    res = 2 * Math.Pow(fx, 3) + 3 * Math.Pow(p, 3);
                }
                else if (3 <x && x < Math.Abs(p))
                {
                    res = Math.Abs(fx - p);
                }
                else if (x ==  Math.Abs(p))
                {
                    res = Math.Pow(fx - p, 2);
                }
                else
                {
                    throw new Exception();
                }

                output.Text = Environment.NewLine + "X = " + x.ToString()
                    + Environment.NewLine + "P = " + p.ToString()
                    + Environment.NewLine + "f(x) = " + fx.ToString()
                    + Environment.NewLine + "Result = " + res.ToString();
            }
            catch (DivideByZeroException)
            {
                output.Text = "Ошибка: Деление на ноль из-за слишком большого числа X";
            }
            catch (Exception)
            {
                output.Text = "Ошибка: Не прошло ни одно из условий или не правильный ввод (напиши число нормально, если дробное, то запись  такая: 11,11)";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            output.Text = string.Empty;
        }
    }
}