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
    public partial class F_SelecionarTurma : Form
    {
        F_NovoAluno formNovoAluno;
        public F_SelecionarTurma(F_NovoAluno f)
        {
            InitializeComponent();
            formNovoAluno = f;
        }

        private void F_SelecionarTurma_Load(object sender, EventArgs e)

        {
            string queryTurma = @"SELECT tbt.N_IDTURMA as 'ID Turma',tbt.T_DSCTURMA as 'Desc. turma',tbh.T_DSCHORARIO as 'Turma',tbp.T_NOMEPROFESSOR as 'Professor', (SELECT count(N_IDALUNOS) FROM tb_alunos as tba WHERE tba.N_IDTURMA = tbt.N_IDTURMA and T_STATUS = 'A') as 'Qtde. Alunos', tbt.N_MAXALUNOS as 'Qtde. Max. Alunos' from 
                                tb_turmas as tbt
                                INNER JOIN 
                                tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR,
                                tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO";
            dgv_selecionarTurma.DataSource = Banco.dql(queryTurma);
            dgv_selecionarTurma.Columns[0].Width = 50;
            dgv_selecionarTurma.Columns[5].Width = 120;
            dgv_selecionarTurma.Columns[3].Width = 230;
        }
    }
}
