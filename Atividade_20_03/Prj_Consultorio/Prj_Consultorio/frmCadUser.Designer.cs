namespace Prj_Consultorio
{
    partial class frmCadUser
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
            this.btnVoltarAtend = new System.Windows.Forms.Button();
            this.btnCadastrarAtend = new System.Windows.Forms.Button();
            this.cbxNome = new System.Windows.Forms.ComboBox();
            this.rbtMedico = new System.Windows.Forms.RadioButton();
            this.rbtAtendente = new System.Windows.Forms.RadioButton();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltarAtend
            // 
            this.btnVoltarAtend.Location = new System.Drawing.Point(382, 227);
            this.btnVoltarAtend.Name = "btnVoltarAtend";
            this.btnVoltarAtend.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarAtend.TabIndex = 54;
            this.btnVoltarAtend.Text = "Voltar";
            this.btnVoltarAtend.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarAtend
            // 
            this.btnCadastrarAtend.Location = new System.Drawing.Point(463, 227);
            this.btnCadastrarAtend.Name = "btnCadastrarAtend";
            this.btnCadastrarAtend.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAtend.TabIndex = 53;
            this.btnCadastrarAtend.Text = "Cadastrar";
            this.btnCadastrarAtend.UseVisualStyleBackColor = true;
            // 
            // cbxNome
            // 
            this.cbxNome.FormattingEnabled = true;
            this.cbxNome.Location = new System.Drawing.Point(175, 101);
            this.cbxNome.Name = "cbxNome";
            this.cbxNome.Size = new System.Drawing.Size(363, 21);
            this.cbxNome.TabIndex = 56;
            // 
            // rbtMedico
            // 
            this.rbtMedico.AutoSize = true;
            this.rbtMedico.Location = new System.Drawing.Point(148, 52);
            this.rbtMedico.Name = "rbtMedico";
            this.rbtMedico.Size = new System.Drawing.Size(60, 17);
            this.rbtMedico.TabIndex = 57;
            this.rbtMedico.TabStop = true;
            this.rbtMedico.Text = "Médico";
            this.rbtMedico.UseVisualStyleBackColor = true;
            // 
            // rbtAtendente
            // 
            this.rbtAtendente.AutoSize = true;
            this.rbtAtendente.Location = new System.Drawing.Point(214, 52);
            this.rbtAtendente.Name = "rbtAtendente";
            this.rbtAtendente.Size = new System.Drawing.Size(74, 17);
            this.rbtAtendente.TabIndex = 58;
            this.rbtAtendente.TabStop = true;
            this.rbtAtendente.Text = "Atendente";
            this.rbtAtendente.UseVisualStyleBackColor = true;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(77, 54);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lblFuncionario.TabIndex = 59;
            this.lblFuncionario.Text = "Funcionário:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 60;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 20);
            this.textBox2.TabIndex = 61;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(77, 104);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 62;
            this.lblNome.Text = "Nome:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(77, 131);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(92, 13);
            this.lblUser.TabIndex = 63;
            this.lblUser.Text = "Nome de Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(77, 157);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 64;
            this.lblSenha.Text = "Senha:";
            // 
            // frmCadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 276);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.rbtAtendente);
            this.Controls.Add(this.rbtMedico);
            this.Controls.Add(this.cbxNome);
            this.Controls.Add(this.btnVoltarAtend);
            this.Controls.Add(this.btnCadastrarAtend);
            this.Name = "frmCadUser";
            this.Text = "Cadastro de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarAtend;
        private System.Windows.Forms.Button btnCadastrarAtend;
        private System.Windows.Forms.ComboBox cbxNome;
        private System.Windows.Forms.RadioButton rbtMedico;
        private System.Windows.Forms.RadioButton rbtAtendente;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSenha;
    }
}