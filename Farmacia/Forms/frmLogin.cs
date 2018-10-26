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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtUsuario.Text = "";
            txtUsuario.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Login Aprovado com sucesso!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
            frmInicial menu = new frmInicial();
            menu.ShowDialog();
            this.btnLimpar.PerformClick();
        }
    }
}
