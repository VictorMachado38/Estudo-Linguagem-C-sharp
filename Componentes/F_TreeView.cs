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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TreeNode raizEstados = treeView1.Nodes.Add("Estados");
            raizEstados.Name = "raizEstados";

                    TreeNode estado1 = raizEstados.Nodes.Add("GO");
                    estado1.Name = "Goias";

                    TreeNode estado2 = raizEstados.Nodes.Add("BR");
                    estado1.Name = "Brasiia - DF";

            TreeNode raizCores = treeView1.Nodes.Add("Cores");
            raizCores.Name = "raizCores";

           
                    TreeNode cor1 = raizCores.Nodes.Add("Preto");
                    cor1.Name = "Preto";

                    TreeNode cor2 = raizCores.Nodes.Add("Azul");
                    cor1.Name = "AZUL";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tb_treeview.Text = treeView1.SelectedNode.Text;
            if (treeView1.SelectedNode.Tag != null)
                tb_tag.Text = treeView1.SelectedNode.Tag.ToString();
            else
                tb_tag.Clear();
        }

        private void btn_removerSelecionado_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.Nodes["raizEstados"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao remover nó." + ex.ToString());
            }
        }
    }
}
