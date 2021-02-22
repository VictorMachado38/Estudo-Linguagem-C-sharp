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
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuario.DataSource = Banco.ObterUsuariosIdNome();
            dgv_usuario.Columns[0].Width = 70;
            dgv_usuario.Columns[1].Width = 280;
            //dgv_usuario.Columns[2].Width = 100;
        }

        private void dgv_usuario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dt = new DataTable();
                String vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
               // MessageBox.Show("A CONTULTA QUE VAI SR FEITA VAI SER ASSIM " + vid);
                dt = Banco.ObterDadosUsuario(vid);
                tb_id.Text = dt.Rows[0].Field < Int64 > ("N_IDUSUARIO").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO").ToString();
                nud_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");

            }
            
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salvalAlteracoes_Click(object sender, EventArgs e)
        {
            int linha = dgv_usuario.SelectedRows[0].Index;
            MessageBox.Show("Esta retornando a linha de número: "+linha);
            Usuario usuario = new Usuario();
            usuario.id = Convert.ToInt32(tb_id.Text);
            usuario.nome = tb_nome.Text;
            usuario.username = tb_senha.Text;
            usuario.senha = tb_senha.Text;
            usuario.status = cb_status.Text;
            usuario.nivel = Convert.ToInt32(nud_nivel.Value);
            //  usuario.nivel = Convert.ToInt32(Math.Round(nud_nivel.Value,0));

            Banco.AtualizarUsuario(usuario);
            //dgv_usuario.DataSource = Banco.ObterUsuariosIdNome();
            //dgv_usuario.CurrentCell = dgv_usuario[0,linha];
           // dgv_usuario[0, linha].Value = tb_id.Text; ESSE NÃO PRECISA POIS ELE É FIXO
            dgv_usuario[1, linha].Value = tb_nome.Text;



        }

        private void btn_novoUsuario_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            dgv_usuario.DataSource = Banco.ObterUsuariosIdNome();

        }

        private void btn_excluirUsuario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão ?","EXCLUIR! CUIDADO!!!!", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                Banco.DeletarUsuario(tb_id.Text);
                dgv_usuario.Rows.Remove(dgv_usuario.CurrentRow);
            }
        }

        private void dgv_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
