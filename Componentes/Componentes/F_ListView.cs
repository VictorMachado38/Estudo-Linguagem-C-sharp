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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }
        private void limpar()
        {
            tb_id.Clear();
            tb_produto.Clear();
            tb_qtde.Clear();
            tb_preco.Clear();
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {

            /*if (tb_id.Text == "" || tb_produto.Text == "" || tb_qtde.Text == "" || tb_preco.Text == "")
            {
                MessageBox.Show("Todos os campos tem que ser preenchidos");
            }
            */
            if (tb_id.Text == "")
            {
                MessageBox.Show("ID não pode ser vazo");
                tb_id.Focus();

            }
            if (tb_produto.Text == "")
            {
                MessageBox.Show("Produto não pode ser vazo");
                tb_produto.Focus();
            }
            if (tb_qtde.Text == "")
            {
                MessageBox.Show("Quantidade não pode ser vazo");
                tb_qtde.Focus();
            }
            if (tb_preco.Text == "")
            {
                MessageBox.Show("Preço não pode ser vazo");
                tb_preco.Focus();
            }
           
            else 
            { 
            string[] pr = new string[4];
            pr[0] = tb_id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_qtde.Text;
            pr[3] = "R$"+tb_preco.Text;
            ListViewItem l = new ListViewItem(pr);
            lv_produtos.Items.Add(l);
            tb_id.Focus();
            limpar();
            }
        }
    }
}
