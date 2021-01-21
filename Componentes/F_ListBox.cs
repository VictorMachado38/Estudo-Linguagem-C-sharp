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
    public partial class F_ListBox : Form
    {
        //Implementeo o List Box
        List<string> carros = new List<string>();
        
        public F_ListBox()
        {
            InitializeComponent();
            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            lb_carros.DataSource = carros;

        }

        private void AtualizarListaCarror(ListBox lb, List<string> l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }

        private void F_ListBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_addCarro.Text == "")
            {
                MessageBox.Show("Digita um cara para adicionar!. =)");
                tb_addCarro.Focus();
            }
                
            else 
            {
                carros.Add(tb_addCarro.Text);
                tb_addCarro.Clear();
                tb_addCarro.Focus();
                AtualizarListaCarror(lb_carros, carros);

                
            }
        }

        private void tb_addCarro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                carros.RemoveAt(lb_carros.SelectedIndex);
                AtualizarListaCarror(lb_carros,carros);

            }

            catch
            {
                MessageBox.Show("Não tem nada para ser removido. \n"+"Ou você não selecionou.");
            }
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_addCarro.Text = carros[lb_carros.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            AtualizarListaCarror(lb_carros, carros);          
        }
    }
}
