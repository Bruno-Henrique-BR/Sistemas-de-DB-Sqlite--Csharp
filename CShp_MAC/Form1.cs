using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_Sqlite.Models;
using System.Windows.Forms;
using csharp_Sqlite;

namespace CShp_MAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarBancoDados_Click(object sender, EventArgs e)
        {
            try
            {
                DalHelper.CriarBancoSQLite();
                btnCriarBancoDados.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            try
            {
                DalHelper.CriarTabelaSQlite();
                btnCriarTabela.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnExibirDados_Click(object sender, EventArgs e)
        {
        }
        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DalHelper.GetClientes();
                dgvDados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnIncluirDados_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("Informe os dados cliente a incluir");
                return;
            }
            try
            {
                Cliente cli = new Cliente();
                cli.Id = Convert.ToInt32(txtID.Text);
                cli.Nome = txtNome.Text;
                cli.Email = txtEmail.Text;

                DalHelper.Add(cli);

                ExibirDados();
                LimpaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("Informe os dados cliente a atualizar");
                return;
            }

            try
            {
                Cliente cli = new Cliente();
                cli.Id = Convert.ToInt32(txtID.Text);
                cli.Nome = txtNome.Text;
                cli.Email = txtEmail.Text;

                DalHelper.Update(cli);
                ExibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnExcluirDados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Informe o ID do cliente a ser Excluído");
                return;
            }
            try
            {
                int codigo = Convert.ToInt32(txtID.Text);
                DalHelper.Delete(codigo);
                ExibirDados();
                LimpaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnLocalizarDados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Informe o ID do cliente a ser Localizado");
                return;
            }
            try
            {
                DataTable dt = new DataTable();
                int codigo = Convert.ToInt32(txtID.Text);

                dt = DalHelper.GetCliente(codigo);
                dgvDados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            const string mensagem = "Deseja Encerrar ?";
            const string titulo = "Encerrar";
            var resultado = MessageBox.Show(mensagem, titulo,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private bool Valida()
        {
            if (string.IsNullOrEmpty(txtID.Text) && string.IsNullOrEmpty(txtNome.Text) && string.IsNullOrEmpty(txtEmail.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void LimpaDados()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
        }
        
        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDados.Rows[e.RowIndex];
                txtID.Text = row.Cells["Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
