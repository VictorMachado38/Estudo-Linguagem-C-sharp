using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Estudo
{
    public partial class Form1 : Form
    {
        StringReader leitura = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void italicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void Salvar()
        {
            try
            {
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter cfb_streamWriter = new StreamWriter(arquivo);
                    cfb_streamWriter.Flush();
                    cfb_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    cfb_streamWriter.Write(this.richTextBox1.Text);
                    cfb_streamWriter.Flush();
                    cfb_streamWriter.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void Abir()
        {
          //  this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.InitialDirectory = @"C:\Users\Machado\Desktop\";
            openFileDialog1.Filter = "Todos Arquivos(*.*)|*.*";
            // openFileDialog1
            /*  if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
              {

              }*/
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader cfb_StreamRedar = new StreamReader(arquivo);
                    cfb_StreamRedar.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = cfb_StreamRedar.ReadLine();
                    while(linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = cfb_StreamRedar.ReadLine();
                      
                    }
                    cfb_StreamRedar.Close();
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("Erro " + ex.Message, "Erro ao abrir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void brn_abrir_Click(object sender, EventArgs e)
        {
            Abir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abir();
        }
    }
        

}
