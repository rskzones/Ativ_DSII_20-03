namespace Prj_Consultorio
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFichaDePacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarFichaDePacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMédicoPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteraçãoExclusãoEPesquisaDePessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMédicoEspecialidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroEspecialidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultórioToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultórioToolStripMenuItem
            // 
            this.consultórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFichaDePacienteToolStripMenuItem,
            this.pesquisarFichaDePacienteToolStripMenuItem});
            this.consultórioToolStripMenuItem.Name = "consultórioToolStripMenuItem";
            this.consultórioToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.consultórioToolStripMenuItem.Text = "Consultório";
            // 
            // cadastrarFichaDePacienteToolStripMenuItem
            // 
            this.cadastrarFichaDePacienteToolStripMenuItem.Name = "cadastrarFichaDePacienteToolStripMenuItem";
            this.cadastrarFichaDePacienteToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.cadastrarFichaDePacienteToolStripMenuItem.Text = "Cadastrar Ficha de Paciente";
            this.cadastrarFichaDePacienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFichaDePacienteToolStripMenuItem_Click);
            // 
            // pesquisarFichaDePacienteToolStripMenuItem
            // 
            this.pesquisarFichaDePacienteToolStripMenuItem.Name = "pesquisarFichaDePacienteToolStripMenuItem";
            this.pesquisarFichaDePacienteToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.pesquisarFichaDePacienteToolStripMenuItem.Text = "Pesquisar Ficha de Paciente";
            this.pesquisarFichaDePacienteToolStripMenuItem.Click += new System.EventHandler(this.pesquisarFichaDePacienteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroMédicoPacienteToolStripMenuItem,
            this.alteraçãoExclusãoEPesquisaDePessoasToolStripMenuItem,
            this.cadastroMédicoEspecialidadeToolStripMenuItem,
            this.cadastroEspecialidadeToolStripMenuItem,
            this.cadastroDeUsuárioToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem1.Text = "Cadastrar";
            // 
            // cadastroMédicoPacienteToolStripMenuItem
            // 
            this.cadastroMédicoPacienteToolStripMenuItem.Name = "cadastroMédicoPacienteToolStripMenuItem";
            this.cadastroMédicoPacienteToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.cadastroMédicoPacienteToolStripMenuItem.Text = "Cadastro";
            this.cadastroMédicoPacienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroMédicoPacienteToolStripMenuItem_Click);
            // 
            // alteraçãoExclusãoEPesquisaDePessoasToolStripMenuItem
            // 
            this.alteraçãoExclusãoEPesquisaDePessoasToolStripMenuItem.Name = "alteraçãoExclusãoEPesquisaDePessoasToolStripMenuItem";
            this.alteraçãoExclusãoEPesquisaDePessoasToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.alteraçãoExclusãoEPesquisaDePessoasToolStripMenuItem.Text = "Alteração/Exclusão e Pesquisa de Pessoas";
            this.alteraçãoExclusãoEPesquisaDePessoasToolStripMenuItem.Click += new System.EventHandler(this.alteraçãoExclusãoEPesquisaDePessoasToolStripMenuItem_Click);
            // 
            // cadastroMédicoEspecialidadeToolStripMenuItem
            // 
            this.cadastroMédicoEspecialidadeToolStripMenuItem.Name = "cadastroMédicoEspecialidadeToolStripMenuItem";
            this.cadastroMédicoEspecialidadeToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.cadastroMédicoEspecialidadeToolStripMenuItem.Text = "Cadastro Médico-Especialidade";
            this.cadastroMédicoEspecialidadeToolStripMenuItem.Click += new System.EventHandler(this.cadastroMédicoEspecialidadeToolStripMenuItem_Click);
            // 
            // cadastroEspecialidadeToolStripMenuItem
            // 
            this.cadastroEspecialidadeToolStripMenuItem.Name = "cadastroEspecialidadeToolStripMenuItem";
            this.cadastroEspecialidadeToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.cadastroEspecialidadeToolStripMenuItem.Text = "Cadastro Especialidade";
            this.cadastroEspecialidadeToolStripMenuItem.Click += new System.EventHandler(this.cadastroEspecialidadeToolStripMenuItem_Click);
            // 
            // cadastroDeUsuárioToolStripMenuItem
            // 
            this.cadastroDeUsuárioToolStripMenuItem.Name = "cadastroDeUsuárioToolStripMenuItem";
            this.cadastroDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.cadastroDeUsuárioToolStripMenuItem.Text = "Cadastro de Usuário";
            this.cadastroDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuárioToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(861, 565);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Consultório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroMédicoEspecialidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroEspecialidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFichaDePacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarFichaDePacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroMédicoPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteraçãoExclusãoEPesquisaDePessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem;
    }
}