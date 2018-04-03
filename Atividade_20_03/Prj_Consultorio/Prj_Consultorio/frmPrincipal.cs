using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prj_Consultorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeAtendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadUser atend = new frmCadUser();
            atend.MdiParent = this;
            atend.Show();
        }

        private void cadastroMédicoEspecialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadMedEspecialidade medEspec = new frmCadMedEspecialidade();
            medEspec.MdiParent = this;
            medEspec.Show();
        }

        private void cadastroEspecialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadEspecialidade espec = new frmCadEspecialidade();
            espec.MdiParent = this;
            espec.Show();
        }

        private void cadastrarFichaDePacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaPac fichaPac = new frmFichaPac();
            fichaPac.MdiParent = this;
            fichaPac.Show();
        }

        private void pesquisarFichaDePacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorico historico = new frmHistorico();
            historico.MdiParent = this;
            historico.Show();
        }

        private void cadastroMédicoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void alteraçãoExclusãoEPesquisaDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlteracao alteracao = new frmAlteracao();
            alteracao.MdiParent = this;
            alteracao.Show();
        }

        private void cadastroDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadUser cadUser = new frmCadUser();
            cadUser.MdiParent = this;
            cadUser.Show();
        }

    }
}
