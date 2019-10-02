using AppGPessoa.Classes;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApi.Models;

namespace GPessoas.Formularios
{
    public partial class FFuncionario : MetroForm
    {
        private List<EnderecoModel> endereco;
        private FuncionarioModel funcionario;
        private FuncionarioModel item;

        public FFuncionario(FuncionarioModel funcionario)
        {
            InitializeComponent();
            this.endereco = new List<EnderecoModel>();
            this.funcionario = new FuncionarioModel();
            this.item = funcionario;
        }

        private void FFuncionario_Load(object sender, EventArgs e)
        {
            if (item == null)
            {
                List<FuncionarioModel> fun = Global.APIListaFuncionarios();
                txtCodigo.Text = (fun != null || fun.Count > 0) ?
                    Convert.ToString(fun.Count + 1).PadLeft(5, '0') : "00001";
            }
            else
                CarregaDados();

        }

        private void BtnEndereco_Click(object sender, EventArgs e)
        {
            using (FEnderecos frm = new FEnderecos(txtCodigo.Text))
            {
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();

                this.endereco = frm.lEnderecos;
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;

            if (ValidacaoCampos(ref msg))
            {
                this.funcionario = new FuncionarioModel
                {
                    Codigo = Convert.ToInt16(txtCodigo.Text),
                    NomeCompleto = txtNomeCompleto.Text,
                    NomeSocial = txtNomeSocial.Text,
                    CPF = mtbCPF.Text.Replace("-", "").Replace(",", "").Replace(".", "").Trim(),
                    RegistroGeral = mtbRG.Text.Replace("-", "").Replace(",", "").Replace(".", "").Trim(),
                    DataAdmissao = Convert.ToDateTime(mtbDataAdmissao.Text),
                    NomeMae = txtNomeMae.Text,
                    NomePai = txtNomePai.Text,
                    Enderecos = this.endereco                    
                };

                string mensagem = string.Empty;

                if (item == null)
                {
                    this.funcionario.CriadoPor = "ADMIN";
                    this.funcionario.CriadoEm = DateTime.Now;
                    mensagem = Global.APIFuncionariosCDU(this.funcionario, "/create");
                }
                else
                {
                    this.funcionario.ModificadoPor = "ADMIN";
                    this.funcionario.ModificadoEm = DateTime.Now;
                    mensagem = Global.APIFuncionariosCDU(this.funcionario, $"/update/{txtCodigo.Text}");
                }
            }
            MessageBox.Show("Falha", msg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool ValidacaoCampos(ref string msg)
        {
            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
                msg += " - Informe o Nome Completo do Funcionário.\n";

            if (string.IsNullOrEmpty(mtbCPF.Text) && Global.ValidaCPF(mtbCPF.Text))
                msg += " - Informe o CPF do Funcionário.\n";

            if (string.IsNullOrEmpty(mtbRG.Text))
                msg += " - Informe o RG do Funcionário.\n";

            if (ckbAdimissaoHoje.Checked && string.IsNullOrEmpty(mtbDataAdmissao.Text))
                msg += " - Informe a Data de Admissão do Funcionário.\n";

            if (string.IsNullOrEmpty(mtbDataAdmissao.Text) &&
                !DateTime.TryParse(mtbDataAdmissao.Text, out DateTime dtAdmissao))
                msg += " - Informe a Data da Admissão do Funcionário.";

            if (!string.IsNullOrEmpty(msg))
                return true;
            else
                return false;
        }

        private void CkbAdimissaoHoje_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAdimissaoHoje.Checked)
            {
                mtbDataAdmissao.Text = DateTime.Now.ToString();
                mtbDataAdmissao.Enabled = false;
            }
            else
            {
                mtbDataAdmissao.Text = string.Empty;
                mtbDataAdmissao.Enabled = true;
            }
        }

        private void CarregaDados()
        {
            txtCodigo.Text = item.Codigo.ToString();
            txtNomeCompleto.Text = item.NomeCompleto;
            txtNomeMae.Text = item.NomeMae;
            txtNomePai.Text = item.NomePai;
            txtNomeSocial.Text = item.NomeSocial;
            mtbCPF.Text = item.CPF;
            mtbDataAdmissao.Text = item.DataAdmissao.ToString();
            mtbRG.Text = item.RegistroGeral;
        }
    }
}
