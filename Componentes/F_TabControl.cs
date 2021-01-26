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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_tap_Click(object sender, EventArgs e)
        {
            add();
        }

        private void add()
        {
            if (tb_novaTab.Text != "")
            {
                TabPage pagina = new TabPage();
                pagina.Text = tb_novaTab.Text;
                pagina.Name = tb_novaTab.Text;
                pagina.TabIndex = tabControl1.TabPages.Count;

                if (cb_azul.Checked == true)
                {
                    pagina.BackColor = Color.Blue;
                }
                if (cb_preto.Checked == true)
                {
                    pagina.BackColor = Color.Black;
                }
                if (cb_branco.Checked == true)
                {
                    pagina.BackColor = Color.White;
                }
                if (cb_cinza.Checked == true)
                {
                    pagina.BackColor = Color.Gray;
                }
                if (cb_cinza.Checked == false & cb_branco.Checked == false & cb_preto.Checked == false & cb_azul.Checked == false)
                {
                    pagina.BackColor = Color.Orange;
                }



                tabControl1.TabPages.Add(pagina);
                // tb_novaTab.Clear();
                definirMaximo();
            }
            else
            {
                MessageBox.Show("Digire o nome da nova tab");
                tb_novaTab.Focus();
            }
        }

        private void btn_removerTab_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_tap_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void btn_removerTab_Click_1(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            definirMaximo();
        }

        private void tb_novaTab_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                add();
            }
        }

        private void F_TabControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                add();
            }
        }

        private void F_TabControl_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_posicioarTab_Click(object sender, EventArgs e)
        {

        }
        private void definirMaximo()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count;
        }

        private void F_TabControl_Load(object sender, EventArgs e)
        {
            definirMaximo();
        }

        private void btn_posicioarTab_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Int32.Parse(numericUpDown1.Value.ToString());
        }
    }
}
