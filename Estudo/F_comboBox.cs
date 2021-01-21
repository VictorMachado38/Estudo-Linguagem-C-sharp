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
    public partial class F_comboBox : Form
    {
        public F_comboBox()
        {
            InitializeComponent();
        }

        private void F_comboBox_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string txt = tb_novoTransporte.Text;
            
            if(tb_novoTransporte.Text != "")
            {
                if(cb_transportes.FindString(tb_novoTransporte.Text)<0)
                cb_transportes.Items.Add(tb_novoTransporte.Text);

            }
            
            
            
           // cb_transportes.Text += 
        }

        private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);

        }

        private void btn_limparElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void btn_rezetarElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();

            List<string> rezet = new List<string>();
            rezet.Add("Carro");
            rezet.Add("Avião");
            rezet.Add("Navio");
            rezet.Add("Ônibus");
            rezet.Add("Trem");

            cb_transportes.Items.AddRange(rezet.ToArray());

        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_novoTransporte.Text = cb_transportes.Text;
        }
    }
}
