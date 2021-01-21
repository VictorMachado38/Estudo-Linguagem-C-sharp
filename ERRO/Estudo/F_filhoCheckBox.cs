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
    public partial class F_filhoCheckBox : Form
    {
        public F_CheckBox fcb;
        public F_filhoCheckBox()
        {
            InitializeComponent();

            try 
            { 

                 fcb = Application.OpenForms["F_CheckBox"] as F_CheckBox;
                 cb_carro.Checked = fcb.cb_carro.Checked;
                 cb_avião.Checked = fcb.cb_avião.Checked;
                 cb_navio.Checked = fcb.cb_navio.Checked;
                 cb_onibus.Checked = fcb.cb_onibus.Checked;
            }
            
            catch
            {
                MessageBox.Show("Erro, o formulario não foi aberto");
            }
        }

        private void F_filhoCheckBox_Load(object sender, EventArgs e)
        {

        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_avião_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_avião.Checked = cb_avião.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_navio.Checked  = cb_navio.Checked;

        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_onibus.Checked = cb_onibus.Checked;
        }
    }
}
