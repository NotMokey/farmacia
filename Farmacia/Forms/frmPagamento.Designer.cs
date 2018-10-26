namespace Farmacia.Forms
{
    partial class frmPagamento
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
            this.gbCadastroPag = new System.Windows.Forms.GroupBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gbListar = new System.Windows.Forms.GroupBox();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblFormasCads = new System.Windows.Forms.Label();
            this.dados = new System.Windows.Forms.DataGridView();
            this.gbCadastroPag.SuspendLayout();
            this.gbListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadastroPag
            // 
            this.gbCadastroPag.BackColor = System.Drawing.Color.Transparent;
            this.gbCadastroPag.Controls.Add(this.btnGravar);
            this.gbCadastroPag.Controls.Add(this.txtDesc);
            this.gbCadastroPag.Controls.Add(this.lblDesc);
            this.gbCadastroPag.Controls.Add(this.txtID);
            this.gbCadastroPag.Controls.Add(this.lblID);
            this.gbCadastroPag.Location = new System.Drawing.Point(408, 12);
            this.gbCadastroPag.Name = "gbCadastroPag";
            this.gbCadastroPag.Size = new System.Drawing.Size(438, 390);
            this.gbCadastroPag.TabIndex = 6;
            this.gbCadastroPag.TabStop = false;
            this.gbCadastroPag.Text = "Cadastrar - Editar";
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnGravar.Location = new System.Drawing.Point(293, 109);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(139, 40);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDesc.Location = new System.Drawing.Point(111, 64);
            this.txtDesc.MaxLength = 60;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(321, 29);
            this.txtDesc.TabIndex = 11;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDesc.Location = new System.Drawing.Point(6, 67);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(99, 24);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Descrição:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtID.Location = new System.Drawing.Point(111, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 29);
            this.txtID.TabIndex = 9;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblID.Location = new System.Drawing.Point(6, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 24);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID:";
            // 
            // gbListar
            // 
            this.gbListar.BackColor = System.Drawing.Color.Transparent;
            this.gbListar.Controls.Add(this.btnAtualiza);
            this.gbListar.Controls.Add(this.btnEditar);
            this.gbListar.Controls.Add(this.lblFormasCads);
            this.gbListar.Controls.Add(this.dados);
            this.gbListar.Location = new System.Drawing.Point(12, 12);
            this.gbListar.Name = "gbListar";
            this.gbListar.Size = new System.Drawing.Size(390, 390);
            this.gbListar.TabIndex = 7;
            this.gbListar.TabStop = false;
            this.gbListar.Text = "Buscar";
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAtualiza.Location = new System.Drawing.Point(246, 87);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(139, 39);
            this.btnAtualiza.TabIndex = 7;
            this.btnAtualiza.Text = "Atualizar Lista";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnEditar.Location = new System.Drawing.Point(245, 43);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 38);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblFormasCads
            // 
            this.lblFormasCads.AutoSize = true;
            this.lblFormasCads.BackColor = System.Drawing.Color.Transparent;
            this.lblFormasCads.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFormasCads.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFormasCads.Location = new System.Drawing.Point(31, 16);
            this.lblFormasCads.Name = "lblFormasCads";
            this.lblFormasCads.Size = new System.Drawing.Size(187, 24);
            this.lblFormasCads.TabIndex = 5;
            this.lblFormasCads.Text = "Formas Cadastradas:";
            // 
            // dados
            // 
            this.dados.AllowUserToAddRows = false;
            this.dados.AllowUserToDeleteRows = false;
            this.dados.BackgroundColor = System.Drawing.Color.White;
            this.dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dados.Location = new System.Drawing.Point(9, 43);
            this.dados.Name = "dados";
            this.dados.ReadOnly = true;
            this.dados.Size = new System.Drawing.Size(231, 341);
            this.dados.TabIndex = 4;
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 411);
            this.Controls.Add(this.gbCadastroPag);
            this.Controls.Add(this.gbListar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formas de Pagamento";
            this.gbCadastroPag.ResumeLayout(false);
            this.gbCadastroPag.PerformLayout();
            this.gbListar.ResumeLayout(false);
            this.gbListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastroPag;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbListar;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblFormasCads;
        private System.Windows.Forms.DataGridView dados;
    }
}