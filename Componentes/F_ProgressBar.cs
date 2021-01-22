using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Componentes
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {

           // try
            //{
                if ((int.Parse(tb_progresso.Text) >= progressBar1.Minimum) & (int.Parse(tb_progresso.Text) <= progressBar1.Maximum))
                {
                    progressBar1.Value = int.Parse(tb_progresso.Text);
                }
            //}
           /* catch
            {
                MessageBox.Show("DIGITA ALGO MENOR DO QUE 101!");
            }*/
            
                 
            
            else if(int.Parse(tb_progresso.Text) > 100)
            {
                MessageBox.Show("DIGITA ALGO MENOR DO QUE 101!");
            }
            
        }

        private void btn_preencher_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for(int i = 0;  i<= progressBar1.Maximum; i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i;
                Thread.Sleep(int.Parse(tb_velocidade.Text));

            }

        }
    }
}
