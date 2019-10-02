using GPessoas;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGPessoa
{
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnAcesso_Click(object sender, EventArgs e)
        {
            if((!string.IsNullOrEmpty(txtLogin.Text) && !string.IsNullOrEmpty(txtSenha.Text)) &&
                (txtLogin.Text == "ADMIN" && txtSenha.Text == "FORPEOPLE"))
            {
                this.Visible = false;
                FPrincipal frm = new FPrincipal();
                frm.ShowDialog();
            }
            MessageBox.Show("Login ou senha invalidos", "Falha de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
