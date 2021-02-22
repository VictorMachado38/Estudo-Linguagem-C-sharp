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
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
              SELECT 
                    N_IDHORARIO as 'ID Horário',
                    T_DSCHORARIO as 'Horário'
                FROM 
                    tb_horarios

            ";
            dgv_horarios.DataSource = Banco.dql(vquery);
            dgv_horarios.Columns[0].Width = 150;
            dgv_horarios.Columns[1].Width = 200;

        }
    }
}
