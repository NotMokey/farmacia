namespace Farmacia.Forms
{
    partial class frmPessoa
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
            this.gbBasico = new System.Windows.Forms.GroupBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.lblNasc = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.chBoxAuto = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dadosPesquisaPessoa = new System.Windows.Forms.DataGridView();
            this.btnPesq = new System.Windows.Forms.Button();
            this.gbBasico.SuspendLayout();
            this.gbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosPesquisaPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBasico
            // 
            this.gbBasico.Controls.Add(this.btnGravar);
            this.gbBasico.Controls.Add(this.mskData);
            this.gbBasico.Controls.Add(this.lblNasc);
            this.gbBasico.Controls.Add(this.mskCPF);
            this.gbBasico.Controls.Add(this.lblCpf);
            this.gbBasico.Controls.Add(this.txtEndereco);
            this.gbBasico.Controls.Add(this.lblEndereco);
            this.gbBasico.Controls.Add(this.txtNome);
            this.gbBasico.Controls.Add(this.lblNome);
            this.gbBasico.Location = new System.Drawing.Point(12, 12);
            this.gbBasico.Name = "gbBasico";
            this.gbBasico.Size = new System.Drawing.Size(425, 403);
            this.gbBasico.TabIndex = 10;
            this.gbBasico.TabStop = false;
            this.gbBasico.Text = "Dados básicos";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(314, 370);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(98, 27);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // mskData
            // 
            this.mskData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mskData.Location = new System.Drawing.Point(296, 87);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(116, 24);
            this.mskData.TabIndex = 7;
            this.mskData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNasc.Location = new System.Drawing.Point(198, 90);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(92, 18);
            this.lblNasc.TabIndex = 6;
            this.lblNasc.Text = "Nascimento:";
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mskCPF.Location = new System.Drawing.Point(54, 87);
            this.mskCPF.Mask = "000-000-000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(138, 24);
            this.mskCPF.TabIndex = 5;
            this.mskCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCpf.Location = new System.Drawing.Point(6, 90);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(42, 18);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEndereco.Location = new System.Drawing.Point(88, 54);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(324, 24);
            this.txtEndereco.TabIndex = 3;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEndereco.Location = new System.Drawing.Point(6, 57);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(76, 18);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNome.Location = new System.Drawing.Point(65, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 24);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNome.Location = new System.Drawing.Point(6, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.chBoxAuto);
            this.gbEditar.Controls.Add(this.btnEditar);
            this.gbEditar.Controls.Add(this.dadosPesquisaPessoa);
            this.gbEditar.Controls.Add(this.btnPesq);
            this.gbEditar.Location = new System.Drawing.Point(443, 12);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(425, 403);
            this.gbEditar.TabIndex = 11;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "Editar Dados";
            // 
            // chBoxAuto
            // 
            this.chBoxAuto.AutoSize = true;
            this.chBoxAuto.Location = new System.Drawing.Point(15, 376);
            this.chBoxAuto.Name = "chBoxAuto";
            this.chBoxAuto.Size = new System.Drawing.Size(156, 17);
            this.chBoxAuto.TabIndex = 11;
            this.chBoxAuto.Text = "Pesquisar automaticamente";
            this.chBoxAuto.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(210, 370);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 27);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // dadosPesquisaPessoa
            // 
            this.dadosPesquisaPessoa.AllowUserToAddRows = false;
            this.dadosPesquisaPessoa.AllowUserToDeleteRows = false;
            this.dadosPesquisaPessoa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dadosPesquisaPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosPesquisaPessoa.Location = new System.Drawing.Point(15, 24);
            this.dadosPesquisaPessoa.Name = "dadosPesquisaPessoa";
            this.dadosPesquisaPessoa.ReadOnly = true;
            this.dadosPesquisaPessoa.Size = new System.Drawing.Size(397, 340);
            this.dadosPesquisaPessoa.TabIndex = 9;
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(314, 370);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(98, 27);
            this.btnPesq.TabIndex = 8;
            this.btnPesq.Text = "Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = true;
            // 
            // frmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 423);
            this.Controls.Add(this.gbBasico);
            this.Controls.Add(this.gbEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPessoa_Load);
            this.gbBasico.ResumeLayout(false);
            this.gbBasico.PerformLayout();
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosPesquisaPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBasico;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.CheckBox chBoxAuto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dadosPesquisaPessoa;
        private System.Windows.Forms.Button btnPesq;
    }
}