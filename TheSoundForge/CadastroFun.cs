using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheSoundForge
{
    public partial class frmCadastroFun : Form
    {
        public frmCadastroFun()
        {
            InitializeComponent();
            txtNome.MaxLength = 50;
            txtEnd.MaxLength = 50;
            txtCidade.MaxLength = 50;
            txtUF.MaxLength = 2;
            txtCEP.MaxLength = 8;
            txtTel.MaxLength = 9;
            txtCel.MaxLength = 9;
            txtPass.MaxLength = 20;
            txtUser.MaxLength = 10;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexão.conectar();
            cmd.Connection.Open();
            cmd.CommandText = "insert into tbFuncionario(Nome_func, End_func, Cidade_func, UF_func, CEP_func, Tel_func, Cel_func, usuario, senha)values(@nome, @end, @cid, @uf, @cep, @tel, @cel, @user, @pass);";

            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = txtNome.Text;
            cmd.Parameters.Add("@end", SqlDbType.VarChar, 50).Value = txtEnd.Text;
            cmd.Parameters.Add("@cid", SqlDbType.VarChar, 50).Value = txtCidade.Text;
            cmd.Parameters.Add("@uf", SqlDbType.Char, 2).Value = txtUF.Text;
            cmd.Parameters.Add("@cep", SqlDbType.Char, 8).Value = txtCEP.Text;
            cmd.Parameters.Add("@tel", SqlDbType.Char, 9).Value = txtTel.Text;
            cmd.Parameters.Add("@cel", SqlDbType.Char, 9).Value = txtCel.Text;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20).Value = txtPass.Text;
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 10).Value = txtUser.Text;

            if (txtNome.Text != "" && txtEnd.Text != "" && txtCidade.Text != "" && txtUF.Text != "" && txtCEP.Text != "" && txtUser.Text != "" && txtPass.Text != "")
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("O Funcionário foi adicionado", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK);
            }

            cmd.Connection.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtEnd.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUF.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtCel.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtNome.Focus();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //referente a todos os campos do frmCadastroFun
            if (e.KeyChar == 13)
            {
                btnSave_Click(sender, e);
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave_Click(sender, e);
            }
            //para limitar o TextBox a aceitar apenas números
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave_Click(sender, e);
            }
            //para limitar o TextBox a aceitar apenas caracteres não numéricos
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
