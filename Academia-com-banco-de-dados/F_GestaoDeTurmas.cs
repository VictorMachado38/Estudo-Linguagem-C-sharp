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
    public partial class F_GestaoDeTurmas : Form
    {
        string idSelecionado;
        public F_GestaoDeTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoDeTurmas_Load(object sender, EventArgs e)
        {
            string vquery = @"SELECT tbt.N_IDTURMA as 'ID' ,tbt.T_DSCTURMA as 'Turma',tbh.T_DSCHORARIO  as 'Horário da turma'
                FROM tb_turmas as tbt
                INNER JOIN
                tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO";
            dgv_turmas.DataSource = Banco.dql(vquery);
            dgv_turmas.Columns[0].Width = 40;
            dgv_turmas.Columns[1].Width = 120;
            dgv_turmas.Columns[2].Width = 120;

            //Popular professroes
            string vqueryProfessores = @"SELECT ID_PROFESSOR,T_NOMEPROFESSOR FROM tb_professores ORDER BY ID_PROFESSOR";
            cb_professores.Items.Clear();
            cb_professores.DataSource = Banco.dql(vqueryProfessores);
            cb_professores.DisplayMember = "T_NOMEPROFESSOR";
            cb_professores.ValueMember = "ID_PROFESSOR";

            //Popular ComboBox Status
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("P", "Paralizada");
            st.Add("C", "Cencelada");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st,null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            /*
            string vqueryStatus = @"SELECT T_STATUS,N_IDTURMA FROM tb_turmas";
            cb_status.DataSource = Banco.dql(vqueryStatus);
            cb_status.DisplayMember = "T_STATUS";
            cb_status.ValueMember = "N_IDTURMA";
            */

            //Popular combo box horarios
            string vqueryHorarios = @"SELECT * FROM tb_horarios ORDER BY T_DSCHORARIO";
            cb_horario.Items.Clear();
            cb_horario.DataSource = Banco.dql(vqueryHorarios);
            cb_horario.DisplayMember = "T_DSCHORARIO";
            cb_horario.ValueMember = "N_IDHORARIO";

         
            //Nome da turma





        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int count = dgv.SelectedRows.Count;
            if (count > 0)
            {
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"SELECT N_IDTURMA,N_IDPROFESSOR,N_IDHORARIO,N_MAXALUNOS,T_STATUS,T_DSCTURMA FROM tb_turmas WHERE N_IDTURMA =" + idSelecionado;
                DataTable dt = Banco.dql(vqueryCampos);
                cb_professores.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                n_maxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                tb_nomeTurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");

            }
            



        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            tb_nomeTurma.Clear();
            //cb_professores.Items.Clear();
            cb_professores.SelectedIndex = -1;
            n_maxAlunos.Value = 0;
            cb_horario.SelectedIndex = -1;
            cb_status.SelectedIndex = -1;

        }

        private void btn_salvarSalvaredicoes_Click(object sender, EventArgs e)
        {
            int linha = dgv_turmas.SelectedRows[0].Index;
            string queryAtualizarTurma = String.Format(@"
                 UPDATE tb_turmas SET T_DSCTURMA = '{0}',N_IDPROFESSOR= {1},N_IDHORARIO = {2}, N_MAXALUNOS= '{3}',T_STATUS = '{4}' WHERE N_IDTURMA = {5}",tb_nomeTurma.Text,
                 cb_professores.SelectedValue,cb_horario.SelectedValue,Int32.Parse(Math.Round(n_maxAlunos.Value,0).ToString()),cb_status.SelectedValue,idSelecionado);
            Banco.dml(queryAtualizarTurma);
            dgv_turmas[1, linha].Value = tb_nomeTurma.Text;
            dgv_turmas[2, linha].Value = cb_horario.Text;
            MessageBox.Show("Dados gravados");

        }

        private void btn_exluirTurma_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão","Excluir?",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string queryExcluirTurma = String.Format(@"DELETE FROM tb_turmas WHERE N_INDTURMA = {0}",idSelecionado);
                Banco.dml(queryExcluirTurma);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
            
          /*  DialogResult res = new DialogResult();
            res = ()
          */
        }
    }
}
