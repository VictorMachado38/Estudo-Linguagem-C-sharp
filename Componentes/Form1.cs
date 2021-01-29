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
    //Meu inical 
    public partial class F_Principal : Form
    {
        public int num;

        public F_Principal()
        {
            InitializeComponent();
            num = 0;
            
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_veiculos.Text == "")
            {
                MessageBox.Show("DIGITA UM VEICULO");
                tb_veiculos.Focus();
                return;
            }

            tb_ListaVeiculos.Text += tb_veiculos.Text + ".\r\n";
            //tb_ListaVeiculos.Text += tb_veiculos.Text + ";\r\n";
            //tb_ListaVeiculos.Text = tb_ListaVeiculos.Text + tb_veiculos.Text;
            tb_veiculos.Clear();
            tb_veiculos.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_ListaVeiculos.Clear();
            tb_veiculos.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_ListaVeiculos.Text, this);
            f_Veiculos.ShowDialog();
        }

        private void bun_valNum_Click(object sender, EventArgs e)
        {

            MessageBox.Show(num.ToString());

        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();



            
        }

        private void chckListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_transportes acesso = new F_transportes();
            acesso.ShowDialog();


        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_comboBox a = new F_comboBox();
            a.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "tsmi_fechar")
            {
                this.Close();
            }
            else if(e.ClickedItem.Name.ToString() == "tsmi_restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "tsmi_mensagem")
            {
                MessageBox.Show("Curso de C#");
            }
        }

        private void dateTimerPickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimerPicker date = new F_DateTimerPicker();
            date.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox lb = new F_ListBox();
            lb.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView lv = new F_ListView();
            lv.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox mtb = new F_MaskedTextBox();
            mtb.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar mc = new F_MonthCalendar();
            mc.ShowDialog();
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown nud = new F_NumericUpDown();
            nud.ShowDialog();

        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox pb = new F_PictureBox();
            pb.ShowDialog();
        }

        private void progrssBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ProgressBar pb = new F_ProgressBar();
            pb.ShowDialog();
        }

        private void radiobuttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Radiobutton r = new F_Radiobutton();
            r.ShowDialog();
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TrackBar tb = new F_TrackBar();
            tb.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_TreeView tv = new F_TreeView();
            tv.ShowDialog();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            F_WebBrowser wb = new F_WebBrowser();
            wb.ShowDialog();
        }

        private void splitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_SplitContainer sc = new F_SplitContainer();
            sc.ShowDialog();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TabControl tb = new F_TabControl();
            tb.ShowDialog();
        }

        private void tableLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TableLayoutPanel tlp = new F_TableLayoutPanel();
            tlp.ShowDialog();
        }

        private void toolStripContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ToolStripContainer tsc = new F_ToolStripContainer();
            tsc.ShowDialog();
        }

        private void baclgroudWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_BackgroudWorker bw = new F_BackgroudWorker();
            bw.ShowDialog();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Timer t = new F_Timer();
            t.ShowDialog();
        }

        private void sQLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sQLiteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            F_SQLite f_SQLite = new F_SQLite();
            f_SQLite.ShowDialog();
        }
    }
}
