using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSoundForge
{
    public partial class frmConsultaFun : Form
    {
        public frmConsultaFun()
        {
            InitializeComponent();
            //remove a última linha, a em branco, da GridView
            dataGridView1.AllowUserToAddRows = false;
            //seleção de linha inteira
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //remove a primeira coluna, a em branco, da GridView
            dataGridView1.RowHeadersVisible = false;
            //oculta as colunas
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            //remove a seleção de multiplas linhas
            dataGridView1.MultiSelect = false;
            //modifica o nome da coluna
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Endereço";
            dataGridView1.Columns[3].HeaderText = "Cidade";
            dataGridView1.Columns[4].HeaderText = "UF";
            dataGridView1.Columns[5].HeaderText = "CEP";
            dataGridView1.Columns[6].HeaderText = "Telefone";
            dataGridView1.Columns[7].HeaderText = "Celular";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTheSoundForgerDataSet.tbFuncionario' table. You can move, or remove it, as needed.
            this.tbFuncionarioTableAdapter.Fill(this.dbTheSoundForgerDataSet.tbFuncionario);

        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            Consulta_Load(sender, e);
        }
    }
}
