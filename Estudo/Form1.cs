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
            Italico();
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

        private void copiar()
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }

        }

        private void colar()
        {
            richTextBox1.Paste();
        }

        private void brn_copiar_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            colar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colar();
        }
        private void Negrito()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n,i,s = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;



            if (n == false)
            {
                if( i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
                
            }
            else
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte,  FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte,   FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte,   FontStyle.Italic);
                }
                
            }
        }
        private void Italico()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, u = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            u = richTextBox1.SelectionFont.Underline;



            if (i == false)
            {
                if (n == true & u == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Bold  | FontStyle.Underline);
                }
                else if (n == false & u == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic| FontStyle.Underline);
                }
                else if (n == true & u == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Italic);
                }
                else if (n == false & u == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }

            }
            else
            {
                if (n == true & u == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n== false & u == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else if (n == true & u == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
               
            }
        }
        private void Sublinahdo()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;



            if (s == false)
            {
                if (i == true & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic );
                }
                else if (i == false & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Bold );
                }
                else if (i == true & n == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Italic);
                }
                else if (i == false & n == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }

            }
            else
            {
                if (i == true & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Bold);
                }
                else if (i == false & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
                else if (i == true & n == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }

            }

        }
        private void brn_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void brn_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinahdo();
        }

        private void brn_sublinahdo_Click(object sender, EventArgs e)
        {
            Sublinahdo();
        }

        private void AlinhamentoDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void AlinhamentoEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void AlinhamentoCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btn_textoADireita_Click(object sender, EventArgs e)
        {
            AlinhamentoDireita();
        }

        private void btn_textoEsquerda_Click(object sender, EventArgs e)
        {
            AlinhamentoEsquerda();
        }

        private void brn_textoCentro_Click(object sender, EventArgs e)
        {
            AlinhamentoCentro();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinhamentoCentro();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinhamentoEsquerda();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinhamentoDireita();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void imprimir()
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            leitura = new StringReader(texto);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPaginas = 0;
            float PosY = 0;
            int cont = 0;
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;

            if (margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }
            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }
            string linha = null;

            Font font = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPaginas = e.MarginBounds.Height / font.GetHeight(e.Graphics);
            linha = leitura.ReadLine();
            while(cont < linhasPaginas)
            {
                PosY = (margemSuperior + (cont * font.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, font,pincel, margemEsquerda, PosY, new StringFormat());
                cont += 1;
                linha = leitura.ReadLine();
            }
            if(linha != null)
            {
                e.HasMorePages = true;

            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }
    }
        

}
