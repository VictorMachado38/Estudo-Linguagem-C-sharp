using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia_com_banco_de_dados
{
    public partial class F_Login : Form
    {
        Form1 form1;
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string usermanse = tb_username.Text;
            string senha = tb_senha.Text;

            if(usermanse == "")
            {
                MessageBox.Show("Usuario invalido ");
                tb_username.Focus();
                return;
            }
            if (senha == "")
            {
                MessageBox.Show("Senha invalido ");
                tb_senha.Focus();
                return;
            }


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
