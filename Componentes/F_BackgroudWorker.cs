﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_BackgroudWorker : Form
    {
        int cont = 0;
        int max = 1000;
        public F_BackgroudWorker()
        {
            InitializeComponent();

        }

        private void F_BackgroudWorker_Load(object sender, EventArgs e)
        {
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i=0; i<max; i++)
            {
                cont ++;
                backgroundWorker1.ReportProgress(100);
                Thread.Sleep(10);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Trabalho terminado");
            label1.Text = "Terminado";
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = "W1 Trabalhando";
            label2.Text = cont.ToString();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            
        }
    }
}
