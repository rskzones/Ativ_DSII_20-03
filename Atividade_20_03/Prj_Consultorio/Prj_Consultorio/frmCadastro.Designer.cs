namespace Prj_Consultorio
{
    partial class frmCadastro
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
            this.rbtCadPaciente = new System.Windows.Forms.RadioButton();
            this.rbtCadMedico = new System.Windows.Forms.RadioButton();
            this.lblTipoCad = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.datNasc = new System.Windows.Forms.DateTimePicker();
            this.lblRGCad = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblTelCad = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPFCad = new System.Windows.Forms.Label();
            this.lblSexoCad = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelCad = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.lblCRMCad = new System.Windows.Forms.Label();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalarioCad = new System.Windows.Forms.Label();
            this.btnCadastrarCad = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtCadPaciente
            // 
            this.rbtCadPaciente.AutoSize = true;
            this.rbtCadPaciente.Location = new System.Drawing.Point(153, 65);
            this.rbtCadPaciente.Name = "rbtCadPaciente";
            this.rbtCadPaciente.Size = new System.Drawing.Size(67, 17);
            this.rbtCadPaciente.TabIndex = 0;
            this.rbtCadPaciente.TabStop = true;
            this.rbtCadPaciente.Text = "Paciente";
            this.rbtCadPaciente.UseVisualStyleBackColor = true;
            // 
            // rbtCadMedico
            // 
            this.rbtCadMedico.AutoSize = true;
            this.rbtCadMedico.Location = new System.Drawing.Point(226, 65);
            this.rbtCadMedico.Name = "rbtCadMedico";
            this.rbtCadMedico.Size = new System.Drawing.Size(60, 17);
            this.rbtCadMedico.TabIndex = 1;
            this.rbtCadMedico.TabStop = true;
            this.rbtCadMedico.Text = "Médico";
            this.rbtCadMedico.UseVisualStyleBackColor = true;
            // 
            // lblTipoCad
            // 
            this.lblTipoCad.AutoSize = true;
            this.lblTipoCad.Location = new System.Drawing.Point(56, 67);
            this.lblTipoCad.Name = "lblTipoCad";
            this.lblTipoCad.Size = new System.Drawing.Size(91, 13);
            this.lblTipoCad.TabIndex = 2;
            this.lblTipoCad.Text = "Tipo de Cadastro:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(80, 130);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(124, 127);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(397, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(62, 156);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(124, 153);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(397, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(62, 185);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(107, 13);
            this.lblDataNasc.TabIndex = 7;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // datNasc
            // 
            this.datNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datNasc.Location = new System.Drawing.Point(175, 179);
            this.datNasc.Name = "datNasc";
            this.datNasc.Size = new System.Drawing.Size(110, 20);
            this.datNasc.TabIndex = 8;
            // 
            // lblRGCad
            // 
            this.lblRGCad.AutoSize = true;
            this.lblRGCad.Location = new System.Drawing.Point(96, 217);
            this.lblRGCad.Name = "lblRGCad";
            this.lblRGCad.Size = new System.Drawing.Size(26, 13);
            this.lblRGCad.TabIndex = 9;
            this.lblRGCad.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(128, 214);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(158, 20);
            this.txtRG.TabIndex = 10;
            // 
            // lblTelCad
            // 
            this.lblTelCad.AutoSize = true;
            this.lblTelCad.Location = new System.Drawing.Point(70, 243);
            this.lblTelCad.Name = "lblTelCad";
            this.lblTelCad.Size = new System.Drawing.Size(52, 13);
            this.lblTelCad.TabIndex = 11;
            this.lblTelCad.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(128, 240);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(158, 20);
            this.txtTelefone.TabIndex = 12;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(363, 214);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(158, 20);
            this.txtCPF.TabIndex = 14;
            // 
            // lblCPFCad
            // 
            this.lblCPFCad.AutoSize = true;
            this.lblCPFCad.Location = new System.Drawing.Point(327, 217);
            this.lblCPFCad.Name = "lblCPFCad";
            this.lblCPFCad.Size = new System.Drawing.Size(30, 13);
            this.lblCPFCad.TabIndex = 13;
            this.lblCPFCad.Text = "CPF:";
            // 
            // lblSexoCad
            // 
            this.lblSexoCad.AutoSize = true;
            this.lblSexoCad.Location = new System.Drawing.Point(323, 189);
            this.lblSexoCad.Name = "lblSexoCad";
            this.lblSexoCad.Size = new System.Drawing.Size(34, 13);
            this.lblSexoCad.TabIndex = 15;
            this.lblSexoCad.Text = "Sexo:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(363, 240);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(158, 20);
            this.txtCelular.TabIndex = 18;
            // 
            // lblCelCad
            // 
            this.lblCelCad.AutoSize = true;
            this.lblCelCad.Location = new System.Drawing.Point(315, 243);
            this.lblCelCad.Name = "lblCelCad";
            this.lblCelCad.Size = new System.Drawing.Size(42, 13);
            this.lblCelCad.TabIndex = 17;
            this.lblCelCad.Text = "Celular:";
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbxSexo.Location = new System.Drawing.Point(363, 186);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(158, 21);
            this.cbxSexo.TabIndex = 19;
            // 
            // lblCRMCad
            // 
            this.lblCRMCad.AutoSize = true;
            this.lblCRMCad.Location = new System.Drawing.Point(88, 271);
            this.lblCRMCad.Name = "lblCRMCad";
            this.lblCRMCad.Size = new System.Drawing.Size(34, 13);
            this.lblCRMCad.TabIndex = 20;
            this.lblCRMCad.Text = "CRM:";
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new System.Drawing.Point(128, 266);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(157, 20);
            this.txtCRM.TabIndex = 21;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(363, 264);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(158, 20);
            this.txtSalario.TabIndex = 23;
            // 
            // lblSalarioCad
            // 
            this.lblSalarioCad.AutoSize = true;
            this.lblSalarioCad.Location = new System.Drawing.Point(315, 271);
            this.lblSalarioCad.Name = "lblSalarioCad";
            this.lblSalarioCad.Size = new System.Drawing.Size(42, 13);
            this.lblSalarioCad.TabIndex = 22;
            this.lblSalarioCad.Text = "Salário:";
            // 
            // btnCadastrarCad
            // 
            this.btnCadastrarCad.Location = new System.Drawing.Point(446, 339);
            this.btnCadastrarCad.Name = "btnCadastrarCad";
            this.btnCadastrarCad.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCad.TabIndex = 24;
            this.btnCadastrarCad.Text = "Cadastrar";
            this.btnCadastrarCad.UseVisualStyleBackColor = true;
            this.btnCadastrarCad.Click += new System.EventHandler(this.btnCadastrarCad_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(365, 339);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 425);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarCad);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalarioCad);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.lblCRMCad);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblCelCad);
            this.Controls.Add(this.lblSexoCad);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPFCad);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelCad);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lblRGCad);
            this.Controls.Add(this.datNasc);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTipoCad);
            this.Controls.Add(this.rbtCadMedico);
            this.Controls.Add(this.rbtCadPaciente);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtCadPaciente;
        private System.Windows.Forms.RadioButton rbtCadMedico;
        private System.Windows.Forms.Label lblTipoCad;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.DateTimePicker datNasc;
        private System.Windows.Forms.Label lblRGCad;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblTelCad;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPFCad;
        private System.Windows.Forms.Label lblSexoCad;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelCad;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label lblCRMCad;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalarioCad;
        private System.Windows.Forms.Button btnCadastrarCad;
        private System.Windows.Forms.Button btnVoltar;
    }
}