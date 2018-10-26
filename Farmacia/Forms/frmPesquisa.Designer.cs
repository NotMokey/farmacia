namespace Farmacia.Forms
{
    partial class frmPesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblPesq = new System.Windows.Forms.Label();
            this.comboPesq = new System.Windows.Forms.ComboBox();
            this.dadosPesquisa = new System.Windows.Forms.DataGridView();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.btnExibir);
            this.gbFiltros.Controls.Add(this.btnPesquisar);
            this.gbFiltros.Controls.Add(this.lblPesq);
            this.gbFiltros.Controls.Add(this.comboPesq);
            this.gbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(368, 105);
            this.gbFiltros.TabIndex = 3;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros para Pesquisa";
            // 
            // btnExibir
            // 
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExibir.Location = new System.Drawing.Point(142, 60);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(220, 37);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "Exibir Detalhes";
            this.btnExibir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPesquisar.Location = new System.Drawing.Point(6, 60);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(130, 37);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblPesq
            // 
            this.lblPesq.AutoSize = true;
            this.lblPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPesq.Location = new System.Drawing.Point(5, 25);
            this.lblPesq.Name = "lblPesq";
            this.lblPesq.Size = new System.Drawing.Size(131, 24);
            this.lblPesq.TabIndex = 1;
            this.lblPesq.Text = "Pesquisar por:";
            // 
            // comboPesq
            // 
            this.comboPesq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboPesq.FormattingEnabled = true;
            this.comboPesq.Items.AddRange(new object[] {
            "Farmaceutico",
            "Funcionario",
            "Cliente",
            "Fornecedor",
            "Produtos"});
            this.comboPesq.Location = new System.Drawing.Point(142, 22);
            this.comboPesq.Name = "comboPesq";
            this.comboPesq.Size = new System.Drawing.Size(220, 32);
            this.comboPesq.TabIndex = 0;
            // 
            // dadosPesquisa
            // 
            this.dadosPesquisa.AllowUserToAddRows = false;
            this.dadosPesquisa.AllowUserToDeleteRows = false;
            this.dadosPesquisa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dadosPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosPesquisa.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dadosPesquisa.Location = new System.Drawing.Point(12, 134);
            this.dadosPesquisa.Name = "dadosPesquisa";
            this.dadosPesquisa.ReadOnly = true;
            this.dadosPesquisa.Size = new System.Drawing.Size(368, 320);
            this.dadosPesquisa.TabIndex = 2;
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 464);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.dadosPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblPesq;
        private System.Windows.Forms.ComboBox comboPesq;
        private System.Windows.Forms.DataGridView dadosPesquisa;
    }
}