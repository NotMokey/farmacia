using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Forms
{
    public partial class frmPessoa : Form
    {
        public frmPessoa(int tipo)
        {
            InitializeComponent();
            if (tipo == 1)
            {
                this.Text = "Farmaceutico";
            }
            else if (tipo == 2)
            {
                this.Text = "Funcionário";
            }
            else {
                this.Text = "Cliente";
            }
        }

        private void frmPessoa_Load(object sender, EventArgs e)
        {

        }
    }
}
