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
    public partial class Form1 : Form
    {
       // Form1 form1;
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void abreForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("É necessario quer nivel minimo " + nivel);
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuário logado");
            }
        }

        private void loToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if(Globais.nivel >= 2)
                {

                }
                else
                {
                    MessageBox.Show("É necessario quer nivel minimo 2");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuário logado");
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            abreForm(1, f_NovoUsuario);
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
            abreForm(1, f_GestaoUsuarios);
           
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoAluno f_NovoAluno = new F_NovoAluno();
            abreForm(1, f_NovoAluno);
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            F_Horarios f_horarios = new F_Horarios();
            abreForm(2, f_horarios); 
            //NOVA ROTINA
            // f_horarios.ShowDialog();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoProfessores f_GestaoProfessores = new F_GestaoProfessores();
            abreForm(2, f_GestaoProfessores);
        }

        private void gestãoDeTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoDeTurmas f_GestaoDeTurmas = new F_GestaoDeTurmas();
            abreForm(3, f_GestaoDeTurmas);
        }
    }
}
