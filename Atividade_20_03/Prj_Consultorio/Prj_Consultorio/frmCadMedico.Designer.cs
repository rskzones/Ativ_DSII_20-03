namespace Prj_Consultorio
{
    partial class frmCadMedico
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblSexoMed = new System.Windows.Forms.Label();
            this.cbxSexoMed = new System.Windows.Forms.ComboBox();
            this.dtNascMed = new System.Windows.Forms.DateTimePicker();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCelularMed = new System.Windows.Forms.Label();
            this.txtEnderecoMed = new System.Windows.Forms.TextBox();
            this.txtCelMed = new System.Windows.Forms.TextBox();
            this.lblTelefoneMed = new System.Windows.Forms.Label();
            this.lblCPFMed = new System.Windows.Forms.Label();
            this.txtTelefoneMed = new System.Windows.Forms.TextBox();
            this.txtCPFMed = new System.Windows.Forms.TextBox();
            this.lblRGMed = new System.Windows.Forms.Label();
            this.lblDataNascMed = new System.Windows.Forms.Label();
            this.lblNomeMed = new System.Windows.Forms.Label();
            this.txtRGMed = new System.Windows.Forms.TextBox();
            this.txtNomeMed = new System.Windows.Forms.TextBox();
            this.lblSalarioMed = new System.Windows.Forms.Label();
            this.txtSalarioMed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(400, 251);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 36;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(481, 251);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 35;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblSexoMed
            // 
            this.lblSexoMed.AutoSize = true;
            this.lblSexoMed.Location = new System.Drawing.Point(351, 117);
            this.lblSexoMed.Name = "lblSexoMed";
            this.lblSexoMed.Size = new System.Drawing.Size(34, 13);
            this.lblSexoMed.TabIndex = 34;
            this.lblSexoMed.Text = "Sexo:";
            // 
            // cbxSexoMed
            // 
            this.cbxSexoMed.FormattingEnabled = true;
            this.cbxSexoMed.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cbxSexoMed.Location = new System.Drawing.Point(391, 114);
            this.cbxSexoMed.Name = "cbxSexoMed";
            this.cbxSexoMed.Size = new System.Drawing.Size(164, 21);
            this.cbxSexoMed.TabIndex = 33;
            // 
            // dtNascMed
            // 
            this.dtNascMed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascMed.Location = new System.Drawing.Point(179, 114);
            this.dtNascMed.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtNascMed.Name = "dtNascMed";
            this.dtNascMed.Size = new System.Drawing.Size(148, 20);
            this.dtNascMed.TabIndex = 32;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(117, 91);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 31;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCelularMed
            // 
            this.lblCelularMed.AutoSize = true;
            this.lblCelularMed.Location = new System.Drawing.Point(343, 169);
            this.lblCelularMed.Name = "lblCelularMed";
            this.lblCelularMed.Size = new System.Drawing.Size(42, 13);
            this.lblCelularMed.TabIndex = 30;
            this.lblCelularMed.Text = "Celular:";
            // 
            // txtEnderecoMed
            // 
            this.txtEnderecoMed.Location = new System.Drawing.Point(179, 88);
            this.txtEnderecoMed.Name = "txtEnderecoMed";
            this.txtEnderecoMed.Size = new System.Drawing.Size(376, 20);
            this.txtEnderecoMed.TabIndex = 29;
            // 
            // txtCelMed
            // 
            this.txtCelMed.Location = new System.Drawing.Point(391, 166);
            this.txtCelMed.Name = "txtCelMed";
            this.txtCelMed.Size = new System.Drawing.Size(164, 20);
            this.txtCelMed.TabIndex = 28;
            // 
            // lblTelefoneMed
            // 
            this.lblTelefoneMed.AutoSize = true;
            this.lblTelefoneMed.Location = new System.Drawing.Point(121, 169);
            this.lblTelefoneMed.Name = "lblTelefoneMed";
            this.lblTelefoneMed.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneMed.TabIndex = 27;
            this.lblTelefoneMed.Text = "Telefone:";
            // 
            // lblCPFMed
            // 
            this.lblCPFMed.AutoSize = true;
            this.lblCPFMed.Location = new System.Drawing.Point(355, 143);
            this.lblCPFMed.Name = "lblCPFMed";
            this.lblCPFMed.Size = new System.Drawing.Size(30, 13);
            this.lblCPFMed.TabIndex = 26;
            this.lblCPFMed.Text = "CPF:";
            // 
            // txtTelefoneMed
            // 
            this.txtTelefoneMed.Location = new System.Drawing.Point(179, 166);
            this.txtTelefoneMed.Name = "txtTelefoneMed";
            this.txtTelefoneMed.Size = new System.Drawing.Size(148, 20);
            this.txtTelefoneMed.TabIndex = 25;
            // 
            // txtCPFMed
            // 
            this.txtCPFMed.Location = new System.Drawing.Point(391, 140);
            this.txtCPFMed.Name = "txtCPFMed";
            this.txtCPFMed.Size = new System.Drawing.Size(164, 20);
            this.txtCPFMed.TabIndex = 24;
            // 
            // lblRGMed
            // 
            this.lblRGMed.AutoSize = true;
            this.lblRGMed.Location = new System.Drawing.Point(147, 143);
            this.lblRGMed.Name = "lblRGMed";
            this.lblRGMed.Size = new System.Drawing.Size(26, 13);
            this.lblRGMed.TabIndex = 23;
            this.lblRGMed.Text = "RG:";
            // 
            // lblDataNascMed
            // 
            this.lblDataNascMed.AutoSize = true;
            this.lblDataNascMed.Location = new System.Drawing.Point(66, 117);
            this.lblDataNascMed.Name = "lblDataNascMed";
            this.lblDataNascMed.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascMed.TabIndex = 22;
            this.lblDataNascMed.Text = "Data de Nascimento:";
            // 
            // lblNomeMed
            // 
            this.lblNomeMed.AutoSize = true;
            this.lblNomeMed.Location = new System.Drawing.Point(75, 67);
            this.lblNomeMed.Name = "lblNomeMed";
            this.lblNomeMed.Size = new System.Drawing.Size(91, 13);
            this.lblNomeMed.TabIndex = 21;
            this.lblNomeMed.Text = "Nome do Médico:";
            // 
            // txtRGMed
            // 
            this.txtRGMed.Location = new System.Drawing.Point(179, 140);
            this.txtRGMed.Name = "txtRGMed";
            this.txtRGMed.Size = new System.Drawing.Size(148, 20);
            this.txtRGMed.TabIndex = 20;
            // 
            // txtNomeMed
            // 
            this.txtNomeMed.Location = new System.Drawing.Point(179, 64);
            this.txtNomeMed.Name = "txtNomeMed";
            this.txtNomeMed.Size = new System.Drawing.Size(376, 20);
            this.txtNomeMed.TabIndex = 19;
            // 
            // lblSalarioMed
            // 
            this.lblSalarioMed.AutoSize = true;
            this.lblSalarioMed.Location = new System.Drawing.Point(131, 202);
            this.lblSalarioMed.Name = "lblSalarioMed";
            this.lblSalarioMed.Size = new System.Drawing.Size(42, 13);
            this.lblSalarioMed.TabIndex = 37;
            this.lblSalarioMed.Text = "Salario:";
            // 
            // txtSalarioMed
            // 
            this.txtSalarioMed.Location = new System.Drawing.Point(179, 199);
            this.txtSalarioMed.Name = "txtSalarioMed";
            this.txtSalarioMed.Size = new System.Drawing.Size(75, 20);
            this.txtSalarioMed.TabIndex = 38;
            // 
            // frmCadMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 339);
            this.Controls.Add(this.txtSalarioMed);
            this.Controls.Add(this.lblSalarioMed);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblSexoMed);
            this.Controls.Add(this.cbxSexoMed);
            this.Controls.Add(this.dtNascMed);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCelularMed);
            this.Controls.Add(this.txtEnderecoMed);
            this.Controls.Add(this.txtCelMed);
            this.Controls.Add(this.lblTelefoneMed);
            this.Controls.Add(this.lblCPFMed);
            this.Controls.Add(this.txtTelefoneMed);
            this.Controls.Add(this.txtCPFMed);
            this.Controls.Add(this.lblRGMed);
            this.Controls.Add(this.lblDataNascMed);
            this.Controls.Add(this.lblNomeMed);
            this.Controls.Add(this.txtRGMed);
            this.Controls.Add(this.txtNomeMed);
            this.Name = "frmCadMedico";
            this.Text = "frmCadMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblSexoMed;
        private System.Windows.Forms.ComboBox cbxSexoMed;
        private System.Windows.Forms.DateTimePicker dtNascMed;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCelularMed;
        private System.Windows.Forms.TextBox txtEnderecoMed;
        private System.Windows.Forms.TextBox txtCelMed;
        private System.Windows.Forms.Label lblTelefoneMed;
        private System.Windows.Forms.Label lblCPFMed;
        private System.Windows.Forms.TextBox txtTelefoneMed;
        private System.Windows.Forms.TextBox txtCPFMed;
        private System.Windows.Forms.Label lblRGMed;
        private System.Windows.Forms.Label lblDataNascMed;
        private System.Windows.Forms.Label lblNomeMed;
        private System.Windows.Forms.TextBox txtRGMed;
        private System.Windows.Forms.TextBox txtNomeMed;
        private System.Windows.Forms.Label lblSalarioMed;
        private System.Windows.Forms.TextBox txtSalarioMed;

    }
}