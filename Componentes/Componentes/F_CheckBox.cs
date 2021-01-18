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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            transp.Add(cb_carro);
            transp.Add(cb_avião);
            transp.Add(cb_navio);
            transp.Add(cb_onibus);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(CheckBox t in transp)
            {
                if(t.Checked)
                {
                    txt += t.Text + ", ";

                }
            }
          
            
            
            /* string txt = "";
             if (cb_carro.Checked)
             {
                 txt += cb_carro.Text + ", ";
             }
             if (cb_navio.Checked)
             {
                 txt += cb_navio.Text + ", ";
             }
             if (cb_avião.Checked)
             {
                 txt += cb_avião.Text + ", ";
             }
             if (cb_onibus.Checked)
             {
                 txt += cb_onibus.Text + ", ";
             }
             else
             {
                 MessageBox.Show("É para marcar o animal");
             }*/
            MessageBox.Show(txt);
            
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_patinete.Checked)
            {
                MessageBox.Show("Patinete marcado");
            }
            else
            {
                MessageBox.Show("Patinete demarcado");
            }
        }

        private void F_CheckBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            F_filhoCheckBox filho = new F_filhoCheckBox();
            filho.ShowDialog();
        }

        private void cb_avião_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
