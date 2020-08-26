namespace SandaliariaMontaImagem
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelLogoDandaliaria = new System.Windows.Forms.Panel();
            this.btLimparLista = new System.Windows.Forms.Button();
            this.lbPastaSaida = new System.Windows.Forms.Label();
            this.brPastaSaida = new System.Windows.Forms.Button();
            this.txPastaSaida = new System.Windows.Forms.TextBox();
            this.btProcessar = new System.Windows.Forms.Button();
            this.btCarregar2 = new System.Windows.Forms.Button();
            this.btCarregar1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbImagem2 = new System.Windows.Forms.PictureBox();
            this.lstbImagens = new System.Windows.Forms.ListBox();
            this.gbListaImagens = new System.Windows.Forms.GroupBox();
            this.panelBarraJanela = new System.Windows.Forms.Panel();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.lbTituloJanela = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem2)).BeginInit();
            this.gbListaImagens.SuspendLayout();
            this.panelBarraJanela.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelLogoDandaliaria);
            this.groupBox1.Controls.Add(this.btLimparLista);
            this.groupBox1.Controls.Add(this.lbPastaSaida);
            this.groupBox1.Controls.Add(this.brPastaSaida);
            this.groupBox1.Controls.Add(this.txPastaSaida);
            this.groupBox1.Controls.Add(this.btProcessar);
            this.groupBox1.Controls.Add(this.btCarregar2);
            this.groupBox1.Controls.Add(this.btCarregar1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROPIEDADES";
            // 
            // panelLogoDandaliaria
            // 
            this.panelLogoDandaliaria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogoDandaliaria.BackgroundImage")));
            this.panelLogoDandaliaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogoDandaliaria.Location = new System.Drawing.Point(12, 70);
            this.panelLogoDandaliaria.Name = "panelLogoDandaliaria";
            this.panelLogoDandaliaria.Size = new System.Drawing.Size(247, 72);
            this.panelLogoDandaliaria.TabIndex = 6;
            // 
            // btLimparLista
            // 
            this.btLimparLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLimparLista.FlatAppearance.BorderSize = 0;
            this.btLimparLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimparLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparLista.ForeColor = System.Drawing.Color.White;
            this.btLimparLista.Location = new System.Drawing.Point(189, 19);
            this.btLimparLista.Name = "btLimparLista";
            this.btLimparLista.Size = new System.Drawing.Size(149, 31);
            this.btLimparLista.TabIndex = 4;
            this.btLimparLista.Text = "LIMPAR LISTA";
            this.btLimparLista.UseVisualStyleBackColor = false;
            this.btLimparLista.Click += new System.EventHandler(this.btLimparLista_Click);
            // 
            // lbPastaSaida
            // 
            this.lbPastaSaida.AutoSize = true;
            this.lbPastaSaida.Location = new System.Drawing.Point(275, 117);
            this.lbPastaSaida.Name = "lbPastaSaida";
            this.lbPastaSaida.Size = new System.Drawing.Size(82, 13);
            this.lbPastaSaida.TabIndex = 5;
            this.lbPastaSaida.Text = "Pasta de saída:";
            // 
            // brPastaSaida
            // 
            this.brPastaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brPastaSaida.FlatAppearance.BorderSize = 0;
            this.brPastaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brPastaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brPastaSaida.ForeColor = System.Drawing.Color.White;
            this.brPastaSaida.Location = new System.Drawing.Point(606, 114);
            this.brPastaSaida.Name = "brPastaSaida";
            this.brPastaSaida.Size = new System.Drawing.Size(27, 20);
            this.brPastaSaida.TabIndex = 0;
            this.brPastaSaida.Text = "...";
            this.brPastaSaida.UseVisualStyleBackColor = false;
            this.brPastaSaida.Click += new System.EventHandler(this.brPastaSaida_Click);
            // 
            // txPastaSaida
            // 
            this.txPastaSaida.Enabled = false;
            this.txPastaSaida.Location = new System.Drawing.Point(363, 114);
            this.txPastaSaida.Name = "txPastaSaida";
            this.txPastaSaida.Size = new System.Drawing.Size(237, 20);
            this.txPastaSaida.TabIndex = 5;
            // 
            // btProcessar
            // 
            this.btProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btProcessar.FlatAppearance.BorderSize = 0;
            this.btProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessar.ForeColor = System.Drawing.Color.White;
            this.btProcessar.Location = new System.Drawing.Point(639, 103);
            this.btProcessar.Name = "btProcessar";
            this.btProcessar.Size = new System.Drawing.Size(149, 39);
            this.btProcessar.TabIndex = 3;
            this.btProcessar.Text = "PROCESSAR";
            this.btProcessar.UseVisualStyleBackColor = false;
            this.btProcessar.Click += new System.EventHandler(this.btProcessar_Click);
            // 
            // btCarregar2
            // 
            this.btCarregar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCarregar2.FlatAppearance.BorderSize = 0;
            this.btCarregar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCarregar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarregar2.ForeColor = System.Drawing.Color.White;
            this.btCarregar2.Location = new System.Drawing.Point(380, 19);
            this.btCarregar2.Name = "btCarregar2";
            this.btCarregar2.Size = new System.Drawing.Size(420, 31);
            this.btCarregar2.TabIndex = 2;
            this.btCarregar2.Text = "CARREGAR LOGO MARCA";
            this.btCarregar2.UseVisualStyleBackColor = false;
            this.btCarregar2.Click += new System.EventHandler(this.btCarregar2_Click);
            // 
            // btCarregar1
            // 
            this.btCarregar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCarregar1.FlatAppearance.BorderSize = 0;
            this.btCarregar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCarregar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarregar1.ForeColor = System.Drawing.Color.White;
            this.btCarregar1.Location = new System.Drawing.Point(34, 19);
            this.btCarregar1.Name = "btCarregar1";
            this.btCarregar1.Size = new System.Drawing.Size(149, 31);
            this.btCarregar1.TabIndex = 1;
            this.btCarregar1.Text = "CARREGAR IMAGENS";
            this.btCarregar1.UseVisualStyleBackColor = false;
            this.btCarregar1.Click += new System.EventHandler(this.btCarregar1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbImagem2);
            this.groupBox3.Location = new System.Drawing.Point(377, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 315);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LOGO MARCA";
            // 
            // pbImagem2
            // 
            this.pbImagem2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagem2.Location = new System.Drawing.Point(3, 16);
            this.pbImagem2.Name = "pbImagem2";
            this.pbImagem2.Size = new System.Drawing.Size(417, 296);
            this.pbImagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagem2.TabIndex = 0;
            this.pbImagem2.TabStop = false;
            // 
            // lstbImagens
            // 
            this.lstbImagens.BackColor = System.Drawing.Color.DarkGray;
            this.lstbImagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbImagens.FormattingEnabled = true;
            this.lstbImagens.Location = new System.Drawing.Point(3, 16);
            this.lstbImagens.Name = "lstbImagens";
            this.lstbImagens.Size = new System.Drawing.Size(365, 296);
            this.lstbImagens.TabIndex = 6;
            // 
            // gbListaImagens
            // 
            this.gbListaImagens.Controls.Add(this.lstbImagens);
            this.gbListaImagens.Location = new System.Drawing.Point(0, 25);
            this.gbListaImagens.Name = "gbListaImagens";
            this.gbListaImagens.Size = new System.Drawing.Size(371, 315);
            this.gbListaImagens.TabIndex = 6;
            this.gbListaImagens.TabStop = false;
            this.gbListaImagens.Text = "IMAGENS";
            // 
            // panelBarraJanela
            // 
            this.panelBarraJanela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBarraJanela.Controls.Add(this.btMinimizar);
            this.panelBarraJanela.Controls.Add(this.btFechar);
            this.panelBarraJanela.Controls.Add(this.lbTituloJanela);
            this.panelBarraJanela.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraJanela.Location = new System.Drawing.Point(0, 0);
            this.panelBarraJanela.Name = "panelBarraJanela";
            this.panelBarraJanela.Size = new System.Drawing.Size(800, 25);
            this.panelBarraJanela.TabIndex = 6;
            this.panelBarraJanela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraJanela_MouseMove);
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMinimizar.BackgroundImage")));
            this.btMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Location = new System.Drawing.Point(748, 0);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(23, 23);
            this.btMinimizar.TabIndex = 7;
            this.btMinimizar.UseVisualStyleBackColor = true;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFechar.BackgroundImage")));
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Location = new System.Drawing.Point(777, 0);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(23, 23);
            this.btFechar.TabIndex = 7;
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lbTituloJanela
            // 
            this.lbTituloJanela.AutoSize = true;
            this.lbTituloJanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloJanela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTituloJanela.Location = new System.Drawing.Point(12, 6);
            this.lbTituloJanela.Name = "lbTituloJanela";
            this.lbTituloJanela.Size = new System.Drawing.Size(174, 16);
            this.lbTituloJanela.TabIndex = 6;
            this.lbTituloJanela.Text = "Sandaliaria Logo Marca";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelBarraJanela);
            this.Controls.Add(this.gbListaImagens);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logo Marca Sandaliaria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem2)).EndInit();
            this.gbListaImagens.ResumeLayout(false);
            this.panelBarraJanela.ResumeLayout(false);
            this.panelBarraJanela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCarregar2;
        private System.Windows.Forms.Button btCarregar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbImagem2;
        private System.Windows.Forms.Button btProcessar;
        private System.Windows.Forms.ListBox lstbImagens;
        private System.Windows.Forms.GroupBox gbListaImagens;
        private System.Windows.Forms.TextBox txPastaSaida;
        private System.Windows.Forms.Label lbPastaSaida;
        private System.Windows.Forms.Button brPastaSaida;
        private System.Windows.Forms.Button btLimparLista;
        private System.Windows.Forms.Panel panelLogoDandaliaria;
        private System.Windows.Forms.Panel panelBarraJanela;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label lbTituloJanela;
    }
}

