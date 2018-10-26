namespace Farmacia.Forms
{
    partial class frmFornecedor
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
            this.gbFornece = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnGravaFornece = new System.Windows.Forms.Button();
            this.btnAttFornece = new System.Windows.Forms.Button();
            this.dadosFornecedor = new System.Windows.Forms.DataGridView();
            this.lblCadastrados = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbFornece.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFornece
            // 
            this.gbFornece.Controls.Add(this.txtNome);
            this.gbFornece.Controls.Add(this.txtDescricao);
            this.gbFornece.Controls.Add(this.txtCod);
            this.gbFornece.Controls.Add(this.lblCodigo);
            this.gbFornece.Controls.Add(this.lblNome);
            this.gbFornece.Controls.Add(this.lblDescricao);
            this.gbFornece.Controls.Add(this.btnGravaFornece);
            this.gbFornece.Location = new System.Drawing.Point(311, 6);
            this.gbFornece.Name = "gbFornece";
            this.gbFornece.Size = new System.Drawing.Size(471, 426);
            this.gbFornece.TabIndex = 7;
            this.gbFornece.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtDescricao.Location = new System.Drawing.Point(107, 58);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(358, 27);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtCod.Location = new System.Drawing.Point(107, 16);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(162, 27);
            this.txtCod.TabIndex = 3;
            this.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCodigo.Location = new System.Drawing.Point(6, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(72, 22);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblDescricao.Location = new System.Drawing.Point(6, 58);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(95, 22);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // btnGravaFornece
            // 
            this.btnGravaFornece.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnGravaFornece.Location = new System.Drawing.Point(344, 386);
            this.btnGravaFornece.Name = "btnGravaFornece";
            this.btnGravaFornece.Size = new System.Drawing.Size(121, 34);
            this.btnGravaFornece.TabIndex = 0;
            this.btnGravaFornece.Text = "Gravar";
            this.btnGravaFornece.UseVisualStyleBackColor = true;
            // 
            // btnAttFornece
            // 
            this.btnAttFornece.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAttFornece.Location = new System.Drawing.Point(6, 409);
            this.btnAttFornece.Name = "btnAttFornece";
            this.btnAttFornece.Size = new System.Drawing.Size(299, 32);
            this.btnAttFornece.TabIndex = 6;
            this.btnAttFornece.Text = "Atualizar Lista de Fornecedores";
            this.btnAttFornece.UseVisualStyleBackColor = true;
            // 
            // dadosFornecedor
            // 
            this.dadosFornecedor.AllowUserToAddRows = false;
            this.dadosFornecedor.AllowUserToDeleteRows = false;
            this.dadosFornecedor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dadosFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosFornecedor.Location = new System.Drawing.Point(6, 30);
            this.dadosFornecedor.Name = "dadosFornecedor";
            this.dadosFornecedor.ReadOnly = true;
            this.dadosFornecedor.Size = new System.Drawing.Size(299, 375);
            this.dadosFornecedor.TabIndex = 5;
            // 
            // lblCadastrados
            // 
            this.lblCadastrados.AutoSize = true;
            this.lblCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCadastrados.Location = new System.Drawing.Point(27, 3);
            this.lblCadastrados.Name = "lblCadastrados";
            this.lblCadastrados.Size = new System.Drawing.Size(244, 24);
            this.lblCadastrados.TabIndex = 4;
            this.lblCadastrados.Text = "Fornecedores Cadastrados:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblNome.Location = new System.Drawing.Point(6, 99);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 22);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNome.Location = new System.Drawing.Point(107, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(358, 27);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 444);
            this.Controls.Add(this.gbFornece);
            this.Controls.Add(this.btnAttFornece);
            this.Controls.Add(this.dadosFornecedor);
            this.Controls.Add(this.lblCadastrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.gbFornece.ResumeLayout(false);
            this.gbFornece.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFornece;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnGravaFornece;
        private System.Windows.Forms.Button btnAttFornece;
        private System.Windows.Forms.DataGridView dadosFornecedor;
        private System.Windows.Forms.Label lblCadastrados;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
    }
}