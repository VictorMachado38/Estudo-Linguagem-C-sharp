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
    public partial class F_GestaoProfessores : Form
    {
        public F_GestaoProfessores()
        {
            InitializeComponent();
        }

        private void F_GestaoProfessores_Load(object sender, EventArgs e)
        {
            
            string vquery;

            vquery = @"SELECT ID_PROFESSOR as 'ID Professor',T_NOMEPROFESSOR as 'Nome professor',T_TELEFONE as Telefone from tb_professores ORDER BY T_NOMEPROFESSOR DESC";
            dgv_professores.DataSource = Banco.dql(vquery);
            dgv_professores.Columns[0].Width = 75;
            dgv_professores.Columns[1].Width = 254;
            dgv_professores.Columns[2].Width = 100;

        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                String vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                            SELECT * FROM tb_professores
                                    WHERE ID_PROFESSOR =                                       
                        " + vid;
                //MessageBox.Show("A CONTULTA QUE VAI SR FEITA VAI SER ASSIM "+vquery+vid);
                dt = Banco.dql(vquery);

                tb_idProfessores.Text = dt.Rows[0].Field<Int64>("ID_PROFESSOR").ToString();
                tb_professores.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR");
                mtb_dscHoario.Text = dt.Rows[0].Field<string>("T_TELEFONE");

              /*  tb_idHorario.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                mtb_dscHoario.Text = dt.Rows[0].Field<string>("T_DSCHORARIO");
              */

            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novoHorario_Click(object sender, EventArgs e)
        {
            tb_idProfessores.Clear();
            tb_professores.Clear();
            mtb_dscHoario.Clear();
        }

        private void btn_exluirHorario_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes) 
            {
                //DataTable dt = new DataTable();
                //String vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                            DELETE  FROM tb_professores
                                    WHERE ID_PROFESSOR =                                       
                        " + tb_idProfessores.Text;
                //MessageBox.Show("A CONTULTA QUE VAI SR FEITA VAI SER ASSIM "+vquery+vid);
                Banco.dql(vquery);

                tb_idProfessores.Clear();
                tb_professores.Clear();
                mtb_dscHoario.Clear();
                
                dgv_professores.Rows.Remove(dgv_professores.CurrentRow);


            }

        }

        private void btn_salvarHorario_Click(object sender, EventArgs e)
        {
            if(tb_idProfessores.Text == "")
            {
                string vquery = @"INSERT INTO tb_professores (T_NOMEPROFESSOR,T_TELEFONE) VALUES ('"+tb_professores.Text+"','"+mtb_dscHoario.Text+"') ";
                Banco.dql(vquery);
                dgv_professores.DataSource = Banco.atualizaProfessor();
            }
            else
            {
                string vquery = @"UPDATE tb_professores SET T_NOMEPROFESSOR = '"+tb_professores.Text+"',T_TELEFONE = '"+mtb_dscHoario.Text+"'  WHERE ID_PROFESSOR = '"+tb_idProfessores.Text+"'";
                Banco.dql(vquery);
                dgv_professores.DataSource = Banco.atualizaProfessor();

            }
        }
    }
}
