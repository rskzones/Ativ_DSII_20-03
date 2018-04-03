using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prj_Consultorio
{
    public partial class frmCadastro : Form
    {
        private string conexaoBancoDados = "Persist Security Info=False;User ID=sa;Initial Catalog=ExemploAula;Data Source=LAB-07-21;password=info211";
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrarCad_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja cadastrar ?", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
               
                SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
                SQLSERVER.Open();

                if (rbtCadMedico.Checked)
                {
                    string insertBD = "INSERT INTO tbMedico values (" +
                        txtNome.Text + ",'" +
                        datNasc.Text + "','" +
                        txtRG.Text + "','" +
                        txtCRM.Text + "','" +
                        txtCPF.Text + "','" +
                        txtTelefone.Text + "','" +
                        txtCelular.Text + "','" +
                        txtEndereco.Text + "','" +
                        txtSalario.Text + "')";

                    SqlCommand comando = new SqlCommand(insertBD, SQLSERVER);
                    comando.ExecuteNonQuery();
                    SQLSERVER.Close();
                }
                else if (rbtCadPaciente.Checked)
                {
                    string insertBD = "INSERT INTO tbPaciente values (" +
                            txtNome.Text + ",'" +
                            datNasc.Text + "','" +
                            txtRG.Text + "','" +
                            txtCPF.Text + "','" +
                            txtTelefone.Text + "','" +
                            txtCelular.Text + "','" +
                            txtEndereco.Text + "')";

                    SqlCommand comando = new SqlCommand(insertBD, SQLSERVER);
                    comando.ExecuteNonQuery();
                    SQLSERVER.Close();
                }
            }
        }
    }
}
