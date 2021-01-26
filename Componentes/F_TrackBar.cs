﻿using System;
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
    public partial class F_TrackBar : Form
    {
        public F_TrackBar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tb_valor.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();
        }

        private void btn_dafinir_Click(object sender, EventArgs e)
        {
           /* if (int.Parse(tb_valor.Text) >= 0 & int.Parse(tb_valor.Text) <= 100)
                trackBar1.Value = int.Parse(tb_valor.Text);
            else
                MessageBox.Show("Digite um número de 1 a 100");
           */

            if (int.Parse(tb_valor.Text) >= trackBar1.Minimum & int.Parse(tb_valor.Text) <= trackBar1.Maximum)
                trackBar1.Value = int.Parse(tb_valor.Text);
            else
            {
                MessageBox.Show("Digite um número de 1 a 100");
                tb_valor.Clear();
                tb_valor.Focus();
            }
                

        }
    }
}
