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


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }
        public void gravar()
        {
            if (MessageBox.Show("Texto modificado. Deseja gravá-lo?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                dlgSalvar.ShowDialog();
                if (dlgSalvar.FileName != "")
                {
                    StreamWriter wr = new StreamWriter(dlgSalvar.FileName, true);
                    foreach (string linhas in richTextBox1.Lines)
                    {
                        wr.WriteLine(linhas);
                    }
                    wr.Close();
                    wr.Dispose();
                }
            }

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void novoCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gravar();
            richTextBox1.Clear();
            status_msg.Text = "Novo arquivo texto.";
        }

        private void salvarCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtem o nome do arquivo para salvar
                if (this.dlgSalvar.ShowDialog() == DialogResult.OK)
                {
                    //abre o stream para escrever e cria um StreamWriter para usar na implementacao do stream
                    FileStream fs = new FileStream(@dlgSalvar.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter m_streamWriter = new StreamWriter(fs);
                    m_streamWriter.Flush();

                    // Escreve o artigo usando a classe StreamWriter
                    m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);

                    // Escrever no controle rich edit control
                    m_streamWriter.Write(this.richTextBox1.Text);

                    // fecha o arquivo
                    m_streamWriter.Flush();
                    m_streamWriter.Close();
                    status_msg.Text = "Local do arquivo salvo: " + dlgSalvar.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Erro : " + status_msg.ToString());
            }
        }

        private void abrirCrilOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dlgAbrir.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(dlgAbrir.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader m_streamReader = new StreamReader(fs);
                    // Lendo para o arquivo usando a classe StreamReader

                    m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

                    // Lê cada linha do stream e efetua o parse até alcançar a última linha
                    this.richTextBox1.Text = "";
                    string linha = m_streamReader.ReadLine();
                    while (linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = m_streamReader.ReadLine();
                    }
                    //Fecha o Stream
                    m_streamReader.Close();
                    status_msg.Text = "Local do arquivo: " + dlgSalvar.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Erro : " + status_msg.ToString());
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Convert.ToString(DateTime.Now);
        }

        private void letraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgFonte.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = dlgFonte.Font;
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void caixaAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToString(richTextBox1.Text.ToUpper());
        }

        private void caixaBaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToString(richTextBox1.Text.ToLower());
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("       -----------------------------------------\n" +
                  "       ETEC VASCO ANTONIO VENCHIARUTT\n" +
                  "       -----------------------------------------\n" +
             "                           Desenvolvido por:\n" +
             "                 Nemésio Florence Vieira Filho\n\n" +
             "                  Com o auxílio da professora:\n" +
             "                         Cristiane Fernandes  \n" +
             "       -----------------------------------------\n" +
              "                       3º H - INFORMÁTICA\n" +
              "       -----------------------------------------", "SOBRE");

        }

        private void imprimirCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maiúscoloMiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void caixaAltaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToString(richTextBox1.Text.ToUpper());
        }

        private void caixaBaixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToString(richTextBox1.Text.ToLower());
        }

        private void inserirDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Convert.ToString(DateTime.Now);
        }

        private void status_msg_Click(object sender, EventArgs e)
        {

        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void corDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void corDeFundoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog fondo = new ColorDialog();
            if (fondo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = fondo.Color;
            }
        }

        private void corDaFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = color.Color;
            }
        }

        private void nnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dlgSalvar_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            StringReader leitor = new StringReader(texto);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //variaveis usadas para definir as configurações da impressão
            float linhasPorPagina = 0;
            float margemEsquerda = e.MarginBounds.Left;
            float margemSuperior = e.MarginBounds.Top;
            string linha = null;
            Font fonteImpressao = this.richTextBox1.Font;
            SolidBrush mCaneta = new SolidBrush(Color.Black);

            // Define o numero de linhas por pagina, usando MarginBounds.
            linhasPorPagina = e.MarginBounds.Height / fonteImpressao.GetHeight(e.Graphics);

            // Verifica se existe mais linhas para imprimir
            if (linha != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            //libera recursos		
            mCaneta.Dispose();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}