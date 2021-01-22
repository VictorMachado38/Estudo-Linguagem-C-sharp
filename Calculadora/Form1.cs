using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void multiplica (int a, int b)
        {
            tb_aegumento1.Text = a.ToString();
            tb_aegumento2.Text = b.ToString();
            int result = a * b;
            tb_resultado.Text = result.ToString();

        }
        private void divide (int a, int b)
        {
            tb_aegumento1.Text = a.ToString();
            tb_aegumento2.Text = b.ToString();
            int result = a / b;
            tb_resultado.Text = result.ToString();

        }
        private void adicao(int a, int b)
        {
            tb_aegumento1.Text = a.ToString();
            tb_aegumento2.Text = b.ToString();
            int result = a + b;
            tb_resultado.Text = result.ToString();

        }
        private void subtracao(int a, int b)
        {
            tb_aegumento1.Text = a.ToString();
            tb_aegumento2.Text = b.ToString();
            int result = a - b;
            tb_resultado.Text = result.ToString();

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            /*tb_aegumento1.Text = "1";
            int a;
            a = 1;
            */
            if (tb_aegumento1.Text == "")
            {
                tb_aegumento1.Text = "1";
                int a;
                a = 1;
            }
            else
            {
                tb_aegumento2.Text = "1";
                int a;
                a = 1;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            /*tb_aegumento2.Text = "2";
            int b;
            b = 2;*/
            if (tb_aegumento1.Text == "")
            {
                tb_aegumento1.Text = "2";
                int b;
                b = 2;
            }
            else
            {
                tb_aegumento2.Text = "2";
                int b;
                b = 2;
            }
        }
          
        private void btn_3_Click(object sender, EventArgs e)
        {
            if(tb_aegumento1.Text == "")
            {
                tb_aegumento1.Text = "3";
                int c;
                c = 3;
            }
            else 
            {
                tb_aegumento2.Text = "3";
                int c;
                c = 3;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (tb_aegumento1.Text == "")
            {
                tb_aegumento1.Text = "4";
                int d;
                d = 4;
            }
            else
            {
                tb_aegumento2.Text = "4";
                int d;
                d = 3;
            }
        }
             
        private void btn_5_Click(object sender, EventArgs e)
        {
            if (tb_aegumento1.Text == "")
            {
                tb_aegumento1.Text = "5";
                int a;
                a = 5;
            }
            else
            {
                tb_aegumento2.Text = "5";
                int a;
                a = 5;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (tb_aegumento1.Text == "")
            {
                tb_aegumento1.Text = "6";
                int a;
                a = 6;
            }
            else
            {
                tb_aegumento2.Text = "6";
                int a;
                a = 6;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (tb_aegumento1.Text == "")
            {
                tb_aegumento1.Text = "7";
                int a;
                a = 7;
            }
            else
            {
                tb_aegumento2.Text = "7";
                int a;
                a = 7;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (tb_aegumento1.Text == "")
            {
                tb_aegumento1.Text = "8";
                int a;
                a = 8;
            }
            else
            {
                tb_aegumento2.Text = "8";
                int a;
                a = 8;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (tb_aegumento1.Text == "")
            {
                tb_aegumento1.Text = "9";
                int a;
                a = 9;
            }
            else
            {
                tb_aegumento2.Text = "9";
                int a;
                a = 9;
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (tb_aegumento1.Text == "")
            {
                tb_aegumento1.Text = "0";
                int a;
                a = 0;
            }
            else
            {
                tb_aegumento2.Text = "0";
                int a;
                a = 0;
            }
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            l_operacao.Text = "X";
            multiplica(int.Parse(tb_aegumento1.Text), int.Parse(tb_aegumento2.Text));
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            l_operacao.Text = "/";
            divide(int.Parse(tb_aegumento1.Text), int.Parse(tb_aegumento2.Text));
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_aegumento1.Clear();
            tb_aegumento2.Clear();
            l_operacao.Text = "";
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            l_operacao.Text = "+";
            adicao(int.Parse(tb_aegumento1.Text), int.Parse(tb_aegumento2.Text));
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            l_operacao.Text = "-";
            subtracao(int.Parse(tb_aegumento1.Text), int.Parse(tb_aegumento2.Text));
        }
    }
    
}
