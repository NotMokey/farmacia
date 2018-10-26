using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Forms;

namespace Farmacia.Forms
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor fornece = new frmFornecedor();
            fornece.ShowDialog();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frmPagamento paga = new frmPagamento();
            paga.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisa pesq = new frmPesquisa();
            pesq.ShowDialog();
        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {
            //this.Dispose();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            frmVenda venda = new frmVenda();
            venda.ShowDialog();
        }

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            frmProduto prod = new frmProduto();
            prod.ShowDialog();
        }

        private void btnFarmacutico_Click(object sender, EventArgs e)
        {
            frmPessoa pessoa = new frmPessoa(1);
            pessoa.ShowDialog();
        }

        private void btnEmpregado_Click(object sender, EventArgs e)
        {
            frmPessoa pessoa = new frmPessoa(2);
            pessoa.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmPessoa pessoa = new frmPessoa(3);
            pessoa.ShowDialog();
        }
    }
}
