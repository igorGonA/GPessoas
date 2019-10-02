using GPessoas.Formularios;
using AppGPessoa.Classes;
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
using WebApi.Models;
using Syncfusion.WinForms.DataGrid;

namespace GPessoas
{
    public partial class FPrincipal : RibbonForm
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void TsbNovo_Click(object sender, EventArgs e)
        {
            using (FFuncionario frm = new FFuncionario(null))
            {
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }

            tsbAtualizar.PerformClick();
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            FuncionarioModel item = (dgvListagem.CurrentItem as FuncionarioModel);

            using (FFuncionario frm = new FFuncionario(item))
            {
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }

            tsbAtualizar.PerformClick();
        }

        private void TsbRemover_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirmação",
                "Deseja realmente excluir o registro selecionado?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                string msg = string.Empty;
                FuncionarioModelBindingSource.EndEdit();

                for (int i = 0; i < dgvListagem.View.Records.Count; i++)
                {
                    FuncionarioModel row = (dgvListagem.View.Records[i].Data as FuncionarioModel);

                    if (row != null)
                        msg = Global.APIFuncionariosCDU(row, $"destroy/{row.Codigo}");
                }

                MessageBox.Show(msg, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
                tsbAtualizar.PerformClick();
            }
        }

        private void TsbAtualizar_Click(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void TsbRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void TsbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            dgvListagem.Columns.Add(new GridTextColumn() { MappingName = "Codigo", HeaderText = "Código", AllowEditing = false, AllowFiltering = true });
            dgvListagem.Columns.Add(new GridTextColumn() { MappingName = "NomeCompleto", HeaderText = "Nome Completo", AllowEditing = false, AllowFiltering = true });
            dgvListagem.Columns.Add(new GridTextColumn() { MappingName = "NomeSocial", HeaderText = "Nome Social", AllowEditing = false, AllowFiltering = true });
            dgvListagem.Columns.Add(new GridTextColumn() { MappingName = "CPF", HeaderText = "CPF", AllowEditing = false, AllowFiltering = true });
            dgvListagem.Columns.Add(new GridTextColumn() { MappingName = "RegistroGeral", HeaderText = "RG", AllowEditing = false, AllowFiltering = true });
            dgvListagem.Columns.Add(new GridTextColumn() { MappingName = "NomeMae", HeaderText = "Nome Mãe", AllowEditing = false, AllowFiltering = true });
            dgvListagem.Columns.Add(new GridTextColumn() { MappingName = "NomePai", HeaderText = "Nome Pai", AllowEditing = false, AllowFiltering = true });
            dgvListagem.Columns.Add(new GridTextColumn() { MappingName = "DataAdmissao", HeaderText = "Data Admissão", AllowEditing = false, AllowFiltering = true });
            dgvListagem.Columns.Add(new GridTextColumn() { MappingName = "CriadoEm", HeaderText = "Registro Criado Em", AllowEditing = false, AllowFiltering = true });
            CarregaDGV();
        }

        private void CarregaDGV()
        {
            Cursor.Current = Cursors.WaitCursor;
            FuncionarioModelBindingSource = new BindingSource();
            FuncionarioModelBindingSource.DataSource = typeof(FuncionarioModel);
            FuncionarioModelBindingSource.DataSource = Global.APIListaFuncionarios();
            dgvListagem.DataSource = FuncionarioModelBindingSource;
            FuncionarioModelBindingSource.EndEdit();

            if (dgvListagem != null && dgvListagem.View != null && dgvListagem.View.Records != null && dgvListagem.View.Records.Count > 0)
            {
                tsbEditar.Enabled = true;
                tsbRemover.Enabled = true;
                tsbNovo.Enabled = true;
                tsbAtualizar.Enabled = true;
            }
            else
            {
                tsbEditar.Enabled = false;
                tsbRemover.Enabled = false;
            }

            Cursor.Current = Cursors.Default;
        }
    }
}
