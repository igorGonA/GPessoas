namespace GPessoas
{
    partial class FPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable1 = new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbRemover = new System.Windows.Forms.ToolStripButton();
            this.tsbAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsbRestart = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.dgvListagem = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.FuncionarioModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionarioModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(1, 0);
            this.ribbonControlAdv1.MenuButtonAutoSize = true;
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.MenuButtonText = "";
            this.ribbonControlAdv1.MenuButtonVisible = false;
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            office2016ColorTable1.HoverCollapsedDropDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            office2016ColorTable1.QATDropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ribbonControlAdv1.Office2016ColorTable.Add(office2016ColorTable1);
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.ribbonControlAdv1.SelectedTab = this.toolStripTabItem1;
            this.ribbonControlAdv1.ShowQuickItemsDropDownButton = false;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = false;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(1026, 157);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.ThemeName = "Office2016";
            this.ribbonControlAdv1.TitleColor = System.Drawing.Color.Black;
            // 
            // toolStripTabItem1
            // 
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx2);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx1);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 2;
            this.toolStripTabItem1.Panel.Text = "Funcionários";
            this.toolStripTabItem1.Position = 0;
            this.toolStripTabItem1.Size = new System.Drawing.Size(90, 25);
            this.toolStripTabItem1.Text = "Funcionários";
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.AutoSize = false;
            this.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbEditar,
            this.tsbRemover,
            this.tsbAtualizar});
            this.toolStripEx2.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripEx2.Size = new System.Drawing.Size(450, 93);
            this.toolStripEx2.TabIndex = 1;
            this.toolStripEx2.Text = "Cadastro do Funcionários";
            // 
            // tsbNovo
            // 
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbNovo.Size = new System.Drawing.Size(107, 76);
            this.tsbNovo.Text = "Novo Cadastro";
            this.tsbNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNovo.Click += new System.EventHandler(this.TsbNovo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbEditar.Size = new System.Drawing.Size(110, 76);
            this.tsbEditar.Text = "Editar Cadastro";
            this.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEditar.Click += new System.EventHandler(this.TsbEditar_Click);
            // 
            // tsbRemover
            // 
            this.tsbRemover.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemover.Image")));
            this.tsbRemover.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemover.Name = "tsbRemover";
            this.tsbRemover.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbRemover.Size = new System.Drawing.Size(124, 76);
            this.tsbRemover.Text = "Remover Cadastro";
            this.tsbRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRemover.Click += new System.EventHandler(this.TsbRemover_Click);
            // 
            // tsbAtualizar
            // 
            this.tsbAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAtualizar.Image")));
            this.tsbAtualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAtualizar.Name = "tsbAtualizar";
            this.tsbAtualizar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbAtualizar.Size = new System.Drawing.Size(76, 76);
            this.tsbAtualizar.Text = "Atualizar";
            this.tsbAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAtualizar.Click += new System.EventHandler(this.TsbAtualizar_Click);
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.AutoSize = false;
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRestart,
            this.tsbSair});
            this.toolStripEx1.Location = new System.Drawing.Point(452, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripEx1.Size = new System.Drawing.Size(182, 93);
            this.toolStripEx1.TabIndex = 0;
            this.toolStripEx1.Text = "Sistema";
            // 
            // tsbRestart
            // 
            this.tsbRestart.Image = ((System.Drawing.Image)(resources.GetObject("tsbRestart.Image")));
            this.tsbRestart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRestart.Name = "tsbRestart";
            this.tsbRestart.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbRestart.Size = new System.Drawing.Size(100, 76);
            this.tsbRestart.Text = "Login / Logof";
            this.tsbRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRestart.Click += new System.EventHandler(this.TsbRestart_Click);
            // 
            // tsbSair
            // 
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbSair.Size = new System.Drawing.Size(56, 76);
            this.tsbSair.Text = "Sair";
            this.tsbSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSair.Click += new System.EventHandler(this.TsbSair_Click);
            // 
            // dgvListagem
            // 
            this.dgvListagem.AccessibleName = "Table";
            this.dgvListagem.BackColor = System.Drawing.SystemColors.Control;
            this.dgvListagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListagem.Location = new System.Drawing.Point(1, 157);
            this.dgvListagem.Name = "dgvListagem";
            this.dgvListagem.Size = new System.Drawing.Size(1022, 442);
            this.dgvListagem.TabIndex = 1;
            this.dgvListagem.Text = "sfDataGrid1";
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.dgvListagem);
            this.Controls.Add(this.ribbonControlAdv1);
            this.Name = "FPrincipal";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.ShowApplicationIcon = false;
            this.Text = "Lista de Funcionarios";
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionarioModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbRemover;
        private System.Windows.Forms.ToolStripButton tsbAtualizar;
        private System.Windows.Forms.ToolStripButton tsbRestart;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvListagem;
        private System.Windows.Forms.BindingSource FuncionarioModelBindingSource;
    }
}

