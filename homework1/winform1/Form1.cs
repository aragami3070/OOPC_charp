using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){

        }
        private void Form1_Click(object sender, EventArgs e){
            // включаем все кнопки
            btn1.Enabled = true; 
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            //btn1.Text = sender.ToString();
            btn1.Text = "You can click me)";
            btn2.Text = "You can click me)";
            btn3.Text = "You can click me)";
            btn4.Text = "You can click me)";
        }
        
        private void btn1_Click(object sender, EventArgs e){
            // выключаю следующую кнопку
            btn2.Enabled = false;
            btn2.Text = "You can't click me(";
        }

        private void btn2_Click(object sender, EventArgs e){
            // выключаю следующую кнопку
            btn3.Enabled = false;
            btn3.Text = "You can't click me(";
        }

        private void btn3_Click(object sender, EventArgs e){
            // выключаю следующую кнопку
            btn4.Enabled = false;
            btn4.Text = "You can't click me(";
        }

        private void btn4_Click(object sender, EventArgs e){
            // выключаю следующую кнопку
            btn1.Enabled = false;
            btn1.Text = "You can't click me(";
        }
    }
}
