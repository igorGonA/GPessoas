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
    public partial class FEnderecos : MetroForm
    {
        private string codFuncionario;
        public List<EnderecoModel> lEnderecos;

        public FEnderecos(string CodFunc)
        {
            InitializeComponent();
            this.codFuncionario = CodFunc;
            this.lEnderecos = new List<EnderecoModel>();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            EnderecoModel Enderecos = new EnderecoModel
            {
                Bairro = txtBairro.Text,
                Localidade = txtCidade.Text,
                Complemento = txtComplemento.Text,
                GIA = txtGIA.Text,
                IBGE = txtIBGE.Text,
                Logradouro = txtLogradouro.Text,
                UF= txtUF.Text,
                Cep = mtbCep.Text.Replace(".", "").Replace(",", "").Replace("-", "").Trim(),
                CodInterno = Convert.ToInt16(codFuncionario), 
                DataCadastro = DateTime.Now
            };

            this.lEnderecos.Add(Enderecos);

            DialogResult dr = MessageBox.Show("Continuar", "Deseja adicionar outro endereço?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
                btnCancelar.PerformClick();
            else
                FEnderecos_Load(sender, e);
        }

        private void BtnBuscaCEP_Click(object sender, EventArgs e)
        {
            EnderecoModel item = Global.BuscaEnderecoViaCEP(mtbCep.Text.Replace(",", "").
                Replace(".", "").Replace("-", "").Trim());

            txtBairro.Text = item.Bairro;
            txtCidade.Text = item.Localidade;
            txtComplemento.Text = item.Complemento;
            txtGIA.Text = item.GIA;
            txtIBGE.Text = item.IBGE;
            txtLogradouro.Text = item.Logradouro;
            txtUF.Text = item.UF;

            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtComplemento.Enabled = true;
            txtGIA.Enabled = true;
            txtIBGE.Enabled = true;
            txtLogradouro.Enabled = true;
            txtUF.Enabled = true;
        }

        private void FEnderecos_Load(object sender, EventArgs e)
        {
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtGIA.Text = string.Empty;
            txtIBGE.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtUF.Text = string.Empty;
            mtbCep.Text = string.Empty;
        }
    }
}
