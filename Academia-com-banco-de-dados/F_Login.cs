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
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            tb_username.Focus();
            //btn_logar.Focus();
            form1 = f;

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string usermanse = tb_username.Text;
            string senha = tb_senha.Text;

            if(usermanse == "")
            {
                MessageBox.Show("Usuario invalido");
                tb_username.Focus();
                return;
            }
            if (senha == "")
            {
                MessageBox.Show("Senha invalida");
                //tb_senha.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME='"+ usermanse+"'AND T_SENHAUSUARIO='"+senha+"'";
          //  MessageBox.Show("A CONTULTA QUE VAI SR FEITA VAI SER ASSIM "+sql);
            dt = Banco.consulta(sql);
            if(dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUSARIO");
                form1.pb_ledLogado.Image = Properties.Resources.led_verde;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontado");
                tb_username.Clear();
                tb_senha.Clear();
                tb_username.Focus();
            }


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            //form1.Close();
        }

        private void F_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void btn_logar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) 
            { 

             //  MessageBox.Show("Você apertou a tecla enter");

                // tb_senha.Focus();
            }
        }

        private void tb_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

            //    MessageBox.Show("Você apertou a tecla enter");
                               // tb_senha.Focus();
            }

        }

        private void F_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
