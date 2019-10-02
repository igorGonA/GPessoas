namespace GPessoas.Formularios
{
    partial class FFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFuncionario));
            this.btnCancelar = new Syncfusion.WinForms.Controls.SfButton();
            this.btnConfirmar = new Syncfusion.WinForms.Controls.SfButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeSocial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.ckbAdimissaoHoje = new System.Windows.Forms.CheckBox();
            this.btnEndereco = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleName = "Button";
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(441, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 28);
            this.btnCancelar.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnCancelar.Style.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AccessibleName = "Button";
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(339, 298);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(96, 28);
            this.btnConfirmar.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnConfirmar.Style.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(16, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(16, 94);
            this.txtNomeCompleto.MaxLength = 150;
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(260, 20);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(16, 145);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(147, 20);
            this.mtbCPF.TabIndex = 3;
            this.mtbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome Social:";
            // 
            // txtNomeSocial
            // 
            this.txtNomeSocial.Location = new System.Drawing.Point(282, 94);
            this.txtNomeSocial.MaxLength = 150;
            this.txtNomeSocial.Name = "txtNomeSocial";
            this.txtNomeSocial.Size = new System.Drawing.Size(260, 20);
            this.txtNomeSocial.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "RG:";
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(169, 145);
            this.mtbRG.Mask = "00.000.000";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(147, 20);
            this.mtbRG.TabIndex = 4;
            this.mtbRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome do Pai:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome da Mãe";
            // 
            // txtNomePai
            // 
            this.txtNomePai.Location = new System.Drawing.Point(16, 200);
            this.txtNomePai.MaxLength = 150;
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(260, 20);
            this.txtNomePai.TabIndex = 7;
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Location = new System.Drawing.Point(282, 200);
            this.txtNomeMae.MaxLength = 150;
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(260, 20);
            this.txtNomeMae.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dt. Admissão:";
            // 
            // mtbDataAdmissao
            // 
            this.mtbDataAdmissao.Enabled = false;
            this.mtbDataAdmissao.Location = new System.Drawing.Point(322, 145);
            this.mtbDataAdmissao.Mask = "00/00/0000";
            this.mtbDataAdmissao.Name = "mtbDataAdmissao";
            this.mtbDataAdmissao.Size = new System.Drawing.Size(113, 20);
            this.mtbDataAdmissao.TabIndex = 5;
            this.mtbDataAdmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbAdimissaoHoje
            // 
            this.ckbAdimissaoHoje.AutoSize = true;
            this.ckbAdimissaoHoje.Checked = true;
            this.ckbAdimissaoHoje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAdimissaoHoje.Location = new System.Drawing.Point(447, 147);
            this.ckbAdimissaoHoje.Name = "ckbAdimissaoHoje";
            this.ckbAdimissaoHoje.Size = new System.Drawing.Size(95, 17);
            this.ckbAdimissaoHoje.TabIndex = 6;
            this.ckbAdimissaoHoje.Text = "Admitido hoje?";
            this.ckbAdimissaoHoje.UseVisualStyleBackColor = true;
            this.ckbAdimissaoHoje.CheckedChanged += new System.EventHandler(this.CkbAdimissaoHoje_CheckedChanged);
            // 
            // btnEndereco
            // 
            this.btnEndereco.AccessibleName = "Button";
            this.btnEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnEndereco.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnEndereco.ForeColor = System.Drawing.Color.White;
            this.btnEndereco.Location = new System.Drawing.Point(16, 241);
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Size = new System.Drawing.Size(147, 28);
            this.btnEndereco.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnEndereco.Style.ForeColor = System.Drawing.Color.White;
            this.btnEndereco.TabIndex = 9;
            this.btnEndereco.Text = "Adicionar Endereço";
            this.btnEndereco.UseVisualStyleBackColor = false;
            this.btnEndereco.Click += new System.EventHandler(this.BtnEndereco_Click);
            // 
            // FFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 338);
            this.Controls.Add(this.ckbAdimissaoHoje);
            this.Controls.Add(this.mtbDataAdmissao);
            this.Controls.Add(this.mtbRG);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.txtNomeMae);
            this.Controls.Add(this.txtNomeSocial);
            this.Controls.Add(this.txtNomePai);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEndereco);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.Name = "FFuncionario";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.FFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton btnCancelar;
        private Syncfusion.WinForms.Controls.SfButton btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeSocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtbDataAdmissao;
        private System.Windows.Forms.CheckBox ckbAdimissaoHoje;
        private Syncfusion.WinForms.Controls.SfButton btnEndereco;
    }
}