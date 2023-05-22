using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_PDV
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuFucionarios_Click(object sender, EventArgs e)
        {
            Cadastro.FrmCadastro frmCadastro = new Cadastro.FrmCadastro();
            frmCadastro.ShowDialog();
        }
    }
}
