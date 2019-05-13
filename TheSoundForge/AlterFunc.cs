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
    public partial class frmAlterFunc : Form
    {
        public frmAlterFunc()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Endereço";
            dataGridView1.Columns[3].HeaderText = "Cidade";
            dataGridView1.Columns[4].HeaderText = "UF";
            dataGridView1.Columns[5].HeaderText = "CEP";
            dataGridView1.Columns[6].HeaderText = "Telefone";
            dataGridView1.Columns[7].HeaderText = "Celular";
            dataGridView1.Columns[8].HeaderText = "Usuário";
            dataGridView1.Columns[9].HeaderText = "Senha";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexão.conectar();
            cmd.Connection.Open();
            cmd.CommandText = "update tbFuncionario set Nome_func = @nome, End_func = @end, Cidade_func = @cid, UF_func = @uf, CEP_func = @cep, Tel_func = @tel, Cel_func = @cel, usuario = @user, senha = @pass where ID_func = @id;";

            DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
            int indice = linhaAtual.Index;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = dataGridView1[0, indice].Value.ToString();

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
                MessageBox.Show("O Funcionário foi Alterado", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK);
            }

            cmd.Connection.Close();
            frmAlterFunc_Load(sender, e);
        }

        private void btnRest_Click(object sender, EventArgs e)
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
            dataGridView1.ClearSelection();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlterFunc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTheSoundForgerDataSet1.tbFuncionario' table. You can move, or remove it, as needed.
            this.tbFuncionarioTableAdapter.Fill(this.dbTheSoundForgerDataSet1.tbFuncionario);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // vamos obter a linha da célula selecionada
            DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
            // vamos exibir o índice da linha atual
            int indice = linhaAtual.Index;
            txtNome.Text = dataGridView1[1, indice].Value.ToString().Trim();
            txtEnd.Text = dataGridView1[2, indice].Value.ToString().Trim();
            txtCidade.Text = dataGridView1[3, indice].Value.ToString().Trim();
            txtUF.Text = dataGridView1[4, indice].Value.ToString().Trim();
            txtCEP.Text = dataGridView1[5, indice].Value.ToString().Trim();
            txtTel.Text = dataGridView1[6, indice].Value.ToString().Trim();
            txtCel.Text = dataGridView1[7, indice].Value.ToString().Trim();
            txtPass.Text = dataGridView1[8, indice].Value.ToString().Trim();
            txtUser.Text = dataGridView1[9, indice].Value.ToString().Trim();

        }

        private void txtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave_Click(sender, e);
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave_Click(sender, e);
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave_Click(sender, e);
            }
            //!(char.IsDigit(e.KeyChar)) bloquei tudo q n é numerico
            //e.KeyChar != 8 permite o backspace
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

    }
}
