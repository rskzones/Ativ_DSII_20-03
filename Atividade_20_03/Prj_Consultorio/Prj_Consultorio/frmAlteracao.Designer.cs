namespace Prj_Consultorio
{
    partial class frmAlteracao
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
            this.lblTipoCad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.dtNasc = new System.Windows.Forms.DateTimePicker();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCPFPaciente = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblRGPaciente = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnVoltarPac = new System.Windows.Forms.Button();
            this.lblCRM = new System.Windows.Forms.Label();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalarioMed = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblProcuraNome = new System.Windows.Forms.Label();
            this.rbtMedico = new System.Windows.Forms.RadioButton();
            this.rbtPaciente = new System.Windows.Forms.RadioButton();
            this.lblCad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTipoCad
            // 
            this.lblTipoCad.AutoSize = true;
            this.lblTipoCad.Location = new System.Drawing.Point(87, 54);
            this.lblTipoCad.Name = "lblTipoCad";
            this.lblTipoCad.Size = new System.Drawing.Size(0, 13);
            this.lblTipoCad.TabIndex = 1;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(329, 194);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 32;
            this.lblSexo.Text = "Sexo:";
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cbxSexo.Location = new System.Drawing.Point(369, 191);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(164, 21);
            this.cbxSexo.TabIndex = 31;
            // 
            // dtNasc
            // 
            this.dtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNasc.Location = new System.Drawing.Point(157, 191);
            this.dtNasc.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(148, 20);
            this.dtNasc.TabIndex = 30;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(95, 168);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 29;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(321, 246);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 28;
            this.lblCelular.Text = "Celular:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(157, 165);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(376, 20);
            this.txtEndereco.TabIndex = 27;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(369, 243);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(164, 20);
            this.txtCelular.TabIndex = 26;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(99, 246);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 25;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCPFPaciente
            // 
            this.lblCPFPaciente.AutoSize = true;
            this.lblCPFPaciente.Location = new System.Drawing.Point(333, 220);
            this.lblCPFPaciente.Name = "lblCPFPaciente";
            this.lblCPFPaciente.Size = new System.Drawing.Size(30, 13);
            this.lblCPFPaciente.TabIndex = 24;
            this.lblCPFPaciente.Text = "CPF:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(157, 243);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(148, 20);
            this.txtTel.TabIndex = 23;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(369, 217);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(164, 20);
            this.txtCPF.TabIndex = 22;
            // 
            // lblRGPaciente
            // 
            this.lblRGPaciente.AutoSize = true;
            this.lblRGPaciente.Location = new System.Drawing.Point(125, 220);
            this.lblRGPaciente.Name = "lblRGPaciente";
            this.lblRGPaciente.Size = new System.Drawing.Size(26, 13);
            this.lblRGPaciente.TabIndex = 21;
            this.lblRGPaciente.Text = "RG:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(44, 194);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(107, 13);
            this.lblDataNasc.TabIndex = 20;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(113, 144);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nome:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(157, 217);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(148, 20);
            this.txtRG.TabIndex = 18;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(157, 141);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(376, 20);
            this.txtNome.TabIndex = 17;
            // 
            // btnVoltarPac
            // 
            this.btnVoltarPac.Location = new System.Drawing.Point(296, 346);
            this.btnVoltarPac.Name = "btnVoltarPac";
            this.btnVoltarPac.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarPac.TabIndex = 34;
            this.btnVoltarPac.Text = "Voltar";
            this.btnVoltarPac.UseVisualStyleBackColor = true;
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(113, 272);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(34, 13);
            this.lblCRM.TabIndex = 35;
            this.lblCRM.Text = "CRM:";
            // 
            // txtCrm
            // 
            this.txtCrm.Location = new System.Drawing.Point(157, 269);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(376, 20);
            this.txtCrm.TabIndex = 36;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(157, 295);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(148, 20);
            this.txtSalario.TabIndex = 40;
            // 
            // lblSalarioMed
            // 
            this.lblSalarioMed.AutoSize = true;
            this.lblSalarioMed.Location = new System.Drawing.Point(109, 298);
            this.lblSalarioMed.Name = "lblSalarioMed";
            this.lblSalarioMed.Size = new System.Drawing.Size(42, 13);
            this.lblSalarioMed.TabIndex = 39;
            this.lblSalarioMed.Text = "Salario:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(377, 346);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(458, 95);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 42;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(157, 95);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(295, 21);
            this.comboBox2.TabIndex = 43;
            // 
            // lblProcuraNome
            // 
            this.lblProcuraNome.AutoSize = true;
            this.lblProcuraNome.Location = new System.Drawing.Point(77, 100);
            this.lblProcuraNome.Name = "lblProcuraNome";
            this.lblProcuraNome.Size = new System.Drawing.Size(74, 13);
            this.lblProcuraNome.TabIndex = 44;
            this.lblProcuraNome.Text = "Buscar Nome:";
            // 
            // rbtMedico
            // 
            this.rbtMedico.AutoSize = true;
            this.rbtMedico.Location = new System.Drawing.Point(160, 50);
            this.rbtMedico.Name = "rbtMedico";
            this.rbtMedico.Size = new System.Drawing.Size(60, 17);
            this.rbtMedico.TabIndex = 45;
            this.rbtMedico.TabStop = true;
            this.rbtMedico.Text = "Médico";
            this.rbtMedico.UseVisualStyleBackColor = true;
            // 
            // rbtPaciente
            // 
            this.rbtPaciente.AutoSize = true;
            this.rbtPaciente.Location = new System.Drawing.Point(251, 50);
            this.rbtPaciente.Name = "rbtPaciente";
            this.rbtPaciente.Size = new System.Drawing.Size(67, 17);
            this.rbtPaciente.TabIndex = 46;
            this.rbtPaciente.TabStop = true;
            this.rbtPaciente.Text = "Paciente";
            this.rbtPaciente.UseVisualStyleBackColor = true;
            // 
            // lblCad
            // 
            this.lblCad.AutoSize = true;
            this.lblCad.Location = new System.Drawing.Point(56, 52);
            this.lblCad.Name = "lblCad";
            this.lblCad.Size = new System.Drawing.Size(91, 13);
            this.lblCad.TabIndex = 47;
            this.lblCad.Text = "Tipo de Cadastro:";
            // 
            // frmAlteracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 397);
            this.Controls.Add(this.lblCad);
            this.Controls.Add(this.rbtPaciente);
            this.Controls.Add(this.rbtMedico);
            this.Controls.Add(this.lblProcuraNome);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalarioMed);
            this.Controls.Add(this.txtCrm);
            this.Controls.Add(this.lblCRM);
            this.Controls.Add(this.btnVoltarPac);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.dtNasc);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCPFPaciente);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblRGPaciente);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTipoCad);
            this.Name = "frmAlteracao";
            this.Text = "Alteração de Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoCad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.DateTimePicker dtNasc;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCPFPaciente;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblRGPaciente;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnVoltarPac;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalarioMed;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblProcuraNome;
        private System.Windows.Forms.RadioButton rbtMedico;
        private System.Windows.Forms.RadioButton rbtPaciente;
        private System.Windows.Forms.Label lblCad;
    }
}