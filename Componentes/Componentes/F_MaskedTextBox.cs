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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                maskedTextBox3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                maskedTextBox3.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string msg = maskedTextBox3.Text;
            MessageBox.Show(msg);
        }

        private void btn_mostrarSenha_Click(object sender, EventArgs e)
        {
            
         /*   if(cb_mostrarSenha.Checked)
            {
                mtb_senha.PasswordChar.ToString();
             
            }
            else
            {
                mtb_senha.;
            }
         */
            
            string senha = mtb_senha.Text;
            MessageBox.Show(senha);
        }
    }
}
