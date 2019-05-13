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
    public partial class frmDelFunc : Form
    {
        public frmDelFunc()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Endereço";
            dataGridView1.Columns[3].HeaderText = "Cidade";
            dataGridView1.Columns[4].HeaderText = "UF";
            dataGridView1.Columns[5].HeaderText = "CEP";
            dataGridView1.Columns[6].HeaderText = "Telefone";
            dataGridView1.Columns[7].HeaderText = "Celular";
        }

        private void frmDelFunc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTheSoundForgerDataSet2.tbFuncionario' table. You can move, or remove it, as needed.
            this.tbFuncionarioTableAdapter.Fill(this.dbTheSoundForgerDataSet2.tbFuncionario);

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexão.conectar();
            cmd.Connection.Open();
            cmd.CommandText = "delete from tbFuncionario where ID_func = @id;";

            DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
            int indice = linhaAtual.Index;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = dataGridView1[0, indice].Value.ToString();
           
            if (MessageBox.Show("Deseja mesmo excluir esse funcionário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            cmd.Connection.Close();
            frmDelFunc_Load(sender, e);
        }
    }
}
