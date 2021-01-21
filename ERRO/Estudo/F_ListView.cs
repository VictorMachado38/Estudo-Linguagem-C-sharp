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
        
        private void obter()
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {

            /*if (tb_id.Text == "" || tb_produto.Text == "" || 
             * tb_qtde.Text == "" || tb_preco.Text == "")
            {
                MessageBox.Show("Todos os campos tem que ser preenchidos");
            }
            */
            if (tb_id.Text == "")
            {
                MessageBox.Show("ID não pode ser vazo");
                tb_id.Focus();
                return;
            }
            if (tb_produto.Text == "")
            {
                MessageBox.Show("Produto não pode ser vazo");
                tb_produto.Focus();
                return;
            }
            if (tb_qtde.Text == "")
            {
                MessageBox.Show("Quantidade não pode ser vazo");
                tb_qtde.Focus();
                return;
            }
            if (tb_preco.Text == "")
            {
                MessageBox.Show("Preço não pode ser vazo");
                tb_preco.Focus();
                return;
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

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;

        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(lv_produtos.SelectedItems.Count > 0)
            {
                // MessageBox.Show(lv_produtos.SelectedIndices[0].ToString());
                obter();
            }
           


            /*
            try
            {
                tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
                tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
                tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
                tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;

            }
            catch
            {
                MessageBox.Show("Ixi");
            }
            */


        }
    }
}
