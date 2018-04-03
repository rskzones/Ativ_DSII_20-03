namespace Prj_Consultorio
{
    partial class frmCadMedEspecialidade
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
            this.txtIDMed = new System.Windows.Forms.TextBox();
            this.txtIDEspec = new System.Windows.Forms.TextBox();
            this.lblIDMed = new System.Windows.Forms.Label();
            this.lblIDEspec = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnVisualizarTabelaEspec = new System.Windows.Forms.Button();
            this.btnVisualizarTabEspec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIDMed
            // 
            this.txtIDMed.Location = new System.Drawing.Point(170, 52);
            this.txtIDMed.Name = "txtIDMed";
            this.txtIDMed.Size = new System.Drawing.Size(244, 20);
            this.txtIDMed.TabIndex = 1;
            // 
            // txtIDEspec
            // 
            this.txtIDEspec.Location = new System.Drawing.Point(170, 78);
            this.txtIDEspec.Name = "txtIDEspec";
            this.txtIDEspec.Size = new System.Drawing.Size(244, 20);
            this.txtIDEspec.TabIndex = 2;
            // 
            // lblIDMed
            // 
            this.lblIDMed.AutoSize = true;
            this.lblIDMed.Location = new System.Drawing.Point(92, 55);
            this.lblIDMed.Name = "lblIDMed";
            this.lblIDMed.Size = new System.Drawing.Size(72, 13);
            this.lblIDMed.TabIndex = 3;
            this.lblIDMed.Text = "Id do Médico:";
            // 
            // lblIDEspec
            // 
            this.lblIDEspec.AutoSize = true;
            this.lblIDEspec.Location = new System.Drawing.Point(61, 78);
            this.lblIDEspec.Name = "lblIDEspec";
            this.lblIDEspec.Size = new System.Drawing.Size(103, 13);
            this.lblIDEspec.TabIndex = 4;
            this.lblIDEspec.Text = "Id da Especialidade:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(375, 144);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(294, 144);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarTabelaEspec
            // 
            this.btnVisualizarTabelaEspec.Location = new System.Drawing.Point(40, 144);
            this.btnVisualizarTabelaEspec.Name = "btnVisualizarTabelaEspec";
            this.btnVisualizarTabelaEspec.Size = new System.Drawing.Size(106, 23);
            this.btnVisualizarTabelaEspec.TabIndex = 7;
            this.btnVisualizarTabelaEspec.Text = "Visualizar Medicos";
            this.btnVisualizarTabelaEspec.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarTabEspec
            // 
            this.btnVisualizarTabEspec.Location = new System.Drawing.Point(152, 144);
            this.btnVisualizarTabEspec.Name = "btnVisualizarTabEspec";
            this.btnVisualizarTabEspec.Size = new System.Drawing.Size(106, 23);
            this.btnVisualizarTabEspec.TabIndex = 8;
            this.btnVisualizarTabEspec.Text = "Visualizar Espec";
            this.btnVisualizarTabEspec.UseVisualStyleBackColor = true;
            // 
            // frmCadMedEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 194);
            this.Controls.Add(this.btnVisualizarTabEspec);
            this.Controls.Add(this.btnVisualizarTabelaEspec);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblIDEspec);
            this.Controls.Add(this.lblIDMed);
            this.Controls.Add(this.txtIDEspec);
            this.Controls.Add(this.txtIDMed);
            this.Name = "frmCadMedEspecialidade";
            this.Text = "frmCadMedEspecialidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDMed;
        private System.Windows.Forms.TextBox txtIDEspec;
        private System.Windows.Forms.Label lblIDMed;
        private System.Windows.Forms.Label lblIDEspec;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnVisualizarTabelaEspec;
        private System.Windows.Forms.Button btnVisualizarTabEspec;
    }
}