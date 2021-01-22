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
    public partial class F_Radiobutton : Form
    {
        public F_Radiobutton()
        {
            InitializeComponent();
        }

        private void btn_selecionado_Click(object sender, EventArgs e)
        {
            string txt = "";
            txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            tb_selecionado.Text = txt;
            MessageBox.Show(txt);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "Não foi atribuido ainda";

            foreach (RadioButton rb in groupBox1.Controls)
            {
                if(rb.Checked)
                {
                    txt = rb.Text;
                }

            }

            MessageBox.Show(txt);
        }
    }
}
