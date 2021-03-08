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
    public partial class F_BancoDeDados : Form
    {
        public F_BancoDeDados()
        {
            InitializeComponent();
        }

        private void F_BancoDeDados_Load(object sender, EventArgs e)
        {
            string sqlqueryBando = "select tba.T_NOMEALUNO as 'Nome do aluno',tba.T_STATUS as 'Status',tbt.T_DSCTURMA as 'Turma',(select tbh.T_DSCHORARIO from tb_turmas as tbt inner join tb_horarios as tbh where tbh.N_IDHORARIO = tbt.N_IDHORARIO) as 'Hoario' from tb_alunos as tba inner join tb_turmas as tbt where tbt.N_IDTURMA = tba.N_IDTURMA ORDER BY tba.T_NOMEALUNO ASC";
            dgv_bandoDeDados.DataSource = Banco.dql(sqlqueryBando);
            dgv_bandoDeDados.Columns[0].Width = 150;
        }
    }
}
