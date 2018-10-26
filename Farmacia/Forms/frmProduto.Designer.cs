namespace Farmacia.Forms
{
    partial class frmProduto
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
            this.dadosProdutos = new System.Windows.Forms.DataGridView();
            this.lblAviso1 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.gbCad = new System.Windows.Forms.GroupBox();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cboFornece = new System.Windows.Forms.ComboBox();
            this.btnCadastra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dadosProdutos)).BeginInit();
            this.gbCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // dadosProdutos
            // 
            this.dadosProdutos.AllowUserToAddRows = false;
            this.dadosProdutos.AllowUserToDeleteRows = false;
            this.dadosProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dadosProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosProdutos.Location = new System.Drawing.Point(2, 35);
            this.dadosProdutos.Name = "dadosProdutos";
            this.dadosProdutos.ReadOnly = true;
            this.dadosProdutos.Size = new System.Drawing.Size(315, 301);
            this.dadosProdutos.TabIndex = 0;
            // 
            // lblAviso1
            // 
            this.lblAviso1.AutoSize = true;
            this.lblAviso1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAviso1.Location = new System.Drawing.Point(64, 9);
            this.lblAviso1.Name = "lblAviso1";
            this.lblAviso1.Size = new System.Drawing.Size(162, 23);
            this.lblAviso1.TabIndex = 1;
            this.lblAviso1.Text = "Produto / Fornecedor:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(2, 342);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(315, 23);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // gbCad
            // 
            this.gbCad.Controls.Add(this.btnCadastra);
            this.gbCad.Controls.Add(this.cboFornece);
            this.gbCad.Controls.Add(this.lblFornecedor);
            this.gbCad.Controls.Add(this.txtDesc);
            this.gbCad.Controls.Add(this.lblDescProd);
            this.gbCad.Location = new System.Drawing.Point(323, 9);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(307, 356);
            this.gbCad.TabIndex = 3;
            this.gbCad.TabStop = false;
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescProd.Location = new System.Drawing.Point(6, 16);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(164, 23);
            this.lblDescProd.TabIndex = 4;
            this.lblDescProd.Text = "Descrição do Produto:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.txtDesc.Location = new System.Drawing.Point(10, 42);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(291, 29);
            this.txtDesc.TabIndex = 5;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFornecedor.Location = new System.Drawing.Point(6, 83);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(96, 23);
            this.lblFornecedor.TabIndex = 6;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // cboFornece
            // 
            this.cboFornece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFornece.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.cboFornece.FormattingEnabled = true;
            this.cboFornece.Location = new System.Drawing.Point(99, 80);
            this.cboFornece.Name = "cboFornece";
            this.cboFornece.Size = new System.Drawing.Size(200, 31);
            this.cboFornece.TabIndex = 7;
            // 
            // btnCadastra
            // 
            this.btnCadastra.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastra.Location = new System.Drawing.Point(154, 117);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(147, 39);
            this.btnCadastra.TabIndex = 4;
            this.btnCadastra.Text = "Cadastrar";
            this.btnCadastra.UseVisualStyleBackColor = true;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 367);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblAviso1);
            this.Controls.Add(this.dadosProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dadosProdutos)).EndInit();
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dadosProdutos;
        private System.Windows.Forms.Label lblAviso1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox gbCad;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.ComboBox cboFornece;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDescProd;
    }
}