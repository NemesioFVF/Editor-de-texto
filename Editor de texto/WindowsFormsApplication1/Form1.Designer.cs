namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCrilOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.inserirDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaAltaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaBaixaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.letraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDaFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDeFundoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgFonte = new System.Windows.Forms.FontDialog();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.layoutToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCtrlNToolStripMenuItem,
            this.abrirCrilOToolStripMenuItem,
            this.salvarCtrlSToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripSeparator4,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // novoCtrlNToolStripMenuItem
            // 
            this.novoCtrlNToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.novoCtrlNToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.novoCtrlNToolStripMenuItem.Name = "novoCtrlNToolStripMenuItem";
            this.novoCtrlNToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoCtrlNToolStripMenuItem.Text = "Novo";
            this.novoCtrlNToolStripMenuItem.Click += new System.EventHandler(this.novoCtrlNToolStripMenuItem_Click);
            // 
            // abrirCrilOToolStripMenuItem
            // 
            this.abrirCrilOToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.abrirCrilOToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.abrirCrilOToolStripMenuItem.Name = "abrirCrilOToolStripMenuItem";
            this.abrirCrilOToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirCrilOToolStripMenuItem.Text = "Abrir";
            this.abrirCrilOToolStripMenuItem.Click += new System.EventHandler(this.abrirCrilOToolStripMenuItem_Click);
            // 
            // salvarCtrlSToolStripMenuItem
            // 
            this.salvarCtrlSToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.salvarCtrlSToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.salvarCtrlSToolStripMenuItem.Name = "salvarCtrlSToolStripMenuItem";
            this.salvarCtrlSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvarCtrlSToolStripMenuItem.Text = "Salvar Como";
            this.salvarCtrlSToolStripMenuItem.Click += new System.EventHandler(this.salvarCtrlSToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.Gray;
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.Gray;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.sairToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.recortarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.toolStripSeparator3,
            this.inserirDataToolStripMenuItem});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.copiarToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.colarToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.recortarToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.excluirToolStripMenuItem.Text = "Limpar Tudo";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // inserirDataToolStripMenuItem
            // 
            this.inserirDataToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.inserirDataToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.inserirDataToolStripMenuItem.Name = "inserirDataToolStripMenuItem";
            this.inserirDataToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.inserirDataToolStripMenuItem.Text = "Inserir Data e Hora";
            this.inserirDataToolStripMenuItem.Click += new System.EventHandler(this.inserirDataToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaAltaToolStripMenuItem1,
            this.caixaBaixaToolStripMenuItem1,
            this.toolStripSeparator2,
            this.letraToolStripMenuItem});
            this.formatarToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // caixaAltaToolStripMenuItem1
            // 
            this.caixaAltaToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.caixaAltaToolStripMenuItem1.ForeColor = System.Drawing.Color.Gray;
            this.caixaAltaToolStripMenuItem1.Name = "caixaAltaToolStripMenuItem1";
            this.caixaAltaToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.caixaAltaToolStripMenuItem1.Text = "Caixa Alta";
            this.caixaAltaToolStripMenuItem1.Click += new System.EventHandler(this.caixaAltaToolStripMenuItem1_Click);
            // 
            // caixaBaixaToolStripMenuItem1
            // 
            this.caixaBaixaToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.caixaBaixaToolStripMenuItem1.ForeColor = System.Drawing.Color.Gray;
            this.caixaBaixaToolStripMenuItem1.Name = "caixaBaixaToolStripMenuItem1";
            this.caixaBaixaToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.caixaBaixaToolStripMenuItem1.Text = "Caixa Baixa";
            this.caixaBaixaToolStripMenuItem1.Click += new System.EventHandler(this.caixaBaixaToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Gray;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(129, 6);
            // 
            // letraToolStripMenuItem
            // 
            this.letraToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.letraToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.letraToolStripMenuItem.Name = "letraToolStripMenuItem";
            this.letraToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.letraToolStripMenuItem.Text = "Fonte";
            this.letraToolStripMenuItem.Click += new System.EventHandler(this.letraToolStripMenuItem_Click);
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corDaFonteToolStripMenuItem,
            this.corDeFundoToolStripMenuItem1});
            this.layoutToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // corDaFonteToolStripMenuItem
            // 
            this.corDaFonteToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.corDaFonteToolStripMenuItem.Name = "corDaFonteToolStripMenuItem";
            this.corDaFonteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.corDaFonteToolStripMenuItem.Text = "Cor da Fonte";
            this.corDaFonteToolStripMenuItem.Click += new System.EventHandler(this.corDaFonteToolStripMenuItem_Click);
            // 
            // corDeFundoToolStripMenuItem1
            // 
            this.corDeFundoToolStripMenuItem1.ForeColor = System.Drawing.Color.Gray;
            this.corDeFundoToolStripMenuItem1.Name = "corDeFundoToolStripMenuItem1";
            this.corDeFundoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.corDeFundoToolStripMenuItem1.Text = "Cor de Fundo";
            this.corDeFundoToolStripMenuItem1.Click += new System.EventHandler(this.corDeFundoToolStripMenuItem1_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.Location = new System.Drawing.Point(0, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(496, 347);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_msg});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_msg
            // 
            this.status_msg.ForeColor = System.Drawing.Color.Gray;
            this.status_msg.Name = "status_msg";
            this.status_msg.Size = new System.Drawing.Size(103, 17);
            this.status_msg.Text = "Nome do arquivo:";
            this.status_msg.Click += new System.EventHandler(this.status_msg_Click);
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.DefaultExt = "txt";
            this.dlgAbrir.FileName = "openFileDialog1";
            this.dlgAbrir.Filter = "Arquivo texto|*.txt";
            // 
            // dlgSalvar
            // 
            this.dlgSalvar.DefaultExt = "txt";
            this.dlgSalvar.Filter = "Arquivo texto|*.txt";
            this.dlgSalvar.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgSalvar_FileOk);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(496, 396);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EDITOR DE TEXTO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCrilOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_msg;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.FontDialog dlgFonte;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaAltaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem caixaBaixaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserirDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corDeFundoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem corDaFonteToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;

    }
}

