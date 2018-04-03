namespace Prj_Consultorio
{
    partial class frmHistorico
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
            this.btnPesquisaHistorico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblBuscaFicha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPesquisaHistorico
            // 
            this.btnPesquisaHistorico.Location = new System.Drawing.Point(648, 76);
            this.btnPesquisaHistorico.Name = "btnPesquisaHistorico";
            this.btnPesquisaHistorico.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaHistorico.TabIndex = 3;
            this.btnPesquisaHistorico.Text = "Pesquisa";
            this.btnPesquisaHistorico.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(88, 200);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(635, 227);
            this.txtDescricao.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(545, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lblBuscaFicha
            // 
            this.lblBuscaFicha.AutoSize = true;
            this.lblBuscaFicha.Location = new System.Drawing.Point(85, 41);
            this.lblBuscaFicha.Name = "lblBuscaFicha";
            this.lblBuscaFicha.Size = new System.Drawing.Size(79, 13);
            this.lblBuscaFicha.TabIndex = 7;
            this.lblBuscaFicha.Text = "Procurar Ficha:";
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 576);
            this.Controls.Add(this.lblBuscaFicha);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisaHistorico);
            this.Name = "frmHistorico";
            this.Text = "frmHistorico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisaHistorico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblBuscaFicha;
    }
}