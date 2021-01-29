using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Timer : Form
    {
        float num;
        int px, py;
        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            num = 0;
            px = img_carro.Location.X;
            py = img_carro.Location.Y;
        }

        private void btn_iniciar_t1_Click(object sender, EventArgs e)
        {
           // timer1.Interval = 500;
            timer1.Start();
        }

        private void brn_para_t1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            timer1.Start();
        }

        private void btn_zerar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
        }

        private void but_iniciarCarro_Click(object sender, EventArgs e)
        {
            timer_carro.Start();
        }

        private void btn_pararCarro_Click(object sender, EventArgs e)
        {
            timer_carro.Stop();
        }

        private void timer_carro_Tick(object sender, EventArgs e)
        {
            px+=2;
            if (px >= 755)
            {
                px = -167;
            }
            img_carro.Location = new Point(px, py);
            px = img_carro.Location.X;
           
        }
    }
}
